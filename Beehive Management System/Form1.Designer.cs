﻿namespace Beehive_Management_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.report = new System.Windows.Forms.TextBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nextShift = new System.Windows.Forms.Button();
            this.assignJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Worker bee job";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(16, 82);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(194, 21);
            this.workerBeeJob.TabIndex = 2;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(16, 161);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(397, 185);
            this.report.TabIndex = 3;
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(232, 57);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(51, 20);
            this.shifts.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shifts";
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(319, 57);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(94, 79);
            this.nextShift.TabIndex = 6;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(16, 120);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(204, 25);
            this.assignJob.TabIndex = 7;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 372);
            this.Controls.Add(this.assignJob);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.report);
            this.Controls.Add(this.workerBeeJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.Button assignJob;
    }
}

