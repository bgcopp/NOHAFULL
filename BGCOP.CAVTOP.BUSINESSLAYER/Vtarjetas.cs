using BGCOP.CAVTOP.COMMON;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Vtarjetas
	{
		public LogCls log = new LogCls();

		public Vtarjetas()
		{
		}

		public int diaSemanaF(string dia)
		{
			int num;
			string str = dia;
			if (str != null)
			{
				switch (str)
				{
					case "Sunday":
					{
						num = 1;
						break;
					}
					case "Monday":
					{
						num = 2;
						break;
					}
					case "Tuesday":
					{
						num = 3;
						break;
					}
					case "Wednesday":
					{
						num = 4;
						break;
					}
					case "Thursday":
					{
						num = 5;
						break;
					}
					case "Friday":
					{
						num = 6;
						break;
					}
					case "Saturday":
					{
						num = 7;
						break;
					}
					default:
					{
						num = 0;
						return num;
					}
				}
			}
			else
			{
				num = 0;
				return num;
			}
			return num;
		}

		public void GuardaMarcacionParqueadero(string idvehiculo, string idempleado, string mregistro)
		{
			this.log.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					TRegistroVehiculo tRegistroVehiculo = new TRegistroVehiculo()
					{
						idVehiculo = new int?(int.Parse(idvehiculo)),
						idempleado = new int?(int.Parse(idempleado)),
						fechadeRegistro = new DateTime?(DateTime.Now),
						mregistro = mregistro
					};
					masterDBACEntity.AddToTRegistroVehiculo(tRegistroVehiculo);
					masterDBACEntity.SaveChanges();
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.log.Evento = string.Concat("Error: ", exception.Message);
				this.log.AddEvent();
			}
		}

		public bool GuardaMarcacionTarjeta(string idCard, string innerN)
		{
			bool flag;
			this.log.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == idCard
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						bool? nullable = tTarjetum.esvisitante;
						if (((bool)nullable? 1 : 0) == 0)
						{
							TEmpleado tEmpleado = (
								from b in masterDBACEntity.TEmpleado
								where b.idTarjeta == (int?)tTarjetum.idTarjeta
								select b).FirstOrDefault<TEmpleado>();
							TMarcacion tMarcacion = new TMarcacion()
							{
								fechaMarcacion = new DateTime?(DateTime.Now),
								idEmpleado = new int?(tEmpleado.idEmpleado),
								NoTarjeta = idCard,
								NoInner = innerN
							};
							masterDBACEntity.AddToTMarcacion(tMarcacion);
							masterDBACEntity.SaveChanges();
						}
						else
						{
							TVisitanteVisitaProgramada tVisitanteVisitaProgramada = (
								from a in masterDBACEntity.TVisitanteVisitaProgramada
								where a.idTarjeta == (int?)tTarjetum.idTarjeta
								orderby a.fechaLlegada descending
								select a).FirstOrDefault<TVisitanteVisitaProgramada>();
							TMarcacion tMarcacion1 = new TMarcacion()
							{
								fechaMarcacion = new DateTime?(DateTime.Now),
								idVisitante = new decimal?(tVisitanteVisitaProgramada.idVisitante),
								idVisitanteVistaP = new decimal?(tVisitanteVisitaProgramada.idTabla),
								NoTarjeta = idCard,
								NoInner = innerN
							};
							masterDBACEntity.AddToTMarcacion(tMarcacion1);
							masterDBACEntity.SaveChanges();
						}
					}
					else
					{
						flag = false;
						return flag;
					}
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.log.Evento = string.Concat("Error: ", exception.Message);
				this.log.AddEvent();
			}
			flag = true;
			return flag;
		}

		public MessageDTO verificaParqueoEntrada(string Card, string CB)
		{
			MessageDTO messageDTO;
			string card = Card;
			MessageDTO str = new MessageDTO();
			bool flag = false;
			bool flag1 = false;
			try
			{
				long num = Convert.ToInt64(card);
				card = string.Format("{0:X}", num).ToLower();
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == card
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						TEmpleado tEmpleado = (
							from b in masterDBACEntity.TEmpleado
							where b.idTarjeta == (int?)tTarjetum.idTarjeta
							select b).FirstOrDefault<TEmpleado>();
						if (tEmpleado != null)
						{
							TVehiculo tVehiculo = (
								from c in masterDBACEntity.TVehiculo
								where c.CodigodeBarras == CB
								select c).FirstOrDefault<TVehiculo>();
							if (tVehiculo != null)
							{
								IQueryable<TEmpleadoVehiculo> tEmpleadoVehiculo = 
									from d in masterDBACEntity.TEmpleadoVehiculo
									where d.IdVehiculo == tVehiculo.idVehiculo
									select d;
								if (tEmpleadoVehiculo != null)
								{
									foreach (TEmpleadoVehiculo tEmpleadoVehiculo1 in tEmpleadoVehiculo)
									{
										if (tEmpleadoVehiculo1.IdEmpleado == tEmpleado.idEmpleado)
										{
											flag = true;
											break;
										}
									}
									IQueryable<TvehiculoParqueo> tvehiculoParqueo = 
										from f in masterDBACEntity.TvehiculoParqueo
										where f.idVehiculo == tVehiculo.idVehiculo
										select f;
									if (tvehiculoParqueo != null)
									{
										int num1 = Convert.ToInt32(DateTime.Now.DayOfWeek);
										foreach (TvehiculoParqueo tvehiculoParqueo1 in tvehiculoParqueo)
										{
											masterDBACEntities masterDBACEntity1 = new masterDBACEntities();
											try
											{
												TParqueo nullable = (
													from g in masterDBACEntity1.TParqueo
													where g.idParqueadero == tvehiculoParqueo1.idParqueadero
													select g).FirstOrDefault<TParqueo>();
												if (nullable != null)
												{
													bool? nullable1 = nullable.estaocupado;
													if (((bool)nullable1 ? 1 : 0) == 0)
													{
														str.Mensaje = string.Concat("El parquedero ", nullable.nParqueo, " se encuentra ocupado.");
														str.Resultado = false;
														str.Error = "*";
														str.ErrorInterno = "*";
													}
													else
													{
														switch (num1)
														{
															case 0:
															{
																nullable1 = tvehiculoParqueo1.dia1;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
															case 1:
															{
																nullable1 = tvehiculoParqueo1.dia2;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
															case 2:
															{
																nullable1 = tvehiculoParqueo1.dia3;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
															case 3:
															{
																nullable1 = tvehiculoParqueo1.dia4;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
															case 4:
															{
																nullable1 = tvehiculoParqueo1.dia5;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
															case 5:
															{
																nullable1 = tvehiculoParqueo1.dia6;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
															case 6:
															{
																nullable1 = tvehiculoParqueo1.dia7;
																if (((bool)nullable1 ? 1: 0) != 0)
																{
																	flag1 = true;
																}
																break;
															}
														}
														if (!(flag & flag1))
														{
															str.Mensaje = string.Concat("El parqueadero no esta programado para usted este dia de la semana!", flag.ToString(), " - ", flag1.ToString());
															str.Resultado = false;
															str.Error = "*";
															str.ErrorInterno = "*";
														}
														else
														{
															nullable.estaocupado = new bool?(true);
															nullable.ocupadopor = tVehiculo.Placa;
															masterDBACEntity1.SaveChanges();
															int num2 = tVehiculo.idVehiculo;
															string str1 = num2.ToString(CultureInfo.InvariantCulture);
															num2 = tEmpleado.idEmpleado;
															this.GuardaMarcacionParqueadero(str1, num2.ToString(CultureInfo.InvariantCulture), "Entrada Vehicular");
															(new TareasInner()).AgregarTarea(1, "OpenS", CB);
															str.Mensaje = "Acceso concedido al parqueadero!";
															str.Resultado = true;
															str.Error = "*";
															str.ErrorInterno = "*";
															messageDTO = str;
															return messageDTO;
														}
													}
												}
												else
												{
													str.Mensaje = "No existe un parqueo para este vehiculo!";
													str.Resultado = false;
													str.Error = "*";
													str.ErrorInterno = "*";
												}
											}
											finally
											{
												if (masterDBACEntity1 != null)
												{
													((IDisposable)masterDBACEntity1).Dispose();
												}
											}
										}
									}
									else
									{
										str.Mensaje = "No existe un parqueadero asignado!";
										str.Resultado = false;
										str.Error = "*";
										str.ErrorInterno = "*";
										messageDTO = str;
										return messageDTO;
									}
								}
								else
								{
									str.Mensaje = "No existe un vehiculo asignado!";
									str.Resultado = false;
									str.Error = "*";
									str.ErrorInterno = "*";
									messageDTO = str;
									return messageDTO;
								}
							}
							else
							{
								str.Mensaje = "El codigo de barras no se encuentra en la BASE de datos!";
								str.Resultado = false;
								str.Error = "*";
								str.ErrorInterno = "*";
								messageDTO = str;
								return messageDTO;
							}
						}
						else
						{
							str.Mensaje = "No existe un empleado asociado a esta tarjeta!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "la tarjeta no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						return messageDTO;
					}
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
				messageDTO = str;
				return messageDTO;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = exception.ToString();
				str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoEntrada(string CB)
		{
			MessageDTO messageDTO;
			MessageDTO str = new MessageDTO();
			bool flag = false;
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					TVehiculo tVehiculo = (
						from c in masterDBACEntity.TVehiculo
						where c.CodigodeBarras == CB
						select c).FirstOrDefault<TVehiculo>();
					if (tVehiculo != null)
					{
						IQueryable<TvehiculoParqueo> tvehiculoParqueo = 
							from f in masterDBACEntity.TvehiculoParqueo
							where f.idVehiculo == tVehiculo.idVehiculo
							select f;
						if (tvehiculoParqueo != null)
						{
							masterDBACEntities masterDBACEntity1 = new masterDBACEntities();
							try
							{
								foreach (TvehiculoParqueo tvehiculoParqueo1 in tvehiculoParqueo)
								{
									TParqueo nullable = (
										from g in masterDBACEntity1.TParqueo
										where g.idParqueadero == tvehiculoParqueo1.idParqueadero
										select g).FirstOrDefault<TParqueo>();
									if (nullable != null)
									{
										bool? nullable1 = nullable.estaocupado;
										if (((bool)nullable1 ? 1 : 0) == 0)
										{
											str.Mensaje = string.Concat("El parqueadero [", nullable.nParqueo, "] se encuentra ocupado.");
											str.Resultado = false;
											str.Error = "*";
											str.ErrorInterno = "*";
										}
										else
										{
											flag = true;
											nullable.estaocupado = new bool?(true);
											nullable.ocupadopor = tVehiculo.Placa;
											masterDBACEntity1.SaveChanges();
											int num = tVehiculo.idVehiculo;
											this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Entrada Vehicular");
											(new TareasInner()).AgregarTarea(1, "OpenS", CB);
											str.Mensaje = "Acceso concedido al parqueadero!";
											str.Resultado = true;
											str.Error = "*";
											str.ErrorInterno = "*";
											messageDTO = str;
											return messageDTO;
										}
									}
									else
									{
										str.Mensaje = "No se puede localizar el parqueadero en la tabla maestra!";
										str.Resultado = false;
										str.Error = "*";
										str.ErrorInterno = "*";
									}
								}
							}
							finally
							{
								if (masterDBACEntity1 != null)
								{
									((IDisposable)masterDBACEntity1).Dispose();
								}
							}
						}
						else
						{
							str.Mensaje = "El vehiculo no tiene un parqueadero asignado!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "El codigo de barras no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						return messageDTO;
					}
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
				messageDTO = str;
				return messageDTO;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = string.Concat("Error: ", exception.ToString());
				str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoSalida(string Card, string CB)
		{
			MessageDTO messageDTO;
			string card = Card;
			bool flag = false;
			MessageDTO str = new MessageDTO();
			try
			{
				long num = Convert.ToInt64(card);
				card = string.Format("{0:X}", num).ToLower();
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == card
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						TEmpleado tEmpleado = (
							from b in masterDBACEntity.TEmpleado
							where b.idTarjeta == (int?)tTarjetum.idTarjeta
							select b).FirstOrDefault<TEmpleado>();
						if (tEmpleado != null)
						{
							TVehiculo tVehiculo = (
								from c in masterDBACEntity.TVehiculo
								where c.CodigodeBarras == CB
								select c).FirstOrDefault<TVehiculo>();
							if (tVehiculo != null)
							{
								IQueryable<TEmpleadoVehiculo> tEmpleadoVehiculo = 
									from d in masterDBACEntity.TEmpleadoVehiculo
									where d.IdVehiculo == tVehiculo.idVehiculo
									select d;
								if (tEmpleadoVehiculo != null)
								{
									foreach (TEmpleadoVehiculo tEmpleadoVehiculo1 in tEmpleadoVehiculo)
									{
										if (tEmpleadoVehiculo1.IdEmpleado == tEmpleado.idEmpleado)
										{
											flag = true;
											(new TareasInner()).AgregarTarea(1, "OpenS", CB);
											masterDBACEntities masterDBACEntity1 = new masterDBACEntities();
											try
											{
												TParqueo nullable = (
													from k1 in masterDBACEntity1.TParqueo
													where k1.ocupadopor == tVehiculo.Placa
													select k1).FirstOrDefault<TParqueo>();
												if (nullable == null)
												{
													str.Mensaje = "El vehiculo no ha ingresado!";
													str.Resultado = true;
													str.Error = "*";
													str.ErrorInterno = "*";
													messageDTO = str;
													return messageDTO;
												}
												else
												{
													nullable.ocupadopor = "";
													nullable.estaocupado = new bool?(false);
													masterDBACEntity1.SaveChanges();
													int num1 = tVehiculo.idVehiculo;
													string str1 = num1.ToString(CultureInfo.InvariantCulture);
													num1 = tEmpleado.idEmpleado;
													this.GuardaMarcacionParqueadero(str1, num1.ToString(CultureInfo.InvariantCulture), "Salida Vehicular");
													str.Mensaje = "Salida Exitosa!";
													str.Resultado = true;
													str.Error = "*";
													str.ErrorInterno = "*";
													messageDTO = str;
													return messageDTO;
												}
											}
											finally
											{
												if (masterDBACEntity1 != null)
												{
													((IDisposable)masterDBACEntity1).Dispose();
												}
											}
										}
									}
								}
								else
								{
									str.Mensaje = "la asignacion del vehiculo no se encuentra en la BASE de datos!";
									str.Resultado = false;
									str.Error = "*";
									str.ErrorInterno = "*";
									messageDTO = str;
									return messageDTO;
								}
							}
							else
							{
								str.Mensaje = "El vehiculo no se encuentra en la BASE de datos!";
								str.Resultado = false;
								str.Error = "*";
								str.ErrorInterno = "*";
								messageDTO = str;
								return messageDTO;
							}
						}
						else
						{
							str.Mensaje = "No existe el en la BASE de datos!";
							str.Resultado = false;
							str.Error = "*";
							str.ErrorInterno = "*";
							messageDTO = str;
							return messageDTO;
						}
					}
					else
					{
						str.Mensaje = "la tarjeta no se encuentra en la BASE de datos!";
						str.Resultado = false;
						str.Error = "*";
						str.ErrorInterno = "*";
						messageDTO = str;
						return messageDTO;
					}
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
				str.Mensaje = "Acceso no permitido";
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
				return messageDTO;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				str.Mensaje = string.Concat("Error :", exception.ToString());
				str.ErrorInterno = exception.InnerException.ToString();
				str.Resultado = false;
				str.Error = "*";
				str.ErrorInterno = "*";
				messageDTO = str;
			}
			return messageDTO;
		}

		public MessageDTO verificaParqueoSalida(string CB)
		{
			MessageDTO messageDTO;
			bool flag = false;
			MessageDTO messageDTO1 = new MessageDTO();
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TVehiculo tVehiculo = (
					from c in masterDBACEntity.TVehiculo
					where c.CodigodeBarras == CB
					select c).FirstOrDefault<TVehiculo>();
				if (tVehiculo != null)
				{
					flag = true;
					(new TareasInner()).AgregarTarea(1, "OpenS", CB);
					TParqueo nullable = (
						from k1 in masterDBACEntity.TParqueo
						where k1.ocupadopor == tVehiculo.Placa
						select k1).FirstOrDefault<TParqueo>();
					if (nullable == null)
					{
						messageDTO1.Mensaje = "El vehiculo no ha ingresado!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
					}
					else
					{
						nullable.ocupadopor = "";
						nullable.estaocupado = new bool?(false);
						masterDBACEntity.SaveChanges();
						int num = tVehiculo.idVehiculo;
						this.GuardaMarcacionParqueadero(num.ToString(CultureInfo.InvariantCulture), "111111111", "Salida Vehicular");
						messageDTO1.Mensaje = "Salida Exitosa!";
						messageDTO1.Resultado = true;
						messageDTO1.Error = "*";
						messageDTO1.ErrorInterno = "*";
						messageDTO = messageDTO1;
					}
				}
				else
				{
					messageDTO1.Mensaje = "El vehiculo no se encuentra en la base de datos";
					messageDTO1.Resultado = false;
					messageDTO1.Error = "*";
					messageDTO1.ErrorInterno = "*";
					messageDTO = messageDTO1;
				}
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return messageDTO;
		}

		public bool VerificaTarjetaBussiness(string idCard)
		{
			int num;
			int num1;
			int num2;
			IQueryable<TDiasHorario> tDiasHorario;
			TDiasHorario tDiasHorario1 = null;
			bool flag;
			DateTime now;
			byte? nullable;
			bool flag1 = false;
			DateTime dateTime = DateTime.Now;
			this.log.FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
			DateTime value = new DateTime();
			DateTime value1 = new DateTime();
			try
			{
				masterDBACEntities masterDBACEntity = new masterDBACEntities();
				try
				{
					dateTime = DateTime.Now;
					string str = idCard;
					TTarjeta tTarjetum = (
						from a in masterDBACEntity.TTarjeta
						where a.numtarjeta == str
						select a).FirstOrDefault<TTarjeta>();
					if (tTarjetum != null)
					{
						bool? nullable1 = tTarjetum.activa;
						if (((bool)nullable1 ? 1 : 0) == 0)
						{
							nullable1 = tTarjetum.esvisitante;
							if (((bool)nullable1 ? 1: 0) == 0)
							{
								TEmpleado tEmpleado = (
									from mm in masterDBACEntity.TEmpleado
									where mm.idTarjeta == (int?)tTarjetum.idTarjeta
									select mm).FirstOrDefault<TEmpleado>();
								if (tEmpleado != null)
								{
									TEstado tEstado = (
										from nn in masterDBACEntity.TEstado
										where nn.idTipoEstado == tEmpleado.idTipoEstado
										select nn).FirstOrDefault<TEstado>();
									if (tEstado == null)
									{
										flag = false;
										return flag;
									}
									else if (!(tEstado.NombreEstado.ToUpper() != "ACTIVO"))
									{
										THorario tHorario = (
											from b in masterDBACEntity.THorario
											where (int?)b.idHorario == tTarjetum.idHorario
											select b).FirstOrDefault<THorario>();
										if (tHorario == null)
										{
											flag = false;
											return flag;
										}
										else if (!tHorario.esMaestro)
										{
											nullable1 = tHorario.esPermanente;
											if (((bool)nullable1 ? 1: 0) == 0)
											{
												if (tHorario.fechaInicio.HasValue)
												{
													value = tHorario.fechaInicio.Value;
												}
												if (tHorario.fechaFin.HasValue)
												{
													value1 = tHorario.fechaFin.Value;
												}
												num = value.CompareTo(dateTime);
												num1 = value1.CompareTo(dateTime);
												if ((num >= 0 ? false : num1 >= 0))
												{
													now = DateTime.Now;
													num2 = this.diaSemanaF(now.DayOfWeek.ToString());
													tDiasHorario = 
														from c in masterDBACEntity.TDiasHorario
														where c.idHorario == tTarjetum.idHorario
														select c;
													if (tDiasHorario != null)
													{
														foreach (TDiasHorario tDiasHorario3 in tDiasHorario)
														{
															nullable = tDiasHorario1.dia;
															if ((nullable1!=null ? 1 : 0) != 0)
															{
																DateTime.TryParse(tDiasHorario3.entrada, out value);
																DateTime.TryParse(tDiasHorario3.salida, out value1);
																value.ToString("dd/MM/yyyy HH:mm:ss");
																value1.ToString("dd/MM/yyyy HH:mm:ss");
																dateTime.ToString("dd/MM/yyyy HH:mm:ss");
																num = value.CompareTo(dateTime);
																num1 = value1.CompareTo(dateTime);
																nullable = tDiasHorario3.dia;
																if (((nullable.GetValueOrDefault() != num2 ? true : !nullable.HasValue) || num >= 0 ? false : num1 >= 0))
																{
																	flag1 = true;
																	break;
																}
															}
														}
													}
													else
													{
														flag = false;
														return flag;
													}
												}
											}
											else
											{
												now = DateTime.Now;
												num2 = this.diaSemanaF(now.DayOfWeek.ToString());
												tDiasHorario = 
													from c in masterDBACEntity.TDiasHorario
													where c.idHorario == tTarjetum.idHorario
													select c;
												if (tDiasHorario != null)
												{
													foreach (TDiasHorario tDiasHorario2 in tDiasHorario)
													{
														DateTime.TryParse(tDiasHorario2.entrada, out value);
														DateTime.TryParse(tDiasHorario2.salida, out value1);
														num = value.CompareTo(dateTime);
														num1 = value1.CompareTo(dateTime);
														nullable = tDiasHorario2.dia;
														if (((nullable.GetValueOrDefault() != num2 ? true : !nullable.HasValue) || num >= 0 ? false : num1 >= 0))
														{
															flag1 = true;
															break;
														}
													}
												}
												else
												{
													flag = false;
													return flag;
												}
											}
										}
										else
										{
											flag = true;
											return flag;
										}
									}
									else
									{
										flag = false;
										return flag;
									}
								}
								else
								{
									flag = false;
									return flag;
								}
							}
							else
							{
								if (tTarjetum.fechavisi1.HasValue)
								{
									value = tTarjetum.fechavisi1.Value;
								}
								if (tTarjetum.fechavisi2.HasValue)
								{
									value1 = tTarjetum.fechavisi2.Value;
								}
								num = value.CompareTo(dateTime);
								num1 = value1.CompareTo(dateTime);
								if ((num >= 0 ? false : num1 >= 0))
								{
									flag = true;
									return flag;
								}
							}
						}
						else
						{
							flag = false;
							return flag;
						}
					}
					else
					{
						flag = false;
						return flag;
					}
				}
				finally
				{
					if (masterDBACEntity != null)
					{
						((IDisposable)masterDBACEntity).Dispose();
					}
				}
				flag = flag1;
				return flag;
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.log.Evento = string.Concat("Error: ", exception.Message);
				this.log.AddEvent();
				flag = flag1;
				return flag;
			}
			return flag;
		}
	}
}