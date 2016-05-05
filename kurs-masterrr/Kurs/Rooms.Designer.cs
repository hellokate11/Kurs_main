namespace Kurs
{
    partial class Rooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_book = new System.Windows.Forms.Button();
            this.button_checkedin = new System.Windows.Forms.Button();
            this.button_checkedout = new System.Windows.Forms.Button();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addRoom = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_book
            // 
            this.button_book.BackColor = System.Drawing.Color.White;
            this.button_book.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book.ForeColor = System.Drawing.Color.Maroon;
            this.button_book.Location = new System.Drawing.Point(350, 357);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(132, 34);
            this.button_book.TabIndex = 1;
            this.button_book.Text = "Забронировать";
            this.button_book.UseVisualStyleBackColor = false;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_checkedin
            // 
            this.button_checkedin.BackColor = System.Drawing.Color.White;
            this.button_checkedin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkedin.ForeColor = System.Drawing.Color.Maroon;
            this.button_checkedin.Location = new System.Drawing.Point(191, 357);
            this.button_checkedin.Name = "button_checkedin";
            this.button_checkedin.Size = new System.Drawing.Size(132, 34);
            this.button_checkedin.TabIndex = 2;
            this.button_checkedin.Text = "Сдать";
            this.button_checkedin.UseVisualStyleBackColor = false;
            this.button_checkedin.Click += new System.EventHandler(this.button_checkedin_Click);
            // 
            // button_checkedout
            // 
            this.button_checkedout.BackColor = System.Drawing.Color.White;
            this.button_checkedout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkedout.ForeColor = System.Drawing.Color.Maroon;
            this.button_checkedout.Location = new System.Drawing.Point(39, 357);
            this.button_checkedout.Name = "button_checkedout";
            this.button_checkedout.Size = new System.Drawing.Size(132, 34);
            this.button_checkedout.TabIndex = 3;
            this.button_checkedout.Text = "Освободить";
            this.button_checkedout.UseVisualStyleBackColor = false;
            this.button_checkedout.Click += new System.EventHandler(this.button_checkedout_Click);
            // 
            // textBox_cost
            // 
            this.textBox_cost.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cost.Location = new System.Drawing.Point(685, 208);
            this.textBox_cost.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(180, 25);
            this.textBox_cost.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(680, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип номера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(682, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Цена";
            // 
            // button_addRoom
            // 
            this.button_addRoom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addRoom.ForeColor = System.Drawing.Color.Maroon;
            this.button_addRoom.Location = new System.Drawing.Point(685, 264);
            this.button_addRoom.Margin = new System.Windows.Forms.Padding(2);
            this.button_addRoom.Name = "button_addRoom";
            this.button_addRoom.Size = new System.Drawing.Size(132, 34);
            this.button_addRoom.TabIndex = 10;
            this.button_addRoom.Text = "Добавить";
            this.button_addRoom.UseVisualStyleBackColor = true;
            this.button_addRoom.Click += new System.EventHandler(this.button_addRoom_Click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.White;
            this.button_del.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del.ForeColor = System.Drawing.Color.Maroon;
            this.button_del.Location = new System.Drawing.Point(500, 357);
            this.button_del.Margin = new System.Windows.Forms.Padding(2);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(132, 34);
            this.button_del.TabIndex = 11;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(680, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Присвоение №";
            // 
            // textBox_number
            // 
            this.textBox_number.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_number.Location = new System.Drawing.Point(683, 72);
            this.textBox_number.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(182, 25);
            this.textBox_number.TabIndex = 13;
            // 
            // comboBox_type
            // 
            this.comboBox_type.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Стандарт Одноместный",
            "Стандарт Двухместный",
            "Стандарт Семейный",
            "Полулюкс",
            "Люкс",
            "Апартаменты"});
            this.comboBox_type.Location = new System.Drawing.Point(683, 133);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(182, 28);
            this.comboBox_type.TabIndex = 14;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(888, 472);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_addRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.button_checkedout);
            this.Controls.Add(this.button_checkedin);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rooms";
            this.Text = "Номера";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_checkedin;
        private System.Windows.Forms.Button button_checkedout;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_addRoom;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.ComboBox comboBox_type;
    }
}