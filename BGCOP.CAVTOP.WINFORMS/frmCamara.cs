using BGCOP.CAVTOP.COMMON;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using WebCAM;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmCamara : Form
	{
		private IContainer components = null;

		private WebCam webCam1;

		private Button button1;

		private Label label1;

		private Panel panel2;

		public PictureBox u;

		private LogCls LogF = new LogCls();

		public frmCamara()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.u.BackgroundImage = this.webCam1.Imagen;
				this.webCam1.Stop();
			}
			catch (Exception exception)
			{
			}
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmCamara_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.webCam1.Stop();
			}
			catch (Exception exception)
			{
				this.Text = string.Concat("Error ", exception.Message);
				throw;
			}
		}

		private void frmCamara_Load(object sender, EventArgs e)
		{
			try
			{
				this.button1.Focus();
				this.webCam1.Start();
				this.LogF.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				MessageBox.Show(string.Concat("Error al iniciar el dispositivo de captura! ", exception.Message), Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.LogF.Evento = string.Concat("Error: ", exception.Message);
				this.LogF.AddEvent();
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmCamara));
			this.webCam1 = new WebCam();
			this.button1 = new Button();
			this.label1 = new Label();
			this.panel2 = new Panel();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.webCam1.BorderStyle = BorderStyle.FixedSingle;
			this.webCam1.Imagen = null;
			this.webCam1.Location = new Point(22, 55);
			this.webCam1.MilisegundosCaptura = 100;
			this.webCam1.Name = "webCam1";
			this.webCam1.Size = new System.Drawing.Size(220, 206);
			this.webCam1.TabIndex = 0;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.Image = Resources.webcam_add_icon;
			this.button1.ImageAlign = ContentAlignment.TopCenter;
			this.button1.Location = new Point(22, 266);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(220, 54);
			this.button1.TabIndex = 1;
			this.button1.Text = "Capturar";
			this.button1.TextAlign = ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(44, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Captura Imagen";
			this.panel2.BackColor = Color.SteelBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(266, 53);
			this.panel2.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(266, 323);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.webCam1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmCamara";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "WebCam";
			base.FormClosing += new FormClosingEventHandler(this.frmCamara_FormClosing);
			base.Load += new EventHandler(this.frmCamara_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}