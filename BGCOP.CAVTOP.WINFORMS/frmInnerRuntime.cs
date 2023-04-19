using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.INNERDEFS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmInnerRuntime : Form
	{
		private IContainer components = null;

		private Panel panel2;

		private Label label1;

		private TextBox textBox1;

		private RadTreeView radTreeView1;

		private Office2010BlackTheme office2010BlackTheme1;

		private ImageList imageList1;

		private Windows7Theme windows7Theme1;

		private Office2010BlackTheme office2010BlackTheme2;

		private TelerikMetroBlueTheme telerikMetroBlueTheme1;

		private System.Windows.Forms.Timer tmrInicio;

		private DesertTheme desertTheme1;

		private List<Inner> vectorInners = new List<Inner>();

		private bool _termino = false;

		private int _innerActual = 0;

		private bool salir = false;

		private int qtyB = 14;

		private byte Origem = 0;

		private byte Complemento = 0;

		private StringBuilder Cartao = new StringBuilder();

		private byte Dia = 0;

		private byte Mes = 0;

		private byte Ano = 0;

		private byte Hora = 0;

		private byte Minuto = 0;

		private byte Segundo = 0;

		private string strCartao = string.Empty;

		private Thread molinete1;

		private Bilhete evento;

		public frmInnerRuntime()
		{
			this.InitializeComponent();
		}

		public void AppendTextBox(TextBox txtB, string value)
		{
			object[] now;
			if (!this._termino)
			{
				if (!txtB.InvokeRequired)
				{
					now = new object[] { "[", DateTime.Now, "]\r\n ", value, "\r\n" };
					txtB.AppendText(string.Concat(now));
					txtB.ScrollToCaret();
				}
				else
				{
					Action<TextBox, string> action = new Action<TextBox, string>(this.AppendTextBox);
					now = new object[] { txtB, value };
					base.Invoke(action, now);
				}
			}
		}

		public void changeIconTree(RadTreeView rt, int nodeIndex, int ic)
		{
			if (!this._termino)
			{
				if (!rt.InvokeRequired)
				{
					this.rfRadtre();
					Application.DoEvents();
				}
				else
				{
					try
					{
						Action<RadTreeView, int, int> action = new Action<RadTreeView, int, int>(this.changeIconTree);
						object[] objArray = new object[] { rt, nodeIndex, ic };
						base.Invoke(action, objArray);
					}
					catch (Exception exception)
					{
					}
				}
			}
		}

		public void changeProgress()
		{
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmInnerRuntime_FormClosing(object sender, FormClosingEventArgs e)
		{
			this._termino = true;
			try
			{
				this.molinete1.Interrupt();
				this.molinete1.Join(2500);
				this.molinete1.Abort();
				this._termino = true;
			}
			catch (Exception exception)
			{
			}
			while (!this.salir)
			{
				this._termino = true;
				Application.DoEvents();
			}
		}

		private void frmInnerRuntime_Load(object sender, EventArgs e)
		{
			this.tmrInicio.Enabled = true;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmInnerRuntime));
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.textBox1 = new TextBox();
			this.radTreeView1 = new RadTreeView();
			this.imageList1 = new ImageList(this.components);
			this.office2010BlackTheme1 = new Office2010BlackTheme();
			this.windows7Theme1 = new Windows7Theme();
			this.office2010BlackTheme2 = new Office2010BlackTheme();
			this.telerikMetroBlueTheme1 = new TelerikMetroBlueTheme();
			this.tmrInicio = new System.Windows.Forms.Timer(this.components);
			this.desertTheme1 = new DesertTheme();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.radTreeView1).BeginInit();
			base.SuspendLayout();
			this.panel2.BackColor = Color.SteelBlue;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(256, 53);
			this.panel2.TabIndex = 57;
			this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(13, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Visualizador de Inner's";
			this.textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.textBox1.BackColor = Color.White;
			this.textBox1.BorderStyle = BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = Color.Navy;
			this.textBox1.Location = new Point(0, 324);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(256, 191);
			this.textBox1.TabIndex = 58;
			this.radTreeView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.radTreeView1.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.radTreeView1.ImageList = this.imageList1;
			this.radTreeView1.Location = new Point(0, 55);
			this.radTreeView1.Name = "radTreeView1";
			this.radTreeView1.Size = new System.Drawing.Size(256, 264);
			this.radTreeView1.SpacingBetweenNodes = -1;
			this.radTreeView1.TabIndex = 59;
			this.radTreeView1.Text = "radTreeView1";
			this.radTreeView1.ThemeName = "TelerikMetroBlue";
			this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Action_Close.png");
			this.imageList1.Images.SetKeyName(1, "Action_Grant.png");
			this.imageList1.Images.SetKeyName(2, "1335051084_dialog-close.png");
			this.imageList1.Images.SetKeyName(3, "1335051089_dialog-apply.png");
			this.tmrInicio.Interval = 800;
			this.tmrInicio.Tick += new EventHandler(this.tmrInicio_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.DimGray;
			base.ClientSize = new System.Drawing.Size(256, 517);
			base.ControlBox = false;
			base.Controls.Add(this.radTreeView1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.panel2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmInnerRuntime";
			this.Text = "Inner's";
			base.FormClosing += new FormClosingEventHandler(this.frmInnerRuntime_FormClosing);
			base.Load += new EventHandler(this.frmInnerRuntime_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.radTreeView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void PersisteMarcacion(string card, string inerN)
		{
			(new Vtarjetas()).GuardaMarcacionTarjeta(card, inerN);
		}

		public void ProcesoInners()
		{
			int numero;
			int num = 0;
			TimeSpan now = new TimeSpan();
			EasyInner.DefinirTipoConexao(2);
			EasyInner.FecharPortaComunicacao();
			num = EasyInner.AbrirPortaComunicacao(3570);
			Thread.Sleep(500);
			if (num == 0)
			{
				num = EasyInner.Ping(1);
				num = EasyInner.Ping(1);
				num = EasyInner.Ping(1);
				num = EasyInner.Ping(1);
				num = EasyInner.Ping(1);
				TareasInner tareasInner = new TareasInner();
				this.AppendTextBox(this.textBox1, "Comunicacion con el puerto Exitosa!");
				while (!this._termino)
				{
					int estado = this.vectorInners[this._innerActual].Estado;
					switch (estado)
					{
						case 1:
						{
							num = EasyInner.Ping(this.vectorInners[this._innerActual].Numero);
							Thread.Sleep(10);
							if (num != 0)
							{
								this.vectorInners[this._innerActual].Estado = 1;
								this.vectorInners[this._innerActual].isOnline = false;
								this.changeIconTree(this.radTreeView1, this._innerActual, 0);
							}
							else
							{
								this.vectorInners[this._innerActual].Estado = 2;
								this.vectorInners[this._innerActual].isOnline = true;
								this.changeIconTree(this.radTreeView1, this._innerActual, 1);
							}
							goto case 11;
						}
						case 2:
						{
							EasyInner.ConfigurarInnerOffLine();
							Thread.Sleep(3);
							EasyInner.DefinirQuantidadeDigitosCartao((byte)this.qtyB);
							Thread.Sleep(3);
							num = EasyInner.DefinirMensagemEntradaOffLine(1, "Entrada OK");
							Thread.Sleep(3);
							num = EasyInner.DefinirMensagemSaidaOffLine(1, "Saida OK");
							Thread.Sleep(3);
							num = EasyInner.DefinirMensagemPadraoOffLine(1, "*Fuera de Linea*");
							Thread.Sleep(3);
							if (!this.vectorInners[this._innerActual].isInnerNet)
							{
								EasyInner.ConfigurarAcionamento2(0, 3);
							}
							else
							{
								EasyInner.ConfigurarAcionamento2(1, 4);
							}
							num = EasyInner.EnviarMensagensOffLine(this.vectorInners[this._innerActual].Numero);
							EasyInner.ConfigurarTipoLeitor(2);
							EasyInner.ReceberDataHoraDadosOnLine(1);
							EasyInner.ConfigurarLeitor1(3);
							EasyInner.ConfigurarLeitor2(3);
							EasyInner.ConfigurarAcionamento1(9, 5);
							num = EasyInner.DefinirTipoListaAcesso(0);
							num = EasyInner.DefinirFuncaoDefaultLeitoresProximidade(12);
							if (EasyInner.EnviarConfiguracoes((int)this.vectorInners[this._innerActual].Numero) != 0)
							{
								this.AppendTextBox(this.textBox1, "Error en Ajuste Inner offline");
								Inner item = this.vectorInners[this._innerActual];
								item.CountFails = item.CountFails + 1;
								if (this.vectorInners[this._innerActual].CountFails > 5)
								{
									this.vectorInners[this._innerActual].Estado = 1;
									goto case 11;
								}
							}
							else
							{
								this.AppendTextBox(this.textBox1, "Ajuste Inner offline OK ");
								this.vectorInners[this._innerActual].Estado = 3;
							}
							goto case 11;
						}
						case 3:
						{
							this.AppendTextBox(this.textBox1, string.Concat("Inner: ", this._innerActual.ToString(), " Verificando Eventos en Inner"));
							this.evento = new Bilhete()
							{
								Ano = 0,
								Cartao = null
							};
							this.evento.Cartao = new StringBuilder();
							this.evento.Dia = 0;
							this.evento.Hora = 0;
							this.evento.Mes = 0;
							this.evento.Minuto = 0;
							this.evento.Tipo = 0;
							if (EasyInner.ColetarBilhete(this.vectorInners[this._innerActual].Numero, ref this.evento.Tipo, ref this.evento.Dia, ref this.evento.Mes, ref this.evento.Ano, ref this.evento.Hora, ref this.evento.Minuto, this.evento.Cartao) != 0)
							{
								TextBox textBox = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox, string.Concat("Inner: ", numero.ToString(CultureInfo.InvariantCulture), " Fin de eventos del Inner"));
								this.vectorInners[this._innerActual].Estado = 4;
							}
							else
							{
								this.AppendTextBox(this.textBox1, string.Concat("Inner: ", this._innerActual.ToString(), " evento : ", this.evento.Cartao.ToString()));
								if (this.VerificaTarjeta(this.evento.Cartao.ToString()))
								{
									string str = this.evento.Cartao.ToString();
									numero = this.vectorInners[this._innerActual].Numero;
									this.PersisteMarcacion(str, numero.ToString(CultureInfo.InvariantCulture));
								}
							}
							goto case 11;
						}
						case 4:
						{
							EasyInner.HabilitarMudancaOnLineOffLine(1, 3);
							EasyInner.DefinirMensagemPadraoMudancaOffLine(1, "*Fuera de Linea*");
							EasyInner.DefinirMensagemPadraoMudancaOnLine(1, "   *En Linea*   ");
							EasyInner.DefinirEntradasMudancaOnLine(7);
							if (EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(this.vectorInners[this._innerActual].Numero) != 0)
							{
								TextBox textBox1 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox1, string.Concat("Error Inner: ", numero.ToString(CultureInfo.InvariantCulture), " Conf Automatica on-off"));
								Inner countFails = this.vectorInners[this._innerActual];
								countFails.CountFails = countFails.CountFails + 1;
								if (this.vectorInners[this._innerActual].CountFails > 5)
								{
									this.vectorInners[this._innerActual].Estado = 1;
									goto case 11;
								}
							}
							else
							{
								TextBox textBox2 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox2, string.Concat("Inner: ", numero.ToString(CultureInfo.InvariantCulture), " Conf Automatica on-off OK"));
								this.vectorInners[this._innerActual].Estado = 5;
							}
							goto case 11;
						}
						case 5:
						{
							TextBox textBox3 = this.textBox1;
							numero = this.vectorInners[this._innerActual].Numero;
							this.AppendTextBox(textBox3, string.Concat("Configuracion Online! Inner [", numero.ToString(CultureInfo.InvariantCulture), "]"));
							EasyInner.ConfigurarInnerOnLine();
							EasyInner.DefinirQuantidadeDigitosCartao((byte)this.qtyB);
							EasyInner.ConfigurarTipoLeitor(2);
							EasyInner.ReceberDataHoraDadosOnLine(1);
							if (EasyInner.EnviarConfiguracoes(this.vectorInners[this._innerActual].Numero) != 0)
							{
								TextBox textBox4 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox4, string.Concat("Inner: ", numero.ToString(), " conf Online FAIL"));
								Inner inner = this.vectorInners[this._innerActual];
								inner.CountFails = inner.CountFails + 1;
								if (this.vectorInners[this._innerActual].CountFails > 5)
								{
									this.vectorInners[this._innerActual].Estado = 1;
									goto case 11;
								}
							}
							else
							{
								TextBox textBox5 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox5, string.Concat("Inner: ", numero.ToString(CultureInfo.InvariantCulture), " conf Online OK"));
								this.vectorInners[this._innerActual].Estado = 6;
							}
							goto case 11;
						}
						case 6:
						{
							TextBox textBox6 = this.textBox1;
							numero = this.vectorInners[this._innerActual].Numero;
							this.AppendTextBox(textBox6, string.Concat("Estado en linea! inner [", numero.ToString(CultureInfo.InvariantCulture), "]"));
							if (EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 1, "   *En Linea*   ") != 0)
							{
								TextBox textBox7 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox7, string.Concat("Inner: ", numero.ToString(CultureInfo.InvariantCulture), " msg online FAIL"));
								Inner item1 = this.vectorInners[this._innerActual];
								item1.CountFails = item1.CountFails + 1;
								if (this.vectorInners[this._innerActual].CountFails > 5)
								{
									this.vectorInners[this._innerActual].Estado = 1;
									goto case 11;
								}
							}
							else
							{
								this.vectorInners[this._innerActual].Estado = 7;
							}
							goto case 11;
						}
						case 7:
						{
							if (!this.vectorInners[this._innerActual].paso)
							{
								this.vectorInners[this._innerActual].paso = true;
								TextBox textBox8 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox8, string.Concat("Conf Entradas en linea! Inner [", numero.ToString(CultureInfo.InvariantCulture), "]"));
							}
							if (EasyInner.EnviarFormasEntradasOnLine(this.vectorInners[this._innerActual].Numero, (byte)this.qtyB, 0, 2, 15, 17) != 0)
							{
								TextBox textBox9 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox9, string.Concat("Inner: ", numero.ToString(CultureInfo.InvariantCulture), " Conf Entrada online FAIL"));
								Inner countFails1 = this.vectorInners[this._innerActual];
								countFails1.CountFails = countFails1.CountFails + 1;
								if (this.vectorInners[this._innerActual].CountFails > 5)
								{
									this.vectorInners[this._innerActual].Estado = 1;
									goto case 11;
								}
							}
							else
							{
								this.vectorInners[this._innerActual].Estado = 8;
							}
							goto case 11;
						}
						case 8:
						{
							if (!this.vectorInners[this._innerActual].PasoTarjeta)
							{
								TextBox textBox10 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox10, string.Concat("Esperando Tarjeta! inner [", numero.ToString(CultureInfo.InvariantCulture), "]"));
								this.vectorInners[this._innerActual].PasoTarjeta = true;
							}
							this.Cartao = new StringBuilder();
							if (EasyInner.ReceberDadosOnLine(this.vectorInners[this._innerActual].Numero, ref this.Origem, ref this.Complemento, this.Cartao, ref this.Dia, ref this.Mes, ref this.Ano, ref this.Hora, ref this.Minuto, ref this.Segundo) != 0)
							{
								this.vectorInners[this._innerActual].Estado = 9;
							}
							else
							{
								this.strCartao = "";
								this.vectorInners[this._innerActual].PasoTarjeta = false;
								for (int i = 0; i < this.qtyB; i++)
								{
									frmInnerRuntime _frmInnerRuntime = this;
									_frmInnerRuntime.strCartao = string.Concat(_frmInnerRuntime.strCartao, Convert.ToString(Convert.ToChar(this.Cartao[i])));
								}
								this.strCartao = string.Format("{0:X}", Convert.ToInt64(this.strCartao));
								this.strCartao = this.strCartao.ToLower();
								TextBox textBox11 = this.textBox1;
								string[] strArrays = new string[20];
								strArrays[0] = "Datos en linea Inner: ";
								numero = this.vectorInners[this._innerActual].Numero;
								strArrays[1] = numero.ToString();
								strArrays[2] = " \r\nOrigen: ";
								strArrays[3] = this.Origem.ToString();
								strArrays[4] = " \r\nComplemento: ";
								strArrays[5] = this.Complemento.ToString();
								strArrays[6] = " \r\n CR: ";
								strArrays[7] = this.strCartao;
								strArrays[8] = " \r\nData: ";
								strArrays[9] = this.Dia.ToString();
								strArrays[10] = "/";
								strArrays[11] = this.Mes.ToString();
								strArrays[12] = "/";
								strArrays[13] = this.Ano.ToString();
								strArrays[14] = " ";
								strArrays[15] = this.Hora.ToString();
								strArrays[16] = ":";
								strArrays[17] = this.Minuto.ToString();
								strArrays[18] = ":";
								strArrays[19] = this.Segundo.ToString();
								this.AppendTextBox(textBox11, string.Concat(strArrays));
								Empleados empleado = new Empleados();
								string str1 = "";
								if (this.VerificaTarjeta(this.strCartao))
								{
									if (EasyInner.AcionarBipCurto(this.vectorInners[this._innerActual].Numero) == 0)
									{
										this.vectorInners[this._innerActual].CARTAOB = this.strCartao;
										try
										{
											str1 = empleado.consultarXtarjeta(this.strCartao).nombre;
											str1 = str1.Remove(15);
										}
										catch (Exception exception)
										{
										}
										if (EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 0, string.Concat(str1, "         Siga        ")) == 0)
										{
											this.vectorInners[this._innerActual].TimerMsgOnline = DateTime.Now;
											this.vectorInners[this._innerActual].renewMsgOnline = true;
											if (!this.vectorInners[this._innerActual].isInnerNet)
											{
												EasyInner.LiberarCatracaDoisSentidos(this.vectorInners[this._innerActual].Numero);
											}
											else
											{
												EasyInner.AcionarRele2(this.vectorInners[this._innerActual].Numero);
											}
											if (!this.vectorInners[this._innerActual].isInnerNet)
											{
												this.vectorInners[this._innerActual].TimerAccess = DateTime.Now;
												this.vectorInners[this._innerActual].Estado = 12;
											}
											else
											{
												this.vectorInners[this._innerActual].Estado = 9;
												string cARTAOB = this.vectorInners[this._innerActual].CARTAOB;
												numero = this.vectorInners[this._innerActual].Numero;
												this.PersisteMarcacion(cARTAOB, numero.ToString(CultureInfo.InvariantCulture));
											}
										}
									}
								}
								else if (EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 0, "      Acceso          negado!     ") == 0)
								{
									num = EasyInner.AcionarBipLongo(this.vectorInners[this._innerActual].Numero);
									this.vectorInners[this._innerActual].isMsgNeg = true;
									this.vectorInners[this._innerActual].TimerMsgNeg = DateTime.Now;
									this.vectorInners[this._innerActual].Estado = 9;
								}
							}
							goto case 11;
						}
						case 9:
						{
							now = DateTime.Now - this.vectorInners[this._innerActual].TimerPingOnline;
							if (now.Seconds < 3)
							{
								now = DateTime.Now - this.vectorInners[this._innerActual].TimerMsgNeg;
								if ((!this.vectorInners[this._innerActual].isMsgNeg ? true : now.Seconds <= 1))
								{
									now = DateTime.Now - this.vectorInners[this._innerActual].TimerMsgOnline;
									if ((!this.vectorInners[this._innerActual].renewMsgOnline ? true : now.Seconds <= 2))
									{
										this.vectorInners[this._innerActual].Estado = 8;
									}
									else
									{
										this.vectorInners[this._innerActual].renewMsgOnline = false;
										EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 1, "   *En Linea*   ");
										this.vectorInners[this._innerActual].Estado = 36;
									}
								}
								else
								{
									this.vectorInners[this._innerActual].isMsgNeg = false;
									EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 1, "   *En Linea*   ");
									this.vectorInners[this._innerActual].Estado = 36;
								}
							}
							else
							{
								this.vectorInners[this._innerActual].TimerPingOnline = DateTime.Now;
								if (EasyInner.PingOnLine(this.vectorInners[this._innerActual].Numero) != 0)
								{
									this.vectorInners[this._innerActual].Estado = 1;
									goto case 11;
								}
								else
								{
									this.vectorInners[this._innerActual].Estado = 36;
								}
							}
							goto case 11;
						}
						case 10:
						case 11:
						{
							frmInnerRuntime _frmInnerRuntime1 = this;
							_frmInnerRuntime1._innerActual++;
							if (this._innerActual > this.vectorInners.Count - 1)
							{
								this._innerActual = 0;
							}
							while (true)
							{
								if (this.vectorInners[this._innerActual].isActive)
								{
									break;
								}
								this._innerActual++;
								if (this._innerActual > this.vectorInners.Count - 1)
								{
									this._innerActual = 0;
								}
							}
							Application.DoEvents();
							continue;
						}
						case 12:
						{
							if (!this.vectorInners[this._innerActual].PasoMSGmolinete)
							{
								TextBox textBox12 = this.textBox1;
								numero = this.vectorInners[this._innerActual].Numero;
								this.AppendTextBox(textBox12, string.Concat("Verificando Giro del Molinete! inner[", numero.ToString(CultureInfo.InvariantCulture), "]"));
								this.vectorInners[this._innerActual].PasoMSGmolinete = true;
							}
							if (EasyInner.ReceberDadosOnLine(this.vectorInners[this._innerActual].Numero, ref this.Origem, ref this.Complemento, this.Cartao, ref this.Dia, ref this.Mes, ref this.Ano, ref this.Hora, ref this.Minuto, ref this.Segundo) != 0)
							{
								now = DateTime.Now - this.vectorInners[this._innerActual].TimerAccess;
								if (now.Seconds > 8)
								{
									TextBox textBox13 = this.textBox1;
									numero = this.vectorInners[this._innerActual].Numero;
									this.AppendTextBox(textBox13, string.Concat("Se vencio el tiempo de acceso! inner [", numero.ToString(CultureInfo.InvariantCulture), "]"));
									EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 1, "   *En Linea*   ");
									this.vectorInners[this._innerActual].PasoMSGmolinete = false;
									this.vectorInners[this._innerActual].Estado = 9;
								}
							}
							else if (this.Origem == 5)
							{
								this.AppendTextBox(this.textBox1, "No ha girado el Molinete!");
								EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 1, "   *En Linea*   ");
								this.vectorInners[this._innerActual].PasoMSGmolinete = false;
								this.vectorInners[this._innerActual].Estado = 9;
							}
							else if (this.Origem == 6)
							{
								EasyInner.EnviarMensagemPadraoOnLine(this.vectorInners[this._innerActual].Numero, 1, "   *En Linea*   ");
								this.AppendTextBox(this.textBox1, "Paso el molinete!");
								string cARTAOB1 = this.vectorInners[this._innerActual].CARTAOB;
								numero = this.vectorInners[this._innerActual].Numero;
								this.PersisteMarcacion(cARTAOB1, numero.ToString(CultureInfo.InvariantCulture));
								this.vectorInners[this._innerActual].PasoMSGmolinete = false;
								this.vectorInners[this._innerActual].Estado = 9;
							}
							goto case 11;
						}
						default:
						{
							if (estado == 36)
							{
								TInnerAccion tInnerAccion = tareasInner.ObtenerUltimaTarea(this.vectorInners[this._innerActual].Numero);
								if (tInnerAccion != null)
								{
									string str2 = tInnerAccion.CodigoAccion.Trim();
									if (str2 != null)
									{
										if (str2 == "OpenS")
										{
											EasyInner.AcionarRele2(this.vectorInners[this._innerActual].Numero);
											tareasInner.CumplirTarea(tInnerAccion);
											this.AppendTextBox(this.textBox1, "Activando salida del Parquedero de forma manual");
										}
									}
								}
								this.vectorInners[this._innerActual].Estado = 7;
								goto case 11;
							}
							else
							{
								goto case 11;
							}
						}
					}
				}
				this.salir = true;
				this.AppendTextBox(this.textBox1, "Proceso Finalizado!");
			}
			else
			{
				this.AppendTextBox(this.textBox1, "Comunicacion con el puerto [3570] ERROR!");
			}
		}

		public void rfRadtre()
		{
			int num = 0;
			foreach (Inner vectorInner in this.vectorInners)
			{
				if (!vectorInner.isOnline)
				{
					if (!vectorInner.isActive)
					{
						vectorInner.nombre2 = string.Concat(vectorInner.nombre, " *Inactivo!*");
					}
					else
					{
						vectorInner.nombre2 = string.Concat(vectorInner.nombre, " fuera de línea");
					}
					this.radTreeView1.Nodes[num].ImageIndex = 0;
				}
				else
				{
					vectorInner.nombre2 = string.Concat(vectorInner.nombre, " En línea");
					this.radTreeView1.Nodes[num].ImageIndex = 1;
				}
				num++;
			}
		}

		private void tmrInicio_Tick(object sender, EventArgs e)
		{
			this.tmrInicio.Enabled = false;
			foreach (Tinner tinner in (new Inners()).listarTodos())
			{
				Inner inner = new Inner()
				{
					Numero = tinner.CodeInner.Value,
					nombre = tinner.NombreInner.ToString(CultureInfo.InvariantCulture),
					nombre2 = string.Concat(tinner.NombreInner.ToString(CultureInfo.InvariantCulture), " Fuera de Linea"),
					isActive = (!tinner.esActivo.HasValue ? false : tinner.esActivo.Value),
					isInnerNet = (!tinner.esinnerNet.HasValue ? false : tinner.esinnerNet.Value),
					PuertoTCP = tinner.puertoCom.Value,
					Estado = 1,
					sm = "|"
				};
				this.vectorInners.Add(inner);
			}
			this.radTreeView1.DataSource = this.vectorInners;
			this.radTreeView1.DisplayMember = "nombre2";
			this.radTreeView1.ValueMember = "Numero";
			this.rfRadtre();
			this._termino = false;
			this.molinete1 = new Thread(new ThreadStart(this.ProcesoInners));
			this.molinete1.Start();
		}

		public bool VerificaTarjeta(string card)
		{
			return (new Vtarjetas()).VerificaTarjetaBussiness(card);
		}
	}
}