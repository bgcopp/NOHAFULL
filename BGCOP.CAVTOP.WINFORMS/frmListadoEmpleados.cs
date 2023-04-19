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
using Telerik.WinControls.UI.Export;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmListadoEmpleados : Form
	{
		private IContainer components = null;

		private Panel panel2;

		private Label label1;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tEmpleadoBindingSource;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tEmpleadoBindingNavigator;

		private ToolStripLabel bindingNavigatorCountItem;

		private ToolStripButton bindingNavigatorMoveFirstItem;

		private ToolStripButton bindingNavigatorMovePreviousItem;

		private ToolStripSeparator bindingNavigatorSeparator;

		private ToolStripTextBox bindingNavigatorPositionItem;

		private ToolStripSeparator bindingNavigatorSeparator1;

		private ToolStripButton bindingNavigatorMoveNextItem;

		private ToolStripButton bindingNavigatorMoveLastItem;

		private ToolStripSeparator bindingNavigatorSeparator2;

		private TEstadoTableAdapter tEstadoTableAdapter;

		private RadGridView radGridView1;

		private BindingSource tEstadoBindingSource;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private BindingSource tEmpresaBindingSource;

		private TDivisionEmpresaTableAdapter tDivisionEmpresaTableAdapter;

		private BindingSource tDivisionEmpresaBindingSource;

		private TTarjetaTableAdapter tTarjetaTableAdapter;

		private BindingSource tTarjetaBindingSource;

		private Button button1;

		private RadDesktopAlert radDesktopAlert1;

		private RadDesktopAlert radDesktopAlert2;

		public frmListadoEmpleados()
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
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedListadoEmpleados.xls");
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

		private void frmListadoEmpleados_Load(object sender, EventArgs e)
		{
			this.tTarjetaTableAdapter.Fill(this.masterDBACDataSet.TTarjeta);
			this.tDivisionEmpresaTableAdapter.Fill(this.masterDBACDataSet.TDivisionEmpresa);
			this.tEmpresaTableAdapter.Fill(this.masterDBACDataSet.TEmpresa);
			this.tEstadoTableAdapter.Fill(this.masterDBACDataSet.TEstado);
			this.tEmpleadoTableAdapter.Fill(this.masterDBACDataSet.TEmpleado);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmListadoEmpleados));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
			GridViewImageColumn gridViewImageColumn = new GridViewImageColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn4 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn5 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn2 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn6 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn7 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn8 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn3 = new GridViewComboBoxColumn();
			this.tEstadoBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.tDivisionEmpresaBindingSource = new BindingSource(this.components);
			this.tTarjetaBindingSource = new BindingSource(this.components);
			this.panel2 = new Panel();
			this.button1 = new Button();
			this.label1 = new Label();
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tDivisionEmpresaTableAdapter = new TDivisionEmpresaTableAdapter();
			this.tEmpresaTableAdapter = new TEmpresaTableAdapter();
			this.tEstadoTableAdapter = new TEstadoTableAdapter();
			this.tTarjetaTableAdapter = new TTarjetaTableAdapter();
			this.tEmpleadoBindingNavigator = new BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new ToolStripButton();
			this.bindingNavigatorSeparator = new ToolStripSeparator();
			this.bindingNavigatorPositionItem = new ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new ToolStripButton();
			this.bindingNavigatorMoveLastItem = new ToolStripButton();
			this.bindingNavigatorSeparator2 = new ToolStripSeparator();
			this.radGridView1 = new RadGridView();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.radDesktopAlert2 = new RadDesktopAlert(this.components);
			((ISupportInitialize)this.tEstadoBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tDivisionEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tTarjetaBindingSource).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingNavigator).BeginInit();
			this.tEmpleadoBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			base.SuspendLayout();
			this.tEstadoBindingSource.DataMember = "TEstado";
			this.tEstadoBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tDivisionEmpresaBindingSource.DataMember = "TDivisionEmpresa";
			this.tDivisionEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tTarjetaBindingSource.DataMember = "TTarjeta";
			this.tTarjetaBindingSource.DataSource = this.masterDBACDataSet;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(918, 53);
			this.panel2.TabIndex = 16;
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.BackgroundImage = Resources.File_Excel_icon;
			this.button1.BackgroundImageLayout = ImageLayout.Stretch;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(860, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 46);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Listado de Empleado";
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpleadoTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = this.tDivisionEmpresaTableAdapter;
			this.tableAdapterManager.TEmpleadoTableAdapter = this.tEmpleadoTableAdapter;
			this.tableAdapterManager.TEmpleadoVehiculoTableAdapter = null;
			this.tableAdapterManager.TEmpresaTableAdapter = this.tEmpresaTableAdapter;
			this.tableAdapterManager.TEmpresaVisitanteTableAdapter = null;
			this.tableAdapterManager.TEstadoTableAdapter = this.tEstadoTableAdapter;
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
			this.tableAdapterManager.TTarjetaTableAdapter = this.tTarjetaTableAdapter;
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
			this.tDivisionEmpresaTableAdapter.ClearBeforeFill = true;
			this.tEmpresaTableAdapter.ClearBeforeFill = true;
			this.tEstadoTableAdapter.ClearBeforeFill = true;
			this.tTarjetaTableAdapter.ClearBeforeFill = true;
			this.tEmpleadoBindingNavigator.AddNewItem = null;
			this.tEmpleadoBindingNavigator.BindingSource = this.tEmpleadoBindingSource;
			this.tEmpleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tEmpleadoBindingNavigator.DeleteItem = null;
			this.tEmpleadoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tEmpleadoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2 };
			items.AddRange(toolStripItemArray);
			this.tEmpleadoBindingNavigator.Location = new Point(0, 512);
			this.tEmpleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tEmpleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tEmpleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tEmpleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tEmpleadoBindingNavigator.Name = "tEmpleadoBindingNavigator";
			this.tEmpleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tEmpleadoBindingNavigator.Size = new System.Drawing.Size(918, 25);
			this.tEmpleadoBindingNavigator.TabIndex = 17;
			this.tEmpleadoBindingNavigator.Text = "bindingNavigator1";
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(9, 60);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "idEmpleado";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idEmpleado";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.Name = "idEmpleado";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewDecimalColumn.Width = 100;
			gridViewTextBoxColumn.FieldName = "nombre";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "Nombre";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "nombre";
			gridViewTextBoxColumn.Width = 250;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "idTipoIdentificacion";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idTipoIdentificacion";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idTipoIdentificacion";
			gridViewTextBoxColumn1.FieldName = "identificacion";
			gridViewTextBoxColumn1.FormatString = "";
			gridViewTextBoxColumn1.HeaderText = "Identificacion";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "identificacion";
			gridViewTextBoxColumn1.Width = 100;
			gridViewTextBoxColumn2.FieldName = "Notarjeta";
			gridViewTextBoxColumn2.FormatString = "";
			gridViewTextBoxColumn2.HeaderText = "Notarjeta";
			gridViewTextBoxColumn2.IsAutoGenerated = true;
			gridViewTextBoxColumn2.IsVisible = false;
			gridViewTextBoxColumn2.Name = "Notarjeta";
			gridViewImageColumn.DataType = typeof(byte[]);
			gridViewImageColumn.FieldName = "foto";
			gridViewImageColumn.FormatString = "";
			gridViewImageColumn.HeaderText = "foto";
			gridViewImageColumn.IsAutoGenerated = true;
			gridViewImageColumn.IsVisible = false;
			gridViewImageColumn.Name = "foto";
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "idCargo";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "idCargo";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "idCargo";
			gridViewDecimalColumn3.DataType = typeof(int);
			gridViewDecimalColumn3.FieldName = "idTipoEstado";
			gridViewDecimalColumn3.FormatString = "";
			gridViewDecimalColumn3.HeaderText = "idTipoEstado";
			gridViewDecimalColumn3.IsAutoGenerated = true;
			gridViewDecimalColumn3.IsVisible = false;
			gridViewDecimalColumn3.Name = "idTipoEstado";
			gridViewComboBoxColumn.DataSource = this.tEstadoBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "NombreEstado";
			gridViewComboBoxColumn.FieldName = "idTipoEstado";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Estado";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idTipoEstado";
			gridViewComboBoxColumn.Width = 100;
			gridViewDecimalColumn4.DataType = typeof(int);
			gridViewDecimalColumn4.FieldName = "idEmpresa";
			gridViewDecimalColumn4.FormatString = "";
			gridViewDecimalColumn4.HeaderText = "idEmpresa";
			gridViewDecimalColumn4.IsAutoGenerated = true;
			gridViewDecimalColumn4.IsVisible = false;
			gridViewDecimalColumn4.Name = "idEmpresa";
			gridViewComboBoxColumn1.DataSource = this.tEmpresaBindingSource;
			gridViewComboBoxColumn1.DataType = typeof(int);
			gridViewComboBoxColumn1.DisplayMember = "RazonSocial";
			gridViewComboBoxColumn1.FieldName = "idEmpresa";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "Empresa";
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "idEmpresa";
			gridViewComboBoxColumn1.Width = 210;
			gridViewDecimalColumn5.DataType = typeof(int);
			gridViewDecimalColumn5.FieldName = "idDivisionEmpresa";
			gridViewDecimalColumn5.FormatString = "";
			gridViewDecimalColumn5.HeaderText = "idDivisionEmpresa";
			gridViewDecimalColumn5.IsAutoGenerated = true;
			gridViewDecimalColumn5.IsVisible = false;
			gridViewDecimalColumn5.Name = "idDivisionEmpresa";
			gridViewComboBoxColumn2.DataSource = this.tDivisionEmpresaBindingSource;
			gridViewComboBoxColumn2.DataType = typeof(int);
			gridViewComboBoxColumn2.DisplayMember = "NombreDivision";
			gridViewComboBoxColumn2.FieldName = "IdDivisionEmpresa";
			gridViewComboBoxColumn2.FormatString = "";
			gridViewComboBoxColumn2.HeaderText = "Division";
			gridViewComboBoxColumn2.Name = "column3";
			gridViewComboBoxColumn2.ValueMember = "IdDivisionEmpresa";
			gridViewComboBoxColumn2.Width = 150;
			gridViewDecimalColumn6.DataType = typeof(int);
			gridViewDecimalColumn6.FieldName = "idHorario";
			gridViewDecimalColumn6.FormatString = "";
			gridViewDecimalColumn6.HeaderText = "idHorario";
			gridViewDecimalColumn6.IsAutoGenerated = true;
			gridViewDecimalColumn6.IsVisible = false;
			gridViewDecimalColumn6.Name = "idHorario";
			gridViewTextBoxColumn3.FieldName = "observaciones";
			gridViewTextBoxColumn3.FormatString = "";
			gridViewTextBoxColumn3.HeaderText = "observaciones";
			gridViewTextBoxColumn3.IsAutoGenerated = true;
			gridViewTextBoxColumn3.IsVisible = false;
			gridViewTextBoxColumn3.Name = "observaciones";
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewDecimalColumn7.DataType = typeof(int);
			gridViewDecimalColumn7.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn7.FormatString = "";
			gridViewDecimalColumn7.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn7.IsAutoGenerated = true;
			gridViewDecimalColumn7.IsVisible = false;
			gridViewDecimalColumn7.Name = "usuarioUltimaGestion";
			gridViewTextBoxColumn4.FieldName = "usuarioHuella";
			gridViewTextBoxColumn4.FormatString = "";
			gridViewTextBoxColumn4.HeaderText = "usuarioHuella";
			gridViewTextBoxColumn4.IsAutoGenerated = true;
			gridViewTextBoxColumn4.IsVisible = false;
			gridViewTextBoxColumn4.Name = "usuarioHuella";
			gridViewDecimalColumn8.DataType = typeof(int);
			gridViewDecimalColumn8.FieldName = "idTarjeta";
			gridViewDecimalColumn8.FormatString = "";
			gridViewDecimalColumn8.HeaderText = "idTarjeta";
			gridViewDecimalColumn8.IsAutoGenerated = true;
			gridViewDecimalColumn8.IsVisible = false;
			gridViewDecimalColumn8.Name = "idTarjeta";
			gridViewComboBoxColumn3.DataSource = this.tTarjetaBindingSource;
			gridViewComboBoxColumn3.DataType = typeof(int);
			gridViewComboBoxColumn3.DisplayMember = "numtarjeta";
			gridViewComboBoxColumn3.FieldName = "idTarjeta";
			gridViewComboBoxColumn3.HeaderText = "Tarjeta";
			gridViewComboBoxColumn3.Name = "column4";
			gridViewComboBoxColumn3.ValueMember = "idTarjeta";
			gridViewComboBoxColumn3.Width = 120;
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewImageColumn, gridViewDecimalColumn2, gridViewDecimalColumn3, gridViewComboBoxColumn, gridViewDecimalColumn4, gridViewComboBoxColumn1, gridViewDecimalColumn5, gridViewComboBoxColumn2, gridViewDecimalColumn6, gridViewTextBoxColumn3, gridViewDateTimeColumn, gridViewDecimalColumn7, gridViewTextBoxColumn4, gridViewDecimalColumn8, gridViewComboBoxColumn3 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tEmpleadoBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ReadOnly = true;
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(897, 449);
			this.radGridView1.TabIndex = 18;
			this.radGridView1.Text = "radGridView1";
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			this.radDesktopAlert2.ContentImage = null;
			this.radDesktopAlert2.PlaySound = false;
			this.radDesktopAlert2.PopupAnimation = true;
			this.radDesktopAlert2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert2.SoundToPlay = null;
			this.radDesktopAlert2.ThemeName = null;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(918, 537);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tEmpleadoBindingNavigator);
			base.Controls.Add(this.panel2);
			base.Name = "frmListadoEmpleados";
			this.Text = "Listado Empleados";
			base.Load += new EventHandler(this.frmListadoEmpleados_Load);
			((ISupportInitialize)this.tEstadoBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tDivisionEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tTarjetaBindingSource).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingNavigator).EndInit();
			this.tEmpleadoBindingNavigator.ResumeLayout(false);
			this.tEmpleadoBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void tEmpleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tEmpleadoBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}