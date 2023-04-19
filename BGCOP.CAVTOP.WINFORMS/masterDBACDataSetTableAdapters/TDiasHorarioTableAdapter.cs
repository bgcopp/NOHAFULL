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
	public class TDiasHorarioTableAdapter : Component
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
		public TDiasHorarioTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idDiasHorario, int? Original_idHorario, byte? Original_dia, string Original_entrada, string Original_salida, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idDiasHorario;
			if (!Original_idHorario.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_idHorario.Value;
			}
			if (!Original_dia.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_dia.Value;
			}
			if (Original_entrada != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_entrada;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			if (Original_salida != null)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_salida;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_usuarioUltimaGestion.Value;
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
		public virtual int Fill(masterDBACDataSet.TDiasHorarioDataTable dataTable)
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
		public virtual masterDBACDataSet.TDiasHorarioDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TDiasHorarioDataTable tDiasHorarioDataTable = new masterDBACDataSet.TDiasHorarioDataTable();
			this.Adapter.Fill(tDiasHorarioDataTable);
			return tDiasHorarioDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TDiasHorario"
			};
			dataTableMapping.ColumnMappings.Add("idDiasHorario", "idDiasHorario");
			dataTableMapping.ColumnMappings.Add("idHorario", "idHorario");
			dataTableMapping.ColumnMappings.Add("dia", "dia");
			dataTableMapping.ColumnMappings.Add("entrada", "entrada");
			dataTableMapping.ColumnMappings.Add("salida", "salida");
			dataTableMapping.ColumnMappings.Add("ObservacionesDia", "ObservacionesDia");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[TDiasHorario] WHERE (([idDiasHorario] = @Original_idDiasHorario) AND ((@IsNull_idHorario = 1 AND [idHorario] IS NULL) OR ([idHorario] = @Original_idHorario)) AND ((@IsNull_dia = 1 AND [dia] IS NULL) OR ([dia] = @Original_dia)) AND ((@IsNull_entrada = 1 AND [entrada] IS NULL) OR ([entrada] = @Original_entrada)) AND ((@IsNull_salida = 1 AND [salida] IS NULL) OR ([salida] = @Original_salida)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idDiasHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idDiasHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "dia", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_entrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "entrada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_entrada", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "entrada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_salida", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "salida", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_salida", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "salida", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[TDiasHorario] ([idHorario], [dia], [entrada], [salida], [ObservacionesDia], [fechaUltimaGestion], [usuarioUltimaGestion]) VALUES (@idHorario, @dia, @entrada, @salida, @ObservacionesDia, @fechaUltimaGestion, @usuarioUltimaGestion);\r\nSELECT idDiasHorario, idHorario, dia, entrada, salida, ObservacionesDia, fechaUltimaGestion, usuarioUltimaGestion FROM TDiasHorario WHERE (idDiasHorario = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "dia", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@entrada", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "entrada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@salida", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "salida", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacionesDia", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesDia", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[TDiasHorario] SET [idHorario] = @idHorario, [dia] = @dia, [entrada] = @entrada, [salida] = @salida, [ObservacionesDia] = @ObservacionesDia, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion WHERE (([idDiasHorario] = @Original_idDiasHorario) AND ((@IsNull_idHorario = 1 AND [idHorario] IS NULL) OR ([idHorario] = @Original_idHorario)) AND ((@IsNull_dia = 1 AND [dia] IS NULL) OR ([dia] = @Original_dia)) AND ((@IsNull_entrada = 1 AND [entrada] IS NULL) OR ([entrada] = @Original_entrada)) AND ((@IsNull_salida = 1 AND [salida] IS NULL) OR ([salida] = @Original_salida)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)));\r\nSELECT idDiasHorario, idHorario, dia, entrada, salida, ObservacionesDia, fechaUltimaGestion, usuarioUltimaGestion FROM TDiasHorario WHERE (idDiasHorario = @idDiasHorario)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "dia", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@entrada", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "entrada", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@salida", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "salida", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacionesDia", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesDia", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idDiasHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idDiasHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "dia", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_entrada", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "entrada", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_entrada", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "entrada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_salida", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "salida", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_salida", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "salida", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idDiasHorario", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idDiasHorario", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idDiasHorario, idHorario, dia, entrada, salida, ObservacionesDia, fechaUltimaGestion, usuarioUltimaGestion FROM dbo.TDiasHorario";
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
		public virtual int Insert(int? idHorario, byte? dia, string entrada, string salida, string ObservacionesDia, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion)
		{
			int num;
			if (!idHorario.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = idHorario.Value;
			}
			if (!dia.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = dia.Value;
			}
			if (entrada != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = entrada;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (salida != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = salida;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (ObservacionesDia != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = ObservacionesDia;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
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
		public virtual int Update(masterDBACDataSet.TDiasHorarioDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TDiasHorario");
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
		public virtual int Update(int? idHorario, byte? dia, string entrada, string salida, string ObservacionesDia, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int Original_idDiasHorario, int? Original_idHorario, byte? Original_dia, string Original_entrada, string Original_salida, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int idDiasHorario)
		{
			int num;
			if (!idHorario.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = idHorario.Value;
			}
			if (!dia.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = dia.Value;
			}
			if (entrada != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = entrada;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			if (salida != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = salida;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			if (ObservacionesDia != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = ObservacionesDia;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
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
			this.Adapter.UpdateCommand.Parameters[7].Value = Original_idDiasHorario;
			if (!Original_idHorario.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 1;
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 0;
				this.Adapter.UpdateCommand.Parameters[9].Value = Original_idHorario.Value;
			}
			if (!Original_dia.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 1;
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 0;
				this.Adapter.UpdateCommand.Parameters[11].Value = Original_dia.Value;
			}
			if (Original_entrada != null)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 0;
				this.Adapter.UpdateCommand.Parameters[13].Value = Original_entrada;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 1;
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			if (Original_salida != null)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_salida;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 1;
				this.Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 0;
				this.Adapter.UpdateCommand.Parameters[17].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 1;
				this.Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 0;
				this.Adapter.UpdateCommand.Parameters[19].Value = Original_usuarioUltimaGestion.Value;
			}
			this.Adapter.UpdateCommand.Parameters[20].Value = idDiasHorario;
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
		public virtual int Update(int? idHorario, byte? dia, string entrada, string salida, string ObservacionesDia, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int Original_idDiasHorario, int? Original_idHorario, byte? Original_dia, string Original_entrada, string Original_salida, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion)
		{
			int num = this.Update(idHorario, dia, entrada, salida, ObservacionesDia, fechaUltimaGestion, usuarioUltimaGestion, Original_idDiasHorario, Original_idHorario, Original_dia, Original_entrada, Original_salida, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_idDiasHorario);
			return num;
		}
	}
}