using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	internal static class Program
	{
		private static int _IdUsuarioActual;

		private static string _PermisoActual;

		private static string _UsrActual;

		public static int idUsuarioActual
		{
			get
			{
				return Program._IdUsuarioActual;
			}
			set
			{
				Program._IdUsuarioActual = value;
			}
		}

		public static Bitmap Imagen
		{
			get;
			set;
		}

		public static string permisoActual
		{
			get
			{
				return Program._PermisoActual;
			}
			set
			{
				Program._PermisoActual = value;
			}
		}

		public static string usrAct2
		{
			get;
			set;
		}

		public static string UsrActual
		{
			get
			{
				return Program._UsrActual;
			}
			set
			{
				Program._UsrActual = value;
			}
		}

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if ((new frmLogIn()).ShowDialog() == DialogResult.OK)
			{
				Application.Run(new frmPrincipal());
				Application.Run(new frmPruebaFuentecs());
			}
		}
	}
}