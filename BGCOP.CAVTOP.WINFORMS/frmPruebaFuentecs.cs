using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmPruebaFuentecs : Form
	{
		private IContainer components = null;

		private PictureBox pictureBox1;

		private TextBox textBox1;

		private Button button1;

		public frmPruebaFuentecs()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PrivateFontCollection privateFontCollection = new PrivateFontCollection();
			string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
			privateFontCollection.AddFontFile(string.Concat(directoryName, "\\DLLWEB\\free3of9.ttf"));
			System.Drawing.Font font = new System.Drawing.Font(new FontFamily("Free 3 of 9", privateFontCollection), 60f);
			this.textBox1.Font = font;
			this.textBox1.ForeColor = Color.Black;
			this.textBox1.Text = "*123456*";
			Graphics graphic = this.pictureBox1.CreateGraphics();
			graphic.MeasureString("*123456789*", font);
			graphic.DrawString("*123456789*", font, new SolidBrush(Color.Black), 0f, 0f);
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
			this.pictureBox1 = new PictureBox();
			this.textBox1 = new TextBox();
			this.button1 = new Button();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Location = new Point(108, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(514, 128);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.textBox1.Location = new Point(339, 293);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(337, 118);
			this.textBox1.TabIndex = 1;
			this.button1.Location = new Point(698, 388);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(785, 423);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.pictureBox1);
			base.Name = "frmPruebaFuentecs";
			this.Text = "frmPruebaFuentecs";
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}