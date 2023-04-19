using BGCOP.CAVTOP.WINFORMS.frmtlk;
using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Localization;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI.Localization;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmVehiculoEmpleado : Form
	{
		private IContainer components = null;

		private Panel panel2;

		private Label label1;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tEmpleadoVehiculoBindingSource;

		private TEmpleadoVehiculoTableAdapter tEmpleadoVehiculoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tEmpleadoVehiculoBindingNavigator;

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

		private ToolStripButton tEmpleadoVehiculoBindingNavigatorSaveItem;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private BindingSource tEmpleadoBindingSource;

		private BindingSource fKTEmpleadoVehiculoTEmpleadoBindingSource;

		private TVehiculoTableAdapter tVehiculoTableAdapter;

		private BindingSource tVehiculoBindingSource;

		private Office2007BlackTheme office2007BlackTheme1;

		private RadDesktopAlert radDesktopAlert1;

		private Button button1;

		private RadGridView radGridView1;

		public frmVehiculoEmpleado()
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
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedVehiculosAsignados.xls");
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

		private void frmVehiculoEmpleado_Load(object sender, EventArgs e)
		{
			this.tVehiculoTableAdapter.Fill(this.masterDBACDataSet.TVehiculo);
			this.tEmpleadoTableAdapter.Fill(this.masterDBACDataSet.TEmpleado);
			this.tEmpleadoVehiculoTableAdapter.Fill(this.masterDBACDataSet.TEmpleadoVehiculo);
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new MyEnglishRadGridLocalizationProvider();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVehiculoEmpleado));
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn2 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tVehiculoBindingSource = new BindingSource(this.components);
			this.panel2 = new Panel();
			this.button1 = new Button();
			this.label1 = new Label();
			this.tEmpleadoVehiculoBindingSource = new BindingSource(this.components);
			this.tEmpleadoVehiculoTableAdapter = new TEmpleadoVehiculoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.tVehiculoTableAdapter = new TVehiculoTableAdapter();
			this.tEmpleadoVehiculoBindingNavigator = new BindingNavigator(this.components);
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
			this.tEmpleadoVehiculoBindingNavigatorSaveItem = new ToolStripButton();
			this.fKTEmpleadoVehiculoTEmpleadoBindingSource = new BindingSource(this.components);
			this.office2007BlackTheme1 = new Office2007BlackTheme();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.radGridView1 = new RadGridView();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tVehiculoBindingSource).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.tEmpleadoVehiculoBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoVehiculoBindingNavigator).BeginInit();
			this.tEmpleadoVehiculoBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.fKTEmpleadoVehiculoTEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.radGridView1).BeginInit();
			base.SuspendLayout();
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tVehiculoBindingSource.DataMember = "TVehiculo";
			this.tVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.panel2.BackColor = Color.White;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(803, 53);
			this.panel2.TabIndex = 3;
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.BackgroundImage = Resources.File_Excel_icon;
			this.button1.BackgroundImageLayout = ImageLayout.Stretch;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(754, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 46);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(37, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Asignacion de vehículos";
			this.tEmpleadoVehiculoBindingSource.DataMember = "TEmpleadoVehiculo";
			this.tEmpleadoVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.tEmpleadoVehiculoTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = null;
			this.tableAdapterManager.TEmpleadoTableAdapter = this.tEmpleadoTableAdapter;
			this.tableAdapterManager.TEmpleadoVehiculoTableAdapter = this.tEmpleadoVehiculoTableAdapter;
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
			this.tableAdapterManager.TVehiculoTableAdapter = this.tVehiculoTableAdapter;
			this.tableAdapterManager.TVisitanteTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaLogTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tEmpleadoTableAdapter.ClearBeforeFill = true;
			this.tVehiculoTableAdapter.ClearBeforeFill = true;
			this.tEmpleadoVehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tEmpleadoVehiculoBindingNavigator.BindingSource = this.tEmpleadoVehiculoBindingSource;
			this.tEmpleadoVehiculoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tEmpleadoVehiculoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tEmpleadoVehiculoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tEmpleadoVehiculoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tEmpleadoVehiculoBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tEmpleadoVehiculoBindingNavigator.Location = new Point(0, 504);
			this.tEmpleadoVehiculoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tEmpleadoVehiculoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tEmpleadoVehiculoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tEmpleadoVehiculoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tEmpleadoVehiculoBindingNavigator.Name = "tEmpleadoVehiculoBindingNavigator";
			this.tEmpleadoVehiculoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tEmpleadoVehiculoBindingNavigator.Size = new System.Drawing.Size(803, 25);
			this.tEmpleadoVehiculoBindingNavigator.TabIndex = 4;
			this.tEmpleadoVehiculoBindingNavigator.Text = "bindingNavigator1";
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
			this.tEmpleadoVehiculoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tEmpleadoVehiculoBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tEmpleadoVehiculoBindingNavigatorSaveItem.Image");
			this.tEmpleadoVehiculoBindingNavigatorSaveItem.Name = "tEmpleadoVehiculoBindingNavigatorSaveItem";
			this.tEmpleadoVehiculoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tEmpleadoVehiculoBindingNavigatorSaveItem.Text = "Save Data";
			this.tEmpleadoVehiculoBindingNavigatorSaveItem.Click += new EventHandler(this.tEmpleadoVehiculoBindingNavigatorSaveItem_Click);
			this.fKTEmpleadoVehiculoTEmpleadoBindingSource.DataMember = "FK_TEmpleadoVehiculo_TEmpleado";
			this.fKTEmpleadoVehiculoTEmpleadoBindingSource.DataSource = this.tEmpleadoBindingSource;
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(8, 56);
			gridViewComboBoxColumn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn.DataSource = this.tEmpleadoBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "identificacion";
			gridViewComboBoxColumn.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn.FieldName = "idEmpleado";
			gridViewComboBoxColumn.FilteringMode = GridViewFilteringMode.DisplayMember;
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Documento";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idEmpleado";
			gridViewComboBoxColumn.Width = 210;
			gridViewComboBoxColumn1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn1.DataSource = this.tEmpleadoBindingSource;
			gridViewComboBoxColumn1.DataType = typeof(int);
			gridViewComboBoxColumn1.DisplayMember = "nombre";
			gridViewComboBoxColumn1.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn1.FieldName = "idEmpleado";
			gridViewComboBoxColumn1.FilteringMode = GridViewFilteringMode.DisplayMember;
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "Empleado";
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "idEmpleado";
			gridViewComboBoxColumn1.Width = 400;
			gridViewComboBoxColumn2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn2.DataSource = this.tVehiculoBindingSource;
			gridViewComboBoxColumn2.DataType = typeof(int);
			gridViewComboBoxColumn2.DisplayMember = "Placa";
			gridViewComboBoxColumn2.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn2.FieldName = "idVehiculo";
			gridViewComboBoxColumn2.FilteringMode = GridViewFilteringMode.DisplayMember;
			gridViewComboBoxColumn2.FormatString = "";
			gridViewComboBoxColumn2.HeaderText = "PLACA";
			gridViewComboBoxColumn2.Name = "column3";
			gridViewComboBoxColumn2.ValueMember = "idVehiculo";
			gridViewComboBoxColumn2.Width = 130;
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "IdEmpleado";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "IdEmpleado";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "IdEmpleado";
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "IdVehiculo";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "IdVehiculo";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "IdVehiculo";
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "usuarioUltimaGestion";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewComboBoxColumn, gridViewComboBoxColumn1, gridViewComboBoxColumn2, gridViewDecimalColumn, gridViewDecimalColumn1, gridViewDateTimeColumn, gridViewDecimalColumn2 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tEmpleadoVehiculoBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(783, 445);
			this.radGridView1.TabIndex = 6;
			this.radGridView1.Text = "radGridView2";
			this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
			this.radGridView1.DataError += new GridViewDataErrorEventHandler(this.radGridView1_DataError);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(803, 529);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tEmpleadoVehiculoBindingNavigator);
			base.Controls.Add(this.panel2);
			base.Name = "frmVehiculoEmpleado";
			this.Text = "frmVehiculoEmpleado";
			base.Load += new EventHandler(this.frmVehiculoEmpleado_Load);
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tVehiculoBindingSource).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.tEmpleadoVehiculoBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoVehiculoBindingNavigator).EndInit();
			this.tEmpleadoVehiculoBindingNavigator.ResumeLayout(false);
			this.tEmpleadoVehiculoBindingNavigator.PerformLayout();
			((ISupportInitialize)this.fKTEmpleadoVehiculoTEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.radGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
		{
			try
			{
				e.Row.Cells["fechaUltimaGestion"].Value = DateTime.Now;
				e.Row.Cells["usuarioUltimaGestion"].Value = Program.idUsuarioActual;
			}
			catch (Exception exception)
			{
			}
		}

		private void radGridView1_DataError(object sender, GridViewDataErrorEventArgs e)
		{
			try
			{
				MessageBox.Show(string.Concat("Error: ", e.ToString()), Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			catch (Exception exception)
			{
			}
		}

		private void tEmpleadoVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea realizar las operaciones pendientes?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				try
				{
					base.Validate();
					this.tEmpleadoVehiculoBindingSource.EndEdit();
					this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
					MessageBox.Show("El registro se proceso con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Error: ", exception.ToString()), Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
	}
}