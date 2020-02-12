namespace Discord_League_Name_Adder
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::DarkUI.Forms.DarkForm
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002238 File Offset: 0x00000438
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002270 File Offset: 0x00000470
		private void InitializeComponent()
		{
			this.darkButton1 = new global::DarkUI.Controls.DarkButton();
			this.darkButton2 = new global::DarkUI.Controls.DarkButton();
			this.TextBoxUsername = new global::DarkUI.Controls.DarkTextBox();
			this.darkLabel1 = new global::DarkUI.Controls.DarkLabel();
			this.TextBoxAuth = new global::DarkUI.Controls.DarkTextBox();
			this.darkLabel2 = new global::DarkUI.Controls.DarkLabel();
			base.SuspendLayout();
			this.darkButton1.Location = new global::System.Drawing.Point(162, 2);
			this.darkButton1.Name = "darkButton1";
			this.darkButton1.Padding = new global::System.Windows.Forms.Padding(5);
			this.darkButton1.Size = new global::System.Drawing.Size(32, 23);
			this.darkButton1.TabIndex = 0;
			this.darkButton1.Text = "X";
			this.darkButton1.Click += new global::System.EventHandler(this.DarkButton1_Click);
			this.darkButton2.Location = new global::System.Drawing.Point(59, 184);
			this.darkButton2.Name = "darkButton2";
			this.darkButton2.Padding = new global::System.Windows.Forms.Padding(5);
			this.darkButton2.Size = new global::System.Drawing.Size(78, 38);
			this.darkButton2.TabIndex = 1;
			this.darkButton2.Text = "Add";
			this.darkButton2.Click += new global::System.EventHandler(this.DarkButton2_Click);
			this.TextBoxUsername.BackColor = global::System.Drawing.Color.FromArgb(69, 73, 74);
			this.TextBoxUsername.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxUsername.ForeColor = global::System.Drawing.Color.FromArgb(220, 220, 220);
			this.TextBoxUsername.Location = new global::System.Drawing.Point(14, 65);
			this.TextBoxUsername.Name = "TextBoxUsername";
			this.TextBoxUsername.Size = new global::System.Drawing.Size(141, 20);
			this.TextBoxUsername.TabIndex = 2;
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.ForeColor = global::System.Drawing.Color.FromArgb(220, 220, 220);
			this.darkLabel1.Location = new global::System.Drawing.Point(11, 29);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new global::System.Drawing.Size(94, 13);
			this.darkLabel1.TabIndex = 3;
			this.darkLabel1.Text = "Desired Username";
			this.TextBoxAuth.BackColor = global::System.Drawing.Color.FromArgb(69, 73, 74);
			this.TextBoxAuth.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxAuth.ForeColor = global::System.Drawing.Color.FromArgb(220, 220, 220);
			this.TextBoxAuth.Location = new global::System.Drawing.Point(14, 143);
			this.TextBoxAuth.Name = "TextBoxAuth";
			this.TextBoxAuth.Size = new global::System.Drawing.Size(141, 20);
			this.TextBoxAuth.TabIndex = 4;
			this.darkLabel2.AutoSize = true;
			this.darkLabel2.ForeColor = global::System.Drawing.Color.FromArgb(220, 220, 220);
			this.darkLabel2.Location = new global::System.Drawing.Point(11, 112);
			this.darkLabel2.Name = "darkLabel2";
			this.darkLabel2.Size = new global::System.Drawing.Size(68, 13);
			this.darkLabel2.TabIndex = 5;
			this.darkLabel2.Text = "Authorization";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(195, 244);
			base.Controls.Add(this.darkLabel2);
			base.Controls.Add(this.TextBoxAuth);
			base.Controls.Add(this.darkLabel1);
			base.Controls.Add(this.TextBoxUsername);
			base.Controls.Add(this.darkButton2);
			base.Controls.Add(this.darkButton1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000005 RID: 5
		private global::DarkUI.Controls.DarkButton darkButton1;

		// Token: 0x04000006 RID: 6
		private global::DarkUI.Controls.DarkButton darkButton2;

		// Token: 0x04000007 RID: 7
		private global::DarkUI.Controls.DarkTextBox TextBoxUsername;

		// Token: 0x04000008 RID: 8
		private global::DarkUI.Controls.DarkLabel darkLabel1;

		// Token: 0x04000009 RID: 9
		private global::DarkUI.Controls.DarkTextBox TextBoxAuth;

		// Token: 0x0400000A RID: 10
		private global::DarkUI.Controls.DarkLabel darkLabel2;
	}
}
