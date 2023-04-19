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
	public class TVisitanteTableAdapter : Component
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
		public TVisitanteTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_idVisitante, string Original_nombreVisitante, int? Original_idTipoIdentificacion, string Original_identificacionVisitante, int? Original_idEmpresaVisitante, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_empresa, string Original_direccion, string Original_telefonos)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idVisitante;
			if (Original_nombreVisitante != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_nombreVisitante;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!Original_idTipoIdentificacion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_idTipoIdentificacion.Value;
			}
			if (Original_identificacionVisitante != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_identificacionVisitante;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			if (!Original_idEmpresaVisitante.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_idEmpresaVisitante.Value;
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
			if (Original_empresa != null)
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 0;
				this.Adapter.DeleteCommand.Parameters[14].Value = Original_empresa;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 1;
				this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
			}
			if (Original_direccion != null)
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 0;
				this.Adapter.DeleteCommand.Parameters[16].Value = Original_direccion;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 1;
				this.Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
			}
			if (Original_telefonos != null)
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 0;
				this.Adapter.DeleteCommand.Parameters[18].Value = Original_telefonos;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[17].Value = 1;
				this.Adapter.DeleteCommand.Parameters[18].Value = DBNull.Value;
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
		public virtual int Fill(masterDBACDataSet.TVisitanteDataTable dataTable)
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
		public virtual masterDBACDataSet.TVisitanteDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TVisitanteDataTable tVisitanteDataTable = new masterDBACDataSet.TVisitanteDataTable();
			this.Adapter.Fill(tVisitanteDataTable);
			return tVisitanteDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TVisitante"
			};
			dataTableMapping.ColumnMappings.Add("idVisitante", "idVisitante");
			dataTableMapping.ColumnMappings.Add("nombreVisitante", "nombreVisitante");
			dataTableMapping.ColumnMappings.Add("idTipoIdentificacion", "idTipoIdentificacion");
			dataTableMapping.ColumnMappings.Add("identificacionVisitante", "identificacionVisitante");
			dataTableMapping.ColumnMappings.Add("huella", "huella");
			dataTableMapping.ColumnMappings.Add("foto", "foto");
			dataTableMapping.ColumnMappings.Add("idEmpresaVisitante", "idEmpresaVisitante");
			dataTableMapping.ColumnMappings.Add("observacionesVisitante", "observacionesVisitante");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("empresa", "empresa");
			dataTableMapping.ColumnMappings.Add("direccion", "direccion");
			dataTableMapping.ColumnMappings.Add("telefonos", "telefonos");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [TVisitante] WHERE (([idVisitante] = @Original_idVisitante) AND ((@IsNull_nombreVisitante = 1 AND [nombreVisitante] IS NULL) OR ([nombreVisitante] = @Original_nombreVisitante)) AND ((@IsNull_idTipoIdentificacion = 1 AND [idTipoIdentificacion] IS NULL) OR ([idTipoIdentificacion] = @Original_idTipoIdentificacion)) AND ((@IsNull_identificacionVisitante = 1 AND [identificacionVisitante] IS NULL) OR ([identificacionVisitante] = @Original_identificacionVisitante)) AND ((@IsNull_idEmpresaVisitante = 1 AND [idEmpresaVisitante] IS NULL) OR ([idEmpresaVisitante] = @Original_idEmpresaVisitante)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_empresa = 1 AND [empresa] IS NULL) OR ([empresa] = @Original_empresa)) AND ((@IsNull_direccion = 1 AND [direccion] IS NULL) OR ([direccion] = @Original_direccion)) AND ((@IsNull_telefonos = 1 AND [telefonos] IS NULL) OR ([telefonos] = @Original_telefonos)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_nombreVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "nombreVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_nombreVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombreVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_identificacionVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "identificacionVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_identificacionVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacionVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpresaVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresaVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpresaVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresaVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_empresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "empresa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_empresa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "empresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_direccion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "direccion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_direccion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_telefonos", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [TVisitante] ([nombreVisitante], [idTipoIdentificacion], [identificacionVisitante], [huella], [foto], [idEmpresaVisitante], [observacionesVisitante], [fechaUltimaGestion], [usuarioUltimaGestion], [empresa], [direccion], [telefonos]) VALUES (@nombreVisitante, @idTipoIdentificacion, @identificacionVisitante, @huella, @foto, @idEmpresaVisitante, @observacionesVisitante, @fechaUltimaGestion, @usuarioUltimaGestion, @empresa, @direccion, @telefonos);\r\nSELECT idVisitante, nombreVisitante, idTipoIdentificacion, identificacionVisitante, huella, foto, idEmpresaVisitante, observacionesVisitante, fechaUltimaGestion, usuarioUltimaGestion, empresa, direccion, telefonos FROM TVisitante WHERE (idVisitante = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@nombreVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombreVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@identificacionVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacionVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@huella", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "huella", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "foto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpresaVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresaVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@observacionesVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observacionesVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@empresa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "empresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [TVisitante] SET [nombreVisitante] = @nombreVisitante, [idTipoIdentificacion] = @idTipoIdentificacion, [identificacionVisitante] = @identificacionVisitante, [huella] = @huella, [foto] = @foto, [idEmpresaVisitante] = @idEmpresaVisitante, [observacionesVisitante] = @observacionesVisitante, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [empresa] = @empresa, [direccion] = @direccion, [telefonos] = @telefonos WHERE (([idVisitante] = @Original_idVisitante) AND ((@IsNull_nombreVisitante = 1 AND [nombreVisitante] IS NULL) OR ([nombreVisitante] = @Original_nombreVisitante)) AND ((@IsNull_idTipoIdentificacion = 1 AND [idTipoIdentificacion] IS NULL) OR ([idTipoIdentificacion] = @Original_idTipoIdentificacion)) AND ((@IsNull_identificacionVisitante = 1 AND [identificacionVisitante] IS NULL) OR ([identificacionVisitante] = @Original_identificacionVisitante)) AND ((@IsNull_idEmpresaVisitante = 1 AND [idEmpresaVisitante] IS NULL) OR ([idEmpresaVisitante] = @Original_idEmpresaVisitante)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_empresa = 1 AND [empresa] IS NULL) OR ([empresa] = @Original_empresa)) AND ((@IsNull_direccion = 1 AND [direccion] IS NULL) OR ([direccion] = @Original_direccion)) AND ((@IsNull_telefonos = 1 AND [telefonos] IS NULL) OR ([telefonos] = @Original_telefonos)));\r\nSELECT idVisitante, nombreVisitante, idTipoIdentificacion, identificacionVisitante, huella, foto, idEmpresaVisitante, observacionesVisitante, fechaUltimaGestion, usuarioUltimaGestion, empresa, direccion, telefonos FROM TVisitante WHERE (idVisitante = @idVisitante)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@nombreVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombreVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@identificacionVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacionVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@huella", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "huella", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image, 0, ParameterDirection.Input, 0, 0, "foto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpresaVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresaVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@observacionesVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "observacionesVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@empresa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "empresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_nombreVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "nombreVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_nombreVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nombreVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idTipoIdentificacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idTipoIdentificacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_identificacionVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "identificacionVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_identificacionVisitante", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "identificacionVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpresaVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresaVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpresaVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresaVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_empresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "empresa", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_empresa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "empresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_direccion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "direccion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_direccion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_telefonos", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVisitante", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT        idVisitante, nombreVisitante, idTipoIdentificacion, identificacionVisitante, huella, foto, idEmpresaVisitante, observacionesVisitante, fechaUltimaGestion, \r\n                         usuarioUltimaGestion, empresa, direccion, telefonos\r\nFROM            TVisitante";
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
		public virtual int Insert(string nombreVisitante, int? idTipoIdentificacion, string identificacionVisitante, string huella, byte[] foto, int? idEmpresaVisitante, string observacionesVisitante, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string empresa, string direccion, string telefonos)
		{
			int num;
			if (nombreVisitante != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = nombreVisitante;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!idTipoIdentificacion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = idTipoIdentificacion.Value;
			}
			if (identificacionVisitante != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = identificacionVisitante;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (huella != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = huella;
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
			if (!idEmpresaVisitante.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = idEmpresaVisitante.Value;
			}
			if (observacionesVisitante != null)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = observacionesVisitante;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = usuarioUltimaGestion.Value;
			}
			if (empresa != null)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = empresa;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			if (direccion != null)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = direccion;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			if (telefonos != null)
			{
				this.Adapter.InsertCommand.Parameters[11].Value = telefonos;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
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
		public virtual int Update(masterDBACDataSet.TVisitanteDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TVisitante");
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
		public virtual int Update(string nombreVisitante, int? idTipoIdentificacion, string identificacionVisitante, string huella, byte[] foto, int? idEmpresaVisitante, string observacionesVisitante, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string empresa, string direccion, string telefonos, decimal Original_idVisitante, string Original_nombreVisitante, int? Original_idTipoIdentificacion, string Original_identificacionVisitante, int? Original_idEmpresaVisitante, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_empresa, string Original_direccion, string Original_telefonos, decimal idVisitante)
		{
			int num;
			if (nombreVisitante != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = nombreVisitante;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!idTipoIdentificacion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = idTipoIdentificacion.Value;
			}
			if (identificacionVisitante != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = identificacionVisitante;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			if (huella != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = huella;
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
			if (!idEmpresaVisitante.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = idEmpresaVisitante.Value;
			}
			if (observacionesVisitante != null)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = observacionesVisitante;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			if (!fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = fechaUltimaGestion.Value;
			}
			if (!usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = usuarioUltimaGestion.Value;
			}
			if (empresa != null)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = empresa;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			if (direccion != null)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = direccion;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			if (telefonos != null)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = telefonos;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[12].Value = Original_idVisitante;
			if (Original_nombreVisitante != null)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_nombreVisitante;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			if (!Original_idTipoIdentificacion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_idTipoIdentificacion.Value;
			}
			if (Original_identificacionVisitante != null)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_identificacionVisitante;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			if (!Original_idEmpresaVisitante.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 1;
				this.Adapter.UpdateCommand.Parameters[20].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[19].Value = 0;
				this.Adapter.UpdateCommand.Parameters[20].Value = Original_idEmpresaVisitante.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 1;
				this.Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[21].Value = 0;
				this.Adapter.UpdateCommand.Parameters[22].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 1;
				this.Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[23].Value = 0;
				this.Adapter.UpdateCommand.Parameters[24].Value = Original_usuarioUltimaGestion.Value;
			}
			if (Original_empresa != null)
			{
				this.Adapter.UpdateCommand.Parameters[25].Value = 0;
				this.Adapter.UpdateCommand.Parameters[26].Value = Original_empresa;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[25].Value = 1;
				this.Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
			}
			if (Original_direccion != null)
			{
				this.Adapter.UpdateCommand.Parameters[27].Value = 0;
				this.Adapter.UpdateCommand.Parameters[28].Value = Original_direccion;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[27].Value = 1;
				this.Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
			}
			if (Original_telefonos != null)
			{
				this.Adapter.UpdateCommand.Parameters[29].Value = 0;
				this.Adapter.UpdateCommand.Parameters[30].Value = Original_telefonos;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[29].Value = 1;
				this.Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[31].Value = idVisitante;
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
		public virtual int Update(string nombreVisitante, int? idTipoIdentificacion, string identificacionVisitante, string huella, byte[] foto, int? idEmpresaVisitante, string observacionesVisitante, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string empresa, string direccion, string telefonos, decimal Original_idVisitante, string Original_nombreVisitante, int? Original_idTipoIdentificacion, string Original_identificacionVisitante, int? Original_idEmpresaVisitante, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_empresa, string Original_direccion, string Original_telefonos)
		{
			int num = this.Update(nombreVisitante, idTipoIdentificacion, identificacionVisitante, huella, foto, idEmpresaVisitante, observacionesVisitante, fechaUltimaGestion, usuarioUltimaGestion, empresa, direccion, telefonos, Original_idVisitante, Original_nombreVisitante, Original_idTipoIdentificacion, Original_identificacionVisitante, Original_idEmpresaVisitante, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_empresa, Original_direccion, Original_telefonos, Original_idVisitante);
			return num;
		}
	}
}