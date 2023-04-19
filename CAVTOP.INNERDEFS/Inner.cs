using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.INNERDEFS
{
	public class Inner
	{
		private int _numero;

		private Enumeradores.EstadosInner _estadoAtual;

		private int _tempoColeta;

		private bool _estaVivo;

		private bool _catraca;

		private bool _biometrico;

		private bool _urna;

		private int _qtdDigitos;

		private int _countPingOnline;

		private int _countReconexao;

		private int _countPingFail;

		private int myVar;

		private int _countRepeatPingOnline;

		private bool _flagMensagemTemporizada;

		private DateTime _teporizador;

		private DateTime _temporizadorErroComSerial;

		public bool Biometrico
		{
			get
			{
				return this._biometrico;
			}
			set
			{
				this._biometrico = value;
			}
		}

		public string CARTAOB
		{
			get;
			set;
		}

		public bool Catraca
		{
			get
			{
				return this._catraca;
			}
			set
			{
				this._catraca = value;
			}
		}

		public int CountFails
		{
			get;
			set;
		}

		public int CountPingFail
		{
			get
			{
				return this._countPingFail;
			}
			set
			{
				this._countPingFail = value;
			}
		}

		public int CountPingOnline
		{
			get
			{
				return this._countPingOnline;
			}
			set
			{
				this._countPingOnline = value;
			}
		}

		public int CountReconexao
		{
			get
			{
				return this._countReconexao;
			}
			set
			{
				this._countReconexao = value;
			}
		}

		public int CountRepeatPingOnline
		{
			get
			{
				return this._countRepeatPingOnline;
			}
			set
			{
				this._countRepeatPingOnline = value;
			}
		}

		public int Estado
		{
			get;
			set;
		}

		public Enumeradores.EstadosInner EstadoAtual
		{
			get
			{
				return this._estadoAtual;
			}
			set
			{
				this._estadoAtual = value;
			}
		}

		public bool estaVivo
		{
			get
			{
				return this._estaVivo;
			}
			set
			{
				this._estaVivo = value;
			}
		}

		public int fallas
		{
			get;
			set;
		}

		public bool FlagMensagemTemporizada
		{
			get
			{
				return this._flagMensagemTemporizada;
			}
			set
			{
				this._flagMensagemTemporizada = value;
			}
		}

		public string id
		{
			get;
			set;
		}

		public int IdInner
		{
			get;
			set;
		}

		public bool isActive
		{
			get;
			set;
		}

		public bool isInnerNet
		{
			get;
			set;
		}

		public bool isMsgNeg
		{
			get;
			set;
		}

		public bool isOnline
		{
			get;
			set;
		}

		public int MyProperty
		{
			get
			{
				return this.myVar;
			}
			set
			{
				this.myVar = value;
			}
		}

		public string nombre
		{
			get;
			set;
		}

		public string nombre2
		{
			get;
			set;
		}

		public int Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
				this.id = string.Concat("Inner -> ", value.ToString(CultureInfo.InvariantCulture));
			}
		}

		public bool paso
		{
			get;
			set;
		}

		public bool PasoMSGmolinete
		{
			get;
			set;
		}

		public bool PasoTarjeta
		{
			get;
			set;
		}

		public int PuertoTCP
		{
			get;
			set;
		}

		public int QtdDigitos
		{
			get
			{
				return this._qtdDigitos;
			}
			set
			{
				this._qtdDigitos = value;
			}
		}

		public bool renewMsgOnline
		{
			get;
			set;
		}

		public int Res
		{
			get;
			set;
		}

		public string sm
		{
			get;
			set;
		}

		public string style
		{
			get;
			set;
		}

		public DateTime T1
		{
			get;
			set;
		}

		public DateTime T2
		{
			get;
			set;
		}

		public DateTime T3
		{
			get;
			set;
		}

		public DateTime T4
		{
			get;
			set;
		}

		public int TempoColeta
		{
			get
			{
				return this._tempoColeta;
			}
			set
			{
				this._tempoColeta = value;
			}
		}

		public DateTime Temporizador
		{
			get
			{
				return this._teporizador;
			}
			set
			{
				this._teporizador = value;
			}
		}

		public DateTime TemporizadorErroComSerial
		{
			get
			{
				return this._temporizadorErroComSerial;
			}
			set
			{
				this._temporizadorErroComSerial = value;
			}
		}

		public DateTime TimerAccess
		{
			get;
			set;
		}

		public DateTime TimerMsgNeg
		{
			get;
			set;
		}

		public DateTime TimerMsgOnline
		{
			get;
			set;
		}

		public DateTime TimerPingOnline
		{
			get;
			set;
		}

		public bool Urna
		{
			get
			{
				return this._urna;
			}
			set
			{
				this._urna = value;
			}
		}

		public Inner()
		{
		}

		public override string ToString()
		{
			string[] str = new string[] { "Inner: ", null, null, null, null, null, null, null };
			int numero = this.Numero;
			str[1] = numero.ToString();
			str[2] = " | Qtd.Dig: ";
			numero = this.QtdDigitos;
			str[3] = numero.ToString();
			str[4] = " | Catraca: ";
			bool catraca = this.Catraca;
			str[5] = catraca.ToString();
			str[6] = " | BIO: ";
			catraca = this.Biometrico;
			str[7] = catraca.ToString();
			return string.Concat(str);
		}
	}
}