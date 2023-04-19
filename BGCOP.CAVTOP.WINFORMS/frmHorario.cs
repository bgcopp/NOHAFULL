using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmHorario : Form
	{
		private bool agrego;

		private IContainer components = null;

		private Panel panel1;

		private Button btnCancelar;

		private Button btnEliminar;

		private Button btnModificar;

		private Button btnAgregar;

		private TextBox txtNombreHorario;

		private Label label4;

		private Label label2;

		private ListBox listBox1;

		private Panel panel2;

		private Label label1;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		private CheckBox chkPerpetuo;

		private Label label7;

		private Label label6;

		private DateTimePicker fechaFin;

		private Label label5;

		private Label label3;

		private DateTimePicker FechaInicio;

		private CheckBox chkMaestro;

		private ToolTip toolTip1;

		private Button button2;

		private Button button1;

		private DataGridView dataGridView1;

		private DataGridViewTextBoxColumn Column1;

		private Label lblId;

		public frmHorario()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.agrego = true;
			this.txtNombreHorario.Text = "";
			this.chkMaestro.Checked = false;
			this.chkPerpetuo.Checked = false;
			this.FechaInicio.Value = DateTime.Now;
			this.fechaFin.Value = DateTime.Now;
			this.dataGridView1.DataSource = null;
			this.button1.Enabled = false;
			this.button2.Enabled = false;
			this.listBox1.SelectedIndex = -1;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea eliminar el registro seleccionado?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				(new Horarios()).Eliminar(((THorario)this.listBox1.SelectedItem).idHorario);
				this.agrego = false;
				this.llenarListaHorarios();
			}
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			Horarios horario;
			if (!this.agrego)
			{
				horario = new Horarios();
				THorario selectedItem = (THorario)this.listBox1.SelectedItem;
				horario.Modificar(selectedItem.idHorario, this.txtNombreHorario.Text, this.chkMaestro.Checked, this.FechaInicio.Value, this.fechaFin.Value, this.chkPerpetuo.Checked, Program.idUsuarioActual);
				this.agrego = false;
				this.llenarListaHorarios();
			}
			else
			{
				horario = new Horarios();
				horario.Agregar(this.txtNombreHorario.Text, this.chkMaestro.Checked, this.FechaInicio.Value, this.fechaFin.Value, this.chkPerpetuo.Checked, Program.idUsuarioActual);
				this.agrego = false;
				this.llenarListaHorarios();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmHorarioDetail _frmHorarioDetail = new frmHorarioDetail()
			{
				idH = Convert.ToInt32(this.lblId.Text)
			};
			_frmHorarioDetail.ShowDialog();
			DiasHorario diasHorario = new DiasHorario();
			this.dataGridView1.DataSource = diasHorario.ListarTodas(Convert.ToInt32(this.lblId.Text));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				DiasHorario diasHorario = new DiasHorario();
				diasHorario.Eliminar(Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[1].Value));
				this.dataGridView1.DataSource = diasHorario.ListarTodas(Convert.ToInt32(this.lblId.Text));
			}
			catch (Exception exception)
			{
			}
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			string str = "";
			foreach (DataGridViewRow row in (IEnumerable)this.dataGridView1.Rows)
			{
				string str1 = row.Cells["dia"].Value.ToString();
				if (str1 != null)
				{
					switch (str1)
					{
						case "1":
						{
							str = "Domingo";
							break;
						}
						case "2":
						{
							str = "Lunes";
							break;
						}
						case "3":
						{
							str = "Martes";
							break;
						}
						case "4":
						{
							str = "Miercoles";
							break;
						}
						case "5":
						{
							str = "Jueves";
							break;
						}
						case "6":
						{
							str = "Viernes";
							break;
						}
						case "7":
						{
							str = "Sábado";
							break;
						}
					}
				}
				row.Cells[0].Value = str;
			}
			foreach (DataGridViewColumn column in this.dataGridView1.Columns)
			{
				column.Width = column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, false);
				if (column.Name == "dia")
				{
					column.Visible = false;
				}
				if (column.Name == "Observaciones")
				{
					column.GetPreferredWidth(DataGridViewAutoSizeColumnMode.Fill, false);
				}
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

		private void frmHorario_Load(object sender, EventArgs e)
		{
			this.agrego = false;
			this.llenarListaHorarios();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHorario));
			this.panel1 = new Panel();
			this.button2 = new Button();
			this.button1 = new Button();
			this.dataGridView1 = new DataGridView();
			this.Column1 = new DataGridViewTextBoxColumn();
			this.label7 = new Label();
			this.label6 = new Label();
			this.fechaFin = new DateTimePicker();
			this.label5 = new Label();
			this.label3 = new Label();
			this.FechaInicio = new DateTimePicker();
			this.chkMaestro = new CheckBox();
			this.chkPerpetuo = new CheckBox();
			this.btnCancelar = new Button();
			this.btnEliminar = new Button();
			this.btnModificar = new Button();
			this.btnAgregar = new Button();
			this.txtNombreHorario = new TextBox();
			this.label4 = new Label();
			this.label2 = new Label();
			this.listBox1 = new ListBox();
			this.panel2 = new Panel();
			this.lblId = new Label();
			this.label1 = new Label();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.toolTip1 = new ToolTip(this.components);
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.fechaFin);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.FechaInicio);
			this.panel1.Controls.Add(this.chkMaestro);
			this.panel1.Controls.Add(this.chkPerpetuo);
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.btnModificar);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.txtNombreHorario);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(10, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(786, 478);
			this.panel1.TabIndex = 3;
			this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button2.BackColor = SystemColors.Control;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Location = new Point(752, 179);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(20, 21);
			this.button2.TabIndex = 65;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(731, 179);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 21);
			this.button1.TabIndex = 64;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1 });
			this.dataGridView1.Location = new Point(310, 204);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(464, 115);
			this.dataGridView1.TabIndex = 63;
			this.dataGridView1.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
			this.Column1.HeaderText = "Dia";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.label7.BackColor = Color.SteelBlue;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(310, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(464, 23);
			this.label7.TabIndex = 62;
			this.label7.Text = "Asignacion";
			this.label7.TextAlign = ContentAlignment.MiddleLeft;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.Location = new Point(340, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 18);
			this.label6.TabIndex = 61;
			this.label6.Text = "Fecha de Fin:";
			this.fechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.fechaFin.Location = new Point(443, 150);
			this.fechaFin.Name = "fechaFin";
			this.fechaFin.Size = new System.Drawing.Size(330, 20);
			this.fechaFin.TabIndex = 60;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(326, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 18);
			this.label5.TabIndex = 59;
			this.label5.Text = "Fecha de Inicio:";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(337, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 18);
			this.label3.TabIndex = 58;
			this.label3.Text = "Perfil Horario:";
			this.FechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.FechaInicio.CustomFormat = "";
			this.FechaInicio.Location = new Point(443, 124);
			this.FechaInicio.Name = "FechaInicio";
			this.FechaInicio.Size = new System.Drawing.Size(330, 20);
			this.FechaInicio.TabIndex = 57;
			this.chkMaestro.AutoSize = true;
			this.chkMaestro.Font = new System.Drawing.Font("Arial Narrow", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chkMaestro.Location = new Point(621, 94);
			this.chkMaestro.Name = "chkMaestro";
			this.chkMaestro.Size = new System.Drawing.Size(117, 24);
			this.chkMaestro.TabIndex = 56;
			this.chkMaestro.Text = "Horario Maestro";
			this.toolTip1.SetToolTip(this.chkMaestro, "El horario Maestro No tiene restricciones.");
			this.chkMaestro.UseVisualStyleBackColor = true;
			this.chkPerpetuo.AutoSize = true;
			this.chkPerpetuo.Font = new System.Drawing.Font("Arial Narrow", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chkPerpetuo.Location = new Point(443, 94);
			this.chkPerpetuo.Name = "chkPerpetuo";
			this.chkPerpetuo.Size = new System.Drawing.Size(122, 24);
			this.chkPerpetuo.TabIndex = 55;
			this.chkPerpetuo.Text = "Horario Perpetuo";
			this.toolTip1.SetToolTip(this.chkPerpetuo, "Marque esta opcion para no definir un intervalo de fechas.");
			this.chkPerpetuo.UseVisualStyleBackColor = true;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.FlatStyle = FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.Location = new Point(662, 329);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(112, 77);
			this.btnCancelar.TabIndex = 54;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnEliminar.FlatStyle = FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnEliminar.ForeColor = Color.Red;
			this.btnEliminar.Image = Resources.cancel_icon;
			this.btnEliminar.Location = new Point(544, 329);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(112, 77);
			this.btnEliminar.TabIndex = 53;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = ContentAlignment.BottomCenter;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
			this.btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnModificar.FlatStyle = FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnModificar.ForeColor = Color.DarkBlue;
			this.btnModificar.Image = Resources.accept_icon__1_;
			this.btnModificar.Location = new Point(426, 329);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(112, 77);
			this.btnModificar.TabIndex = 52;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextAlign = ContentAlignment.BottomCenter;
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.FlatStyle = FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(308, 329);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(112, 77);
			this.btnAgregar.TabIndex = 51;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
			this.txtNombreHorario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.txtNombreHorario.BorderStyle = BorderStyle.FixedSingle;
			this.txtNombreHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtNombreHorario.Location = new Point(443, 63);
			this.txtNombreHorario.Name = "txtNombreHorario";
			this.txtNombreHorario.Size = new System.Drawing.Size(331, 24);
			this.txtNombreHorario.TabIndex = 31;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(317, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 18);
			this.label4.TabIndex = 30;
			this.label4.Text = "Nombre Horario:";
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 438);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(755, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tenga en cuenta que para modificar la ASIGNACION debe pruiemro haber creado el horario";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(301, 346);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.lblId);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(786, 53);
			this.panel2.TabIndex = 1;
			this.lblId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.lblId.BackColor = Color.Transparent;
			this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblId.Location = new Point(663, 34);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(120, 18);
			this.lblId.TabIndex = 31;
			this.lblId.Text = "Nombre Horario:";
			this.lblId.TextAlign = ContentAlignment.MiddleRight;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(6, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(341, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gestor de Horarios del Sistema";
			this.shapeContainer1.Location = new Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			ShapeCollection shapes = this.shapeContainer1.Shapes;
			Shape[] shapeArray = new Shape[] { this.lineShape1, this.lineShape2 };
			shapes.AddRange(shapeArray);
			this.shapeContainer1.Size = new System.Drawing.Size(786, 478);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 772;
			this.lineShape1.Y1 = 430;
			this.lineShape1.Y2 = 430;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 772;
			this.lineShape2.Y1 = 431;
			this.lineShape2.Y2 = 431;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Sistema de Control de Acceso";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(807, 495);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmHorario";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Horarios";
			base.Load += new EventHandler(this.frmHorario_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.dataGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedIndex != -1)
			{
				THorario selectedItem = (THorario)this.listBox1.SelectedItem;
				this.txtNombreHorario.Text = selectedItem.NombreHorario;
				if (selectedItem.esPermanente.HasValue)
				{
					this.chkPerpetuo.Checked = selectedItem.esPermanente.Value;
				}
				this.chkMaestro.Checked = selectedItem.esMaestro;
				this.chkPerpetuo.Checked = selectedItem.esPermanente.Value;
				if (selectedItem.fechaInicio.HasValue)
				{
					this.FechaInicio.Value = selectedItem.fechaInicio.Value;
				}
				if (selectedItem.fechaFin.HasValue)
				{
					this.fechaFin.Value = selectedItem.fechaFin.Value;
				}
				this.lblId.Text = selectedItem.idHorario.ToString();
				DiasHorario diasHorario = new DiasHorario();
				this.dataGridView1.DataSource = diasHorario.ListarTodas(selectedItem.idHorario);
				this.button1.Enabled = true;
				this.button2.Enabled = true;
			}
		}

		public void llenarListaHorarios()
		{
			Horarios horario = new Horarios();
			this.listBox1.DataSource = horario.ListarTodas();
			this.listBox1.DisplayMember = "NombreHorario";
			this.listBox1.ValueMember = "idHorario";
		}
	}
}