using BGCOP.CAVTOP.WINFORMS.frmtlk;
using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Localization;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmVisitaProgramada : Form
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

		private RadGridView radGridView1;

		private Office2010BlackTheme office2010BlackTheme1;

		private Office2010BlueTheme office2010BlueTheme1;

		private Panel panel2;

		private Label label1;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private BindingSource tEmpresaBindingSource;

		private TDivisionEmpresaTableAdapter tDivisionEmpresaTableAdapter;

		private BindingSource fKTDivisionEmpresaTEmpresaBindingSource;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private BindingSource fKTEmpleadoTDivisionEmpresaBindingSource;

		private BindingSource tDivisionEmpresaBindingSource;

		private BindingSource tEmpleadoBindingSource;

		private Office2010BlackTheme office2010BlackTheme2;

		public frmVisitaProgramada()
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

		private void frmVisitaProgramada_Load(object sender, EventArgs e)
		{
			this.tEmpleadoTableAdapter.Fill(this.masterDBACDataSet.TEmpleado);
			this.tDivisionEmpresaTableAdapter.Fill(this.masterDBACDataSet.TDivisionEmpresa);
			this.tEmpresaTableAdapter.Fill(this.masterDBACDataSet.TEmpresa);
			this.tVisitaProgramadaTableAdapter.Fill(this.masterDBACDataSet.TVisitaProgramada);
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new MyEnglishRadGridLocalizationProvider();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVisitaProgramada));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDateTimeColumn cultureInfo = new GridViewDateTimeColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn1 = new GridViewDateTimeColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn2 = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn2 = new GridViewComboBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn4 = new GridViewDecimalColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn3 = new GridViewDateTimeColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn4 = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn5 = new GridViewDecimalColumn();
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tDivisionEmpresaBindingSource = new BindingSource(this.components);
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.tVisitaProgramadaBindingSource = new BindingSource(this.components);
			this.tVisitaProgramadaTableAdapter = new TVisitaProgramadaTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tDivisionEmpresaTableAdapter = new TDivisionEmpresaTableAdapter();
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
			this.radGridView1 = new RadGridView();
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			this.office2010BlueTheme1 = new Office2010BlueTheme();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.fKTDivisionEmpresaTEmpresaBindingSource = new BindingSource(this.components);
			this.fKTEmpleadoTDivisionEmpresaBindingSource = new BindingSource(this.components);
			this.office2010BlackTheme2 = new Office2010BlackTheme();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tDivisionEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingNavigator).BeginInit();
			this.tVisitaProgramadaBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.fKTDivisionEmpresaTEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.fKTEmpleadoTDivisionEmpresaBindingSource).BeginInit();
			base.SuspendLayout();
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tDivisionEmpresaBindingSource.DataMember = "TDivisionEmpresa";
			this.tDivisionEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.tVisitaProgramadaBindingSource.DataMember = "TVisitaProgramada";
			this.tVisitaProgramadaBindingSource.DataSource = this.masterDBACDataSet;
			this.tVisitaProgramadaTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = this.tDivisionEmpresaTableAdapter;
			this.tableAdapterManager.TEmpleadoTableAdapter = this.tEmpleadoTableAdapter;
			this.tableAdapterManager.TEmpleadoVehiculoTableAdapter = null;
			this.tableAdapterManager.TEmpresaTableAdapter = this.tEmpresaTableAdapter;
			this.tableAdapterManager.TEmpresaVisitanteTableAdapter = null;
			this.tableAdapterManager.TEstadoTableAdapter = null;
			this.tableAdapterManager.TFestivosTableAdapter = null;
			this.tableAdapterManager.THorarioTableAdapter = null;
			this.tableAdapterManager.TinnerTableAdapter = null;
			this.tableAdapterManager.TipoVehiculoTableAdapter = null;
			this.tableAdapterManager.TMarcaVehiculoTableAdapter = null;
			this.tableAdapterManager.TModeloVehiculoTableAdapter = null;
			this.tableAdapterManager.TPanelTableAdapter = null;
			this.tableAdapterManager.TParqueoTableAdapter = null;
			this.tableAdapterManager.TRegistroEmpleadoTableAdapter = null;
			this.tableAdapterManager.TRegistroVehiculoTableAdapter = null;
			this.tableAdapterManager.TTarjetaTableAdapter = null;
			this.tableAdapterManager.TTipoIdentificacionTableAdapter = null;
			this.tableAdapterManager.TTipoRegistroTableAdapter = null;
			this.tableAdapterManager.TTipoUsuarioTableAdapter = null;
			this.tableAdapterManager.TUsuarioTableAdapter = null;
			this.tableAdapterManager.TvehiculoParqueoTableAdapter = null;
			this.tableAdapterManager.TVehiculoTableAdapter = null;
			this.tableAdapterManager.TVisitanteTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = this.tVisitaProgramadaTableAdapter;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tDivisionEmpresaTableAdapter.ClearBeforeFill = true;
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
			this.tVisitaProgramadaBindingNavigator.Location = new Point(0, 415);
			this.tVisitaProgramadaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tVisitaProgramadaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tVisitaProgramadaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tVisitaProgramadaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tVisitaProgramadaBindingNavigator.Name = "tVisitaProgramadaBindingNavigator";
			this.tVisitaProgramadaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tVisitaProgramadaBindingNavigator.Size = new System.Drawing.Size(1045, 25);
			this.tVisitaProgramadaBindingNavigator.TabIndex = 0;
			this.tVisitaProgramadaBindingNavigator.Text = "bindingNavigator1";
			this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
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
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 42);
			gridViewDecimalColumn.FieldName = "idVisitaProgramada";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idVisitaProgramada";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idVisitaProgramada";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewTextBoxColumn.FieldName = "DescripcionVisita";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "DescripcionVisita";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "DescripcionVisita";
			gridViewTextBoxColumn.Width = 200;
			gridViewDateTimeColumn.CustomFormat = "";
			gridViewDateTimeColumn.FieldName = "fechaInicio";
			gridViewDateTimeColumn.Format = DateTimePickerFormat.Short;
			gridViewDateTimeColumn.FormatInfo = new CultureInfo("");
			gridViewDateTimeColumn.FormatString = "{0:d}";
			gridViewDateTimeColumn.HeaderText = "Fecha Inicio";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.Name = "fechaInicio";
			gridViewDateTimeColumn.Width = 150;
			cultureInfo.EditorType = GridViewDateTimeEditorType.TimePicker;
			cultureInfo.FieldName = "fechaInicio";
			cultureInfo.Format = DateTimePickerFormat.Time;
			cultureInfo.FormatInfo = new CultureInfo("");
			cultureInfo.FormatString = "{0:hh:mm:ss tt}";
			cultureInfo.HeaderText = "Hora Inicio";
			cultureInfo.Name = "fechaInicio2";
			cultureInfo.Width = 100;
			gridViewDateTimeColumn1.CustomFormat = "";
			gridViewDateTimeColumn1.FieldName = "fechafin";
			gridViewDateTimeColumn1.Format = DateTimePickerFormat.Short;
			gridViewDateTimeColumn1.FormatInfo = new CultureInfo("");
			gridViewDateTimeColumn1.FormatString = "{0:d}";
			gridViewDateTimeColumn1.HeaderText = "Fecha fin";
			gridViewDateTimeColumn1.IsAutoGenerated = true;
			gridViewDateTimeColumn1.Name = "fechafin";
			gridViewDateTimeColumn1.Width = 150;
			gridViewDateTimeColumn2.EditorType = GridViewDateTimeEditorType.TimePicker;
			gridViewDateTimeColumn2.FieldName = "fechafin";
			gridViewDateTimeColumn2.Format = DateTimePickerFormat.Time;
			gridViewDateTimeColumn2.FormatString = "{0:hh:mm:ss tt}";
			gridViewDateTimeColumn2.HeaderText = "Hora Fin";
			gridViewDateTimeColumn2.Name = "fechafin1";
			gridViewDateTimeColumn2.Width = 100;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "idEmpresa";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idEmpresa";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idEmpresa";
			gridViewComboBoxColumn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn.DataSource = this.tEmpresaBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "RazonSocial";
			gridViewComboBoxColumn.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn.FieldName = "idEmpresa";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Empresa";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idEmpresa";
			gridViewComboBoxColumn.Width = 200;
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "IdDivisionEmpresa";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "IdDivisionEmpresa";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "IdDivisionEmpresa";
			gridViewComboBoxColumn1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn1.DataSource = this.tDivisionEmpresaBindingSource;
			gridViewComboBoxColumn1.DataType = typeof(int);
			gridViewComboBoxColumn1.DisplayMember = "NombreDivision";
			gridViewComboBoxColumn1.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn1.FieldName = "IdDivisionEmpresa";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "División";
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "IdDivisionEmpresa";
			gridViewComboBoxColumn1.Width = 150;
			gridViewDecimalColumn3.DataType = typeof(int);
			gridViewDecimalColumn3.FieldName = "idEmpleado";
			gridViewDecimalColumn3.FormatString = "";
			gridViewDecimalColumn3.HeaderText = "idEmpleado";
			gridViewDecimalColumn3.IsAutoGenerated = true;
			gridViewDecimalColumn3.IsVisible = false;
			gridViewDecimalColumn3.Name = "idEmpleado";
			gridViewComboBoxColumn2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn2.DataSource = this.tEmpleadoBindingSource;
			gridViewComboBoxColumn2.DataType = typeof(int);
			gridViewComboBoxColumn2.DisplayMember = "nombre";
			gridViewComboBoxColumn2.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn2.FieldName = "idEmpleado";
			gridViewComboBoxColumn2.FormatString = "";
			gridViewComboBoxColumn2.HeaderText = "Empleado";
			gridViewComboBoxColumn2.Name = "column3";
			gridViewComboBoxColumn2.ValueMember = "idEmpleado";
			gridViewComboBoxColumn2.Width = 150;
			gridViewTextBoxColumn1.FieldName = "ObservacionesVisita";
			gridViewTextBoxColumn1.FormatString = "";
			gridViewTextBoxColumn1.HeaderText = "ObservacionesVisita";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "ObservacionesVisita";
			gridViewDecimalColumn4.DataType = typeof(int);
			gridViewDecimalColumn4.FieldName = "idEstadoVisita";
			gridViewDecimalColumn4.FormatString = "";
			gridViewDecimalColumn4.HeaderText = "idEstadoVisita";
			gridViewDecimalColumn4.IsAutoGenerated = true;
			gridViewDecimalColumn4.IsVisible = false;
			gridViewDecimalColumn4.Name = "idEstadoVisita";
			gridViewDateTimeColumn3.FieldName = "fechadeIngreso";
			gridViewDateTimeColumn3.FormatString = "";
			gridViewDateTimeColumn3.HeaderText = "fechadeIngreso";
			gridViewDateTimeColumn3.IsAutoGenerated = true;
			gridViewDateTimeColumn3.Name = "fechadeIngreso";
			gridViewDateTimeColumn4.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn4.FormatString = "";
			gridViewDateTimeColumn4.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn4.IsAutoGenerated = true;
			gridViewDateTimeColumn4.IsVisible = false;
			gridViewDateTimeColumn4.Name = "fechaUltimaGestion";
			gridViewDecimalColumn5.DataType = typeof(int);
			gridViewDecimalColumn5.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn5.FormatString = "";
			gridViewDecimalColumn5.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn5.IsAutoGenerated = true;
			gridViewDecimalColumn5.IsVisible = false;
			gridViewDecimalColumn5.Name = "usuarioUltimaGestion";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDateTimeColumn, cultureInfo, gridViewDateTimeColumn1, gridViewDateTimeColumn2, gridViewDecimalColumn1, gridViewComboBoxColumn, gridViewDecimalColumn2, gridViewComboBoxColumn1, gridViewDecimalColumn3, gridViewComboBoxColumn2, gridViewTextBoxColumn1, gridViewDecimalColumn4, gridViewDateTimeColumn3, gridViewDateTimeColumn4, gridViewDecimalColumn5 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tVisitaProgramadaBindingSource;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Size = new System.Drawing.Size(1021, 370);
			this.radGridView1.TabIndex = 1;
			this.radGridView1.Text = "radGridView1";
			this.radGridView1.ThemeName = "Office2010Black";
			this.panel2.BackColor = Color.Silver;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1045, 35);
			this.panel2.TabIndex = 5;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(37, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Visitas Programadas";
			this.fKTDivisionEmpresaTEmpresaBindingSource.DataMember = "FK_TDivisionEmpresa_TEmpresa";
			this.fKTDivisionEmpresaTEmpresaBindingSource.DataSource = this.tEmpresaBindingSource;
			this.fKTEmpleadoTDivisionEmpresaBindingSource.DataMember = "FK_TEmpleado_TDivisionEmpresa";
			this.fKTEmpleadoTDivisionEmpresaBindingSource.DataSource = this.fKTDivisionEmpresaTEmpresaBindingSource;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1045, 440);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tVisitaProgramadaBindingNavigator);
			base.Name = "frmVisitaProgramada";
			this.Text = "frmVisitaProgramada";
			base.Load += new EventHandler(this.frmVisitaProgramada_Load);
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tDivisionEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingNavigator).EndInit();
			this.tVisitaProgramadaBindingNavigator.ResumeLayout(false);
			this.tVisitaProgramadaBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.fKTDivisionEmpresaTEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.fKTEmpleadoTDivisionEmpresaBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void tVisitaProgramadaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tVisitaProgramadaBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}