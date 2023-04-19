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

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmTarjetas : Form
	{
		private IContainer components = null;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tTarjetaBindingSource;

		private TTarjetaTableAdapter tTarjetaTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tTarjetaBindingNavigator;

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

		private ToolStripButton tTarjetaBindingNavigatorSaveItem;

		private RadGridView radGridView1;

		private THorarioTableAdapter tHorarioTableAdapter;

		private BindingSource tHorarioBindingSource;

		private Panel panel2;

		private Label label1;

		private Office2010BlackTheme office2010BlackTheme1;

		public frmTarjetas()
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

		private void frmTarjetas_Load(object sender, EventArgs e)
		{
			this.tHorarioTableAdapter.Fill(this.masterDBACDataSet.THorario);
			this.tTarjetaTableAdapter.Fill(this.masterDBACDataSet.TTarjeta);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmTarjetas));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
			GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new GridViewCheckBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn1 = new GridViewDateTimeColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn2 = new GridViewDateTimeColumn();
			this.tHorarioBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tTarjetaBindingSource = new BindingSource(this.components);
			this.tTarjetaTableAdapter = new TTarjetaTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tHorarioTableAdapter = new THorarioTableAdapter();
			this.tTarjetaBindingNavigator = new BindingNavigator(this.components);
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
			this.tTarjetaBindingNavigatorSaveItem = new ToolStripButton();
			this.radGridView1 = new RadGridView();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			((ISupportInitialize)this.tHorarioBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tTarjetaBindingSource).BeginInit();
			((ISupportInitialize)this.tTarjetaBindingNavigator).BeginInit();
			this.tTarjetaBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.tHorarioBindingSource.DataMember = "THorario";
			this.tHorarioBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tTarjetaBindingSource.DataMember = "TTarjeta";
			this.tTarjetaBindingSource.DataSource = this.masterDBACDataSet;
			this.tTarjetaTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.THorarioTableAdapter = this.tHorarioTableAdapter;
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
			this.tHorarioTableAdapter.ClearBeforeFill = true;
			this.tTarjetaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tTarjetaBindingNavigator.BindingSource = this.tTarjetaBindingSource;
			this.tTarjetaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tTarjetaBindingNavigator.CountItemFormat = "de {0}";
			this.tTarjetaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tTarjetaBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tTarjetaBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tTarjetaBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tTarjetaBindingNavigator.Location = new Point(0, 366);
			this.tTarjetaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tTarjetaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tTarjetaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tTarjetaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tTarjetaBindingNavigator.Name = "tTarjetaBindingNavigator";
			this.tTarjetaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tTarjetaBindingNavigator.Size = new System.Drawing.Size(684, 25);
			this.tTarjetaBindingNavigator.TabIndex = 3;
			this.tTarjetaBindingNavigator.Text = "bindingNavigator1";
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
			this.tTarjetaBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tTarjetaBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tTarjetaBindingNavigatorSaveItem.Image");
			this.tTarjetaBindingNavigatorSaveItem.Name = "tTarjetaBindingNavigatorSaveItem";
			this.tTarjetaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tTarjetaBindingNavigatorSaveItem.Text = "Save Data";
			this.tTarjetaBindingNavigatorSaveItem.Click += new EventHandler(this.tTarjetaBindingNavigatorSaveItem_Click);
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 60);
			this.radGridView1.MasterTemplate.AllowDragToGroup = false;
			this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
			gridViewDecimalColumn.DataType = typeof(int);
			gridViewDecimalColumn.FieldName = "idTarjeta";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idTarjeta";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idTarjeta";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewTextBoxColumn.FieldName = "numtarjeta";
			gridViewTextBoxColumn.FormatString = "";
			gridViewTextBoxColumn.HeaderText = "numtarjeta";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "numtarjeta";
			gridViewTextBoxColumn.Width = 289;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "idHorario";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idHorario";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idHorario";
			gridViewComboBoxColumn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			gridViewComboBoxColumn.DataSource = this.tHorarioBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "NombreHorario";
			gridViewComboBoxColumn.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn.FieldName = "idHorario";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Horario";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idHorario";
			gridViewComboBoxColumn.Width = 216;
			gridViewDateTimeColumn.FieldName = "fechaUltimaGestion";
			gridViewDateTimeColumn.FormatString = "";
			gridViewDateTimeColumn.HeaderText = "fechaUltimaGestion";
			gridViewDateTimeColumn.IsAutoGenerated = true;
			gridViewDateTimeColumn.IsVisible = false;
			gridViewDateTimeColumn.Name = "fechaUltimaGestion";
			gridViewDateTimeColumn.Width = 130;
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "usuarioUltimaGestion";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "usuarioUltimaGestion";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "usuarioUltimaGestion";
			gridViewCheckBoxColumn.FieldName = "activa";
			gridViewCheckBoxColumn.FormatString = "";
			gridViewCheckBoxColumn.HeaderText = "Activa";
			gridViewCheckBoxColumn.IsAutoGenerated = true;
			gridViewCheckBoxColumn.Name = "activa";
			gridViewCheckBoxColumn.Width = 90;
			gridViewCheckBoxColumn1.FieldName = "esvisitante";
			gridViewCheckBoxColumn1.FormatString = "";
			gridViewCheckBoxColumn1.HeaderText = "esvisitante";
			gridViewCheckBoxColumn1.IsAutoGenerated = true;
			gridViewCheckBoxColumn1.IsVisible = false;
			gridViewCheckBoxColumn1.Name = "esvisitante";
			gridViewCheckBoxColumn2.FieldName = "esutilizada";
			gridViewCheckBoxColumn2.FormatString = "";
			gridViewCheckBoxColumn2.HeaderText = "Esta Utilizada";
			gridViewCheckBoxColumn2.IsAutoGenerated = true;
			gridViewCheckBoxColumn2.Name = "esutilizada";
			gridViewCheckBoxColumn2.Width = 47;
			gridViewDateTimeColumn1.FieldName = "fechavisi1";
			gridViewDateTimeColumn1.FormatString = "";
			gridViewDateTimeColumn1.HeaderText = "fechavisi1";
			gridViewDateTimeColumn1.IsAutoGenerated = true;
			gridViewDateTimeColumn1.IsVisible = false;
			gridViewDateTimeColumn1.Name = "fechavisi1";
			gridViewDateTimeColumn2.FieldName = "fechavisi2";
			gridViewDateTimeColumn2.FormatString = "";
			gridViewDateTimeColumn2.HeaderText = "fechavisi2";
			gridViewDateTimeColumn2.IsAutoGenerated = true;
			gridViewDateTimeColumn2.IsVisible = false;
			gridViewDateTimeColumn2.Name = "fechavisi2";
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDecimalColumn1, gridViewComboBoxColumn, gridViewDateTimeColumn, gridViewDecimalColumn2, gridViewCheckBoxColumn, gridViewCheckBoxColumn1, gridViewCheckBoxColumn2, gridViewDateTimeColumn1, gridViewDateTimeColumn2 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tTarjetaBindingSource;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(660, 303);
			this.radGridView1.TabIndex = 4;
			this.radGridView1.Text = "radGridView1";
			this.radGridView1.ThemeName = "ControlDefault";
			this.radGridView1.CellBeginEdit += new GridViewCellCancelEventHandler(this.radGridView1_CellBeginEdit);
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(684, 53);
			this.panel2.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tarjetas";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(684, 391);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tTarjetaBindingNavigator);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTarjetas";
			this.Text = "Maestro de Tarjetas";
			base.Load += new EventHandler(this.frmTarjetas_Load);
			((ISupportInitialize)this.tHorarioBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tTarjetaBindingSource).EndInit();
			((ISupportInitialize)this.tTarjetaBindingNavigator).EndInit();
			this.tTarjetaBindingNavigator.ResumeLayout(false);
			this.tTarjetaBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radGridView1_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
		{
			e.Row.Cells[6].Value = true;
			e.Row.Cells[7].Value = false;
			e.Row.Cells[8].Value = false;
		}

		private void tTarjetaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Desea realizar las operaciones pendientes?", Settings.Default.Titulo, MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
			{
				try
				{
					base.Validate();
					this.tTarjetaBindingSource.EndEdit();
					this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
					MessageBox.Show("El registro se proceso con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("error: ", exception.ToString()), Settings.Default.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
	}
}