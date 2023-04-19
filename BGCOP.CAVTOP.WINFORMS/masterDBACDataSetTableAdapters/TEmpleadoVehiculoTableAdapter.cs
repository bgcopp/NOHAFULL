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
	public class TEmpleadoVehiculoTableAdapter : Component
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
		public TEmpleadoVehiculoTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int? Original_IdEmpleado, int? Original_IdVehiculo, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int Original_id)
		{
			int num;
			if (!Original_IdEmpleado.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[0].Value = 1;
				this.Adapter.DeleteCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[0].Value = 0;
				this.Adapter.DeleteCommand.Parameters[1].Value = Original_IdEmpleado.Value;
			}
			if (!Original_IdVehiculo.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 1;
				this.Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 0;
				this.Adapter.DeleteCommand.Parameters[3].Value = Original_IdVehiculo.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 1;
				this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 0;
				this.Adapter.DeleteCommand.Parameters[5].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 1;
				this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 0;
				this.Adapter.DeleteCommand.Parameters[7].Value = Original_usuarioUltimaGestion.Value;
			}
			this.Adapter.DeleteCommand.Parameters[8].Value = Original_id;
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
		public virtual int Fill(masterDBACDataSet.TEmpleadoVehiculoDataTable dataTable)
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
		public virtual masterDBACDataSet.TEmpleadoVehiculoDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TEmpleadoVehiculoDataTable tEmpleadoVehiculoDataTable = new masterDBACDataSet.TEmpleadoVehiculoDataTable();
			this.Adapter.Fill(tEmpleadoVehiculoDataTable);
			return tEmpleadoVehiculoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TEmpleadoVehiculo"
			};
			dataTableMapping.ColumnMappings.Add("IdEmpleado", "IdEmpleado");
			dataTableMapping.ColumnMappings.Add("IdVehiculo", "IdVehiculo");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("id", "id");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TEmpleadoVehiculo] WHERE (((@IsNull_IdEmpleado = 1 AND [IdEmpleado] IS NULL) OR ([IdEmpleado] = @Original_IdEmpleado)) AND ((@IsNull_IdVehiculo = 1 AND [IdVehiculo] IS NULL) OR ([IdVehiculo] = @Original_IdVehiculo)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ([id] = @Original_id))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IdEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IdEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdVehiculo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdVehiculo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TEmpleadoVehiculo] ([IdEmpleado], [IdVehiculo], [fechaUltimaGestion], [usuarioUltimaGestion]) VALUES (@IdEmpleado, @IdVehiculo, @fechaUltimaGestion, @usuarioUltimaGestion);\r\nSELECT IdEmpleado, IdVehiculo, fechaUltimaGestion, usuarioUltimaGestion, id FROM TEmpleadoVehiculo WHERE (id = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IdEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdVehiculo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TEmpleadoVehiculo] SET [IdEmpleado] = @IdEmpleado, [IdVehiculo] = @IdVehiculo, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion WHERE (((@IsNull_IdEmpleado = 1 AND [IdEmpleado] IS NULL) OR ([IdEmpleado] = @Original_IdEmpleado)) AND ((@IsNull_IdVehiculo = 1 AND [IdVehiculo] IS NULL) OR ([IdVehiculo] = @Original_IdVehiculo)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ([id] = @Original_id));\r\nSELECT IdEmpleado, IdVehiculo, fechaUltimaGestion, usuarioUltimaGestion, id FROM TEmpleadoVehiculo WHERE (id = @id)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IdEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdVehiculo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IdEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IdEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdVehiculo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IdVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdVehiculo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        IdEmpleado, IdVehiculo, fechaUltimaGestion, usuarioUltimaGestion, id\r\nFROM            TEmpleadoVehiculo";
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
		public virtual int Insert(int? IdEmpleado, int? IdVehiculo, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion)
		{
			int num;
			if (!IdEmpleado.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = IdEmpleado.Value;
			}
			if (!IdVehiculo.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = IdVehiculo.Value;
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
		public virtual int Update(masterDBACDataSet.TEmpleadoVehiculoDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TEmpleadoVehiculo");
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
		public virtual int Update(int? IdEmpleado, int? IdVehiculo, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int? Original_IdEmpleado, int? Original_IdVehiculo, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int Original_id, int id)
		{
			int num;
			if (!IdEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = IdEmpleado.Value;
			}
			if (!IdVehiculo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = IdVehiculo.Value;
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
			if (!Original_IdEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = 1;
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = 0;
				this.Adapter.UpdateCommand.Parameters[5].Value = Original_IdEmpleado.Value;
			}
			if (!Original_IdVehiculo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = 1;
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = 0;
				this.Adapter.UpdateCommand.Parameters[7].Value = Original_IdVehiculo.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 1;
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 0;
				this.Adapter.UpdateCommand.Parameters[9].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 1;
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 0;
				this.Adapter.UpdateCommand.Parameters[11].Value = Original_usuarioUltimaGestion.Value;
			}
			this.Adapter.UpdateCommand.Parameters[12].Value = Original_id;
			this.Adapter.UpdateCommand.Parameters[13].Value = id;
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
	}
}