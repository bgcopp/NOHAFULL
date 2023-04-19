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
	public class frmLiberaParqueo : Form
	{
		private IContainer components = null;

		private Panel panel2;

		private Button button1;

		private Label label1;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tParqueoBindingSource;

		private TParqueoTableAdapter tParqueoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tParqueoBindingNavigator;

		private ToolStripLabel bindingNavigatorCountItem;

		private ToolStripButton bindingNavigatorMoveFirstItem;

		private ToolStripButton bindingNavigatorMovePreviousItem;

		private ToolStripSeparator bindingNavigatorSeparator;

		private ToolStripTextBox bindingNavigatorPositionItem;

		private ToolStripSeparator bindingNavigatorSeparator1;

		private ToolStripButton bindingNavigatorMoveNextItem;

		private ToolStripButton bindingNavigatorMoveLastItem;

		private ToolStripSeparator bindingNavigatorSeparator2;

		private ToolStripButton tParqueoBindingNavigatorSaveItem;

		private RadGridView radGridView1;

		private RadDesktopAlert radDesktopAlert1;

		public frmLiberaParqueo()
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
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedDataDivisiones.xls");
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

		private void frmLiberaParqueo_Load(object sender, EventArgs e)
		{
			this.tParqueoTableAdapter.Fill(this.masterDBACDataSet.TParqueo);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmLiberaParqueo));
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn = new GridViewCheckBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			this.panel2 = new Panel();
			this.button1 = new Button();
			this.label1 = new Label();
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tParqueoBindingSource = new BindingSource(this.components);
			this.tParqueoTableAdapter = new TParqueoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tParqueoBindingNavigator = new BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new ToolStripButton();
			this.bindingNavigatorSeparator = new ToolStripSeparator();
			this.bindingNavigatorPositionItem = new ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new ToolStripButton();
			this.bindingNavigatorMoveLastItem = new ToolStripButton();
			this.bindingNavigatorSeparator2 = new ToolStripSeparator();
			this.tParqueoBindingNavigatorSaveItem = new ToolStripButton();
			this.radGridView1 = new RadGridView();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tParqueoBindingSource).BeginInit();
			((ISupportInitialize)this.tParqueoBindingNavigator).BeginInit();
			this.tParqueoBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			base.SuspendLayout();
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(947, 53);
			this.panel2.TabIndex = 61;
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.BackgroundImage = Resources.File_Excel_icon;
			this.button1.BackgroundImageLayout = ImageLayout.Stretch;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(898, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 46);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Libera Parqueo";
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tParqueoBindingSource.DataMember = "TParqueo";
			this.tParqueoBindingSource.DataSource = this.masterDBACDataSet;
			this.tParqueoTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.TParqueoTableAdapter = this.tParqueoTableAdapter;
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
			this.tParqueoBindingNavigator.AddNewItem = null;
			this.tParqueoBindingNavigator.BindingSource = this.tParqueoBindingSource;
			this.tParqueoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tParqueoBindingNavigator.DeleteItem = null;
			this.tParqueoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tParqueoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.tParqueoBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tParqueoBindingNavigator.Location = new Point(0, 506);
			this.tParqueoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tParqueoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tParqueoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tParqueoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tParqueoBindingNavigator.Name = "tParqueoBindingNavigator";
			this.tParqueoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tParqueoBindingNavigator.Size = new System.Drawing.Size(947, 25);
			this.tParqueoBindingNavigator.TabIndex = 62;
			this.tParqueoBindingNavigator.Text = "bindingNavigator1";
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
			this.tParqueoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tParqueoBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tParqueoBindingNavigatorSaveItem.Image");
			this.tParqueoBindingNavigatorSaveItem.Name = "tParqueoBindingNavigatorSaveItem";
			this.tParqueoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tParqueoBindingNavigatorSaveItem.Text = "Save Data";
			this.tParqueoBindingNavigatorSaveItem.Click += new EventHandler(this.tParqueoBindingNavigatorSaveItem_Click);
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(9, 60);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			gridViewTextBoxColumn.FieldName = "nParqueo";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "Parqueadero";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "nParqueo";
			gridViewTextBoxColumn.Width = 300;
			gridViewTextBoxColumn1.FieldName = "ocupadopor";
			gridViewTextBoxColumn1.FormatString = "";
			gridViewTextBoxColumn1.HeaderText = "Ultimo Vehiculo";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "ocupadopor";
			gridViewTextBoxColumn1.Width = 150;
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "idParqueadero";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idParqueadero";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idParqueadero";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewTextBoxColumn2.FieldName = "observacionesParqueo";
			gridViewTextBoxColumn2.FormatString = "";
			gridViewTextBoxColumn2.HeaderText = "observacionesParqueo";
			gridViewTextBoxColumn2.IsAutoGenerated = true;
			gridViewTextBoxColumn2.IsVisible = false;
			gridViewTextBoxColumn2.Name = "observacionesParqueo";
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewCheckBoxColumn.FieldName = "estaocupado";
			gridViewCheckBoxColumn.FormatString = "";
			gridViewCheckBoxColumn.HeaderText = "Ocupado";
			gridViewCheckBoxColumn.IsAutoGenerated = true;
			gridViewCheckBoxColumn.Name = "estaocupado";
			gridViewCheckBoxColumn.Width = 100;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "usuarioUltimaGestion";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewTextBoxColumn, gridViewTextBoxColumn1, gridViewDecimalColumn, gridViewTextBoxColumn2, gridViewDateTimeColumn, gridViewCheckBoxColumn, gridViewDecimalColumn1 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tParqueoBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(926, 443);
			this.radGridView1.TabIndex = 63;
			this.radGridView1.Text = "radGridView1";
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new System.Drawing.Size(947, 531);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tParqueoBindingNavigator);
			base.Controls.Add(this.panel2);
			base.Name = "frmLiberaParqueo";
			this.Text = "Liberar Parqueo";
			base.Load += new EventHandler(this.frmLiberaParqueo_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tParqueoBindingSource).EndInit();
			((ISupportInitialize)this.tParqueoBindingNavigator).EndInit();
			this.tParqueoBindingNavigator.ResumeLayout(false);
			this.tParqueoBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void tParqueoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tParqueoBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}