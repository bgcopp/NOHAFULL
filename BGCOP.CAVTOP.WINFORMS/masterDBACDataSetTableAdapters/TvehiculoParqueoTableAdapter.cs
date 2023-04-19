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
	public class TvehiculoParqueoTableAdapter : Component
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
		public TvehiculoParqueoTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int? Original_idVehiculo, int? Original_idParqueadero, byte? Original_diaSemana, bool? Original_dia1, bool? Original_dia2, bool? Original_dia3, bool? Original_dia4, bool? Original_dia5, bool? Original_dia6, bool? Original_dia7, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int Original_id)
		{
			int num;
			if (!Original_idVehiculo.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[0].Value = 1;
				this.Adapter.DeleteCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[0].Value = 0;
				this.Adapter.DeleteCommand.Parameters[1].Value = Original_idVehiculo.Value;
			}
			if (!Original_idParqueadero.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 1;
				this.Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 0;
				this.Adapter.DeleteCommand.Parameters[3].Value = Original_idParqueadero.Value;
			}
			if (!Original_diaSemana.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 1;
				this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 0;
				this.Adapter.DeleteCommand.Parameters[5].Value = Original_diaSemana.Value;
			}
			if (!Original_dia1.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 1;
				this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 0;
				this.Adapter.DeleteCommand.Parameters[7].Value = Original_dia1.Value;
			}
			if (!Original_dia2.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 1;
				this.Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 0;
				this.Adapter.DeleteCommand.Parameters[9].Value = Original_dia2.Value;
			}
			if (!Original_dia3.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[10].Value = 1;
				this.Adapter.DeleteCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[10].Value = 0;
				this.Adapter.DeleteCommand.Parameters[11].Value = Original_dia3.Value;
			}
			if (!Original_dia4.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[12].Value = 1;
				this.Adapter.DeleteCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[12].Value = 0;
				this.Adapter.DeleteCommand.Parameters[13].Value = Original_dia4.Value;
			}
			if (!Original_dia5.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[14].Value = 1;
				this.Adapter.DeleteCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[14].Value = 0;
				this.Adapter.DeleteCommand.Parameters[15].Value = Original_dia5.Value;
			}
			if (!Original_dia6.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[16].Value = 1;
				this.Adapter.DeleteCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[16].Value = 0;
				this.Adapter.DeleteCommand.Parameters[17].Value = Original_dia6.Value;
			}
			if (!Original_dia7.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[18].Value = 1;
				this.Adapter.DeleteCommand.Parameters[19].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[18].Value = 0;
				this.Adapter.DeleteCommand.Parameters[19].Value = Original_dia7.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[20].Value = 1;
				this.Adapter.DeleteCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[20].Value = 0;
				this.Adapter.DeleteCommand.Parameters[21].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[22].Value = 1;
				this.Adapter.DeleteCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[22].Value = 0;
				this.Adapter.DeleteCommand.Parameters[23].Value = Original_usuarioUltimaGestion.Value;
			}
			this.Adapter.DeleteCommand.Parameters[24].Value = Original_id;
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
		public virtual int Fill(masterDBACDataSet.TvehiculoParqueoDataTable dataTable)
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
		public virtual masterDBACDataSet.TvehiculoParqueoDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TvehiculoParqueoDataTable tvehiculoParqueoDataTable = new masterDBACDataSet.TvehiculoParqueoDataTable();
			this.Adapter.Fill(tvehiculoParqueoDataTable);
			return tvehiculoParqueoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TvehiculoParqueo"
			};
			dataTableMapping.ColumnMappings.Add("idVehiculo", "idVehiculo");
			dataTableMapping.ColumnMappings.Add("idParqueadero", "idParqueadero");
			dataTableMapping.ColumnMappings.Add("diaSemana", "diaSemana");
			dataTableMapping.ColumnMappings.Add("ObservacionesVP", "ObservacionesVP");
			dataTableMapping.ColumnMappings.Add("dia1", "dia1");
			dataTableMapping.ColumnMappings.Add("dia2", "dia2");
			dataTableMapping.ColumnMappings.Add("dia3", "dia3");
			dataTableMapping.ColumnMappings.Add("dia4", "dia4");
			dataTableMapping.ColumnMappings.Add("dia5", "dia5");
			dataTableMapping.ColumnMappings.Add("dia6", "dia6");
			dataTableMapping.ColumnMappings.Add("dia7", "dia7");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("id", "id");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TvehiculoParqueo] WHERE (((@IsNull_idVehiculo = 1 AND [idVehiculo] IS NULL) OR ([idVehiculo] = @Original_idVehiculo)) AND ((@IsNull_idParqueadero = 1 AND [idParqueadero] IS NULL) OR ([idParqueadero] = @Original_idParqueadero)) AND ((@IsNull_diaSemana = 1 AND [diaSemana] IS NULL) OR ([diaSemana] = @Original_diaSemana)) AND ((@IsNull_dia1 = 1 AND [dia1] IS NULL) OR ([dia1] = @Original_dia1)) AND ((@IsNull_dia2 = 1 AND [dia2] IS NULL) OR ([dia2] = @Original_dia2)) AND ((@IsNull_dia3 = 1 AND [dia3] IS NULL) OR ([dia3] = @Original_dia3)) AND ((@IsNull_dia4 = 1 AND [dia4] IS NULL) OR ([dia4] = @Original_dia4)) AND ((@IsNull_dia5 = 1 AND [dia5] IS NULL) OR ([dia5] = @Original_dia5)) AND ((@IsNull_dia6 = 1 AND [dia6] IS NULL) OR ([dia6] = @Original_dia6)) AND ((@IsNull_dia7 = 1 AND [dia7] IS NULL) OR ([dia7] = @Original_dia7)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ([id] = @Original_id))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVehiculo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVehiculo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_diaSemana", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "diaSemana", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_diaSemana", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "diaSemana", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia1", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia1", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia1", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia1", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia2", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia2", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia2", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia2", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia3", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia3", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia3", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia3", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia4", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia4", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia4", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia4", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia5", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia5", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia5", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia5", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia6", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia6", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia6", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia6", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_dia7", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia7", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_dia7", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia7", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TvehiculoParqueo] ([idVehiculo], [idParqueadero], [diaSemana], [ObservacionesVP], [dia1], [dia2], [dia3], [dia4], [dia5], [dia6], [dia7], [fechaUltimaGestion], [usuarioUltimaGestion]) VALUES (@idVehiculo, @idParqueadero, @diaSemana, @ObservacionesVP, @dia1, @dia2, @dia3, @dia4, @dia5, @dia6, @dia7, @fechaUltimaGestion, @usuarioUltimaGestion);\r\nSELECT idVehiculo, idParqueadero, diaSemana, ObservacionesVP, dia1, dia2, dia3, dia4, dia5, dia6, dia7, fechaUltimaGestion, usuarioUltimaGestion, id FROM TvehiculoParqueo WHERE (id = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVehiculo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@diaSemana", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "diaSemana", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacionesVP", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesVP", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia1", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia1", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia2", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia2", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia3", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia3", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia4", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia4", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia5", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia5", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia6", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia6", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dia7", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia7", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TvehiculoParqueo] SET [idVehiculo] = @idVehiculo, [idParqueadero] = @idParqueadero, [diaSemana] = @diaSemana, [ObservacionesVP] = @ObservacionesVP, [dia1] = @dia1, [dia2] = @dia2, [dia3] = @dia3, [dia4] = @dia4, [dia5] = @dia5, [dia6] = @dia6, [dia7] = @dia7, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion WHERE (((@IsNull_idVehiculo = 1 AND [idVehiculo] IS NULL) OR ([idVehiculo] = @Original_idVehiculo)) AND ((@IsNull_idParqueadero = 1 AND [idParqueadero] IS NULL) OR ([idParqueadero] = @Original_idParqueadero)) AND ((@IsNull_diaSemana = 1 AND [diaSemana] IS NULL) OR ([diaSemana] = @Original_diaSemana)) AND ((@IsNull_dia1 = 1 AND [dia1] IS NULL) OR ([dia1] = @Original_dia1)) AND ((@IsNull_dia2 = 1 AND [dia2] IS NULL) OR ([dia2] = @Original_dia2)) AND ((@IsNull_dia3 = 1 AND [dia3] IS NULL) OR ([dia3] = @Original_dia3)) AND ((@IsNull_dia4 = 1 AND [dia4] IS NULL) OR ([dia4] = @Original_dia4)) AND ((@IsNull_dia5 = 1 AND [dia5] IS NULL) OR ([dia5] = @Original_dia5)) AND ((@IsNull_dia6 = 1 AND [dia6] IS NULL) OR ([dia6] = @Original_dia6)) AND ((@IsNull_dia7 = 1 AND [dia7] IS NULL) OR ([dia7] = @Original_dia7)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ([id] = @Original_id));\r\nSELECT idVehiculo, idParqueadero, diaSemana, ObservacionesVP, dia1, dia2, dia3, dia4, dia5, dia6, dia7, fechaUltimaGestion, usuarioUltimaGestion, id FROM TvehiculoParqueo WHERE (id = @id)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVehiculo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@diaSemana", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "diaSemana", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacionesVP", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesVP", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia1", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia1", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia2", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia2", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia3", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia3", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia4", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia4", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia5", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia5", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia6", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia6", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@dia7", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia7", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVehiculo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVehiculo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVehiculo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idParqueadero", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idParqueadero", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_diaSemana", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "diaSemana", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_diaSemana", SqlDbType.TinyInt, 0, ParameterDirection.Input, 0, 0, "diaSemana", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia1", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia1", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia1", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia1", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia2", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia2", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia2", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia2", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia3", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia3", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia3", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia3", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia4", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia4", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia4", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia4", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia5", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia5", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia5", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia5", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia6", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia6", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia6", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia6", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_dia7", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "dia7", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_dia7", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "dia7", DataRowVersion.Original, false, null, "", "", ""));
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
			this._commandCollection[0].CommandText = "SELECT        idVehiculo, idParqueadero, diaSemana, ObservacionesVP, dia1, dia2, dia3, dia4, dia5, dia6, dia7, fechaUltimaGestion, usuarioUltimaGestion, id\r\nFROM            TvehiculoParqueo";
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
		public virtual int Insert(int? idVehiculo, int? idParqueadero, byte? diaSemana, string ObservacionesVP, bool? dia1, bool? dia2, bool? dia3, bool? dia4, bool? dia5, bool? dia6, bool? dia7, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion)
		{
			int num;
			if (!idVehiculo.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = idVehiculo.Value;
			}
			if (!idParqueadero.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = idParqueadero.Value;
			}
			if (!diaSemana.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = diaSemana.Value;
			}
			if (ObservacionesVP != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = ObservacionesVP;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (!dia1.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = dia1.Value;
			}
			if (!dia2.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = dia2.Value;
			}
			if (!dia3.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = dia3.Value;
			}
			if (!dia4.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = dia4.Value;
			}
			if (!dia5.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = dia5.Value;
			}
			if (!dia6.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = dia6.Value;
			}
			if (!dia7.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = dia7.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[11].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[12].Value = usuarioUltimaGestion.Value;
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
		public virtual int Update(masterDBACDataSet.TvehiculoParqueoDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TvehiculoParqueo");
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
		public virtual int Update(int? idVehiculo, int? idParqueadero, byte? diaSemana, string ObservacionesVP, bool? dia1, bool? dia2, bool? dia3, bool? dia4, bool? dia5, bool? dia6, bool? dia7, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int? Original_idVehiculo, int? Original_idParqueadero, byte? Original_diaSemana, bool? Original_dia1, bool? Original_dia2, bool? Original_dia3, bool? Original_dia4, bool? Original_dia5, bool? Original_dia6, bool? Original_dia7, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int Original_id, int id)
		{
			int num;
			if (!idVehiculo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = idVehiculo.Value;
			}
			if (!idParqueadero.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = idParqueadero.Value;
			}
			if (!diaSemana.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = diaSemana.Value;
			}
			if (ObservacionesVP != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = ObservacionesVP;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			if (!dia1.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = dia1.Value;
			}
			if (!dia2.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = dia2.Value;
			}
			if (!dia3.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = dia3.Value;
			}
			if (!dia4.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = dia4.Value;
			}
			if (!dia5.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = dia5.Value;
			}
			if (!dia6.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = dia6.Value;
			}
			if (!dia7.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = dia7.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = usuarioUltimaGestion.Value;
			}
			if (!Original_idVehiculo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_idVehiculo.Value;
			}
			if (!Original_idParqueadero.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_idParqueadero.Value;
			}
			if (!Original_diaSemana.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_diaSemana.Value;
			}
			if (!Original_dia1.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 1;
				this.Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 0;
				this.Adapter.UpdateCommand.Parameters[20].Value = Original_dia1.Value;
			}
			if (!Original_dia2.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 1;
				this.Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 0;
				this.Adapter.UpdateCommand.Parameters[22].Value = Original_dia2.Value;
			}
			if (!Original_dia3.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 1;
				this.Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 0;
				this.Adapter.UpdateCommand.Parameters[24].Value = Original_dia3.Value;
			}
			if (!Original_dia4.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[25].Value = 1;
				this.Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[25].Value = 0;
				this.Adapter.UpdateCommand.Parameters[26].Value = Original_dia4.Value;
			}
			if (!Original_dia5.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[27].Value = 1;
				this.Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[27].Value = 0;
				this.Adapter.UpdateCommand.Parameters[28].Value = Original_dia5.Value;
			}
			if (!Original_dia6.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[29].Value = 1;
				this.Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[29].Value = 0;
				this.Adapter.UpdateCommand.Parameters[30].Value = Original_dia6.Value;
			}
			if (!Original_dia7.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[31].Value = 1;
				this.Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[31].Value = 0;
				this.Adapter.UpdateCommand.Parameters[32].Value = Original_dia7.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[33].Value = 1;
				this.Adapter.UpdateCommand.Parameters[34].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[33].Value = 0;
				this.Adapter.UpdateCommand.Parameters[34].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[35].Value = 1;
				this.Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[35].Value = 0;
				this.Adapter.UpdateCommand.Parameters[36].Value = Original_usuarioUltimaGestion.Value;
			}
			this.Adapter.UpdateCommand.Parameters[37].Value = Original_id;
			this.Adapter.UpdateCommand.Parameters[38].Value = id;
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