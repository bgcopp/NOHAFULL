using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.COMMON;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmLogIn : RadForm
	{
		private IContainer components = null;

		private Office2010BlackTheme office2010BlackTheme1;

		private DesertTheme desertTheme1;

		private Office2007BlackTheme office2007BlackTheme1;

		private Panel panel1;

		private Button button3;

		private Label label4;

		private Button button2;

		private Label label3;

		private TextBox txtPassword;

		private Label label2;

		private TextBox txtUsuario;

		private Panel panel2;

		private Label label1;

		private PictureBox pictureBox1;

		private Label label5;

		internal PictureBox pictureBox2;

		public frmLogIn()
		{
			this.InitializeComponent();
			base.DialogResult = System.Windows.Forms.DialogResult.No;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.comprobacion();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			this.comprobacion();
		}

		public void comprobacion()
		{
			logIn _logIn = new logIn();
			Usuarios usuario = new Usuarios();
			usrDB _usrDB = _logIn.CompruebaLogin(this.txtUsuario.Text, this.txtPassword.Text);
			if (_usrDB.idUsr == -1)
			{
				MessageBox.Show("Error en el inicio del sistema.\nVerifique la información suministrada!.\nSi necesita ayuda contacte al administrador del sistema.", Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				TUsuario tUsuario = usuario.obtenerUsuario(this.txtUsuario.Text);
				Utilitys utility = new Utilitys();
				Program.idUsuarioActual = _usrDB.idUsr;
				Program.permisoActual = _usrDB.permiUsr;
				Program.Imagen = new Bitmap(utility.Bytes2Image(tUsuario.fotoUsuario));
				Program.UsrActual = tUsuario.nombre;
				Program.usrAct2 = tUsuario.login;
				base.DialogResult = System.Windows.Forms.DialogResult.OK;
				base.Close();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmLogIn_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
		}

		private void frmLogIn_Load(object sender, EventArgs e)
		{
			this.txtUsuario.Focus();
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLogIn));
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			this.desertTheme1 = new DesertTheme();
			this.office2007BlackTheme1 = new Office2007BlackTheme();
			this.panel1 = new Panel();
			this.label5 = new Label();
			this.pictureBox2 = new PictureBox();
			this.pictureBox1 = new PictureBox();
			this.button3 = new Button();
			this.label4 = new Label();
			this.button2 = new Button();
			this.label3 = new Label();
			this.txtPassword = new TextBox();
			this.label2 = new Label();
			this.txtUsuario = new TextBox();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(12, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(826, 490);
			this.panel1.TabIndex = 0;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(659, 446);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(164, 39);
			this.label5.TabIndex = 39;
			this.label5.Text = "Desarrollado por Boris Camelo\r\nE-Mail: bgcopp@gmail.com\r\nBogotá - Colombia       2012 ";
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(162, 374);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(220, 86);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 38;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Image = Resources.shot_1346129654634;
			this.pictureBox1.Location = new Point(3, 77);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(379, 383);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 36;
			this.pictureBox1.TabStop = false;
			this.button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
			this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Image = Resources.Button_Check_icon;
			this.button3.ImageAlign = ContentAlignment.TopCenter;
			this.button3.Location = new Point(575, 251);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 56);
			this.button3.TabIndex = 35;
			this.button3.Text = "Aceptar";
			this.button3.TextAlign = ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click_1);
			this.label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label4.BackColor = Color.LightGoldenrodYellow;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Brown;
			this.label4.Location = new Point(412, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(371, 30);
			this.label4.TabIndex = 34;
			this.label4.Text = "Ingrese su contraseña en una fomra segura. \r\nSi necesita información contacte al Administrador de su sistema.";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
			this.button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Image = Resources.cancel_icon;
			this.button2.ImageAlign = ContentAlignment.TopCenter;
			this.button2.Location = new Point(682, 251);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(101, 56);
			this.button2.TabIndex = 32;
			this.button2.Text = "Cancelar";
			this.button2.TextAlign = ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(412, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 18);
			this.label3.TabIndex = 31;
			this.label3.Text = "Contraseña";
			this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtPassword.Location = new Point(490, 219);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(293, 26);
			this.txtPassword.TabIndex = 30;
			this.txtPassword.KeyUp += new KeyEventHandler(this.txtPassword_KeyUp);
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(433, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 29;
			this.label2.Text = "Usuario";
			this.txtUsuario.BorderStyle = BorderStyle.FixedSingle;
			this.txtUsuario.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtUsuario.Location = new Point(490, 188);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(293, 26);
			this.txtUsuario.TabIndex = 28;
			this.txtUsuario.KeyUp += new KeyEventHandler(this.txtUsuario_KeyUp);
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(826, 53);
			this.panel2.TabIndex = 27;
			this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(13, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(797, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sistema de Control de Acceso NOHA";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.LightGray;
			base.ClientSize = new System.Drawing.Size(866, 566);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmLogIn";
			base.RootElement.ApplyShapeToControl = true;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Acceso al Sistema NOHA";
			base.ThemeName = "Office2007Black";
			base.Load += new EventHandler(this.frmLogIn_Load);
			base.KeyUp += new KeyEventHandler(this.frmLogIn_KeyUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		private void txtPassword_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.comprobacion();
			}
		}

		private void txtUsuario_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.txtPassword.Focus();
			}
		}
	}
}