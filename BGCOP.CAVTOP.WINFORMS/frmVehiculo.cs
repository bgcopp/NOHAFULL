using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmVehiculo : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label3;

		private TextBox txtPlaca;

		private Label label2;

		private Button btnCancelar;

		private ListBox listBox1;

		private Button btnEliminar;

		private Button btnModificar;

		private Button btnAgregar;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private Label label6;

		private ComboBox comboBox2;

		private Label label5;

		private ComboBox comboBox1;

		private Label label7;

		private TextBox txtCodB;

		private Label label4;

		private TextBox txtColor;

		private Panel panel2;

		private Label label1;

		private PictureBox pictureBox1;

		private Button button1;

		private ImageList imageList1;

		private Button button2;

		private PrintDocument printDocument1;

		private PrintPreviewDialog printPreviewDialog1;

		private Timer timer1;

		private Label label8;

		private Label label9;

		public System.Drawing.Font c39Font;

		private PrivateFontCollection pfc;

		private FontFamily family;

		private Graphics objGraphics;

		public frmVehiculo()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.txtPlaca.Focus();
			this.listBox1.SelectedIndex = -1;
			this.comboBox2.SelectedIndex = -1;
			this.comboBox1.SelectedIndex = -1;
			this.txtColor.Text = "";
			this.txtCodB.Text = "";
			this.txtPlaca.Text = "";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex >= 0)
			{
				Vehiculos vehiculo = new Vehiculos();
				if (MessageBox.Show("Desea eliminar el registro seleccionado?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
				{
					vehiculo.Eliminar(Convert.ToInt32(this.listBox1.SelectedValue));
					MessageBox.Show("El registro se elimino con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
					this.llenaLista();
				}
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			TVehiculo tVehiculo = new TVehiculo()
			{
				Placa = this.txtPlaca.Text,
				color = this.txtColor.Text,
				CodigodeBarras = this.txtCodB.Text,
				idModeloVehiculo = new short?((short)this.comboBox1.SelectedValue),
				fechaUltimaGestion = new DateTime?(DateTime.Now),
				usuarioUltimaGestion = new int?(Program.idUsuarioActual)
			};
			Vehiculos vehiculo = new Vehiculos();
			if (this.listBox1.SelectedIndex != -1)
			{
				vehiculo.Modificar(Convert.ToInt32(this.listBox1.SelectedValue), this.txtPlaca.Text, (short)this.comboBox1.SelectedValue, this.txtCodB.Text, this.txtColor.Text, DateTime.Now, Program.idUsuarioActual);
				MessageBox.Show("El registro se modificó con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				this.llenaLista();
			}
			else
			{
				vehiculo.Agregar(this.txtPlaca.Text, (short)this.comboBox1.SelectedValue, this.txtCodB.Text, this.txtColor.Text, DateTime.Now, Program.idUsuarioActual);
				MessageBox.Show("El registro se agrego con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				this.llenaLista();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.printDocument1.DefaultPageSettings.Landscape = true;
			this.printDocument1.Print();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Vehiculos vehiculo = new Vehiculos();
			this.txtCodB.Text = vehiculo.GenCodigodeBarras();
			this.dCB(this.txtCodB.Text);
		}

		public void dCB(string CB)
		{
			this.objGraphics = this.pictureBox1.CreateGraphics();
			this.objGraphics.Clear(Color.White);
			this.objGraphics.DrawString(string.Concat("*", CB, "*"), this.c39Font, new SolidBrush(Color.Black), 0f, 0f);
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			//base.Dispose(disposing);
		}

		private void frmVehiculo_Load(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
		}

		private void frmVehiculo_Paint(object sender, PaintEventArgs e)
		{
		}

		public void inicioFuneteCB()
		{
			this.pfc = new PrivateFontCollection();
			string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
			this.pfc.AddFontFile(string.Concat(directoryName, "\\DLLWEB\\free3of9.ttf"));
			this.family = new FontFamily("Free 3 of 9", this.pfc);
			this.c39Font = new System.Drawing.Font(this.family, 24f);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVehiculo));
			this.panel1 = new Panel();
			this.button2 = new Button();
			this.imageList1 = new ImageList(this.components);
			this.pictureBox1 = new PictureBox();
			this.panel2 = new Panel();
			this.button1 = new Button();
			this.label1 = new Label();
			this.label4 = new Label();
			this.txtColor = new TextBox();
			this.label7 = new Label();
			this.txtCodB = new TextBox();
			this.label6 = new Label();
			this.comboBox2 = new ComboBox();
			this.label5 = new Label();
			this.comboBox1 = new ComboBox();
			this.label3 = new Label();
			this.txtPlaca = new TextBox();
			this.label2 = new Label();
			this.btnCancelar = new Button();
			this.listBox1 = new ListBox();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.printDocument1 = new PrintDocument();
			this.printPreviewDialog1 = new PrintPreviewDialog();
			this.timer1 = new Timer(this.components);
			this.label8 = new Label();
			this.label9 = new Label();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtColor);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtCodB);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtPlaca);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(9, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 531);
			this.panel1.TabIndex = 5;
			this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.ImageIndex = 1;
			this.button2.ImageList = this.imageList1;
			this.button2.Location = new Point(577, 185);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 49);
			this.button2.TabIndex = 26;
			this.button2.Text = "Generar\r\nNuevo Código\r\nde Barras";
			this.button2.TextAlign = ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "print-icon.png");
			this.imageList1.Images.SetKeyName(1, "Android-Barcode-Reader-140.png");
			this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.pictureBox1.Location = new Point(365, 240);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(345, 89);
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 53);
			this.panel2.TabIndex = 23;
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new Point(600, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 49);
			this.button1.TabIndex = 25;
			this.button1.Text = "Imprimir \r\nCódigo \r\nde Barras";
			this.button1.TextAlign = ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Maestro de Vehículos";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Black;
			this.label4.Location = new Point(311, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Color :";
			this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtColor.Location = new Point(365, 129);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(345, 22);
			this.txtColor.TabIndex = 21;
			this.txtColor.TextAlign = HorizontalAlignment.Center;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.Black;
			this.label7.Location = new Point(240, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 16);
			this.label7.TabIndex = 20;
			this.label7.Text = "Código de Barras :";
			this.txtCodB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtCodB.Location = new Point(365, 202);
			this.txtCodB.Name = "txtCodB";
			this.txtCodB.Size = new System.Drawing.Size(202, 22);
			this.txtCodB.TabIndex = 19;
			this.txtCodB.TextAlign = HorizontalAlignment.Center;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.Black;
			this.label6.Location = new Point(308, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 16);
			this.label6.TabIndex = 18;
			this.label6.Text = "Marca :";
			this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new Point(365, 78);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(345, 21);
			this.comboBox2.TabIndex = 17;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.Black;
			this.label5.Location = new Point(300, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 16);
			this.label5.TabIndex = 16;
			this.label5.Text = "Modelo :";
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(365, 103);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(345, 21);
			this.comboBox1.TabIndex = 15;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(311, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Placa :";
			this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtPlaca.Location = new Point(365, 157);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(345, 22);
			this.txtPlaca.TabIndex = 11;
			this.txtPlaca.TextAlign = HorizontalAlignment.Center;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 491);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(694, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "_______________";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.FlatStyle = FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(601, 396);
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
			this.listBox1.Size = new System.Drawing.Size(230, 404);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.FlatStyle = FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(483, 396);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.FlatStyle = FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(365, 396);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.FlatStyle = FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(247, 396);
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
			this.shapeContainer1.Size = new System.Drawing.Size(725, 531);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 711;
			this.lineShape1.Y1 = 506;
			this.lineShape1.Y2 = 506;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 711;
			this.lineShape2.Y1 = 507;
			this.lineShape2.Y2 = 507;
			this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("printPreviewDialog1.Icon");
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			this.timer1.Interval = 800;
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.Location = new Point(675, 500);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 9);
			this.label8.TabIndex = 6;
			this.label8.Text = "__";
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.Location = new Point(676, 476);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 9);
			this.label9.TabIndex = 27;
			this.label9.Text = "vehiculos";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(743, 539);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmVehiculo";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Vehiculos";
			base.Load += new EventHandler(this.frmVehiculo_Load);
			base.Paint += new PaintEventHandler(this.frmVehiculo_Paint);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				TVehiculo selectedItem = (TVehiculo)this.listBox1.SelectedItem;
				this.txtPlaca.Text = selectedItem.Placa;
				this.txtColor.Text = selectedItem.color;
				this.txtCodB.Text = selectedItem.CodigodeBarras;
				this.dCB(selectedItem.CodigodeBarras);
				int num1 = 0;
				TModeloVehiculo tModeloVehiculo = new TModeloVehiculo();
				foreach (TModeloVehiculo item in this.comboBox1.Items)
				{
					int num2 = item.idModeloVehiculo;
					short? nullable1 = selectedItem.idModeloVehiculo;
					if ((num2 != nullable1.GetValueOrDefault() ? 0 : Convert.ToInt32(nullable1.HasValue)) == 0)
					{
						num1++;
					}
					else
					{
						tModeloVehiculo = item;
						break;
					}
				}
				try
				{
					this.comboBox1.SelectedIndex = num1;
					num1 = 0;
					num1 = this.comboBox2.Items.Cast<TMarcaVehiculo>().TakeWhile<TMarcaVehiculo>((TMarcaVehiculo qqq) => {
						int num = qqq.idMarcaVehiculo;
						short? nullable = tModeloVehiculo.idMarcaVehiculo;
						return (num != nullable.GetValueOrDefault() ? true : !nullable.HasValue);
					}).Count<TMarcaVehiculo>();
					try
					{
						this.comboBox2.SelectedIndex = num1;
					}
					catch (Exception exception)
					{
					}
				}
				catch (Exception exception1)
				{
				}
			}
		}

		public void llenaLista()
		{
			Vehiculos vehiculo = new Vehiculos();
			this.listBox1.DataSource = vehiculo.ListarTodos();
			this.listBox1.DisplayMember = "Placa";
			this.listBox1.ValueMember = "idVehiculo";
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				TVehiculo selectedItem = (TVehiculo)this.listBox1.SelectedItem;
				e.Graphics.DrawString(string.Concat("*", this.txtCodB.Text, "*"), this.c39Font, new SolidBrush(Color.Black), 5f, 12f);
				e.Graphics.DrawString(string.Concat("*", this.txtCodB.Text, "*"), this.c39Font, new SolidBrush(Color.Black), 5f, 32f);
				Graphics graphics = e.Graphics;
				string[] text = new string[] { "[", this.txtPlaca.Text, "] ", this.txtCodB.Text, " [Ed. Protección]" };
				graphics.DrawString(string.Concat(text), this.label9.Font, new SolidBrush(Color.Black), 12f, 56f);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			this.inicioFuneteCB();
			this.llenaLista();
			MarcasVehiculo marcasVehiculo = new MarcasVehiculo();
			this.comboBox2.DataSource = marcasVehiculo.ListarTodos();
			this.comboBox2.DisplayMember = "NombreMarcaVehiculo";
			this.comboBox2.ValueMember = "idMarcaVehiculo";
			ModelosVehiculo modelosVehiculo = new ModelosVehiculo();
			this.comboBox1.DataSource = modelosVehiculo.ListarTodos();
			this.comboBox1.DisplayMember = "NombreModelo";
			this.comboBox1.ValueMember = "idModeloVehiculo";
		}
	}
}