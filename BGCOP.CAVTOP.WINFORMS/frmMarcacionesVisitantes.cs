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
	public class frmMarcacionesVisitantes : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label1;

		private Button button1;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tMarcacionBindingSource;

		private TMarcacionTableAdapter tMarcacionTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tMarcacionBindingNavigator;

		private ToolStripLabel bindingNavigatorCountItem;

		private ToolStripButton bindingNavigatorMoveFirstItem;

		private ToolStripButton bindingNavigatorMovePreviousItem;

		private ToolStripSeparator bindingNavigatorSeparator;

		private ToolStripTextBox bindingNavigatorPositionItem;

		private ToolStripSeparator bindingNavigatorSeparator1;

		private ToolStripButton bindingNavigatorMoveNextItem;

		private ToolStripButton bindingNavigatorMoveLastItem;

		private ToolStripSeparator bindingNavigatorSeparator2;

		private TVisitanteTableAdapter tVisitanteTableAdapter;

		private RadGridView radGridView1;

		private BindingSource tVisitanteBindingSource;

		private RadDesktopAlert radDesktopAlert1;

		public frmMarcacionesVisitantes()
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
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedDataMarcacionVisitantes.xls");
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

		private void frmMarcacionesVisitantes_Load(object sender, EventArgs e)
		{
			this.tVisitanteTableAdapter.Fill(this.masterDBACDataSet.TVisitante);
			this.tMarcacionTableAdapter.FillByVisitantes(this.masterDBACDataSet.TMarcacion);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMarcacionesVisitantes));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			this.tVisitanteBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.button1 = new Button();
			this.tMarcacionBindingSource = new BindingSource(this.components);
			this.tMarcacionTableAdapter = new TMarcacionTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tVisitanteTableAdapter = new TVisitanteTableAdapter();
			this.tMarcacionBindingNavigator = new BindingNavigator(this.components);
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
			((ISupportInitialize)this.tVisitanteBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.tMarcacionBindingSource).BeginInit();
			((ISupportInitialize)this.tMarcacionBindingNavigator).BeginInit();
			this.tMarcacionBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			base.SuspendLayout();
			this.tVisitanteBindingSource.DataMember = "TVisitante";
			this.tVisitanteBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.panel1.BackColor = Color.White;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = DockStyle.Top;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(891, 68);
			this.panel1.TabIndex = 3;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(13, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(425, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Reportes de Marcaciones de Visitantes";
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.BackgroundImage = Resources.File_Excel_icon;
			this.button1.BackgroundImageLayout = ImageLayout.Stretch;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(833, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(46, 46);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.tMarcacionBindingSource.DataMember = "TMarcacion";
			this.tMarcacionBindingSource.DataSource = this.masterDBACDataSet;
			this.tMarcacionTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.TMarcacionTableAdapter = this.tMarcacionTableAdapter;
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
			this.tableAdapterManager.TVisitanteTableAdapter = this.tVisitanteTableAdapter;
			this.tableAdapterManager.TVisitanteVisitaProgramadaLogTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tVisitanteTableAdapter.ClearBeforeFill = true;
			this.tMarcacionBindingNavigator.AddNewItem = null;
			this.tMarcacionBindingNavigator.BindingSource = this.tMarcacionBindingSource;
			this.tMarcacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tMarcacionBindingNavigator.DeleteItem = null;
			this.tMarcacionBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tMarcacionBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2 };
			items.AddRange(toolStripItemArray);
			this.tMarcacionBindingNavigator.Location = new Point(0, 314);
			this.tMarcacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tMarcacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tMarcacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tMarcacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tMarcacionBindingNavigator.Name = "tMarcacionBindingNavigator";
			this.tMarcacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tMarcacionBindingNavigator.Size = new System.Drawing.Size(891, 25);
			this.tMarcacionBindingNavigator.TabIndex = 4;
			this.tMarcacionBindingNavigator.Text = "bindingNavigator1";
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
			this.radGridView1.Location = new Point(0, 74);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			this.radGridView1.MasterTemplate.AllowDeleteRow = false;
			this.radGridView1.MasterTemplate.AllowEditRow = false;
			gridViewDecimalColumn.FieldName = "idMarcacion";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "ID";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.Name = "idMarcacion";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewDecimalColumn.Width = 70;
			gridViewTextBoxColumn.FieldName = "NoTarjeta";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "Tarjeta";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "NoTarjeta";
			gridViewTextBoxColumn.Width = 120;
			gridViewDateTimeColumn.FieldName = "fechaMarcacion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "Fecha";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.Name = "fechaMarcacion";
			gridViewDateTimeColumn.Width = 150;
			gridViewTextBoxColumn1.FieldName = "NoInner";
			gridViewTextBoxColumn1.FormatString = "";
			gridViewTextBoxColumn1.HeaderText = "Inner";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "NoInner";
			gridViewDecimalColumn1.FieldName = "idVisitante";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idVisitante";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idVisitante";
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "idEmpleado";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "idEmpleado";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "idEmpleado";
			gridViewDecimalColumn3.FieldName = "idVisitanteVistaP";
			gridViewDecimalColumn3.FormatString = "";
			gridViewDecimalColumn3.HeaderText = "idVisitanteVistaP";
			gridViewDecimalColumn3.IsAutoGenerated = true;
			gridViewDecimalColumn3.IsVisible = false;
			gridViewDecimalColumn3.Name = "idVisitanteVistaP";
			gridViewComboBoxColumn.DataSource = this.tVisitanteBindingSource;
			gridViewComboBoxColumn.DataType = typeof(decimal);
			gridViewComboBoxColumn.DisplayMember = "nombreVisitante";
			gridViewComboBoxColumn.FieldName = "idVisitante";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Visitante";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idVisitante";
			gridViewComboBoxColumn.Width = 330;
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDateTimeColumn, gridViewTextBoxColumn1, gridViewDecimalColumn1, gridViewDecimalColumn2, gridViewDecimalColumn3, gridViewComboBoxColumn };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tMarcacionBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ReadOnly = true;
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(891, 237);
			this.radGridView1.TabIndex = 5;
			this.radGridView1.Text = "radGridView1";
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(891, 339);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tMarcacionBindingNavigator);
			base.Controls.Add(this.panel1);
			base.Name = "frmMarcacionesVisitantes";
			this.Text = "frmMarcacionesVisitantes";
			base.Load += new EventHandler(this.frmMarcacionesVisitantes_Load);
			((ISupportInitialize)this.tVisitanteBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.tMarcacionBindingSource).EndInit();
			((ISupportInitialize)this.tMarcacionBindingNavigator).EndInit();
			this.tMarcacionBindingNavigator.ResumeLayout(false);
			this.tMarcacionBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void tMarcacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tMarcacionBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}