using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.COMMON;
using BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmVisitante : Form
	{
		private AutoCompleteStringCollection txtC;

		private AutoCompleteStringCollection txtT;

		private bool agrego;

		public int indice;

		public decimal idVisitanteF;

		public decimal idvisitaprogramada;

		private IContainer components = null;

		private Panel panel2;

		private Label label1;

		private RadTextBoxControl txtDocIdentidad;

		private Label label2;

		private RadGroupBox radGroupBox1;

		private ComboBox comboBox1;

		private Label label4;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSet masterDBACDataSet;

		private BindingSource tTipoIdentificacionBindingSource;

		private TTipoIdentificacionTableAdapter tTipoIdentificacionTableAdapter;

		private Button button6;

		private RadioButton radioButton2;

		private RadioButton radioButton1;

		private PictureBox fotoUsuario;

		private Label label8;

		private RadTextBoxControl txtObservaciones;

		private Label label7;

		private RadTextBoxControl txtTelefonos;

		private Label label6;

		private RadTextBoxControl txtDireccion;

		private Label label5;

		private RadTextBoxControl txtEmpresa;

		private Label label3;

		private RadTextBoxControl txtNombre;

		private Office2010BlackTheme office2010BlackTheme1;

		private Button btnCancelar;

		private Button button1;

		private OpenFileDialog openFileDialog1;

		private Label label11;

		private RadDateTimePicker dtFecha2;

		private Label label10;

		private RadDateTimePicker dtFecha1;

		private Label label9;

		private Label txtId2;

		private Label label12;

		private BindingSource tVisitaProgramadaBindingSource;

		private TVisitaProgramadaTableAdapter tVisitaProgramadaTableAdapter;

		private TableAdapterManager tableAdapterManager;

		private CheckBox checkBox1;

		private Label label13;

		private Label label14;

		private RadDropDownList rdEmpresaDestino;

		private TEmpresaTableAdapter tEmpresaTableAdapter;

		private BindingSource tEmpresaBindingSource;

		private Label label16;

		private RadDropDownList rdDivisionDestino;

		private BindingSource fKTDivisionEmpresaTEmpresaBindingSource;

		private TDivisionEmpresaTableAdapter tDivisionEmpresaTableAdapter;

		private Label label17;

		private RadDropDownList rdEmpleadoDestino;

		private BindingSource fKTEmpleadoTDivisionEmpresaBindingSource;

		private TEmpleadoTableAdapter tEmpleadoTableAdapter;

		private Label label18;

		private Label label15;

		private BindingSource tTarjetaBindingSource;

		private TTarjetaTableAdapter tTarjetaTableAdapter;

		private ToolStrip fillByNoutilizadaToolStrip;

		private ToolStripButton fillByNoutilizadaToolStripButton;

		private ToolStrip fillByVisitasActivasToolStrip;

		private ToolStripButton fillByVisitasActivasToolStripButton;

		private BindingSource tEmpleadoBindingSource;

		private Label lblIdEmp;

		private Button button2;

		private RadDesktopAlert radDesktopAlert1;

		private Label lblPreprogramada;

		private Panel panel1;

		private Label lblVisitaProgramadaInfo;

		private Timer timer1;

		private RadDesktopAlert radDesktopAlert2;

		private TelerikMetroBlueTheme telerikMetroBlueTheme1;

		private ComboBox cmbTarjeta;

		private RadDropDownList cmbProgramada;

		public frmVisitante()
		{
			this.InitializeComponent();
			this.agrego = false;
			this.indice = 0;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TVisitaProgramada tVisitaProgramada;
			TVisitanteVisitaProgramada tVisitanteVisitaProgramada;
			Exception exception;
			TTarjeta nullable;
			if (!this.checkBox1.Checked)
			{
				if (this.cmbTarjeta.SelectedIndex < 0)
				{
					this.radDesktopAlert1.ContentImage = Resources.accept_icon__1_;
					this.radDesktopAlert1.CaptionText = "Aviso";
					this.radDesktopAlert1.ContentText = "Error No existe la tarjeta";
					this.radDesktopAlert1.FixedSize = new System.Drawing.Size(450, 150);
					this.radDesktopAlert1.Show();
					return;
				}
				else if (this.txtNombre.Text == "")
				{
					this.radDesktopAlert1.ContentImage = Resources.accept_icon__1_;
					this.radDesktopAlert1.CaptionText = "Aviso";
					this.radDesktopAlert1.ContentText = "nombre invalido";
					this.radDesktopAlert1.FixedSize = new System.Drawing.Size(450, 150);
					this.radDesktopAlert1.Show();
					return;
				}
				else if (this.rdEmpleadoDestino.SelectedIndex < 0)
				{
					this.radDesktopAlert1.ContentImage = Resources.accept_icon__1_;
					this.radDesktopAlert1.CaptionText = "Aviso";
					this.radDesktopAlert1.ContentText = "destino no seleccionado";
					this.radDesktopAlert1.FixedSize = new System.Drawing.Size(450, 150);
					this.radDesktopAlert1.Show();
					return;
				}
			}
			Utilitys utility = new Utilitys();
			decimal num = this.idVisitanteF;
			decimal num1 = new decimal(0);
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TransactionScope transactionScope = new TransactionScope();
				try
				{
					switch (this.indice)
					{
						case 1:
						{
							if (!(this.txtNombre.Text != ""))
							{
								MessageBox.Show("Error: Informacion del Visitante Incompleta", "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
							else
							{
								TVisitante tVisitante = new TVisitante()
								{
									nombreVisitante = this.txtNombre.Text,
									idTipoIdentificacion = new int?((int)this.comboBox1.SelectedValue),
									identificacionVisitante = this.txtDocIdentidad.Text,
									telefonos = this.txtTelefonos.Text,
									direccion = this.txtDireccion.Text,
									empresa = this.txtEmpresa.Text,
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									foto = utility.Image2Bytes(this.fotoUsuario.BackgroundImage)
								};
								TVisitante tVisitante1 = tVisitante;
								try
								{
									masterDBACEntity.AddToTVisitante(tVisitante1);
									masterDBACEntity.SaveChanges();
									num = tVisitante1.idVisitante;
								}
								catch (Exception exception1)
								{
									exception = exception1;
									MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								TVisitaProgramada tVisitaProgramada1 = new TVisitaProgramada()
								{
									DescripcionVisita = "Entrada Portería",
									fechaInicio = new DateTime?(this.dtFecha1.Value),
									fechafin = new DateTime?(this.dtFecha2.Value),
									idEmpresa = new int?((int)this.rdEmpresaDestino.SelectedValue),
									idEmpleado = new int?((int)this.rdEmpleadoDestino.SelectedValue),
									ObservacionesVisita = this.txtObservaciones.Text,
									idEstadoVisita = new int?(1),
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									usuarioUltimaGestion = new int?(Program.idUsuarioActual)
								};
								tVisitaProgramada = tVisitaProgramada1;
								try
								{
									masterDBACEntity.AddToTVisitaProgramada(tVisitaProgramada);
									masterDBACEntity.SaveChanges();
									num1 = tVisitaProgramada.idVisitaProgramada;
								}
								catch (Exception exception2)
								{
									exception = exception2;
									MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								if (!this.checkBox1.Checked)
								{
									nullable = (
										from tj in masterDBACEntity.TTarjeta
										where tj.numtarjeta == this.cmbTarjeta.Text
										select tj).FirstOrDefault<TTarjeta>();
									nullable.esutilizada = new bool?(true);
									nullable.esvisitante = new bool?(true);
									nullable.fechavisi1 = new DateTime?(this.dtFecha1.Value);
									nullable.fechavisi2 = new DateTime?(this.dtFecha2.Value);
									try
									{
										masterDBACEntity.SaveChanges();
									}
									catch (Exception exception3)
									{
										exception = exception3;
										MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
										return;
									}
								}
								if (!this.checkBox1.Checked)
								{
									TVisitanteVisitaProgramada tVisitanteVisitaProgramada1 = new TVisitanteVisitaProgramada()
									{
										idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
										idVisitaProgramada = num1,
										idVisitante = num,
										fechaLlegada = new DateTime?(this.dtFecha1.Value),
										fechaSalida = new DateTime?(this.dtFecha2.Value),
										fechaUltimaGestion = new DateTime?(DateTime.Now),
										ObservacionesVisita = this.txtObservaciones.Text,
										usuarioUltimaGestion = new int?(Program.idUsuarioActual),
										visitacumplida = new bool?(true),
										idTarjeta = new int?((int)this.cmbTarjeta.SelectedValue)
									};
									tVisitanteVisitaProgramada = tVisitanteVisitaProgramada1;
								}
								else
								{
									TVisitanteVisitaProgramada tVisitanteVisitaProgramada2 = new TVisitanteVisitaProgramada()
									{
										idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
										idVisitaProgramada = num1,
										idVisitante = num,
										fechaLlegada = new DateTime?(this.dtFecha1.Value),
										fechaSalida = new DateTime?(this.dtFecha2.Value),
										fechaUltimaGestion = new DateTime?(DateTime.Now),
										ObservacionesVisita = this.txtObservaciones.Text,
										usuarioUltimaGestion = new int?(Program.idUsuarioActual),
										visitacumplida = new bool?(false)
									};
									tVisitanteVisitaProgramada = tVisitanteVisitaProgramada2;
								}
								try
								{
									masterDBACEntity.AddToTVisitanteVisitaProgramada(tVisitanteVisitaProgramada);
									TVisitanteVisitaProgramadaLog tVisitanteVisitaProgramadaLog = new TVisitanteVisitaProgramadaLog()
									{
										idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
										idVisitaProgramada = num1,
										idVisitante = num,
										fechaRegistro = new DateTime?(DateTime.Now),
										fechaLlegada = new DateTime?(this.dtFecha1.Value),
										fechaSalida = new DateTime?(this.dtFecha2.Value),
										fechaUltimaGestion = new DateTime?(DateTime.Now),
										ObservacionesVisita = this.txtObservaciones.Text,
										usuarioUltimaGestion = new int?(Program.idUsuarioActual),
										visitacumplida = new bool?(false)
									};
									masterDBACEntity.AddToTVisitanteVisitaProgramadaLog(tVisitanteVisitaProgramadaLog);
									masterDBACEntity.SaveChanges();
									transactionScope.Complete();
									num1 = tVisitanteVisitaProgramada.idVisitaProgramada;
									MessageBox.Show("El resgitro se agrego con exito!", "Gestion CAV12", MessageBoxButtons.OK);
									this.limpiaCampos();
								}
								catch (Exception exception4)
								{
									exception = exception4;
									MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								break;
							}
						}
						case 2:
						{
							TVisitante text = (
								from vi in masterDBACEntity.TVisitante
								where vi.idVisitante == num
								select vi).FirstOrDefault<TVisitante>();
							try
							{
								text.nombreVisitante = this.txtNombre.Text;
								text.idTipoIdentificacion = new int?((int)this.comboBox1.SelectedValue);
								text.identificacionVisitante = this.txtDocIdentidad.Text;
								text.telefonos = this.txtTelefonos.Text;
								text.direccion = this.txtDireccion.Text;
								text.empresa = this.txtEmpresa.Text;
								text.fechaUltimaGestion = new DateTime?(DateTime.Now);
								text.foto = utility.Image2Bytes(this.fotoUsuario.BackgroundImage);
								masterDBACEntity.SaveChanges();
							}
							catch (Exception exception5)
							{
							}
							if (!this.checkBox1.Checked)
							{
								nullable = (
									from tj in masterDBACEntity.TTarjeta
									where tj.numtarjeta == this.cmbTarjeta.Text
									select tj).FirstOrDefault<TTarjeta>();
								nullable.esutilizada = new bool?(true);
								nullable.esvisitante = new bool?(true);
								nullable.fechavisi1 = new DateTime?(this.dtFecha1.Value);
								nullable.fechavisi2 = new DateTime?(this.dtFecha2.Value);
								try
								{
									masterDBACEntity.SaveChanges();
								}
								catch (Exception exception6)
								{
									exception = exception6;
									MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
							}
							if (!this.checkBox1.Checked)
							{
								TVisitaProgramada tVisitaProgramada2 = new TVisitaProgramada()
								{
									DescripcionVisita = "Entrada Portería",
									fechaInicio = new DateTime?(this.dtFecha1.Value),
									fechafin = new DateTime?(this.dtFecha2.Value),
									idEmpresa = new int?((int)this.rdEmpresaDestino.SelectedValue),
									idEmpleado = new int?((int)this.rdEmpleadoDestino.SelectedValue),
									ObservacionesVisita = this.txtObservaciones.Text,
									idEstadoVisita = new int?(1),
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									usuarioUltimaGestion = new int?(Program.idUsuarioActual)
								};
								tVisitaProgramada = tVisitaProgramada2;
								try
								{
									masterDBACEntity.AddToTVisitaProgramada(tVisitaProgramada);
									masterDBACEntity.SaveChanges();
									num1 = tVisitaProgramada.idVisitaProgramada;
								}
								catch (Exception exception7)
								{
									exception = exception7;
									MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								TVisitanteVisitaProgramada tVisitanteVisitaProgramada3 = new TVisitanteVisitaProgramada()
								{
									idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
									idVisitaProgramada = num1,
									idVisitante = num,
									fechaLlegada = new DateTime?(this.dtFecha1.Value),
									fechaSalida = new DateTime?(this.dtFecha2.Value),
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									ObservacionesVisita = this.txtObservaciones.Text,
									usuarioUltimaGestion = new int?(Program.idUsuarioActual),
									visitacumplida = new bool?(true),
									idTarjeta = new int?((int)this.cmbTarjeta.SelectedValue)
								};
								tVisitanteVisitaProgramada = tVisitanteVisitaProgramada3;
								TVisitanteVisitaProgramadaLog tVisitanteVisitaProgramadaLog1 = new TVisitanteVisitaProgramadaLog()
								{
									idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
									idVisitaProgramada = num1,
									idVisitante = num,
									fechaRegistro = new DateTime?(DateTime.Now),
									fechaLlegada = new DateTime?(this.dtFecha1.Value),
									fechaSalida = new DateTime?(this.dtFecha2.Value),
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									ObservacionesVisita = this.txtObservaciones.Text,
									usuarioUltimaGestion = new int?(Program.idUsuarioActual),
									visitacumplida = new bool?(false)
								};
								masterDBACEntity.AddToTVisitanteVisitaProgramadaLog(tVisitanteVisitaProgramadaLog1);
							}
							else
							{
								num1 = Convert.ToInt32(this.cmbProgramada.SelectedValue);
								TVisitanteVisitaProgramada tVisitanteVisitaProgramada4 = new TVisitanteVisitaProgramada()
								{
									idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
									idVisitaProgramada = num1,
									idVisitante = num,
									fechaLlegada = new DateTime?(this.dtFecha1.Value),
									fechaSalida = new DateTime?(this.dtFecha2.Value),
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									ObservacionesVisita = this.txtObservaciones.Text,
									usuarioUltimaGestion = new int?(Program.idUsuarioActual),
									visitacumplida = new bool?(false)
								};
								tVisitanteVisitaProgramada = tVisitanteVisitaProgramada4;
							}
							try
							{
								masterDBACEntity.AddToTVisitanteVisitaProgramada(tVisitanteVisitaProgramada);
								masterDBACEntity.SaveChanges();
								transactionScope.Complete();
								num1 = tVisitanteVisitaProgramada.idVisitaProgramada;
								MessageBox.Show("El resgitro se agrego con exito!", "Gestion CAV12", MessageBoxButtons.OK);
								this.limpiaCampos();
							}
							catch (Exception exception8)
							{
								exception = exception8;
								MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
							break;
						}
						case 3:
						{
							TVisitante text1 = (
								from vi in masterDBACEntity.TVisitante
								where vi.idVisitante == num
								select vi).FirstOrDefault<TVisitante>();
							try
							{
								text1.nombreVisitante = this.txtNombre.Text;
								text1.idTipoIdentificacion = new int?((int)this.comboBox1.SelectedValue);
								text1.identificacionVisitante = this.txtDocIdentidad.Text;
								text1.telefonos = this.txtTelefonos.Text;
								text1.direccion = this.txtDireccion.Text;
								text1.empresa = this.txtEmpresa.Text;
								text1.fechaUltimaGestion = new DateTime?(DateTime.Now);
								text1.foto = utility.Image2Bytes(this.fotoUsuario.BackgroundImage);
								masterDBACEntity.SaveChanges();
							}
							catch (Exception exception9)
							{
							}
							if (!this.checkBox1.Checked)
							{
								try
								{
									nullable = (
										from tj in masterDBACEntity.TTarjeta
										where tj.numtarjeta == this.cmbTarjeta.Text
										select tj).FirstOrDefault<TTarjeta>();
									nullable.esutilizada = new bool?(true);
									nullable.esvisitante = new bool?(true);
									nullable.fechavisi1 = new DateTime?(this.dtFecha1.Value);
									nullable.fechavisi2 = new DateTime?(this.dtFecha2.Value);
									masterDBACEntity.SaveChanges();
								}
								catch (Exception exception10)
								{
									exception = exception10;
									MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
							}
							TVisitanteVisitaProgramada nullable1 = (
								from a in masterDBACEntity.TVisitanteVisitaProgramada
								where a.idVisitante == this.idVisitanteF && a.idVisitaProgramada == this.idvisitaprogramada
								select a).FirstOrDefault<TVisitanteVisitaProgramada>();
							nullable1.idTarjeta = new int?((int)this.cmbTarjeta.SelectedValue);
							nullable1.visitacumplida = new bool?(true);
							try
							{
								masterDBACEntity.SaveChanges();
								TVisitanteVisitaProgramadaLog tVisitanteVisitaProgramadaLog2 = new TVisitanteVisitaProgramadaLog()
								{
									idEmpleadoAutorizaEntrada = new int?((int)this.rdEmpleadoDestino.SelectedValue),
									idVisitaProgramada = nullable1.idVisitaProgramada,
									idVisitante = num,
									fechaRegistro = new DateTime?(DateTime.Now),
									fechaLlegada = new DateTime?(this.dtFecha1.Value),
									fechaSalida = new DateTime?(this.dtFecha2.Value),
									fechaUltimaGestion = new DateTime?(DateTime.Now),
									ObservacionesVisita = this.txtObservaciones.Text,
									usuarioUltimaGestion = new int?(Program.idUsuarioActual),
									visitacumplida = new bool?(false)
								};
								masterDBACEntity.AddToTVisitanteVisitaProgramadaLog(tVisitanteVisitaProgramadaLog2);
								masterDBACEntity.SaveChanges();
								transactionScope.Complete();
								MessageBox.Show("El resgitro se agrego con exito!", "Gestion CAV12", MessageBoxButtons.OK);
								this.limpiaCampos();
							}
							catch (Exception exception11)
							{
								exception = exception11;
								MessageBox.Show(string.Concat("Error: ", exception.Message), "Sistema Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
							break;
						}
					}
				}
				finally
				{
					if (transactionScope != null)
					{
						((IDisposable)transactionScope).Dispose();
					}
				}
				return;
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				frmCamara _frmCamara = new frmCamara();
				try
				{
					_frmCamara.u = this.fotoUsuario;
					_frmCamara.ShowDialog();
				}
				finally
				{
					if (_frmCamara != null)
					{
						((IDisposable)_frmCamara).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.fotoUsuario.BackgroundImage = Resources.personal;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.label13.Enabled = this.checkBox1.Checked;
			this.cmbProgramada.Enabled = Convert.ToBoolean(this.checkBox1.Checked);
			this.cmbTarjeta.Enabled = !Convert.ToBoolean(this.checkBox1.Checked);
			this.label9.Enabled = !this.checkBox1.Checked;
			if (!this.checkBox1.Checked)
			{
				this.dtFecha1.Enabled = true;
				this.dtFecha2.Enabled = true;
			}
		}

		private void cmbProgramada_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					var variable = (
						from a in masterDBACEntity.TVisitaProgramada
						join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
						join c in masterDBACEntity.TDivisionEmpresa on b.idDivisionEmpresa equals c.IdDivisionEmpresa
						join d in masterDBACEntity.TEmpresa on c.IdEmpresa equals (int?)d.idEmpresa
						where a.idVisitaProgramada == (decimal)this.cmbProgramada.SelectedValue
						select new { idempresa = d.idEmpresa, idDivision = c.IdDivisionEmpresa, idemple = b.idEmpleado, f1 = a.fechaInicio, f2 = a.fechafin }).FirstOrDefault();
					this.rdEmpresaDestino.SelectedValue = variable.idempresa;
					this.rdDivisionDestino.SelectedValue = variable.idDivision;
					this.rdEmpleadoDestino.SelectedValue = variable.idemple;
					this.dtFecha1.Value = variable.f1.Value;
					this.dtFecha2.Value = variable.f2.Value;
					this.dtFecha1.Enabled = false;
					this.dtFecha2.Enabled = false;
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
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

		private void fillByNoutilizadaToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.tTarjetaTableAdapter.Fill(this.masterDBACDataSet.TTarjeta);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void fillByVisitasActivasToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.tVisitaProgramadaTableAdapter.FillByVisitasActivas(this.masterDBACDataSet.TVisitaProgramada);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void fotoUsuario_Click(object sender, EventArgs e)
		{
		}

		private void fotoUsuario_DoubleClick(object sender, EventArgs e)
		{
		}

		private void frmVisitante_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\u001B')
			{
				this.limpiaCampos();
			}
		}

		private void frmVisitante_Load(object sender, EventArgs e)
		{
			Application.DoEvents();
			this.timer1.Enabled = true;
		}

		public void inicio()
		{
			this.cmbProgramada.SelectedIndex = -1;
			this.txtNombre.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);
			this.txtEmpresa.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);
			this.txtTelefonos.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);
			this.txtDireccion.KeyPress += new KeyPressEventHandler(this.txtNombre_KeyPress);
			this.dtFecha1.Value = DateTime.Now;
			this.dtFecha2.Value = DateTime.Now.AddHours(12);
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			this.txtT = frmVisitante.LoadAutoIdentificacion(masterDBACEntity.TTarjeta.ToList<TTarjeta>());
			this.limpiaCampos();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.label2 = new Label();
			this.txtDocIdentidad = new RadTextBoxControl();
			this.radGroupBox1 = new RadGroupBox();
			this.panel1 = new Panel();
			this.lblVisitaProgramadaInfo = new Label();
			this.lblPreprogramada = new Label();
			this.button2 = new Button();
			this.rdDivisionDestino = new RadDropDownList();
			this.fKTDivisionEmpresaTEmpresaBindingSource = new BindingSource(this.components);
			this.tEmpresaBindingSource = new BindingSource(this.components);
			this.masterDBACDataSet = new BGCOP.CAVTOP.WINFORMS.masterDBACDataSet();
			this.rdEmpresaDestino = new RadDropDownList();
			this.label15 = new Label();
			this.lblIdEmp = new Label();
			this.tEmpleadoBindingSource = new BindingSource(this.components);
			this.tTarjetaBindingSource = new BindingSource(this.components);
			this.label18 = new Label();
			this.label17 = new Label();
			this.rdEmpleadoDestino = new RadDropDownList();
			this.label16 = new Label();
			this.label14 = new Label();
			this.label13 = new Label();
			this.checkBox1 = new CheckBox();
			this.tVisitaProgramadaBindingSource = new BindingSource(this.components);
			this.label12 = new Label();
			this.txtId2 = new Label();
			this.btnCancelar = new Button();
			this.button1 = new Button();
			this.label9 = new Label();
			this.label11 = new Label();
			this.dtFecha2 = new RadDateTimePicker();
			this.label10 = new Label();
			this.dtFecha1 = new RadDateTimePicker();
			this.label8 = new Label();
			this.txtObservaciones = new RadTextBoxControl();
			this.label7 = new Label();
			this.txtTelefonos = new RadTextBoxControl();
			this.label6 = new Label();
			this.txtDireccion = new RadTextBoxControl();
			this.radioButton1 = new RadioButton();
			this.radioButton2 = new RadioButton();
			this.button6 = new Button();
			this.fotoUsuario = new PictureBox();
			this.label5 = new Label();
			this.txtEmpresa = new RadTextBoxControl();
			this.label3 = new Label();
			this.txtNombre = new RadTextBoxControl();
			this.comboBox1 = new ComboBox();
			this.tTipoIdentificacionBindingSource = new BindingSource(this.components);
			this.label4 = new Label();
			this.fKTEmpleadoTDivisionEmpresaBindingSource = new BindingSource(this.components);
			this.tTipoIdentificacionTableAdapter = new TTipoIdentificacionTableAdapter();
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			this.openFileDialog1 = new OpenFileDialog();
			this.tVisitaProgramadaTableAdapter = new TVisitaProgramadaTableAdapter();
			this.tableAdapterManager = new TableAdapterManager();
			this.tEmpresaTableAdapter = new TEmpresaTableAdapter();
			this.tDivisionEmpresaTableAdapter = new TDivisionEmpresaTableAdapter();
			this.tEmpleadoTableAdapter = new TEmpleadoTableAdapter();
			this.tTarjetaTableAdapter = new TTarjetaTableAdapter();
			this.fillByNoutilizadaToolStrip = new ToolStrip();
			this.fillByNoutilizadaToolStripButton = new ToolStripButton();
			this.fillByVisitasActivasToolStrip = new ToolStrip();
			this.fillByVisitasActivasToolStripButton = new ToolStripButton();
			this.radDesktopAlert1 = new RadDesktopAlert(this.components);
			this.timer1 = new Timer(this.components);
			this.radDesktopAlert2 = new RadDesktopAlert(this.components);
			this.telerikMetroBlueTheme1 = new TelerikMetroBlueTheme();
			this.cmbProgramada = new RadDropDownList();
			this.cmbTarjeta = new ComboBox();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.txtDocIdentidad).BeginInit();
			((ISupportInitialize)this.radGroupBox1).BeginInit();
			this.radGroupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.rdDivisionDestino).BeginInit();
			((ISupportInitialize)this.fKTDivisionEmpresaTEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.tEmpresaBindingSource).BeginInit();
			((ISupportInitialize)this.masterDBACDataSet).BeginInit();
			((ISupportInitialize)this.rdEmpresaDestino).BeginInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).BeginInit();
			((ISupportInitialize)this.tTarjetaBindingSource).BeginInit();
			((ISupportInitialize)this.rdEmpleadoDestino).BeginInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).BeginInit();
			((ISupportInitialize)this.dtFecha2).BeginInit();
			((ISupportInitialize)this.dtFecha1).BeginInit();
			((ISupportInitialize)this.txtObservaciones).BeginInit();
			((ISupportInitialize)this.txtTelefonos).BeginInit();
			((ISupportInitialize)this.txtDireccion).BeginInit();
			((ISupportInitialize)this.fotoUsuario).BeginInit();
			((ISupportInitialize)this.txtEmpresa).BeginInit();
			((ISupportInitialize)this.txtNombre).BeginInit();
			((ISupportInitialize)this.tTipoIdentificacionBindingSource).BeginInit();
			((ISupportInitialize)this.fKTEmpleadoTDivisionEmpresaBindingSource).BeginInit();
			this.fillByNoutilizadaToolStrip.SuspendLayout();
			this.fillByVisitasActivasToolStrip.SuspendLayout();
			((ISupportInitialize)this.cmbProgramada).BeginInit();
			base.SuspendLayout();
			this.panel2.BackColor = Color.WhiteSmoke;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtDocIdentidad);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(936, 35);
			this.panel2.TabIndex = 4;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(37, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Visitante";
			this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(466, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Documento de identificación";
			this.txtDocIdentidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.txtDocIdentidad.Font = new System.Drawing.Font("Arial Narrow", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtDocIdentidad.Location = new Point(635, 7);
			this.txtDocIdentidad.Name = "txtDocIdentidad";
			this.txtDocIdentidad.Size = new System.Drawing.Size(273, 25);
			this.txtDocIdentidad.TabIndex = 1;
			this.txtDocIdentidad.KeyUp += new KeyEventHandler(this.txtDocIdentidad_KeyUp);
			this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this.radGroupBox1.Controls.Add(this.cmbTarjeta);
			this.radGroupBox1.Controls.Add(this.panel1);
			this.radGroupBox1.Controls.Add(this.lblPreprogramada);
			this.radGroupBox1.Controls.Add(this.button2);
			this.radGroupBox1.Controls.Add(this.rdDivisionDestino);
			this.radGroupBox1.Controls.Add(this.rdEmpresaDestino);
			this.radGroupBox1.Controls.Add(this.label15);
			this.radGroupBox1.Controls.Add(this.lblIdEmp);
			this.radGroupBox1.Controls.Add(this.label18);
			this.radGroupBox1.Controls.Add(this.label17);
			this.radGroupBox1.Controls.Add(this.rdEmpleadoDestino);
			this.radGroupBox1.Controls.Add(this.label16);
			this.radGroupBox1.Controls.Add(this.label14);
			this.radGroupBox1.Controls.Add(this.label13);
			this.radGroupBox1.Controls.Add(this.checkBox1);
			this.radGroupBox1.Controls.Add(this.cmbProgramada);
			this.radGroupBox1.Controls.Add(this.label12);
			this.radGroupBox1.Controls.Add(this.txtId2);
			this.radGroupBox1.Controls.Add(this.btnCancelar);
			this.radGroupBox1.Controls.Add(this.button1);
			this.radGroupBox1.Controls.Add(this.label9);
			this.radGroupBox1.Controls.Add(this.label11);
			this.radGroupBox1.Controls.Add(this.dtFecha2);
			this.radGroupBox1.Controls.Add(this.label10);
			this.radGroupBox1.Controls.Add(this.dtFecha1);
			this.radGroupBox1.Controls.Add(this.label8);
			this.radGroupBox1.Controls.Add(this.txtObservaciones);
			this.radGroupBox1.Controls.Add(this.label7);
			this.radGroupBox1.Controls.Add(this.txtTelefonos);
			this.radGroupBox1.Controls.Add(this.label6);
			this.radGroupBox1.Controls.Add(this.txtDireccion);
			this.radGroupBox1.Controls.Add(this.radioButton1);
			this.radGroupBox1.Controls.Add(this.radioButton2);
			this.radGroupBox1.Controls.Add(this.button6);
			this.radGroupBox1.Controls.Add(this.fotoUsuario);
			this.radGroupBox1.Controls.Add(this.label5);
			this.radGroupBox1.Controls.Add(this.txtEmpresa);
			this.radGroupBox1.Controls.Add(this.label3);
			this.radGroupBox1.Controls.Add(this.txtNombre);
			this.radGroupBox1.Controls.Add(this.comboBox1);
			this.radGroupBox1.Controls.Add(this.label4);
			this.radGroupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.radGroupBox1.FooterImageIndex = -1;
			this.radGroupBox1.FooterImageKey = "";
			this.radGroupBox1.FooterText = "Visitas";
			this.radGroupBox1.GroupBoxStyle = RadGroupBoxStyle.Office;
			this.radGroupBox1.HeaderImageIndex = -1;
			this.radGroupBox1.HeaderImageKey = "";
			this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
			this.radGroupBox1.HeaderText = "Datos del Visitante";
			this.radGroupBox1.Location = new Point(12, 36);
			this.radGroupBox1.Name = "radGroupBox1";
			this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
			this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
			this.radGroupBox1.Size = new System.Drawing.Size(914, 478);
			this.radGroupBox1.TabIndex = 7;
			this.radGroupBox1.Text = "Datos del Visitante";
			this.radGroupBox1.ThemeName = "TelerikMetroBlue";
			this.panel1.Controls.Add(this.lblVisitaProgramadaInfo);
			this.panel1.Location = new Point(132, 316);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(606, 100);
			this.panel1.TabIndex = 121;
			this.lblVisitaProgramadaInfo.BackColor = Color.SandyBrown;
			this.lblVisitaProgramadaInfo.Location = new Point(13, 4);
			this.lblVisitaProgramadaInfo.Name = "lblVisitaProgramadaInfo";
			this.lblVisitaProgramadaInfo.Size = new System.Drawing.Size(575, 89);
			this.lblVisitaProgramadaInfo.TabIndex = 0;
			this.lblVisitaProgramadaInfo.Text = "...";
			this.lblPreprogramada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.lblPreprogramada.BorderStyle = BorderStyle.FixedSingle;
			this.lblPreprogramada.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblPreprogramada.Location = new Point(132, 298);
			this.lblPreprogramada.Name = "lblPreprogramada";
			this.lblPreprogramada.Size = new System.Drawing.Size(605, 18);
			this.lblPreprogramada.TabIndex = 120;
			this.lblPreprogramada.Text = "...";
			this.lblPreprogramada.TextAlign = ContentAlignment.MiddleCenter;
			this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.Location = new Point(776, 165);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 24);
			this.button2.TabIndex = 119;
			this.button2.Text = "Capturar Imagen";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.rdDivisionDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.rdDivisionDestino.AutoCompleteDisplayMember = "NombreDivision";
			this.rdDivisionDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.rdDivisionDestino.AutoCompleteValueMember = "IdDivisionEmpresa";
			this.rdDivisionDestino.DataSource = this.fKTDivisionEmpresaTEmpresaBindingSource;
			this.rdDivisionDestino.DisplayMember = "NombreDivision";
			this.rdDivisionDestino.DropDownAnimationEnabled = true;
			this.rdDivisionDestino.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rdDivisionDestino.Location = new Point(132, 210);
			this.rdDivisionDestino.MaxDropDownItems = 0;
			this.rdDivisionDestino.Name = "rdDivisionDestino";
			this.rdDivisionDestino.ShowImageInEditorArea = true;
			this.rdDivisionDestino.Size = new System.Drawing.Size(318, 19);
			this.rdDivisionDestino.TabIndex = 111;
			this.rdDivisionDestino.Text = "Seleccione una Opcion";
			this.rdDivisionDestino.ValueMember = "IdDivisionEmpresa";
			this.fKTDivisionEmpresaTEmpresaBindingSource.DataMember = "FK_TDivisionEmpresa_TEmpresa";
			this.fKTDivisionEmpresaTEmpresaBindingSource.DataSource = this.tEmpresaBindingSource;
			this.tEmpresaBindingSource.DataMember = "TEmpresa";
			this.tEmpresaBindingSource.DataSource = this.masterDBACDataSet;
			this.masterDBACDataSet.DataSetName = "masterDBACDataSet";
			this.masterDBACDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.rdEmpresaDestino.AutoCompleteDisplayMember = "RazonSocial";
			this.rdEmpresaDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.rdEmpresaDestino.AutoCompleteValueMember = "idEmpresa";
			this.rdEmpresaDestino.DataSource = this.tEmpresaBindingSource;
			this.rdEmpresaDestino.DisplayMember = "RazonSocial";
			this.rdEmpresaDestino.DropDownAnimationEnabled = true;
			this.rdEmpresaDestino.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rdEmpresaDestino.Location = new Point(132, 189);
			this.rdEmpresaDestino.MaxDropDownItems = 0;
			this.rdEmpresaDestino.Name = "rdEmpresaDestino";
			this.rdEmpresaDestino.ShowImageInEditorArea = true;
			this.rdEmpresaDestino.Size = new System.Drawing.Size(318, 19);
			this.rdEmpresaDestino.TabIndex = 108;
			this.rdEmpresaDestino.Text = "Seleccione una Opcion";
			this.rdEmpresaDestino.ValueMember = "idEmpresa";
			this.label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label15.BackColor = Color.LemonChiffon;
			this.label15.BorderStyle = BorderStyle.FixedSingle;
			this.label15.DataBindings.Add(new Binding("Text", this.tEmpresaBindingSource, "EmpleadoContacto", true));
			this.label15.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label15.Location = new Point(451, 188);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(286, 20);
			this.label15.TabIndex = 115;
			this.lblIdEmp.AutoSize = true;
			this.lblIdEmp.DataBindings.Add(new Binding("Text", this.tEmpleadoBindingSource, "idEmpresa", true));
			this.lblIdEmp.Location = new Point(429, 189);
			this.lblIdEmp.Name = "lblIdEmp";
			this.lblIdEmp.Size = new System.Drawing.Size(16, 20);
			this.lblIdEmp.TabIndex = 118;
			this.lblIdEmp.Text = "0";
			this.tEmpleadoBindingSource.DataMember = "TEmpleado";
			this.tEmpleadoBindingSource.DataSource = this.masterDBACDataSet;
			this.tTarjetaBindingSource.DataMember = "TTarjeta";
			this.tTarjetaBindingSource.DataSource = this.masterDBACDataSet;
			this.label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label18.BackColor = Color.LemonChiffon;
			this.label18.BorderStyle = BorderStyle.FixedSingle;
			this.label18.DataBindings.Add(new Binding("Text", this.tEmpresaBindingSource, "telContactoInterno", true));
			this.label18.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label18.Location = new Point(451, 210);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(286, 19);
			this.label18.TabIndex = 116;
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label17.Location = new Point(57, 169);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 15);
			this.label17.TabIndex = 114;
			this.label17.Text = "Empleado";
			this.rdEmpleadoDestino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.rdEmpleadoDestino.AutoCompleteDisplayMember = "nombre";
			this.rdEmpleadoDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.rdEmpleadoDestino.AutoCompleteValueMember = "idEmpleado";
			this.rdEmpleadoDestino.DataSource = this.tEmpleadoBindingSource;
			this.rdEmpleadoDestino.DisplayMember = "nombre";
			this.rdEmpleadoDestino.DropDownAnimationEnabled = true;
			this.rdEmpleadoDestino.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.rdEmpleadoDestino.Location = new Point(132, 167);
			this.rdEmpleadoDestino.MaxDropDownItems = 0;
			this.rdEmpleadoDestino.Name = "rdEmpleadoDestino";
			this.rdEmpleadoDestino.ShowImageInEditorArea = true;
			this.rdEmpleadoDestino.Size = new System.Drawing.Size(605, 19);
			this.rdEmpleadoDestino.TabIndex = 113;
			this.rdEmpleadoDestino.Text = "Seleccione una Opcion";
			this.rdEmpleadoDestino.ValueMember = "idEmpleado";
			this.rdEmpleadoDestino.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rdEmpleadoDestino_SelectedIndexChanged);
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label16.Location = new Point(23, 213);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(97, 15);
			this.label16.TabIndex = 112;
			this.label16.Text = "Division Destino";
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label14.Location = new Point(16, 191);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 15);
			this.label14.TabIndex = 109;
			this.label14.Text = "Empresa Destino";
			this.label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label13.Location = new Point(454, 58);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(76, 15);
			this.label13.TabIndex = 107;
			this.label13.Text = "Programada";
			this.checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.checkBox1.BackColor = Color.Goldenrod;
			this.checkBox1.Location = new Point(539, 30);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(198, 23);
			this.checkBox1.TabIndex = 106;
			this.checkBox1.Text = "Visita Programada";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
			this.tVisitaProgramadaBindingSource.DataMember = "TVisitaProgramada";
			this.tVisitaProgramadaBindingSource.DataSource = this.masterDBACDataSet;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.Location = new Point(25, 298);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(95, 15);
			this.label12.TabIndex = 104;
			this.label12.Text = "PreProgramada";
			this.txtId2.BackColor = Color.LemonChiffon;
			this.txtId2.BorderStyle = BorderStyle.FixedSingle;
			this.txtId2.Location = new Point(232, 26);
			this.txtId2.Name = "txtId2";
			this.txtId2.Size = new System.Drawing.Size(210, 21);
			this.txtId2.TabIndex = 103;
			this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnCancelar.ForeColor = Color.Maroon;
			this.btnCancelar.Image = Resources.door_out_icon;
			this.btnCancelar.ImageAlign = ContentAlignment.TopCenter;
			this.btnCancelar.Location = new Point(777, 361);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(109, 59);
			this.btnCancelar.TabIndex = 63;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = ContentAlignment.BottomCenter;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
			this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.DarkGreen;
			this.button1.Image = Resources.accept_icon__1_;
			this.button1.ImageAlign = ContentAlignment.TopCenter;
			this.button1.Location = new Point(777, 293);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 62);
			this.button1.TabIndex = 8;
			this.button1.Text = "Aceptar";
			this.button1.TextAlign = ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.Location = new Point(485, 85);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 15);
			this.label9.TabIndex = 101;
			this.label9.Text = "Tarjeta";
			this.label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.Location = new Point(363, 142);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 15);
			this.label11.TabIndex = 96;
			this.label11.Text = "Fecha Salida";
			this.dtFecha2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.dtFecha2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtFecha2.Format = DateTimePickerFormat.Custom;
			this.dtFecha2.Location = new Point(453, 142);
			this.dtFecha2.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtFecha2.MinDate = new DateTime((long)0);
			this.dtFecha2.Name = "dtFecha2";
			this.dtFecha2.NullableValue = new DateTime?(new DateTime(2012, 7, 18, 18, 18, 48, 652));
			this.dtFecha2.NullDate = new DateTime((long)0);
			this.dtFecha2.Size = new System.Drawing.Size(284, 20);
			this.dtFecha2.TabIndex = 95;
			this.dtFecha2.TabStop = false;
			this.dtFecha2.Text = "18/07/2012 18:18:48";
			this.dtFecha2.ThemeName = "Office2010Black";
			this.dtFecha2.Value = new DateTime(2012, 7, 18, 18, 18, 48, 652);
			this.label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.Location = new Point(355, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 15);
			this.label10.TabIndex = 94;
			this.label10.Text = "Fecha Ingreso";
			this.dtFecha1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.dtFecha1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtFecha1.Format = DateTimePickerFormat.Custom;
			this.dtFecha1.Location = new Point(453, 114);
			this.dtFecha1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtFecha1.MinDate = new DateTime((long)0);
			this.dtFecha1.Name = "dtFecha1";
			this.dtFecha1.NullableValue = new DateTime?(new DateTime(2012, 7, 18, 18, 18, 48, 652));
			this.dtFecha1.NullDate = new DateTime((long)0);
			this.dtFecha1.Size = new System.Drawing.Size(284, 20);
			this.dtFecha1.TabIndex = 93;
			this.dtFecha1.TabStop = false;
			this.dtFecha1.Text = "18/07/2012 18:18:48";
			this.dtFecha1.ThemeName = "Office2010Black";
			this.dtFecha1.Value = new DateTime(2012, 7, 18, 18, 18, 48, 652);
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.Location = new Point(30, 237);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 15);
			this.label8.TabIndex = 42;
			this.label8.Text = "Observaciones";
			this.txtObservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.txtObservaciones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.txtObservaciones.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtObservaciones.Location = new Point(132, 233);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(605, 61);
			this.txtObservaciones.TabIndex = 6;
			this.label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.Location = new Point(62, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 15);
			this.label7.TabIndex = 40;
			this.label7.Text = "Teléfonos";
			this.txtTelefonos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.txtTelefonos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.txtTelefonos.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtTelefonos.Location = new Point(131, 139);
			this.txtTelefonos.Name = "txtTelefonos";
			this.txtTelefonos.Size = new System.Drawing.Size(219, 25);
			this.txtTelefonos.TabIndex = 5;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.Location = new Point(65, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 15);
			this.label6.TabIndex = 38;
			this.label6.Text = "Dirección";
			this.txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.txtDireccion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.txtDireccion.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtDireccion.Location = new Point(132, 83);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(318, 25);
			this.txtDireccion.TabIndex = 3;
			this.radioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.radioButton1.Location = new Point(777, 188);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(98, 19);
			this.radioButton1.TabIndex = 29;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Archivo Existente";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Visible = false;
			this.radioButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.radioButton2.Location = new Point(776, 212);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(118, 19);
			this.radioButton2.TabIndex = 30;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Dispositivo de Captura";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Visible = false;
			this.button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.button6.Font = new System.Drawing.Font("Arial Narrow", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.Location = new Point(776, 31);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(110, 24);
			this.button6.TabIndex = 32;
			this.button6.Text = "Borrar Imágen";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new EventHandler(this.button6_Click);
			this.fotoUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.fotoUsuario.BackgroundImage = Resources.personal;
			this.fotoUsuario.BackgroundImageLayout = ImageLayout.Stretch;
			this.fotoUsuario.Location = new Point(779, 57);
			this.fotoUsuario.Name = "fotoUsuario";
			this.fotoUsuario.Size = new System.Drawing.Size(104, 107);
			this.fotoUsuario.TabIndex = 28;
			this.fotoUsuario.TabStop = false;
			this.fotoUsuario.Click += new EventHandler(this.fotoUsuario_Click);
			this.fotoUsuario.DoubleClick += new EventHandler(this.fotoUsuario_DoubleClick);
			this.label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(3, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 15);
			this.label5.TabIndex = 36;
			this.label5.Text = "Empresa de Origen";
			this.txtEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.txtEmpresa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.txtEmpresa.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtEmpresa.Location = new Point(131, 111);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(219, 25);
			this.txtEmpresa.TabIndex = 4;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(11, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 15);
			this.label3.TabIndex = 34;
			this.label3.Text = "Nombre Completo";
			this.txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.txtNombre.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtNombre.Location = new Point(132, 55);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(318, 25);
			this.txtNombre.TabIndex = 2;
			this.comboBox1.DataSource = this.tTipoIdentificacionBindingSource;
			this.comboBox1.DisplayMember = "descripcionIdentificacion";
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(131, 26);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(94, 21);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.ValueMember = "idTipoIdentificacion";
			this.tTipoIdentificacionBindingSource.DataMember = "TTipoIdentificacion";
			this.tTipoIdentificacionBindingSource.DataSource = this.masterDBACDataSet;
			this.label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(44, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Identificación";
			this.fKTEmpleadoTDivisionEmpresaBindingSource.DataMember = "FK_TEmpleado_TDivisionEmpresa";
			this.fKTEmpleadoTDivisionEmpresaBindingSource.DataSource = this.fKTDivisionEmpresaTEmpresaBindingSource;
			this.tTipoIdentificacionTableAdapter.ClearBeforeFill = true;
			this.openFileDialog1.FileName = "openFileDialog1";
			this.tVisitaProgramadaTableAdapter.ClearBeforeFill = true;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.TCargoTableAdapter = null;
			this.tableAdapterManager.TDiasHorarioTableAdapter = null;
			this.tableAdapterManager.TDivisionEmpresaTableAdapter = null;
			this.tableAdapterManager.TEmpleadoTableAdapter = null;
			this.tableAdapterManager.TEmpleadoVehiculoTableAdapter = null;
			this.tableAdapterManager.TEmpresaTableAdapter = this.tEmpresaTableAdapter;
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
			this.tableAdapterManager.TTipoIdentificacionTableAdapter = this.tTipoIdentificacionTableAdapter;
			this.tableAdapterManager.TTipoRegistroTableAdapter = null;
			this.tableAdapterManager.TTipoUsuarioTableAdapter = null;
			this.tableAdapterManager.TUsuarioTableAdapter = null;
			this.tableAdapterManager.TvehiculoParqueoTableAdapter = null;
			this.tableAdapterManager.TVehiculoTableAdapter = null;
			this.tableAdapterManager.TVisitanteTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaLogTableAdapter = null;
			this.tableAdapterManager.TVisitanteVisitaProgramadaTableAdapter = null;
			this.tableAdapterManager.TVisitaProgramadaTableAdapter = this.tVisitaProgramadaTableAdapter;
			this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tEmpresaTableAdapter.ClearBeforeFill = true;
			this.tDivisionEmpresaTableAdapter.ClearBeforeFill = true;
			this.tEmpleadoTableAdapter.ClearBeforeFill = true;
			this.tTarjetaTableAdapter.ClearBeforeFill = true;
			this.fillByNoutilizadaToolStrip.Dock = DockStyle.None;
			ToolStripItemCollection items = this.fillByNoutilizadaToolStrip.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.fillByNoutilizadaToolStripButton };
			items.AddRange(toolStripItemArray);
			this.fillByNoutilizadaToolStrip.Location = new Point(0, 35);
			this.fillByNoutilizadaToolStrip.Name = "fillByNoutilizadaToolStrip";
			this.fillByNoutilizadaToolStrip.Size = new System.Drawing.Size(111, 25);
			this.fillByNoutilizadaToolStrip.TabIndex = 8;
			this.fillByNoutilizadaToolStrip.Text = "fillByNoutilizadaToolStrip";
			this.fillByNoutilizadaToolStrip.Visible = false;
			this.fillByNoutilizadaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.fillByNoutilizadaToolStripButton.Name = "fillByNoutilizadaToolStripButton";
			this.fillByNoutilizadaToolStripButton.Size = new System.Drawing.Size(99, 22);
			this.fillByNoutilizadaToolStripButton.Text = "FillByNoutilizada";
			this.fillByNoutilizadaToolStripButton.Click += new EventHandler(this.fillByNoutilizadaToolStripButton_Click);
			this.fillByVisitasActivasToolStrip.Dock = DockStyle.None;
			ToolStripItemCollection toolStripItemCollections = this.fillByVisitasActivasToolStrip.Items;
			toolStripItemArray = new ToolStripItem[] { this.fillByVisitasActivasToolStripButton };
			toolStripItemCollections.AddRange(toolStripItemArray);
			this.fillByVisitasActivasToolStrip.Location = new Point(0, 35);
			this.fillByVisitasActivasToolStrip.Name = "fillByVisitasActivasToolStrip";
			this.fillByVisitasActivasToolStrip.Size = new System.Drawing.Size(122, 25);
			this.fillByVisitasActivasToolStrip.TabIndex = 9;
			this.fillByVisitasActivasToolStrip.Text = "fillByVisitasActivasToolStrip";
			this.fillByVisitasActivasToolStrip.Visible = false;
			this.fillByVisitasActivasToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.fillByVisitasActivasToolStripButton.Name = "fillByVisitasActivasToolStripButton";
			this.fillByVisitasActivasToolStripButton.Size = new System.Drawing.Size(110, 22);
			this.fillByVisitasActivasToolStripButton.Text = "FillByVisitasActivas";
			this.fillByVisitasActivasToolStripButton.Click += new EventHandler(this.fillByVisitasActivasToolStripButton_Click);
			this.radDesktopAlert1.ContentImage = null;
			this.radDesktopAlert1.PlaySound = false;
			this.radDesktopAlert1.PopupAnimation = true;
			this.radDesktopAlert1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert1.SoundToPlay = null;
			this.radDesktopAlert1.ThemeName = null;
			this.timer1.Interval = 550;
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			this.radDesktopAlert2.ContentImage = null;
			this.radDesktopAlert2.Opacity = 1f;
			this.radDesktopAlert2.PlaySound = false;
			this.radDesktopAlert2.PopupAnimation = true;
			this.radDesktopAlert2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.radDesktopAlert2.SoundToPlay = null;
			this.radDesktopAlert2.ThemeName = null;
			this.cmbProgramada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.cmbProgramada.AutoCompleteDisplayMember = "DescripcionVisita";
			this.cmbProgramada.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cmbProgramada.AutoCompleteValueMember = "idVisitaProgramada";
			this.cmbProgramada.DataSource = this.tVisitaProgramadaBindingSource;
			this.cmbProgramada.DisplayMember = "DescripcionVisita";
			this.cmbProgramada.DropDownAnimationEnabled = true;
			this.cmbProgramada.Enabled = false;
			this.cmbProgramada.Font = new System.Drawing.Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cmbProgramada.Location = new Point(540, 59);
			this.cmbProgramada.MaxDropDownItems = 0;
			this.cmbProgramada.Name = "cmbProgramada";
			this.cmbProgramada.ShowImageInEditorArea = true;
			this.cmbProgramada.Size = new System.Drawing.Size(199, 19);
			this.cmbProgramada.TabIndex = 105;
			this.cmbProgramada.Text = "Seleccione una Opcion";
			this.cmbProgramada.ValueMember = "idVisitaProgramada";
			this.cmbProgramada.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbProgramada_SelectedIndexChanged);
			this.cmbTarjeta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cmbTarjeta.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cmbTarjeta.DataSource = this.tTarjetaBindingSource;
			this.cmbTarjeta.DisplayMember = "numtarjeta";
			this.cmbTarjeta.FormattingEnabled = true;
			this.cmbTarjeta.Location = new Point(540, 85);
			this.cmbTarjeta.Name = "cmbTarjeta";
			this.cmbTarjeta.Size = new System.Drawing.Size(199, 21);
			this.cmbTarjeta.TabIndex = 122;
			this.cmbTarjeta.ValueMember = "idTarjeta";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(936, 522);
			base.Controls.Add(this.fillByNoutilizadaToolStrip);
			base.Controls.Add(this.fillByVisitasActivasToolStrip);
			base.Controls.Add(this.radGroupBox1);
			base.Controls.Add(this.panel2);
			base.KeyPreview = true;
			base.Name = "frmVisitante";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Visitas";
			base.Load += new EventHandler(this.frmVisitante_Load);
			base.KeyPress += new KeyPressEventHandler(this.frmVisitante_KeyPress);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.txtDocIdentidad).EndInit();
			((ISupportInitialize)this.radGroupBox1).EndInit();
			this.radGroupBox1.ResumeLayout(false);
			this.radGroupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.rdDivisionDestino).EndInit();
			((ISupportInitialize)this.fKTDivisionEmpresaTEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.tEmpresaBindingSource).EndInit();
			((ISupportInitialize)this.masterDBACDataSet).EndInit();
			((ISupportInitialize)this.rdEmpresaDestino).EndInit();
			((ISupportInitialize)this.tEmpleadoBindingSource).EndInit();
			((ISupportInitialize)this.tTarjetaBindingSource).EndInit();
			((ISupportInitialize)this.rdEmpleadoDestino).EndInit();
			((ISupportInitialize)this.tVisitaProgramadaBindingSource).EndInit();
			((ISupportInitialize)this.dtFecha2).EndInit();
			((ISupportInitialize)this.dtFecha1).EndInit();
			((ISupportInitialize)this.txtObservaciones).EndInit();
			((ISupportInitialize)this.txtTelefonos).EndInit();
			((ISupportInitialize)this.txtDireccion).EndInit();
			((ISupportInitialize)this.fotoUsuario).EndInit();
			((ISupportInitialize)this.txtEmpresa).EndInit();
			((ISupportInitialize)this.txtNombre).EndInit();
			((ISupportInitialize)this.tTipoIdentificacionBindingSource).EndInit();
			((ISupportInitialize)this.fKTEmpleadoTDivisionEmpresaBindingSource).EndInit();
			this.fillByNoutilizadaToolStrip.ResumeLayout(false);
			this.fillByNoutilizadaToolStrip.PerformLayout();
			this.fillByVisitasActivasToolStrip.ResumeLayout(false);
			this.fillByVisitasActivasToolStrip.PerformLayout();
			((ISupportInitialize)this.cmbProgramada).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void limpiaCampos()
		{
			this.panel1.Visible = false;
			this.lblPreprogramada.BackColor = Color.White;
			this.lblPreprogramada.Text = "...";
			this.txtDocIdentidad.Focus();
			this.txtId2.Text = "";
			this.txtDocIdentidad.Text = "";
			this.fotoUsuario.BackgroundImage = Resources.personal;
			this.txtNombre.Text = "";
			this.txtEmpresa.Text = "";
			this.txtDireccion.Text = "";
			this.txtTelefonos.Text = "";
			this.txtObservaciones.Text = "";
			this.cmbTarjeta.SelectedIndex = -1;
			this.rdDivisionDestino.SelectedIndex = -1;
			this.rdEmpleadoDestino.SelectedIndex = -1;
			this.rdEmpresaDestino.SelectedIndex = -1;
			this.dtFecha1.Value = DateTime.Now;
			this.dtFecha2.Value = DateTime.Now.AddHours(12);
			this.label15.Text = "";
			this.label18.Text = "";
			this.cmbProgramada.SelectedIndex = -1;
		}

		public static AutoCompleteStringCollection LoadAutoIdentificacion(List<TVisitante> ao)
		{
			AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
			foreach (TVisitante tVisitante in ao)
			{
				autoCompleteStringCollections.Add(tVisitante.identificacionVisitante);
			}
			return autoCompleteStringCollections;
		}

		public static AutoCompleteStringCollection LoadAutoIdentificacion(List<TTarjeta> ao)
		{
			AutoCompleteStringCollection autoCompleteStringCollections = new AutoCompleteStringCollection();
			foreach (TTarjeta tTarjetum in ao)
			{
				autoCompleteStringCollections.Add(tTarjetum.numtarjeta);
			}
			return autoCompleteStringCollections;
		}

		private void rdEmpleadoDestino_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			if (this.rdEmpleadoDestino.SelectedIndex >= 0)
			{
				this.tEmpresaTableAdapter.FillByidEmpresa(this.masterDBACDataSet.TEmpresa, Convert.ToInt32(this.lblIdEmp.Text));
				this.rdEmpresaDestino.Rebind();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = false;
			this.tTarjetaTableAdapter.Fill(this.masterDBACDataSet.TTarjeta);
			this.tEmpleadoTableAdapter.Fill(this.masterDBACDataSet.TEmpleado);
			this.tDivisionEmpresaTableAdapter.Fill(this.masterDBACDataSet.TDivisionEmpresa);
			this.tEmpresaTableAdapter.FillByidEmpresa(this.masterDBACDataSet.TEmpresa, -1);
			this.tVisitaProgramadaTableAdapter.FillByVisitasActivas(this.masterDBACDataSet.TVisitaProgramada);
			this.tTipoIdentificacionTableAdapter.Fill(this.masterDBACDataSet.TTipoIdentificacion);
			this.txtDocIdentidad.Focus();
			this.inicio();
		}

		private void txtDocIdentidad_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Utilitys utility = new Utilitys();
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				TVisitante tVisitante = (
					from rg in masterDBACEntity.TVisitante
					where rg.identificacionVisitante == this.txtDocIdentidad.Text
					select rg).FirstOrDefault<TVisitante>();
				this.panel1.Visible = false;
				if (tVisitante != null)
				{
					this.txtId2.Text = tVisitante.identificacionVisitante;
					this.fotoUsuario.BackgroundImage = utility.Bytes2Image(tVisitante.foto);
					this.txtNombre.Text = tVisitante.nombreVisitante;
					this.txtEmpresa.Text = tVisitante.empresa;
					this.txtDireccion.Text = tVisitante.direccion;
					this.txtTelefonos.Text = tVisitante.telefonos;
					this.txtObservaciones.Text = tVisitante.observacionesVisitante;
					this.idVisitanteF = tVisitante.idVisitante;
					this.button1.Focus();
					this.agrego = false;
					this.indice = 2;
					var list = (
						from a in masterDBACEntity.TVisitanteVisitaProgramada
						join b in masterDBACEntity.TEmpleado on a.idEmpleadoAutorizaEntrada equals (int?)b.idEmpleado
						join c in masterDBACEntity.TDivisionEmpresa on b.idDivisionEmpresa equals c.IdDivisionEmpresa
						join d in masterDBACEntity.TEmpresa on c.IdEmpresa equals (int?)d.idEmpresa
						join f in masterDBACEntity.TVisitaProgramada on a.idVisitaProgramada equals f.idVisitaProgramada
						where a.idVisitante == tVisitante.idVisitante && (f.DescripcionVisita != "Entrada Portería") && (a.fechaSalida >= (DateTime?)DateTime.Now)
						select new { Empresa = d.RazonSocial, Division = c.NombreDivision, Empleado = b.nombre, fecha_Lllegada = a.fechaLlegada, fecha_Salida = a.fechaSalida, idvisi = a.idVisitante, idvisitap = a.idVisitaProgramada, idemp = d.idEmpresa, iddivi = c.IdDivisionEmpresa, idemple = b.idEmpleado, descr = f.DescripcionVisita, osv = f.ObservacionesVisita }).ToList();
					try
					{
						if (list.Count <= 0)
						{
							this.panel1.Visible = false;
							this.lblPreprogramada.BackColor = Color.White;
							this.lblPreprogramada.Text = "...";
						}
						else
						{
							this.indice = 3;
							this.panel1.Visible = true;
							this.lblVisitaProgramadaInfo.Text = string.Concat("Visita: ", list[0].descr, "\r\n");
							Label label = this.lblVisitaProgramadaInfo;
							label.Text = string.Concat(label.Text, "Empresa Destino: ", list[0].Empresa, "\r\n");
							Label label1 = this.lblVisitaProgramadaInfo;
							label1.Text = string.Concat(label1.Text, "Empleado: ", list[0].Empleado, "\r\n");
							Label label2 = this.lblVisitaProgramadaInfo;
							label2.Text = string.Concat(label2.Text, "Obsv :", list[0].osv);
							this.radDesktopAlert1.ContentImage = Resources.calendar_icon48;
							this.radDesktopAlert1.CaptionText = "Visita Programada";
							this.radDesktopAlert1.ContentText = "El visitante tiene una vista Programada.\r\nVerifique la informacion adicional en la pantalla.!";
							this.radDesktopAlert1.FixedSize = new System.Drawing.Size(450, 150);
							this.radDesktopAlert1.Show();
							this.lblPreprogramada.BackColor = Color.YellowGreen;
							this.lblPreprogramada.Text = "Tiene una visita Programa";
							this.rdEmpresaDestino.SelectedValue = list[0].idemp;
							this.rdDivisionDestino.SelectedValue = list[0].iddivi;
							this.rdEmpleadoDestino.SelectedValue = list[0].idemple;
							DateTime now = DateTime.Now;
							DateTime? fechaLllegada = list[0].fecha_Lllegada;
							if ((fechaLllegada.HasValue ? Convert.ToInt32(now < fechaLllegada.GetValueOrDefault()) : 0) == 0)
							{
								RadDateTimePicker value = this.dtFecha1;
								fechaLllegada = list[0].fecha_Lllegada;
								value.Value = fechaLllegada.Value;
								RadDateTimePicker radDateTimePicker = this.dtFecha2;
								fechaLllegada = list[0].fecha_Salida;
								radDateTimePicker.Value = fechaLllegada.Value;
							}
							else
							{
								this.dtFecha1.Value = DateTime.Now;
								RadDateTimePicker radDateTimePicker1 = this.dtFecha2;
								now = DateTime.Now;
								radDateTimePicker1.Value = now.AddHours(8);
							}
							this.idVisitanteF = tVisitante.idVisitante;
							this.idvisitaprogramada = list[0].idvisitap;
						}
					}
					catch (Exception exception)
					{
					}
				}
				else if (MessageBox.Show("Desea Agregar un nuevo registro?", "Gestion CAV12", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
				{
					this.agrego = true;
					this.indice = 1;
					this.txtId2.Text = this.txtDocIdentidad.Text;
					this.txtNombre.Focus();
				}
			}
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!(((RadTextBoxControl)sender).Name != "txtNombre" ? true : e.KeyChar != '\r'))
				{
					SendKeys.Send("{TAB}");
				}
				else if (!(((RadTextBoxControl)sender).Name != "txtEmpresa" ? true : e.KeyChar != '\r'))
				{
					SendKeys.Send("{TAB}");
				}
				else if (!(((RadTextBoxControl)sender).Name != "txtTelefonos" ? true : e.KeyChar != '\r'))
				{
					SendKeys.Send("{TAB}");
				}
				else if ((((RadTextBoxControl)sender).Name != "txtDireccion" ? false : e.KeyChar == '\r'))
				{
					SendKeys.Send("{TAB}");
				}
			}
			catch (Exception exception)
			{
			}
		}
	}
}