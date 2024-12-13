namespace Train
{
    partial class CreateEditSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new Label();
            btnSaveClick = new Button();
            lbID = new Label();
            lbTrainID = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label1 = new Label();
            dtpDepartureDate = new DateTimePicker();
            tbTrainID = new TextBox();
            tbDepartureTime = new TextBox();
            tbDeparturePlace = new TextBox();
            tbArrivalTime = new TextBox();
            tbArrivalPlace = new TextBox();
            tbRoute = new TextBox();
            tbTicketPrice = new TextBox();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Font = new Font("Segoe UI", 18F);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(776, 33);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Создать расписание";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSaveClick
            // 
            btnSaveClick.Font = new Font("Segoe UI", 12F);
            btnSaveClick.Location = new Point(314, 381);
            btnSaveClick.Name = "btnSaveClick";
            btnSaveClick.Size = new Size(197, 57);
            btnSaveClick.TabIndex = 1;
            btnSaveClick.Text = "Сохранить";
            btnSaveClick.UseVisualStyleBackColor = true;
            btnSaveClick.Click += btnSaveClick_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(314, 70);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 15);
            lbID.TabIndex = 2;
            lbID.Click += lbID_Click;
            // 
            // lbTrainID
            // 
            lbTrainID.AutoSize = true;
            lbTrainID.Location = new Point(169, 103);
            lbTrainID.Name = "lbTrainID";
            lbTrainID.Size = new Size(58, 15);
            lbTrainID.TabIndex = 3;
            lbTrainID.Text = "ID поезда";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 136);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата отправления";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 168);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 5;
            label4.Text = "Время отправления";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 199);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 6;
            label5.Text = "Место отправления";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 229);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 7;
            label6.Text = "Время прибытия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(169, 259);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 8;
            label7.Text = "Место прибытия";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 294);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 9;
            label8.Text = "Маршрут";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 329);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 10;
            label9.Text = "Цена билета";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 70);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 11;
            label1.Text = "ID расписания";
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Location = new Point(314, 130);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new Size(200, 23);
            dtpDepartureDate.TabIndex = 12;
            // 
            // tbTrainID
            // 
            tbTrainID.Location = new Point(314, 101);
            tbTrainID.Name = "tbTrainID";
            tbTrainID.Size = new Size(200, 23);
            tbTrainID.TabIndex = 13;
            // 
            // tbDepartureTime
            // 
            tbDepartureTime.Location = new Point(314, 165);
            tbDepartureTime.Name = "tbDepartureTime";
            tbDepartureTime.Size = new Size(200, 23);
            tbDepartureTime.TabIndex = 14;
            // 
            // tbDeparturePlace
            // 
            tbDeparturePlace.Location = new Point(314, 196);
            tbDeparturePlace.Name = "tbDeparturePlace";
            tbDeparturePlace.Size = new Size(200, 23);
            tbDeparturePlace.TabIndex = 15;
            // 
            // tbArrivalTime
            // 
            tbArrivalTime.Location = new Point(314, 226);
            tbArrivalTime.Name = "tbArrivalTime";
            tbArrivalTime.Size = new Size(200, 23);
            tbArrivalTime.TabIndex = 16;
            // 
            // tbArrivalPlace
            // 
            tbArrivalPlace.Location = new Point(314, 255);
            tbArrivalPlace.Name = "tbArrivalPlace";
            tbArrivalPlace.Size = new Size(200, 23);
            tbArrivalPlace.TabIndex = 17;
            // 
            // tbRoute
            // 
            tbRoute.Location = new Point(314, 291);
            tbRoute.Name = "tbRoute";
            tbRoute.Size = new Size(200, 23);
            tbRoute.TabIndex = 18;
            // 
            // tbTicketPrice
            // 
            tbTicketPrice.Location = new Point(314, 326);
            tbTicketPrice.Name = "tbTicketPrice";
            tbTicketPrice.Size = new Size(200, 23);
            tbTicketPrice.TabIndex = 19;
            // 
            // CreateEditSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbTicketPrice);
            Controls.Add(tbRoute);
            Controls.Add(tbArrivalPlace);
            Controls.Add(tbArrivalTime);
            Controls.Add(tbDeparturePlace);
            Controls.Add(tbDepartureTime);
            Controls.Add(tbTrainID);
            Controls.Add(dtpDepartureDate);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbTrainID);
            Controls.Add(lbID);
            Controls.Add(btnSaveClick);
            Controls.Add(lbTitle);
            Name = "CreateEditSchedule";
            Text = "Создания расписания";
            Load += CreateEditSchedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btnSaveClick;
        private Label lbID;
        private Label lbTrainID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label1;
        private DateTimePicker dtpDepartureDate;
        private TextBox tbTrainID;
        private TextBox tbDepartureTime;
        private TextBox tbDeparturePlace;
        private TextBox tbArrivalTime;
        private TextBox tbArrivalPlace;
        private TextBox tbRoute;
        private TextBox tbTicketPrice;
    }
}