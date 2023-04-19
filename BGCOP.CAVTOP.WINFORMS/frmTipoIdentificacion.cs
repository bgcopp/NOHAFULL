using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.COMMON;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmTipoIdentificacion : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label3;

		private TextBox txtIdentificacion;

		private Label label2;

		private ListBox listBox1;

		private Panel panel2;

		private Label label1;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private ToolTip toolTip1;

		private Button btnCancelar;

		private Button btnEliminar;

		private Button btnModificar;

		private Button btnAgregar;

		public Utilitys ut = new Utilitys();

		private LogCls logF = new LogCls();

		public frmTipoIdentificacion()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.txtIdentificacion.Focus();
			this.listBox1.SelectedIndex = -1;
			this.txtIdentificacion.Text = "";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex >= 0)
			{
				TiposIdentificacion tiposIdentificacion = new TiposIdentificacion();
				if (MessageBox.Show("Desea eliminar el registro seleccionado?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
				{
					tiposIdentificacion.EliminarTipoIdentificacion(Convert.ToInt32(this.listBox1.SelectedValue));
					MessageBox.Show("El registro se elimino con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
					this.listBox1.DataSource = tiposIdentificacion.ListarTodos();
					this.listBox1.DisplayMember = "descripcionIdentificacion";
					this.listBox1.ValueMember = "idTipoIdentificacion";
				}
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			TTipoIdentificacion tTipoIdentificacion;
			TiposIdentificacion tiposIdentificacion;
			if (this.listBox1.SelectedIndex != -1)
			{
				tTipoIdentificacion = new TTipoIdentificacion()
				{
					descripcionIdentificacion = this.txtIdentificacion.Text,
					fechaUltimaGestion = new DateTime?(DateTime.Now),
					usuarioUltimaGestion = new int?(Program.idUsuarioActual)
				};
				tiposIdentificacion = new TiposIdentificacion();
				tiposIdentificacion.ModificarTipoIdentificacion(Convert.ToInt32(this.listBox1.SelectedValue), tTipoIdentificacion);
				MessageBox.Show("El registro se modificó con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				this.listBox1.DataSource = tiposIdentificacion.ListarTodos();
				this.listBox1.DisplayMember = "descripcionIdentificacion";
				this.listBox1.ValueMember = "idTipoIdentificacion";
			}
			else
			{
				tTipoIdentificacion = new TTipoIdentificacion()
				{
					descripcionIdentificacion = this.txtIdentificacion.Text,
					fechaUltimaGestion = new DateTime?(DateTime.Now),
					usuarioUltimaGestion = new int?(Program.idUsuarioActual)
				};
				tiposIdentificacion = new TiposIdentificacion();
				tiposIdentificacion.AgregarTipoIdentificacion(tTipoIdentificacion);
				MessageBox.Show("El registro se agrego con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				this.listBox1.DataSource = tiposIdentificacion.ListarTodos();
				this.listBox1.DisplayMember = "descripcionIdentificacion";
				this.listBox1.ValueMember = "idTipoIdentificacion";
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

		private void frmTipoIdentificacion_Load(object sender, EventArgs e)
		{
			TiposIdentificacion tiposIdentificacion = new TiposIdentificacion();
			this.listBox1.DataSource = tiposIdentificacion.ListarTodos();
			this.listBox1.DisplayMember = "descripcionIdentificacion";
			this.listBox1.ValueMember = "idTipoIdentificacion";
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmTipoIdentificacion));
			this.panel1 = new Panel();
			this.btnCancelar = new Button();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.label3 = new Label();
			this.txtIdentificacion = new TextBox();
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
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtIdentificacion);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(9, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 399);
			this.panel1.TabIndex = 2;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.FlatStyle = FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(604, 259);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 58;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnCancelar, "Cancela Operación");
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.FlatStyle = FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(486, 259);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 57;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnEliminar, "Elimina Registro");
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.FlatStyle = FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(368, 259);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 56;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnModificar, "Modifica Registro");
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.FlatStyle = FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(250, 259);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 77);
			this.btnAgregar.TabIndex = 55;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agrega Registro");
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
			this.label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(249, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Identificación";
			this.txtIdentificacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtIdentificacion.Location = new Point(341, 156);
			this.txtIdentificacion.Name = "txtIdentificacion";
			this.txtIdentificacion.Size = new System.Drawing.Size(369, 22);
			this.txtIdentificacion.TabIndex = 11;
			this.txtIdentificacion.TextAlign = HorizontalAlignment.Center;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 359);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(694, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "_______________";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(230, 276);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 53);
			this.panel2.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipos de Identificación";
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
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(743, 412);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTipoIdentificacion";
			this.Text = "Tipo de Identificacion";
			base.Load += new EventHandler(this.frmTipoIdentificacion_Load);
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
				TTipoIdentificacion selectedItem = (TTipoIdentificacion)this.listBox1.SelectedItem;
				this.txtIdentificacion.Text = selectedItem.descripcionIdentificacion;
			}
		}
	}
}