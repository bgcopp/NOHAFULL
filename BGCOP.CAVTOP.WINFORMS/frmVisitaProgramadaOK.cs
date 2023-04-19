using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmVisitaProgramadaOK : Form
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

		private Panel panel2;

		private Label label1;

		private ListBox descripcionVisitaListBox;

		private TextBox descripcionVisitaTextBox;

		private BindingSource tEmpresaBindingSource;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private ComboBox razonSocialComboBox;

		private BindingSource tEmpleadoBindingSource;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private ComboBox nombreComboBox;

		public frmVisitaProgramadaOK()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmVisitaProgramadaOK_Load(object sender, EventArgs e)
		{
			this.tEmpresaTableAdapter.Fill(this.masterDBACDataSet.TEmpresa);
			this.tVisitaProgramadaTableAdapter.Fill(this.masterDBACDataSet.TVisitaProgramada);
		}

		private void idEmpleadoTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.nombreComboBox.SelectedValue = Convert.ToInt32(this.idEmpleadoTextBox.Text);
			}
			catch (Exception exception)
			{
			}
		}

		private void idEmpresaTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.razonSocialComboBox.SelectedValue = Convert.ToInt32(this.idEmpleadoTextBox.Text);
			}
			catch (Exception exception)
			{
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVisitaProgramadaOK));
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tVisitaProgramadaBindingSource = new BindingSource(this.components);
			this.tVisitaProgramadaTableAdapter = new TVisitaProgramadaTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
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
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.descripcionVisitaListBox = new ListBox();
			this.descripcionVisitaTextBox = new TextBox();
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.tEmpresaTableAdapter = new TEmpresaTableAdapter();
			this.razonSocialComboBox = new ComboBox();
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.nombreComboBox = new ComboBox();
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
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingNavigator).BeginInit();
			this.tVisitaProgramadaBindingNavigator.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			base.SuspendLayout();
			label.AutoSize = true;
			label.Location = new Point(233, 66);
			label.Name = "idVisitaProgramadaLabel";
			label.Size = new System.Drawing.Size(106, 13);
			label.TabIndex = 1;
			label.Text = "id Visita Programada:";
			point.AutoSize = true;
			point.Location = new Point(233, 92);
			point.Name = "descripcionVisitaLabel";
			point.Size = new System.Drawing.Size(94, 13);
			point.TabIndex = 3;
			point.Text = "Descripcion Visita:";
			size.AutoSize = true;
			size.Location = new Point(233, 120);
			size.Name = "fechaInicioLabel";
			size.Size = new System.Drawing.Size(65, 13);
			size.TabIndex = 5;
			size.Text = "fecha Inicio:";
			label1.AutoSize = true;
			label1.Location = new Point(233, 146);
			label1.Name = "fechafinLabel";
			label1.Size = new System.Drawing.Size(48, 13);
			label1.TabIndex = 7;
			label1.Text = "fechafin:";
			point1.AutoSize = true;
			point1.Location = new Point(690, 330);
			point1.Name = "idEmpresaLabel";
			point1.Size = new System.Drawing.Size(62, 13);
			point1.TabIndex = 9;
			point1.Text = "id Empresa:";
			size1.AutoSize = true;
			size1.Location = new Point(684, 298);
			size1.Name = "idEmpleadoLabel";
			size1.Size = new System.Drawing.Size(68, 13);
			size1.TabIndex = 11;
			size1.Text = "id Empleado:";
			label2.AutoSize = true;
			label2.Location = new Point(233, 223);
			label2.Name = "observacionesVisitaLabel";
			label2.Size = new System.Drawing.Size(109, 13);
			label2.TabIndex = 13;
			label2.Text = "Observaciones Visita:";
			point2.AutoSize = true;
			point2.Location = new Point(233, 249);
			point2.Name = "idEstadoVisitaLabel";
			point2.Size = new System.Drawing.Size(82, 13);
			point2.TabIndex = 15;
			point2.Text = "id Estado Visita:";
			size2.AutoSize = true;
			size2.Location = new Point(233, 276);
			size2.Name = "fechadeIngresoLabel";
			size2.Size = new System.Drawing.Size(87, 13);
			size2.TabIndex = 17;
			size2.Text = "fechade Ingreso:";
			label3.AutoSize = true;
			label3.Location = new Point(233, 302);
			label3.Name = "fechaUltimaGestionLabel";
			label3.Size = new System.Drawing.Size(108, 13);
			label3.TabIndex = 19;
			label3.Text = "fecha Ultima Gestion:";
			point3.AutoSize = true;
			point3.Location = new Point(233, 327);
			point3.Name = "usuarioUltimaGestionLabel";
			point3.Size = new System.Drawing.Size(115, 13);
			point3.TabIndex = 21;
			point3.Text = "usuario Ultima Gestion:";
			size3.AutoSize = true;
			size3.Location = new Point(233, 353);
			size3.Name = "idDivisionEmpresaLabel";
			size3.Size = new System.Drawing.Size(103, 13);
			size3.TabIndex = 23;
			size3.Text = "Id Division Empresa:";
			label4.AutoSize = true;
			label4.Location = new Point(233, 171);
			label4.Name = "razonSocialLabel";
			label4.Size = new System.Drawing.Size(73, 13);
			label4.TabIndex = 28;
			label4.Text = "Razon Social:";
			point4.AutoSize = true;
			point4.Location = new Point(261, 197);
			point4.Name = "nombreLabel";
			point4.Size = new System.Drawing.Size(57, 13);
			point4.TabIndex = 29;
			point4.Text = "Empleado:";
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tVisitaProgramadaBindingSource.DataMember = "TVisitaProgramada";
			this.tVisitaProgramadaBindingSource.DataSource = this.masterDBACDataSet;
			this.tVisitaProgramadaTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = null;
			this.tableAdapterManager.TEmpleadoTableAdapter = null;
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
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = this.tVisitaProgramadaTableAdapter;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tVisitaProgramadaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tVisitaProgramadaBindingNavigator.BindingSource = this.tVisitaProgramadaBindingSource;
			this.tVisitaProgramadaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tVisitaProgramadaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tVisitaProgramadaBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tVisitaProgramadaBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tVisitaProgramadaBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tVisitaProgramadaBindingNavigator.Location = new Point(0, 396);
			this.tVisitaProgramadaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tVisitaProgramadaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tVisitaProgramadaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tVisitaProgramadaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tVisitaProgramadaBindingNavigator.Name = "tVisitaProgramadaBindingNavigator";
			this.tVisitaProgramadaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tVisitaProgramadaBindingNavigator.Size = new System.Drawing.Size(855, 25);
			this.tVisitaProgramadaBindingNavigator.TabIndex = 0;
			this.tVisitaProgramadaBindingNavigator.Text = "bindingNavigator1";
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
			this.tVisitaProgramadaBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tVisitaProgramadaBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tVisitaProgramadaBindingNavigatorSaveItem.Image");
			this.tVisitaProgramadaBindingNavigatorSaveItem.Name = "tVisitaProgramadaBindingNavigatorSaveItem";
			this.tVisitaProgramadaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tVisitaProgramadaBindingNavigatorSaveItem.Text = "Save Data";
			this.tVisitaProgramadaBindingNavigatorSaveItem.Click += new EventHandler(this.tVisitaProgramadaBindingNavigatorSaveItem_Click);
			this.idVisitaProgramadaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idVisitaProgramada", true));
			this.idVisitaProgramadaTextBox.Location = new Point(354, 63);
			this.idVisitaProgramadaTextBox.Name = "idVisitaProgramadaTextBox";
			this.idVisitaProgramadaTextBox.Size = new System.Drawing.Size(200, 20);
			this.idVisitaProgramadaTextBox.TabIndex = 2;
			this.fechaInicioDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechaInicio", true));
			this.fechaInicioDateTimePicker.Location = new Point(354, 116);
			this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
			this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechaInicioDateTimePicker.TabIndex = 6;
			this.fechafinDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechafin", true));
			this.fechafinDateTimePicker.Location = new Point(354, 142);
			this.fechafinDateTimePicker.Name = "fechafinDateTimePicker";
			this.fechafinDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechafinDateTimePicker.TabIndex = 8;
			this.idEmpresaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idEmpresa", true));
			this.idEmpresaTextBox.Location = new Point(758, 327);
			this.idEmpresaTextBox.Name = "idEmpresaTextBox";
			this.idEmpresaTextBox.Size = new System.Drawing.Size(77, 20);
			this.idEmpresaTextBox.TabIndex = 10;
			this.idEmpresaTextBox.TextChanged += new EventHandler(this.idEmpresaTextBox_TextChanged);
			this.idEmpleadoTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idEmpleado", true));
			this.idEmpleadoTextBox.Location = new Point(758, 295);
			this.idEmpleadoTextBox.Name = "idEmpleadoTextBox";
			this.idEmpleadoTextBox.Size = new System.Drawing.Size(74, 20);
			this.idEmpleadoTextBox.TabIndex = 12;
			this.idEmpleadoTextBox.TextChanged += new EventHandler(this.idEmpleadoTextBox_TextChanged);
			this.observacionesVisitaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "ObservacionesVisita", true));
			this.observacionesVisitaTextBox.Location = new Point(354, 220);
			this.observacionesVisitaTextBox.Name = "observacionesVisitaTextBox";
			this.observacionesVisitaTextBox.Size = new System.Drawing.Size(200, 20);
			this.observacionesVisitaTextBox.TabIndex = 14;
			this.idEstadoVisitaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "idEstadoVisita", true));
			this.idEstadoVisitaTextBox.Location = new Point(354, 246);
			this.idEstadoVisitaTextBox.Name = "idEstadoVisitaTextBox";
			this.idEstadoVisitaTextBox.Size = new System.Drawing.Size(200, 20);
			this.idEstadoVisitaTextBox.TabIndex = 16;
			this.fechadeIngresoDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechadeIngreso", true));
			this.fechadeIngresoDateTimePicker.Location = new Point(354, 272);
			this.fechadeIngresoDateTimePicker.Name = "fechadeIngresoDateTimePicker";
			this.fechadeIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechadeIngresoDateTimePicker.TabIndex = 18;
			this.fechaUltimaGestionDateTimePicker.DataBindings.Add(new Binding("Value", this.tVisitaProgramadaBindingSource, "fechaUltimaGestion", true));
			this.fechaUltimaGestionDateTimePicker.Location = new Point(354, 298);
			this.fechaUltimaGestionDateTimePicker.Name = "fechaUltimaGestionDateTimePicker";
			this.fechaUltimaGestionDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechaUltimaGestionDateTimePicker.TabIndex = 20;
			this.usuarioUltimaGestionTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "usuarioUltimaGestion", true));
			this.usuarioUltimaGestionTextBox.Location = new Point(354, 324);
			this.usuarioUltimaGestionTextBox.Name = "usuarioUltimaGestionTextBox";
			this.usuarioUltimaGestionTextBox.Size = new System.Drawing.Size(200, 20);
			this.usuarioUltimaGestionTextBox.TabIndex = 22;
			this.idDivisionEmpresaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "IdDivisionEmpresa", true));
			this.idDivisionEmpresaTextBox.Location = new Point(354, 350);
			this.idDivisionEmpresaTextBox.Name = "idDivisionEmpresaTextBox";
			this.idDivisionEmpresaTextBox.Size = new System.Drawing.Size(200, 20);
			this.idDivisionEmpresaTextBox.TabIndex = 24;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(855, 53);
			this.panel2.TabIndex = 25;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Visitas Programadas";
			this.descripcionVisitaListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.descripcionVisitaListBox.DataBindings.Add(new Binding("SelectedValue", this.tVisitaProgramadaBindingSource, "DescripcionVisita", true));
			this.descripcionVisitaListBox.DataSource = this.tVisitaProgramadaBindingSource;
			this.descripcionVisitaListBox.DisplayMember = "DescripcionVisita";
			this.descripcionVisitaListBox.FormattingEnabled = true;
			this.descripcionVisitaListBox.Location = new Point(9, 60);
			this.descripcionVisitaListBox.Name = "descripcionVisitaListBox";
			this.descripcionVisitaListBox.Size = new System.Drawing.Size(218, 316);
			this.descripcionVisitaListBox.TabIndex = 27;
			this.descripcionVisitaTextBox.DataBindings.Add(new Binding("Text", this.tVisitaProgramadaBindingSource, "DescripcionVisita", true));
			this.descripcionVisitaTextBox.Location = new Point(354, 89);
			this.descripcionVisitaTextBox.Name = "descripcionVisitaTextBox";
			this.descripcionVisitaTextBox.Size = new System.Drawing.Size(200, 20);
			this.descripcionVisitaTextBox.TabIndex = 28;
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpresaTableAdapter.ClearBeforeFill = true;
			this.razonSocialComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.razonSocialComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.razonSocialComboBox.DataSource = this.tEmpresaBindingSource;
			this.razonSocialComboBox.DisplayMember = "RazonSocial";
			this.razonSocialComboBox.FormattingEnabled = true;
			this.razonSocialComboBox.Location = new Point(354, 168);
			this.razonSocialComboBox.Name = "razonSocialComboBox";
			this.razonSocialComboBox.Size = new System.Drawing.Size(200, 21);
			this.razonSocialComboBox.TabIndex = 29;
			this.razonSocialComboBox.ValueMember = "idEmpresa";
			this.razonSocialComboBox.SelectedIndexChanged += new EventHandler(this.razonSocialComboBox_SelectedIndexChanged);
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpleadoTableAdapter.ClearBeforeFill = true;
			this.nombreComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.nombreComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.nombreComboBox.DataSource = this.tEmpleadoBindingSource;
			this.nombreComboBox.DisplayMember = "nombre";
			this.nombreComboBox.FormattingEnabled = true;
			this.nombreComboBox.Location = new Point(354, 194);
			this.nombreComboBox.Name = "nombreComboBox";
			this.nombreComboBox.Size = new System.Drawing.Size(200, 21);
			this.nombreComboBox.TabIndex = 30;
			this.nombreComboBox.ValueMember = "idEmpleado";
			this.nombreComboBox.SelectedIndexChanged += new EventHandler(this.nombreComboBox_SelectedIndexChanged);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(855, 421);
			base.Controls.Add(point4);
			base.Controls.Add(this.nombreComboBox);
			base.Controls.Add(label4);
			base.Controls.Add(this.razonSocialComboBox);
			base.Controls.Add(this.descripcionVisitaTextBox);
			base.Controls.Add(this.descripcionVisitaListBox);
			base.Controls.Add(this.panel2);
			base.Controls.Add(label);
			base.Controls.Add(this.idVisitaProgramadaTextBox);
			base.Controls.Add(point);
			base.Controls.Add(size);
			base.Controls.Add(this.fechaInicioDateTimePicker);
			base.Controls.Add(label1);
			base.Controls.Add(this.fechafinDateTimePicker);
			base.Controls.Add(point1);
			base.Controls.Add(this.idEmpresaTextBox);
			base.Controls.Add(size1);
			base.Controls.Add(this.idEmpleadoTextBox);
			base.Controls.Add(label2);
			base.Controls.Add(this.observacionesVisitaTextBox);
			base.Controls.Add(point2);
			base.Controls.Add(this.idEstadoVisitaTextBox);
			base.Controls.Add(size2);
			base.Controls.Add(this.fechadeIngresoDateTimePicker);
			base.Controls.Add(label3);
			base.Controls.Add(this.fechaUltimaGestionDateTimePicker);
			base.Controls.Add(point3);
			base.Controls.Add(this.usuarioUltimaGestionTextBox);
			base.Controls.Add(size3);
			base.Controls.Add(this.idDivisionEmpresaTextBox);
			base.Controls.Add(this.tVisitaProgramadaBindingNavigator);
			base.Name = "frmVisitaProgramadaOK";
			this.Text = "Visitas Programadas";
			base.Load += new EventHandler(this.frmVisitaProgramadaOK_Load);
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingNavigator).EndInit();
			this.tVisitaProgramadaBindingNavigator.ResumeLayout(false);
			this.tVisitaProgramadaBindingNavigator.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.nombreComboBox.SelectedIndex >= 0)
			{
				this.idEmpleadoTextBox.Text = this.nombreComboBox.SelectedValue.ToString();
			}
		}

		private void razonSocialComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.razonSocialComboBox.SelectedIndex >= 0)
			{
				this.idEmpresaTextBox.Text = this.razonSocialComboBox.SelectedValue.ToString();
				this.tEmpleadoTableAdapter.FillByEmpleadobyEmpresa(this.masterDBACDataSet.TEmpleado, Convert.ToInt32(this.razonSocialComboBox.SelectedValue));
			}
		}

		private void tVisitaProgramadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tVisitaProgramadaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}