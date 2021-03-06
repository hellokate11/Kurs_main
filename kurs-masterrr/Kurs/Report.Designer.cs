﻿namespace Kurs
{
    partial class Report
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_graphic = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(23, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 407);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "по";
            // 
            // button_graphic
            // 
            this.button_graphic.ForeColor = System.Drawing.Color.Maroon;
            this.button_graphic.Location = new System.Drawing.Point(51, 529);
            this.button_graphic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_graphic.Name = "button_graphic";
            this.button_graphic.Size = new System.Drawing.Size(240, 40);
            this.button_graphic.TabIndex = 5;
            this.button_graphic.Text = "Сформировать график";
            this.button_graphic.UseVisualStyleBackColor = true;
            // 
            // button_excel
            // 
            this.button_excel.ForeColor = System.Drawing.Color.Maroon;
            this.button_excel.Location = new System.Drawing.Point(485, 529);
            this.button_excel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(240, 40);
            this.button_excel.TabIndex = 6;
            this.button_excel.Text = "Выгрузить в EXCEL";
            this.button_excel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(51, 55);
            this.dateTimePicker_from.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(331, 25);
            this.dateTimePicker_from.TabIndex = 7;
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(485, 55);
            this.dateTimePicker_to.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(331, 25);
            this.dateTimePicker_to.TabIndex = 8;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(853, 615);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_graphic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Report";
            this.Text = "Отчеты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_graphic;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
    }
}