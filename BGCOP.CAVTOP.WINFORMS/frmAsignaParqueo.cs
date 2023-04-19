using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Objects;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmAsignaParqueo : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label2;

		private Button btnCancelar;

		private Button btnEliminar;

		private Panel panel2;

		private Label label1;

		private Button btnModificar;

		private Button btnAgregar;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private DataGridView dataGridView1;

		private GroupBox groupBox1;

		private Panel panel3;

		private ComboBox comboBox2;

		private ComboBox comboBox1;

		private Label label3;

		private Label label5;

		private ComboBox comboBox4;

		private Label label6;

		private ComboBox comboBox3;

		private Label label4;

		private CheckBox checkBox7;

		private CheckBox checkBox6;

		private CheckBox checkBox5;

		private CheckBox checkBox4;

		private CheckBox checkBox3;

		private CheckBox checkBox2;

		private CheckBox checkBox1;

		private Label label7;

		private Label lblIdVehiculo;

		private Label lblIdParqueo;

		private Label label8;

		private Label label9;

		private TextBox textBox1;

		private Label label10;

		private AutoCompleteStringCollection txtC;

		private AutoCompleteStringCollection txtCp;

		private AutoCompleteStringCollection txtC3;

		private AutoCompleteStringCollection txtC4;

		private bool agrego;

		public frmAsignaParqueo()
		{
			this.agrego = false;
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.agrego = true;
			this.lblIdVehiculo.Text = "";
			this.lblIdParqueo.Text = "";
			this.comboBox3.SelectedIndex = -1;
			this.comboBox4.SelectedIndex = -1;
			this.checkBox1.Checked = false;
			this.checkBox2.Checked = false;
			this.checkBox3.Checked = false;
			this.checkBox4.Checked = false;
			this.checkBox5.Checked = false;
			this.checkBox6.Checked = false;
			this.checkBox7.Checked = false;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.agrego = false;
			base.Close();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea Eliminar el registro seleccionado?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				VehiculosParqueos vehiculosParqueo = new VehiculosParqueos();
				vehiculosParqueo.Eliminar((int)this.comboBox4.SelectedValue, (int)this.comboBox3.SelectedValue);
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.agrego)
				{
					VehiculosParqueos vehiculosParqueo = new VehiculosParqueos();
					vehiculosParqueo.Modificar((int)this.comboBox4.SelectedValue, (int)this.comboBox3.SelectedValue, DateTime.Now, Program.idUsuarioActual, 1, "Sin Observaciones", this.checkBox1.Checked, this.checkBox2.Checked, this.checkBox3.Checked, this.checkBox4.Checked, this.checkBox5.Checked, this.checkBox6.Checked, this.checkBox7.Checked);
				}
				else
				{
					masterDBACEntities masterDBACEntity = new masterDBACEntities();
					try
					{
						TvehiculoParqueo tvehiculoParqueo = new TvehiculoParqueo()
						{
							idVehiculo = (int)this.comboBox3.SelectedValue,
							idParqueadero = (int)this.comboBox4.SelectedValue,
							diaSemana = 1,
							dia1 = new bool?(this.checkBox1.Checked),
							dia2 = new bool?(this.checkBox2.Checked),
							dia3 = new bool?(this.checkBox3.Checked),
							dia4 = new bool?(this.checkBox4.Checked),
							dia5 = new bool?(this.checkBox5.Checked),
							dia6 = new bool?(this.checkBox6.Checked),
							dia7 = new bool?(this.checkBox7.Checked),
							ObservacionesVP = "Sin Observaciones",
							fechaUltimaGestion = new DateTime?(DateTime.Now),
							usuarioUltimaGestion = new int?(Program.idUsuarioActual)
						};
						TvehiculoParqueo tvehiculoParqueo1 = tvehiculoParqueo;
						if (MessageBox.Show("Desea confirmar la operacion?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
						{
							masterDBACEntity.AddToTvehiculoParqueo(tvehiculoParqueo1);
							masterDBACEntity.SaveChanges();
							this.llenaLista();
						}
					}
					finally
					{
						if (masterDBACEntity != null)
						{
							((IDisposable)masterDBACEntity).Dispose();
						}
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboBox3.Text = this.comboBox1.Text;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboBox4.Text = this.comboBox2.Text;
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblIdVehiculo.Text = this.comboBox3.SelectedValue.ToString();
				this.lblIdParqueo.Text = this.comboBox4.SelectedValue.ToString();
			}
			catch (Exception exception)
			{
			}
		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblIdVehiculo.Text = this.comboBox3.SelectedValue.ToString();
				this.lblIdParqueo.Text = this.comboBox4.SelectedValue.ToString();
			}
			catch (Exception exception)
			{
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			this.selectGrid();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmAsignaParqueo_CausesValidationChanged(object sender, EventArgs e)
		{
		}

		private void frmAsignaParqueo_Load(object sender, EventArgs e)
		{
			this.llenaLista();
		}

		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle steelBlue = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAsignaParqueo));
			this.panel1 = new Panel();
			this.panel3 = new Panel();
			this.comboBox2 = new ComboBox();
			this.comboBox1 = new ComboBox();
			this.label3 = new Label();
			this.label5 = new Label();
			this.groupBox1 = new GroupBox();
			this.lblIdParqueo = new Label();
			this.label8 = new Label();
			this.lblIdVehiculo = new Label();
			this.label7 = new Label();
			this.comboBox4 = new ComboBox();
			this.label6 = new Label();
			this.comboBox3 = new ComboBox();
			this.label4 = new Label();
			this.checkBox7 = new CheckBox();
			this.checkBox6 = new CheckBox();
			this.checkBox5 = new CheckBox();
			this.checkBox4 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox1 = new CheckBox();
			this.dataGridView1 = new DataGridView();
			this.label2 = new Label();
			this.btnCancelar = new Button();
			this.btnEliminar = new Button();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.label9 = new Label();
			this.label10 = new Label();
			this.textBox1 = new TextBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(9, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 534);
			this.panel1.TabIndex = 4;
			this.panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.panel3.BackColor = Color.SteelBlue;
			this.panel3.CausesValidation = false;
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.comboBox2);
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new Point(0, 204);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(725, 28);
			this.panel3.TabIndex = 31;
			this.comboBox2.CausesValidation = false;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new Point(538, 3);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(179, 21);
			this.comboBox2.TabIndex = 33;
			this.comboBox2.SelectedIndexChanged += new EventHandler(this.comboBox2_SelectedIndexChanged);
			this.comboBox1.CausesValidation = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(191, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(179, 21);
			this.comboBox1.TabIndex = 32;
			this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(376, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 16);
			this.label3.TabIndex = 31;
			this.label3.Text = "Busqueda Parqueadero :";
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.Black;
			this.label5.Location = new Point(71, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "Busqueda Placa :";
			this.groupBox1.CausesValidation = false;
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.lblIdParqueo);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.lblIdVehiculo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.comboBox4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Location = new Point(6, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(716, 141);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adición - Modificación";
			this.lblIdParqueo.CausesValidation = false;
			this.lblIdParqueo.Location = new Point(187, 21);
			this.lblIdParqueo.Name = "lblIdParqueo";
			this.lblIdParqueo.Size = new System.Drawing.Size(43, 15);
			this.lblIdParqueo.TabIndex = 36;
			this.lblIdParqueo.Text = "label8";
			this.label8.AutoSize = true;
			this.label8.CausesValidation = false;
			this.label8.Location = new Point(171, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(10, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "-";
			this.lblIdVehiculo.CausesValidation = false;
			this.lblIdVehiculo.Location = new Point(130, 21);
			this.lblIdVehiculo.Name = "lblIdVehiculo";
			this.lblIdVehiculo.Size = new System.Drawing.Size(43, 15);
			this.lblIdVehiculo.TabIndex = 34;
			this.lblIdVehiculo.Text = "label8";
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.Black;
			this.label7.Location = new Point(43, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 33;
			this.label7.Text = "Referencia :";
			this.comboBox4.CausesValidation = false;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new Point(130, 70);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(179, 21);
			this.comboBox4.TabIndex = 32;
			this.comboBox4.SelectedIndexChanged += new EventHandler(this.comboBox4_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.Black;
			this.label6.Location = new Point(30, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 16);
			this.label6.TabIndex = 31;
			this.label6.Text = "Parqueadero :";
			this.comboBox3.CausesValidation = false;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new Point(130, 43);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(179, 21);
			this.comboBox3.TabIndex = 30;
			this.comboBox3.SelectedIndexChanged += new EventHandler(this.comboBox3_SelectedIndexChanged);
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Black;
			this.label4.Location = new Point(10, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 16);
			this.label4.TabIndex = 29;
			this.label4.Text = "Busqueda Placa :";
			this.checkBox7.AutoSize = true;
			this.checkBox7.CausesValidation = false;
			this.checkBox7.Location = new Point(479, 68);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(68, 17);
			this.checkBox7.TabIndex = 24;
			this.checkBox7.Text = "Domingo";
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox6.AutoSize = true;
			this.checkBox6.CausesValidation = false;
			this.checkBox6.Location = new Point(413, 68);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(63, 17);
			this.checkBox6.TabIndex = 23;
			this.checkBox6.Text = "Sabado";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox5.AutoSize = true;
			this.checkBox5.CausesValidation = false;
			this.checkBox5.Location = new Point(348, 68);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(61, 17);
			this.checkBox5.TabIndex = 22;
			this.checkBox5.Text = "Viernes";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox4.AutoSize = true;
			this.checkBox4.CausesValidation = false;
			this.checkBox4.Location = new Point(556, 45);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(60, 17);
			this.checkBox4.TabIndex = 21;
			this.checkBox4.Text = "Jueves";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox3.AutoSize = true;
			this.checkBox3.CausesValidation = false;
			this.checkBox3.Location = new Point(479, 45);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(71, 17);
			this.checkBox3.TabIndex = 20;
			this.checkBox3.Text = "Miercoles";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox2.AutoSize = true;
			this.checkBox2.CausesValidation = false;
			this.checkBox2.Location = new Point(413, 45);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(58, 17);
			this.checkBox2.TabIndex = 19;
			this.checkBox2.Text = "Martes";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox1.AutoSize = true;
			this.checkBox1.CausesValidation = false;
			this.checkBox1.Location = new Point(348, 45);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(55, 17);
			this.checkBox1.TabIndex = 18;
			this.checkBox1.Text = "Lunes";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.PapayaWhip;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.dataGridView1.CausesValidation = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new Point(3, 234);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			steelBlue.SelectionBackColor = Color.SteelBlue;
			steelBlue.SelectionForeColor = Color.LightGoldenrodYellow;
			this.dataGridView1.RowsDefaultCellStyle = steelBlue;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(719, 158);
			this.dataGridView1.TabIndex = 24;
			this.dataGridView1.SelectionChanged += new EventHandler(this.dataGridView1_SelectionChanged);
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 494);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(694, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "_______________";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.CausesValidation = false;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(601, 395);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.CausesValidation = false;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(483, 395);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
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
			this.label1.Size = new System.Drawing.Size(256, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Asignación de Parqueo";
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.CausesValidation = false;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(365, 395);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.CausesValidation = false;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(247, 395);
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
			this.shapeContainer1.Size = new System.Drawing.Size(725, 534);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 711;
			this.lineShape1.Y1 = 486;
			this.lineShape1.Y2 = 486;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 711;
			this.lineShape2.Y1 = 487;
			this.lineShape2.Y2 = 487;
			this.label9.CausesValidation = false;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(10, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(43, 15);
			this.label9.TabIndex = 35;
			this.label9.Text = "Filtro:";
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.Black;
			this.label10.Location = new Point(18, 98);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(106, 16);
			this.label10.TabIndex = 37;
			this.label10.Text = "Observaciones :";
			this.textBox1.Location = new Point(130, 98);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(574, 37);
			this.textBox1.TabIndex = 38;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CausesValidation = false;
			base.ClientSize = new System.Drawing.Size(743, 547);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmAsignaParqueo";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Parqueo";
			base.Load += new EventHandler(this.frmAsignaParqueo_Load);
			base.CausesValidationChanged += new EventHandler(this.frmAsignaParqueo_CausesValidationChanged);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((ISupportInitialize)this.dataGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		public void llenaLista()
		{
			Vehiculos vehiculo = new Vehiculos();
			Parqueaderos parqueadero = new Parqueaderos();
			List<TVehiculo> tVehiculos = vehiculo.ListarTodos();
			List<TParqueo> tParqueos = parqueadero.ListarTodos();
			this.txtC3 = frmAsignaParqueo.LoadAutoCompletetVehi(tVehiculos);
			this.txtC4 = frmAsignaParqueo.LoadAutoCompletetPar(tParqueos);
			this.comboBox3.DataSource = tVehiculos;
			this.comboBox3.DisplayMember = "Placa";
			this.comboBox3.ValueMember = "idVehiculo";
			this.comboBox4.DataSource = tParqueos;
			this.comboBox4.DisplayMember = "nparqueo";
			this.comboBox4.ValueMember = "idParqueadero";
			this.comboBox3.SelectedIndex = -1;
			this.comboBox4.SelectedIndex = -1;
			this.comboBox3.AutoCompleteCustomSource = this.txtC3;
			this.comboBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.comboBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.comboBox4.AutoCompleteCustomSource = this.txtC4;
			this.comboBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.comboBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
			List<viParqueoVehiculo> viParqueoVehiculos = (new VehiculosParqueos()).listarTodos();
			this.txtC = frmAsignaParqueo.LoadAutoCompletePlaca(viParqueoVehiculos);
			this.txtCp = frmAsignaParqueo.LoadAutoCompleteParqueo(viParqueoVehiculos);
			this.dataGridView1.DataSource = viParqueoVehiculos;
			this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
			this.dataGridView1.Columns["Placa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Lunes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Martes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Miercoles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Jueves"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Viernes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Sábado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["Domingo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridView1.Columns["idVehiculo"].Visible = false;
			this.dataGridView1.Columns["idParqueadero"].Visible = false;
			this.comboBox1.AutoCompleteCustomSource = this.txtC;
			this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.comboBox1.DataSource = viParqueoVehiculos;
			this.comboBox1.DisplayMember = "Placa";
			this.comboBox1.SelectedIndex = -1;
			this.comboBox2.AutoCompleteCustomSource = this.txtCp;
			this.comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.comboBox2.DataSource = viParqueoVehiculos;
			this.comboBox2.DisplayMember = "Parqueadero";
			this.comboBox2.SelectedIndex = -1;
			this.lblIdVehiculo.Text = "";
			this.lblIdParqueo.Text = "";
			this.dataGridView1.Rows[0].Selected = true;
			this.selectGrid();
		}

		public static AutoCompleteStringCollection LoadAutoCompleteParqueo(List<viParqueoVehiculo> ao)
		{
			AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
			foreach (viParqueoVehiculo _viParqueoVehiculo in ao)
			{
				autoCompleteStringCollections.Add(_viParqueoVehiculo.Parqueadero);
			}
			return autoCompleteStringCollections;
		}

		public static AutoCompleteStringCollection LoadAutoCompletePlaca(List<viParqueoVehiculo> ao)
		{
			AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
			foreach (viParqueoVehiculo _viParqueoVehiculo in ao)
			{
				autoCompleteStringCollections.Add(_viParqueoVehiculo.Placa);
			}
			return autoCompleteStringCollections;
		}

		public static AutoCompleteStringCollection LoadAutoCompletetPar(List<TParqueo> ao)
		{
			AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
			foreach (TParqueo tParqueo in ao)
			{
				autoCompleteStringCollections.Add(tParqueo.nParqueo);
			}
			return autoCompleteStringCollections;
		}

		public static AutoCompleteStringCollection LoadAutoCompletetVehi(List<TVehiculo> ao)
		{
			AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
			foreach (TVehiculo tVehiculo in ao)
			{
				autoCompleteStringCollections.Add(tVehiculo.Placa);
			}
			return autoCompleteStringCollections;
		}

		public void selectGrid()
		{
			try
			{
				this.checkBox1.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Lunes"].Value);
				this.checkBox2.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Martes"].Value);
				this.checkBox3.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Miercoles"].Value);
				this.checkBox4.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Jueves"].Value);
				this.checkBox5.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Viernes"].Value);
				this.checkBox6.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Sábado"].Value);
				this.checkBox7.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["Domingo"].Value);
				this.lblIdVehiculo.Text = this.dataGridView1.SelectedRows[0].Cells["idVehiculo"].Value.ToString();
				this.lblIdParqueo.Text = this.dataGridView1.SelectedRows[0].Cells["idParqueadero"].Value.ToString();
			}
			catch (Exception exception)
			{
			}
		}
	}
}