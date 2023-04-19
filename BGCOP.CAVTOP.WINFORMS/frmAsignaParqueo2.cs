using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmAsignaParqueo2 : Form
	{
		private IContainer components = null;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tvehiculoParqueoBindingSource;

		private TvehiculoParqueoTableAdapter tvehiculoParqueoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tvehiculoParqueoBindingNavigator;

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

		private ToolStripButton tvehiculoParqueoBindingNavigatorSaveItem;

		private BindingSource tVehiculoBindingSource;

		private TVehiculoTableAdapter tVehiculoTableAdapter;

		private BindingSource tParqueoBindingSource;

		private TParqueoTableAdapter tParqueoTableAdapter;

		private Panel panel2;

		private Label label1;

		private Office2007BlackTheme office2007BlackTheme1;

		private Office2010BlackTheme office2010BlackTheme1;

		private DesertTheme desertTheme1;

		private Timer tInicio;

		private ToolTip toolTip1;

		private Button button1;

		private RadDesktopAlert radDesktopAlert1;

		private RadGridView radGridView1;

		public frmAsignaParqueo2()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ExportToExcelML exportToExcelML = new ExportToExcelML(this.radGridView1)
			{
				HiddenColumnOption = HiddenOption.DoNotExport,
				ExportVisualSettings = true,
				SheetMaxRows = ExcelMaxRows._1048576,
				SheetName = "Listado",
				SummariesExportOption = SummariesOption.DoNotExport
			};
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedDataAsignacionParqueos.xls");
			try
			{
				exportToExcelML.RunExport(str);
				this.radDesktopAlert1.ContentImage = Resources.File_Excel_icon;
				this.radDesktopAlert1.CaptionText = "Exportar a excel";
				this.radDesktopAlert1.ContentText = string.Concat("El archivo se exportado con exito.\r\nRuta: ", str);
				this.radDesktopAlert1.FixedSize = new System.Drawing.Size(450, 150);
				this.radDesktopAlert1.Show();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
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

		private void frmAsignaParqueo2_Load(object sender, EventArgs e)
		{
			this.tInicio.Enabled = true;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAsignaParqueo2));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn5 = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn6 = new GridViewCheckBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			this.tVehiculoBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tParqueoBindingSource = new BindingSource(this.components);
			this.tvehiculoParqueoBindingSource = new BindingSource(this.components);
			this.tvehiculoParqueoTableAdapter = new TvehiculoParqueoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tvehiculoParqueoBindingNavigator = new BindingNavigator(this.components);
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
			this.tvehiculoParqueoBindingNavigatorSaveItem = new ToolStripButton();
			this.tVehiculoTableAdapter = new TVehiculoTableAdapter();
			this.tParqueoTableAdapter = new TParqueoTableAdapter();
			this.panel2 = new Panel();
			this.button1 = new Button();
			this.label1 = new Label();
			this.office2007BlackTheme1 = new Office2007BlackTheme();
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			this.desertTheme1 = new DesertTheme();
			this.tInicio = new Timer(this.components);
			this.toolTip1 = new ToolTip(this.components);
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.radGridView1 = new RadGridView();
			((ISupportInitialize)this.tVehiculoBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tParqueoBindingSource).BeginInit();
			((ISupportInitialize)this.tvehiculoParqueoBindingSource).BeginInit();
			((ISupportInitialize)this.tvehiculoParqueoBindingNavigator).BeginInit();
			this.tvehiculoParqueoBindingNavigator.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			base.SuspendLayout();
			this.tVehiculoBindingSource.DataMember = "TVehiculo";
			this.tVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tParqueoBindingSource.DataMember = "TParqueo";
			this.tParqueoBindingSource.DataSource = this.masterDBACDataSet;
			this.tvehiculoParqueoBindingSource.DataMember = "TvehiculoParqueo";
			this.tvehiculoParqueoBindingSource.DataSource = this.masterDBACDataSet;
			this.tvehiculoParqueoTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.TvehiculoParqueoTableAdapter = this.tvehiculoParqueoTableAdapter;
			this.tableAdapterManager.TVehiculoTableAdapter = null;
			this.tableAdapterManager.TVisitanteTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaLogTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tvehiculoParqueoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tvehiculoParqueoBindingNavigator.BindingSource = this.tvehiculoParqueoBindingSource;
			this.tvehiculoParqueoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tvehiculoParqueoBindingNavigator.CountItemFormat = "de {0}";
			this.tvehiculoParqueoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tvehiculoParqueoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tvehiculoParqueoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tvehiculoParqueoBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tvehiculoParqueoBindingNavigator.Location = new Point(0, 482);
			this.tvehiculoParqueoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tvehiculoParqueoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tvehiculoParqueoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tvehiculoParqueoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tvehiculoParqueoBindingNavigator.Name = "tvehiculoParqueoBindingNavigator";
			this.tvehiculoParqueoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tvehiculoParqueoBindingNavigator.Size = new System.Drawing.Size(973, 25);
			this.tvehiculoParqueoBindingNavigator.TabIndex = 3;
			this.tvehiculoParqueoBindingNavigator.Text = "bindingNavigator1";
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
			this.tvehiculoParqueoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tvehiculoParqueoBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tvehiculoParqueoBindingNavigatorSaveItem.Image");
			this.tvehiculoParqueoBindingNavigatorSaveItem.Name = "tvehiculoParqueoBindingNavigatorSaveItem";
			this.tvehiculoParqueoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tvehiculoParqueoBindingNavigatorSaveItem.Text = "Save Data";
			this.tvehiculoParqueoBindingNavigatorSaveItem.Click += new EventHandler(this.tvehiculoParqueoBindingNavigatorSaveItem_Click);
			this.tVehiculoTableAdapter.ClearBeforeFill = true;
			this.tParqueoTableAdapter.ClearBeforeFill = true;
			this.panel2.BackColor = Color.WhiteSmoke;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(973, 53);
			this.panel2.TabIndex = 14;
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.BackgroundImage = Resources.File_Excel_icon;
			this.button1.BackgroundImageLayout = ImageLayout.Stretch;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(924, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 46);
			this.button1.TabIndex = 2;
			this.toolTip1.SetToolTip(this.button1, "Exportar en Formato Excel");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Asignacion de Parqueadero";
			this.tInicio.Interval = 300;
			this.tInicio.Tick += new EventHandler(this.tInicio_Tick);
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Sistema de Control de Acceso";
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 60);
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "idVehiculo";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idVehiculo";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idVehiculo";
			gridViewDecimalColumn.Width = 61;
			gridViewComboBoxColumn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn.DataSource = this.tVehiculoBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "Placa";
			gridViewComboBoxColumn.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn.FieldName = "idVehiculo";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "PLACA";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idVehiculo";
			gridViewComboBoxColumn.Width = 80;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "idParqueadero";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idParqueadero";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idParqueadero";
			gridViewDecimalColumn1.Width = 82;
			gridViewComboBoxColumn1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn1.DataSource = this.tParqueoBindingSource;
			gridViewComboBoxColumn1.DataType = typeof(int);
			gridViewComboBoxColumn1.DisplayMember = "nParqueo";
			gridViewComboBoxColumn1.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn1.FieldName = "idParqueadero";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "PARQUEADERO";
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "idParqueadero";
			gridViewComboBoxColumn1.Width = 250;
			gridViewDecimalColumn2.DataType = typeof(byte);
			gridViewDecimalColumn2.FieldName = "diaSemana";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "diaSemana";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "diaSemana";
			gridViewDecimalColumn2.Width = 63;
			gridViewTextBoxColumn.FieldName = "ObservacionesVP";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "ObservacionesVP";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "ObservacionesVP";
			gridViewTextBoxColumn.Width = 200;
			gridViewCheckBoxColumn.FieldName = "dia1";
			gridViewCheckBoxColumn.FormatString = "";
			gridViewCheckBoxColumn.HeaderText = "Domingo";
			gridViewCheckBoxColumn.IsAutoGenerated = true;
			gridViewCheckBoxColumn.Name = "dia1";
			gridViewCheckBoxColumn.Width = 65;
			gridViewCheckBoxColumn1.FieldName = "dia2";
			gridViewCheckBoxColumn1.FormatString = "";
			gridViewCheckBoxColumn1.HeaderText = "Lunes";
			gridViewCheckBoxColumn1.IsAutoGenerated = true;
			gridViewCheckBoxColumn1.Name = "dia2";
			gridViewCheckBoxColumn1.Width = 56;
			gridViewCheckBoxColumn2.FieldName = "dia3";
			gridViewCheckBoxColumn2.FormatString = "";
			gridViewCheckBoxColumn2.HeaderText = "Martes";
			gridViewCheckBoxColumn2.IsAutoGenerated = true;
			gridViewCheckBoxColumn2.Name = "dia3";
			gridViewCheckBoxColumn2.Width = 56;
			gridViewCheckBoxColumn3.FieldName = "dia4";
			gridViewCheckBoxColumn3.FormatString = "";
			gridViewCheckBoxColumn3.HeaderText = "Miercoles";
			gridViewCheckBoxColumn3.IsAutoGenerated = true;
			gridViewCheckBoxColumn3.Name = "dia4";
			gridViewCheckBoxColumn3.Width = 56;
			gridViewCheckBoxColumn4.FieldName = "dia5";
			gridViewCheckBoxColumn4.FormatString = "";
			gridViewCheckBoxColumn4.HeaderText = "Jueves";
			gridViewCheckBoxColumn4.IsAutoGenerated = true;
			gridViewCheckBoxColumn4.Name = "dia5";
			gridViewCheckBoxColumn4.Width = 56;
			gridViewCheckBoxColumn5.FieldName = "dia6";
			gridViewCheckBoxColumn5.FormatString = "";
			gridViewCheckBoxColumn5.HeaderText = "Viernes";
			gridViewCheckBoxColumn5.IsAutoGenerated = true;
			gridViewCheckBoxColumn5.Name = "dia6";
			gridViewCheckBoxColumn5.Width = 56;
			gridViewCheckBoxColumn6.FieldName = "dia7";
			gridViewCheckBoxColumn6.FormatString = "";
			gridViewCheckBoxColumn6.HeaderText = "Sabado";
			gridViewCheckBoxColumn6.IsAutoGenerated = true;
			gridViewCheckBoxColumn6.Name = "dia7";
			gridViewCheckBoxColumn6.Width = 56;
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewDateTimeColumn.Width = 106;
			gridViewDecimalColumn3.DataType = typeof(int);
			gridViewDecimalColumn3.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn3.FormatString = "";
			gridViewDecimalColumn3.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn3.IsAutoGenerated = true;
			gridViewDecimalColumn3.IsVisible = false;
			gridViewDecimalColumn3.Name = "usuarioUltimaGestion";
			gridViewDecimalColumn3.Width = 116;
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewComboBoxColumn, gridViewDecimalColumn1, gridViewComboBoxColumn1, gridViewDecimalColumn2, gridViewTextBoxColumn, gridViewCheckBoxColumn, gridViewCheckBoxColumn1, gridViewCheckBoxColumn2, gridViewCheckBoxColumn3, gridViewCheckBoxColumn4, gridViewCheckBoxColumn5, gridViewCheckBoxColumn6, gridViewDateTimeColumn, gridViewDecimalColumn3 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tvehiculoParqueoBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(949, 419);
			this.radGridView1.TabIndex = 15;
			this.radGridView1.Text = "radGridView2";
			this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(973, 507);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.tvehiculoParqueoBindingNavigator);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmAsignaParqueo2";
			this.Text = "Parqueo";
			base.Load += new EventHandler(this.frmAsignaParqueo2_Load);
			((ISupportInitialize)this.tVehiculoBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tParqueoBindingSource).EndInit();
			((ISupportInitialize)this.tvehiculoParqueoBindingSource).EndInit();
			((ISupportInitialize)this.tvehiculoParqueoBindingNavigator).EndInit();
			this.tvehiculoParqueoBindingNavigator.ResumeLayout(false);
			this.tvehiculoParqueoBindingNavigator.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
		{
			e.Row.Cells["diaSemana"].Value = 1;
			e.Row.Cells["fechaUltimaGestion"].Value = DateTime.Now;
			e.Row.Cells["usuarioUltimaGestion"].Value = Program.idUsuarioActual;
		}

		private void tInicio_Tick(object sender, EventArgs e)
		{
			this.tInicio.Enabled = false;
			this.tParqueoTableAdapter.Fill(this.masterDBACDataSet.TParqueo);
			this.tVehiculoTableAdapter.Fill(this.masterDBACDataSet.TVehiculo);
			this.tvehiculoParqueoTableAdapter.Fill(this.masterDBACDataSet.TvehiculoParqueo);
		}

		private void tvehiculoParqueoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea realizar las operaciones pendientes?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				base.Validate();
				this.tvehiculoParqueoBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
				MessageBox.Show("El registro se proceso con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
			}
		}
	}
}