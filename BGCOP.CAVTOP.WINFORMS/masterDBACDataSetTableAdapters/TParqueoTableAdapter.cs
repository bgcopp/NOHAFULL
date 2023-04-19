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
	public class TParqueoTableAdapter : Component
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
		public TParqueoTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idParqueadero, string Original_nParqueo, string Original_observacionesParqueo, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_estaocupado, string Original_ocupadopor)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idParqueadero;
			if (Original_nParqueo != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_nParqueo;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Original_observacionesParqueo != null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_observacionesParqueo;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
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
			if (!Original_estaocupado.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_estaocupado.Value;
			}
			if (Original_ocupadopor != null)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_ocupadopor;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
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
		public virtual int Fill(masterDBACDataSet.TParqueoDataTable dataTable)
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
		public virtual masterDBACDataSet.TParqueoDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TParqueoDataTable tParqueoDataTable = new masterDBACDataSet.TParqueoDataTable();
			this.Adapter.Fill(tParqueoDataTable);
			return tParqueoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TParqueo"
			};
			dataTableMapping.ColumnMappings.Add("idParqueadero", "idParqueadero");
			dataTableMapping.ColumnMappings.Add("nParqueo", "nParqueo");
			dataTableMapping.ColumnMappings.Add("observacionesParqueo", "observacionesParqueo");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("estaocupado", "estaocupado");
			dataTableMapping.ColumnMappings.Add("ocupadopor", "ocupadopor");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TParqueo] WHERE (([idParqueadero] = @Original_idParqueadero) AND ((@IsNull_nParqueo = 1 AND [nParqueo] IS NULL) OR ([nParqueo] = @Original_nParqueo)) AND ((@IsNull_observacionesParqueo = 1 AND [observacionesParqueo] IS NULL) OR ([observacionesParqueo] = @Original_observacionesParqueo)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_estaocupado = 1 AND [estaocupado] IS NULL) OR ([estaocupado] = @Original_estaocupado)) AND ((@IsNull_ocupadopor = 1 AND [ocupadopor] IS NULL) OR ([ocupadopor] = @Original_ocupadopor)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_nParqueo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "nParqueo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_nParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nParqueo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_observacionesParqueo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "observacionesParqueo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_observacionesParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observacionesParqueo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_estaocupado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "estaocupado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_estaocupado", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "estaocupado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_ocupadopor", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ocupadopor", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ocupadopor", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ocupadopor", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TParqueo] ([nParqueo], [observacionesParqueo], [fechaUltimaGestion], [usuarioUltimaGestion], [estaocupado], [ocupadopor]) VALUES (@nParqueo, @observacionesParqueo, @fechaUltimaGestion, @usuarioUltimaGestion, @estaocupado, @ocupadopor);\r\nSELECT idParqueadero, nParqueo, observacionesParqueo, fechaUltimaGestion, usuarioUltimaGestion, estaocupado, ocupadopor FROM TParqueo WHERE (idParqueadero = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@nParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nParqueo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@observacionesParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observacionesParqueo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@estaocupado", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "estaocupado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ocupadopor", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ocupadopor", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TParqueo] SET [nParqueo] = @nParqueo, [observacionesParqueo] = @observacionesParqueo, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [estaocupado] = @estaocupado, [ocupadopor] = @ocupadopor WHERE (([idParqueadero] = @Original_idParqueadero) AND ((@IsNull_nParqueo = 1 AND [nParqueo] IS NULL) OR ([nParqueo] = @Original_nParqueo)) AND ((@IsNull_observacionesParqueo = 1 AND [observacionesParqueo] IS NULL) OR ([observacionesParqueo] = @Original_observacionesParqueo)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_estaocupado = 1 AND [estaocupado] IS NULL) OR ([estaocupado] = @Original_estaocupado)) AND ((@IsNull_ocupadopor = 1 AND [ocupadopor] IS NULL) OR ([ocupadopor] = @Original_ocupadopor)));\r\nSELECT idParqueadero, nParqueo, observacionesParqueo, fechaUltimaGestion, usuarioUltimaGestion, estaocupado, ocupadopor FROM TParqueo WHERE (idParqueadero = @idParqueadero)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@nParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nParqueo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@observacionesParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observacionesParqueo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@estaocupado", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "estaocupado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ocupadopor", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ocupadopor", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_nParqueo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "nParqueo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_nParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nParqueo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_observacionesParqueo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "observacionesParqueo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_observacionesParqueo", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observacionesParqueo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_estaocupado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "estaocupado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_estaocupado", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "estaocupado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_ocupadopor", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "ocupadopor", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ocupadopor", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ocupadopor", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idParqueadero", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        idParqueadero, nParqueo, observacionesParqueo, fechaUltimaGestion, usuarioUltimaGestion, estaocupado, ocupadopor\r\nFROM            TParqueo";
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
		public virtual int Insert(string nParqueo, string observacionesParqueo, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? estaocupado, string ocupadopor)
		{
			int num;
			if (nParqueo != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = nParqueo;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (observacionesParqueo != null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = observacionesParqueo;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
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
			if (!estaocupado.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = estaocupado.Value;
			}
			if (ocupadopor != null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = ocupadopor;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
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
		public virtual int Update(masterDBACDataSet.TParqueoDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TParqueo");
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
		public virtual int Update(string nParqueo, string observacionesParqueo, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? estaocupado, string ocupadopor, int Original_idParqueadero, string Original_nParqueo, string Original_observacionesParqueo, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_estaocupado, string Original_ocupadopor, int idParqueadero)
		{
			int num;
			if (nParqueo != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = nParqueo;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (observacionesParqueo != null)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = observacionesParqueo;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
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
			if (!estaocupado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = estaocupado.Value;
			}
			if (ocupadopor != null)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = ocupadopor;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[6].Value = Original_idParqueadero;
			if (Original_nParqueo != null)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 0;
				this.Adapter.UpdateCommand.Parameters[8].Value = Original_nParqueo;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 1;
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			if (Original_observacionesParqueo != null)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_observacionesParqueo;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 1;
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 0;
				this.Adapter.UpdateCommand.Parameters[12].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_estaocupado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_estaocupado.Value;
			}
			if (Original_ocupadopor != null)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_ocupadopor;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[19].Value = idParqueadero;
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
		public virtual int Update(string nParqueo, string observacionesParqueo, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? estaocupado, string ocupadopor, int Original_idParqueadero, string Original_nParqueo, string Original_observacionesParqueo, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_estaocupado, string Original_ocupadopor)
		{
			int num = this.Update(nParqueo, observacionesParqueo, fechaUltimaGestion, usuarioUltimaGestion, estaocupado, ocupadopor, Original_idParqueadero, Original_nParqueo, Original_observacionesParqueo, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_estaocupado, Original_ocupadopor, Original_idParqueadero);
			return num;
		}
	}
}