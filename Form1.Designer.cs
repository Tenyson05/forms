namespace forms1
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
            this.name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.dateOverTime = new System.Windows.Forms.DateTimePicker();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "txtName";
            this.txtName.Location = new System.Drawing.Point(44, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 1;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(316, 28);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(35, 13);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours";
            this.hoursLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateOverTime
            // 
            this.dateOverTime.AccessibleName = "dateOverTime";
            this.dateOverTime.Location = new System.Drawing.Point(533, 60);
            this.dateOverTime.Name = "dateOverTime";
            this.dateOverTime.Size = new System.Drawing.Size(200, 20);
            this.dateOverTime.TabIndex = 3;
            this.dateOverTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtHours
            // 
            this.txtHours.AccessibleName = "txtHours";
            this.txtHours.Location = new System.Drawing.Point(319, 60);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(124, 20);
            this.txtHours.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.dateOverTime);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.DateTimePicker dateOverTime;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button button1;
    }
}

