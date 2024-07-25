namespace StrongPasswordGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.gbPasswordQuality = new System.Windows.Forms.GroupBox();
            this.cbSpecialChars = new System.Windows.Forms.CheckBox();
            this.cbDigits = new System.Windows.Forms.CheckBox();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbUpperCase = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).BeginInit();
            this.gbPasswordQuality.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(217, 283);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 27);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numPasswordLength
            // 
            this.numPasswordLength.Location = new System.Drawing.Point(139, 38);
            this.numPasswordLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPasswordLength.Name = "numPasswordLength";
            this.numPasswordLength.Size = new System.Drawing.Size(96, 23);
            this.numPasswordLength.TabIndex = 1;
            this.numPasswordLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(24, 40);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(99, 15);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Password Length";
            // 
            // gbPasswordQuality
            // 
            this.gbPasswordQuality.Controls.Add(this.cbSpecialChars);
            this.gbPasswordQuality.Controls.Add(this.cbDigits);
            this.gbPasswordQuality.Controls.Add(this.cbLowercase);
            this.gbPasswordQuality.Controls.Add(this.cbUpperCase);
            this.gbPasswordQuality.Location = new System.Drawing.Point(21, 77);
            this.gbPasswordQuality.Name = "gbPasswordQuality";
            this.gbPasswordQuality.Size = new System.Drawing.Size(292, 126);
            this.gbPasswordQuality.TabIndex = 5;
            this.gbPasswordQuality.TabStop = false;
            this.gbPasswordQuality.Text = "Password Quality";
            // 
            // cbSpecialChars
            // 
            this.cbSpecialChars.AutoSize = true;
            this.cbSpecialChars.Checked = true;
            this.cbSpecialChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecialChars.Location = new System.Drawing.Point(6, 97);
            this.cbSpecialChars.Name = "cbSpecialChars";
            this.cbSpecialChars.Size = new System.Drawing.Size(231, 19);
            this.cbSpecialChars.TabIndex = 6;
            this.cbSpecialChars.Text = "specialChars (!@#$%^&*()_+[]{}|;:,.<>?)";
            this.cbSpecialChars.UseVisualStyleBackColor = true;
            // 
            // cbDigits
            // 
            this.cbDigits.AutoSize = true;
            this.cbDigits.Checked = true;
            this.cbDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDigits.Location = new System.Drawing.Point(6, 72);
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.Size = new System.Drawing.Size(139, 19);
            this.cbDigits.TabIndex = 7;
            this.cbDigits.Text = "Digits (0123456789)";
            this.cbDigits.UseVisualStyleBackColor = true;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Checked = true;
            this.cbLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowercase.Location = new System.Drawing.Point(6, 47);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(254, 19);
            this.cbLowercase.TabIndex = 8;
            this.cbLowercase.Text = "Lowercase (abcdefghijklmnopqrstuvwxyz)";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // cbUpperCase
            // 
            this.cbUpperCase.AutoSize = true;
            this.cbUpperCase.Checked = true;
            this.cbUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperCase.Location = new System.Drawing.Point(6, 22);
            this.cbUpperCase.Name = "cbUpperCase";
            this.cbUpperCase.Size = new System.Drawing.Size(281, 19);
            this.cbUpperCase.TabIndex = 5;
            this.cbUpperCase.Text = "Uppercase (ABCDEFGHIJKLMNOPQRSTUVWXYZ)";
            this.cbUpperCase.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(21, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(292, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.gbPasswordQuality);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.numPasswordLength);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Strong Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordLength)).EndInit();
            this.gbPasswordQuality.ResumeLayout(false);
            this.gbPasswordQuality.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numPasswordLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.GroupBox gbPasswordQuality;
        private System.Windows.Forms.CheckBox cbSpecialChars;
        private System.Windows.Forms.CheckBox cbDigits;
        private System.Windows.Forms.CheckBox cbLowercase;
        private System.Windows.Forms.CheckBox cbUpperCase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
    }
}

