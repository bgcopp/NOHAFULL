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
	public class frmEmpresa : Form
	{
		private LogCls logF = new LogCls();

		public Utilitys ut = new Utilitys();

		private IContainer components = null;

		private Panel panel1;

		private TextBox txtRazonSocial;

		private Label label4;

		private TextBox txtNit;

		private Label label5;

		private Label label2;

		private ListBox listBox1;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private ToolTip toolTip1;

		private TextBox txtObservaciones;

		private Label label7;

		private TextBox txtContacto;

		private Label label8;

		private TextBox txtExtension;

		private Label label6;

		private TextBox txtTelefonos;

		private Label label3;

		private TextBox txtCargoContacto;

		private Label label9;

		private Button btnAgregar;

		private Button btnCancelar;

		private Button btnEliminar;

		private Button btnModificar;

		private Panel panel2;

		private Label label1;

		public frmEmpresa()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.txtContacto.Text = "";
			this.txtExtension.Text = "";
			this.txtNit.Text = "";
			this.txtObservaciones.Text = "";
			this.txtRazonSocial.Text = "";
			this.txtTelefonos.Text = "";
			this.txtNit.Focus();
			this.txtCargoContacto.Text = "";
			this.listBox1.SelectedIndex = -1;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Empresas empresa = new Empresas();
			if (MessageBox.Show("Desea eliminar el registro seleccionado?", "Gestion CAV12", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				empresa.EliminarEmpresa(Convert.ToInt32(this.listBox1.SelectedValue));
			}
			this.listBox1.DataSource = empresa.ListarTodas();
			this.listBox1.DisplayMember = "RazonSocial";
			this.listBox1.ValueMember = "idEmpresa";
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			TEmpresa tEmpresa = new TEmpresa()
			{
				nit = this.txtNit.Text,
				RazonSocial = this.txtRazonSocial.Text,
				telefonos = this.txtTelefonos.Text,
				telContactoInterno = this.txtExtension.Text,
				EmpleadoContacto = this.txtContacto.Text,
				ObservacioneEmpresa = this.txtObservaciones.Text,
				CargoContacto = this.txtCargoContacto.Text
			};
			Empresas empresa = new Empresas();
			if (this.listBox1.SelectedIndex != -1)
			{
				empresa.ModificarEmpresa((int)this.listBox1.SelectedValue, tEmpresa, Program.idUsuarioActual);
				MessageBox.Show("El registro se modificó con exito!", "Gestion CAV12", MessageBoxButtons.OK);
				this.listBox1.DataSource = empresa.ListarTodas();
			}
			else
			{
				empresa.CrearEmpresa(tEmpresa, Program.idUsuarioActual);
				MessageBox.Show("El registro se agrego con exito!", "Gestion CAV12", MessageBoxButtons.OK);
				this.listBox1.DataSource = empresa.ListarTodas();
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

		private void frmEmpresa_Load(object sender, EventArgs e)
		{
			Empresas empresa = new Empresas();
			this.listBox1.DataSource = empresa.ListarTodas();
			this.listBox1.DisplayMember = "RazonSocial";
			this.listBox1.ValueMember = "idEmpresa";
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmEmpresa));
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.btnCancelar = new Button();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.txtCargoContacto = new TextBox();
			this.label9 = new Label();
			this.txtObservaciones = new TextBox();
			this.label7 = new Label();
			this.txtContacto = new TextBox();
			this.label8 = new Label();
			this.txtExtension = new TextBox();
			this.label6 = new Label();
			this.txtTelefonos = new TextBox();
			this.label3 = new Label();
			this.txtRazonSocial = new TextBox();
			this.label4 = new Label();
			this.txtNit = new TextBox();
			this.label5 = new Label();
			this.label2 = new Label();
			this.listBox1 = new ListBox();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.toolTip1 = new ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.txtCargoContacto);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.txtObservaciones);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtContacto);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtExtension);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtTelefonos);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtRazonSocial);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtNit);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(9, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(788, 427);
			this.panel1.TabIndex = 2;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(788, 53);
			this.panel2.TabIndex = 55;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Empresas";
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.FlatStyle = FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(664, 296);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 54;
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
			this.btnEliminar.Location = new Point(546, 296);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 53;
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
			this.btnModificar.Location = new Point(428, 296);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 52;
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
			this.btnAgregar.Location = new Point(310, 296);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 77);
			this.btnAgregar.TabIndex = 51;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agrega Registro");
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
			this.txtCargoContacto.BorderStyle = BorderStyle.FixedSingle;
			this.txtCargoContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtCargoContacto.Location = new Point(420, 201);
			this.txtCargoContacto.Name = "txtCargoContacto";
			this.txtCargoContacto.Size = new System.Drawing.Size(354, 24);
			this.txtCargoContacto.TabIndex = 50;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.Location = new Point(304, 203);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 18);
			this.label9.TabIndex = 49;
			this.label9.Text = "Cargo Contacto:";
			this.txtObservaciones.BorderStyle = BorderStyle.FixedSingle;
			this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtObservaciones.Location = new Point(420, 229);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(354, 63);
			this.txtObservaciones.TabIndex = 48;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.Location = new Point(306, 231);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 18);
			this.label7.TabIndex = 47;
			this.label7.Text = "Observaciones:";
			this.txtContacto.BorderStyle = BorderStyle.FixedSingle;
			this.txtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtContacto.Location = new Point(421, 171);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.Size = new System.Drawing.Size(354, 24);
			this.txtContacto.TabIndex = 46;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.Location = new Point(345, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 18);
			this.label8.TabIndex = 45;
			this.label8.Text = "Contacto:";
			this.txtExtension.BorderStyle = BorderStyle.FixedSingle;
			this.txtExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtExtension.Location = new Point(421, 143);
			this.txtExtension.Name = "txtExtension";
			this.txtExtension.Size = new System.Drawing.Size(354, 24);
			this.txtExtension.TabIndex = 44;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.Location = new Point(333, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 18);
			this.label6.TabIndex = 43;
			this.label6.Text = "Ext. Interna:";
			this.txtTelefonos.BorderStyle = BorderStyle.FixedSingle;
			this.txtTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTelefonos.Location = new Point(421, 115);
			this.txtTelefonos.Name = "txtTelefonos";
			this.txtTelefonos.Size = new System.Drawing.Size(354, 24);
			this.txtTelefonos.TabIndex = 42;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(340, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 18);
			this.label3.TabIndex = 41;
			this.label3.Text = "Teléfonos:";
			this.txtRazonSocial.BorderStyle = BorderStyle.FixedSingle;
			this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtRazonSocial.Location = new Point(421, 87);
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.Size = new System.Drawing.Size(354, 24);
			this.txtRazonSocial.TabIndex = 31;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(317, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 18);
			this.label4.TabIndex = 30;
			this.label4.Text = "Razon Social:";
			this.txtNit.BackColor = Color.PapayaWhip;
			this.txtNit.BorderStyle = BorderStyle.FixedSingle;
			this.txtNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtNit.Location = new Point(420, 60);
			this.txtNit.Name = "txtNit";
			this.txtNit.Size = new System.Drawing.Size(355, 24);
			this.txtNit.TabIndex = 29;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(388, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 18);
			this.label5.TabIndex = 28;
			this.label5.Text = "Nit:";
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 387);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(757, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "___";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(301, 310);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.shapeContainer1.Location = new Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			ShapeCollection shapes = this.shapeContainer1.Shapes;
			Shape[] shapeArray = new Shape[] { this.lineShape1, this.lineShape2 };
			shapes.AddRange(shapeArray);
			this.shapeContainer1.Size = new System.Drawing.Size(788, 427);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 774;
			this.lineShape1.Y1 = 379;
			this.lineShape1.Y2 = 379;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 774;
			this.lineShape2.Y1 = 380;
			this.lineShape2.Y2 = 380;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Sistema de Control de Acceso";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(809, 436);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmEmpresa";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Empresas";
			base.Load += new EventHandler(this.frmEmpresa_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            try
            {
				TEmpresa selectedItem = (TEmpresa)this.listBox1.SelectedItem;
				this.txtNit.Text = selectedItem.nit;
				this.txtRazonSocial.Text = selectedItem.RazonSocial;
				this.txtTelefonos.Text = selectedItem.telefonos;
				this.txtExtension.Text = selectedItem.telContactoInterno;
				this.txtContacto.Text = selectedItem.EmpleadoContacto;
				this.txtObservaciones.Text = selectedItem.ObservacioneEmpresa;
				this.txtCargoContacto.Text = selectedItem.CargoContacto;
			}
            catch (Exception)
            {

                //throw;
            }
			
		}
	}
}