using BGCOP.CAVTOP.WINFORMS.frmtlk;
using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.Collections.Generic;
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
	public class frmEmpleado : Form
	{
		private IContainer components = null;

		private ToolTip toolTip1;

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

		private RadGridView radGridView1;

		private BindingSource tTipoIdentificacionBindingSource;

		private TTipoIdentificacionTableAdapter tTipoIdentificacionTableAdapter;

		private BindingSource tCargoBindingSource;

		private TCargoTableAdapter tCargoTableAdapter;

		private BindingSource tEstadoBindingSource;

		private TEstadoTableAdapter tEstadoTableAdapter;

		private BindingSource tEmpresaBindingSource;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private BindingSource tDivisionEmpresaBindingSource;

		private TDivisionEmpresaTableAdapter tDivisionEmpresaTableAdapter;

		private Office2010BlueTheme office2010BlueTheme1;

		private TelerikMetroBlueTheme telerikMetroBlueTheme1;

		private Office2010BlackTheme office2010BlackTheme1;

		private Panel panel2;

		private Label label1;

		private Office2007BlackTheme office2007BlackTheme1;

		private BindingSource tTarjetaBindingSource;

		private TTarjetaTableAdapter tTarjetaTableAdapter;

		private Office2010BlackTheme office2010BlackTheme2;

		private TelerikMetroTheme telerikMetroTheme1;

		private DesertTheme desertTheme1;

		private BreezeTheme breezeTheme1;

		private BindingSource fKTDivisionEmpresaTEmpresaBindingSource;

		private Timer timer1;

		public frmEmpleado()
		{
			this.InitializeComponent();
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea eliminar el registro seleccionado?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				this.tCargoBindingSource.RemoveCurrent();
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

		private void frmEmpleado_Load(object sender, EventArgs e)
		{
			this.tTarjetaTableAdapter.Fill(this.masterDBACDataSet.TTarjeta);
			this.tDivisionEmpresaTableAdapter.Fill(this.masterDBACDataSet.TDivisionEmpresa);
			this.tEmpresaTableAdapter.Fill(this.masterDBACDataSet.TEmpresa);
			this.tEstadoTableAdapter.Fill(this.masterDBACDataSet.TEstado);
			this.tCargoTableAdapter.Fill(this.masterDBACDataSet.TCargo);
			this.tTipoIdentificacionTableAdapter.Fill(this.masterDBACDataSet.TTipoIdentificacion);
			this.tEmpleadoTableAdapter.Fill(this.masterDBACDataSet.TEmpleado);
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new MyEnglishRadGridLocalizationProvider();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmEmpleado));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn2 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			GridViewDecimalColumn gridViewDecimalColumn4 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn3 = new GridViewComboBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn4 = new GridViewComboBoxColumn();
			GridViewImageColumn gridViewImageColumn = new GridViewImageColumn();
			GridViewCommandColumn gridViewCommandColumn = new GridViewCommandColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn5 = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn5 = new GridViewDecimalColumn();
			GridViewDecimalColumn gridViewDecimalColumn6 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn7 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
			this.tTipoIdentificacionBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.tDivisionEmpresaBindingSource = new BindingSource(this.components);
			this.tCargoBindingSource = new BindingSource(this.components);
			this.tTarjetaBindingSource = new BindingSource(this.components);
			this.tEstadoBindingSource = new BindingSource(this.components);
			this.toolTip1 = new ToolTip(this.components);
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tEmpleadoBindingNavigator = new BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new ToolStripButton();
			this.bindingNavigatorCountItem = new ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new ToolStripButton();
			this.bindingNavigatorSeparator = new ToolStripSeparator();
			this.bindingNavigatorPositionItem = new ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new ToolStripButton();
			this.bindingNavigatorMoveLastItem = new ToolStripButton();
			this.bindingNavigatorSeparator2 = new ToolStripSeparator();
			this.bindingNavigatorDeleteItem = new ToolStripButton();
			this.tEmpleadoBindingNavigatorSaveItem = new ToolStripButton();
			this.radGridView1 = new RadGridView();
			this.tTipoIdentificacionTableAdapter = new TTipoIdentificacionTableAdapter();
			this.tCargoTableAdapter = new TCargoTableAdapter();
			this.tEstadoTableAdapter = new TEstadoTableAdapter();
			this.tEmpresaTableAdapter = new TEmpresaTableAdapter();
			this.tDivisionEmpresaTableAdapter = new TDivisionEmpresaTableAdapter();
			this.office2010BlueTheme1 = new Office2010BlueTheme();
			this.telerikMetroBlueTheme1 = new TelerikMetroBlueTheme();
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.office2007BlackTheme1 = new Office2007BlackTheme();
			this.tTarjetaTableAdapter = new TTarjetaTableAdapter();
			this.office2010BlackTheme2 = new Office2010BlackTheme();
			this.telerikMetroTheme1 = new TelerikMetroTheme();
			this.desertTheme1 = new DesertTheme();
			this.breezeTheme1 = new BreezeTheme();
			this.fKTDivisionEmpresaTEmpresaBindingSource = new BindingSource(this.components);
			this.timer1 = new Timer(this.components);
			((ISupportInitialize)this.tTipoIdentificacionBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tDivisionEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tCargoBindingSource).BeginInit();
			((ISupportInitialize)this.tTarjetaBindingSource).BeginInit();
			((ISupportInitialize)this.tEstadoBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingNavigator).BeginInit();
			this.tEmpleadoBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.fKTDivisionEmpresaTEmpresaBindingSource).BeginInit();
			base.SuspendLayout();
			this.tTipoIdentificacionBindingSource.DataMember = "TTipoIdentificacion";
			this.tTipoIdentificacionBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tDivisionEmpresaBindingSource.DataMember = "TDivisionEmpresa";
			this.tDivisionEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.tCargoBindingSource.DataMember = "TCargo";
			this.tCargoBindingSource.DataSource = this.masterDBACDataSet;
			this.tCargoBindingSource.Sort = "NombreCargo";
			this.tTarjetaBindingSource.DataMember = "TTarjeta";
			this.tTarjetaBindingSource.DataSource = this.masterDBACDataSet;
			this.tEstadoBindingSource.DataMember = "TEstado";
			this.tEstadoBindingSource.DataSource = this.masterDBACDataSet;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Sistema de Control de Acceso";
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
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tEmpleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tEmpleadoBindingNavigator.BindingSource = this.tEmpleadoBindingSource;
			this.tEmpleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tEmpleadoBindingNavigator.CountItemFormat = "de {0}";
			this.tEmpleadoBindingNavigator.DeleteItem = null;
			this.tEmpleadoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tEmpleadoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tEmpleadoBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tEmpleadoBindingNavigator.Location = new Point(0, 498);
			this.tEmpleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tEmpleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tEmpleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tEmpleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tEmpleadoBindingNavigator.Name = "tEmpleadoBindingNavigator";
			this.tEmpleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tEmpleadoBindingNavigator.Size = new System.Drawing.Size(774, 25);
			this.tEmpleadoBindingNavigator.TabIndex = 0;
			this.tEmpleadoBindingNavigator.Text = "bindingNavigator1";
			this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.ToolTipText = "Nuevo Registro";
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
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
			this.bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.ToolTipText = "Eliminar Registro";
			this.bindingNavigatorDeleteItem.Click += new EventHandler(this.bindingNavigatorDeleteItem_Click);
			this.tEmpleadoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tEmpleadoBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tEmpleadoBindingNavigatorSaveItem.Image");
			this.tEmpleadoBindingNavigatorSaveItem.Name = "tEmpleadoBindingNavigatorSaveItem";
			this.tEmpleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tEmpleadoBindingNavigatorSaveItem.Text = "Save Data";
			this.tEmpleadoBindingNavigatorSaveItem.ToolTipText = "Guardar Cambios";
			this.tEmpleadoBindingNavigatorSaveItem.Click += new EventHandler(this.tEmpleadoBindingNavigatorSaveItem_Click);
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 85);
			this.radGridView1.MasterTemplate.AllowDragToGroup = false;
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "idEmpleado";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idEmpleado";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idEmpleado";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewTextBoxColumn.ColumnCharacterCasing = CharacterCasing.Upper;
			gridViewTextBoxColumn.ExcelExportType = DisplayFormatType.Text;
			gridViewTextBoxColumn.FieldName = "nombre";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "Nombre";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "nombre";
			gridViewTextBoxColumn.Width = 230;
			gridViewComboBoxColumn.DataSource = this.tTipoIdentificacionBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "descripcionIdentificacion";
			gridViewComboBoxColumn.ExcelExportType = DisplayFormatType.Text;
			gridViewComboBoxColumn.FieldName = "idTipoIdentificacion";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Tipo Documento";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idTipoIdentificacion";
			gridViewComboBoxColumn.Width = 110;
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
			gridViewTextBoxColumn1.Width = 150;
			gridViewComboBoxColumn1.DataSource = this.tEmpresaBindingSource;
			gridViewComboBoxColumn1.DataType = typeof(int);
			gridViewComboBoxColumn1.DisplayMember = "RazonSocial";
			gridViewComboBoxColumn1.FieldName = "idEmpresa";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "Empresa";
			gridViewComboBoxColumn1.Name = "column4";
			gridViewComboBoxColumn1.ValueMember = "idEmpresa";
			gridViewComboBoxColumn1.Width = 220;
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "idEmpresa";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "idEmpresa";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "idEmpresa";
			gridViewComboBoxColumn2.DataSource = this.tDivisionEmpresaBindingSource;
			gridViewComboBoxColumn2.DataType = typeof(int);
			gridViewComboBoxColumn2.DisplayMember = "NombreDivision";
			gridViewComboBoxColumn2.EnableExpressionEditor = false;
			gridViewComboBoxColumn2.Expression = "";
			gridViewComboBoxColumn2.FieldName = "IdDivisionEmpresa";
			gridViewComboBoxColumn2.FormatString = "";
			gridViewComboBoxColumn2.HeaderText = "División";
			gridViewComboBoxColumn2.Name = "column5";
			gridViewComboBoxColumn2.ValueMember = "IdDivisionEmpresa";
			gridViewComboBoxColumn2.Width = 220;
			gridViewDecimalColumn3.DataType = typeof(int);
			gridViewDecimalColumn3.FieldName = "idDivisionEmpresa";
			gridViewDecimalColumn3.FormatString = "";
			gridViewDecimalColumn3.HeaderText = "idDivisionEmpresa";
			gridViewDecimalColumn3.IsAutoGenerated = true;
			gridViewDecimalColumn3.Name = "idDivisionEmpresa";
			gridViewDecimalColumn3.Width = 35;
			gridViewDecimalColumn4.DataType = typeof(int);
			gridViewDecimalColumn4.FieldName = "idCargo";
			gridViewDecimalColumn4.FormatString = "";
			gridViewDecimalColumn4.HeaderText = "idCargo";
			gridViewDecimalColumn4.IsAutoGenerated = true;
			gridViewDecimalColumn4.IsVisible = false;
			gridViewDecimalColumn4.Name = "idCargo";
			gridViewComboBoxColumn3.DataSource = this.tCargoBindingSource;
			gridViewComboBoxColumn3.DataType = typeof(int);
			gridViewComboBoxColumn3.DisplayMember = "NombreCargo";
			gridViewComboBoxColumn3.FieldName = "idCargo";
			gridViewComboBoxColumn3.FormatString = "";
			gridViewComboBoxColumn3.HeaderText = "Cargo";
			gridViewComboBoxColumn3.Name = "cargo";
			gridViewComboBoxColumn3.ValueMember = "idCargo";
			gridViewComboBoxColumn3.Width = 200;
			gridViewTextBoxColumn2.FieldName = "Notarjeta";
			gridViewTextBoxColumn2.FormatString = "";
			gridViewTextBoxColumn2.HeaderText = "Tarjeta";
			gridViewTextBoxColumn2.IsAutoGenerated = true;
			gridViewTextBoxColumn2.IsVisible = false;
			gridViewTextBoxColumn2.Name = "Notarjeta";
			gridViewTextBoxColumn2.Width = 120;
			gridViewComboBoxColumn4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn4.DataSource = this.tTarjetaBindingSource;
			gridViewComboBoxColumn4.DataType = typeof(int);
			gridViewComboBoxColumn4.DisplayMember = "numtarjeta";
			gridViewComboBoxColumn4.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn4.FieldName = "idTarjeta";
			gridViewComboBoxColumn4.FormatString = "";
			gridViewComboBoxColumn4.HeaderText = "Tarjeta";
			gridViewComboBoxColumn4.Name = "column6";
			gridViewComboBoxColumn4.ValueMember = "idTarjeta";
			gridViewComboBoxColumn4.Width = 150;
			gridViewImageColumn.DataType = typeof(byte[]);
			gridViewImageColumn.FieldName = "foto";
			gridViewImageColumn.FormatString = "";
			gridViewImageColumn.HeaderText = "Foto";
			gridViewImageColumn.IsAutoGenerated = true;
			gridViewImageColumn.IsVisible = false;
			gridViewImageColumn.Name = "foto";
			gridViewImageColumn.Width = 100;
			gridViewCommandColumn.DefaultText = "Seleccion de Origen";
			gridViewCommandColumn.FormatString = "";
			gridViewCommandColumn.HeaderText = "Foto ADV.";
			gridViewCommandColumn.IsVisible = false;
			gridViewCommandColumn.Name = "column2";
			gridViewCommandColumn.UseDefaultText = true;
			gridViewCommandColumn.Width = 130;
			gridViewComboBoxColumn5.DataSource = this.tEstadoBindingSource;
			gridViewComboBoxColumn5.DataType = typeof(int);
			gridViewComboBoxColumn5.DisplayMember = "NombreEstado";
			gridViewComboBoxColumn5.FieldName = "idTipoEstado";
			gridViewComboBoxColumn5.FormatString = "";
			gridViewComboBoxColumn5.HeaderText = "Estado";
			gridViewComboBoxColumn5.Name = "column3";
			gridViewComboBoxColumn5.ValueMember = "idTipoEstado";
			gridViewComboBoxColumn5.Width = 150;
			gridViewDecimalColumn5.DataType = typeof(int);
			gridViewDecimalColumn5.FieldName = "idTipoEstado";
			gridViewDecimalColumn5.FormatString = "";
			gridViewDecimalColumn5.HeaderText = "idTipoEstado";
			gridViewDecimalColumn5.IsAutoGenerated = true;
			gridViewDecimalColumn5.IsVisible = false;
			gridViewDecimalColumn5.Name = "idTipoEstado";
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
			gridViewTextBoxColumn3.Name = "observaciones";
			gridViewTextBoxColumn3.Width = 250;
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewDateTimeColumn.Width = 35;
			gridViewDecimalColumn7.DataType = typeof(int);
			gridViewDecimalColumn7.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn7.FormatString = "";
			gridViewDecimalColumn7.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn7.IsAutoGenerated = true;
			gridViewDecimalColumn7.IsVisible = false;
			gridViewDecimalColumn7.Name = "usuarioUltimaGestion";
			gridViewDecimalColumn7.Width = 35;
			gridViewTextBoxColumn4.FieldName = "usuarioHuella";
			gridViewTextBoxColumn4.FormatString = "";
			gridViewTextBoxColumn4.HeaderText = "usuarioHuella";
			gridViewTextBoxColumn4.IsAutoGenerated = true;
			gridViewTextBoxColumn4.IsVisible = false;
			gridViewTextBoxColumn4.Name = "usuarioHuella";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewComboBoxColumn, gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewComboBoxColumn1, gridViewDecimalColumn2, gridViewComboBoxColumn2, gridViewDecimalColumn3, gridViewDecimalColumn4, gridViewComboBoxColumn3, gridViewTextBoxColumn2, gridViewComboBoxColumn4, gridViewImageColumn, gridViewCommandColumn, gridViewComboBoxColumn5, gridViewDecimalColumn5, gridViewDecimalColumn6, gridViewTextBoxColumn3, gridViewDateTimeColumn, gridViewDecimalColumn7, gridViewTextBoxColumn4 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tEmpleadoBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.MultiSelect = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(750, 410);
			this.radGridView1.TabIndex = 1;
			this.radGridView1.Text = "radGridView1";
			this.radGridView1.ThemeName = "ControlDefault";
			this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
			this.radGridView1.UserAddingRow += new GridViewRowCancelEventHandler(this.radGridView1_UserAddingRow);
			this.radGridView1.DataBindingComplete += new GridViewBindingCompleteEventHandler(this.radGridView1_DataBindingComplete);
			this.tTipoIdentificacionTableAdapter.ClearBeforeFill = true;
			this.tCargoTableAdapter.ClearBeforeFill = true;
			this.tEstadoTableAdapter.ClearBeforeFill = true;
			this.tEmpresaTableAdapter.ClearBeforeFill = true;
			this.tDivisionEmpresaTableAdapter.ClearBeforeFill = true;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(774, 53);
			this.panel2.TabIndex = 14;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Listado Empleado";
			this.tTarjetaTableAdapter.ClearBeforeFill = true;
			this.fKTDivisionEmpresaTEmpresaBindingSource.DataMember = "FK_TDivisionEmpresa_TEmpresa";
			this.fKTDivisionEmpresaTEmpresaBindingSource.DataSource = this.tEmpresaBindingSource;
			this.timer1.Interval = 800;
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(774, 523);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tEmpleadoBindingNavigator);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmEmpleado";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Empleados";
			base.Load += new EventHandler(this.frmEmpleado_Load);
			((ISupportInitialize)this.tTipoIdentificacionBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tDivisionEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tCargoBindingSource).EndInit();
			((ISupportInitialize)this.tTarjetaBindingSource).EndInit();
			((ISupportInitialize)this.tEstadoBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingNavigator).EndInit();
			this.tEmpleadoBindingNavigator.ResumeLayout(false);
			this.tEmpleadoBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.fKTDivisionEmpresaTEmpresaBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
		{
			e.Row.Cells["fechaUltimaGestion"].Value = DateTime.Now;
			e.Row.Cells["usuarioUltimaGestion"].Value = Program.idUsuarioActual;
		}

		private void radGridView1_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
		{
			foreach (GridViewRowInfo row in this.radGridView1.Rows)
			{
				row.Cells[7].Value = 2;
			}
		}

		private void radGridView1_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
		}
	}
}