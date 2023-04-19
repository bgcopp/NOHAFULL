using BGCOP.CAVTOP.WINFORMS;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters
{
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapter")]
	[ToolboxItem(true)]
	public class TVisitanteVisitaProgramadaTableAdapter : Component
	{
		private SqlDataAdapter _adapter;

		private SqlConnection _connection;

		private SqlTransaction _transaction;

		private SqlCommand[] _commandCollection;

		private bool _clearBeforeFill;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				if (this._adapter == null)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				if (this._commandCollection == null)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				if (this._connection == null)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				if (this.Adapter.InsertCommand != null)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				if (this.Adapter.DeleteCommand != null)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				if (this.Adapter.UpdateCommand != null)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				for (int i = 0; i < (int)this.CommandCollection.Length; i++)
				{
					if (this.CommandCollection[i] != null)
					{
						this.CommandCollection[i].Connection = value;
					}
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				for (int i = 0; i < (int)this.CommandCollection.Length; i++)
				{
					this.CommandCollection[i].Transaction = this._transaction;
				}
				if ((this.Adapter == null ? false : this.Adapter.DeleteCommand != null))
				{
					this.Adapter.DeleteCommand.Transaction = this._transaction;
				}
				if ((this.Adapter == null ? false : this.Adapter.InsertCommand != null))
				{
					this.Adapter.InsertCommand.Transaction = this._transaction;
				}
				if ((this.Adapter == null ? false : this.Adapter.UpdateCommand != null))
				{
					this.Adapter.UpdateCommand.Transaction = this._transaction;
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TVisitanteVisitaProgramadaTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_idVisitante, decimal Original_idVisitaProgramada, int? Original_idEmpleadoAutorizaEntrada, DateTime? Original_fechaLlegada, DateTime? Original_fechaSalida, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_visitacumplida, string Original_tarjeta, int? Original_idTarjeta, decimal Original_idTabla)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idVisitante;
			this.Adapter.DeleteCommand.Parameters[1].Value = Original_idVisitaProgramada;
			if (!Original_idEmpleadoAutorizaEntrada.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 1;
				this.Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 0;
				this.Adapter.DeleteCommand.Parameters[3].Value = Original_idEmpleadoAutorizaEntrada.Value;
			}
			if (!Original_fechaLlegada.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 1;
				this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 0;
				this.Adapter.DeleteCommand.Parameters[5].Value = Original_fechaLlegada.Value;
			}
			if (!Original_fechaSalida.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 1;
				this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 0;
				this.Adapter.DeleteCommand.Parameters[7].Value = Original_fechaSalida.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 1;
				this.Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 0;
				this.Adapter.DeleteCommand.Parameters[9].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[10].Value = 1;
				this.Adapter.DeleteCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[10].Value = 0;
				this.Adapter.DeleteCommand.Parameters[11].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_visitacumplida.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[12].Value = 1;
				this.Adapter.DeleteCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[12].Value = 0;
				this.Adapter.DeleteCommand.Parameters[13].Value = Original_visitacumplida.Value;
			}
			if (Original_tarjeta != null)
			{
				this.Adapter.DeleteCommand.Parameters[14].Value = 0;
				this.Adapter.DeleteCommand.Parameters[15].Value = Original_tarjeta;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[14].Value = 1;
				this.Adapter.DeleteCommand.Parameters[15].Value = DBNull.Value;
			}
			if (!Original_idTarjeta.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[16].Value = 1;
				this.Adapter.DeleteCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[16].Value = 0;
				this.Adapter.DeleteCommand.Parameters[17].Value = Original_idTarjeta.Value;
			}
			this.Adapter.DeleteCommand.Parameters[18].Value = Original_idTabla;
			ConnectionState state = this.Adapter.DeleteCommand.Connection.State;
			if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.DeleteCommand.Connection.Open();
			}
			try
			{
				num = this.Adapter.DeleteCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					this.Adapter.DeleteCommand.Connection.Close();
				}
			}
			return num;
		}

		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(masterDBACDataSet.TVisitanteVisitaProgramadaDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		[DataObjectMethod(DataObjectMethodType.Select, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual masterDBACDataSet.TVisitanteVisitaProgramadaDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TVisitanteVisitaProgramadaDataTable tVisitanteVisitaProgramadaDataTable = new masterDBACDataSet.TVisitanteVisitaProgramadaDataTable();
			this.Adapter.Fill(tVisitanteVisitaProgramadaDataTable);
			return tVisitanteVisitaProgramadaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TVisitanteVisitaProgramada"
			};
			dataTableMapping.ColumnMappings.Add("idVisitante", "idVisitante");
			dataTableMapping.ColumnMappings.Add("idVisitaProgramada", "idVisitaProgramada");
			dataTableMapping.ColumnMappings.Add("idEmpleadoAutorizaEntrada", "idEmpleadoAutorizaEntrada");
			dataTableMapping.ColumnMappings.Add("fechaLlegada", "fechaLlegada");
			dataTableMapping.ColumnMappings.Add("fechaSalida", "fechaSalida");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("visitacumplida", "visitacumplida");
			dataTableMapping.ColumnMappings.Add("tarjeta", "tarjeta");
			dataTableMapping.ColumnMappings.Add("idTarjeta", "idTarjeta");
			dataTableMapping.ColumnMappings.Add("ObservacionesVisita", "ObservacionesVisita");
			dataTableMapping.ColumnMappings.Add("idTabla", "idTabla");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TVisitanteVisitaProgramada] WHERE (([idVisitante] = @Original_idVisitante) AND ([idVisitaProgramada] = @Original_idVisitaProgramada) AND ((@IsNull_idEmpleadoAutorizaEntrada = 1 AND [idEmpleadoAutorizaEntrada] IS NULL) OR ([idEmpleadoAutorizaEntrada] = @Original_idEmpleadoAutorizaEntrada)) AND ((@IsNull_fechaLlegada = 1 AND [fechaLlegada] IS NULL) OR ([fechaLlegada] = @Original_fechaLlegada)) AND ((@IsNull_fechaSalida = 1 AND [fechaSalida] IS NULL) OR ([fechaSalida] = @Original_fechaSalida)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_visitacumplida = 1 AND [visitacumplida] IS NULL) OR ([visitacumplida] = @Original_visitacumplida)) AND ((@IsNull_tarjeta = 1 AND [tarjeta] IS NULL) OR ([tarjeta] = @Original_tarjeta)) AND ((@IsNull_idTarjeta = 1 AND [idTarjeta] IS NULL) OR ([idTarjeta] = @Original_idTarjeta)) AND ([idTabla] = @Original_idTabla))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVisitaProgramada", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleadoAutorizaEntrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleadoAutorizaEntrada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpleadoAutorizaEntrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleadoAutorizaEntrada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaLlegada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaLlegada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaLlegada", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaLlegada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaSalida", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaSalida", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaSalida", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaSalida", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_visitacumplida", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "visitacumplida", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_visitacumplida", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "visitacumplida", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_tarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "tarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_tarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "tarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTabla", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idTabla", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TVisitanteVisitaProgramada] ([idVisitante], [idVisitaProgramada], [idEmpleadoAutorizaEntrada], [fechaLlegada], [fechaSalida], [fechaUltimaGestion], [usuarioUltimaGestion], [visitacumplida], [tarjeta], [idTarjeta], [ObservacionesVisita]) VALUES (@idVisitante, @idVisitaProgramada, @idEmpleadoAutorizaEntrada, @fechaLlegada, @fechaSalida, @fechaUltimaGestion, @usuarioUltimaGestion, @visitacumplida, @tarjeta, @idTarjeta, @ObservacionesVisita);\r\nSELECT idVisitante, idVisitaProgramada, idEmpleadoAutorizaEntrada, fechaLlegada, fechaSalida, fechaUltimaGestion, usuarioUltimaGestion, visitacumplida, tarjeta, idTarjeta, ObservacionesVisita, idTabla FROM TVisitanteVisitaProgramada WHERE (idVisitaProgramada = @idVisitaProgramada) AND (idVisitante = @idVisitante)",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idVisitaProgramada", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpleadoAutorizaEntrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleadoAutorizaEntrada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaLlegada", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaLlegada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaSalida", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaSalida", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@visitacumplida", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "visitacumplida", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@tarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "tarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacionesVisita", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TVisitanteVisitaProgramada] SET [idVisitante] = @idVisitante, [idVisitaProgramada] = @idVisitaProgramada, [idEmpleadoAutorizaEntrada] = @idEmpleadoAutorizaEntrada, [fechaLlegada] = @fechaLlegada, [fechaSalida] = @fechaSalida, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [visitacumplida] = @visitacumplida, [tarjeta] = @tarjeta, [idTarjeta] = @idTarjeta, [ObservacionesVisita] = @ObservacionesVisita WHERE (([idVisitante] = @Original_idVisitante) AND ([idVisitaProgramada] = @Original_idVisitaProgramada) AND ((@IsNull_idEmpleadoAutorizaEntrada = 1 AND [idEmpleadoAutorizaEntrada] IS NULL) OR ([idEmpleadoAutorizaEntrada] = @Original_idEmpleadoAutorizaEntrada)) AND ((@IsNull_fechaLlegada = 1 AND [fechaLlegada] IS NULL) OR ([fechaLlegada] = @Original_fechaLlegada)) AND ((@IsNull_fechaSalida = 1 AND [fechaSalida] IS NULL) OR ([fechaSalida] = @Original_fechaSalida)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_visitacumplida = 1 AND [visitacumplida] IS NULL) OR ([visitacumplida] = @Original_visitacumplida)) AND ((@IsNull_tarjeta = 1 AND [tarjeta] IS NULL) OR ([tarjeta] = @Original_tarjeta)) AND ((@IsNull_idTarjeta = 1 AND [idTarjeta] IS NULL) OR ([idTarjeta] = @Original_idTarjeta)) AND ([idTabla] = @Original_idTabla));\r\nSELECT idVisitante, idVisitaProgramada, idEmpleadoAutorizaEntrada, fechaLlegada, fechaSalida, fechaUltimaGestion, usuarioUltimaGestion, visitacumplida, tarjeta, idTarjeta, ObservacionesVisita, idTabla FROM TVisitanteVisitaProgramada WHERE (idVisitaProgramada = @idVisitaProgramada) AND (idVisitante = @idVisitante)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVisitaProgramada", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpleadoAutorizaEntrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleadoAutorizaEntrada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaLlegada", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaLlegada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaSalida", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaSalida", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@visitacumplida", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "visitacumplida", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@tarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "tarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacionesVisita", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVisitaProgramada", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleadoAutorizaEntrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleadoAutorizaEntrada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpleadoAutorizaEntrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleadoAutorizaEntrada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaLlegada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaLlegada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaLlegada", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaLlegada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaSalida", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaSalida", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaSalida", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaSalida", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_visitacumplida", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "visitacumplida", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_visitacumplida", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "visitacumplida", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_tarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "tarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_tarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "tarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTabla", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idTabla", DataRowVersion.Original, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idVisitante, idVisitaProgramada, idEmpleadoAutorizaEntrada, fechaLlegada, fechaSalida, fechaUltimaGestion, usuarioUltimaGestion, visitacumplida, tarjeta, idTarjeta, ObservacionesVisita, idTabla FROM TVisitanteVisitaProgramada";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection()
			{
				ConnectionString = Settings.Default.masterDBACConnectionString
			};
		}

		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Insert(decimal idVisitante, decimal idVisitaProgramada, int? idEmpleadoAutorizaEntrada, DateTime? fechaLlegada, DateTime? fechaSalida, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? visitacumplida, string tarjeta, int? idTarjeta, string ObservacionesVisita)
		{
			int num;
			this.Adapter.InsertCommand.Parameters[0].Value = idVisitante;
			this.Adapter.InsertCommand.Parameters[1].Value = idVisitaProgramada;
			if (!idEmpleadoAutorizaEntrada.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = idEmpleadoAutorizaEntrada.Value;
			}
			if (!fechaLlegada.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = fechaLlegada.Value;
			}
			if (!fechaSalida.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = fechaSalida.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = usuarioUltimaGestion.Value;
			}
			if (!visitacumplida.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = visitacumplida.Value;
			}
			if (tarjeta != null)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = tarjeta;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			if (!idTarjeta.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = idTarjeta.Value;
			}
			if (ObservacionesVisita != null)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = ObservacionesVisita;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			ConnectionState state = this.Adapter.InsertCommand.Connection.State;
			if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.InsertCommand.Connection.Open();
			}
			try
			{
				num = this.Adapter.InsertCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					this.Adapter.InsertCommand.Connection.Close();
				}
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet.TVisitanteVisitaProgramadaDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TVisitanteVisitaProgramada");
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[] { dataRow });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}

		[DataObjectMethod(DataObjectMethodType.Update, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(decimal idVisitante, decimal idVisitaProgramada, int? idEmpleadoAutorizaEntrada, DateTime? fechaLlegada, DateTime? fechaSalida, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? visitacumplida, string tarjeta, int? idTarjeta, string ObservacionesVisita, decimal Original_idVisitante, decimal Original_idVisitaProgramada, int? Original_idEmpleadoAutorizaEntrada, DateTime? Original_fechaLlegada, DateTime? Original_fechaSalida, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_visitacumplida, string Original_tarjeta, int? Original_idTarjeta, decimal Original_idTabla)
		{
			int num;
			this.Adapter.UpdateCommand.Parameters[0].Value = idVisitante;
			this.Adapter.UpdateCommand.Parameters[1].Value = idVisitaProgramada;
			if (!idEmpleadoAutorizaEntrada.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = idEmpleadoAutorizaEntrada.Value;
			}
			if (!fechaLlegada.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = fechaLlegada.Value;
			}
			if (!fechaSalida.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = fechaSalida.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = usuarioUltimaGestion.Value;
			}
			if (!visitacumplida.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = visitacumplida.Value;
			}
			if (tarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = tarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			if (!idTarjeta.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = idTarjeta.Value;
			}
			if (ObservacionesVisita != null)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = ObservacionesVisita;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[11].Value = Original_idVisitante;
			this.Adapter.UpdateCommand.Parameters[12].Value = Original_idVisitaProgramada;
			if (!Original_idEmpleadoAutorizaEntrada.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_idEmpleadoAutorizaEntrada.Value;
			}
			if (!Original_fechaLlegada.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_fechaLlegada.Value;
			}
			if (!Original_fechaSalida.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_fechaSalida.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 1;
				this.Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 0;
				this.Adapter.UpdateCommand.Parameters[20].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 1;
				this.Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 0;
				this.Adapter.UpdateCommand.Parameters[22].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_visitacumplida.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 1;
				this.Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 0;
				this.Adapter.UpdateCommand.Parameters[24].Value = Original_visitacumplida.Value;
			}
			if (Original_tarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[25].Value = 0;
				this.Adapter.UpdateCommand.Parameters[26].Value = Original_tarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[25].Value = 1;
				this.Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
			}
			if (!Original_idTarjeta.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[27].Value = 1;
				this.Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[27].Value = 0;
				this.Adapter.UpdateCommand.Parameters[28].Value = Original_idTarjeta.Value;
			}
			this.Adapter.UpdateCommand.Parameters[29].Value = Original_idTabla;
			ConnectionState state = this.Adapter.UpdateCommand.Connection.State;
			if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.UpdateCommand.Connection.Open();
			}
			try
			{
				num = this.Adapter.UpdateCommand.ExecuteNonQuery();
			}
			finally
			{
				if (state == ConnectionState.Closed)
				{
					this.Adapter.UpdateCommand.Connection.Close();
				}
			}
			return num;
		}

		[DataObjectMethod(DataObjectMethodType.Update, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(int? idEmpleadoAutorizaEntrada, DateTime? fechaLlegada, DateTime? fechaSalida, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? visitacumplida, string tarjeta, int? idTarjeta, string ObservacionesVisita, decimal Original_idVisitante, decimal Original_idVisitaProgramada, int? Original_idEmpleadoAutorizaEntrada, DateTime? Original_fechaLlegada, DateTime? Original_fechaSalida, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_visitacumplida, string Original_tarjeta, int? Original_idTarjeta, decimal Original_idTabla)
		{
			int num = this.Update(Original_idVisitante, Original_idVisitaProgramada, idEmpleadoAutorizaEntrada, fechaLlegada, fechaSalida, fechaUltimaGestion, usuarioUltimaGestion, visitacumplida, tarjeta, idTarjeta, ObservacionesVisita, Original_idVisitante, Original_idVisitaProgramada, Original_idEmpleadoAutorizaEntrada, Original_fechaLlegada, Original_fechaSalida, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_visitacumplida, Original_tarjeta, Original_idTarjeta, Original_idTabla);
			return num;
		}
	}
}