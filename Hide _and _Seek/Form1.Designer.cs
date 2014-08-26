namespace Hide__and__Seek
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
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThrougthTheDoor = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.hidle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(34, 32);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(442, 212);
            this.description.TabIndex = 1;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(34, 271);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(120, 23);
            this.goHere.TabIndex = 2;
            this.goHere.Text = "Go here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Visible = false;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(214, 273);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(262, 21);
            this.exits.TabIndex = 3;
            this.exits.Visible = false;
            // 
            // goThrougthTheDoor
            // 
            this.goThrougthTheDoor.Location = new System.Drawing.Point(34, 300);
            this.goThrougthTheDoor.Name = "goThrougthTheDoor";
            this.goThrougthTheDoor.Size = new System.Drawing.Size(410, 23);
            this.goThrougthTheDoor.TabIndex = 4;
            this.goThrougthTheDoor.Text = "Go throuth the door";
            this.goThrougthTheDoor.UseVisualStyleBackColor = true;
            this.goThrougthTheDoor.Visible = false;
            this.goThrougthTheDoor.Click += new System.EventHandler(this.goThrougthTheDoor_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(34, 330);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(410, 23);
            this.check.TabIndex = 5;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hidle
            // 
            this.hidle.Location = new System.Drawing.Point(34, 360);
            this.hidle.Name = "hidle";
            this.hidle.Size = new System.Drawing.Size(410, 23);
            this.hidle.TabIndex = 6;
            this.hidle.Text = "Hidle";
            this.hidle.UseVisualStyleBackColor = true;
            this.hidle.Click += new System.EventHandler(this.hidle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 453);
            this.Controls.Add(this.hidle);
            this.Controls.Add(this.check);
            this.Controls.Add(this.goThrougthTheDoor);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThrougthTheDoor;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hidle;
    }
}

