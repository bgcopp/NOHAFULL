using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmReporteMarcacionesVehiculo : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Button button2;

		private Button button1;

		private Label label5;

		private ComboBox cmbVehiculo;

		private Label label3;

		private DateTimePicker dtFin;

		private Label label2;

		private DateTimePicker dtInicio;

		private Panel panel2;

		private Label label1;

		private RadGridView radGridView1;

		private RadDesktopAlert radDesktopAlert1;

		private Office2007BlackTheme office2007BlackTheme1;

		private TelerikMetroBlueTheme telerikMetroBlueTheme1;

		private StatusStrip statusStrip1;

		private ToolStripStatusLabel toolStripStatusLabel1;

		private ToolStripStatusLabel lblRegistros;

		private BreezeTheme breezeTheme1;

		public List<TVehiculo> listaVehiculos;

		public frmReporteMarcacionesVehiculo()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Reportes reporte = new Reportes();
			TVehiculo selectedItem = this.cmbVehiculo.SelectedItem as TVehiculo;
			RadGridView radGridView = this.radGridView1;
			DateTime date = this.dtInicio.Value.Date;
			DateTime dateTime = this.dtFin.Value.Date;
			var resultado = reporte.consultarReporteVehiculos(date, dateTime.AddDays(1), selectedItem.idVehiculo);
			radGridView.DataSource = resultado;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ExportToExcelML exportToExcelML = new ExportToExcelML(this.radGridView1)
			{
				HiddenColumnOption = HiddenOption.DoNotExport,
				ExportVisualSettings = true,
				SheetMaxRows = ExcelMaxRows._1048576,
				SheetName = "Listado",
				SummariesExportOption = SummariesOption.DoNotExport
			};
			string str = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\\ExportedDataMarcacionVehiculos.xls");
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

		private void frmReporteMarcacionesVehiculo_Load(object sender, EventArgs e)
		{
			this.dtInicio.Value = DateTime.Now;
			this.dtFin.Value = DateTime.Now;
			this.listaVehiculos = (new Vehiculos()).ListarTodos();
			List<TVehiculo> tVehiculos = this.listaVehiculos;
			TVehiculo tVehiculo = new TVehiculo()
			{
				Placa = "Todos Los Vehiculos",
				idVehiculo = -999
			};
			tVehiculos.Insert(0, tVehiculo);
			this.cmbVehiculo.DataSource = this.listaVehiculos;
			this.cmbVehiculo.DisplayMember = "Placa";
			this.cmbVehiculo.ValueMember = "idVehiculo";
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new Panel();
			this.button2 = new Button();
			this.button1 = new Button();
			this.label5 = new Label();
			this.cmbVehiculo = new ComboBox();
			this.label3 = new Label();
			this.dtFin = new DateTimePicker();
			this.label2 = new Label();
			this.dtInicio = new DateTimePicker();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.radGridView1 = new RadGridView();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.office2007BlackTheme1 = new Office2007BlackTheme();
			this.telerikMetroBlueTheme1 = new TelerikMetroBlueTheme();
			this.statusStrip1 = new StatusStrip();
			this.toolStripStatusLabel1 = new ToolStripStatusLabel();
			this.lblRegistros = new ToolStripStatusLabel();
			this.breezeTheme1 = new BreezeTheme();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.radGridView1).BeginInit();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.White;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.cmbVehiculo);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.dtFin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtInicio);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = DockStyle.Top;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1004, 106);
			this.panel1.TabIndex = 4;
			this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button2.BackgroundImage = Resources.File_Excel_icon;
			this.button2.BackgroundImageLayout = ImageLayout.Stretch;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Location = new Point(949, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(46, 46);
			this.button2.TabIndex = 10;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Location = new Point(864, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 56);
			this.button1.TabIndex = 9;
			this.button1.Text = "Buscar...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new Point(383, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Vehículo";
			this.cmbVehiculo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.cmbVehiculo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cmbVehiculo.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cmbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cmbVehiculo.FormattingEnabled = true;
			this.cmbVehiculo.Location = new Point(434, 66);
			this.cmbVehiculo.Name = "cmbVehiculo";
			this.cmbVehiculo.Size = new System.Drawing.Size(178, 24);
			this.cmbVehiculo.TabIndex = 7;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(26, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fecha Fin";
			this.dtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dtFin.Location = new Point(85, 64);
			this.dtFin.Name = "dtFin";
			this.dtFin.Size = new System.Drawing.Size(284, 22);
			this.dtFin.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(17, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fecha Inicio";
			this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dtInicio.Location = new Point(85, 36);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(284, 22);
			this.dtInicio.TabIndex = 1;
			this.panel2.BackColor = Color.CornflowerBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1004, 30);
			this.panel2.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(13, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reporte de Marcaciones de Vehículos";
			this.radGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radGridView1.Location = new Point(12, 112);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			this.radGridView1.MasterTemplate.AllowDeleteRow = false;
			this.radGridView1.MasterTemplate.AllowEditRow = false;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radGridView1.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new System.Drawing.Size(983, 372);
			this.radGridView1.TabIndex = 7;
			this.radGridView1.Text = "radGridView1";
			this.radGridView1.ThemeName = "Office2007Black";
			this.radGridView1.DataBindingComplete += new GridViewBindingCompleteEventHandler(this.radGridView1_DataBindingComplete);
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			ToolStripItemCollection items = this.statusStrip1.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.toolStripStatusLabel1, this.lblRegistros };
			items.AddRange(toolStripItemArray);
			this.statusStrip1.Location = new Point(0, 487);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(205, 17);
			this.toolStripStatusLabel1.Text = "Registro encontrados en la busqueda:";
			this.lblRegistros.BackColor = Color.DarkOrange;
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(64, 17);
			this.lblRegistros.Text = "0 Registros";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1004, 509);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.panel1);
			base.Name = "frmReporteMarcacionesVehiculo";
			this.Text = "Marcaciones Vehículo";
			base.Load += new EventHandler(this.frmReporteMarcacionesVehiculo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.radGridView1).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radGridView1_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
		{
			foreach (GridViewDataColumn column in this.radGridView1.Columns)
			{
				column.BestFit();
			}
			ToolStripStatusLabel toolStripStatusLabel = this.lblRegistros;
			int count = this.radGridView1.Rows.Count;
			toolStripStatusLabel.Text = string.Concat(count.ToString(CultureInfo.InvariantCulture), " Registros");
		}
	}
}