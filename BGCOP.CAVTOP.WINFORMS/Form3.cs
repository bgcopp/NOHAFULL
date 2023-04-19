using BGCOP.CAVTOP.BUSINESSLAYER;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class Form3 : Form
	{
		private IContainer components = null;

		private Button button1;

		public Form3()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new Vtarjetas()).VerificaTarjetaBussiness("f0382db1c");
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.button1 = new Button();
			base.SuspendLayout();
			this.button1.Location = new Point(77, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 73);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(284, 262);
			base.Controls.Add(this.button1);
			base.Name = "Form3";
			this.Text = "Form3";
			base.ResumeLayout(false);
		}
	}
}