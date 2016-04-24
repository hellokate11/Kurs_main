namespace Kurs
{
    partial class Services
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
            this.button1_add = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_del_serv = new System.Windows.Forms.Button();
            this.button_edit_serv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_add
            // 
            this.button1_add.ForeColor = System.Drawing.Color.Maroon;
            this.button1_add.Location = new System.Drawing.Point(125, 395);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(137, 33);
            this.button1_add.TabIndex = 1;
            this.button1_add.Text = "Добавить";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(64, 349);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(124, 25);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(222, 349);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(124, 25);
            this.textBox_cost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(220, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Стоимость";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(816, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_del_serv
            // 
            this.button_del_serv.ForeColor = System.Drawing.Color.Maroon;
            this.button_del_serv.Location = new System.Drawing.Point(459, 345);
            this.button_del_serv.Name = "button_del_serv";
            this.button_del_serv.Size = new System.Drawing.Size(137, 33);
            this.button_del_serv.TabIndex = 6;
            this.button_del_serv.Text = "Удалить";
            this.button_del_serv.UseVisualStyleBackColor = true;
            // 
            // button_edit_serv
            // 
            this.button_edit_serv.ForeColor = System.Drawing.Color.Maroon;
            this.button_edit_serv.Location = new System.Drawing.Point(459, 395);
            this.button_edit_serv.Name = "button_edit_serv";
            this.button_edit_serv.Size = new System.Drawing.Size(137, 33);
            this.button_edit_serv.TabIndex = 7;
            this.button_edit_serv.Text = "Редактировать";
            this.button_edit_serv.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(851, 481);
            this.Controls.Add(this.button_edit_serv);
            this.Controls.Add(this.button_del_serv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_del_serv;
        private System.Windows.Forms.Button button_edit_serv;
    }
}