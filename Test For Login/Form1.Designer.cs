﻿namespace Test_For_Login
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
			this.emailBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ShowPageButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// emailBox
			// 
			this.emailBox.Location = new System.Drawing.Point(286, 67);
			this.emailBox.Name = "emailBox";
			this.emailBox.Size = new System.Drawing.Size(171, 22);
			this.emailBox.TabIndex = 0;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(286, 95);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(171, 22);
			this.passwordBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(286, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(100, 100);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(69, 17);
			this.PasswordLabel.TabIndex = 4;
			this.PasswordLabel.Text = "Password";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(369, 340);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(173, 28);
			this.button3.TabIndex = 6;
			this.button3.Text = "Create Account";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(286, 124);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(171, 22);
			this.textBox1.TabIndex = 7;
			this.textBox1.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(100, 127);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Verify Password";
			this.label2.Visible = false;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 346);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(316, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Don\'t have an account? Click here to create one ";
			// 
			// ShowPageButton
			// 
			this.ShowPageButton.Location = new System.Drawing.Point(369, 378);
			this.ShowPageButton.Name = "ShowPageButton";
			this.ShowPageButton.Size = new System.Drawing.Size(173, 28);
			this.ShowPageButton.TabIndex = 10;
			this.ShowPageButton.Text = "Show New Page";
			this.ShowPageButton.UseVisualStyleBackColor = true;
			this.ShowPageButton.Click += new System.EventHandler(this.ShowPageButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 418);
			this.Controls.Add(this.ShowPageButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.emailBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button ShowPageButton;
	}
}

