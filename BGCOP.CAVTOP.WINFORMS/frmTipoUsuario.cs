using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.COMMON;
using BGCOP.CAVTOP.WINFORMS.Properties;
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
	public class frmTipoUsuario : Form
	{
		private LogCls LogF = new LogCls();

		private SesionActual tu = new SesionActual();

		private IContainer components = null;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		private ListBox listBox1;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private Label label2;

		private CheckedListBox chkPermisos;

		private Label label3;

		private TextBox txtTipoUsuario;

		private ToolTip toolTip1;

		private Button btnCancelar;

		private Button btnEliminar;

		private Button btnModificar;

		private Button btnAgregar;

		public frmTipoUsuario()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			int i = 0;
			this.txtTipoUsuario.Text = "";
			for (i = 0; i < 50; i++)
			{
				this.chkPermisos.SetItemChecked(i, false);
			}
			this.txtTipoUsuario.Focus();
			this.listBox1.SelectedIndex = -1;
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			string str;
			TiposUsuarios tiposUsuario;
			if (this.listBox1.SelectedIndex == -1)
			{
				if (this.txtTipoUsuario.Text.Length <= 0)
				{
					MessageBox.Show("Verifique la Informacion Suministrada.");
					this.LogF.Evento = "Verifique la Informacion Suministrada. Campo tipo usuario vacio";
					this.LogF.AddEvent();
				}
				else
				{
					str = this.ObtienePermisos();
					tiposUsuario = new TiposUsuarios();
					if (!tiposUsuario.CrearTipoUsuario(this.txtTipoUsuario.Text, str, this.tu.IdUsuarioActual))
					{
						this.LogF.Evento = "error al agregar tipoUsuario";
						this.LogF.AddEvent();
					}
					this.listBox1.DataSource = tiposUsuario.ListarTodosLosTipos();
				}
			}
			else if (MessageBox.Show("Desea modificar el registro seleccionado?", "Gestion CAV12", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				tiposUsuario = new TiposUsuarios();
				str = this.ObtienePermisos();
				tiposUsuario.ActualizarTipoUsuario(Convert.ToInt32(this.listBox1.SelectedValue), this.txtTipoUsuario.Text, str, this.tu.IdUsuarioActual);
				this.listBox1.DataSource = tiposUsuario.ListarTodosLosTipos();
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

		private void frmTipoUsuario_Load(object sender, EventArgs e)
		{
			this.LogF.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			this.LlenaLista();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmTipoUsuario));
			this.panel1 = new Panel();
			this.btnCancelar = new Button();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.chkPermisos = new CheckedListBox();
			this.label3 = new Label();
			this.txtTipoUsuario = new TextBox();
			this.label2 = new Label();
			this.listBox1 = new ListBox();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.toolTip1 = new ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.chkPermisos);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtTipoUsuario);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 399);
			this.panel1.TabIndex = 0;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(601, 270);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 58;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnCancelar, "Cancela Operación");
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(483, 270);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 57;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnEliminar, "Elimina Registro");
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(365, 270);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 56;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnModificar, "Modifica Registro");
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(247, 270);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 77);
			this.btnAgregar.TabIndex = 55;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agrega Registro");
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
			this.chkPermisos.ColumnWidth = 200;
			this.chkPermisos.FormattingEnabled = true;
			this.chkPermisos.Location = new Point(247, 95);
			this.chkPermisos.MultiColumn = true;
			this.chkPermisos.Name = "chkPermisos";
			this.chkPermisos.Size = new System.Drawing.Size(465, 169);
			this.chkPermisos.TabIndex = 13;
			this.toolTip1.SetToolTip(this.chkPermisos, "Matriz de Seleccion de permisos para el perfil.");
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(251, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tipo de Usuario :";
			this.txtTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTipoUsuario.Location = new Point(365, 67);
			this.txtTipoUsuario.Name = "txtTipoUsuario";
			this.txtTipoUsuario.Size = new System.Drawing.Size(347, 22);
			this.txtTipoUsuario.TabIndex = 11;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 362);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(694, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "_______________";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(230, 292);
			this.listBox1.TabIndex = 6;
			this.toolTip1.SetToolTip(this.listBox1, "Listado Actual de Perfiles de Usuario");
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
			this.label1.Size = new System.Drawing.Size(213, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Perfiles de Usuario";
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
			this.lineShape1.Y1 = 355;
			this.lineShape1.Y2 = 355;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 711;
			this.lineShape2.Y1 = 356;
			this.lineShape2.Y2 = 356;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Sistema de Control de Acceso";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(749, 417);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTipoUsuario";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Sistema de Control de Acceso";
			base.Load += new EventHandler(this.frmTipoUsuario_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				TTipoUsuario selectedItem = (TTipoUsuario)this.listBox1.SelectedItem;
				this.txtTipoUsuario.Text = selectedItem.NombreTipoUsuario;
				string str = selectedItem.permisos;
				int num = 0;
				string str1 = str;
				for (int i = 0; i < str1.Length; i++)
				{
					if (str1[i] != '1')
					{
						this.chkPermisos.SetItemChecked(num, false);
					}
					else
					{
						this.chkPermisos.SetItemChecked(num, true);
					}
					num++;
				}
			}
		}

		public void LlenaLista()
		{
			try
			{
				ModulosSoftware modulosSoftware = new ModulosSoftware();
				this.chkPermisos.DataSource = modulosSoftware.ListaModulos;
				TiposUsuarios tiposUsuario = new TiposUsuarios();
				this.listBox1.DataSource = tiposUsuario.ListarTodosLosTipos();
				this.listBox1.DisplayMember = "NombreTipoUsuario";
				this.listBox1.ValueMember = "idTipoUsuario";
				this.listBox1.SelectedIndex = -1;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.LogF.Evento = string.Concat("Error: ", exception.Message);
				this.LogF.AddEvent();
			}
		}

		public string ObtienePermisos()
		{
			int i = 0;
			string str = "";
			for (i = 0; i < 50; i++)
			{
				str = (!this.chkPermisos.GetItemChecked(i) ? string.Concat(str, "0") : string.Concat(str, "1"));
			}
			return str;
		}
	}
}