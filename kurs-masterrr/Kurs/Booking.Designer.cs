namespace Kurs
{
    partial class Booking
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
            this.dataGridView_clients = new System.Windows.Forms.DataGridView();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_reservation_complete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_rooms = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_clients
            // 
            this.dataGridView_clients.AllowUserToAddRows = false;
            this.dataGridView_clients.AllowUserToDeleteRows = false;
            this.dataGridView_clients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clients.Location = new System.Drawing.Point(20, 34);
            this.dataGridView_clients.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView_clients.Name = "dataGridView_clients";
            this.dataGridView_clients.ReadOnly = true;
            this.dataGridView_clients.Size = new System.Drawing.Size(783, 238);
            this.dataGridView_clients.TabIndex = 0;
            this.dataGridView_clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(930, 218);
            this.textBox_info.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(249, 125);
            this.textBox_info.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата с:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата по:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(844, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Доп. информация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Клиент";
            // 
            // button_reservation_complete
            // 
            this.button_reservation_complete.BackColor = System.Drawing.Color.White;
            this.button_reservation_complete.ForeColor = System.Drawing.Color.Maroon;
            this.button_reservation_complete.Location = new System.Drawing.Point(930, 368);
            this.button_reservation_complete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_reservation_complete.Name = "button_reservation_complete";
            this.button_reservation_complete.Size = new System.Drawing.Size(172, 41);
            this.button_reservation_complete.TabIndex = 8;
            this.button_reservation_complete.Text = "забронировать";
            this.button_reservation_complete.UseVisualStyleBackColor = false;
            this.button_reservation_complete.Click += new System.EventHandler(this.button_reservation_complete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(930, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(930, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(249, 25);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dataGridView_rooms
            // 
            this.dataGridView_rooms.AllowUserToAddRows = false;
            this.dataGridView_rooms.AllowUserToDeleteRows = false;
            this.dataGridView_rooms.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rooms.Location = new System.Drawing.Point(20, 329);
            this.dataGridView_rooms.Name = "dataGridView_rooms";
            this.dataGridView_rooms.ReadOnly = true;
            this.dataGridView_rooms.RowTemplate.Height = 24;
            this.dataGridView_rooms.Size = new System.Drawing.Size(783, 238);
            this.dataGridView_rooms.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(844, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Статус";
            // 
            // comboBox_status
            // 
            this.comboBox_status.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Оплачено",
            "Не оплачено"});
            this.comboBox_status.Location = new System.Drawing.Point(930, 135);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(249, 28);
            this.comboBox_status.TabIndex = 14;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1204, 598);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_rooms);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_reservation_complete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.dataGridView_clients);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Booking";
            this.Text = "Бронирование номеров";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reservation_complete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_status;
        public System.Windows.Forms.DataGridView dataGridView_clients;
        public System.Windows.Forms.DataGridView dataGridView_rooms;
    }
}