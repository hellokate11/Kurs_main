namespace Kurs
{
    partial class Bill
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
            this.cheque = new System.Windows.Forms.DataGridView();
            this.services = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.services)).BeginInit();
            this.SuspendLayout();
            // 
            // cheque
            // 
            this.cheque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheque.Location = new System.Drawing.Point(34, 42);
            this.cheque.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(900, 278);
            this.cheque.TabIndex = 0;
            // 
            // services
            // 
            this.services.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.services.Location = new System.Drawing.Point(34, 369);
            this.services.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(900, 278);
            this.services.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Счёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(31, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Услуги";
            // 
            // button_bill
            // 
            this.button_bill.ForeColor = System.Drawing.Color.Maroon;
            this.button_bill.Location = new System.Drawing.Point(546, 662);
            this.button_bill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_bill.Name = "button_bill";
            this.button_bill.Size = new System.Drawing.Size(197, 37);
            this.button_bill.TabIndex = 4;
            this.button_bill.Text = "Сформировать счёт";
            this.button_bill.UseVisualStyleBackColor = true;
            this.button_bill.Click += new System.EventHandler(this.button_bill_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(952, 712);
            this.Controls.Add(this.button_bill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.services);
            this.Controls.Add(this.cheque);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Bill";
            this.Text = "Формирование счёта";
            ((System.ComponentModel.ISupportInitialize)(this.cheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cheque;
        private System.Windows.Forms.DataGridView services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_bill;
    }
}