using System.Data;
using Train.Repositories;

namespace Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadSchedules();

            this.BackgroundImage = Image.FromFile("C:\\Users\\user\\source\\repos\\Train\\Train\\Models\\nastol.com.ua_358956.jpg");

            tbSearch.KeyDown += TbSearch_KeyDown;
            tbSearchTime.KeyDown += TbSearch_KeyDown;
            cbTrainID.SelectedIndexChanged += CbTrainID_SelectedIndexChanged;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int t = 0;
        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                ReadSchedules();
            }
        }

        private void CbTrainID_SelectedIndexChanged(object sender, EventArgs e)
        {
            t = 1;
            ReadSchedules();
        }
        private void ReadSchedules()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("ID поезда");
            dataTable.Columns.Add("Дата отправления");
            dataTable.Columns.Add("Время отправления");
            dataTable.Columns.Add("Место отправления");
            dataTable.Columns.Add("Время прибытия");
            dataTable.Columns.Add("Место прибытия");
            dataTable.Columns.Add("Маршрут");
            dataTable.Columns.Add("Цена билета");

            var repo = new ScheduleRepository();
            var schedules = repo.GetSchedules();

            foreach (var schedule in schedules)
            {
                var row = dataTable.NewRow();

                row["ID"] = schedule.ScheduleID;
                row["ID поезда"] = schedule.TrainID;
                row["Дата отправления"] = schedule.DepartureDate.ToShortDateString();
                row["Время отправления"] = schedule.DepartureTime.ToString();
                row["Место отправления"] = schedule.DeparturePlace;
                row["Время прибытия"] = schedule.ArrivalTime.ToString();
                row["Место прибытия"] = schedule.ArrivalPlace;
                row["Маршрут"] = schedule.Route;
                row["Цена билета"] = schedule.TicketPrice;

                dataTable.Rows.Add(row);
            }
            if (t != 1)
            {
                FillTrainIDComboBox(dataTable);
            }
            if (t == 1)
            {
                t = 0;
            }


            ApplyFilters(dataTable);
        }








        private void btnDelSchedule_Click(object sender, EventArgs e)
        {
            var val = this.schedulesTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int schedule_id = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Вы готовы удалить расписание?", "Удалить расписание", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new ScheduleRepository();
            repo.DeleteSchedule(schedule_id);

            ReadSchedules();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            CreateEditSchedule form = new CreateEditSchedule();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadSchedules();
            }
        }

        private void btnEditSchedule_Click_1(object sender, EventArgs e)
        {
            var val = this.schedulesTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int schedule_id = int.Parse(val);

            var repo = new ScheduleRepository();
            var schedule = repo.GetSchedule(schedule_id);

            if (schedule == null) return;

            CreateEditSchedule form = new CreateEditSchedule();
            form.EditSchedule(schedule);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadSchedules();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
        }


        private void ApplyFilters(DataTable dataTable)
        {
            string filter = "";

            if (!string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                filter += $"[Место отправления] LIKE '%{tbSearch.Text}%'";
            }

            if (!string.IsNullOrWhiteSpace(tbSearchTime.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"[Место прибытия] LIKE '%{tbSearchTime.Text}%'";
            }

            if (!string.IsNullOrWhiteSpace(cbTrainID.SelectedItem?.ToString()))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += $"[ID поезда] = '{cbTrainID.SelectedItem}'";
            }

            if (!string.IsNullOrEmpty(filter))
            {
                DataView view = new DataView(dataTable);
                view.RowFilter = filter;
                this.schedulesTable.DataSource = view;
            }
            else
            {
                this.schedulesTable.DataSource = dataTable;
            }
        }

        private void FillTrainIDComboBox(DataTable dataTable)
        {
            cbTrainID.Items.Clear();
            cbTrainID.Items.Add("");

            var trainIDs = dataTable.AsEnumerable()
                .Select(row => row["ID поезда"].ToString())
                .Distinct()
                .OrderBy(id => id);

            foreach (var trainID in trainIDs)
            {
                cbTrainID.Items.Add(trainID);
            }

            cbTrainID.SelectedIndex = 0;
        }

        private void schedulesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
