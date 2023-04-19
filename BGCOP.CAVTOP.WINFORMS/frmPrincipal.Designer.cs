using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;

using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmPrincipal : RadRibbonForm
	{
		private IContainer components = null;

		private RadRibbonBar radRibbonBar1;

		private RadStatusStrip radStatusStrip1;

		private BreezeTheme breezeTheme1;

		private DesertTheme desertTheme1;

		private Office2007SilverTheme office2007SilverTheme1;

		private Office2010SilverTheme office2010SilverTheme1;

		private TelerikMetroTheme telerikMetroTheme1;

		private TelerikMetroBlueTheme telerikMetroBlueTheme1;

		private RibbonTab ribbonTab1;

		private RadRibbonBarGroup radRibbonBarGroup1;

		private RadButtonElement radButtonElement1;

		private RadButtonElement btnMcargos;

		private RadButtonElement btnMestados;

		private RadButtonElement btnMempresas;

		private RadButtonElement btnMdivisiones;

		private RadButtonElement btnMempleado;

		private RibbonTab ribbonTab2;

		private RadRibbonBarGroup radRibbonBarGroup2;

		private RadButtonElement btnMvehiculos;

		private RadRibbonBarButtonGroup radRibbonBarButtonGroup1;

		private RadButtonElement btnMmarcas;

		private RadButtonElement btnMtiposV;

		private RadButtonElement btnMmodelo;

		private RibbonTab ribbonTab3;

		private RadRibbonBarGroup radRibbonBarGroup3;

		private RadButtonElement btnMparqueo;

		private RadRibbonBarGroup radRibbonBarGroup4;

		private RadButtonElement btnMasigParqueo;

		private RadRibbonBarGroup radRibbonBarGroup5;

		private RadButtonElement btnMasignaVe;

		private SplitContainer splitContainer1;

		private RadDock radDock1;

		private DocumentContainer documentContainer1;

		private Label label1;

		private Label lblNombreUsr;

		private PictureBox fotoUsuario;

		private Label label2;

		private RibbonTab ribbonTab4;

		private RadRibbonBarGroup radRibbonBarGroup6;

		private RadButtonElement btnMhorarios;

		private RadRibbonBarGroup radRibbonBarGroup7;

		private RadButtonElement btnMtarjetas;

		private RibbonTab ribbonTab5;

		private RadRibbonBarGroup radRibbonBarGroup8;

		private RadButtonElement radButtonElement2;

		private RadRibbonBarGroup radRibbonBarGroup9;

		private RadButtonElement btnMprogramadas;

		private TelerikMetroBlueTheme telerikMetroBlueTheme2;

		private Label label3;

		private Timer tGeneral;

		private Timer tInicio;

		private Label label4;

		private RibbonTab ribbonTab6;

		private RadRibbonBarGroup radRibbonBarGroup10;

		private RadButtonElement radButtonElement3;

		private RadButtonElement radButtonElement4;

		private Panel panel1;

		private RadRibbonBarGroup radRibbonBarGroup11;

		private RadButtonElement radButtonElement5;

		private RibbonTab ribbonTab7;

		private RadRibbonBarGroup radRibbonBarGroup12;

		private RadButtonElement radButtonElement6;

		private RadButtonElement radButtonElement7;

		private RadRibbonBarGroup radRibbonBarGroup13;

		private RadButtonElement radButtonElement8;

		private RadButtonElement radButtonElement9;

		private RadButtonElement radButtonElement10;

		private RadRibbonBarGroup radRibbonBarGroup14;

		private RadButtonElement radButtonElement11;

		private frmInnerRuntime j;

		public bool banderaMartha = false;

		public frmPrincipal()
		{
			this.InitializeComponent();
		}

		private void btnMasignaVe_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(10, 1) == "0"))
			{
				(new frmVehiculoEmpleado()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMasigParqueo_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(12, 1) == "0"))
			{
				(new frmAsignaParqueo2()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMcargos_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(1, 1) == "0"))
			{
				(new frmCargo()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMdivisiones_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(4, 1) == "0"))
			{
				(new frmDivisionesEmpresa()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMempleado_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(5, 1) == "0"))
			{
				(new frmEmpleadoOk()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMempresas_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(3, 1) == "0"))
			{
				(new frmEmpresa()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMestados_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(2, 1) == "0"))
			{
				(new frmEstadosEmpleado()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMhorarios_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(13, 1) == "0"))
			{
				(new frmHorario()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMmarcas_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(7, 1) == "0"))
			{
				(new frmMarcaVehiculo()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMmodelo_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(9, 1) == "0"))
			{
				(new frmModeloVehiculo2()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMparqueo_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(11, 1) == "0"))
			{
				(new frmParqueos()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMprogramadas_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(15, 1) == "0"))
			{
				(new frmVisitaProgramadaOk_2()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMtarjetas_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(14, 1) == "0"))
			{
				(new frmTarjetas()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMtiposV_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(8, 1) == "0"))
			{
				(new frmTipoVehiculo()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void btnMvehiculos_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(6, 1) == "0"))
			{
				(new frmVehiculo()
				{
					MdiParent = this
				}).Show();
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

		private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				Form[] mdiChildren = base.MdiChildren;
				for (int i = 0; i < (int)mdiChildren.Length; i++)
				{
					mdiChildren[i].Close();
				}
				//System.Threading.Thread.CurrentThread.Abort();
				Application.Exit();

				//this.j.Close();
				//Form[] mdiChildren = base.MdiChildren;
				//for (int i = 0; i < (int)mdiChildren.Length; i++)
				//{
				//	mdiChildren[i].Close();
				//}

			}
			catch (Exception exception)
			{

			}
			
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			if (Program.idUsuarioActual == 1)
			{
				this.splitContainer1.SplitterDistance = 200;
			}
			else
			{
				(new frmVisitante()
				{
					MdiParent = this
				}).Show();
			}
			this.tGeneral.Enabled = true;
			this.tInicio.Enabled = true;
		}

		private void frmPrincipal_Resize(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmPrincipal));
			this.radRibbonBar1 = new RadRibbonBar();
			this.ribbonTab1 = new RibbonTab();
			this.radRibbonBarGroup1 = new RadRibbonBarGroup();
			this.radButtonElement1 = new RadButtonElement();
			this.btnMcargos = new RadButtonElement();
			this.btnMestados = new RadButtonElement();
			this.btnMempresas = new RadButtonElement();
			this.btnMdivisiones = new RadButtonElement();
			this.btnMempleado = new RadButtonElement();
			this.ribbonTab2 = new RibbonTab();
			this.radRibbonBarGroup2 = new RadRibbonBarGroup();
			this.btnMvehiculos = new RadButtonElement();
			this.radRibbonBarButtonGroup1 = new RadRibbonBarButtonGroup();
			this.btnMmarcas = new RadButtonElement();
			this.btnMtiposV = new RadButtonElement();
			this.btnMmodelo = new RadButtonElement();
			this.radRibbonBarGroup5 = new RadRibbonBarGroup();
			this.btnMasignaVe = new RadButtonElement();
			this.ribbonTab3 = new RibbonTab();
			this.radRibbonBarGroup3 = new RadRibbonBarGroup();
			this.btnMparqueo = new RadButtonElement();
			this.radRibbonBarGroup4 = new RadRibbonBarGroup();
			this.btnMasigParqueo = new RadButtonElement();
			this.radRibbonBarGroup11 = new RadRibbonBarGroup();
			this.radButtonElement5 = new RadButtonElement();
			this.ribbonTab4 = new RibbonTab();
			this.radRibbonBarGroup6 = new RadRibbonBarGroup();
			this.btnMhorarios = new RadButtonElement();
			this.radRibbonBarGroup7 = new RadRibbonBarGroup();
			this.btnMtarjetas = new RadButtonElement();
			this.radRibbonBarGroup14 = new RadRibbonBarGroup();
			this.radButtonElement11 = new RadButtonElement();
			this.ribbonTab5 = new RibbonTab();
			this.radRibbonBarGroup8 = new RadRibbonBarGroup();
			this.radButtonElement2 = new RadButtonElement();
			this.radRibbonBarGroup9 = new RadRibbonBarGroup();
			this.btnMprogramadas = new RadButtonElement();
			this.ribbonTab6 = new RibbonTab();
			this.radRibbonBarGroup10 = new RadRibbonBarGroup();
			this.radButtonElement3 = new RadButtonElement();
			this.radButtonElement4 = new RadButtonElement();
			this.ribbonTab7 = new RibbonTab();
			this.radRibbonBarGroup12 = new RadRibbonBarGroup();
			this.radButtonElement6 = new RadButtonElement();
			this.radButtonElement7 = new RadButtonElement();
			this.radRibbonBarGroup13 = new RadRibbonBarGroup();
			this.radButtonElement8 = new RadButtonElement();
			this.radButtonElement9 = new RadButtonElement();
			this.radButtonElement10 = new RadButtonElement();
			this.radStatusStrip1 = new RadStatusStrip();
			this.breezeTheme1 = new BreezeTheme();
			this.desertTheme1 = new DesertTheme();
			this.office2007SilverTheme1 = new Office2007SilverTheme();
			this.office2010SilverTheme1 = new Office2010SilverTheme();
			this.telerikMetroTheme1 = new TelerikMetroTheme();
			this.telerikMetroBlueTheme1 = new TelerikMetroBlueTheme();
			this.splitContainer1 = new SplitContainer();
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.label4 = new Label();
			this.lblNombreUsr = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.fotoUsuario = new PictureBox();
			this.radDock1 = new RadDock();
			this.documentContainer1 = new DocumentContainer();
			this.telerikMetroBlueTheme2 = new TelerikMetroBlueTheme();
			this.tGeneral = new Timer(this.components);
			this.tInicio = new Timer(this.components);
			((ISupportInitialize)this.radRibbonBar1).BeginInit();
			((ISupportInitialize)this.radStatusStrip1).BeginInit();
			((ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((ISupportInitialize)this.fotoUsuario).BeginInit();
			((ISupportInitialize)this.radDock1).BeginInit();
			this.radDock1.SuspendLayout();
			((ISupportInitialize)this.documentContainer1).BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.radRibbonBar1.AutoSize = true;
			RadRibbonBarCommandTabCollection commandTabs = this.radRibbonBar1.CommandTabs;
			RadItem[] radItemArray = new RadItem[] { this.ribbonTab1, this.ribbonTab2, this.ribbonTab3, this.ribbonTab4, this.ribbonTab5, this.ribbonTab6, this.ribbonTab7 };
			commandTabs.AddRange(radItemArray);
			this.radRibbonBar1.ExitButton.AccessibleDescription = "Exit";
			this.radRibbonBar1.ExitButton.AccessibleName = "Exit";
			this.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit";
			this.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit";
			this.radRibbonBar1.ExitButton.ButtonElement.Class = "RadMenuButtonElement";
			this.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.radRibbonBar1.ExitButton.Text = "Exit";
			this.radRibbonBar1.Location = new Point(0, 0);
			this.radRibbonBar1.Name = "radRibbonBar1";
			this.radRibbonBar1.OptionsButton.AccessibleDescription = "Options";
			this.radRibbonBar1.OptionsButton.AccessibleName = "Options";
			this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options";
			this.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options";
			this.radRibbonBar1.OptionsButton.ButtonElement.Class = "RadMenuButtonElement";
			this.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.radRibbonBar1.OptionsButton.Text = "Options";
			this.radRibbonBar1.RootElement.AutoSizeMode = RadAutoSizeMode.WrapAroundChildren;
			this.radRibbonBar1.Size = new System.Drawing.Size(979, 164);
			this.radRibbonBar1.StartButtonImage = null;
			this.radRibbonBar1.TabIndex = 0;
			this.radRibbonBar1.Text = "Sistema de Control de Acceso NOHA";
			this.radRibbonBar1.ThemeName = "TelerikMetroBlue";
			((RadRibbonBarElement)this.radRibbonBar1.GetChildAt(0)).Text = "Sistema de Control de Acceso NOHA";
			((FillPrimitive)this.radRibbonBar1.GetChildAt(0).GetChildAt(3).GetChildAt(1).GetChildAt(1).GetChildAt(0)).BackColor = Color.FromArgb(27, 161, 226);
			this.ribbonTab1.AccessibleDescription = "Empleados";
			this.ribbonTab1.AccessibleName = "Empleados";
			this.ribbonTab1.Class = "RibbonTab";
			this.ribbonTab1.IsSelected = true;
			RadItemOwnerCollection items = this.ribbonTab1.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup1 };
			items.AddRange(radItemArray);
			this.ribbonTab1.Name = "ribbonTab1";
			this.ribbonTab1.Text = "Maestros de Empleados";
			this.ribbonTab1.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup1.AccessibleDescription = "Tablas Maestras";
			this.radRibbonBarGroup1.AccessibleName = "Tablas Maestras";
			this.radRibbonBarGroup1.AutoSize = false;
			this.radRibbonBarGroup1.Bounds = new Rectangle(0, 0, 371, 100);
			RadItemOwnerCollection radItemOwnerCollection = this.radRibbonBarGroup1.Items;
			radItemArray = new RadItem[] { this.radButtonElement1, this.btnMcargos, this.btnMestados, this.btnMempresas, this.btnMdivisiones, this.btnMempleado };
			radItemOwnerCollection.AddRange(radItemArray);
			this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
			this.radRibbonBarGroup1.Text = "";
			this.radRibbonBarGroup1.Visibility = ElementVisibility.Visible;
			this.radButtonElement1.AccessibleDescription = "Tipos de Identificación";
			this.radButtonElement1.AccessibleName = "Tipos de Identificación";
			this.radButtonElement1.Class = "RibbonBarButtonElement";
			this.radButtonElement1.Image = Resources.Vcard_32;
			this.radButtonElement1.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement1.Name = "radButtonElement1";
			this.radButtonElement1.StretchHorizontally = true;
			this.radButtonElement1.Text = "Identificación";
			this.radButtonElement1.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement1.TextOrientation = Orientation.Horizontal;
			this.radButtonElement1.TextWrap = true;
			this.radButtonElement1.ToolTipText = "Mestro tipos de Identificación";
			this.radButtonElement1.Visibility = ElementVisibility.Visible;
			this.radButtonElement1.Click += new EventHandler(this.radButtonElement1_Click);
			this.btnMcargos.AccessibleDescription = "Maestro de Cargos ";
			this.btnMcargos.AccessibleName = "Maestro de Cargos ";
			this.btnMcargos.Class = "RibbonBarButtonElement";
			this.btnMcargos.Image = Resources.BO_Department_32x32;
			this.btnMcargos.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMcargos.Name = "btnMcargos";
			this.btnMcargos.Text = "Cargos ";
			this.btnMcargos.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMcargos.Visibility = ElementVisibility.Visible;
			this.btnMcargos.Click += new EventHandler(this.btnMcargos_Click);
			this.btnMestados.AccessibleDescription = "Maestro Estados Empleado";
			this.btnMestados.AccessibleName = "Maestro Estados Empleado";
			this.btnMestados.Class = "RibbonBarButtonElement";
			this.btnMestados.Image = Resources.BO_Role_32x32;
			this.btnMestados.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMestados.Name = "btnMestados";
			this.btnMestados.Text = "Estados";
			this.btnMestados.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMestados.Visibility = ElementVisibility.Visible;
			this.btnMestados.Click += new EventHandler(this.btnMestados_Click);
			this.btnMempresas.AccessibleDescription = "Maestro de Empresas";
			this.btnMempresas.AccessibleName = "Maestro de Empresas";
			this.btnMempresas.Class = "RibbonBarButtonElement";
			this.btnMempresas.Image = Resources.BO_Organization_32x32;
			this.btnMempresas.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMempresas.Name = "btnMempresas";
			this.btnMempresas.Text = "Empresas";
			this.btnMempresas.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMempresas.Visibility = ElementVisibility.Visible;
			this.btnMempresas.Click += new EventHandler(this.btnMempresas_Click);
			this.btnMdivisiones.AccessibleDescription = "Maestro de Divisiones";
			this.btnMdivisiones.AccessibleName = "Maestro de Divisiones";
			this.btnMdivisiones.Class = "RibbonBarButtonElement";
			this.btnMdivisiones.Image = Resources.BO_Position_32x32;
			this.btnMdivisiones.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMdivisiones.Name = "btnMdivisiones";
			this.btnMdivisiones.Text = "Divisiones";
			this.btnMdivisiones.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMdivisiones.Visibility = ElementVisibility.Visible;
			this.btnMdivisiones.Click += new EventHandler(this.btnMdivisiones_Click);
			this.btnMempleado.AccessibleDescription = "Maestro de Empleados";
			this.btnMempleado.AccessibleName = "Maestro de Empleados";
			this.btnMempleado.Class = "RibbonBarButtonElement";
			this.btnMempleado.Image = Resources.BO_Customer_32x32;
			this.btnMempleado.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMempleado.Name = "btnMempleado";
			this.btnMempleado.Text = "Empleados";
			this.btnMempleado.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMempleado.Visibility = ElementVisibility.Visible;
			this.btnMempleado.Click += new EventHandler(this.btnMempleado_Click);
			this.ribbonTab2.AccessibleDescription = "Maestras Vehiculos";
			this.ribbonTab2.AccessibleName = "Maestras Vehiculos";
			this.ribbonTab2.Class = "RibbonTab";
			this.ribbonTab2.IsSelected = false;
			RadItemOwnerCollection items1 = this.ribbonTab2.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup2, this.radRibbonBarGroup5 };
			items1.AddRange(radItemArray);
			this.ribbonTab2.Name = "ribbonTab2";
			this.ribbonTab2.Text = "Maestros de Vehiculos";
			this.ribbonTab2.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup2.AccessibleDescription = "Tablas Maestras";
			this.radRibbonBarGroup2.AccessibleName = "Tablas Maestras";
			RadItemOwnerCollection radItemOwnerCollection1 = this.radRibbonBarGroup2.Items;
			radItemArray = new RadItem[] { this.btnMvehiculos, this.radRibbonBarButtonGroup1 };
			radItemOwnerCollection1.AddRange(radItemArray);
			this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
			this.radRibbonBarGroup2.Text = "";
			this.radRibbonBarGroup2.Visibility = ElementVisibility.Visible;
			this.btnMvehiculos.AccessibleDescription = "Maestro de Vehículos";
			this.btnMvehiculos.AccessibleName = "Maestro de Vehículos";
			this.btnMvehiculos.Class = "RibbonBarButtonElement";
			this.btnMvehiculos.Image = Resources.vw_beetle_icon321;
			this.btnMvehiculos.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMvehiculos.Name = "btnMvehiculos";
			this.btnMvehiculos.Text = "Maestro de Vehículos";
			this.btnMvehiculos.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMvehiculos.Visibility = ElementVisibility.Visible;
			this.btnMvehiculos.Click += new EventHandler(this.btnMvehiculos_Click);
			this.radRibbonBarButtonGroup1.AccessibleDescription = "radRibbonBarButtonGroup1";
			this.radRibbonBarButtonGroup1.AccessibleName = "radRibbonBarButtonGroup1";
			RadItemOwnerCollection items2 = this.radRibbonBarButtonGroup1.Items;
			radItemArray = new RadItem[] { this.btnMmarcas, this.btnMtiposV, this.btnMmodelo };
			items2.AddRange(radItemArray);
			this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
			this.radRibbonBarButtonGroup1.Orientation = Orientation.Vertical;
			this.radRibbonBarButtonGroup1.Padding = new System.Windows.Forms.Padding(1);
			this.radRibbonBarButtonGroup1.ShowBackColor = false;
			this.radRibbonBarButtonGroup1.ShowBorder = false;
			this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
			this.radRibbonBarButtonGroup1.Visibility = ElementVisibility.Visible;
			this.btnMmarcas.AccessibleDescription = "Marcas";
			this.btnMmarcas.AccessibleName = "Marcas";
			this.btnMmarcas.Class = "RibbonBarButtonElement";
			this.btnMmarcas.Image = Resources.BMW_M3_Challenge_1_icon16;
			this.btnMmarcas.Name = "btnMmarcas";
			this.btnMmarcas.ShowBorder = false;
			this.btnMmarcas.SmallImage = null;
			this.btnMmarcas.Text = "Marcas";
			this.btnMmarcas.TextAlignment = ContentAlignment.MiddleRight;
			this.btnMmarcas.Visibility = ElementVisibility.Visible;
			this.btnMmarcas.Click += new EventHandler(this.btnMmarcas_Click);
			this.btnMtiposV.AccessibleDescription = "Tipos";
			this.btnMtiposV.AccessibleName = "Tipos";
			this.btnMtiposV.Class = "RibbonBarButtonElement";
			this.btnMtiposV.Image = Resources.BMW_icon24;
			this.btnMtiposV.Name = "btnMtiposV";
			this.btnMtiposV.ShowBorder = false;
			this.btnMtiposV.Text = "Tipos";
			this.btnMtiposV.TextAlignment = ContentAlignment.MiddleRight;
			this.btnMtiposV.Visibility = ElementVisibility.Visible;
			this.btnMtiposV.Click += new EventHandler(this.btnMtiposV_Click);
			this.btnMmodelo.AccessibleDescription = "Modelos";
			this.btnMmodelo.AccessibleName = "Modelos";
			this.btnMmodelo.Class = "RibbonBarButtonElement";
			this.btnMmodelo.Image = Resources.bmw_mini_icon24;
			this.btnMmodelo.Name = "btnMmodelo";
			this.btnMmodelo.ShowBorder = false;
			this.btnMmodelo.Text = "Modelos";
			this.btnMmodelo.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.btnMmodelo.Visibility = ElementVisibility.Visible;
			this.btnMmodelo.Click += new EventHandler(this.btnMmodelo_Click);
			this.radRibbonBarGroup5.AccessibleDescription = "Asingación";
			this.radRibbonBarGroup5.AccessibleName = "Asingación";
			RadItemOwnerCollection radItemOwnerCollection2 = this.radRibbonBarGroup5.Items;
			radItemArray = new RadItem[] { this.btnMasignaVe };
			radItemOwnerCollection2.AddRange(radItemArray);
			this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
			this.radRibbonBarGroup5.Text = "";
			this.radRibbonBarGroup5.Visibility = ElementVisibility.Visible;
			this.btnMasignaVe.AccessibleDescription = "Asignar Vehiculo Empleado";
			this.btnMasignaVe.AccessibleName = "Asignar Vehiculo Empleado";
			this.btnMasignaVe.Class = "RibbonBarButtonElement";
			this.btnMasignaVe.Image = Resources.bmw_mini_icon24;
			this.btnMasignaVe.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMasignaVe.Name = "btnMasignaVe";
			this.btnMasignaVe.Text = "Asignar Vehiculo Empleado";
			this.btnMasignaVe.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMasignaVe.Visibility = ElementVisibility.Visible;
			this.btnMasignaVe.Click += new EventHandler(this.btnMasignaVe_Click);
			this.ribbonTab3.AccessibleDescription = "Maestras de Parqueaderos";
			this.ribbonTab3.AccessibleName = "Maestras de Parqueaderos";
			this.ribbonTab3.Class = "RibbonTab";
			this.ribbonTab3.IsSelected = false;
			RadItemOwnerCollection items3 = this.ribbonTab3.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup3, this.radRibbonBarGroup4, this.radRibbonBarGroup11 };
			items3.AddRange(radItemArray);
			this.ribbonTab3.Name = "ribbonTab3";
			this.ribbonTab3.Text = "Maestros de Parqueaderos";
			this.ribbonTab3.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup3.AccessibleDescription = "Maestra de Parqueaderos";
			this.radRibbonBarGroup3.AccessibleName = "Maestra de Parqueaderos";
			this.radRibbonBarGroup3.Alignment = ContentAlignment.MiddleCenter;
			RadItemOwnerCollection radItemOwnerCollection3 = this.radRibbonBarGroup3.Items;
			radItemArray = new RadItem[] { this.btnMparqueo };
			radItemOwnerCollection3.AddRange(radItemArray);
			this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
			this.radRibbonBarGroup3.Text = "";
			this.radRibbonBarGroup3.Visibility = ElementVisibility.Visible;
			this.btnMparqueo.AccessibleDescription = "Parqueaderos";
			this.btnMparqueo.AccessibleName = "Parqueaderos";
			this.btnMparqueo.Class = "RibbonBarButtonElement";
			this.btnMparqueo.Image = Resources.office_building_icon32;
			this.btnMparqueo.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMparqueo.Name = "btnMparqueo";
			this.btnMparqueo.Text = "Parqueaderos";
			this.btnMparqueo.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMparqueo.Visibility = ElementVisibility.Visible;
			this.btnMparqueo.Click += new EventHandler(this.btnMparqueo_Click);
			this.radRibbonBarGroup4.AccessibleDescription = "Asignacion";
			this.radRibbonBarGroup4.AccessibleName = "Asignacion";
			RadItemOwnerCollection items4 = this.radRibbonBarGroup4.Items;
			radItemArray = new RadItem[] { this.btnMasigParqueo };
			items4.AddRange(radItemArray);
			this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
			this.radRibbonBarGroup4.Text = "";
			this.radRibbonBarGroup4.Visibility = ElementVisibility.Visible;
			this.btnMasigParqueo.AccessibleDescription = "Asignar Parqueo";
			this.btnMasigParqueo.AccessibleName = "Asignar Parqueo";
			this.btnMasigParqueo.Class = "RibbonBarButtonElement";
			this.btnMasigParqueo.Image = Resources.Car_Repair_Blue_2_icon32;
			this.btnMasigParqueo.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMasigParqueo.Name = "btnMasigParqueo";
			this.btnMasigParqueo.Text = "Asignar Parqueo";
			this.btnMasigParqueo.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMasigParqueo.Visibility = ElementVisibility.Visible;
			this.btnMasigParqueo.Click += new EventHandler(this.btnMasigParqueo_Click);
			this.radRibbonBarGroup11.AccessibleDescription = "Liberar";
			this.radRibbonBarGroup11.AccessibleName = "Liberar";
			RadItemOwnerCollection radItemOwnerCollection4 = this.radRibbonBarGroup11.Items;
			radItemArray = new RadItem[] { this.radButtonElement5 };
			radItemOwnerCollection4.AddRange(radItemArray);
			this.radRibbonBarGroup11.Name = "radRibbonBarGroup11";
			this.radRibbonBarGroup11.Text = "Liberar";
			this.radRibbonBarGroup11.Visibility = ElementVisibility.Visible;
			this.radButtonElement5.AccessibleDescription = "Liberar Parqueos";
			this.radButtonElement5.AccessibleName = "Liberar Parqueos";
			this.radButtonElement5.Class = "RibbonBarButtonElement";
			this.radButtonElement5.Image = Resources.Action_Inline_New_32x32;
			this.radButtonElement5.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement5.Name = "radButtonElement5";
			this.radButtonElement5.Text = "Liberar Parqueos";
			this.radButtonElement5.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement5.Visibility = ElementVisibility.Visible;
			this.radButtonElement5.Click += new EventHandler(this.radButtonElement5_Click);
			this.ribbonTab4.AccessibleDescription = "Maestras de Horarios Y Tarjetas";
			this.ribbonTab4.AccessibleName = "Maestras de Horarios Y Tarjetas";
			this.ribbonTab4.Class = "RibbonTab";
			this.ribbonTab4.IsSelected = false;
			RadItemOwnerCollection items5 = this.ribbonTab4.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup6, this.radRibbonBarGroup7, this.radRibbonBarGroup14 };
			items5.AddRange(radItemArray);
			this.ribbonTab4.Name = "ribbonTab4";
			this.ribbonTab4.Text = "Maestros de Horarios Y Tarjetas";
			this.ribbonTab4.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup6.AccessibleDescription = "Horarios";
			this.radRibbonBarGroup6.AccessibleName = "Horarios";
			RadItemOwnerCollection radItemOwnerCollection5 = this.radRibbonBarGroup6.Items;
			radItemArray = new RadItem[] { this.btnMhorarios };
			radItemOwnerCollection5.AddRange(radItemArray);
			this.radRibbonBarGroup6.Name = "radRibbonBarGroup6";
			this.radRibbonBarGroup6.Text = "";
			this.radRibbonBarGroup6.Visibility = ElementVisibility.Visible;
			this.btnMhorarios.AccessibleDescription = "Horarios";
			this.btnMhorarios.AccessibleName = "Horarios";
			this.btnMhorarios.Class = "RibbonBarButtonElement";
			this.btnMhorarios.Image = Resources.calendar_icon48;
			this.btnMhorarios.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMhorarios.Name = "btnMhorarios";
			this.btnMhorarios.Text = "Gestor de Horarios";
			this.btnMhorarios.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMhorarios.Visibility = ElementVisibility.Visible;
			this.btnMhorarios.Click += new EventHandler(this.btnMhorarios_Click);
			this.radRibbonBarGroup7.AccessibleDescription = "Tarjetas";
			this.radRibbonBarGroup7.AccessibleName = "Tarjetas";
			RadItemOwnerCollection items6 = this.radRibbonBarGroup7.Items;
			radItemArray = new RadItem[] { this.btnMtarjetas };
			items6.AddRange(radItemArray);
			this.radRibbonBarGroup7.Name = "radRibbonBarGroup7";
			this.radRibbonBarGroup7.Text = "";
			this.radRibbonBarGroup7.Visibility = ElementVisibility.Visible;
			this.btnMtarjetas.AccessibleDescription = "Gestor de Tarjetas";
			this.btnMtarjetas.AccessibleName = "Gestor de Tarjetas";
			this.btnMtarjetas.Class = "RibbonBarButtonElement";
			this.btnMtarjetas.Image = Resources.vcards_64;
			this.btnMtarjetas.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMtarjetas.Name = "btnMtarjetas";
			this.btnMtarjetas.Text = "Gestor de Tarjetas";
			this.btnMtarjetas.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMtarjetas.Visibility = ElementVisibility.Visible;
			this.btnMtarjetas.Click += new EventHandler(this.btnMtarjetas_Click);
			this.radRibbonBarGroup14.AccessibleDescription = "FIX";
			this.radRibbonBarGroup14.AccessibleName = "FIX";
			RadItemOwnerCollection radItemOwnerCollection6 = this.radRibbonBarGroup14.Items;
			radItemArray = new RadItem[] { this.radButtonElement11 };
			radItemOwnerCollection6.AddRange(radItemArray);
			this.radRibbonBarGroup14.Name = "radRibbonBarGroup14";
			this.radRibbonBarGroup14.Text = "FIX";
			this.radRibbonBarGroup14.Visibility = ElementVisibility.Visible;
			this.radButtonElement11.AccessibleDescription = "Limpiar Tarjeta";
			this.radButtonElement11.AccessibleName = "Limpiar Tarjeta";
			this.radButtonElement11.Class = "RibbonBarButtonElement";
			this.radButtonElement11.Image = Resources.Vcard_32;
			this.radButtonElement11.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement11.Name = "radButtonElement11";
			this.radButtonElement11.Text = "Limpiar Tarjeta";
			this.radButtonElement11.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement11.Visibility = ElementVisibility.Visible;
			this.radButtonElement11.Click += new EventHandler(this.radButtonElement11_Click);
			this.ribbonTab5.AccessibleDescription = "Visitantes";
			this.ribbonTab5.AccessibleName = "Visitantes";
			this.ribbonTab5.Class = "RibbonTab";
			this.ribbonTab5.IsSelected = false;
			RadItemOwnerCollection items7 = this.ribbonTab5.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup8, this.radRibbonBarGroup9 };
			items7.AddRange(radItemArray);
			this.ribbonTab5.Name = "ribbonTab5";
			this.ribbonTab5.Text = "Visitantes";
			this.ribbonTab5.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup8.AccessibleDescription = "Visitantes";
			this.radRibbonBarGroup8.AccessibleName = "Visitantes";
			RadItemOwnerCollection radItemOwnerCollection7 = this.radRibbonBarGroup8.Items;
			radItemArray = new RadItem[] { this.radButtonElement2 };
			radItemOwnerCollection7.AddRange(radItemArray);
			this.radRibbonBarGroup8.Name = "radRibbonBarGroup8";
			this.radRibbonBarGroup8.Text = "";
			this.radRibbonBarGroup8.Visibility = ElementVisibility.Visible;
			this.radButtonElement2.AccessibleDescription = "Gestor de Visitantes";
			this.radButtonElement2.AccessibleName = "Gestor de Visitantes";
			this.radButtonElement2.Class = "RibbonBarButtonElement";
			this.radButtonElement2.Image = Resources.BO_Role_32x321;
			this.radButtonElement2.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement2.Name = "radButtonElement2";
			this.radButtonElement2.Text = "Gestor de Visitantes";
			this.radButtonElement2.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement2.Visibility = ElementVisibility.Visible;
			this.radButtonElement2.Click += new EventHandler(this.radButtonElement2_Click);
			this.radRibbonBarGroup9.AccessibleDescription = "Visitas Programadas";
			this.radRibbonBarGroup9.AccessibleName = "Visitas Programadas";
			RadItemOwnerCollection items8 = this.radRibbonBarGroup9.Items;
			radItemArray = new RadItem[] { this.btnMprogramadas };
			items8.AddRange(radItemArray);
			this.radRibbonBarGroup9.Name = "radRibbonBarGroup9";
			this.radRibbonBarGroup9.Text = "";
			this.radRibbonBarGroup9.Visibility = ElementVisibility.Visible;
			this.btnMprogramadas.AccessibleDescription = "Gestor Visitas Programadas";
			this.btnMprogramadas.AccessibleName = "Gestor Visitas Programadas";
			this.btnMprogramadas.Class = "RibbonBarButtonElement";
			this.btnMprogramadas.Image = Resources.Actions_view_calendar_month_icon32;
			this.btnMprogramadas.ImageAlignment = ContentAlignment.MiddleCenter;
			this.btnMprogramadas.Name = "btnMprogramadas";
			this.btnMprogramadas.Text = "Gestor Visitas Programadas";
			this.btnMprogramadas.TextAlignment = ContentAlignment.BottomCenter;
			this.btnMprogramadas.Visibility = ElementVisibility.Visible;
			this.btnMprogramadas.Click += new EventHandler(this.btnMprogramadas_Click);
			this.ribbonTab6.AccessibleDescription = "Usuarios";
			this.ribbonTab6.AccessibleName = "Usuarios";
			this.ribbonTab6.Class = "RibbonTab";
			this.ribbonTab6.IsSelected = false;
			RadItemOwnerCollection radItemOwnerCollection8 = this.ribbonTab6.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup10 };
			radItemOwnerCollection8.AddRange(radItemArray);
			this.ribbonTab6.Name = "ribbonTab6";
			this.ribbonTab6.Text = "Usuarios";
			this.ribbonTab6.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup10.AccessibleDescription = "Usuarios del Sistema";
			this.radRibbonBarGroup10.AccessibleName = "Usuarios del Sistema";
			RadItemOwnerCollection items9 = this.radRibbonBarGroup10.Items;
			radItemArray = new RadItem[] { this.radButtonElement3, this.radButtonElement4 };
			items9.AddRange(radItemArray);
			this.radRibbonBarGroup10.Name = "radRibbonBarGroup10";
			this.radRibbonBarGroup10.Text = "";
			this.radRibbonBarGroup10.Visibility = ElementVisibility.Visible;
			this.radButtonElement3.AccessibleDescription = "radButtonElement3";
			this.radButtonElement3.AccessibleName = "radButtonElement3";
			this.radButtonElement3.Class = "RibbonBarButtonElement";
			this.radButtonElement3.Image = Resources.BO_User_32x32;
			this.radButtonElement3.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement3.Name = "radButtonElement3";
			this.radButtonElement3.Text = "Administrador";
			this.radButtonElement3.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement3.Visibility = ElementVisibility.Visible;
			this.radButtonElement3.Click += new EventHandler(this.radButtonElement3_Click);
			this.radButtonElement4.AccessibleDescription = "Roles";
			this.radButtonElement4.AccessibleName = "Roles";
			this.radButtonElement4.Class = "RibbonBarButtonElement";
			this.radButtonElement4.Image = Resources.BO_Department_32x32;
			this.radButtonElement4.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement4.Name = "radButtonElement4";
			this.radButtonElement4.Text = "Gestor Roles";
			this.radButtonElement4.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement4.Visibility = ElementVisibility.Visible;
			this.radButtonElement4.Click += new EventHandler(this.radButtonElement4_Click);
			this.ribbonTab7.AccessibleDescription = "Listados";
			this.ribbonTab7.AccessibleName = "Listados";
			this.ribbonTab7.Class = "RibbonTab";
			this.ribbonTab7.IsSelected = false;
			RadItemOwnerCollection radItemOwnerCollection9 = this.ribbonTab7.Items;
			radItemArray = new RadItem[] { this.radRibbonBarGroup12, this.radRibbonBarGroup13 };
			radItemOwnerCollection9.AddRange(radItemArray);
			this.ribbonTab7.Name = "ribbonTab7";
			this.ribbonTab7.Text = "Listados";
			this.ribbonTab7.Visibility = ElementVisibility.Visible;
			this.radRibbonBarGroup12.AccessibleDescription = "Listas";
			this.radRibbonBarGroup12.AccessibleName = "Listas";
			RadItemOwnerCollection items10 = this.radRibbonBarGroup12.Items;
			radItemArray = new RadItem[] { this.radButtonElement6, this.radButtonElement7 };
			items10.AddRange(radItemArray);
			this.radRibbonBarGroup12.Name = "radRibbonBarGroup12";
			this.radRibbonBarGroup12.Text = "Listas";
			this.radRibbonBarGroup12.Visibility = ElementVisibility.Visible;
			this.radButtonElement6.AccessibleDescription = "Empleados";
			this.radButtonElement6.AccessibleName = "Empleados";
			this.radButtonElement6.Class = "RibbonBarButtonElement";
			this.radButtonElement6.Image = Resources.BO_Customer_32x32;
			this.radButtonElement6.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement6.Name = "radButtonElement6";
			this.radButtonElement6.Text = "Empleados";
			this.radButtonElement6.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement6.Visibility = ElementVisibility.Visible;
			this.radButtonElement6.Click += new EventHandler(this.radButtonElement6_Click);
			this.radButtonElement7.AccessibleDescription = "Vehiculos";
			this.radButtonElement7.AccessibleName = "Vehiculos";
			this.radButtonElement7.Class = "RibbonBarButtonElement";
			this.radButtonElement7.Image = Resources.bmw_mini_icon24;
			this.radButtonElement7.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement7.Name = "radButtonElement7";
			this.radButtonElement7.Text = "Vehiculos";
			this.radButtonElement7.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement7.Visibility = ElementVisibility.Visible;
			this.radButtonElement7.Click += new EventHandler(this.radButtonElement7_Click);
			this.radRibbonBarGroup13.AccessibleDescription = "Marcaciones";
			this.radRibbonBarGroup13.AccessibleName = "Marcaciones";
			RadItemOwnerCollection radItemOwnerCollection10 = this.radRibbonBarGroup13.Items;
			radItemArray = new RadItem[] { this.radButtonElement8, this.radButtonElement9, this.radButtonElement10 };
			radItemOwnerCollection10.AddRange(radItemArray);
			this.radRibbonBarGroup13.Name = "radRibbonBarGroup13";
			this.radRibbonBarGroup13.Text = "Marcaciones";
			this.radRibbonBarGroup13.Visibility = ElementVisibility.Visible;
			this.radButtonElement8.AccessibleDescription = "Marcaciones Empleados";
			this.radButtonElement8.AccessibleName = "Marcaciones Empleados";
			this.radButtonElement8.Class = "RibbonBarButtonElement";
			this.radButtonElement8.Image = Resources.BO_Position_32x32;
			this.radButtonElement8.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement8.Name = "radButtonElement8";
			this.radButtonElement8.Text = "Marcaciones Empleados";
			this.radButtonElement8.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement8.Visibility = ElementVisibility.Visible;
			this.radButtonElement8.Click += new EventHandler(this.radButtonElement8_Click);
			this.radButtonElement9.AccessibleDescription = "Marcaciones Visitantes";
			this.radButtonElement9.AccessibleName = "Marcaciones Visitantes";
			this.radButtonElement9.Class = "RibbonBarButtonElement";
			this.radButtonElement9.Image = Resources.Vcard_32;
			this.radButtonElement9.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement9.Name = "radButtonElement9";
			this.radButtonElement9.Text = "Marcaciones Visitantes";
			this.radButtonElement9.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement9.Visibility = ElementVisibility.Visible;
			this.radButtonElement9.Click += new EventHandler(this.radButtonElement9_Click);
			this.radButtonElement10.AccessibleDescription = "Marcaciones Vehiculos";
			this.radButtonElement10.AccessibleName = "Marcaciones Vehiculos";
			this.radButtonElement10.Class = "RibbonBarButtonElement";
			this.radButtonElement10.Image = Resources.bmw_mini_icon24;
			this.radButtonElement10.ImageAlignment = ContentAlignment.MiddleCenter;
			this.radButtonElement10.Name = "radButtonElement10";
			this.radButtonElement10.Text = "Marcaciones Vehiculos";
			this.radButtonElement10.TextAlignment = ContentAlignment.BottomCenter;
			this.radButtonElement10.Visibility = ElementVisibility.Visible;
			this.radButtonElement10.Click += new EventHandler(this.radButtonElement10_Click);
			this.radStatusStrip1.AutoSize = true;
			this.radStatusStrip1.LayoutStyle = RadStatusBarLayoutStyle.Stack;
			this.radStatusStrip1.Location = new Point(0, 627);
			this.radStatusStrip1.Name = "radStatusStrip1";
			this.radStatusStrip1.Size = new System.Drawing.Size(979, 42);
			this.radStatusStrip1.SizingGrip = false;
			this.radStatusStrip1.TabIndex = 1;
			this.radStatusStrip1.Text = "radStatusStrip1";
			this.radStatusStrip1.ThemeName = "Breeze";
			this.splitContainer1.Dock = DockStyle.Fill;
			this.splitContainer1.Location = new Point(0, 164);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.lblNombreUsr);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.fotoUsuario);
			this.splitContainer1.Panel2.Controls.Add(this.radDock1);
			this.splitContainer1.Size = new System.Drawing.Size(979, 463);
			this.splitContainer1.SplitterDistance = 282;
			this.splitContainer1.TabIndex = 3;
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Location = new Point(6, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(271, 304);
			this.panel1.TabIndex = 28;
			this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label1.BackColor = Color.LightSteelBlue;
			this.label1.Location = new Point(3, 314);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Información Usuario Actual";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Black;
			this.label4.Location = new Point(12, 419);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(258, 19);
			this.label4.TabIndex = 27;
			this.label4.Text = "00:00:00";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			this.lblNombreUsr.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lblNombreUsr.Location = new Point(99, 360);
			this.lblNombreUsr.Name = "lblNombreUsr";
			this.lblNombreUsr.Size = new System.Drawing.Size(178, 17);
			this.lblNombreUsr.TabIndex = 24;
			this.lblNombreUsr.Text = "xxxxxxxxxxxx";
			this.lblNombreUsr.TextAlign = ContentAlignment.MiddleCenter;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.Location = new Point(102, 387);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "xxxxxxxxxxxx";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(12, 438);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(258, 19);
			this.label3.TabIndex = 26;
			this.label3.Text = "00:00:00";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			this.fotoUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.fotoUsuario.BackgroundImage = Resources.personal;
			this.fotoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
			this.fotoUsuario.Location = new Point(12, 336);
			this.fotoUsuario.Name = "fotoUsuario";
			this.fotoUsuario.Size = new System.Drawing.Size(81, 80);
			this.fotoUsuario.TabIndex = 23;
			this.fotoUsuario.TabStop = false;
			this.radDock1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radDock1.BackColor = Color.LightSteelBlue;
			this.radDock1.Controls.Add(this.documentContainer1);
			this.radDock1.DocumentManager.DocumentInsertOrder = DockWindowInsertOrder.InFront;
			this.radDock1.IsCleanUpTarget = true;
			this.radDock1.Location = new Point(0, 0);
			this.radDock1.MainDocumentContainer = this.documentContainer1;
			this.radDock1.Name = "radDock1";
			this.radDock1.Padding = new System.Windows.Forms.Padding(5);
			this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.radDock1.RootElement.Padding = new System.Windows.Forms.Padding(5);
			this.radDock1.Size = new System.Drawing.Size(693, 457);
			this.radDock1.SplitterWidth = 4;
			this.radDock1.TabIndex = 4;
			this.radDock1.TabStop = false;
			this.radDock1.Text = "radDock1";
			this.radDock1.ThemeName = "Desert";
			this.documentContainer1.Location = new Point(5, 5);
			this.documentContainer1.Name = "documentContainer1";
			this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
			this.documentContainer1.Size = new System.Drawing.Size(683, 447);
			this.documentContainer1.SizeInfo.SizeMode = SplitPanelSizeMode.Fill;
			this.documentContainer1.SplitterWidth = 4;
			this.documentContainer1.TabIndex = 0;
			this.documentContainer1.TabStop = false;
			this.documentContainer1.ThemeName = "Desert";
			this.tGeneral.Interval = 900;
			this.tGeneral.Tick += new EventHandler(this.tGeneral_Tick);
			this.tInicio.Interval = 800;
			this.tInicio.Tick += new EventHandler(this.tInicio_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new System.Drawing.Size(979, 669);
			base.Controls.Add(this.splitContainer1);
			base.Controls.Add(this.radStatusStrip1);
			base.Controls.Add(this.radRibbonBar1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.IsMdiContainer = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmPrincipal";
			base.RootElement.ApplyShapeToControl = true;
			this.Text = "Sistema de Control de Acceso NOHA";
			base.WindowState = FormWindowState.Maximized;
			base.FormClosing += new FormClosingEventHandler(this.frmPrincipal_FormClosing);
			base.Load += new EventHandler(this.frmPrincipal_Load);
			base.Resize += new EventHandler(this.frmPrincipal_Resize);
			((ISupportInitialize)this.radRibbonBar1).EndInit();
			((ISupportInitialize)this.radStatusStrip1).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((ISupportInitialize)this.fotoUsuario).EndInit();
			((ISupportInitialize)this.radDock1).EndInit();
			this.radDock1.ResumeLayout(false);
			((ISupportInitialize)this.documentContainer1).EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void radButtonElement1_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(0, 1) == "0"))
			{
				(new frmTipoIdentificacion()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void radButtonElement10_Click(object sender, EventArgs e)
		{
			(new frmReporteMarcacionesVehiculo()
			{
				MdiParent = this
			}).Show();
		}

		private void radButtonElement11_Click(object sender, EventArgs e)
		{
			(new frmLimpiaTarjeta()
			{
				MdiParent = this
			}).Show();
		}

		private void radButtonElement2_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(16, 1) == "0"))
			{
				(new frmVisitante()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void radButtonElement3_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(17, 1) == "0"))
			{
				(new frmUsuario()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void radButtonElement4_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(18, 1) == "0"))
			{
				(new frmTipoUsuario()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void radButtonElement5_Click(object sender, EventArgs e)
		{
			if (!(Program.permisoActual.Substring(19, 1) == "0"))
			{
				(new frmLiberaParqueo()
				{
					MdiParent = this
				}).Show();
			}
		}

		private void radButtonElement6_Click(object sender, EventArgs e)
		{
			(new frmListadoEmpleados()
			{
				MdiParent = this
			}).Show();
		}

		private void radButtonElement7_Click(object sender, EventArgs e)
		{
			(new frmListadoVehiculosParqueo()
			{
				MdiParent = this
			}).Show();
		}

		private void radButtonElement8_Click(object sender, EventArgs e)
		{
			(new frmReporteMarcacionesEmpleado()
			{
				MdiParent = this
			}).Show();
		}

		private void radButtonElement9_Click(object sender, EventArgs e)
		{
			(new frmReporteMarcacionesVisitantes()
			{
				MdiParent = this
			}).Show();
		}

		private void tGeneral_Tick(object sender, EventArgs e)
		{
			this.label3.Text = DateTime.Now.ToLongTimeString();
			this.label4.Text = DateTime.Now.ToLongDateString();
		}

		private void tInicio_Tick(object sender, EventArgs e)
		{
			this.tInicio.Enabled = false;
			this.lblNombreUsr.Text = Program.UsrActual;
			this.label2.Text = Program.usrAct2;
			this.fotoUsuario.BackgroundImage = Program.Imagen;
			this.radDock1.AutoDetectMdiChildren = true;
			if (!this.banderaMartha)
			{
				//this.j = new frmInnerRuntime()
				//{
				//	TopLevel = false,
				//	Parent = this.panel1,
				//	WindowState = FormWindowState.Maximized
				//};
				//this.j.Show();
			}
		}
	}
}