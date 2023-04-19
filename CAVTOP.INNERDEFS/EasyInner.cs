using System;
using System.Runtime.InteropServices;
using System.Text;

namespace BGCOP.CAVTOP.INNERDEFS
{
	public class EasyInner
	{
		public EasyInner()
		{
		}

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte AbrirPortaComunicacao(int Porta);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte AcionarBipCurto(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte AcionarBipLongo(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte AcionarRele1(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte AcionarRele2(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ApagarHorariosAcesso(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ApagarHorariosSirene(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ApagarListaAcesso(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ApagarMensagensOffLine(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ApagarTodosUsuariosVerid(int Inner, string SenhaAdm);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ApagarUsuarioVerid(int Inner, string Cartao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte AvisarQuandoMemoriaCheia(byte Avisa);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte CartaoMasterLiberaAcesso(byte Libera);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ColetarBilhete(int Inner, ref byte Tipo, ref byte Dia, ref byte Mes, ref byte Ano, ref byte Hora, ref byte Minuto, StringBuilder Cartao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte CompararDigitalLeitor(int Inner, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte CompararPINVerid(int Inner, string Cartao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte CompararTemplateVerid(int Inner, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int ConectarModem(int Porta, string Str, int Tom, string Telefone, int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarAcionamento1(byte Funcao, byte Tempo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarAcionamento2(byte Funcao, byte Tempo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarAjustesQualidadeBio(int Inner, byte Registro, byte Verificacao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarAjustesSegurancaBio(int Inner, byte Identificacao, byte Verificacao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarAjustesSensibilidadeBio(int Inner, byte Ganho, byte Brilho, byte Contraste);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarBio(int Inner, byte HabilitaIdentificacao, byte HabilitaVerificacao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarCapturaAdaptativaBio(int Inner, byte Capturar, byte Total, byte Tempo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarFiltroBio(int Inner, byte Habilitar);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarInnerOffLine();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarInnerOnLine();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitor1(byte Operacao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitor2(byte Operacao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeAcura();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeHIDAbaTrack2();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeMotorolaAbaTrack2();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeSmartCard();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeSmartCardAcura();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeWiegand();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarLeitorProximidadeWiegandFacilityCode();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarRedeVerid(int Inner, byte Envia, byte Recebe, byte BroadCast);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarTipoLeitor(byte Tipo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ConfigurarWiegandDoisLeitores(byte Habilita, byte ExibirMensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte CriarUsuarioLeitorVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirCodigoEmpresa(int Codigo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirConfiguracaoTecladoOnLine(byte Digitos, byte EcoDisplay, byte Tempo, byte PosicaoCursor);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirConfiguracoesFuncoes(byte Funcao, byte Catraca, byte Rele1, byte Rele2, byte Lista, byte Biometria);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirEntradasMudancaOffLine(byte Teclado, byte Leitor1, byte Leitor2, byte Catraca);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirEntradasMudancaOffLineComBiometria(byte Teclado, byte Leitor1, byte Leitor2, byte Verificacao, byte Identificacao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirEntradasMudancaOnLine(byte Entrada);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirEventoSensor(byte Sensor, byte Evento, byte Tempo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirFormasPictogramasMillenium(byte Forma);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirFuncaoDefaultLeitoresProximidade(byte Funcao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirFuncaoDefaultSensorBiometria(byte Funcao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirLogicaRele(byte Logica);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirMensagemEntradaOffLine(byte ExibirData, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirMensagemFuncaoOffLine(string Mensagem, byte Funcao, byte Habilitada);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirMensagemPadraoMudancaOffLine(byte ExibirData, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirMensagemPadraoMudancaOnLine(byte ExibirData, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirMensagemPadraoOffLine(byte ExibirData, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirMensagemSaidaOffLine(byte ExibirData, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirNivelAcesso(byte Nivel);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte DefinirNumeroCartaoMaster(string Master);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirPadraoCartao(byte Padrao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirPorcentagemRevista(byte Porcentagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirQuantidadeDigitosCartao(byte Quantidade);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirTipoConexao(byte Tipo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DefinirTipoListaAcesso(byte Tipo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DesabilitarBipCatraca(byte Desabilita);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DesabilitarBloqueioCatracaMicroSwitch(byte Desabilita);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DesabilitarRele1(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DesabilitarRele2(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DesligarBackLite(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DesligarBipIntermitente(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte DevolverCartao(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EngolirCartao(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarAjustesBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarComandoAcessoNegado(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarConfiguracoes(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarConfiguracoesFuncoes(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarConfiguracoesMudancaAutomaticaOnLineOffLine(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarFormasEntradasOnLine(int Inner, byte QtdeDigitosTeclado, byte EcoTeclado, byte FormaEntrada, byte TempoTeclado, byte PosicaoCursorTeclado);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarHorariosAcesso(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarHorariosSirene(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarHorarioVerao(int Inner, byte DiaInicio, byte MesInicio, byte AnoInicio, byte HoraInicio, byte MinutoInicio, byte DiaFim, byte MesFim, byte AnoFim, byte HoraFim, byte MinutoFim);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarListaAcesso(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarListaUsuariosSemDigitalBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte EnviarMensagemImpressora00(int Inner, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte EnviarMensagemImpressoraFF(int Inner, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte EnviarMensagemPadraoOnLine(int Inner, byte ExibirData, string Mensagem);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte EnviarMensagemTemporariaOnLine(int Inner, byte ExibirData, string Mensagem, byte Tempo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarMensagensOffLine(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarRelogio(int Inner, byte Dia, byte Mes, byte Ano, byte Hora, byte Minuto, byte Segundo);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int EnviarStringInicializacaoModem(string Str);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte EnviarUsuarioBio(int Inner, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte FazerIdentificacaoBiometricaBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte FazerVerificacaoBiometricaBio(int Inner, string Usuario);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void FecharPortaComunicacao();

		[DllImport("Kernel32", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int GetTickCount();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte HabilitarMudancaOnLineOffLine(byte Habilita, byte Tempo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte HabilitarScoreFuncoes(int Funcao, byte Score);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte HabilitarScoreMensagemOffLine(int Inner, byte Tipo, byte Habilitar);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte HabilitarTeclado(byte Habilita, byte Ecoar);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte IncluirUsuarioSemDigitalBio(string Cartao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte IncluirUsuarioVerid(int Inner, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void InicializarColetaListaUsuariosBio();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte InserirHorarioAcesso(byte Horario, byte DiaSemana, byte FaixaDia, byte Hora, byte Minuto);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte InserirHorarioSirene(byte Hora, byte Minuto, byte Segunda, byte Terca, byte Quarta, byte Quinta, byte Sexta, byte Sabado, byte DomingoFeriado);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte InserirQuantidadeDigitoVariavel(byte Digito);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte InserirUsuarioLeitorBio(int Inner, byte Tipo, string Usuario);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte InserirUsuarioListaAcesso(string Cartao, byte Horario);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int LerByteModem();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LerSensoresInner(int Inner, ref byte StatusSensor1, ref byte StatusSensor2, ref byte StatusSensor3);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LevantarParaOnLine(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LiberarCatracaDoisSentidos(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LiberarCatracaEntrada(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LiberarCatracaEntradaInvertida(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LiberarCatracaSaida(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LiberarCatracaSaidaInvertida(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LigarBackLite(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LigarBipIntermitente(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LocalizarPrimeiroUsuarioVerid(int Inner, byte Modo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte LocalizarProximoUsuarioVerid(int Inner, byte Modo);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte LocalizarUsuarioVerid(int Inner, byte Modo, byte Digitos, string Cartao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ManterRele1Acionado(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ManterRele2Acionado(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte PermitirCadastroInnerBioVerid(byte Permite);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte Ping(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte PingOnLine(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ReceberDadosOnLine(int Inner, ref byte Origem, ref byte Complemento, StringBuilder Cartao, ref byte Dia, ref byte Mes, ref byte Ano, ref byte Hora, ref byte Minuto, ref byte Segundo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberDataHoraDadosOnLine(byte Recebe);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberModeloBio(int Inner, byte OnLine, ref int Modelo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberPacoteListaUsuariosBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberQuantidadeUsuariosBio(int Inner, byte OnLine, ref int Quantidade);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberRelogio(int Inner, ref byte Dia, ref byte Mes, ref byte Ano, ref byte Hora, ref byte Minuto, ref byte Segundo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberTemplateLeitor(int Inner, byte OnLine, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberTotalUsuariosVerid(int Inner, ref int Total);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberUsuarioCadastradoBio(int Inner, byte OnLine, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ReceberUsuarioLista(int Inner, StringBuilder Usuario);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ReceberUsuarioVerid(int Inner, byte Modo, ref byte Digitos, byte[] Template, string Cartao);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberVersaoBio(int Inner, byte OnLine, ref int VersaoAlta, ref int VersaoBaixa);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ReceberVersaoFirmware(int Inner, ref byte Linha, ref short Variacao, ref byte VersaoAlta, ref byte VersaoBaixa, ref byte VersaoSufixo);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte RegistrarAcessoNegado(byte TipoRegistro);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResetarModoOnLine(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoComparacaoDigitalLeitor(int Inner, byte OnLine);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoComparacaoPINVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoComparacaoTemplateVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoConfiguracaoBio(int Inner, byte OnLine);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoConfiguracaoRedeVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoEnvioAjustesBio(int Inner, byte OnLine);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoExclusaoTodosUsuariosVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoExclusaoUsuarioVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte ResultadoIdentificacaoBiometrica(int Inner, byte OnLine, byte[] Usuario);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoInclusaoUsuarioLeitorVerid(int Inner, byte[] Template);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoInclusaoUsuarioVerid(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoInsercaoUsuarioLeitorBio(int Inner, byte OnLine);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte ResultadoVerificacaoBiometrica(int Inner, byte OnLine);

		public static long RetornarSegundosSys()
		{
			return (long)(EasyInner.GetTickCount() / 1000);
		}

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void SetarBioLight(int Light);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern void SetarInnerOld(int Inner, int Old);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte SolicitarExclusaoUsuario(int Inner, string Usuario);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte SolicitarListaUsuariosBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte SolicitarModeloBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte SolicitarQuantidadeUsuariosBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte SolicitarTemplateLeitor(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte SolicitarTotalUsuariosVerid(int Inner, byte Modo);

		[DllImport("EasyInner.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern byte SolicitarUsuarioCadastradoBio(int Inner, string Usuario);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte SolicitarVersaoBio(int Inner);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int TemProximoPacote();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int TemProximoUsuario();

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte UsuarioFoiEnviado(int Inner, byte OnLine);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte UsuarioFoiExcluido(int Inner, byte OnLine);

		[DllImport("EasyInner.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern byte UtilizarSenhaAcesso(byte Utiliza);
	}
}