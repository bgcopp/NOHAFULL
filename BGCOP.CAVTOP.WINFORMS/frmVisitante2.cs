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
	public class frmVisitante2 : Form
	{
		private IContainer components = null;

		private Panel panel2;

		private Label label1;

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

		private BindingSource tTipoIdentificacionBindingSource;

		private TTipoIdentificacionTableAdapter tTipoIdentificacionTableAdapter;

		public frmVisitante2()
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

		private void frmVisitante2_Load(object sender, EventArgs e)
		{
			this.tTipoIdentificacionTableAdapter.Fill(this.masterDBACDataSet.TTipoIdentificacion);
			this.tVisitanteTableAdapter.Fill(this.masterDBACDataSet.TVisitante);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmVisitante2));
			GridViewDecimalColumn gridViewDecimalColumn = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn1 = new GridViewDecimalColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn = new GridViewComboBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
			GridViewImageColumn gridViewImageColumn = new GridViewImageColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
			GridViewComboBoxColumn gridViewComboBoxColumn1 = new GridViewComboBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
			GridViewDecimalColumn gridViewDecimalColumn2 = new GridViewDecimalColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn5 = new GridViewTextBoxColumn();
			GridViewTextBoxColumn gridViewTextBoxColumn6 = new GridViewTextBoxColumn();
			GridViewDateTimeColumn gridViewDateTimeColumn = new GridViewDateTimeColumn();
			GridViewDecimalColumn gridViewDecimalColumn3 = new GridViewDecimalColumn();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.tVisitanteBindingSource = new BindingSource(this.components);
			this.tVisitanteTableAdapter = new TVisitanteTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tVisitanteBindingNavigator = new BindingNavigator(this.components);
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
			this.tVisitanteBindingNavigatorSaveItem = new ToolStripButton();
			this.radGridView1 = new RadGridView();
			this.tTipoIdentificacionBindingSource = new BindingSource(this.components);
			this.tTipoIdentificacionTableAdapter = new TTipoIdentificacionTableAdapter();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.tVisitanteBindingSource).BeginInit();
			((ISupportInitialize)this.tVisitanteBindingNavigator).BeginInit();
			this.tVisitanteBindingNavigator.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			((ISupportInitialize)this.tTipoIdentificacionBindingSource).BeginInit();
			base.SuspendLayout();
			this.panel2.BackColor = Color.SteelBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(713, 53);
			this.panel2.TabIndex = 5;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(37, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Visitante";
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
			this.tableAdapterManager.TVisitanteTableAdapter = this.tVisitanteTableAdapter;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tVisitanteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tVisitanteBindingNavigator.BindingSource = this.tVisitanteBindingSource;
			this.tVisitanteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tVisitanteBindingNavigator.CountItemFormat = "de {0}";
			this.tVisitanteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tVisitanteBindingNavigator.Dock = DockStyle.Bottom;
			ToolStripItemCollection items = this.tVisitanteBindingNavigator.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem, this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem, this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1, this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem, this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem, this.bindingNavigatorDeleteItem, this.tVisitanteBindingNavigatorSaveItem };
			items.AddRange(toolStripItemArray);
			this.tVisitanteBindingNavigator.Location = new Point(0, 501);
			this.tVisitanteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tVisitanteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tVisitanteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tVisitanteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tVisitanteBindingNavigator.Name = "tVisitanteBindingNavigator";
			this.tVisitanteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tVisitanteBindingNavigator.Size = new System.Drawing.Size(713, 25);
			this.tVisitanteBindingNavigator.TabIndex = 6;
			this.tVisitanteBindingNavigator.Text = "bindingNavigator1";
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
			this.tVisitanteBindingNavigatorSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tVisitanteBindingNavigatorSaveItem.Image = (Image)componentResourceManager.GetObject("tVisitanteBindingNavigatorSaveItem.Image");
			this.tVisitanteBindingNavigatorSaveItem.Name = "tVisitanteBindingNavigatorSaveItem";
			this.tVisitanteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.tVisitanteBindingNavigatorSaveItem.Text = "Save Data";
			this.tVisitanteBindingNavigatorSaveItem.Click += new EventHandler(this.tVisitanteBindingNavigatorSaveItem_Click);
			this.radGridView1.Location = new Point(13, 61);
			gridViewDecimalColumn.FieldName = "idVisitante";
			gridViewDecimalColumn.FormatString = "";
			gridViewDecimalColumn.HeaderText = "idVisitante";
			gridViewDecimalColumn.IsAutoGenerated = true;
			gridViewDecimalColumn.IsVisible = false;
			gridViewDecimalColumn.Name = "idVisitante";
			gridViewDecimalColumn.ReadOnly = true;
			gridViewTextBoxColumn.FieldName = "nombreVisitante";
			gridViewTextBoxColumn.HeaderText = "nombreVisitante";
			gridViewTextBoxColumn.IsAutoGenerated = true;
			gridViewTextBoxColumn.Name = "nombreVisitante";
			gridViewTextBoxColumn.Width = 150;
			gridViewDecimalColumn1.DataType = typeof(int);
			gridViewDecimalColumn1.FieldName = "idTipoIdentificacion";
			gridViewDecimalColumn1.FormatString = "";
			gridViewDecimalColumn1.HeaderText = "idTipoIdentificacion";
			gridViewDecimalColumn1.IsAutoGenerated = true;
			gridViewDecimalColumn1.IsVisible = false;
			gridViewDecimalColumn1.Name = "idTipoIdentificacion";
			gridViewComboBoxColumn.DataSource = this.tTipoIdentificacionBindingSource;
			gridViewComboBoxColumn.DataType = typeof(int);
			gridViewComboBoxColumn.DisplayMember = "descripcionIdentificacion";
			gridViewComboBoxColumn.FieldName = "idTipoIdentificacion";
			gridViewComboBoxColumn.FormatString = "";
			gridViewComboBoxColumn.HeaderText = "Tipo Doc";
			gridViewComboBoxColumn.Name = "column1";
			gridViewComboBoxColumn.ValueMember = "idTipoIdentificacion";
			gridViewComboBoxColumn.Width = 100;
			gridViewTextBoxColumn1.FieldName = "identificacionVisitante";
			gridViewTextBoxColumn1.HeaderText = "identificacionVisitante";
			gridViewTextBoxColumn1.IsAutoGenerated = true;
			gridViewTextBoxColumn1.Name = "identificacionVisitante";
			gridViewTextBoxColumn1.Width = 120;
			gridViewTextBoxColumn2.FieldName = "huella";
			gridViewTextBoxColumn2.FormatString = "";
			gridViewTextBoxColumn2.HeaderText = "huella";
			gridViewTextBoxColumn2.IsAutoGenerated = true;
			gridViewTextBoxColumn2.IsVisible = false;
			gridViewTextBoxColumn2.Name = "huella";
			gridViewImageColumn.DataType = typeof(byte[]);
			gridViewImageColumn.FieldName = "foto";
			gridViewImageColumn.HeaderText = "foto";
			gridViewImageColumn.IsAutoGenerated = true;
			gridViewImageColumn.Name = "foto";
			gridViewTextBoxColumn3.FieldName = "empresa";
			gridViewTextBoxColumn3.FormatString = "";
			gridViewTextBoxColumn3.HeaderText = "empresa";
			gridViewTextBoxColumn3.IsAutoGenerated = true;
			gridViewTextBoxColumn3.Name = "empresa";
			gridViewComboBoxColumn1.DataSource = this.tVisitanteBindingSource;
			gridViewComboBoxColumn1.DisplayMember = "empresa";
			gridViewComboBoxColumn1.DropDownStyle = RadDropDownStyle.DropDown;
			gridViewComboBoxColumn1.FieldName = "empresa";
			gridViewComboBoxColumn1.FormatString = "";
			gridViewComboBoxColumn1.HeaderText = "empresa";
			gridViewComboBoxColumn1.IsVisible = false;
			gridViewComboBoxColumn1.Name = "column2";
			gridViewComboBoxColumn1.ValueMember = "empresa";
			gridViewComboBoxColumn1.Width = 150;
			gridViewTextBoxColumn4.FieldName = "direccion";
			gridViewTextBoxColumn4.HeaderText = "direccion";
			gridViewTextBoxColumn4.IsAutoGenerated = true;
			gridViewTextBoxColumn4.Name = "direccion";
			gridViewTextBoxColumn4.Width = 150;
			gridViewDecimalColumn2.DataType = typeof(int);
			gridViewDecimalColumn2.FieldName = "idEmpresaVisitante";
			gridViewDecimalColumn2.FormatString = "";
			gridViewDecimalColumn2.HeaderText = "idEmpresaVisitante";
			gridViewDecimalColumn2.IsAutoGenerated = true;
			gridViewDecimalColumn2.IsVisible = false;
			gridViewDecimalColumn2.Name = "idEmpresaVisitante";
			gridViewTextBoxColumn5.FieldName = "telefonos";
			gridViewTextBoxColumn5.FormatString = "";
			gridViewTextBoxColumn5.HeaderText = "telefonos";
			gridViewTextBoxColumn5.IsAutoGenerated = true;
			gridViewTextBoxColumn5.Name = "telefonos";
			gridViewTextBoxColumn5.Width = 150;
			gridViewTextBoxColumn6.FieldName = "observacionesVisitante";
			gridViewTextBoxColumn6.FormatString = "";
			gridViewTextBoxColumn6.HeaderText = "observacionesVisitante";
			gridViewTextBoxColumn6.IsAutoGenerated = true;
			gridViewTextBoxColumn6.Name = "observacionesVisitante";
			gridViewTextBoxColumn6.Width = 250;
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
			GridViewDataColumn[] gridViewDataColumnArray = new GridViewDataColumn[] { gridViewDecimalColumn, gridViewTextBoxColumn, gridViewDecimalColumn1, gridViewComboBoxColumn, gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewImageColumn, gridViewTextBoxColumn3, gridViewComboBoxColumn1, gridViewTextBoxColumn4, gridViewDecimalColumn2, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewDateTimeColumn, gridViewDecimalColumn3 };
			columns.AddRange(gridViewDataColumnArray);
			this.radGridView1.MasterTemplate.DataSource = this.tVisitanteBindingSource;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Size = new System.Drawing.Size(688, 437);
			this.radGridView1.TabIndex = 7;
			this.radGridView1.Text = "radGridView1";
			this.tTipoIdentificacionBindingSource.DataMember = "TTipoIdentificacion";
			this.tTipoIdentificacionBindingSource.DataSource = this.masterDBACDataSet;
			this.tTipoIdentificacionTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(713, 526);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.tVisitanteBindingNavigator);
			base.Controls.Add(this.panel2);
			base.Name = "frmVisitante2";
			this.Text = "frmVisitante2";
			base.Load += new EventHandler(this.frmVisitante2_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.tVisitanteBindingSource).EndInit();
			((ISupportInitialize)this.tVisitanteBindingNavigator).EndInit();
			this.tVisitanteBindingNavigator.ResumeLayout(false);
			this.tVisitanteBindingNavigator.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			((ISupportInitialize)this.tTipoIdentificacionBindingSource).EndInit();
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