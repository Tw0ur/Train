namespace Train
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            schedulesTable = new DataGridView();
            btnAddSchedule = new Button();
            btnEditSchedule = new Button();
            btnDelSchedule = new Button();
            tbSearch = new TextBox();
            tbSearchTime = new TextBox();
            cbTrainID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)schedulesTable).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI", 24F);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(12, -1);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(974, 48);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Расписание поездов";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // schedulesTable
            // 
            schedulesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            schedulesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schedulesTable.Location = new Point(12, 102);
            schedulesTable.MultiSelect = false;
            schedulesTable.Name = "schedulesTable";
            schedulesTable.RowHeadersVisible = false;
            schedulesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            schedulesTable.Size = new Size(974, 462);
            schedulesTable.TabIndex = 1;
            schedulesTable.CellContentClick += schedulesTable_CellContentClick;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Font = new Font("Segoe UI", 12F);
            btnAddSchedule.Location = new Point(12, 50);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(132, 46);
            btnAddSchedule.TabIndex = 2;
            btnAddSchedule.Text = "Добавить";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // btnEditSchedule
            // 
            btnEditSchedule.Font = new Font("Segoe UI", 12F);
            btnEditSchedule.Location = new Point(150, 50);
            btnEditSchedule.Name = "btnEditSchedule";
            btnEditSchedule.Size = new Size(132, 46);
            btnEditSchedule.TabIndex = 3;
            btnEditSchedule.Text = "Изменить";
            btnEditSchedule.UseVisualStyleBackColor = true;
            btnEditSchedule.Click += btnEditSchedule_Click_1;
            // 
            // btnDelSchedule
            // 
            btnDelSchedule.Font = new Font("Segoe UI", 12F);
            btnDelSchedule.Location = new Point(288, 50);
            btnDelSchedule.Name = "btnDelSchedule";
            btnDelSchedule.Size = new Size(132, 46);
            btnDelSchedule.TabIndex = 4;
            btnDelSchedule.Text = "Удалить";
            btnDelSchedule.UseVisualStyleBackColor = true;
            btnDelSchedule.Click += btnDelSchedule_Click;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 12F);
            tbSearch.Location = new Point(594, 60);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(133, 29);
            tbSearch.TabIndex = 5;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // tbSearchTime
            // 
            tbSearchTime.Font = new Font("Segoe UI", 12F);
            tbSearchTime.Location = new Point(733, 60);
            tbSearchTime.Name = "tbSearchTime";
            tbSearchTime.Size = new Size(121, 29);
            tbSearchTime.TabIndex = 6;
            // 
            // cbTrainID
            // 
            cbTrainID.Font = new Font("Segoe UI", 12F);
            cbTrainID.FormattingEnabled = true;
            cbTrainID.Location = new Point(864, 60);
            cbTrainID.Margin = new Padding(7, 7, 3, 3);
            cbTrainID.Name = "cbTrainID";
            cbTrainID.Size = new Size(121, 29);
            cbTrainID.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 576);
            Controls.Add(cbTrainID);
            Controls.Add(tbSearchTime);
            Controls.Add(tbSearch);
            Controls.Add(btnDelSchedule);
            Controls.Add(btnEditSchedule);
            Controls.Add(btnAddSchedule);
            Controls.Add(schedulesTable);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)schedulesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private DataGridView schedulesTable;
        private Button btnAddSchedule;
        private Button btnEditSchedule;
        private Button btnDelSchedule;
        private TextBox tbSearch;
        private TextBox tbSearchTime;
        private ComboBox cbTrainID;
    }
}
