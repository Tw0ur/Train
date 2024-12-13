using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train.Models;
using Train.Repositories;

namespace Train
{
    public partial class CreateEditSchedule : Form
    {
        public CreateEditSchedule()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void CreateEditSchedule_Load(object sender, EventArgs e)
        {

        }


        private int schedule_id = 0;

        public void EditSchedule(Schedule schedule)
        {
            this.Text = "Редактирование расписания";
            this.lbTitle.Text = "Редактирование расписания";

            this.lbID.Text = "" + schedule.ScheduleID;
            this.tbTrainID.Text = schedule.TrainID.ToString();
            this.dtpDepartureDate.Value = schedule.DepartureDate;
            this.tbDepartureTime.Text = schedule.DepartureTime.ToString();
            this.tbDeparturePlace.Text = schedule.DeparturePlace;
            this.tbArrivalTime.Text = schedule.ArrivalTime.ToString();
            this.tbArrivalPlace.Text = schedule.ArrivalPlace;
            this.tbRoute.Text = schedule.Route;
            this.tbTicketPrice.Text = schedule.TicketPrice.ToString();

            this.schedule_id = schedule.ScheduleID;
        }



        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSaveClick_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.ScheduleID = schedule_id;
            schedule.TrainID = Convert.ToInt32(this.tbTrainID.Text);
            schedule.DepartureDate = this.dtpDepartureDate.Value;
            schedule.DepartureTime = TimeSpan.Parse(this.tbDepartureTime.Text);
            schedule.DeparturePlace = this.tbDeparturePlace.Text;
            schedule.ArrivalTime = TimeSpan.Parse(this.tbArrivalTime.Text);
            schedule.ArrivalPlace = this.tbArrivalPlace.Text;
            schedule.Route = this.tbRoute.Text;
            schedule.TicketPrice = Convert.ToDecimal(this.tbTicketPrice.Text);

            var repo = new ScheduleRepository();

            if (schedule_id == 0)
            {
                repo.CreateSchedule(schedule);
            }
            else
            {
                repo.UpdateSchedule(schedule);
            }

            this.DialogResult = DialogResult.OK;
        }

        //private void tbDeparturePlace_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
