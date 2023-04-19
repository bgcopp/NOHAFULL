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
	public class TEmpresaTableAdapter : Component
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
		public TEmpresaTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idEmpresa, string Original_nit, string Original_RazonSocial, string Original_telefonos, string Original_telContactoInterno, string Original_EmpleadoContacto, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_CargoContacto)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idEmpresa;
			if (Original_nit != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_nit;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Original_RazonSocial != null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_RazonSocial;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Original_telefonos != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_telefonos;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			if (Original_telContactoInterno != null)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_telContactoInterno;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			if (Original_EmpleadoContacto != null)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_EmpleadoContacto;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 1;
				this.Adapter.DeleteCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[13].Value = 0;
				this.Adapter.DeleteCommand.Parameters[14].Value = Original_usuarioUltimaGestion.Value;
			}
			if (Original_CargoContacto != null)
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 0;
				this.Adapter.DeleteCommand.Parameters[16].Value = Original_CargoContacto;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[15].Value = 1;
				this.Adapter.DeleteCommand.Parameters[16].Value = DBNull.Value;
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
		public virtual int Fill(masterDBACDataSet.TEmpresaDataTable dataTable)
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
		public virtual int FillByidEmpresa(masterDBACDataSet.TEmpresaDataTable dataTable, int ide)
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
			this.Adapter.SelectCommand.Parameters[0].Value = ide;
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
		public virtual masterDBACDataSet.TEmpresaDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TEmpresaDataTable tEmpresaDataTable = new masterDBACDataSet.TEmpresaDataTable();
			this.Adapter.Fill(tEmpresaDataTable);
			return tEmpresaDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TEmpresa"
			};
			dataTableMapping.ColumnMappings.Add("idEmpresa", "idEmpresa");
			dataTableMapping.ColumnMappings.Add("nit", "nit");
			dataTableMapping.ColumnMappings.Add("RazonSocial", "RazonSocial");
			dataTableMapping.ColumnMappings.Add("telefonos", "telefonos");
			dataTableMapping.ColumnMappings.Add("telContactoInterno", "telContactoInterno");
			dataTableMapping.ColumnMappings.Add("EmpleadoContacto", "EmpleadoContacto");
			dataTableMapping.ColumnMappings.Add("ObservacioneEmpresa", "ObservacioneEmpresa");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("CargoContacto", "CargoContacto");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[TEmpresa] WHERE (([idEmpresa] = @Original_idEmpresa) AND ((@IsNull_nit = 1 AND [nit] IS NULL) OR ([nit] = @Original_nit)) AND ((@IsNull_RazonSocial = 1 AND [RazonSocial] IS NULL) OR ([RazonSocial] = @Original_RazonSocial)) AND ((@IsNull_telefonos = 1 AND [telefonos] IS NULL) OR ([telefonos] = @Original_telefonos)) AND ((@IsNull_telContactoInterno = 1 AND [telContactoInterno] IS NULL) OR ([telContactoInterno] = @Original_telContactoInterno)) AND ((@IsNull_EmpleadoContacto = 1 AND [EmpleadoContacto] IS NULL) OR ([EmpleadoContacto] = @Original_EmpleadoContacto)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_CargoContacto = 1 AND [CargoContacto] IS NULL) OR ([CargoContacto] = @Original_CargoContacto)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_nit", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "nit", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_nit", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nit", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_RazonSocial", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "RazonSocial", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_RazonSocial", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "RazonSocial", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_telefonos", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_telContactoInterno", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "telContactoInterno", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_telContactoInterno", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telContactoInterno", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_EmpleadoContacto", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "EmpleadoContacto", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_EmpleadoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "EmpleadoContacto", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CargoContacto", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CargoContacto", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CargoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "CargoContacto", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[TEmpresa] ([nit], [RazonSocial], [telefonos], [telContactoInterno], [EmpleadoContacto], [ObservacioneEmpresa], [fechaUltimaGestion], [usuarioUltimaGestion], [CargoContacto]) VALUES (@nit, @RazonSocial, @telefonos, @telContactoInterno, @EmpleadoContacto, @ObservacioneEmpresa, @fechaUltimaGestion, @usuarioUltimaGestion, @CargoContacto);\r\nSELECT idEmpresa, nit, RazonSocial, telefonos, telContactoInterno, EmpleadoContacto, ObservacioneEmpresa, fechaUltimaGestion, usuarioUltimaGestion, CargoContacto FROM TEmpresa WHERE (idEmpresa = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@nit", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nit", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "RazonSocial", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@telContactoInterno", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telContactoInterno", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EmpleadoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "EmpleadoContacto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacioneEmpresa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacioneEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CargoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "CargoContacto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[TEmpresa] SET [nit] = @nit, [RazonSocial] = @RazonSocial, [telefonos] = @telefonos, [telContactoInterno] = @telContactoInterno, [EmpleadoContacto] = @EmpleadoContacto, [ObservacioneEmpresa] = @ObservacioneEmpresa, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [CargoContacto] = @CargoContacto WHERE (([idEmpresa] = @Original_idEmpresa) AND ((@IsNull_nit = 1 AND [nit] IS NULL) OR ([nit] = @Original_nit)) AND ((@IsNull_RazonSocial = 1 AND [RazonSocial] IS NULL) OR ([RazonSocial] = @Original_RazonSocial)) AND ((@IsNull_telefonos = 1 AND [telefonos] IS NULL) OR ([telefonos] = @Original_telefonos)) AND ((@IsNull_telContactoInterno = 1 AND [telContactoInterno] IS NULL) OR ([telContactoInterno] = @Original_telContactoInterno)) AND ((@IsNull_EmpleadoContacto = 1 AND [EmpleadoContacto] IS NULL) OR ([EmpleadoContacto] = @Original_EmpleadoContacto)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_CargoContacto = 1 AND [CargoContacto] IS NULL) OR ([CargoContacto] = @Original_CargoContacto)));\r\nSELECT idEmpresa, nit, RazonSocial, telefonos, telContactoInterno, EmpleadoContacto, ObservacioneEmpresa, fechaUltimaGestion, usuarioUltimaGestion, CargoContacto FROM TEmpresa WHERE (idEmpresa = @idEmpresa)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@nit", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nit", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "RazonSocial", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@telContactoInterno", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telContactoInterno", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@EmpleadoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "EmpleadoContacto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacioneEmpresa", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacioneEmpresa", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CargoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "CargoContacto", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpresa", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_nit", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "nit", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_nit", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "nit", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_RazonSocial", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "RazonSocial", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_RazonSocial", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "RazonSocial", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_telefonos", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_telefonos", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telefonos", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_telContactoInterno", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "telContactoInterno", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_telContactoInterno", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "telContactoInterno", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_EmpleadoContacto", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "EmpleadoContacto", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_EmpleadoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "EmpleadoContacto", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CargoContacto", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CargoContacto", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CargoContacto", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "CargoContacto", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand(), null };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idEmpresa, nit, RazonSocial, telefonos, telContactoInterno, EmpleadoContacto, ObservacioneEmpresa, fechaUltimaGestion, usuarioUltimaGestion, CargoContacto FROM dbo.TEmpresa";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[1] = new SqlCommand();
			this._commandCollection[1].Connection = this.Connection;
			this._commandCollection[1].CommandText = "SELECT        idEmpresa, nit, RazonSocial, telefonos, telContactoInterno, EmpleadoContacto, ObservacioneEmpresa, fechaUltimaGestion, usuarioUltimaGestion, \r\n                         CargoContacto\r\nFROM            TEmpresa\r\nWHERE        (idEmpresa = @ide)";
			this._commandCollection[1].CommandType = CommandType.Text;
			this._commandCollection[1].Parameters.Add(new SqlParameter("@ide", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idEmpresa", DataRowVersion.Current, false, null, "", "", ""));
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
		public virtual int Insert(string nit, string RazonSocial, string telefonos, string telContactoInterno, string EmpleadoContacto, string ObservacioneEmpresa, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string CargoContacto)
		{
			int num;
			if (nit != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = nit;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (RazonSocial != null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = RazonSocial;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			if (telefonos != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = telefonos;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (telContactoInterno != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = telContactoInterno;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (EmpleadoContacto != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = EmpleadoContacto;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (ObservacioneEmpresa != null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = ObservacioneEmpresa;
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
			if (CargoContacto != null)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = CargoContacto;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
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
		public virtual int Update(masterDBACDataSet.TEmpresaDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TEmpresa");
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
		public virtual int Update(string nit, string RazonSocial, string telefonos, string telContactoInterno, string EmpleadoContacto, string ObservacioneEmpresa, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string CargoContacto, int Original_idEmpresa, string Original_nit, string Original_RazonSocial, string Original_telefonos, string Original_telContactoInterno, string Original_EmpleadoContacto, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_CargoContacto, int idEmpresa)
		{
			int num;
			if (nit != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = nit;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (RazonSocial != null)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = RazonSocial;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			if (telefonos != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = telefonos;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			if (telContactoInterno != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = telContactoInterno;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			if (EmpleadoContacto != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = EmpleadoContacto;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			if (ObservacioneEmpresa != null)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = ObservacioneEmpresa;
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
			if (CargoContacto != null)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = CargoContacto;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[9].Value = Original_idEmpresa;
			if (Original_nit != null)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 0;
				this.Adapter.UpdateCommand.Parameters[11].Value = Original_nit;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 1;
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			if (Original_RazonSocial != null)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 0;
				this.Adapter.UpdateCommand.Parameters[13].Value = Original_RazonSocial;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 1;
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			if (Original_telefonos != null)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_telefonos;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			if (Original_telContactoInterno != null)
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 0;
				this.Adapter.UpdateCommand.Parameters[17].Value = Original_telContactoInterno;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[16].Value = 1;
				this.Adapter.UpdateCommand.Parameters[17].Value = DBNull.Value;
			}
			if (Original_EmpleadoContacto != null)
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 0;
				this.Adapter.UpdateCommand.Parameters[19].Value = Original_EmpleadoContacto;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[18].Value = 1;
				this.Adapter.UpdateCommand.Parameters[19].Value = DBNull.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 1;
				this.Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 0;
				this.Adapter.UpdateCommand.Parameters[21].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 1;
				this.Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[22].Value = 0;
				this.Adapter.UpdateCommand.Parameters[23].Value = Original_usuarioUltimaGestion.Value;
			}
			if (Original_CargoContacto != null)
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 0;
				this.Adapter.UpdateCommand.Parameters[25].Value = Original_CargoContacto;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[24].Value = 1;
				this.Adapter.UpdateCommand.Parameters[25].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[26].Value = idEmpresa;
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
		public virtual int Update(string nit, string RazonSocial, string telefonos, string telContactoInterno, string EmpleadoContacto, string ObservacioneEmpresa, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, string CargoContacto, int Original_idEmpresa, string Original_nit, string Original_RazonSocial, string Original_telefonos, string Original_telContactoInterno, string Original_EmpleadoContacto, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, string Original_CargoContacto)
		{
			int num = this.Update(nit, RazonSocial, telefonos, telContactoInterno, EmpleadoContacto, ObservacioneEmpresa, fechaUltimaGestion, usuarioUltimaGestion, CargoContacto, Original_idEmpresa, Original_nit, Original_RazonSocial, Original_telefonos, Original_telContactoInterno, Original_EmpleadoContacto, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_CargoContacto, Original_idEmpresa);
			return num;
		}
	}
}