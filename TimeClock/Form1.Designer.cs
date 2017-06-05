namespace TimeClock
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.ClockIn = new System.Windows.Forms.Button();
            this.ClockOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(64, 79);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 17);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "label1";
            // 
            // ClockIn
            // 
            this.ClockIn.Location = new System.Drawing.Point(67, 174);
            this.ClockIn.Name = "ClockIn";
            this.ClockIn.Size = new System.Drawing.Size(75, 23);
            this.ClockIn.TabIndex = 1;
            this.ClockIn.Text = "Clock In";
            this.ClockIn.UseVisualStyleBackColor = true;
            this.ClockIn.Click += new System.EventHandler(this.ClockIn_Click);
            // 
            // ClockOutButton
            // 
            this.ClockOutButton.Location = new System.Drawing.Point(149, 174);
            this.ClockOutButton.Name = "ClockOutButton";
            this.ClockOutButton.Size = new System.Drawing.Size(82, 23);
            this.ClockOutButton.TabIndex = 2;
            this.ClockOutButton.Text = "Clock Out";
            this.ClockOutButton.UseVisualStyleBackColor = true;
            this.ClockOutButton.Click += new System.EventHandler(this.ClockOutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.ClockOutButton);
            this.Controls.Add(this.ClockIn);
            this.Controls.Add(this.DateLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button ClockIn;
        private System.Windows.Forms.Button ClockOutButton;
    }
}

