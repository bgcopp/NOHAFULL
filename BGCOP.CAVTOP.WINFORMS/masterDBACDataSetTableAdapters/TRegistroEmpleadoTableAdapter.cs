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
	public class TRegistroEmpleadoTableAdapter : Component
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
		public TRegistroEmpleadoTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_idRegistroEmpleado, int? Original_idEmpleado, DateTime? Original_fechadeRegistro, int? Original_idPanel, int? Original_idTipoRegistro, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idRegistroEmpleado;
			if (!Original_idEmpleado.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_idEmpleado.Value;
			}
			if (!Original_fechadeRegistro.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_fechadeRegistro.Value;
			}
			if (!Original_idPanel.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_idPanel.Value;
			}
			if (!Original_idTipoRegistro.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_idTipoRegistro.Value;
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
		public virtual int Fill(masterDBACDataSet.TRegistroEmpleadoDataTable dataTable)
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
		public virtual masterDBACDataSet.TRegistroEmpleadoDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TRegistroEmpleadoDataTable tRegistroEmpleadoDataTable = new masterDBACDataSet.TRegistroEmpleadoDataTable();
			this.Adapter.Fill(tRegistroEmpleadoDataTable);
			return tRegistroEmpleadoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TRegistroEmpleado"
			};
			dataTableMapping.ColumnMappings.Add("idRegistroEmpleado", "idRegistroEmpleado");
			dataTableMapping.ColumnMappings.Add("idEmpleado", "idEmpleado");
			dataTableMapping.ColumnMappings.Add("fechadeRegistro", "fechadeRegistro");
			dataTableMapping.ColumnMappings.Add("idPanel", "idPanel");
			dataTableMapping.ColumnMappings.Add("idTipoRegistro", "idTipoRegistro");
			dataTableMapping.ColumnMappings.Add("descripcionRegistro", "descripcionRegistro");
			dataTableMapping.ColumnMappings.Add("ObservacionesRegistro", "ObservacionesRegistro");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[TRegistroEmpleado] WHERE (([idRegistroEmpleado] = @Original_idRegistroEmpleado) AND ((@IsNull_idEmpleado = 1 AND [idEmpleado] IS NULL) OR ([idEmpleado] = @Original_idEmpleado)) AND ((@IsNull_fechadeRegistro = 1 AND [fechadeRegistro] IS NULL) OR ([fechadeRegistro] = @Original_fechadeRegistro)) AND ((@IsNull_idPanel = 1 AND [idPanel] IS NULL) OR ([idPanel] = @Original_idPanel)) AND ((@IsNull_idTipoRegistro = 1 AND [idTipoRegistro] IS NULL) OR ([idTipoRegistro] = @Original_idTipoRegistro)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idRegistroEmpleado", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idRegistroEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechadeRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechadeRegistro", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechadeRegistro", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeRegistro", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idTipoRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoRegistro", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTipoRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoRegistro", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[TRegistroEmpleado] ([idEmpleado], [fechadeRegistro], [idPanel], [idTipoRegistro], [descripcionRegistro], [ObservacionesRegistro], [fechaUltimaGestion], [usuarioUltimaGestion]) VALUES (@idEmpleado, @fechadeRegistro, @idPanel, @idTipoRegistro, @descripcionRegistro, @ObservacionesRegistro, @fechaUltimaGestion, @usuarioUltimaGestion);\r\nSELECT idRegistroEmpleado, idEmpleado, fechadeRegistro, idPanel, idTipoRegistro, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion FROM TRegistroEmpleado WHERE (idRegistroEmpleado = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechadeRegistro", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idTipoRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@descripcionRegistro", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "descripcionRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacionesRegistro", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[TRegistroEmpleado] SET [idEmpleado] = @idEmpleado, [fechadeRegistro] = @fechadeRegistro, [idPanel] = @idPanel, [idTipoRegistro] = @idTipoRegistro, [descripcionRegistro] = @descripcionRegistro, [ObservacionesRegistro] = @ObservacionesRegistro, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion WHERE (([idRegistroEmpleado] = @Original_idRegistroEmpleado) AND ((@IsNull_idEmpleado = 1 AND [idEmpleado] IS NULL) OR ([idEmpleado] = @Original_idEmpleado)) AND ((@IsNull_fechadeRegistro = 1 AND [fechadeRegistro] IS NULL) OR ([fechadeRegistro] = @Original_fechadeRegistro)) AND ((@IsNull_idPanel = 1 AND [idPanel] IS NULL) OR ([idPanel] = @Original_idPanel)) AND ((@IsNull_idTipoRegistro = 1 AND [idTipoRegistro] IS NULL) OR ([idTipoRegistro] = @Original_idTipoRegistro)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)));\r\nSELECT idRegistroEmpleado, idEmpleado, fechadeRegistro, idPanel, idTipoRegistro, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion FROM TRegistroEmpleado WHERE (idRegistroEmpleado = @idRegistroEmpleado)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechadeRegistro", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTipoRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@descripcionRegistro", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "descripcionRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacionesRegistro", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesRegistro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idRegistroEmpleado", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idRegistroEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechadeRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechadeRegistro", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechadeRegistro", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeRegistro", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idTipoRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoRegistro", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTipoRegistro", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoRegistro", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idRegistroEmpleado", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, "idRegistroEmpleado", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idRegistroEmpleado, idEmpleado, fechadeRegistro, idPanel, idTipoRegistro, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion FROM dbo.TRegistroEmpleado";
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
		public virtual int Insert(int? idEmpleado, DateTime? fechadeRegistro, int? idPanel, int? idTipoRegistro, string descripcionRegistro, string ObservacionesRegistro, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion)
		{
			int num;
			if (!idEmpleado.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = idEmpleado.Value;
			}
			if (!fechadeRegistro.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = fechadeRegistro.Value;
			}
			if (!idPanel.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = idPanel.Value;
			}
			if (!idTipoRegistro.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = idTipoRegistro.Value;
			}
			if (descripcionRegistro != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = descripcionRegistro;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (ObservacionesRegistro != null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = ObservacionesRegistro;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = usuarioUltimaGestion.Value;
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
		public virtual int Update(masterDBACDataSet.TRegistroEmpleadoDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TRegistroEmpleado");
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
		public virtual int Update(int? idEmpleado, DateTime? fechadeRegistro, int? idPanel, int? idTipoRegistro, string descripcionRegistro, string ObservacionesRegistro, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, decimal Original_idRegistroEmpleado, int? Original_idEmpleado, DateTime? Original_fechadeRegistro, int? Original_idPanel, int? Original_idTipoRegistro, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, decimal idRegistroEmpleado)
		{
			int num;
			if (!idEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = idEmpleado.Value;
			}
			if (!fechadeRegistro.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = fechadeRegistro.Value;
			}
			if (!idPanel.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = idPanel.Value;
			}
			if (!idTipoRegistro.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = idTipoRegistro.Value;
			}
			if (descripcionRegistro != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = descripcionRegistro;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			if (ObservacionesRegistro != null)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = ObservacionesRegistro;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = usuarioUltimaGestion.Value;
			}
			this.Adapter.UpdateCommand.Parameters[8].Value = Original_idRegistroEmpleado;
			if (!Original_idEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_idEmpleado.Value;
			}
			if (!Original_fechadeRegistro.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 1;
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 0;
				this.Adapter.UpdateCommand.Parameters[12].Value = Original_fechadeRegistro.Value;
			}
			if (!Original_idPanel.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_idPanel.Value;
			}
			if (!Original_idTipoRegistro.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_idTipoRegistro.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 1;
				this.Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 0;
				this.Adapter.UpdateCommand.Parameters[20].Value = Original_usuarioUltimaGestion.Value;
			}
			this.Adapter.UpdateCommand.Parameters[21].Value = idRegistroEmpleado;
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
		public virtual int Update(int? idEmpleado, DateTime? fechadeRegistro, int? idPanel, int? idTipoRegistro, string descripcionRegistro, string ObservacionesRegistro, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, decimal Original_idRegistroEmpleado, int? Original_idEmpleado, DateTime? Original_fechadeRegistro, int? Original_idPanel, int? Original_idTipoRegistro, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion)
		{
			int num = this.Update(idEmpleado, fechadeRegistro, idPanel, idTipoRegistro, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion, Original_idRegistroEmpleado, Original_idEmpleado, Original_fechadeRegistro, Original_idPanel, Original_idTipoRegistro, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_idRegistroEmpleado);
			return num;
		}
	}
}