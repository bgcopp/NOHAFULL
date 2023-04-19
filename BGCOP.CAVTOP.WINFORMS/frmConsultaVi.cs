using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmConsultaVi : Form
	{
		private IContainer components = null;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tVisitanteBindingSource;

		private TVisitanteTableAdapter tVisitanteTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private BindingNavigator tVisitanteBindingNavigator;

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

		private ToolStripButton tVisitanteBindingNavigatorSaveItem;

		private RadGridView radGridView1;

		private TVisitanteVisitaProgramadaTableAdapter tVisitanteVisitaProgramadaTableAdapter;

		private BindingSource fKTVisitanteVisitaProgramadaTVisitanteBindingSource;

		private TVisitanteVisitaProgramadaLogTableAdapter tVisitanteVisitaProgramadaLogTableAdapter;

		private BindingSource fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource;

		public frmConsultaVi()
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

		private void frmConsultaVi_Load(object sender, EventArgs e)
		{
			this.tVisitanteVisitaProgramadaLogTableAdapter.Fill(this.masterDBACDataSet.TVisitanteVisitaProgramadaLog);
			this.tVisitanteVisitaProgramadaTableAdapter.Fill(this.masterDBACDataSet.TVisitanteVisitaProgramada);
			this.tVisitanteTableAdapter.Fill(this.masterDBACDataSet.TVisitante);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmConsultaVi));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn2 = new GridViewComboBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
			GridViewImageColumn gridViewImageColumn = new GridViewImageColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn5 = new GridViewTextBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn6 = new GridViewTextBoxColumn();
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tVisitanteBindingSource = new BindingSource(this.components);
			this.tVisitanteTableAdapter = new TVisitanteTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tVisitanteBindingNavigator = new BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new ToolStripButton();
			this.bindingNavigatorSeparator = new ToolStripSeparator();
			this.bindingNavigatorPositionItem = new ToolStripTextBox();
			this.bindingNavigatorCountItem = new ToolStripLabel();
			this.bindingNavigatorSeparator1 = new ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new ToolStripButton();
			this.bindingNavigatorMoveLastItem = new ToolStripButton();
			this.bindingNavigatorSeparator2 = new ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new ToolStripButton();
			this.bindingNavigatorDeleteItem = new ToolStripButton();
			this.tVisitanteBindingNavigatorSaveItem = new ToolStripButton();
			this.radGridView1 = new RadGridView();
			this.fKTVisitanteVisitaProgramadaTVisitanteBindingSource = new BindingSource(this.components);
			this.tVisitanteVisitaProgramadaTableAdapter = new TVisitanteVisitaProgramadaTableAdapter();
			this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource = new BindingSource(this.components);
			this.tVisitanteVisitaProgramadaLogTableAdapter = new TVisitanteVisitaProgramadaLogTableAdapter();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tVisitanteBindingSource).BeginInit();
			((ISupportInitialize)this.tVisitanteBindingNavigator).BeginInit();
			this.tVisitanteBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			((ISupportInitialize)this.fKTVisitanteVisitaProgramadaTVisitanteBindingSource).BeginInit();
			((ISupportInitialize)this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource).BeginInit();
			base.SuspendLayout();
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tVisitanteBindingSource.DataMember = "TVisitante";
			this.tVisitanteBindingSource.DataSource = this.masterDBACDataSet;
			this.tVisitanteTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.TvehiculoParqueoTableAdapter = null;
			this.tableAdapterManager.TVehiculoTableAdapter = null;
			this.tableAdapterManager.TVisitanteTableAdapter = this.tVisitanteTableAdapter;
			this.tableAdapterManager.TVisitanteVisitaProgramadaLogTableAdapter = this.tVisitanteVisitaProgramadaLogTableAdapter;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = this.tVisitanteVisitaProgramadaTableAdapter;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tVisitanteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tVisitanteBindingNavigator.BindingSource = this.tVisitanteBindingSource;
			this.tVisitanteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tVisitanteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tVisitanteBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tVisitanteBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tVisitanteBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tVisitanteBindingNavigator.Location = new Point(0, 460);
			this.tVisitanteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tVisitanteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tVisitanteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tVisitanteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tVisitanteBindingNavigator.Name = "tVisitanteBindingNavigator";
			this.tVisitanteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tVisitanteBindingNavigator.Size = new System.Drawing.Size(934, 25);
			this.tVisitanteBindingNavigator.TabIndex = 0;
			this.tVisitanteBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorAddNewItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorDeleteItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = (Image)componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.tVisitanteBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tVisitanteBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tVisitanteBindingNavigatorSaveItem.Image");
			this.tVisitanteBindingNavigatorSaveItem.Name = "tVisitanteBindingNavigatorSaveItem";
			this.tVisitanteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tVisitanteBindingNavigatorSaveItem.Text = "Save Data";
			this.tVisitanteBindingNavigatorSaveItem.Click += new EventHandler(this.tVisitanteBindingNavigatorSaveItem_Click);
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 52);
			gridViewDecimalColumn.FieldName = "idVisitante";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idVisitante";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idVisitante";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewDecimalColumn.Width = 61;
			gridViewTextBoxColumn.FieldName = "nombreVisitante";
			gridViewTextBoxColumn.HeaderText = "Nombre Visitante";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "nombreVisitante";
			gridViewTextBoxColumn.Width = 91;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "idTipoIdentificacion";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idTipoIdentificacion";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idTipoIdentificacion";
			gridViewDecimalColumn1.Width = 106;
			gridViewTextBoxColumn1.FieldName = "identificacionVisitante";
			gridViewTextBoxColumn1.HeaderText = "identificacionVisitante";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "identificacionVisitante";
			gridViewTextBoxColumn1.Width = 118;
			gridViewComboBoxColumn.DataSource = this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource;
			gridViewComboBoxColumn.DisplayMember = "fechaRegistro";
			gridViewComboBoxColumn.FieldName = "fechaRegistro";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Ultimo registro";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "fechaRegistro";
			gridViewComboBoxColumn.Width = 150;
			gridViewComboBoxColumn1.DataSource = this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource;
			gridViewComboBoxColumn1.DisplayMember = "fechaSalida";
			gridViewComboBoxColumn1.FieldName = "fechaRegistro";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "Fecha de Salida";
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "fechaRegistro";
			gridViewComboBoxColumn2.DataSource = this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource;
			gridViewComboBoxColumn2.DisplayMember = "ObservacionesVisita";
			gridViewComboBoxColumn2.FormatString = "";
			gridViewComboBoxColumn2.HeaderText = "Observaciones";
			gridViewComboBoxColumn2.Name = "column3";
			gridViewComboBoxColumn2.ValueMember = null;
			gridViewComboBoxColumn2.Width = 250;
			gridViewTextBoxColumn2.FieldName = "huella";
			gridViewTextBoxColumn2.FormatString = "";
			gridViewTextBoxColumn2.HeaderText = "huella";
			gridViewTextBoxColumn2.IsAutoGenerated = true;
			gridViewTextBoxColumn2.IsVisible = false;
			gridViewTextBoxColumn2.Name = "huella";
			gridViewTextBoxColumn2.Width = 38;
			gridViewImageColumn.DataType = typeof(byte[]);
			gridViewImageColumn.FieldName = "foto";
			gridViewImageColumn.HeaderText = "foto";
			gridViewImageColumn.IsAutoGenerated = true;
			gridViewImageColumn.Name = "foto";
			gridViewImageColumn.RowSpan = 140;
			gridViewImageColumn.StretchVertically = false;
			gridViewImageColumn.Width = 140;
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "idEmpresaVisitante";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "idEmpresaVisitante";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "idEmpresaVisitante";
			gridViewDecimalColumn2.Width = 103;
			gridViewTextBoxColumn3.FieldName = "observacionesVisitante";
			gridViewTextBoxColumn3.FormatString = "";
			gridViewTextBoxColumn3.HeaderText = "observacionesVisitante";
			gridViewTextBoxColumn3.IsAutoGenerated = true;
			gridViewTextBoxColumn3.IsVisible = false;
			gridViewTextBoxColumn3.Name = "observacionesVisitante";
			gridViewTextBoxColumn3.Width = 122;
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
			gridViewTextBoxColumn4.FieldName = "empresa";
			gridViewTextBoxColumn4.HeaderText = "empresa";
			gridViewTextBoxColumn4.IsAutoGenerated = true;
			gridViewTextBoxColumn4.Name = "empresa";
			gridViewTextBoxColumn4.Width = 51;
			gridViewTextBoxColumn5.FieldName = "direccion";
			gridViewTextBoxColumn5.FormatString = "";
			gridViewTextBoxColumn5.HeaderText = "direccion";
			gridViewTextBoxColumn5.IsAutoGenerated = true;
			gridViewTextBoxColumn5.Name = "direccion";
			gridViewTextBoxColumn5.Width = 54;
			gridViewTextBoxColumn6.FieldName = "telefonos";
			gridViewTextBoxColumn6.FormatString = "";
			gridViewTextBoxColumn6.HeaderText = "telefonos";
			gridViewTextBoxColumn6.IsAutoGenerated = true;
			gridViewTextBoxColumn6.Name = "telefonos";
			gridViewTextBoxColumn6.Width = 55;
			GridViewColumnCollection columns = this.radGridView1.MasterTemplate.Columns;
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDecimalColumn1, gridViewTextBoxColumn1, gridViewComboBoxColumn, gridViewComboBoxColumn1, gridViewComboBoxColumn2, gridViewTextBoxColumn2, gridViewImageColumn, gridViewDecimalColumn2, gridViewTextBoxColumn3, gridViewDateTimeColumn, gridViewDecimalColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tVisitanteBindingSource;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Size = new System.Drawing.Size(910, 405);
			this.radGridView1.TabIndex = 1;
			this.radGridView1.Text = "radGridView1";
			this.fKTVisitanteVisitaProgramadaTVisitanteBindingSource.DataMember = "FK_TVisitanteVisitaProgramada_TVisitante";
			this.fKTVisitanteVisitaProgramadaTVisitanteBindingSource.DataSource = this.tVisitanteBindingSource;
			this.tVisitanteVisitaProgramadaTableAdapter.ClearBeforeFill = true;
			this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource.DataMember = "FK_TVisitanteVisitaProgramadaLog_TVisitante";
			this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource.DataSource = this.tVisitanteBindingSource;
			this.tVisitanteVisitaProgramadaLogTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(934, 485);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tVisitanteBindingNavigator);
			base.Name = "frmConsultaVi";
			this.Text = "frmConsultaVi";
			base.Load += new EventHandler(this.frmConsultaVi_Load);
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tVisitanteBindingSource).EndInit();
			((ISupportInitialize)this.tVisitanteBindingNavigator).EndInit();
			this.tVisitanteBindingNavigator.ResumeLayout(false);
			this.tVisitanteBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			((ISupportInitialize)this.fKTVisitanteVisitaProgramadaTVisitanteBindingSource).EndInit();
			((ISupportInitialize)this.fKTVisitanteVisitaProgramadaLogTVisitanteBindingSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void tVisitanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			base.Validate();
			this.tVisitanteBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.masterDBACDataSet);
		}
	}
}