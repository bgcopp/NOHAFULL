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
	public class TTarjetaTableAdapter : Component
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
		public TTarjetaTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idTarjeta, string Original_numtarjeta, int? Original_idHorario, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_activa, bool? Original_esvisitante, bool? Original_esutilizada, DateTime? Original_fechavisi1, DateTime? Original_fechavisi2)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idTarjeta;
			if (Original_numtarjeta != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_numtarjeta;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!Original_idHorario.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_idHorario.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_activa.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_activa.Value;
			}
			if (!Original_esvisitante.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_esvisitante.Value;
			}
			if (!Original_esutilizada.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 1;
				this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 0;
				this.Adapter.DeleteCommand.Parameters[14].Value = Original_esutilizada.Value;
			}
			if (!Original_fechavisi1.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 1;
				this.Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 0;
				this.Adapter.DeleteCommand.Parameters[16].Value = Original_fechavisi1.Value;
			}
			if (!Original_fechavisi2.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 1;
				this.Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 0;
				this.Adapter.DeleteCommand.Parameters[18].Value = Original_fechavisi2.Value;
			}
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
		public virtual int Fill(masterDBACDataSet.TTarjetaDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		[DataObjectMethod(DataObjectMethodType.Fill, false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int FillBy(masterDBACDataSet.TTarjetaDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		[DataObjectMethod(DataObjectMethodType.Fill, false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int FillByNoutilizada(masterDBACDataSet.TTarjetaDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[2];
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
		public virtual masterDBACDataSet.TTarjetaDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TTarjetaDataTable tTarjetaDataTable = new masterDBACDataSet.TTarjetaDataTable();
			this.Adapter.Fill(tTarjetaDataTable);
			return tTarjetaDataTable;
		}

		[DataObjectMethod(DataObjectMethodType.Select, false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual masterDBACDataSet.TTarjetaDataTable GetDataSinUtilizar()
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
			masterDBACDataSet.TTarjetaDataTable tTarjetaDataTable = new masterDBACDataSet.TTarjetaDataTable();
			this.Adapter.Fill(tTarjetaDataTable);
			return tTarjetaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TTarjeta"
			};
			dataTableMapping.ColumnMappings.Add("idTarjeta", "idTarjeta");
			dataTableMapping.ColumnMappings.Add("numtarjeta", "numtarjeta");
			dataTableMapping.ColumnMappings.Add("idHorario", "idHorario");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("activa", "activa");
			dataTableMapping.ColumnMappings.Add("esvisitante", "esvisitante");
			dataTableMapping.ColumnMappings.Add("esutilizada", "esutilizada");
			dataTableMapping.ColumnMappings.Add("fechavisi1", "fechavisi1");
			dataTableMapping.ColumnMappings.Add("fechavisi2", "fechavisi2");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TTarjeta] WHERE (([idTarjeta] = @Original_idTarjeta) AND ((@IsNull_numtarjeta = 1 AND [numtarjeta] IS NULL) OR ([numtarjeta] = @Original_numtarjeta)) AND ((@IsNull_idHorario = 1 AND [idHorario] IS NULL) OR ([idHorario] = @Original_idHorario)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_activa = 1 AND [activa] IS NULL) OR ([activa] = @Original_activa)) AND ((@IsNull_esvisitante = 1 AND [esvisitante] IS NULL) OR ([esvisitante] = @Original_esvisitante)) AND ((@IsNull_esutilizada = 1 AND [esutilizada] IS NULL) OR ([esutilizada] = @Original_esutilizada)) AND ((@IsNull_fechavisi1 = 1 AND [fechavisi1] IS NULL) OR ([fechavisi1] = @Original_fechavisi1)) AND ((@IsNull_fechavisi2 = 1 AND [fechavisi2] IS NULL) OR ([fechavisi2] = @Original_fechavisi2)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_numtarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "numtarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_numtarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "numtarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_activa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "activa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_activa", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "activa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_esvisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esvisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_esvisitante", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esvisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_esutilizada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esutilizada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_esutilizada", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esutilizada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechavisi1", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechavisi1", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechavisi1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi1", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechavisi2", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechavisi2", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechavisi2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi2", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TTarjeta] ([numtarjeta], [idHorario], [fechaUltimaGestion], [usuarioUltimaGestion], [activa], [esvisitante], [esutilizada], [fechavisi1], [fechavisi2]) VALUES (@numtarjeta, @idHorario, @fechaUltimaGestion, @usuarioUltimaGestion, @activa, @esvisitante, @esutilizada, @fechavisi1, @fechavisi2);\r\nSELECT idTarjeta, numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2 FROM TTarjeta WHERE (idTarjeta = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@numtarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "numtarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@activa", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "activa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@esvisitante", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esvisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@esutilizada", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esutilizada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechavisi1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi1", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechavisi2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi2", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TTarjeta] SET [numtarjeta] = @numtarjeta, [idHorario] = @idHorario, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [activa] = @activa, [esvisitante] = @esvisitante, [esutilizada] = @esutilizada, [fechavisi1] = @fechavisi1, [fechavisi2] = @fechavisi2 WHERE (([idTarjeta] = @Original_idTarjeta) AND ((@IsNull_numtarjeta = 1 AND [numtarjeta] IS NULL) OR ([numtarjeta] = @Original_numtarjeta)) AND ((@IsNull_idHorario = 1 AND [idHorario] IS NULL) OR ([idHorario] = @Original_idHorario)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_activa = 1 AND [activa] IS NULL) OR ([activa] = @Original_activa)) AND ((@IsNull_esvisitante = 1 AND [esvisitante] IS NULL) OR ([esvisitante] = @Original_esvisitante)) AND ((@IsNull_esutilizada = 1 AND [esutilizada] IS NULL) OR ([esutilizada] = @Original_esutilizada)) AND ((@IsNull_fechavisi1 = 1 AND [fechavisi1] IS NULL) OR ([fechavisi1] = @Original_fechavisi1)) AND ((@IsNull_fechavisi2 = 1 AND [fechavisi2] IS NULL) OR ([fechavisi2] = @Original_fechavisi2)));\r\nSELECT idTarjeta, numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2 FROM TTarjeta WHERE (idTarjeta = @idTarjeta)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@numtarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "numtarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@activa", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "activa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@esvisitante", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esvisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@esutilizada", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esutilizada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechavisi1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi1", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechavisi2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi2", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_numtarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "numtarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_numtarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "numtarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_activa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "activa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_activa", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "activa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_esvisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esvisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_esvisitante", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esvisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_esutilizada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esutilizada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_esutilizada", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esutilizada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechavisi1", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechavisi1", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechavisi1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi1", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechavisi2", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechavisi2", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechavisi2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechavisi2", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTarjeta", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand(), null, null };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        idTarjeta, numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2\r\nFROM            TTarjeta";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[1] = new SqlCommand();
			this._commandCollection[1].Connection = this.Connection;
			this._commandCollection[1].CommandText = "SELECT        idTarjeta, numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2\r\nFROM            TTarjeta\r\nWHERE        (esutilizada = 0)";
			this._commandCollection[1].CommandType = CommandType.Text;
			this._commandCollection[2] = new SqlCommand();
			this._commandCollection[2].Connection = this.Connection;
			this._commandCollection[2].CommandText = "SELECT        idTarjeta, numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2\r\nFROM            TTarjeta\r\nWHERE       esutilizada <> 1 or esutilizada is null";
			this._commandCollection[2].CommandType = CommandType.Text;
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
		public virtual int Insert(string numtarjeta, int? idHorario, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? activa, bool? esvisitante, bool? esutilizada, DateTime? fechavisi1, DateTime? fechavisi2)
		{
			int num;
			if (numtarjeta != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = numtarjeta;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!idHorario.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = idHorario.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = usuarioUltimaGestion.Value;
			}
			if (!activa.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = activa.Value;
			}
			if (!esvisitante.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = esvisitante.Value;
			}
			if (!esutilizada.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = esutilizada.Value;
			}
			if (!fechavisi1.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = fechavisi1.Value;
			}
			if (!fechavisi2.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = fechavisi2.Value;
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
		public virtual int Update(masterDBACDataSet.TTarjetaDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TTarjeta");
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
		public virtual int Update(string numtarjeta, int? idHorario, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? activa, bool? esvisitante, bool? esutilizada, DateTime? fechavisi1, DateTime? fechavisi2, int Original_idTarjeta, string Original_numtarjeta, int? Original_idHorario, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_activa, bool? Original_esvisitante, bool? Original_esutilizada, DateTime? Original_fechavisi1, DateTime? Original_fechavisi2, int idTarjeta)
		{
			int num;
			if (numtarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = numtarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!idHorario.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = idHorario.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = usuarioUltimaGestion.Value;
			}
			if (!activa.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = activa.Value;
			}
			if (!esvisitante.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = esvisitante.Value;
			}
			if (!esutilizada.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = esutilizada.Value;
			}
			if (!fechavisi1.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = fechavisi1.Value;
			}
			if (!fechavisi2.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = fechavisi2.Value;
			}
			this.Adapter.UpdateCommand.Parameters[9].Value = Original_idTarjeta;
			if (Original_numtarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 0;
				this.Adapter.UpdateCommand.Parameters[11].Value = Original_numtarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 1;
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			if (!Original_idHorario.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 1;
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 0;
				this.Adapter.UpdateCommand.Parameters[13].Value = Original_idHorario.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 1;
				this.Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 0;
				this.Adapter.UpdateCommand.Parameters[17].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_activa.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 1;
				this.Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 0;
				this.Adapter.UpdateCommand.Parameters[19].Value = Original_activa.Value;
			}
			if (!Original_esvisitante.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 1;
				this.Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 0;
				this.Adapter.UpdateCommand.Parameters[21].Value = Original_esvisitante.Value;
			}
			if (!Original_esutilizada.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 1;
				this.Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 0;
				this.Adapter.UpdateCommand.Parameters[23].Value = Original_esutilizada.Value;
			}
			if (!Original_fechavisi1.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 1;
				this.Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 0;
				this.Adapter.UpdateCommand.Parameters[25].Value = Original_fechavisi1.Value;
			}
			if (!Original_fechavisi2.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[26].Value = 1;
				this.Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[26].Value = 0;
				this.Adapter.UpdateCommand.Parameters[27].Value = Original_fechavisi2.Value;
			}
			this.Adapter.UpdateCommand.Parameters[28].Value = idTarjeta;
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
		public virtual int Update(string numtarjeta, int? idHorario, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? activa, bool? esvisitante, bool? esutilizada, DateTime? fechavisi1, DateTime? fechavisi2, int Original_idTarjeta, string Original_numtarjeta, int? Original_idHorario, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_activa, bool? Original_esvisitante, bool? Original_esutilizada, DateTime? Original_fechavisi1, DateTime? Original_fechavisi2)
		{
			int num = this.Update(numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2, Original_idTarjeta, Original_numtarjeta, Original_idHorario, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_activa, Original_esvisitante, Original_esutilizada, Original_fechavisi1, Original_fechavisi2, Original_idTarjeta);
			return num;
		}
	}
}