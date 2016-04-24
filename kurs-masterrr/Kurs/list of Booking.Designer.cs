namespace Kurs
{
    partial class list_of_Booking
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
            this.dataGridView_booking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_booking
            // 
            this.dataGridView_booking.AllowUserToAddRows = false;
            this.dataGridView_booking.AllowUserToDeleteRows = false;
            this.dataGridView_booking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_booking.Location = new System.Drawing.Point(14, 13);
            this.dataGridView_booking.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView_booking.Name = "dataGridView_booking";
            this.dataGridView_booking.ReadOnly = true;
            this.dataGridView_booking.Size = new System.Drawing.Size(841, 429);
            this.dataGridView_booking.TabIndex = 1;
            // 
            // list_of_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(871, 474);
            this.Controls.Add(this.dataGridView_booking);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "list_of_Booking";
            this.Text = "Список броней";
            this.Load += new System.EventHandler(this.list_of_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_booking;
    }
}