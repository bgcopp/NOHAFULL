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
	public class TMarcacionTableAdapter : Component
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
		public TMarcacionTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_idMarcacion, string Original_NoTarjeta, DateTime? Original_fechaMarcacion, string Original_NoInner, decimal? Original_idVisitante, int? Original_idEmpleado, decimal? Original_idVisitanteVistaP)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idMarcacion;
			if (Original_NoTarjeta != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_NoTarjeta;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!Original_fechaMarcacion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_fechaMarcacion.Value;
			}
			if (Original_NoInner != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_NoInner;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			if (!Original_idVisitante.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_idVisitante.Value;
			}
			if (!Original_idEmpleado.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_idEmpleado.Value;
			}
			if (!Original_idVisitanteVistaP.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 1;
				this.Adapter.DeleteCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[11].Value = 0;
				this.Adapter.DeleteCommand.Parameters[12].Value = Original_idVisitanteVistaP.Value;
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
		public virtual int Fill(masterDBACDataSet.TMarcacionDataTable dataTable)
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
		public virtual int FillByEmpleados(masterDBACDataSet.TMarcacionDataTable dataTable)
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
		public virtual int FillByVisitantes(masterDBACDataSet.TMarcacionDataTable dataTable)
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
		public virtual masterDBACDataSet.TMarcacionDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TMarcacionDataTable tMarcacionDataTable = new masterDBACDataSet.TMarcacionDataTable();
			this.Adapter.Fill(tMarcacionDataTable);
			return tMarcacionDataTable;
		}

		[DataObjectMethod(DataObjectMethodType.Select, false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual masterDBACDataSet.TMarcacionDataTable GetDataBy()
		{
			this.Adapter.SelectCommand = this.CommandCollection[1];
			masterDBACDataSet.TMarcacionDataTable tMarcacionDataTable = new masterDBACDataSet.TMarcacionDataTable();
			this.Adapter.Fill(tMarcacionDataTable);
			return tMarcacionDataTable;
		}

		[DataObjectMethod(DataObjectMethodType.Select, false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual masterDBACDataSet.TMarcacionDataTable GetDataBy1()
		{
			this.Adapter.SelectCommand = this.CommandCollection[2];
			masterDBACDataSet.TMarcacionDataTable tMarcacionDataTable = new masterDBACDataSet.TMarcacionDataTable();
			this.Adapter.Fill(tMarcacionDataTable);
			return tMarcacionDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TMarcacion"
			};
			dataTableMapping.ColumnMappings.Add("idMarcacion", "idMarcacion");
			dataTableMapping.ColumnMappings.Add("NoTarjeta", "NoTarjeta");
			dataTableMapping.ColumnMappings.Add("fechaMarcacion", "fechaMarcacion");
			dataTableMapping.ColumnMappings.Add("NoInner", "NoInner");
			dataTableMapping.ColumnMappings.Add("idVisitante", "idVisitante");
			dataTableMapping.ColumnMappings.Add("idEmpleado", "idEmpleado");
			dataTableMapping.ColumnMappings.Add("idVisitanteVistaP", "idVisitanteVistaP");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[TMarcacion] WHERE (([idMarcacion] = @Original_idMarcacion) AND ((@IsNull_NoTarjeta = 1 AND [NoTarjeta] IS NULL) OR ([NoTarjeta] = @Original_NoTarjeta)) AND ((@IsNull_fechaMarcacion = 1 AND [fechaMarcacion] IS NULL) OR ([fechaMarcacion] = @Original_fechaMarcacion)) AND ((@IsNull_NoInner = 1 AND [NoInner] IS NULL) OR ([NoInner] = @Original_NoInner)) AND ((@IsNull_idVisitante = 1 AND [idVisitante] IS NULL) OR ([idVisitante] = @Original_idVisitante)) AND ((@IsNull_idEmpleado = 1 AND [idEmpleado] IS NULL) OR ([idEmpleado] = @Original_idEmpleado)) AND ((@IsNull_idVisitanteVistaP = 1 AND [idVisitanteVistaP] IS NULL) OR ([idVisitanteVistaP] = @Original_idVisitanteVistaP)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idMarcacion", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idMarcacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_NoTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NoTarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_NoTarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaMarcacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaMarcacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaMarcacion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaMarcacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_NoInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NoInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_NoInner", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "NoInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_idVisitanteVistaP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVisitanteVistaP", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idVisitanteVistaP", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitanteVistaP", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[TMarcacion] ([NoTarjeta], [fechaMarcacion], [NoInner], [idVisitante], [idEmpleado], [idVisitanteVistaP]) VALUES (@NoTarjeta, @fechaMarcacion, @NoInner, @idVisitante, @idEmpleado, @idVisitanteVistaP);\r\nSELECT idMarcacion, NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP FROM TMarcacion WHERE (idMarcacion = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoTarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoTarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaMarcacion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaMarcacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoInner", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "NoInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@idVisitanteVistaP", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitanteVistaP", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[TMarcacion] SET [NoTarjeta] = @NoTarjeta, [fechaMarcacion] = @fechaMarcacion, [NoInner] = @NoInner, [idVisitante] = @idVisitante, [idEmpleado] = @idEmpleado, [idVisitanteVistaP] = @idVisitanteVistaP WHERE (([idMarcacion] = @Original_idMarcacion) AND ((@IsNull_NoTarjeta = 1 AND [NoTarjeta] IS NULL) OR ([NoTarjeta] = @Original_NoTarjeta)) AND ((@IsNull_fechaMarcacion = 1 AND [fechaMarcacion] IS NULL) OR ([fechaMarcacion] = @Original_fechaMarcacion)) AND ((@IsNull_NoInner = 1 AND [NoInner] IS NULL) OR ([NoInner] = @Original_NoInner)) AND ((@IsNull_idVisitante = 1 AND [idVisitante] IS NULL) OR ([idVisitante] = @Original_idVisitante)) AND ((@IsNull_idEmpleado = 1 AND [idEmpleado] IS NULL) OR ([idEmpleado] = @Original_idEmpleado)) AND ((@IsNull_idVisitanteVistaP = 1 AND [idVisitanteVistaP] IS NULL) OR ([idVisitanteVistaP] = @Original_idVisitanteVistaP)));\r\nSELECT idMarcacion, NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP FROM TMarcacion WHERE (idMarcacion = @idMarcacion)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoTarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoTarjeta", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaMarcacion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaMarcacion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoInner", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "NoInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idVisitanteVistaP", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitanteVistaP", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idMarcacion", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idMarcacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_NoTarjeta", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NoTarjeta", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_NoTarjeta", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoTarjeta", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaMarcacion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaMarcacion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaMarcacion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaMarcacion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_NoInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NoInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_NoInner", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "NoInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idVisitante", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVisitante", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVisitante", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitante", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idEmpleado", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idEmpleado", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_idVisitanteVistaP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idVisitanteVistaP", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idVisitanteVistaP", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "idVisitanteVistaP", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idMarcacion", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, "idMarcacion", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand(), null, null };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idMarcacion, NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP FROM dbo.TMarcacion";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[1] = new SqlCommand();
			this._commandCollection[1].Connection = this.Connection;
			this._commandCollection[1].CommandText = "SELECT        idMarcacion, NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP\r\nFROM            TMarcacion\r\nWHERE        (idVisitante IS NULL)";
			this._commandCollection[1].CommandType = CommandType.Text;
			this._commandCollection[2] = new SqlCommand();
			this._commandCollection[2].Connection = this.Connection;
			this._commandCollection[2].CommandText = "SELECT        idMarcacion, NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP\r\nFROM            TMarcacion\r\nWHERE        (idEmpleado IS NULL)";
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
		public virtual int Insert(string NoTarjeta, DateTime? fechaMarcacion, string NoInner, decimal? idVisitante, int? idEmpleado, decimal? idVisitanteVistaP)
		{
			int num;
			if (NoTarjeta != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = NoTarjeta;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!fechaMarcacion.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = fechaMarcacion.Value;
			}
			if (NoInner != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = NoInner;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!idVisitante.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = idVisitante.Value;
			}
			if (!idEmpleado.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = idEmpleado.Value;
			}
			if (!idVisitanteVistaP.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = idVisitanteVistaP.Value;
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
		public virtual int Update(masterDBACDataSet.TMarcacionDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TMarcacion");
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
		public virtual int Update(string NoTarjeta, DateTime? fechaMarcacion, string NoInner, decimal? idVisitante, int? idEmpleado, decimal? idVisitanteVistaP, decimal Original_idMarcacion, string Original_NoTarjeta, DateTime? Original_fechaMarcacion, string Original_NoInner, decimal? Original_idVisitante, int? Original_idEmpleado, decimal? Original_idVisitanteVistaP, decimal idMarcacion)
		{
			int num;
			if (NoTarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = NoTarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (!fechaMarcacion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = fechaMarcacion.Value;
			}
			if (NoInner != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = NoInner;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!idVisitante.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = idVisitante.Value;
			}
			if (!idEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = idEmpleado.Value;
			}
			if (!idVisitanteVistaP.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = idVisitanteVistaP.Value;
			}
			this.Adapter.UpdateCommand.Parameters[6].Value = Original_idMarcacion;
			if (Original_NoTarjeta != null)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 0;
				this.Adapter.UpdateCommand.Parameters[8].Value = Original_NoTarjeta;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 1;
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			if (!Original_fechaMarcacion.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_fechaMarcacion.Value;
			}
			if (Original_NoInner != null)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 0;
				this.Adapter.UpdateCommand.Parameters[12].Value = Original_NoInner;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 1;
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			if (!Original_idVisitante.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_idVisitante.Value;
			}
			if (!Original_idEmpleado.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_idEmpleado.Value;
			}
			if (!Original_idVisitanteVistaP.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 1;
				this.Adapter.UpdateCommand.Parameters[18].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[17].Value = 0;
				this.Adapter.UpdateCommand.Parameters[18].Value = Original_idVisitanteVistaP.Value;
			}
			this.Adapter.UpdateCommand.Parameters[19].Value = idMarcacion;
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
		public virtual int Update(string NoTarjeta, DateTime? fechaMarcacion, string NoInner, decimal? idVisitante, int? idEmpleado, decimal? idVisitanteVistaP, decimal Original_idMarcacion, string Original_NoTarjeta, DateTime? Original_fechaMarcacion, string Original_NoInner, decimal? Original_idVisitante, int? Original_idEmpleado, decimal? Original_idVisitanteVistaP)
		{
			int num = this.Update(NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP, Original_idMarcacion, Original_NoTarjeta, Original_fechaMarcacion, Original_NoInner, Original_idVisitante, Original_idEmpleado, Original_idVisitanteVistaP, Original_idMarcacion);
			return num;
		}
	}
}