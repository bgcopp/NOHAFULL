using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmEmpleadoOk : Form
	{
		private IContainer components = null;

		private Panel panel2;

		private Label label1;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tEmpleadoBindingSource;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tEmpleadoBindingNavigator;

		private ToolStripButton bindingNavigatorAddNewItem;

		private ToolStripLabel bindingNavigatorCountItem;

		private ToolStripButton bindingNavigatorDeleteItem;

		private ToolStripButton bindingNavigatorMoveFirstItem;

		private ToolStripButton bindingNavigatorMovePreviousItem;

		private ToolStripSeparator bindingNavigatorSeparator;

		private ToolStripTextBox bindingNavigatorPositionItem;

		private ToolStripSeparator bindingNavigatorSeparator1;

		private ToolStripButton bindingNavigatorMoveNextItem;

		private ToolStripButton bindingNavigatorMoveLastItem;

		private ToolStripSeparator bindingNavigatorSeparator2;

		private ToolStripButton tEmpleadoBindingNavigatorSaveItem;

		private TextBox idEmpleadoTextBox;

		private TextBox nombreTextBox;

		private TextBox idTipoIdentificacionTextBox;

		private TextBox identificacionTextBox;

		private TextBox notarjetaTextBox;

		private TextBox idCargoTextBox;

		private TextBox idTipoEstadoTextBox;

		private TextBox idEmpresaTextBox;

		private TextBox idDivisionEmpresaTextBox;

		private TextBox idHorarioTextBox;

		private TextBox observacionesTextBox;

		private DateTimePicker fechaUltimaGestionDateTimePicker;

		private TextBox usuarioUltimaGestionTextBox;

		private TextBox usuarioHuellaTextBox;

		private TextBox idTarjetaTextBox;

		private ComboBox cmbTipoIdentificacion;

		private ComboBox cmbTarjetas;

		private ComboBox cmbEmpresa;

		private ComboBox cmbDivision;

		private ComboBox cmbCargos;

		private Panel panel1;

		private BindingSource tEmpresaBindingSource;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private Panel panel3;

		private Button button1;

		private RadioButton radioButton2;

		private RadioButton radioButton1;

		private TextBox textBox1;

		private RadDesktopAlert radDesktopAlert1;

		private ComboBox cmbEstado;

		private Timer tInicio;

		public frmEmpleadoOk()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int num = -1;
			num = (!this.radioButton1.Checked ? this.tEmpleadoBindingSource.Find("nombre", this.textBox1.Text) : this.tEmpleadoBindingSource.Find("identificacion", this.textBox1.Text));
			if (num != -1)
			{
				this.textBox1.Text = "";
				this.tEmpleadoBindingSource.Position = num;
			}
			else
			{
				this.radDesktopAlert1.ContentImage = Resources.cancel_icon;
				this.radDesktopAlert1.CaptionText = "Busqueda...";
				this.radDesktopAlert1.ContentText = "No se ha encontrado ningun registro!";
				this.radDesktopAlert1.FixedSize = new System.Drawing.Size(450, 140);
				this.radDesktopAlert1.Show();
			}
		}

		public void centrarPanel()
		{
			this.panel3.Top = (base.Height - this.panel3.Height) / 2 + this.panel2.Height / 2;
			this.panel3.Left = (base.Width - this.panel3.Width) / 2;
		}

		private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbCargos.SelectedIndex >= 0)
			{
				this.idCargoTextBox.Text = this.cmbCargos.SelectedValue.ToString();
			}
		}

		private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbDivision.SelectedIndex >= 0)
			{
				this.idDivisionEmpresaTextBox.Text = this.cmbDivision.SelectedValue.ToString();
			}
		}

		private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbEmpresa.SelectedIndex >= 0)
			{
				this.idEmpresaTextBox.Text = this.cmbEmpresa.SelectedValue.ToString();
			}
		}

		private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbEstado.SelectedIndex >= 0)
			{
				this.idTipoEstadoTextBox.Text = this.cmbEstado.SelectedValue.ToString();
			}
		}

		private void cmbTarjetas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbTarjetas.SelectedIndex >= 0)
			{
				this.idTarjetaTextBox.Text = this.cmbTarjetas.SelectedValue.ToString();
			}
		}

		private void cmbTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbTipoIdentificacion.SelectedIndex >= 0)
			{
				this.idTipoIdentificacionTextBox.Text = this.cmbTipoIdentificacion.SelectedValue.ToString();
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

		private void frmEmpleadoOk_Load(object sender, EventArgs e)
		{
			this.centrarPanel();
			this.tInicio.Enabled = true;
		}

		private void frmEmpleadoOk_SizeChanged(object sender, EventArgs e)
		{
			this.centrarPanel();
		}

		private void idCargoTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.cmbCargos.SelectedValue = Convert.ToInt32(this.idCargoTextBox.Text);
			}
			catch (Exception exception)
			{
				this.cmbCargos.SelectedIndex = -1;
			}
		}

		private void idEmpresaTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.cmbEmpresa.SelectedValue = Convert.ToInt32(this.idEmpresaTextBox.Text);
			}
			catch (Exception exception)
			{
				this.cmbEmpresa.SelectedIndex = -1;
			}
			try
			{
				DivisionesEmpresa divisionesEmpresa = new DivisionesEmpresa();
				this.cmbDivision.DataSource = divisionesEmpresa.ListarTodas(Convert.ToInt32(this.idEmpresaTextBox.Text));
				this.cmbDivision.DisplayMember = "NombreDivision";
				this.cmbDivision.ValueMember = "IdDivisionEmpresa";
			}
			catch (Exception exception1)
			{
			}
		}

		private void idTarjetaTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string text = this.idTarjetaTextBox.Text;
				this.cmbTarjetas.SelectedValue = Convert.ToInt32(this.idTarjetaTextBox.Text);
			}
			catch (Exception exception)
			{
				this.cmbTarjetas.SelectedIndex = -1;
			}
		}

		private void idTipoEstadoTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.cmbEstado.SelectedValue = Convert.ToInt32(this.idTipoEstadoTextBox.Text);
			}
			catch (Exception exception)
			{
				this.cmbEstado.SelectedIndex = -1;
			}
		}

		private void idTipoIdentificacionTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.cmbTipoIdentificacion.SelectedValue = Convert.ToInt32(this.idTipoIdentificacionTextBox.Text);
			}
			catch (Exception exception)
			{
				this.cmbTipoIdentificacion.SelectedIndex = -1;
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmEmpleadoOk));
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tEmpleadoBindingNavigator = new BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new ToolStripButton();
			this.bindingNavigatorCountItem = new ToolStripLabel();
			this.bindingNavigatorDeleteItem = new ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new ToolStripButton();
			this.bindingNavigatorSeparator = new ToolStripSeparator();
			this.bindingNavigatorPositionItem = new ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new ToolStripButton();
			this.bindingNavigatorMoveLastItem = new ToolStripButton();
			this.bindingNavigatorSeparator2 = new ToolStripSeparator();
			this.tEmpleadoBindingNavigatorSaveItem = new ToolStripButton();
			this.idEmpleadoTextBox = new TextBox();
			this.nombreTextBox = new TextBox();
			this.idTipoIdentificacionTextBox = new TextBox();
			this.identificacionTextBox = new TextBox();
			this.notarjetaTextBox = new TextBox();
			this.idCargoTextBox = new TextBox();
			this.idTipoEstadoTextBox = new TextBox();
			this.idEmpresaTextBox = new TextBox();
			this.idDivisionEmpresaTextBox = new TextBox();
			this.idHorarioTextBox = new TextBox();
			this.observacionesTextBox = new TextBox();
			this.fechaUltimaGestionDateTimePicker = new DateTimePicker();
			this.usuarioUltimaGestionTextBox = new TextBox();
			this.usuarioHuellaTextBox = new TextBox();
			this.idTarjetaTextBox = new TextBox();
			this.cmbTipoIdentificacion = new ComboBox();
			this.cmbTarjetas = new ComboBox();
			this.cmbEmpresa = new ComboBox();
			this.cmbDivision = new ComboBox();
			this.cmbCargos = new ComboBox();
			this.panel1 = new Panel();
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.tEmpresaTableAdapter = new TEmpresaTableAdapter();
			this.panel3 = new Panel();
			this.cmbEstado = new ComboBox();
			this.radioButton2 = new RadioButton();
			this.radioButton1 = new RadioButton();
			this.textBox1 = new TextBox();
			this.button1 = new Button();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.tInicio = new Timer(this.components);
			Label label = new Label();
			Label point = new Label();
			Label size = new Label();
			Label label1 = new Label();
			Label point1 = new Label();
			Label size1 = new Label();
			Label label2 = new Label();
			Label point2 = new Label();
			Label size2 = new Label();
			Label label3 = new Label();
			Label point3 = new Label();
			Label size3 = new Label();
			Label label4 = new Label();
			Label point4 = new Label();
			Label size4 = new Label();
			Label label5 = new Label();
			Label point5 = new Label();
			Label size5 = new Label();
			Label label6 = new Label();
			Label point6 = new Label();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingNavigator).BeginInit();
			this.tEmpleadoBindingNavigator.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			label.AutoSize = true;
			label.Location = new Point(89, 201);
			label.Name = "idEmpleadoLabel";
			label.Size = new System.Drawing.Size(68, 13);
			label.TabIndex = 16;
			label.Text = "id Empleado:";
			point.AutoSize = true;
			point.Location = new Point(60, 119);
			point.Name = "nombreLabel";
			point.Size = new System.Drawing.Size(47, 13);
			point.TabIndex = 18;
			point.Text = "Nombre:";
			size.AutoSize = true;
			size.Location = new Point(10, 67);
			size.Name = "idTipoIdentificacionLabel";
			size.Size = new System.Drawing.Size(97, 13);
			size.TabIndex = 20;
			size.Text = "Tipo Identificacion:";
			label1.AutoSize = true;
			label1.Location = new Point(34, 93);
			label1.Name = "identificacionLabel";
			label1.Size = new System.Drawing.Size(73, 13);
			label1.TabIndex = 22;
			label1.Text = "Identificacion:";
			point1.AutoSize = true;
			point1.Location = new Point(89, 172);
			point1.Name = "notarjetaLabel";
			point1.Size = new System.Drawing.Size(53, 13);
			point1.TabIndex = 24;
			point1.Text = "Notarjeta:";
			size1.AutoSize = true;
			size1.Location = new Point(83, 110);
			size1.Name = "idCargoLabel";
			size1.Size = new System.Drawing.Size(49, 13);
			size1.TabIndex = 26;
			size1.Text = "id Cargo:";
			label2.AutoSize = true;
			label2.Location = new Point(74, 58);
			label2.Name = "idTipoEstadoLabel";
			label2.Size = new System.Drawing.Size(78, 13);
			label2.TabIndex = 28;
			label2.Text = "id Tipo Estado:";
			point2.AutoSize = true;
			point2.Location = new Point(89, 142);
			point2.Name = "idEmpresaLabel";
			point2.Size = new System.Drawing.Size(62, 13);
			point2.TabIndex = 30;
			point2.Text = "id Empresa:";
			size2.AutoSize = true;
			size2.Location = new Point(74, 84);
			size2.Name = "idDivisionEmpresaLabel";
			size2.Size = new System.Drawing.Size(102, 13);
			size2.TabIndex = 32;
			size2.Text = "id Division Empresa:";
			label3.AutoSize = true;
			label3.Location = new Point(89, 253);
			label3.Name = "idHorarioLabel";
			label3.Size = new System.Drawing.Size(55, 13);
			label3.TabIndex = 34;
			label3.Text = "id Horario:";
			point3.AutoSize = true;
			point3.Location = new Point(28, 273);
			point3.Name = "observacionesLabel";
			point3.Size = new System.Drawing.Size(79, 13);
			point3.TabIndex = 36;
			point3.Text = "observaciones:";
			size3.AutoSize = true;
			size3.Location = new Point(89, 280);
			size3.Name = "fechaUltimaGestionLabel";
			size3.Size = new System.Drawing.Size(108, 13);
			size3.TabIndex = 38;
			size3.Text = "fecha Ultima Gestion:";
			label4.AutoSize = true;
			label4.Location = new Point(89, 305);
			label4.Name = "usuarioUltimaGestionLabel";
			label4.Size = new System.Drawing.Size(115, 13);
			label4.TabIndex = 40;
			label4.Text = "usuario Ultima Gestion:";
			point4.AutoSize = true;
			point4.Location = new Point(74, 6);
			point4.Name = "usuarioHuellaLabel";
			point4.Size = new System.Drawing.Size(77, 13);
			point4.TabIndex = 42;
			point4.Text = "usuario Huella:";
			size4.AutoSize = true;
			size4.Location = new Point(74, 32);
			size4.Name = "idTarjetaLabel";
			size4.Size = new System.Drawing.Size(54, 13);
			size4.TabIndex = 44;
			size4.Text = "id Tarjeta:";
			label5.AutoSize = true;
			label5.Location = new Point(54, 246);
			label5.Name = "label2";
			label5.Size = new System.Drawing.Size(53, 13);
			label5.TabIndex = 48;
			label5.Text = "Notarjeta:";
			point5.AutoSize = true;
			point5.Location = new Point(56, 145);
			point5.Name = "label3";
			point5.Size = new System.Drawing.Size(51, 13);
			point5.TabIndex = 50;
			point5.Text = "Empresa:";
			size5.AutoSize = true;
			size5.Location = new Point(16, 172);
			size5.Name = "label4";
			size5.Size = new System.Drawing.Size(91, 13);
			size5.TabIndex = 52;
			size5.Text = "Division Empresa:";
			label6.AutoSize = true;
			label6.Location = new Point(69, 200);
			label6.Name = "label5";
			label6.Size = new System.Drawing.Size(38, 13);
			label6.TabIndex = 54;
			label6.Text = "Cargo:";
			point6.AutoSize = true;
			point6.Location = new Point(65, 224);
			point6.Name = "label6";
			point6.Size = new System.Drawing.Size(43, 13);
			point6.TabIndex = 61;
			point6.Text = "Estado:";
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(929, 53);
			this.panel2.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Maestro de Empleado";
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpleadoTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = null;
			this.tableAdapterManager.TEmpleadoTableAdapter = this.tEmpleadoTableAdapter;
			this.tableAdapterManager.TEmpleadoVehiculoTableAdapter = null;
			this.tableAdapterManager.TEmpresaTableAdapter = null;
			this.tableAdapterManager.TEmpresaVisitanteTableAdapter = null;
			this.tableAdapterManager.TEstadoTableAdapter = null;
			this.tableAdapterManager.TFestivosTableAdapter = null;
			this.tableAdapterManager.THorarioTableAdapter = null;
			this.tableAdapterManager.TInnerAccionTableAdapter = null;
			this.tableAdapterManager.TinnerTableAdapter = null;
			this.tableAdapterManager.TipoVehiculoTableAdapter = null;
			this.tableAdapterManager.TMarcacionTableAdapter = null;
			this.tableAdapterManager.TMarcaVehiculoTableAdapter = null;
			this.tableAdapterManager.TModeloVehiculoTableAdapter = null;
			this.tableAdapterManager.TPanelTableAdapter = null;
			this.tableAdapterManager.TParqueoTableAdapter = null;
			this.tableAdapterManager.TRegistroEmpleadoTableAdapter = null;
			this.tableAdapterManager.TRegistroVehiculo1TableAdapter = null;
			this.tableAdapterManager.TRegistroVehiculoTableAdapter = null;
			this.tableAdapterManager.TTarjetaTableAdapter = null;
			this.tableAdapterManager.TTipoIdentificacionTableAdapter = null;
			this.tableAdapterManager.TTipoRegistroTableAdapter = null;
			this.tableAdapterManager.TTipoUsuarioTableAdapter = null;
			this.tableAdapterManager.TUsuarioTableAdapter = null;
			this.tableAdapterManager.TvehiculoParqueoTableAdapter = null;
			this.tableAdapterManager.TVehiculoTableAdapter = null;
			this.tableAdapterManager.TVisitanteTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaLogTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tEmpleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tEmpleadoBindingNavigator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.tEmpleadoBindingNavigator.BindingSource = this.tEmpleadoBindingSource;
			this.tEmpleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tEmpleadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tEmpleadoBindingNavigator.Dock = DockStyle.None;
			ToolStripItemCollection items = this.tEmpleadoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tEmpleadoBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tEmpleadoBindingNavigator.Location = new Point(68, 328);
			this.tEmpleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tEmpleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tEmpleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tEmpleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tEmpleadoBindingNavigator.Name = "tEmpleadoBindingNavigator";
			this.tEmpleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tEmpleadoBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.tEmpleadoBindingNavigator.TabIndex = 16;
			this.tEmpleadoBindingNavigator.Text = "bindingNavigator1";
			this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			this.bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveFirstItem.Image");
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			this.bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMovePreviousItem.Image");
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			this.bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveNextItem.Image");
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			this.bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveLastItem.Image");
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			this.tEmpleadoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tEmpleadoBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tEmpleadoBindingNavigatorSaveItem.Image");
			this.tEmpleadoBindingNavigatorSaveItem.Name = "tEmpleadoBindingNavigatorSaveItem";
			this.tEmpleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tEmpleadoBindingNavigatorSaveItem.Text = "Save Data";
			this.tEmpleadoBindingNavigatorSaveItem.Click += new EventHandler(this.tEmpleadoBindingNavigatorSaveItem_Click);
			this.idEmpleadoTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idEmpleado", true));
			this.idEmpleadoTextBox.Location = new Point(210, 198);
			this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
			this.idEmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
			this.idEmpleadoTextBox.TabIndex = 17;
			this.nombreTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "nombre", true));
			this.nombreTextBox.Location = new Point(124, 116);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(363, 20);
			this.nombreTextBox.TabIndex = 19;
			this.idTipoIdentificacionTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idTipoIdentificacion", true));
			this.idTipoIdentificacionTextBox.Location = new Point(210, 224);
			this.idTipoIdentificacionTextBox.Name = "idTipoIdentificacionTextBox";
			this.idTipoIdentificacionTextBox.Size = new System.Drawing.Size(200, 20);
			this.idTipoIdentificacionTextBox.TabIndex = 21;
			this.idTipoIdentificacionTextBox.TextChanged += new EventHandler(this.idTipoIdentificacionTextBox_TextChanged);
			this.identificacionTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "identificacion", true));
			this.identificacionTextBox.Location = new Point(124, 90);
			this.identificacionTextBox.Name = "identificacionTextBox";
			this.identificacionTextBox.Size = new System.Drawing.Size(363, 20);
			this.identificacionTextBox.TabIndex = 23;
			this.notarjetaTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "Notarjeta", true));
			this.notarjetaTextBox.Location = new Point(210, 169);
			this.notarjetaTextBox.Name = "notarjetaTextBox";
			this.notarjetaTextBox.Size = new System.Drawing.Size(200, 20);
			this.notarjetaTextBox.TabIndex = 25;
			this.notarjetaTextBox.TextChanged += new EventHandler(this.notarjetaTextBox_TextChanged);
			this.idCargoTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idCargo", true));
			this.idCargoTextBox.Location = new Point(204, 107);
			this.idCargoTextBox.Name = "idCargoTextBox";
			this.idCargoTextBox.Size = new System.Drawing.Size(200, 20);
			this.idCargoTextBox.TabIndex = 27;
			this.idCargoTextBox.TextChanged += new EventHandler(this.idCargoTextBox_TextChanged);
			this.idTipoEstadoTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idTipoEstado", true));
			this.idTipoEstadoTextBox.Location = new Point(195, 55);
			this.idTipoEstadoTextBox.Name = "idTipoEstadoTextBox";
			this.idTipoEstadoTextBox.Size = new System.Drawing.Size(200, 20);
			this.idTipoEstadoTextBox.TabIndex = 29;
			this.idTipoEstadoTextBox.TextChanged += new EventHandler(this.idTipoEstadoTextBox_TextChanged);
			this.idEmpresaTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idEmpresa", true));
			this.idEmpresaTextBox.Location = new Point(210, 139);
			this.idEmpresaTextBox.Name = "idEmpresaTextBox";
			this.idEmpresaTextBox.Size = new System.Drawing.Size(200, 20);
			this.idEmpresaTextBox.TabIndex = 31;
			this.idEmpresaTextBox.TextChanged += new EventHandler(this.idEmpresaTextBox_TextChanged);
			this.idDivisionEmpresaTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idDivisionEmpresa", true));
			this.idDivisionEmpresaTextBox.Location = new Point(195, 81);
			this.idDivisionEmpresaTextBox.Name = "idDivisionEmpresaTextBox";
			this.idDivisionEmpresaTextBox.Size = new System.Drawing.Size(200, 20);
			this.idDivisionEmpresaTextBox.TabIndex = 33;
			this.idHorarioTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idHorario", true));
			this.idHorarioTextBox.Location = new Point(210, 250);
			this.idHorarioTextBox.Name = "idHorarioTextBox";
			this.idHorarioTextBox.Size = new System.Drawing.Size(200, 20);
			this.idHorarioTextBox.TabIndex = 35;
			this.observacionesTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "observaciones", true));
			this.observacionesTextBox.Location = new Point(125, 270);
			this.observacionesTextBox.Multiline = true;
			this.observacionesTextBox.Name = "observacionesTextBox";
			this.observacionesTextBox.Size = new System.Drawing.Size(362, 52);
			this.observacionesTextBox.TabIndex = 37;
			this.fechaUltimaGestionDateTimePicker.DataBindings.Add(new Binding("Value", this.tEmpleadoBindingSource, "fechaUltimaGestion", true));
			this.fechaUltimaGestionDateTimePicker.Location = new Point(210, 276);
			this.fechaUltimaGestionDateTimePicker.Name = "fechaUltimaGestionDateTimePicker";
			this.fechaUltimaGestionDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechaUltimaGestionDateTimePicker.TabIndex = 39;
			this.usuarioUltimaGestionTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "usuarioUltimaGestion", true));
			this.usuarioUltimaGestionTextBox.Location = new Point(210, 302);
			this.usuarioUltimaGestionTextBox.Name = "usuarioUltimaGestionTextBox";
			this.usuarioUltimaGestionTextBox.Size = new System.Drawing.Size(200, 20);
			this.usuarioUltimaGestionTextBox.TabIndex = 41;
			this.usuarioHuellaTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "usuarioHuella", true));
			this.usuarioHuellaTextBox.Location = new Point(195, 3);
			this.usuarioHuellaTextBox.Name = "usuarioHuellaTextBox";
			this.usuarioHuellaTextBox.Size = new System.Drawing.Size(200, 20);
			this.usuarioHuellaTextBox.TabIndex = 43;
			this.idTarjetaTextBox.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idTarjeta", true));
			this.idTarjetaTextBox.Location = new Point(195, 29);
			this.idTarjetaTextBox.Name = "idTarjetaTextBox";
			this.idTarjetaTextBox.Size = new System.Drawing.Size(200, 20);
			this.idTarjetaTextBox.TabIndex = 45;
			this.idTarjetaTextBox.TextChanged += new EventHandler(this.idTarjetaTextBox_TextChanged);
			this.cmbTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbTipoIdentificacion.FormattingEnabled = true;
			this.cmbTipoIdentificacion.Location = new Point(124, 63);
			this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
			this.cmbTipoIdentificacion.Size = new System.Drawing.Size(363, 21);
			this.cmbTipoIdentificacion.TabIndex = 46;
			this.cmbTipoIdentificacion.SelectedIndexChanged += new EventHandler(this.cmbTipoIdentificacion_SelectedIndexChanged);
			this.cmbTarjetas.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cmbTarjetas.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cmbTarjetas.FormattingEnabled = true;
			this.cmbTarjetas.Location = new Point(125, 243);
			this.cmbTarjetas.Name = "cmbTarjetas";
			this.cmbTarjetas.Size = new System.Drawing.Size(363, 21);
			this.cmbTarjetas.TabIndex = 47;
			this.cmbTarjetas.SelectedIndexChanged += new EventHandler(this.cmbTarjetas_SelectedIndexChanged);
			this.cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbEmpresa.FormattingEnabled = true;
			this.cmbEmpresa.Location = new Point(124, 142);
			this.cmbEmpresa.Name = "cmbEmpresa";
			this.cmbEmpresa.Size = new System.Drawing.Size(363, 21);
			this.cmbEmpresa.TabIndex = 49;
			this.cmbEmpresa.SelectedIndexChanged += new EventHandler(this.cmbEmpresa_SelectedIndexChanged);
			this.cmbDivision.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbDivision.FormattingEnabled = true;
			this.cmbDivision.Location = new Point(124, 169);
			this.cmbDivision.Name = "cmbDivision";
			this.cmbDivision.Size = new System.Drawing.Size(363, 21);
			this.cmbDivision.TabIndex = 51;
			this.cmbDivision.SelectedIndexChanged += new EventHandler(this.cmbDivision_SelectedIndexChanged);
			this.cmbCargos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cmbCargos.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cmbCargos.FormattingEnabled = true;
			this.cmbCargos.Location = new Point(124, 196);
			this.cmbCargos.Name = "cmbCargos";
			this.cmbCargos.Size = new System.Drawing.Size(363, 21);
			this.cmbCargos.TabIndex = 53;
			this.cmbCargos.SelectedIndexChanged += new EventHandler(this.cmbCargos_SelectedIndexChanged);
			this.panel1.Controls.Add(this.usuarioHuellaTextBox);
			this.panel1.Controls.Add(point1);
			this.panel1.Controls.Add(this.idTarjetaTextBox);
			this.panel1.Controls.Add(this.notarjetaTextBox);
			this.panel1.Controls.Add(size4);
			this.panel1.Controls.Add(size1);
			this.panel1.Controls.Add(this.idCargoTextBox);
			this.panel1.Controls.Add(point4);
			this.panel1.Controls.Add(label2);
			this.panel1.Controls.Add(this.idTipoIdentificacionTextBox);
			this.panel1.Controls.Add(this.usuarioUltimaGestionTextBox);
			this.panel1.Controls.Add(this.idTipoEstadoTextBox);
			this.panel1.Controls.Add(point2);
			this.panel1.Controls.Add(label4);
			this.panel1.Controls.Add(this.idEmpresaTextBox);
			this.panel1.Controls.Add(size2);
			this.panel1.Controls.Add(this.fechaUltimaGestionDateTimePicker);
			this.panel1.Controls.Add(this.idEmpleadoTextBox);
			this.panel1.Controls.Add(this.idDivisionEmpresaTextBox);
			this.panel1.Controls.Add(size3);
			this.panel1.Controls.Add(label);
			this.panel1.Controls.Add(label3);
			this.panel1.Controls.Add(this.idHorarioTextBox);
			this.panel1.Location = new Point(155, 283);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(117, 20);
			this.panel1.TabIndex = 55;
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpresaTableAdapter.ClearBeforeFill = true;
			this.panel3.BackColor = Color.Gainsboro;
			this.panel3.Controls.Add(this.observacionesTextBox);
			this.panel3.Controls.Add(point6);
			this.panel3.Controls.Add(this.cmbEstado);
			this.panel3.Controls.Add(this.panel1);
			this.panel3.Controls.Add(this.radioButton2);
			this.panel3.Controls.Add(this.radioButton1);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.cmbTipoIdentificacion);
			this.panel3.Controls.Add(this.tEmpleadoBindingNavigator);
			this.panel3.Controls.Add(point3);
			this.panel3.Controls.Add(this.identificacionTextBox);
			this.panel3.Controls.Add(label6);
			this.panel3.Controls.Add(label1);
			this.panel3.Controls.Add(this.cmbCargos);
			this.panel3.Controls.Add(size);
			this.panel3.Controls.Add(size5);
			this.panel3.Controls.Add(this.nombreTextBox);
			this.panel3.Controls.Add(this.cmbDivision);
			this.panel3.Controls.Add(point);
			this.panel3.Controls.Add(point5);
			this.panel3.Controls.Add(this.cmbTarjetas);
			this.panel3.Controls.Add(this.cmbEmpresa);
			this.panel3.Controls.Add(label5);
			this.panel3.Location = new Point(234, 71);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(517, 359);
			this.panel3.TabIndex = 56;
			this.cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Location = new Point(125, 220);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(363, 21);
			this.cmbEstado.TabIndex = 60;
			this.cmbEstado.SelectedIndexChanged += new EventHandler(this.cmbEstado_SelectedIndexChanged);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(210, 9);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(62, 17);
			this.radioButton2.TabIndex = 59;
			this.radioButton2.Text = "Nombre";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new Point(125, 9);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(80, 17);
			this.radioButton1.TabIndex = 58;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Documento";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.textBox1.Location = new Point(125, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(264, 20);
			this.textBox1.TabIndex = 57;
			this.button1.Image = Resources.Action_Printing_Preview;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(395, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 49);
			this.button1.TabIndex = 56;
			this.button1.Text = "Buscar...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.radDesktopAlert1.AutoCloseDelay = 5;
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			this.tInicio.Interval = 500;
			this.tInicio.Tick += new EventHandler(this.tInicio_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(929, 456);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel3);
			base.Name = "frmEmpleadoOk";
			this.Text = "Empleado";
			base.Load += new EventHandler(this.frmEmpleadoOk_Load);
			base.SizeChanged += new EventHandler(this.frmEmpleadoOk_SizeChanged);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingNavigator).EndInit();
			this.tEmpleadoBindingNavigator.ResumeLayout(false);
			this.tEmpleadoBindingNavigator.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		public void llenaT()
		{
			Tarjetas tarjeta = new Tarjetas();
			this.cmbTarjetas.DataSource = tarjeta.ListarTodas();
			this.cmbTarjetas.DisplayMember = "numtarjeta";
			this.cmbTarjetas.ValueMember = "idTarjeta";
		}

		private void notarjetaTextBox_TextChanged(object sender, EventArgs e)
		{
		}

		private void tEmpleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea realizar las operaciones pendientes?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				base.Validate();
				this.tEmpleadoBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
				MessageBox.Show("El registro se proceso con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
			}
		}

		private void tInicio_Tick(object sender, EventArgs e)
		{
			this.tInicio.Enabled = false;
			this.tEmpresaTableAdapter.Fill(this.masterDBACDataSet.TEmpresa);
			TiposIdentificacion tiposIdentificacion = new TiposIdentificacion();
			this.cmbTipoIdentificacion.DataSource = tiposIdentificacion.ListarTodos();
			this.cmbTipoIdentificacion.DisplayMember = "descripcionIdentificacion";
			this.cmbTipoIdentificacion.ValueMember = "idTipoIdentificacion";
			this.llenaT();
			Empresas empresa = new Empresas();
			this.cmbEmpresa.DataSource = empresa.ListarTodas();
			this.cmbEmpresa.DisplayMember = "RazonSocial";
			this.cmbEmpresa.ValueMember = "idEmpresa";
			Cargos cargo = new Cargos();
			this.cmbCargos.DataSource = cargo.ListarTodas();
			this.cmbCargos.DisplayMember = "NombreCargo";
			this.cmbCargos.ValueMember = "idCargo";
			EstadosEmpleado estadosEmpleado = new EstadosEmpleado();
			this.cmbEstado.DataSource = estadosEmpleado.ListarTodos();
			this.cmbEstado.DisplayMember = "NombreEstado";
			this.cmbEstado.ValueMember = "idTipoEstado";
			this.tEmpleadoTableAdapter.Fill(this.masterDBACDataSet.TEmpleado);
		}
	}
}