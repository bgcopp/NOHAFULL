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
	public class TVisitaProgramadaTableAdapter : Component
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
		public TVisitaProgramadaTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_idVisitaProgramada, DateTime? Original_fechaInicio, DateTime? Original_fechafin, int? Original_idEmpresa, int? Original_idEmpleado, int? Original_idEstadoVisita, DateTime? Original_fechadeIngreso, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int? Original_IdDivisionEmpresa)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idVisitaProgramada;
			if (!Original_fechaInicio.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_fechaInicio.Value;
			}
			if (!Original_fechafin.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_fechafin.Value;
			}
			if (!Original_idEmpresa.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_idEmpresa.Value;
			}
			if (!Original_idEmpleado.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_idEmpleado.Value;
			}
			if (!Original_idEstadoVisita.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_idEstadoVisita.Value;
			}
			if (!Original_fechadeIngreso.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_fechadeIngreso.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 1;
				this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 0;
				this.Adapter.DeleteCommand.Parameters[14].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 1;
				this.Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 0;
				this.Adapter.DeleteCommand.Parameters[16].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_IdDivisionEmpresa.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 1;
				this.Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 0;
				this.Adapter.DeleteCommand.Parameters[18].Value = Original_IdDivisionEmpresa.Value;
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
		public virtual int Fill(masterDBACDataSet.TVisitaProgramadaDataTable dataTable)
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
		public virtual int FillByVisitasActivas(masterDBACDataSet.TVisitaProgramadaDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
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
		public virtual masterDBACDataSet.TVisitaProgramadaDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TVisitaProgramadaDataTable tVisitaProgramadaDataTable = new masterDBACDataSet.TVisitaProgramadaDataTable();
			this.Adapter.Fill(tVisitaProgramadaDataTable);
			return tVisitaProgramadaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TVisitaProgramada"
			};
			dataTableMapping.ColumnMappings.Add("idVisitaProgramada", "idVisitaProgramada");
			dataTableMapping.ColumnMappings.Add("DescripcionVisita", "DescripcionVisita");
			dataTableMapping.ColumnMappings.Add("fechaInicio", "fechaInicio");
			dataTableMapping.ColumnMappings.Add("fechafin", "fechafin");
			dataTableMapping.ColumnMappings.Add("idEmpresa", "idEmpresa");
			dataTableMapping.ColumnMappings.Add("idEmpleado", "idEmpleado");
			dataTableMapping.ColumnMappings.Add("ObservacionesVisita", "ObservacionesVisita");
			dataTableMapping.ColumnMappings.Add("idEstadoVisita", "idEstadoVisita");
			dataTableMapping.ColumnMappings.Add("fechadeIngreso", "fechadeIngreso");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("IdDivisionEmpresa", "IdDivisionEmpresa");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TVisitaProgramada] WHERE (([idVisitaProgramada] = @Original_idVisitaProgramada) AND ((@IsNull_fechaInicio = 1 AND [fechaInicio] IS NULL) OR ([fechaInicio] = @Original_fechaInicio)) AND ((@IsNull_fechafin = 1 AND [fechafin] IS NULL) OR ([fechafin] = @Original_fechafin)) AND ((@IsNull_idEmpresa = 1 AND [idEmpresa] IS NULL) OR ([idEmpresa] = @Original_idEmpresa)) AND ((@IsNull_idEmpleado = 1 AND [idEmpleado] IS NULL) OR ([idEmpleado] = @Original_idEmpleado)) AND ((@IsNull_idEstadoVisita = 1 AND [idEstadoVisita] IS NULL) OR ([idEstadoVisita] = @Original_idEstadoVisita)) AND ((@IsNull_fechadeIngreso = 1 AND [fechadeIngreso] IS NULL) OR ([fechadeIngreso] = @Original_fechadeIngreso)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_IdDivisionEmpresa = 1 AND [IdDivisionEmpresa] IS NULL) OR ([IdDivisionEmpresa] = @Original_IdDivisionEmpresa)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVisitaProgramada", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaInicio", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechafin", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechafin", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechafin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechafin", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEstadoVisita", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEstadoVisita", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEstadoVisita", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEstadoVisita", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechadeIngreso", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechadeIngreso", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechadeIngreso", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeIngreso", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_IdDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdDivisionEmpresa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_IdDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdDivisionEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TVisitaProgramada] ([DescripcionVisita], [fechaInicio], [fechafin], [idEmpresa], [idEmpleado], [ObservacionesVisita], [idEstadoVisita], [fechadeIngreso], [fechaUltimaGestion], [usuarioUltimaGestion], [IdDivisionEmpresa]) VALUES (@DescripcionVisita, @fechaInicio, @fechafin, @idEmpresa, @idEmpleado, @ObservacionesVisita, @idEstadoVisita, @fechadeIngreso, @fechaUltimaGestion, @usuarioUltimaGestion, @IdDivisionEmpresa);\r\nSELECT idVisitaProgramada, DescripcionVisita, fechaInicio, fechafin, idEmpresa, idEmpleado, ObservacionesVisita, idEstadoVisita, fechadeIngreso, fechaUltimaGestion, usuarioUltimaGestion, IdDivisionEmpresa FROM TVisitaProgramada WHERE (idVisitaProgramada = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@DescripcionVisita", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "DescripcionVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechafin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechafin", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacionesVisita", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEstadoVisita", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEstadoVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechadeIngreso", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeIngreso", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IdDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdDivisionEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TVisitaProgramada] SET [DescripcionVisita] = @DescripcionVisita, [fechaInicio] = @fechaInicio, [fechafin] = @fechafin, [idEmpresa] = @idEmpresa, [idEmpleado] = @idEmpleado, [ObservacionesVisita] = @ObservacionesVisita, [idEstadoVisita] = @idEstadoVisita, [fechadeIngreso] = @fechadeIngreso, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [IdDivisionEmpresa] = @IdDivisionEmpresa WHERE (([idVisitaProgramada] = @Original_idVisitaProgramada) AND ((@IsNull_fechaInicio = 1 AND [fechaInicio] IS NULL) OR ([fechaInicio] = @Original_fechaInicio)) AND ((@IsNull_fechafin = 1 AND [fechafin] IS NULL) OR ([fechafin] = @Original_fechafin)) AND ((@IsNull_idEmpresa = 1 AND [idEmpresa] IS NULL) OR ([idEmpresa] = @Original_idEmpresa)) AND ((@IsNull_idEmpleado = 1 AND [idEmpleado] IS NULL) OR ([idEmpleado] = @Original_idEmpleado)) AND ((@IsNull_idEstadoVisita = 1 AND [idEstadoVisita] IS NULL) OR ([idEstadoVisita] = @Original_idEstadoVisita)) AND ((@IsNull_fechadeIngreso = 1 AND [fechadeIngreso] IS NULL) OR ([fechadeIngreso] = @Original_fechadeIngreso)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_IdDivisionEmpresa = 1 AND [IdDivisionEmpresa] IS NULL) OR ([IdDivisionEmpresa] = @Original_IdDivisionEmpresa)));\r\nSELECT idVisitaProgramada, DescripcionVisita, fechaInicio, fechafin, idEmpresa, idEmpleado, ObservacionesVisita, idEstadoVisita, fechadeIngreso, fechaUltimaGestion, usuarioUltimaGestion, IdDivisionEmpresa FROM TVisitaProgramada WHERE (idVisitaProgramada = @idVisitaProgramada)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DescripcionVisita", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "DescripcionVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechafin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechafin", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacionesVisita", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEstadoVisita", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEstadoVisita", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechadeIngreso", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeIngreso", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IdDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdDivisionEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVisitaProgramada", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaInicio", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechafin", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechafin", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechafin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechafin", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEstadoVisita", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEstadoVisita", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEstadoVisita", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEstadoVisita", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechadeIngreso", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechadeIngreso", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechadeIngreso", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechadeIngreso", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_IdDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdDivisionEmpresa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_IdDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "IdDivisionEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVisitaProgramada", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, "idVisitaProgramada", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand(), null };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        idVisitaProgramada, DescripcionVisita, fechaInicio, fechafin, idEmpresa, idEmpleado, ObservacionesVisita, idEstadoVisita, fechadeIngreso, fechaUltimaGestion, \r\n                         usuarioUltimaGestion, IdDivisionEmpresa\r\nFROM            TVisitaProgramada\r\nWHERE        (DescripcionVisita <> 'Entrada Portería')";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[1] = new SqlCommand();
			this._commandCollection[1].Connection = this.Connection;
			this._commandCollection[1].CommandText = "SELECT        DescripcionVisita, IdDivisionEmpresa, ObservacionesVisita, fechaInicio, fechaUltimaGestion, fechadeIngreso, fechafin, idEmpleado, idEmpresa, idEstadoVisita, \r\n                         idVisitaProgramada, usuarioUltimaGestion\r\nFROM            TVisitaProgramada\r\nWHERE        (DescripcionVisita <> 'Entrada Portería') AND (fechafin >= GETDATE())";
			this._commandCollection[1].CommandType = CommandType.Text;
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
		public virtual int Insert(string DescripcionVisita, DateTime? fechaInicio, DateTime? fechafin, int? idEmpresa, int? idEmpleado, string ObservacionesVisita, int? idEstadoVisita, DateTime? fechadeIngreso, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int? IdDivisionEmpresa)
		{
			int num;
			if (DescripcionVisita != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DescripcionVisita;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!fechaInicio.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = fechaInicio.Value;
			}
			if (!fechafin.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = fechafin.Value;
			}
			if (!idEmpresa.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = idEmpresa.Value;
			}
			if (!idEmpleado.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = idEmpleado.Value;
			}
			if (ObservacionesVisita != null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = ObservacionesVisita;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			if (!idEstadoVisita.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = idEstadoVisita.Value;
			}
			if (!fechadeIngreso.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = fechadeIngreso.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = usuarioUltimaGestion.Value;
			}
			if (!IdDivisionEmpresa.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = IdDivisionEmpresa.Value;
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
		public virtual int Update(masterDBACDataSet.TVisitaProgramadaDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TVisitaProgramada");
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
		public virtual int Update(string DescripcionVisita, DateTime? fechaInicio, DateTime? fechafin, int? idEmpresa, int? idEmpleado, string ObservacionesVisita, int? idEstadoVisita, DateTime? fechadeIngreso, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int? IdDivisionEmpresa, decimal Original_idVisitaProgramada, DateTime? Original_fechaInicio, DateTime? Original_fechafin, int? Original_idEmpresa, int? Original_idEmpleado, int? Original_idEstadoVisita, DateTime? Original_fechadeIngreso, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int? Original_IdDivisionEmpresa, decimal idVisitaProgramada)
		{
			int num;
			if (DescripcionVisita != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DescripcionVisita;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!fechaInicio.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = fechaInicio.Value;
			}
			if (!fechafin.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = fechafin.Value;
			}
			if (!idEmpresa.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = idEmpresa.Value;
			}
			if (!idEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = idEmpleado.Value;
			}
			if (ObservacionesVisita != null)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = ObservacionesVisita;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			if (!idEstadoVisita.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = idEstadoVisita.Value;
			}
			if (!fechadeIngreso.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = fechadeIngreso.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = usuarioUltimaGestion.Value;
			}
			if (!IdDivisionEmpresa.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = IdDivisionEmpresa.Value;
			}
			this.Adapter.UpdateCommand.Parameters[11].Value = Original_idVisitaProgramada;
			if (!Original_fechaInicio.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 1;
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 0;
				this.Adapter.UpdateCommand.Parameters[13].Value = Original_fechaInicio.Value;
			}
			if (!Original_fechafin.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_fechafin.Value;
			}
			if (!Original_idEmpresa.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 1;
				this.Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 0;
				this.Adapter.UpdateCommand.Parameters[17].Value = Original_idEmpresa.Value;
			}
			if (!Original_idEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 1;
				this.Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 0;
				this.Adapter.UpdateCommand.Parameters[19].Value = Original_idEmpleado.Value;
			}
			if (!Original_idEstadoVisita.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 1;
				this.Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 0;
				this.Adapter.UpdateCommand.Parameters[21].Value = Original_idEstadoVisita.Value;
			}
			if (!Original_fechadeIngreso.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 1;
				this.Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 0;
				this.Adapter.UpdateCommand.Parameters[23].Value = Original_fechadeIngreso.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 1;
				this.Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 0;
				this.Adapter.UpdateCommand.Parameters[25].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[26].Value = 1;
				this.Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[26].Value = 0;
				this.Adapter.UpdateCommand.Parameters[27].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_IdDivisionEmpresa.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[28].Value = 1;
				this.Adapter.UpdateCommand.Parameters[29].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[28].Value = 0;
				this.Adapter.UpdateCommand.Parameters[29].Value = Original_IdDivisionEmpresa.Value;
			}
			this.Adapter.UpdateCommand.Parameters[30].Value = idVisitaProgramada;
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
		public virtual int Update(string DescripcionVisita, DateTime? fechaInicio, DateTime? fechafin, int? idEmpresa, int? idEmpleado, string ObservacionesVisita, int? idEstadoVisita, DateTime? fechadeIngreso, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, int? IdDivisionEmpresa, decimal Original_idVisitaProgramada, DateTime? Original_fechaInicio, DateTime? Original_fechafin, int? Original_idEmpresa, int? Original_idEmpleado, int? Original_idEstadoVisita, DateTime? Original_fechadeIngreso, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, int? Original_IdDivisionEmpresa)
		{
			int num = this.Update(DescripcionVisita, fechaInicio, fechafin, idEmpresa, idEmpleado, ObservacionesVisita, idEstadoVisita, fechadeIngreso, fechaUltimaGestion, usuarioUltimaGestion, IdDivisionEmpresa, Original_idVisitaProgramada, Original_fechaInicio, Original_fechafin, Original_idEmpresa, Original_idEmpleado, Original_idEstadoVisita, Original_fechadeIngreso, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_IdDivisionEmpresa, Original_idVisitaProgramada);
			return num;
		}
	}
}