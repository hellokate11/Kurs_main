namespace Kurs
{
    partial class Clients
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
            this.button_del_cl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_edit_client = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(839, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_del_cl
            // 
            this.button_del_cl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button_del_cl.ForeColor = System.Drawing.Color.Maroon;
            this.button_del_cl.Location = new System.Drawing.Point(651, 403);
            this.button_del_cl.Name = "button_del_cl";
            this.button_del_cl.Size = new System.Drawing.Size(139, 36);
            this.button_del_cl.TabIndex = 6;
            this.button_del_cl.Text = "удалить гостя";
            this.button_del_cl.UseVisualStyleBackColor = true;
            this.button_del_cl.Click += new System.EventHandler(this.button_del_cl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(319, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "добавить гостя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_edit_client
            // 
            this.button_edit_client.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.button_edit_client.ForeColor = System.Drawing.Color.Maroon;
            this.button_edit_client.Location = new System.Drawing.Point(484, 403);
            this.button_edit_client.Name = "button_edit_client";
            this.button_edit_client.Size = new System.Drawing.Size(139, 36);
            this.button_edit_client.TabIndex = 9;
            this.button_edit_client.Text = "редактирвать";
            this.button_edit_client.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.button_edit_client);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_del_cl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clients";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_del_cl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_edit_client;
    }
}