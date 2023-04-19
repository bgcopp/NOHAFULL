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
using Telerik.WinControls.UI.Localization;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmModeloVehiculo2 : Form
	{
		private IContainer components = null;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tModeloVehiculoBindingSource;

		private TModeloVehiculoTableAdapter tModeloVehiculoTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tModeloVehiculoBindingNavigator;

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

		private ToolStripButton tModeloVehiculoBindingNavigatorSaveItem;

		private RadGridView radGridView1;

		private BindingSource tVehiculoBindingSource;

		private TVehiculoTableAdapter tVehiculoTableAdapter;

		private BindingSource tMarcaVehiculoBindingSource;

		private TMarcaVehiculoTableAdapter tMarcaVehiculoTableAdapter;

		private BindingSource tipoVehiculoBindingSource;

		private TipoVehiculoTableAdapter tipoVehiculoTableAdapter;

		private Office2007BlackTheme office2007BlackTheme1;

		private Panel panel2;

		private Label label1;

		private Office2010BlackTheme office2010BlackTheme1;

		public frmModeloVehiculo2()
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

		private void frmModeloVehiculo2_Load(object sender, EventArgs e)
		{
			this.tipoVehiculoTableAdapter.Fill(this.masterDBACDataSet.TipoVehiculo);
			this.tMarcaVehiculoTableAdapter.Fill(this.masterDBACDataSet.TMarcaVehiculo);
			this.tVehiculoTableAdapter.Fill(this.masterDBACDataSet.TVehiculo);
			this.tModeloVehiculoTableAdapter.Fill(this.masterDBACDataSet.TModeloVehiculo);
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new MyEnglishRadGridLocalizationProvider();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmModeloVehiculo2));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			this.tMarcaVehiculoBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tipoVehiculoBindingSource = new BindingSource(this.components);
			this.tModeloVehiculoBindingSource = new BindingSource(this.components);
			this.tModeloVehiculoTableAdapter = new TModeloVehiculoTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tModeloVehiculoBindingNavigator = new BindingNavigator(this.components);
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
			this.tModeloVehiculoBindingNavigatorSaveItem = new ToolStripButton();
			this.radGridView1 = new RadGridView();
			this.tVehiculoBindingSource = new BindingSource(this.components);
			this.tVehiculoTableAdapter = new TVehiculoTableAdapter();
			this.tMarcaVehiculoTableAdapter = new TMarcaVehiculoTableAdapter();
			this.tipoVehiculoTableAdapter = new TipoVehiculoTableAdapter();
			this.office2007BlackTheme1 = new Office2007BlackTheme();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			((ISupportInitialize)this.tMarcaVehiculoBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tipoVehiculoBindingSource).BeginInit();
			((ISupportInitialize)this.tModeloVehiculoBindingSource).BeginInit();
			((ISupportInitialize)this.tModeloVehiculoBindingNavigator).BeginInit();
			this.tModeloVehiculoBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			((ISupportInitialize)this.tVehiculoBindingSource).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.tMarcaVehiculoBindingSource.DataMember = "TMarcaVehiculo";
			this.tMarcaVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tipoVehiculoBindingSource.DataMember = "TipoVehiculo";
			this.tipoVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.tModeloVehiculoBindingSource.DataMember = "TModeloVehiculo";
			this.tModeloVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.tModeloVehiculoTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.TipoVehiculoTableAdapter = null;
			this.tableAdapterManager.TMarcaVehiculoTableAdapter = null;
			this.tableAdapterManager.TModeloVehiculoTableAdapter = this.tModeloVehiculoTableAdapter;
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
			this.tModeloVehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tModeloVehiculoBindingNavigator.BindingSource = this.tModeloVehiculoBindingSource;
			this.tModeloVehiculoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tModeloVehiculoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tModeloVehiculoBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tModeloVehiculoBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tModeloVehiculoBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tModeloVehiculoBindingNavigator.Location = new Point(0, 300);
			this.tModeloVehiculoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tModeloVehiculoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tModeloVehiculoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tModeloVehiculoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tModeloVehiculoBindingNavigator.Name = "tModeloVehiculoBindingNavigator";
			this.tModeloVehiculoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tModeloVehiculoBindingNavigator.Size = new System.Drawing.Size(686, 25);
			this.tModeloVehiculoBindingNavigator.TabIndex = 3;
			this.tModeloVehiculoBindingNavigator.Text = "bindingNavigator1";
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
			this.tModeloVehiculoBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tModeloVehiculoBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tModeloVehiculoBindingNavigatorSaveItem.Image");
			this.tModeloVehiculoBindingNavigatorSaveItem.Name = "tModeloVehiculoBindingNavigatorSaveItem";
			this.tModeloVehiculoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tModeloVehiculoBindingNavigatorSaveItem.Text = "Save Data";
			this.tModeloVehiculoBindingNavigatorSaveItem.Click += new EventHandler(this.tModeloVehiculoBindingNavigatorSaveItem_Click);
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 60);
			this.radGridView1.MasterTemplate.AllowDragToGroup = false;
			this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
			gridViewDecimalColumn.DataType = typeof(short);
			gridViewDecimalColumn.FieldName = "idModeloVehiculo";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idModeloVehiculo";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idModeloVehiculo";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewComboBoxColumn.AutoCompleteMode = AutoCompleteMode.Append;
			gridViewComboBoxColumn.DataSource = this.tMarcaVehiculoBindingSource;
			gridViewComboBoxColumn.DataType = typeof(short);
			gridViewComboBoxColumn.DisplayMember = "NombreMarcaVehiculo";
			gridViewComboBoxColumn.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn.FieldName = "idMarcaVehiculo";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Marca";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idMarcaVehiculo";
			gridViewComboBoxColumn.Width = 175;
			gridViewDecimalColumn1.DataType = typeof(short);
			gridViewDecimalColumn1.FieldName = "idMarcaVehiculo";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idMarcaVehiculo";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idMarcaVehiculo";
			gridViewTextBoxColumn.FieldName = "NombreModelo";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "NombreModelo";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "NombreModelo";
			gridViewTextBoxColumn.Width = 292;
			gridViewDecimalColumn2.DataType = typeof(byte);
			gridViewDecimalColumn2.FieldName = "idTipoVehiculo";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "idTipoVehiculo";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "idTipoVehiculo";
			gridViewComboBoxColumn1.DataSource = this.tipoVehiculoBindingSource;
			gridViewComboBoxColumn1.DataType = typeof(byte);
			gridViewComboBoxColumn1.DisplayMember = "NombreTipoVehiculo";
			gridViewComboBoxColumn1.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn1.FieldName = "idTipoVehiculo";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "Tipo";
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "idTipoVehiculo";
			gridViewComboBoxColumn1.Width = 176;
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewDecimalColumn3.DataType = typeof(int);
			gridViewDecimalColumn3.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn3.FormatString = "";
			gridViewDecimalColumn3.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn3.IsAutoGenerated = true;
			gridViewDecimalColumn3.IsVisible = false;
			gridViewDecimalColumn3.Name = "usuarioUltimaGestion";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewComboBoxColumn, gridViewDecimalColumn1, gridViewTextBoxColumn, gridViewDecimalColumn2, gridViewComboBoxColumn1, gridViewDateTimeColumn, gridViewDecimalColumn3 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tModeloVehiculoBindingSource;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radGridView1.Size = new System.Drawing.Size(662, 237);
			this.radGridView1.TabIndex = 4;
			this.radGridView1.Text = "radGridView1";
			this.radGridView1.ThemeName = "Office2010Black";
			this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
			this.tVehiculoBindingSource.DataMember = "TVehiculo";
			this.tVehiculoBindingSource.DataSource = this.masterDBACDataSet;
			this.tVehiculoTableAdapter.ClearBeforeFill = true;
			this.tMarcaVehiculoTableAdapter.ClearBeforeFill = true;
			this.tipoVehiculoTableAdapter.ClearBeforeFill = true;
			this.panel2.BackColor = Color.Black;
			this.panel2.BackgroundImage = Resources.Clean_Gray_BackGround;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(686, 53);
			this.panel2.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.WhiteSmoke;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Modelos";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(686, 325);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tModeloVehiculoBindingNavigator);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmModeloVehiculo2";
			this.Text = "Modelos";
			base.Load += new EventHandler(this.frmModeloVehiculo2_Load);
			((ISupportInitialize)this.tMarcaVehiculoBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tipoVehiculoBindingSource).EndInit();
			((ISupportInitialize)this.tModeloVehiculoBindingSource).EndInit();
			((ISupportInitialize)this.tModeloVehiculoBindingNavigator).EndInit();
			this.tModeloVehiculoBindingNavigator.ResumeLayout(false);
			this.tModeloVehiculoBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			((ISupportInitialize)this.tVehiculoBindingSource).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
		{
			e.Row.Cells["fechaUltimaGestion"].Value = DateTime.Now;
			e.Row.Cells["usuarioUltimaGestion"].Value = Program.idUsuarioActual;
		}

		private void tModeloVehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea realizar las operaciones pendientes?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				base.Validate();
				this.tModeloVehiculoBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
				MessageBox.Show("El registro se proceso con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
			}
		}
	}
}