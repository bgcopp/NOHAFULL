using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmParqueos : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label3;

		private TextBox txtParqueo;

		private Label label2;

		private Button btnCancelar;

		private ListBox listBox1;

		private Button btnEliminar;

		private Button btnModificar;

		private Button btnAgregar;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private Label label4;

		private TextBox txtObservaciones;

		private Panel panel2;

		private Label label1;

		public frmParqueos()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.txtParqueo.Focus();
			this.txtObservaciones.Text = "";
			this.listBox1.SelectedIndex = -1;
			this.txtParqueo.Text = "";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex >= 0)
			{
				Parqueaderos parqueadero = new Parqueaderos();
				if (MessageBox.Show("Desea eliminar el registro seleccionado?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
				{
					parqueadero.Eliminar(Convert.ToInt32(this.listBox1.SelectedValue));
					MessageBox.Show("El registro se elimino con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
					this.llenaLista();
				}
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			Parqueaderos parqueadero;
			TParqueo tParqueo = new TParqueo()
			{
				nParqueo = this.txtParqueo.Text,
				observacionesParqueo = this.txtObservaciones.Text,
				fechaUltimaGestion = new DateTime?(DateTime.Now),
				usuarioUltimaGestion = new int?(Program.idUsuarioActual)
			};
			if (this.listBox1.SelectedIndex != -1)
			{
				parqueadero = new Parqueaderos();
				parqueadero.Modificar(Convert.ToInt32(this.listBox1.SelectedValue), this.txtParqueo.Text, DateTime.Now, Program.idUsuarioActual, "Sin Observaciones");
				MessageBox.Show("El registro se modificó con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				this.llenaLista();
			}
			else
			{
				parqueadero = new Parqueaderos();
				parqueadero.Agregar(string.Concat("Parqueadero # [", this.txtParqueo.Text, "]"), DateTime.Now, Program.idUsuarioActual, "Sin Observaciones");
				MessageBox.Show("El registro se agrego con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				this.llenaLista();
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

		private void frmParqueos_Load(object sender, EventArgs e)
		{
			this.llenaLista();
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmParqueos));
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.label4 = new Label();
			this.txtObservaciones = new TextBox();
			this.label3 = new Label();
			this.txtParqueo = new TextBox();
			this.label2 = new Label();
			this.btnCancelar = new Button();
			this.listBox1 = new ListBox();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtObservaciones);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtParqueo);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(9, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 399);
			this.panel1.TabIndex = 4;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 53);
			this.panel2.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Parqueaderos";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Black;
			this.label4.Location = new Point(260, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Notas :";
			this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtObservaciones.Location = new Point(306, 144);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(404, 110);
			this.txtObservaciones.TabIndex = 13;
			this.txtObservaciones.TextAlign = HorizontalAlignment.Center;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(245, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Parqueo :";
			this.txtParqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtParqueo.Location = new Point(306, 116);
			this.txtParqueo.Name = "txtParqueo";
			this.txtParqueo.Size = new System.Drawing.Size(404, 22);
			this.txtParqueo.TabIndex = 11;
			this.txtParqueo.TextAlign = HorizontalAlignment.Center;
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
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(601, 260);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(230, 276);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(483, 260);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(365, 260);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(247, 260);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 77);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
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
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(743, 407);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmParqueos";
			this.Text = "Parqueaderos";
			base.Load += new EventHandler(this.frmParqueos_Load);
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
				TParqueo selectedItem = (TParqueo)this.listBox1.SelectedItem;
				this.txtParqueo.Text = selectedItem.nParqueo;
				this.txtObservaciones.Text = selectedItem.observacionesParqueo;
			}
		}

		public void llenaLista()
		{
			Parqueaderos parqueadero = new Parqueaderos();
			this.listBox1.DataSource = parqueadero.ListarTodos();
			this.listBox1.DisplayMember = "nParqueo";
			this.listBox1.ValueMember = "idParqueadero";
		}
	}
}