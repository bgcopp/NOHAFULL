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
	public class frmListadoVehiculosParqueo : Form
	{
		private IContainer components = null;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tVehiculoBindingSource;

		private TVehiculoTableAdapter tVehiculoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tVehiculoBindingNavigator;

		private ToolStripLabel bindingNavigatorCountItem;

		private ToolStripButton bindingNavigatorMoveFirstItem;

		private ToolStripButton bindingNavigatorMovePreviousItem;

		private ToolStripSeparator bindingNavigatorSeparator;

		private ToolStripTextBox bindingNavigatorPositionItem;

		private ToolStripSeparator bindingNavigatorSeparator1;

		private ToolStripButton bindingNavigatorMoveNextItem;

		private ToolStripButton bindingNavigatorMoveLastItem;

		private ToolStripSeparator bindingNavigatorSeparator2;

		private RadGridView radGridView1;

		private TModeloVehiculoTableAdapter tModeloVehiculoTableAdapter;

		private Panel panel2;

		private Button button1;

		private Label label1;

		private BindingSource tModeloVehiculoBindingSource;

		private RadDesktopAlert radDesktopAlert1;

		public frmListadoVehiculosParqueo()
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
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedListadoVehiculos.xls");
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

		private void frmListadoVehiculosParqueo_Load(object sender, EventArgs e)
		{
			this.tModeloVehiculoTableAdapter.Fill(this.masterDBACDataSet.TModeloVehiculo);
			this.tVehiculoTableAdapter.Fill(this.masterDBACDataSet.TVehiculo);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmListadoVehiculosParqueo));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn = new GridViewCheckBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn1 = new GridViewDateTimeColumn();
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tVehiculoBindingSource = new BindingSource(this.components);
			this.tVehiculoTableAdapter = new TVehiculoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tVehiculoBindingNavigator = new BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new ToolStripButton();
			this.bindingNavigatorSeparator = new ToolStripSeparator();
			this.bindingNavigatorPositionItem = new ToolStripTextBox();
			this.bindingNavigatorCountItem = new ToolStripLabel();
			this.bindingNavigatorSeparator1 = new ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new ToolStripButton();
			this.bindingNavigatorMoveLastItem = new ToolStripButton();
			this.bindingNavigatorSeparator2 = new ToolStripSeparator();
			this.radGridView1 = new RadGridView();
			this.panel2 = new Panel();
			this.button1 = new Button();
			this.label1 = new Label();
			this.tModeloVehiculoBindingSource = new BindingSource(this.components);
			this.tModeloVehiculoTableAdapter = new TModeloVehiculoTableAdapter();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tVehiculoBindingSource).BeginInit();
			((ISupportInitialize)this.tVehiculoBindingNavigator).BeginInit();
			this.tVehiculoBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.tModeloVehiculoBindingSource).BeginInit();
			base.SuspendLayout();
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tVehiculoBindingSource.DataMember = "TVehiculo";
			this.tVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.tVehiculoTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.TModeloVehiculoTableAdapter = this.tModeloVehiculoTableAdapter;
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
			this.tVehiculoBindingNavigator.AddNewItem = null;
			this.tVehiculoBindingNavigator.BindingSource = this.tVehiculoBindingSource;
			this.tVehiculoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tVehiculoBindingNavigator.DeleteItem = null;
			this.tVehiculoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tVehiculoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2 };
			items.AddRange(toolStripItemArray);
			this.tVehiculoBindingNavigator.Location = new Point(0, 536);
			this.tVehiculoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tVehiculoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tVehiculoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tVehiculoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tVehiculoBindingNavigator.Name = "tVehiculoBindingNavigator";
			this.tVehiculoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tVehiculoBindingNavigator.Size = new System.Drawing.Size(786, 25);
			this.tVehiculoBindingNavigator.TabIndex = 0;
			this.tVehiculoBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(9, 60);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "idVehiculo";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idVehiculo";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.Name = "idVehiculo";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewDecimalColumn.Width = 100;
			gridViewTextBoxColumn.FieldName = "Placa";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "Placa";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "Placa";
			gridViewTextBoxColumn.Width = 130;
			gridViewDecimalColumn1.DataType = typeof(short);
			gridViewDecimalColumn1.FieldName = "idModeloVehiculo";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idModeloVehiculo";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idModeloVehiculo";
			gridViewComboBoxColumn.DataSource = this.tModeloVehiculoBindingSource;
			gridViewComboBoxColumn.DataType = typeof(short);
			gridViewComboBoxColumn.DisplayMember = "NombreModelo";
			gridViewComboBoxColumn.FieldName = "idModeloVehiculo";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Modelo";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idModeloVehiculo";
			gridViewTextBoxColumn1.FieldName = "CodigodeBarras";
			gridViewTextBoxColumn1.FormatString = "";
			gridViewTextBoxColumn1.HeaderText = "CodigodeBarras";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "CodigodeBarras";
			gridViewTextBoxColumn1.Width = 160;
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
			gridViewTextBoxColumn2.FieldName = "color";
			gridViewTextBoxColumn2.FormatString = "";
			gridViewTextBoxColumn2.HeaderText = "color";
			gridViewTextBoxColumn2.IsAutoGenerated = true;
			gridViewTextBoxColumn2.Name = "color";
			gridViewTextBoxColumn2.Width = 150;
			gridViewCheckBoxColumn.FieldName = "estaOcupado";
			gridViewCheckBoxColumn.FormatString = "";
			gridViewCheckBoxColumn.HeaderText = "estaOcupado";
			gridViewCheckBoxColumn.IsAutoGenerated = true;
			gridViewCheckBoxColumn.IsVisible = false;
			gridViewCheckBoxColumn.Name = "estaOcupado";
			gridViewDateTimeColumn1.FieldName = "fechaUltOcup";
			gridViewDateTimeColumn1.FormatString = "";
			gridViewDateTimeColumn1.HeaderText = "fechaUltOcup";
			gridViewDateTimeColumn1.IsAutoGenerated = true;
			gridViewDateTimeColumn1.IsVisible = false;
			gridViewDateTimeColumn1.Name = "fechaUltOcup";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDecimalColumn1, gridViewComboBoxColumn, gridViewTextBoxColumn1, gridViewDateTimeColumn, gridViewDecimalColumn2, gridViewTextBoxColumn2, gridViewCheckBoxColumn, gridViewDateTimeColumn1 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tVehiculoBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ReadOnly = true;
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(765, 473);
			this.radGridView1.TabIndex = 1;
			this.radGridView1.Text = "radGridView1";
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(786, 53);
			this.panel2.TabIndex = 17;
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.BackgroundImage = Resources.File_Excel_icon;
			this.button1.BackgroundImageLayout = ImageLayout.Stretch;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(728, 4);
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
			this.label1.Size = new System.Drawing.Size(232, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Listado de Vehiculos";
			this.tModeloVehiculoBindingSource.DataMember = "TModeloVehiculo";
			this.tModeloVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.tModeloVehiculoTableAdapter.ClearBeforeFill = true;
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(786, 561);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tVehiculoBindingNavigator);
			base.Name = "frmListadoVehiculosParqueo";
			this.Text = "Vehiculos";
			base.Load += new EventHandler(this.frmListadoVehiculosParqueo_Load);
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tVehiculoBindingSource).EndInit();
			((ISupportInitialize)this.tVehiculoBindingNavigator).EndInit();
			this.tVehiculoBindingNavigator.ResumeLayout(false);
			this.tVehiculoBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.tModeloVehiculoBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void tVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tVehiculoBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}