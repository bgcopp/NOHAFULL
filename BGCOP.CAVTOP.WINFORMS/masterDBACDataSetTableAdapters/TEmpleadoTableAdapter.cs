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
	public class TEmpleadoTableAdapter : Component
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
		public TEmpleadoTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idEmpleado, string Original_nombre, int? Original_idTipoIdentificacion, string Original_identificacion, string Original_Notarjeta, int? Original_idCargo, int Original_idTipoEstado, int Original_idEmpresa, int Original_idDivisionEmpresa, int? Original_idHorario, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_usuarioHuella, int? Original_idTarjeta)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idEmpleado;
			if (Original_nombre == null)
			{
				throw new ArgumentNullException("Original_nombre");
			}
			this.Adapter.DeleteCommand.Parameters[1].Value = Original_nombre;
			if (!Original_idTipoIdentificacion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 1;
				this.Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[2].Value = 0;
				this.Adapter.DeleteCommand.Parameters[3].Value = Original_idTipoIdentificacion.Value;
			}
			if (Original_identificacion != null)
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 0;
				this.Adapter.DeleteCommand.Parameters[5].Value = Original_identificacion;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 1;
				this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
			}
			if (Original_Notarjeta != null)
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 0;
				this.Adapter.DeleteCommand.Parameters[7].Value = Original_Notarjeta;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 1;
				this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
			}
			if (!Original_idCargo.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 1;
				this.Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 0;
				this.Adapter.DeleteCommand.Parameters[9].Value = Original_idCargo.Value;
			}
			this.Adapter.DeleteCommand.Parameters[10].Value = Original_idTipoEstado;
			this.Adapter.DeleteCommand.Parameters[11].Value = Original_idEmpresa;
			this.Adapter.DeleteCommand.Parameters[12].Value = Original_idDivisionEmpresa;
			if (!Original_idHorario.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 1;
				this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 0;
				this.Adapter.DeleteCommand.Parameters[14].Value = Original_idHorario.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 1;
				this.Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 0;
				this.Adapter.DeleteCommand.Parameters[16].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 1;
				this.Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 0;
				this.Adapter.DeleteCommand.Parameters[18].Value = Original_usuarioUltimaGestion.Value;
			}
			if (Original_usuarioHuella != null)
			{
				this.Adapter.DeleteCommand.Parameters[19].Value = 0;
				this.Adapter.DeleteCommand.Parameters[20].Value = Original_usuarioHuella;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[19].Value = 1;
				this.Adapter.DeleteCommand.Parameters[20].Value = DBNull.Value;
			}
			if (!Original_idTarjeta.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[21].Value = 1;
				this.Adapter.DeleteCommand.Parameters[22].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[21].Value = 0;
				this.Adapter.DeleteCommand.Parameters[22].Value = Original_idTarjeta.Value;
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
		public virtual int Fill(masterDBACDataSet.TEmpleadoDataTable dataTable)
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
		public virtual int FillByEmpleadobyEmpresa(masterDBACDataSet.TEmpleadoDataTable dataTable, int idemp)
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
			this.Adapter.SelectCommand.Parameters[0].Value = idemp;
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
		public virtual masterDBACDataSet.TEmpleadoDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TEmpleadoDataTable tEmpleadoDataTable = new masterDBACDataSet.TEmpleadoDataTable();
			this.Adapter.Fill(tEmpleadoDataTable);
			return tEmpleadoDataTable;
		}

		[DataObjectMethod(DataObjectMethodType.Select, false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual masterDBACDataSet.TEmpleadoDataTable GetDataByEmpleadobyEmpresa(int idemp)
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
			this.Adapter.SelectCommand.Parameters[0].Value = idemp;
			masterDBACDataSet.TEmpleadoDataTable tEmpleadoDataTable = new masterDBACDataSet.TEmpleadoDataTable();
			this.Adapter.Fill(tEmpleadoDataTable);
			return tEmpleadoDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TEmpleado"
			};
			dataTableMapping.ColumnMappings.Add("idEmpleado", "idEmpleado");
			dataTableMapping.ColumnMappings.Add("nombre", "nombre");
			dataTableMapping.ColumnMappings.Add("idTipoIdentificacion", "idTipoIdentificacion");
			dataTableMapping.ColumnMappings.Add("identificacion", "identificacion");
			dataTableMapping.ColumnMappings.Add("Notarjeta", "Notarjeta");
			dataTableMapping.ColumnMappings.Add("foto", "foto");
			dataTableMapping.ColumnMappings.Add("idCargo", "idCargo");
			dataTableMapping.ColumnMappings.Add("idTipoEstado", "idTipoEstado");
			dataTableMapping.ColumnMappings.Add("idEmpresa", "idEmpresa");
			dataTableMapping.ColumnMappings.Add("idDivisionEmpresa", "idDivisionEmpresa");
			dataTableMapping.ColumnMappings.Add("idHorario", "idHorario");
			dataTableMapping.ColumnMappings.Add("observaciones", "observaciones");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioHuella", "usuarioHuella");
			dataTableMapping.ColumnMappings.Add("idTarjeta", "idTarjeta");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TEmpleado] WHERE (([idEmpleado] = @Original_idEmpleado) AND ([nombre] = @Original_nombre) AND ((@IsNull_idTipoIdentificacion = 1 AND [idTipoIdentificacion] IS NULL) OR ([idTipoIdentificacion] = @Original_idTipoIdentificacion)) AND ((@IsNull_identificacion = 1 AND [identificacion] IS NULL) OR ([identificacion] = @Original_identificacion)) AND ((@IsNull_Notarjeta = 1 AND [Notarjeta] IS NULL) OR ([Notarjeta] = @Original_Notarjeta)) AND ((@IsNull_idCargo = 1 AND [idCargo] IS NULL) OR ([idCargo] = @Original_idCargo)) AND ([idTipoEstado] = @Original_idTipoEstado) AND ([idEmpresa] = @Original_idEmpresa) AND ([idDivisionEmpresa] = @Original_idDivisionEmpresa) AND ((@IsNull_idHorario = 1 AND [idHorario] IS NULL) OR ([idHorario] = @Original_idHorario)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_usuarioHuella = 1 AND [usuarioHuella] IS NULL) OR ([usuarioHuella] = @Original_usuarioHuella)) AND ((@IsNull_idTarjeta = 1 AND [idTarjeta] IS NULL) OR ([idTarjeta] = @Original_idTarjeta)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_nombre", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombre", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_identificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "identificacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_identificacion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Notarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Notarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Notarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Notarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idCargo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idCargo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idCargo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idCargo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTipoEstado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoEstado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idDivisionEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioHuella", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioHuella", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioHuella", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "usuarioHuella", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TEmpleado] ([nombre], [idTipoIdentificacion], [identificacion], [Notarjeta], [foto], [idCargo], [idTipoEstado], [idEmpresa], [idDivisionEmpresa], [idHorario], [observaciones], [fechaUltimaGestion], [usuarioUltimaGestion], [usuarioHuella], [idTarjeta]) VALUES (@nombre, @idTipoIdentificacion, @identificacion, @Notarjeta, @foto, @idCargo, @idTipoEstado, @idEmpresa, @idDivisionEmpresa, @idHorario, @observaciones, @fechaUltimaGestion, @usuarioUltimaGestion, @usuarioHuella, @idTarjeta);\r\nSELECT idEmpleado, nombre, idTipoIdentificacion, identificacion, Notarjeta, foto, idCargo, idTipoEstado, idEmpresa, idDivisionEmpresa, idHorario, observaciones, fechaUltimaGestion, usuarioUltimaGestion, usuarioHuella, idTarjeta FROM TEmpleado WHERE (idEmpleado = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombre", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@identificacion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Notarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Notarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "foto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idCargo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idCargo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idTipoEstado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoEstado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idDivisionEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observaciones", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioHuella", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "usuarioHuella", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TEmpleado] SET [nombre] = @nombre, [idTipoIdentificacion] = @idTipoIdentificacion, [identificacion] = @identificacion, [Notarjeta] = @Notarjeta, [foto] = @foto, [idCargo] = @idCargo, [idTipoEstado] = @idTipoEstado, [idEmpresa] = @idEmpresa, [idDivisionEmpresa] = @idDivisionEmpresa, [idHorario] = @idHorario, [observaciones] = @observaciones, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [usuarioHuella] = @usuarioHuella, [idTarjeta] = @idTarjeta WHERE (([idEmpleado] = @Original_idEmpleado) AND ([nombre] = @Original_nombre) AND ((@IsNull_idTipoIdentificacion = 1 AND [idTipoIdentificacion] IS NULL) OR ([idTipoIdentificacion] = @Original_idTipoIdentificacion)) AND ((@IsNull_identificacion = 1 AND [identificacion] IS NULL) OR ([identificacion] = @Original_identificacion)) AND ((@IsNull_Notarjeta = 1 AND [Notarjeta] IS NULL) OR ([Notarjeta] = @Original_Notarjeta)) AND ((@IsNull_idCargo = 1 AND [idCargo] IS NULL) OR ([idCargo] = @Original_idCargo)) AND ([idTipoEstado] = @Original_idTipoEstado) AND ([idEmpresa] = @Original_idEmpresa) AND ([idDivisionEmpresa] = @Original_idDivisionEmpresa) AND ((@IsNull_idHorario = 1 AND [idHorario] IS NULL) OR ([idHorario] = @Original_idHorario)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_usuarioHuella = 1 AND [usuarioHuella] IS NULL) OR ([usuarioHuella] = @Original_usuarioHuella)) AND ((@IsNull_idTarjeta = 1 AND [idTarjeta] IS NULL) OR ([idTarjeta] = @Original_idTarjeta)));\r\nSELECT idEmpleado, nombre, idTipoIdentificacion, identificacion, Notarjeta, foto, idCargo, idTipoEstado, idEmpresa, idDivisionEmpresa, idHorario, observaciones, fechaUltimaGestion, usuarioUltimaGestion, usuarioHuella, idTarjeta FROM TEmpleado WHERE (idEmpleado = @idEmpleado)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombre", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@identificacion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Notarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Notarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "foto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idCargo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idCargo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTipoEstado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoEstado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idDivisionEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observaciones", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioHuella", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "usuarioHuella", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_nombre", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombre", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_identificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "identificacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_identificacion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Notarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Notarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Notarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "Notarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idCargo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idCargo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idCargo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idCargo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTipoEstado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoEstado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idDivisionEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idDivisionEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioHuella", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioHuella", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioHuella", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "usuarioHuella", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand(), null };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        idEmpleado, nombre, idTipoIdentificacion, identificacion, Notarjeta, foto, idCargo, idTipoEstado, idEmpresa, idDivisionEmpresa, idHorario, observaciones, \r\n                         fechaUltimaGestion, usuarioUltimaGestion, usuarioHuella, idTarjeta\r\nFROM            TEmpleado";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[1] = new SqlCommand();
			this._commandCollection[1].Connection = this.Connection;
			this._commandCollection[1].CommandText = "SELECT        idEmpleado, nombre, idTipoIdentificacion, identificacion, Notarjeta, foto, idCargo, idTipoEstado, idEmpresa, idDivisionEmpresa, idHorario, observaciones, \r\n                         fechaUltimaGestion, usuarioUltimaGestion, usuarioHuella, idTarjeta\r\nFROM            TEmpleado\r\nWHERE        (idEmpresa = @idemp)";
			this._commandCollection[1].CommandType = CommandType.Text;
			this._commandCollection[1].Parameters.Add(new SqlParameter("@idemp", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
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
		public virtual int Insert(string nombre, int? idTipoIdentificacion, string identificacion, string Notarjeta, byte[] foto, int? idCargo, int idTipoEstado, int idEmpresa, int idDivisionEmpresa, int? idHorario, string observaciones, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string usuarioHuella, int? idTarjeta)
		{
			int num;
			if (nombre == null)
			{
				throw new ArgumentNullException("nombre");
			}
			this.Adapter.InsertCommand.Parameters[0].Value = nombre;
			if (!idTipoIdentificacion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = idTipoIdentificacion.Value;
			}
			if (identificacion != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = identificacion;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Notarjeta != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = Notarjeta;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (foto != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = foto;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (!idCargo.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = idCargo.Value;
			}
			this.Adapter.InsertCommand.Parameters[6].Value = idTipoEstado;
			this.Adapter.InsertCommand.Parameters[7].Value = idEmpresa;
			this.Adapter.InsertCommand.Parameters[8].Value = idDivisionEmpresa;
			if (!idHorario.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = idHorario.Value;
			}
			if (observaciones != null)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = observaciones;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
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
			if (usuarioHuella != null)
			{
				this.Adapter.InsertCommand.Parameters[13].Value = usuarioHuella;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
			}
			if (!idTarjeta.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[14].Value = idTarjeta.Value;
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
		public virtual int Update(masterDBACDataSet.TEmpleadoDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TEmpleado");
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
		public virtual int Update(string nombre, int? idTipoIdentificacion, string identificacion, string Notarjeta, byte[] foto, int? idCargo, int idTipoEstado, int idEmpresa, int idDivisionEmpresa, int? idHorario, string observaciones, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string usuarioHuella, int? idTarjeta, int Original_idEmpleado, string Original_nombre, int? Original_idTipoIdentificacion, string Original_identificacion, string Original_Notarjeta, int? Original_idCargo, int Original_idTipoEstado, int Original_idEmpresa, int Original_idDivisionEmpresa, int? Original_idHorario, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_usuarioHuella, int? Original_idTarjeta, int idEmpleado)
		{
			int num;
			if (nombre == null)
			{
				throw new ArgumentNullException("nombre");
			}
			this.Adapter.UpdateCommand.Parameters[0].Value = nombre;
			if (!idTipoIdentificacion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = idTipoIdentificacion.Value;
			}
			if (identificacion != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = identificacion;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Notarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = Notarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			if (foto != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = foto;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			if (!idCargo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = idCargo.Value;
			}
			this.Adapter.UpdateCommand.Parameters[6].Value = idTipoEstado;
			this.Adapter.UpdateCommand.Parameters[7].Value = idEmpresa;
			this.Adapter.UpdateCommand.Parameters[8].Value = idDivisionEmpresa;
			if (!idHorario.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = idHorario.Value;
			}
			if (observaciones != null)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = observaciones;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
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
			if (usuarioHuella != null)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = usuarioHuella;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			if (!idTarjeta.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = idTarjeta.Value;
			}
			this.Adapter.UpdateCommand.Parameters[15].Value = Original_idEmpleado;
			if (Original_nombre == null)
			{
				throw new ArgumentNullException("Original_nombre");
			}
			this.Adapter.UpdateCommand.Parameters[16].Value = Original_nombre;
			if (!Original_idTipoIdentificacion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_idTipoIdentificacion.Value;
			}
			if (Original_identificacion != null)
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 0;
				this.Adapter.UpdateCommand.Parameters[20].Value = Original_identificacion;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 1;
				this.Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
			}
			if (Original_Notarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 0;
				this.Adapter.UpdateCommand.Parameters[22].Value = Original_Notarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 1;
				this.Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
			}
			if (!Original_idCargo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 1;
				this.Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 0;
				this.Adapter.UpdateCommand.Parameters[24].Value = Original_idCargo.Value;
			}
			this.Adapter.UpdateCommand.Parameters[25].Value = Original_idTipoEstado;
			this.Adapter.UpdateCommand.Parameters[26].Value = Original_idEmpresa;
			this.Adapter.UpdateCommand.Parameters[27].Value = Original_idDivisionEmpresa;
			if (!Original_idHorario.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[28].Value = 1;
				this.Adapter.UpdateCommand.Parameters[29].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[28].Value = 0;
				this.Adapter.UpdateCommand.Parameters[29].Value = Original_idHorario.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[30].Value = 1;
				this.Adapter.UpdateCommand.Parameters[31].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[30].Value = 0;
				this.Adapter.UpdateCommand.Parameters[31].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[32].Value = 1;
				this.Adapter.UpdateCommand.Parameters[33].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[32].Value = 0;
				this.Adapter.UpdateCommand.Parameters[33].Value = Original_usuarioUltimaGestion.Value;
			}
			if (Original_usuarioHuella != null)
			{
				this.Adapter.UpdateCommand.Parameters[34].Value = 0;
				this.Adapter.UpdateCommand.Parameters[35].Value = Original_usuarioHuella;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[34].Value = 1;
				this.Adapter.UpdateCommand.Parameters[35].Value = DBNull.Value;
			}
			if (!Original_idTarjeta.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[36].Value = 1;
				this.Adapter.UpdateCommand.Parameters[37].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[36].Value = 0;
				this.Adapter.UpdateCommand.Parameters[37].Value = Original_idTarjeta.Value;
			}
			this.Adapter.UpdateCommand.Parameters[38].Value = idEmpleado;
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
		public virtual int Update(string nombre, int? idTipoIdentificacion, string identificacion, string Notarjeta, byte[] foto, int? idCargo, int idTipoEstado, int idEmpresa, int idDivisionEmpresa, int? idHorario, string observaciones, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string usuarioHuella, int? idTarjeta, int Original_idEmpleado, string Original_nombre, int? Original_idTipoIdentificacion, string Original_identificacion, string Original_Notarjeta, int? Original_idCargo, int Original_idTipoEstado, int Original_idEmpresa, int Original_idDivisionEmpresa, int? Original_idHorario, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_usuarioHuella, int? Original_idTarjeta)
		{
			int num = this.Update(nombre, idTipoIdentificacion, identificacion, Notarjeta, foto, idCargo, idTipoEstado, idEmpresa, idDivisionEmpresa, idHorario, observaciones, fechaUltimaGestion, usuarioUltimaGestion, usuarioHuella, idTarjeta, Original_idEmpleado, Original_nombre, Original_idTipoIdentificacion, Original_identificacion, Original_Notarjeta, Original_idCargo, Original_idTipoEstado, Original_idEmpresa, Original_idDivisionEmpresa, Original_idHorario, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_usuarioHuella, Original_idTarjeta, Original_idEmpleado);
			return num;
		}
	}
}