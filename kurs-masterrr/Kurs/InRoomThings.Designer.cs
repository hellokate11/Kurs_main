namespace Kurs
{
    partial class InRoomThings
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
            this.button_add_thing = new System.Windows.Forms.Button();
            this.button_transfer_thing = new System.Windows.Forms.Button();
            this.textBox_nameOfthing = new System.Windows.Forms.TextBox();
            this.costOFthing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_add_thing
            // 
            this.button_add_thing.ForeColor = System.Drawing.Color.Maroon;
            this.button_add_thing.Location = new System.Drawing.Point(82, 621);
            this.button_add_thing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_add_thing.Name = "button_add_thing";
            this.button_add_thing.Size = new System.Drawing.Size(125, 32);
            this.button_add_thing.TabIndex = 1;
            this.button_add_thing.Text = "Добавить";
            this.button_add_thing.UseVisualStyleBackColor = true;
            this.button_add_thing.Click += new System.EventHandler(this.button_add_thing_Click);
            // 
            // button_transfer_thing
            // 
            this.button_transfer_thing.ForeColor = System.Drawing.Color.Maroon;
            this.button_transfer_thing.Location = new System.Drawing.Point(630, 421);
            this.button_transfer_thing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_transfer_thing.Name = "button_transfer_thing";
            this.button_transfer_thing.Size = new System.Drawing.Size(133, 60);
            this.button_transfer_thing.TabIndex = 2;
            this.button_transfer_thing.Text = "Изменить статус вещи";
            this.button_transfer_thing.UseVisualStyleBackColor = true;
            // 
            // textBox_nameOfthing
            // 
            this.textBox_nameOfthing.Location = new System.Drawing.Point(82, 456);
            this.textBox_nameOfthing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_nameOfthing.Name = "textBox_nameOfthing";
            this.textBox_nameOfthing.Size = new System.Drawing.Size(225, 25);
            this.textBox_nameOfthing.TabIndex = 3;
            // 
            // costOFthing
            // 
            this.costOFthing.Location = new System.Drawing.Point(82, 511);
            this.costOFthing.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.costOFthing.Name = "costOFthing";
            this.costOFthing.Size = new System.Drawing.Size(225, 25);
            this.costOFthing.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(82, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(80, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(82, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Добавление вещей в резерв";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(85, 570);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(222, 25);
            this.textBox_status.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(82, 546);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус";
            // 
            // InRoomThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(811, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costOFthing);
            this.Controls.Add(this.textBox_nameOfthing);
            this.Controls.Add(this.button_transfer_thing);
            this.Controls.Add(this.button_add_thing);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InRoomThings";
            this.Text = "Вещи в номерах";
            this.Load += new System.EventHandler(this.InRoomThings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add_thing;
        private System.Windows.Forms.Button button_transfer_thing;
        private System.Windows.Forms.TextBox textBox_nameOfthing;
        private System.Windows.Forms.TextBox costOFthing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label4;
    }
}