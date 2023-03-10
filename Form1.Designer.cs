namespace ColdEmailTracker
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
            this.Name_Text_Box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Company_Text_Box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Position_Text_Box = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FollowUpPicker = new System.Windows.Forms.DateTimePicker();
            this.EmailDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AttachResume = new System.Windows.Forms.OpenFileDialog();
            this.Attach_Resume = new System.Windows.Forms.Button();
            this.ResumeFileName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_Text_Box
            // 
            this.Name_Text_Box.Location = new System.Drawing.Point(129, 49);
            this.Name_Text_Box.Name = "Name_Text_Box";
            this.Name_Text_Box.Size = new System.Drawing.Size(481, 29);
            this.Name_Text_Box.TabIndex = 0;
            this.Name_Text_Box.Text = "";
            this.Name_Text_Box.TextChanged += new System.EventHandler(this.Name_Text_Box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lead Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Company_Text_Box
            // 
            this.Company_Text_Box.Location = new System.Drawing.Point(129, 112);
            this.Company_Text_Box.Name = "Company_Text_Box";
            this.Company_Text_Box.Size = new System.Drawing.Size(481, 29);
            this.Company_Text_Box.TabIndex = 2;
            this.Company_Text_Box.Text = "";
            this.Company_Text_Box.TextChanged += new System.EventHandler(this.Company_Text_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label2.Location = new System.Drawing.Point(124, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lead Company";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Position_Text_Box
            // 
            this.Position_Text_Box.Location = new System.Drawing.Point(129, 181);
            this.Position_Text_Box.Name = "Position_Text_Box";
            this.Position_Text_Box.Size = new System.Drawing.Size(481, 29);
            this.Position_Text_Box.TabIndex = 4;
            this.Position_Text_Box.Text = "";
            this.Position_Text_Box.TextChanged += new System.EventHandler(this.Position_Text_Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label3.Location = new System.Drawing.Point(124, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lead Position";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label4.Location = new System.Drawing.Point(124, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label5.Location = new System.Drawing.Point(124, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Follow-Up-Date";
            // 
            // FollowUpPicker
            // 
            this.FollowUpPicker.Location = new System.Drawing.Point(129, 329);
            this.FollowUpPicker.Name = "FollowUpPicker";
            this.FollowUpPicker.Size = new System.Drawing.Size(200, 20);
            this.FollowUpPicker.TabIndex = 9;
            this.FollowUpPicker.ValueChanged += new System.EventHandler(this.FollowUpPicker_ValueChanged);
            // 
            // EmailDatePicker
            // 
            this.EmailDatePicker.Location = new System.Drawing.Point(129, 255);
            this.EmailDatePicker.Name = "EmailDatePicker";
            this.EmailDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EmailDatePicker.TabIndex = 10;
            this.EmailDatePicker.ValueChanged += new System.EventHandler(this.EmailDatePicker_ValueChanged);
            // 
            // Attach_Resume
            // 
            this.Attach_Resume.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.Attach_Resume.Location = new System.Drawing.Point(129, 375);
            this.Attach_Resume.Name = "Attach_Resume";
            this.Attach_Resume.Size = new System.Drawing.Size(200, 37);
            this.Attach_Resume.TabIndex = 11;
            this.Attach_Resume.Text = "Attach Resume";
            this.Attach_Resume.UseVisualStyleBackColor = true;
            this.Attach_Resume.Click += new System.EventHandler(this.Attach_Resume_Click);
            // 
            // ResumeFileName
            // 
            this.ResumeFileName.AutoSize = true;
            this.ResumeFileName.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.ResumeFileName.Location = new System.Drawing.Point(129, 424);
            this.ResumeFileName.Name = "ResumeFileName";
            this.ResumeFileName.Size = new System.Drawing.Size(180, 28);
            this.ResumeFileName.TabIndex = 12;
            this.ResumeFileName.Text = "Resume File Name";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.Submit.Location = new System.Drawing.Point(129, 469);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(200, 37);
            this.Submit.TabIndex = 13;
            this.Submit.Text = "Perform Outreach!";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 542);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ResumeFileName);
            this.Controls.Add(this.Attach_Resume);
            this.Controls.Add(this.EmailDatePicker);
            this.Controls.Add(this.FollowUpPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Position_Text_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Company_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_Text_Box);
            this.Name = "Form1";
            this.Text = "LeadFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Name_Text_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Company_Text_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Position_Text_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FollowUpPicker;
        private System.Windows.Forms.DateTimePicker EmailDatePicker;
        private System.Windows.Forms.OpenFileDialog AttachResume;
        private System.Windows.Forms.Button Attach_Resume;
        private System.Windows.Forms.Label ResumeFileName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Submit;
    }
}

