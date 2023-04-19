using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BGCOP.CAVTOP.INNERDEFS
{
	public class ManageInners
	{
		public List<Inner> ListaInner;

		public bool activa = false;

		public ManageInners()
		{
		}

		public void AddInner(int numInner)
		{
			Inner inner = new Inner()
			{
				Biometrico = false,
				Catraca = true,
				EstadoAtual = Enumeradores.EstadosInner.ESTADO_CONECTAR,
				Numero = numInner,
				QtdDigitos = 14,
				style = "background-color: RED"
			};
			foreach (Inner listaInner in this.ListaInner)
			{
				if (listaInner.Numero == inner.Numero)
				{
					InnerErrorEventsArgs innerErrorEventsArg = new InnerErrorEventsArgs()
					{
						MensajeError = "El dispositivo ya se encuentra en el sistema!",
						SourceError = "inner"
					};
					if (this.ErrInner != null)
					{
						this.ErrInner(this, innerErrorEventsArg);
					}
					return;
				}
			}
			this.ListaInner.Add(inner);
		}

		private static void ESTADO_COLETAR_BILHETES(Inner InnerAtual)
		{
			try
			{
				Bilhete bilhete = new Bilhete()
				{
					Ano = 0,
					Cartao = null
				};
				bilhete.Cartao = new StringBuilder();
				bilhete.Dia = 0;
				bilhete.Hora = 0;
				bilhete.Mes = 0;
				bilhete.Minuto = 0;
				bilhete.Tipo = 0;
				string str = "";
				int i = 0;
				InnerAtual.CountPingOnline = 0;
				InnerAtual.CountPingFail = 0;
				InnerAtual.CountRepeatPingOnline = 0;
				if (EasyInner.ColetarBilhete(InnerAtual.Numero, ref bilhete.Tipo, ref bilhete.Dia, ref bilhete.Mes, ref bilhete.Ano, ref bilhete.Hora, ref bilhete.Minuto, bilhete.Cartao) == 0)
				{
					str = "";
					for (i = 0; i < 16; i++)
					{
						str = string.Concat(str, Convert.ToString(Convert.ToChar(bilhete.Cartao[i])));
					}
					InnerAtual.TempoColeta = (int)EasyInner.RetornarSegundosSys() + 2;
				}
				else if (EasyInner.RetornarSegundosSys() >= (long)InnerAtual.TempoColeta)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_CFG_ONLINE;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_CONECTAR(Inner InnerAtual)
		{
			try
			{
				InnerAtual.CountPingOnline = 0;
				if (EasyInner.Ping(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_CFG_OFFLINE;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_CONFIGURAR_ENTRADAS_ONLINE(Inner InnerAtual)
		{
			try
			{
				int num = -1;
				num = (!InnerAtual.Biometrico ? EasyInner.EnviarFormasEntradasOnLine(InnerAtual.Numero, (byte)InnerAtual.QtdDigitos, 1, 7, 15, 17) : EasyInner.EnviarFormasEntradasOnLine(InnerAtual.Numero, (byte)InnerAtual.QtdDigitos, 1, 12, 15, 17));
				if (num == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_CONFIGURAR_MUDANCAS_ONLINE_OFFLINE(Inner InnerAtual)
		{
			try
			{
				EasyInner.ConfigurarInnerOffLine();
				EasyInner.DefinirEntradasMudancaOnLine(12);
				if (!InnerAtual.Biometrico)
				{
					EasyInner.DefinirEntradasMudancaOffLine(1, 1, 0, 0);
				}
				else
				{
					EasyInner.DefinirEntradasMudancaOffLineComBiometria(1, 1, 0, 1, 1);
				}
				EasyInner.DefinirMensagemPadraoMudancaOffLine(1, "Modo Offline");
				EasyInner.DefinirMensagemPadraoMudancaOnLine(1, "Modo Online");
				EasyInner.HabilitarMudancaOnLineOffLine(2, 8);
				if (EasyInner.EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_COLETAR_BILHETES;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_ENVIAR_BIPCURTO(Inner InnerAtual)
		{
			try
			{
				if (EasyInner.AcionarBipCurto(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_OK;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_ENVIAR_CFG_OFFLINE(Inner InnerAtual)
		{
			try
			{
				InnerAtual.CountPingOnline = 0;
				EasyInner.ConfigurarInnerOffLine();
				EasyInner.DefinirQuantidadeDigitosCartao((byte)InnerAtual.QtdDigitos);
				EasyInner.ReceberDataHoraDadosOnLine(1);
				EasyInner.HabilitarTeclado(1, 0);
				EasyInner.ConfigurarTipoLeitor(2);
				EasyInner.ConfigurarLeitor1(3);
				EasyInner.ConfigurarLeitor2(3);
				EasyInner.ConfigurarAcionamento1(1, 5);
				EasyInner.ConfigurarAcionamento2(1, 5);
				if (EasyInner.EnviarConfiguracoes(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_CONFIGURAR_MUDANCAS_ONLINE_OFFLINE;
					InnerAtual.TempoColeta = (int)EasyInner.RetornarSegundosSys() + 2;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_ENVIAR_CFG_ONLINE(Inner InnerAtual)
		{
			try
			{
				EasyInner.ConfigurarInnerOnLine();
				EasyInner.DefinirQuantidadeDigitosCartao((byte)InnerAtual.QtdDigitos);
				EasyInner.ConfigurarTipoLeitor(2);
				EasyInner.ReceberDataHoraDadosOnLine(1);
				EasyInner.ConfigurarLeitor2(3);
				EasyInner.ConfigurarAcionamento1(1, 5);
				EasyInner.ConfigurarAcionamento2(1, 5);
				if (EasyInner.EnviarConfiguracoes(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_DATA_HORA;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_ENVIAR_DATA_HORA(Inner InnerAtual)
		{
			try
			{
				DateTime now = DateTime.Now;
				if (EasyInner.EnviarRelogio(InnerAtual.Numero, (byte)now.Day, (byte)now.Month, Convert.ToByte(now.Year.ToString().Substring(2, 2)), (byte)now.Hour, (byte)now.Minute, (byte)now.Second) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_PADRAO;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_ENVIAR_MSG_OK(Inner InnerAtual)
		{
			try
			{
				int num = -1;
				if (!InnerAtual.FlagMensagemTemporizada)
				{
					if (!InnerAtual.Catraca)
					{
						num = EasyInner.EnviarMensagemPadraoOnLine(InnerAtual.Numero, 0, "Acesso Liberado");
						InnerAtual.FlagMensagemTemporizada = true;
					}
					else
					{
						num = EasyInner.EnviarMensagemPadraoOnLine(InnerAtual.Numero, 0, "Passe na Catraca");
						InnerAtual.FlagMensagemTemporizada = true;
					}
				}
				TimeSpan now = DateTime.Now - InnerAtual.Temporizador;
				if (InnerAtual.Catraca)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_LIBERA_GIRO_CATRACA;
					InnerAtual.FlagMensagemTemporizada = false;
				}
				else if (now.Seconds > 2)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_PADRAO;
					InnerAtual.FlagMensagemTemporizada = false;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_ENVIAR_MSG_PADRAO(Inner InnerAtual)
		{
			try
			{
				if (EasyInner.EnviarMensagemPadraoOnLine(InnerAtual.Numero, 1, "Modo Online") == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_CONFIGURAR_ENTRADAS_ONLINE;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_LIBERA_GIRO_CATRACA(Inner InnerAtual)
		{
			try
			{
				if (EasyInner.LiberarCatracaDoisSentidos(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_MONITORA_GIRO_CATRACA;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_MONITORA_GIRO_CATRACA(Inner InnerAtual)
		{
			try
			{
				byte num = 0;
				byte num1 = 0;
				StringBuilder stringBuilder = new StringBuilder();
				byte num2 = 0;
				byte num3 = 0;
				byte num4 = 0;
				byte num5 = 0;
				byte num6 = 0;
				byte num7 = 0;
				string empty = string.Empty;
				InnerAtual.CountPingOnline = 0;
				if (EasyInner.ReceberDadosOnLine(InnerAtual.Numero, ref num, ref num1, stringBuilder, ref num2, ref num3, ref num4, ref num5, ref num6, ref num7) == 0)
				{
					if (num != 5)
					{
						if (num == 6)
						{
						}
					}
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_PADRAO;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private void ESTADO_POLLING(Inner InnerAtual)
		{
			try
			{
				byte num = 0;
				byte num1 = 0;
				StringBuilder stringBuilder = new StringBuilder();
				byte num2 = 0;
				byte num3 = 0;
				byte num4 = 0;
				byte num5 = 0;
				byte num6 = 0;
				byte num7 = 0;
				string empty = string.Empty;
				int num8 = -1;
				int i = 0;
				num8 = EasyInner.ReceberDadosOnLine(InnerAtual.Numero, ref num, ref num1, stringBuilder, ref num2, ref num3, ref num4, ref num5, ref num6, ref num7);
				InnerAtual.Temporizador = DateTime.Now;
				if (num8 == 0)
				{
					if ((num1 == 5 || num1 == 6 || num1 == 65 ? false : num1 != 42))
					{
						InnerAtual.CountPingOnline = 0;
						empty = "";
						for (i = 0; i < stringBuilder.Length; i++)
						{
							empty = string.Concat(empty, Convert.ToString(Convert.ToChar(stringBuilder[i])));
						}
						InnerErrorEventsArgs innerErrorEventsArg = new InnerErrorEventsArgs()
						{
							MensajeError = string.Concat(empty, " El dispositivo ya se encuentra en el sistema!"),
							SourceError = "inner"
						};
						if (this.ErrInner != null)
						{
							this.ErrInner(this, innerErrorEventsArg);
						}
						return;
					}
					else
					{
						InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_PADRAO;
						return;
					}
				}
				else if (num8 == 128)
				{
					InnerAtual.TemporizadorErroComSerial = DateTime.MinValue;
				}
				else if (InnerAtual.TemporizadorErroComSerial == DateTime.MinValue)
				{
					InnerAtual.TemporizadorErroComSerial = DateTime.Now;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private static void ESTADO_RECONECTAR(Inner InnerAtual)
		{
			try
			{
				InnerAtual.CountPingOnline = 0;
				if (EasyInner.PingOnLine(InnerAtual.Numero) == 0)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_CONECTAR;
					InnerAtual.CountPingOnline = 0;
				}
			}
			catch (Exception exception)
			{
			}
		}

		public void Inicio()
		{
			this.ListaInner = new List<Inner>();
		}

		private static void PING_ONLINE(Inner InnerAtual)
		{
			try
			{
				if (EasyInner.PingOnLine(InnerAtual.Numero) != 0)
				{
					Inner innerAtual = InnerAtual;
					innerAtual.CountPingFail = innerAtual.CountPingFail + 1;
					InnerAtual.CountPingOnline = 0;
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
				}
				else
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_POLLING;
					InnerAtual.CountPingOnline = 0;
					InnerAtual.CountPingFail = 0;
				}
				if (InnerAtual.CountPingFail > 2)
				{
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_RECONECTAR;
					InnerAtual.CountPingOnline = 0;
				}
			}
			catch (Exception exception)
			{
			}
		}

		private void prcInner()
		{
			EasyInner.DefinirTipoConexao(2);
			EasyInner.FecharPortaComunicacao();
			if (EasyInner.AbrirPortaComunicacao(3570) == 0)
			{
				while (this.activa)
				{
					foreach (Inner listaInner in this.ListaInner)
					{
						if ((listaInner.CountPingOnline <= 3000 ? false : listaInner.EstadoAtual == Enumeradores.EstadosInner.ESTADO_POLLING))
						{
							listaInner.EstadoAtual = Enumeradores.EstadosInner.PING_ONLINE;
						}
						if (listaInner.TemporizadorErroComSerial != DateTime.MinValue)
						{
							TimeSpan now = DateTime.Now - listaInner.TemporizadorErroComSerial;
							if ((now.Seconds > 15 ? true : now.Minutes > 0))
							{
								listaInner.EstadoAtual = Enumeradores.EstadosInner.RECONECTANDO_SERIAL;
							}
						}
						switch (listaInner.EstadoAtual)
						{
							case Enumeradores.EstadosInner.ESTADO_CONECTAR:
							{
								ManageInners.ESTADO_CONECTAR(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_ENVIAR_CFG_OFFLINE:
							{
								ManageInners.ESTADO_ENVIAR_CFG_OFFLINE(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_COLETAR_BILHETES:
							{
								ManageInners.ESTADO_COLETAR_BILHETES(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_ENVIAR_CFG_ONLINE:
							{
								ManageInners.ESTADO_ENVIAR_CFG_ONLINE(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_ENVIAR_DATA_HORA:
							{
								ManageInners.ESTADO_ENVIAR_DATA_HORA(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_PADRAO:
							{
								ManageInners.ESTADO_ENVIAR_MSG_PADRAO(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_CONFIGURAR_ENTRADAS_ONLINE:
							{
								ManageInners.ESTADO_CONFIGURAR_ENTRADAS_ONLINE(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_CONFIGURAR_MUDANCAS_ONLINE_OFFLINE:
							{
								ManageInners.ESTADO_CONFIGURAR_MUDANCAS_ONLINE_OFFLINE(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_POLLING:
							{
								this.ESTADO_POLLING(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_VALIDAR_DADOS:
							case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA:
							{
								listaInner.CountPingOnline = listaInner.CountPingOnline + 100;
								continue;
							}
							case Enumeradores.EstadosInner.ESTADO_ENVIAR_BIPCURTO:
							{
								ManageInners.ESTADO_ENVIAR_BIPCURTO(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_ENVIAR_MSG_OK:
							{
								ManageInners.ESTADO_ENVIAR_MSG_OK(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_LIBERA_GIRO_CATRACA:
							{
								ManageInners.ESTADO_LIBERA_GIRO_CATRACA(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_MONITORA_GIRO_CATRACA:
							{
								ManageInners.ESTADO_MONITORA_GIRO_CATRACA(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.PING_ONLINE:
							{
								ManageInners.PING_ONLINE(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.ESTADO_RECONECTAR:
							{
								ManageInners.ESTADO_RECONECTAR(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							case Enumeradores.EstadosInner.RECONECTANDO_SERIAL:
							{
								ManageInners.RECONECTAR_SERIAL(listaInner);
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
							default:
							{
								goto case Enumeradores.EstadosInner.ESTADO_LIBERAR_CATRACA;
							}
						}
					}
					Thread.Sleep(100 / this.ListaInner.Count);
				}
				EasyInner.FecharPortaComunicacao();
			}
		}

		public void ProcesaInner()
		{
			this.activa = true;
			(new Thread(new ThreadStart(this.prcInner))).Start();
		}

		private static void RECONECTAR_SERIAL(Inner InnerAtual)
		{
			Thread.Sleep(25);
			Inner innerAtual = InnerAtual;
			innerAtual.CountRepeatPingOnline = innerAtual.CountRepeatPingOnline + 250;
			if (InnerAtual.CountRepeatPingOnline > 1500)
			{
				if (EasyInner.Ping(InnerAtual.Numero) == 0)
				{
					InnerAtual.CountPingFail = 0;
					InnerAtual.TemporizadorErroComSerial = DateTime.MinValue;
					EasyInner.LevantarParaOnLine(InnerAtual.Numero);
					InnerAtual.EstadoAtual = Enumeradores.EstadosInner.ESTADO_COLETAR_BILHETES;
					InnerAtual.TempoColeta = (int)EasyInner.RetornarSegundosSys() + 5;
				}
			}
		}

		public event EventHandler<InnerErrorEventsArgs> ErrInner;
	}
}