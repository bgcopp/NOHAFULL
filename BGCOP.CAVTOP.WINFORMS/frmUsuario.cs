using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.COMMON;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmUsuario : Form
	{
		private LogCls logF = new LogCls();

		public Utilitys ut = new Utilitys();

		private static ClassSeguridad secu;

		private string passActual = "123";

		private string passNuevo = "123";

		private byte[] passActualMD5;

		private byte[] passNuevoMD5;

		private bool cambio = false;

		private IContainer components = null;

		private Panel panel1;

		private Label label2;

		private ListBox listBox1;

		private Panel panel2;

		private Label label1;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private RadioButton radioButton2;

		private RadioButton radioButton1;

		private Label label3;

		private PictureBox fotoUsuario;

		private TextBox txtLogin;

		private Label label4;

		private TextBox txtNombre;

		private Label label5;

		private Button button6;

		private Button button5;

		private Label label8;

		private CheckBox chlActivo;

		private Button button7;

		private ComboBox cmbTipoUser;

		private Label label7;

		private Label label6;

		private ToolTip toolTip1;

		private OpenFileDialog openFileDialog1;

		private Button btnCancelar;

		private Button btnEliminar;

		private Button btnModificar;

		private Button btnAgregar;

		static frmUsuario()
		{
			frmUsuario.secu = new ClassSeguridad();
		}

		public frmUsuario()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.txtNombre.Focus();
			this.listBox1.SelectedIndex = -1;
			this.fotoUsuario.BackgroundImage = Resources.personal;
			this.txtNombre.Text = "";
			this.txtLogin.Text = "";
			this.cmbTipoUser.SelectedIndex = -1;
			this.passNuevo = "123";
			this.chlActivo.Checked = false;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Usuarios usuario = new Usuarios();
			if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Gestion CAV12", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				usuario.EliminarUsuario(Convert.ToInt32(this.listBox1.SelectedValue));
			}
			this.listBox1.DataSource = usuario.ListarTodosLosUsuarios();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			TUsuario tUsuario;
			Usuarios usuario;
			object obj;
			object obj1;
			if (this.listBox1.SelectedIndex != -1)
			{
				tUsuario = new TUsuario()
				{
					nombre = this.txtNombre.Text,
					login = this.txtLogin.Text,
					idTipoUsuario = (int?)this.cmbTipoUser.SelectedValue,
					fechaUltimaGestion = new DateTime?(DateTime.Now),
					fotoUsuario = this.ut.Image2Bytes(this.fotoUsuario.BackgroundImage)
				};
				if (!this.cambio)
				{
					tUsuario.password = ((TUsuario)this.listBox1.SelectedItem).password;
				}
				else
				{
					tUsuario.password = frmUsuario.secu.GetMd5Hash(this.passNuevo);
				}
				this.cambio = false;
				tUsuario.usuarioUltimaGestion = new int?(this.ut.IdUsuarioActual);
				TUsuario nullable = tUsuario;
				if (this.chlActivo.Checked)
				{
					obj = 1;
				}
				else
				{
					obj = null;
				}
				nullable.activo = new short?((short)obj);
				usuario = new Usuarios();
				usuario.ModificarUsuario((int)this.listBox1.SelectedValue, tUsuario, this.ut.IdUsuarioActual);
				MessageBox.Show("El usuario se modificó con exito!", "Gestion CAV12", MessageBoxButtons.OK);
				this.listBox1.DataSource = usuario.ListarTodosLosUsuarios();
			}
			else
			{
				tUsuario = new TUsuario()
				{
					nombre = this.txtNombre.Text,
					login = this.txtLogin.Text,
					idTipoUsuario = (int?)this.cmbTipoUser.SelectedValue,
					fechaUltimaGestion = new DateTime?(DateTime.Now),
					fotoUsuario = this.ut.Image2Bytes(this.fotoUsuario.BackgroundImage),
					password = frmUsuario.secu.GetMd5Hash(this.passNuevo),
					usuarioUltimaGestion = new int?(this.ut.IdUsuarioActual)
				};
				TUsuario nullable1 = tUsuario;
				if (this.chlActivo.Checked)
				{
					obj1 = 1;
				}
				else
				{
					obj1 = null;
				}
				nullable1.activo = new short?((short)obj1);
				usuario = new Usuarios();
				usuario.AgregarUsuario(tUsuario, this.ut.IdUsuarioActual);
				MessageBox.Show("El usuario se agrego con exito!", "Gestion CAV12", MessageBoxButtons.OK);
				this.listBox1.DataSource = usuario.ListarTodosLosUsuarios();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (this.radioButton1.Checked)
			{
				this.openFileDialog1.ShowDialog();
				string fileName = this.openFileDialog1.FileName;
				if (fileName.Length > 0)
				{
					try
					{
						this.fotoUsuario.BackgroundImage = new Bitmap(fileName);
					}
					catch (Exception exception)
					{
						this.fotoUsuario.BackgroundImage = Resources.personal;
					}
				}
			}
			else if (this.radioButton2.Checked)
			{
				frmCamara _frmCamara = new frmCamara()
				{
					u = this.fotoUsuario
				};
				_frmCamara.ShowDialog();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.fotoUsuario.BackgroundImage = Resources.personal;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string str = Interaction.InputBox("Digite la contraseña", "CAV12", "123", -1, -1);
			if (!(str == Interaction.InputBox("Digite nuevamente la contraseña", "CAV12", "123", -1, -1)))
			{
				MessageBox.Show("Verifique la información suministrada. No coinciden las contraseñas!", Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.cambio = false;
			}
			else
			{
				this.passNuevo = str;
				MessageBox.Show("Para guardar los cambios, haga click en el botón actualizar.", Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.cambio = true;
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

		private void frmUsuario_Load(object sender, EventArgs e)
		{
			this.logF.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			Usuarios usuario = new Usuarios();
			this.listBox1.DataSource = usuario.ListarTodosLosUsuarios();
			this.listBox1.DisplayMember = "nombre";
			this.listBox1.ValueMember = "idUsuario";
			TiposUsuarios tiposUsuario = new TiposUsuarios();
			this.cmbTipoUser.DataSource = tiposUsuario.ListarTodosLosTipos();
			this.cmbTipoUser.DisplayMember = "NombreTipoUsuario";
			this.cmbTipoUser.ValueMember = "idTipoUsuario";
			this.txtNombre.Focus();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmUsuario));
			this.panel1 = new Panel();
			this.btnCancelar = new Button();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.label8 = new Label();
			this.chlActivo = new CheckBox();
			this.button7 = new Button();
			this.cmbTipoUser = new ComboBox();
			this.label7 = new Label();
			this.label6 = new Label();
			this.txtLogin = new TextBox();
			this.label4 = new Label();
			this.txtNombre = new TextBox();
			this.label5 = new Label();
			this.button6 = new Button();
			this.button5 = new Button();
			this.radioButton2 = new RadioButton();
			this.radioButton1 = new RadioButton();
			this.label3 = new Label();
			this.fotoUsuario = new PictureBox();
			this.label2 = new Label();
			this.listBox1 = new ListBox();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.toolTip1 = new ToolTip(this.components);
			this.openFileDialog1 = new OpenFileDialog();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.fotoUsuario).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.chlActivo);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.cmbTipoUser);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtLogin);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtNombre);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.fotoUsuario);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(9, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 399);
			this.panel1.TabIndex = 1;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(600, 263);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 62;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnCancelar, "Cancela Operación");
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(482, 263);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 61;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnEliminar, "Elimina Registro");
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(364, 263);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 60;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnModificar, "Modifica Registro");
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(246, 263);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 77);
			this.btnAgregar.TabIndex = 59;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agrega Registro");
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.Location = new Point(584, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(134, 18);
			this.label8.TabIndex = 43;
			this.label8.Text = "Estado del Usuario";
			this.chlActivo.AutoSize = true;
			this.chlActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chlActivo.Location = new Point(614, 181);
			this.chlActivo.Name = "chlActivo";
			this.chlActivo.Size = new System.Drawing.Size(64, 20);
			this.chlActivo.TabIndex = 42;
			this.chlActivo.Text = "Activo";
			this.chlActivo.UseVisualStyleBackColor = true;
			this.button7.BackColor = Color.SteelBlue;
			this.button7.FlatAppearance.MouseOverBackColor = Color.Green;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Verdana", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.Location = new Point(390, 176);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(171, 29);
			this.button7.TabIndex = 41;
			this.button7.Text = "Cambiar Contraseña";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new EventHandler(this.button7_Click);
			this.cmbTipoUser.BackColor = Color.Moccasin;
			this.cmbTipoUser.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbTipoUser.FlatStyle = FlatStyle.Flat;
			this.cmbTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cmbTipoUser.FormattingEnabled = true;
			this.cmbTipoUser.Location = new Point(390, 233);
			this.cmbTipoUser.Name = "cmbTipoUser";
			this.cmbTipoUser.Size = new System.Drawing.Size(328, 24);
			this.cmbTipoUser.TabIndex = 40;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.Location = new Point(387, 209);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 18);
			this.label7.TabIndex = 39;
			this.label7.Text = "Tipo de Usuario";
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.Location = new Point(387, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 18);
			this.label6.TabIndex = 38;
			this.label6.Text = "Contraseña";
			this.txtLogin.BorderStyle = BorderStyle.FixedSingle;
			this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtLogin.Location = new Point(390, 126);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(327, 24);
			this.txtLogin.TabIndex = 31;
			this.toolTip1.SetToolTip(this.txtLogin, "Alias de identificación para ingresar al sistema");
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(387, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 18);
			this.label4.TabIndex = 30;
			this.label4.Text = "Login de entrada";
			this.txtNombre.BorderStyle = BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtNombre.Location = new Point(390, 78);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(328, 24);
			this.txtNombre.TabIndex = 29;
			this.toolTip1.SetToolTip(this.txtNombre, "Nombre completo del usuario");
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(387, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 18);
			this.label5.TabIndex = 28;
			this.label5.Text = "Nombre Completo";
			this.button6.Location = new Point(350, 56);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(31, 23);
			this.button6.TabIndex = 27;
			this.button6.Text = "[-]";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new EventHandler(this.button6_Click);
			this.button5.Location = new Point(318, 56);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(31, 23);
			this.button5.TabIndex = 26;
			this.button5.Text = "[+]";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(249, 240);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(131, 17);
			this.radioButton2.TabIndex = 25;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Dispositivo de Captura";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new Point(249, 224);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(107, 17);
			this.radioButton1.TabIndex = 24;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Archivo Existente";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(244, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 16);
			this.label3.TabIndex = 23;
			this.label3.Text = "Foto";
			this.fotoUsuario.BackgroundImage = Resources.personal;
			this.fotoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
			this.fotoUsuario.Location = new Point(247, 79);
			this.fotoUsuario.Name = "fotoUsuario";
			this.fotoUsuario.Size = new System.Drawing.Size(133, 138);
			this.fotoUsuario.TabIndex = 22;
			this.fotoUsuario.TabStop = false;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 359);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(694, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "La contraseña por defecto para los usuarios es 123. Después de ser cambiada no se puede verifica su valor.";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(230, 274);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel2.BackColor = Color.SteelBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 53);
			this.panel2.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(37, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gestion de Usuarios";
			this.shapeContainer1.Location = new Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			ShapeCollection shapes = this.shapeContainer1.Shapes;
			Shape[] shapeArray = new Shape[] { this.lineShape1, this.lineShape2 };
			shapes.AddRange(shapeArray);
			this.shapeContainer1.Size = new System.Drawing.Size(725, 399);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 711;
			this.lineShape1.Y1 = 351;
			this.lineShape1.Y2 = 351;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 711;
			this.lineShape2.Y1 = 352;
			this.lineShape2.Y2 = 352;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Sistema de Control de Acceso";
			this.openFileDialog1.FileName = "openFileDialog1";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(743, 416);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmUsuario";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Sistema de Control de Acceso";
			base.Load += new EventHandler(this.frmUsuario_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.fotoUsuario).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				TUsuario selectedItem = (TUsuario)this.listBox1.SelectedItem;
				this.txtNombre.Text = selectedItem.nombre;
				this.txtLogin.Text = selectedItem.login;
				this.cmbTipoUser.SelectedValue = selectedItem.idTipoUsuario;
				this.fotoUsuario.BackgroundImage = this.ut.Bytes2Image(selectedItem.fotoUsuario);
				CheckBox checkBox = this.chlActivo;
				short? nullable = selectedItem.activo;
				checkBox.Checked = (nullable.GetValueOrDefault() != 1 ? false : nullable.HasValue);
			}
		}
	}
}