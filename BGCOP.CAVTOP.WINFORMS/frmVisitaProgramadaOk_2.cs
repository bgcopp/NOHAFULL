using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmVisitaProgramadaOk_2 : Form
	{
		private IContainer components = null;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tVisitaProgramadaBindingSource;

		private TVisitaProgramadaTableAdapter tVisitaProgramadaTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tVisitaProgramadaBindingNavigator;

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

		private ToolStripButton tVisitaProgramadaBindingNavigatorSaveItem;

		private TextBox idVisitaProgramadaTextBox;

		private TextBox descripcionVisitaTextBox;

		private DateTimePicker fechaInicioDateTimePicker;

		private DateTimePicker fechafinDateTimePicker;

		private TextBox idEmpresaTextBox;

		private TextBox idEmpleadoTextBox;

		private TextBox observacionesVisitaTextBox;

		private TextBox idEstadoVisitaTextBox;

		private DateTimePicker fechadeIngresoDateTimePicker;

		private DateTimePicker fechaUltimaGestionDateTimePicker;

		private TextBox usuarioUltimaGestionTextBox;

		private TextBox idDivisionEmpresaTextBox;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private BindingSource tEmpresaBindingSource;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private ComboBox razonSocialComboBox;

		private BindingSource tEmpleadoBindingSource;

		private ComboBox nombreComboBox;

		private TextBox idDivisionEmpresaTextBox1;

		private TextBox textBox1;

		private GroupBox groupBox1;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		public frmVisitaProgramadaOk_2()
		{
			this.InitializeComponent();
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			this.fechaInicioDateTimePicker.Value = DateTime.Now;
			this.fechafinDateTimePicker.Value = DateTime.Now;
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
		}

		public void centrarPanel()
		{
			this.panel1.Top = (base.Height - this.panel1.Height) / 2;
			this.panel1.Left = (base.Width - this.panel1.Width) / 2;
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmVisitaProgramadaOk_2_Load(object sender, EventArgs e)
		{
			this.fechaInicioDateTimePicker.Value = DateTime.Now;
			this.fechafinDateTimePicker.Value = DateTime.Now;
			this.tEmpresaTableAdapter.Fill(this.masterDBACDataSet.TEmpresa);
			this.tVisitaProgramadaTableAdapter.Fill(this.masterDBACDataSet.TVisitaProgramada);
		}

		private void frmVisitaProgramadaOk_2_SizeChanged(object sender, EventArgs e)
		{
			this.centrarPanel();
		}

		private void idEmpleadoTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.nombreComboBox.SelectedValue = Convert.ToInt32(this.idEmpleadoTextBox.Text);
			}
			catch (Exception exception)
			{
				this.nombreComboBox.SelectedIndex = -1;
			}
		}

		private void idEmpresaTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.razonSocialComboBox.SelectedValue = Convert.ToInt32(this.idEmpresaTextBox.Text);
				this.tEmpleadoTableAdapter.FillByEmpleadobyEmpresa(this.masterDBACDataSet.TEmpleado, Convert.ToInt32(this.idEmpresaTextBox.Text));
			}
			catch (Exception exception)
			{
				this.razonSocialComboBox.SelectedIndex = -1;
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVisitaProgramadaOk_2));
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tVisitaProgramadaBindingSource = new BindingSource(this.components);
			this.tVisitaProgramadaTableAdapter = new TVisitaProgramadaTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.tEmpresaTableAdapter = new TEmpresaTableAdapter();
			this.tVisitaProgramadaBindingNavigator = new BindingNavigator(this.components);
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
			this.tVisitaProgramadaBindingNavigatorSaveItem = new ToolStripButton();
			this.idVisitaProgramadaTextBox = new TextBox();
			this.descripcionVisitaTextBox = new TextBox();
			this.fechaInicioDateTimePicker = new DateTimePicker();
			this.fechafinDateTimePicker = new DateTimePicker();
			this.idEmpresaTextBox = new TextBox();
			this.idEmpleadoTextBox = new TextBox();
			this.observacionesVisitaTextBox = new TextBox();
			this.idEstadoVisitaTextBox = new TextBox();
			this.fechadeIngresoDateTimePicker = new DateTimePicker();
			this.fechaUltimaGestionDateTimePicker = new DateTimePicker();
			this.usuarioUltimaGestionTextBox = new TextBox();
			this.idDivisionEmpresaTextBox = new TextBox();
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.razonSocialComboBox = new ComboBox();
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.nombreComboBox = new ComboBox();
			this.idDivisionEmpresaTextBox1 = new TextBox();
			this.textBox1 = new TextBox();
			this.groupBox1 = new GroupBox();
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.label1 = new Label();
			Label label = new Label();
			Label font = new Label();
			Label point = new Label();
			Label size = new Label();
			Label label1 = new Label();
			Label point1 = new Label();
			Label font1 = new Label();
			Label size1 = new Label();
			Label label2 = new Label();
			Label point2 = new Label();
			Label size2 = new Label();
			Label label3 = new Label();
			Label font2 = new Label();
			Label font3 = new Label();
			Label point3 = new Label();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingNavigator).BeginInit();
			this.tVisitaProgramadaBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			label.AutoSize = true;
			label.Location = new Point(18, 170);
			label.Name = "idVisitaProgramadaLabel";
			label.Size = new System.Drawing.Size(137, 16);
			label.TabIndex = 1;
			label.Text = "id Visita Programada:";
			font.AutoSize = true;
			font.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			font.Location = new Point(25, 70);
			font.Name = "descripcionVisitaLabel";
			font.Size = new System.Drawing.Size(119, 16);
			font.TabIndex = 3;
			font.Text = "Descripcion Visita:";
			point.AutoSize = true;
			point.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			point.Location = new Point(61, 97);
			point.Name = "fechaInicioLabel";
			point.Size = new System.Drawing.Size(83, 16);
			point.TabIndex = 5;
			point.Text = "Fecha Inicio:";
			size.AutoSize = true;
			size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			size.Location = new Point(74, 123);
			size.Name = "fechafinLabel";
			size.Size = new System.Drawing.Size(70, 16);
			size.TabIndex = 7;
			size.Text = "Fecha Fin:";
			label1.AutoSize = true;
			label1.Location = new Point(19, 226);
			label1.Name = "idEmpresaLabel";
			label1.Size = new System.Drawing.Size(80, 16);
			label1.TabIndex = 9;
			label1.Text = "id Empresa:";
			point1.AutoSize = true;
			point1.Location = new Point(19, 252);
			point1.Name = "idEmpleadoLabel";
			point1.Size = new System.Drawing.Size(88, 16);
			point1.TabIndex = 11;
			point1.Text = "id Empleado:";
			font1.AutoSize = true;
			font1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			font1.Location = new Point(5, 200);
			font1.Name = "observacionesVisitaLabel";
			font1.Size = new System.Drawing.Size(139, 16);
			font1.TabIndex = 13;
			font1.Text = "Observaciones Visita:";
			size1.AutoSize = true;
			size1.Location = new Point(18, 32);
			size1.Name = "idEstadoVisitaLabel";
			size1.Size = new System.Drawing.Size(104, 16);
			size1.TabIndex = 15;
			size1.Text = "id Estado Visita:";
			label2.AutoSize = true;
			label2.Location = new Point(18, 59);
			label2.Name = "fechadeIngresoLabel";
			label2.Size = new System.Drawing.Size(108, 16);
			label2.TabIndex = 17;
			label2.Text = "fechade Ingreso:";
			point2.AutoSize = true;
			point2.Location = new Point(18, 85);
			point2.Name = "fechaUltimaGestionLabel";
			point2.Size = new System.Drawing.Size(134, 16);
			point2.TabIndex = 19;
			point2.Text = "fecha Ultima Gestion:";
			size2.AutoSize = true;
			size2.Location = new Point(18, 110);
			size2.Name = "usuarioUltimaGestionLabel";
			size2.Size = new System.Drawing.Size(145, 16);
			size2.TabIndex = 21;
			size2.Text = "usuario Ultima Gestion:";
			label3.AutoSize = true;
			label3.Location = new Point(18, 136);
			label3.Name = "idDivisionEmpresaLabel";
			label3.Size = new System.Drawing.Size(131, 16);
			label3.TabIndex = 23;
			label3.Text = "Id Division Empresa:";
			font2.AutoSize = true;
			font2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			font2.Location = new Point(78, 148);
			font2.Name = "razonSocialLabel";
			font2.Size = new System.Drawing.Size(66, 16);
			font2.TabIndex = 25;
			font2.Text = "Empresa:";
			font3.AutoSize = true;
			font3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			font3.Location = new Point(18, 177);
			font3.Name = "nombreLabel";
			font3.Size = new System.Drawing.Size(126, 16);
			font3.TabIndex = 27;
			font3.Text = "Nombre Empleado:";
			point3.AutoSize = true;
			point3.Location = new Point(32, 278);
			point3.Name = "idDivisionEmpresaLabel1";
			point3.Size = new System.Drawing.Size(131, 16);
			point3.TabIndex = 29;
			point3.Text = "id Division Empresa:";
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tVisitaProgramadaBindingSource.DataMember = "TVisitaProgramada";
			this.tVisitaProgramadaBindingSource.DataSource = this.masterDBACDataSet;
			this.tVisitaProgramadaTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = null;
			this.tableAdapterManager.TEmpleadoTableAdapter = this.tEmpleadoTableAdapter;
			this.tableAdapterManager.TEmpleadoVehiculoTableAdapter = null;
			this.tableAdapterManager.TEmpresaTableAdapter = this.tEmpresaTableAdapter;
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
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = this.tVisitaProgramadaTableAdapter;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tEmpleadoTableAdapter.ClearBeforeFill = true;
			this.tEmpresaTableAdapter.ClearBeforeFill = true;
			this.tVisitaProgramadaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tVisitaProgramadaBindingNavigator.BindingSource = this.tVisitaProgramadaBindingSource;
			this.tVisitaProgramadaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tVisitaProgramadaBindingNavigator.CountItemFormat = "de {0}";
			this.tVisitaProgramadaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tVisitaProgramadaBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tVisitaProgramadaBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tVisitaProgramadaBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tVisitaProgramadaBindingNavigator.Location = new Point(0, 480);
			this.tVisitaProgramadaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tVisitaProgramadaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tVisitaProgramadaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tVisitaProgramadaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tVisitaProgramadaBindingNavigator.Name = "tVisitaProgramadaBindingNavigator";
			this.tVisitaProgramadaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tVisitaProgramadaBindingNavigator.Size = new System.Drawing.Size(798, 25);
			this.tVisitaProgramadaBindingNavigator.TabIndex = 0;
			this.tVisitaProgramadaBindingNavigator.Text = "bindingNavigator1";
			this.tVisitaProgramadaBindingNavigator.RefreshItems += new EventHandler(this.tVisitaProgramadaBindingNavigator_RefreshItems);
			this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new EventHandler(this.bindingNavigatorAddNewItem_Click);
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			this.bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new EventHandler(this.bindingNavigatorDeleteItem_Click);
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
			this.tVisitaProgramadaBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tVisitaProgramadaBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tVisitaProgramadaBindingNavigatorSaveItem.Image");
			this.tVisitaProgramadaBindingNavigatorSaveItem.Name = "tVisitaProgramadaBindingNavigatorSaveItem";
			this.tVisitaProgramadaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tVisitaProgramadaBindingNavigatorSaveItem.Text = "Save Data";
			this.tVisitaProgramadaBindingNavigatorSaveItem.Click += new EventHandler(this.tVisitaProgramadaBindingNavigatorSaveItem_Click);
			this.idVisitaProgramadaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idVisitaProgramada", true));
			this.idVisitaProgramadaTextBox.Location = new Point(140, 167);
			this.idVisitaProgramadaTextBox.Name = "idVisitaProgramadaTextBox";
			this.idVisitaProgramadaTextBox.Size = new System.Drawing.Size(200, 22);
			this.idVisitaProgramadaTextBox.TabIndex = 2;
			this.descripcionVisitaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.descripcionVisitaTextBox.BackColor = Color.LightGoldenrodYellow;
			this.descripcionVisitaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "DescripcionVisita", true));
			this.descripcionVisitaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.descripcionVisitaTextBox.Location = new Point(148, 67);
			this.descripcionVisitaTextBox.Name = "descripcionVisitaTextBox";
			this.descripcionVisitaTextBox.Size = new System.Drawing.Size(488, 22);
			this.descripcionVisitaTextBox.TabIndex = 4;
			this.fechaInicioDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.fechaInicioDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechaInicio", true));
			this.fechaInicioDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fechaInicioDateTimePicker.Location = new Point(148, 92);
			this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
			this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(488, 22);
			this.fechaInicioDateTimePicker.TabIndex = 6;
			this.fechafinDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.fechafinDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechafin", true));
			this.fechafinDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.fechafinDateTimePicker.Location = new Point(148, 119);
			this.fechafinDateTimePicker.Name = "fechafinDateTimePicker";
			this.fechafinDateTimePicker.Size = new System.Drawing.Size(488, 22);
			this.fechafinDateTimePicker.TabIndex = 8;
			this.idEmpresaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idEmpresa", true));
			this.idEmpresaTextBox.Location = new Point(140, 223);
			this.idEmpresaTextBox.Name = "idEmpresaTextBox";
			this.idEmpresaTextBox.Size = new System.Drawing.Size(200, 22);
			this.idEmpresaTextBox.TabIndex = 10;
			this.idEmpresaTextBox.TextChanged += new EventHandler(this.idEmpresaTextBox_TextChanged);
			this.idEmpleadoTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idEmpleado", true));
			this.idEmpleadoTextBox.Location = new Point(140, 249);
			this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
			this.idEmpleadoTextBox.Size = new System.Drawing.Size(200, 22);
			this.idEmpleadoTextBox.TabIndex = 12;
			this.idEmpleadoTextBox.TextChanged += new EventHandler(this.idEmpleadoTextBox_TextChanged);
			this.observacionesVisitaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.observacionesVisitaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "ObservacionesVisita", true));
			this.observacionesVisitaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.observacionesVisitaTextBox.Location = new Point(148, 200);
			this.observacionesVisitaTextBox.Multiline = true;
			this.observacionesVisitaTextBox.Name = "observacionesVisitaTextBox";
			this.observacionesVisitaTextBox.ScrollBars = ScrollBars.Vertical;
			this.observacionesVisitaTextBox.Size = new System.Drawing.Size(488, 73);
			this.observacionesVisitaTextBox.TabIndex = 14;
			this.idEstadoVisitaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idEstadoVisita", true));
			this.idEstadoVisitaTextBox.Location = new Point(140, 29);
			this.idEstadoVisitaTextBox.Name = "idEstadoVisitaTextBox";
			this.idEstadoVisitaTextBox.Size = new System.Drawing.Size(200, 22);
			this.idEstadoVisitaTextBox.TabIndex = 16;
			this.fechadeIngresoDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechadeIngreso", true));
			this.fechadeIngresoDateTimePicker.Location = new Point(140, 55);
			this.fechadeIngresoDateTimePicker.Name = "fechadeIngresoDateTimePicker";
			this.fechadeIngresoDateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.fechadeIngresoDateTimePicker.TabIndex = 18;
			this.fechaUltimaGestionDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechaUltimaGestion", true));
			this.fechaUltimaGestionDateTimePicker.Location = new Point(140, 81);
			this.fechaUltimaGestionDateTimePicker.Name = "fechaUltimaGestionDateTimePicker";
			this.fechaUltimaGestionDateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.fechaUltimaGestionDateTimePicker.TabIndex = 20;
			this.usuarioUltimaGestionTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "usuarioUltimaGestion", true));
			this.usuarioUltimaGestionTextBox.Location = new Point(140, 107);
			this.usuarioUltimaGestionTextBox.Name = "usuarioUltimaGestionTextBox";
			this.usuarioUltimaGestionTextBox.Size = new System.Drawing.Size(200, 22);
			this.usuarioUltimaGestionTextBox.TabIndex = 22;
			this.idDivisionEmpresaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "IdDivisionEmpresa", true));
			this.idDivisionEmpresaTextBox.Location = new Point(140, 133);
			this.idDivisionEmpresaTextBox.Name = "idDivisionEmpresaTextBox";
			this.idDivisionEmpresaTextBox.Size = new System.Drawing.Size(200, 22);
			this.idDivisionEmpresaTextBox.TabIndex = 24;
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.razonSocialComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.razonSocialComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.razonSocialComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.razonSocialComboBox.DataSource = this.tEmpresaBindingSource;
			this.razonSocialComboBox.DisplayMember = "RazonSocial";
			this.razonSocialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.razonSocialComboBox.FormattingEnabled = true;
			this.razonSocialComboBox.Location = new Point(148, 145);
			this.razonSocialComboBox.Name = "razonSocialComboBox";
			this.razonSocialComboBox.Size = new System.Drawing.Size(488, 24);
			this.razonSocialComboBox.TabIndex = 26;
			this.razonSocialComboBox.ValueMember = "idEmpresa";
			this.razonSocialComboBox.SelectedIndexChanged += new EventHandler(this.razonSocialComboBox_SelectedIndexChanged);
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.nombreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.nombreComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.nombreComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.nombreComboBox.DataSource = this.tEmpleadoBindingSource;
			this.nombreComboBox.DisplayMember = "nombre";
			this.nombreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.nombreComboBox.FormattingEnabled = true;
			this.nombreComboBox.Location = new Point(148, 172);
			this.nombreComboBox.Name = "nombreComboBox";
			this.nombreComboBox.Size = new System.Drawing.Size(488, 24);
			this.nombreComboBox.TabIndex = 28;
			this.nombreComboBox.ValueMember = "idEmpleado";
			this.nombreComboBox.SelectedIndexChanged += new EventHandler(this.nombreComboBox_SelectedIndexChanged);
			this.idDivisionEmpresaTextBox1.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idDivisionEmpresa", true));
			this.idDivisionEmpresaTextBox1.Location = new Point(140, 275);
			this.idDivisionEmpresaTextBox1.Name = "idDivisionEmpresaTextBox1";
			this.idDivisionEmpresaTextBox1.Size = new System.Drawing.Size(121, 22);
			this.idDivisionEmpresaTextBox1.TabIndex = 30;
			this.textBox1.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idDivisionEmpresa", true));
			this.textBox1.Location = new Point(140, 197);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 31;
			this.groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.groupBox1.Controls.Add(this.idEstadoVisitaTextBox);
			this.groupBox1.Controls.Add(this.idDivisionEmpresaTextBox);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(label3);
			this.groupBox1.Controls.Add(point3);
			this.groupBox1.Controls.Add(this.usuarioUltimaGestionTextBox);
			this.groupBox1.Controls.Add(this.idDivisionEmpresaTextBox1);
			this.groupBox1.Controls.Add(size2);
			this.groupBox1.Controls.Add(this.fechaUltimaGestionDateTimePicker);
			this.groupBox1.Controls.Add(point2);
			this.groupBox1.Controls.Add(this.fechadeIngresoDateTimePicker);
			this.groupBox1.Controls.Add(label2);
			this.groupBox1.Controls.Add(label);
			this.groupBox1.Controls.Add(size1);
			this.groupBox1.Controls.Add(this.idVisitaProgramadaTextBox);
			this.groupBox1.Controls.Add(this.idEmpleadoTextBox);
			this.groupBox1.Controls.Add(point1);
			this.groupBox1.Controls.Add(this.idEmpresaTextBox);
			this.groupBox1.Controls.Add(label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.groupBox1.Location = new Point(174, 220);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 24);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.descripcionVisitaTextBox);
			this.panel1.Controls.Add(this.observacionesVisitaTextBox);
			this.panel1.Controls.Add(font1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.fechafinDateTimePicker);
			this.panel1.Controls.Add(size);
			this.panel1.Controls.Add(font3);
			this.panel1.Controls.Add(this.fechaInicioDateTimePicker);
			this.panel1.Controls.Add(this.nombreComboBox);
			this.panel1.Controls.Add(point);
			this.panel1.Controls.Add(font2);
			this.panel1.Controls.Add(font);
			this.panel1.Controls.Add(this.razonSocialComboBox);
			this.panel1.Location = new Point(53, 94);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(675, 310);
			this.panel1.TabIndex = 34;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(675, 53);
			this.panel2.TabIndex = 34;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Visita Programada";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(798, 505);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.tVisitaProgramadaBindingNavigator);
			base.Name = "frmVisitaProgramadaOk_2";
			this.Text = "Visita Programada";
			base.Load += new EventHandler(this.frmVisitaProgramadaOk_2_Load);
			base.SizeChanged += new EventHandler(this.frmVisitaProgramadaOk_2_SizeChanged);
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingNavigator).EndInit();
			this.tVisitaProgramadaBindingNavigator.ResumeLayout(false);
			this.tVisitaProgramadaBindingNavigator.PerformLayout();
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.idEmpleadoTextBox.Text = this.nombreComboBox.SelectedValue.ToString();
				this.idDivisionEmpresaTextBox.Text = this.idDivisionEmpresaTextBox1.Text;
			}
			catch (Exception exception)
			{
			}
		}

		private void razonSocialComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.idEmpresaTextBox.Text = this.razonSocialComboBox.SelectedValue.ToString();
				this.tEmpleadoTableAdapter.FillByEmpleadobyEmpresa(this.masterDBACDataSet.TEmpleado, Convert.ToInt32(this.idEmpresaTextBox.Text));
			}
			catch (Exception exception)
			{
			}
		}

		private void tVisitaProgramadaBindingNavigator_RefreshItems(object sender, EventArgs e)
		{
		}

		private void tVisitaProgramadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea realizar las operaciones pendientes?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				DateTime value = this.fechaInicioDateTimePicker.Value;
				DateTime dateTime = this.fechafinDateTimePicker.Value;
				this.fechaInicioDateTimePicker.Value = value.Date;
				this.fechafinDateTimePicker.Value = dateTime.Date.AddHours(12);
				base.Validate();
				this.tVisitaProgramadaBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
				MessageBox.Show("El registro se proceso con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
			}
		}
	}
}