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
	public class THorarioTableAdapter : Component
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
		public THorarioTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idHorario, string Original_NombreHorario, bool Original_esMaestro, DateTime? Original_fechaInicio, DateTime? Original_fechaFin, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_esPermanente)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idHorario;
			if (Original_NombreHorario != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_NombreHorario;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			this.Adapter.DeleteCommand.Parameters[3].Value = Original_esMaestro;
			if (!Original_fechaInicio.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 1;
				this.Adapter.DeleteCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[4].Value = 0;
				this.Adapter.DeleteCommand.Parameters[5].Value = Original_fechaInicio.Value;
			}
			if (!Original_fechaFin.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 1;
				this.Adapter.DeleteCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[6].Value = 0;
				this.Adapter.DeleteCommand.Parameters[7].Value = Original_fechaFin.Value;
			}
			if (!Original_fechaUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 1;
				this.Adapter.DeleteCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[8].Value = 0;
				this.Adapter.DeleteCommand.Parameters[9].Value = Original_fechaUltimaGestion.Value;
			}
			if (!Original_usuarioUltimaGestion.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[10].Value = 1;
				this.Adapter.DeleteCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[10].Value = 0;
				this.Adapter.DeleteCommand.Parameters[11].Value = Original_usuarioUltimaGestion.Value;
			}
			if (!Original_esPermanente.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[12].Value = 1;
				this.Adapter.DeleteCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[12].Value = 0;
				this.Adapter.DeleteCommand.Parameters[13].Value = Original_esPermanente.Value;
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
		public virtual int Fill(masterDBACDataSet.THorarioDataTable dataTable)
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
		public virtual masterDBACDataSet.THorarioDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.THorarioDataTable tHorarioDataTable = new masterDBACDataSet.THorarioDataTable();
			this.Adapter.Fill(tHorarioDataTable);
			return tHorarioDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "THorario"
			};
			dataTableMapping.ColumnMappings.Add("idHorario", "idHorario");
			dataTableMapping.ColumnMappings.Add("NombreHorario", "NombreHorario");
			dataTableMapping.ColumnMappings.Add("esMaestro", "esMaestro");
			dataTableMapping.ColumnMappings.Add("fechaInicio", "fechaInicio");
			dataTableMapping.ColumnMappings.Add("fechaFin", "fechaFin");
			dataTableMapping.ColumnMappings.Add("ObservacionesHorario", "ObservacionesHorario");
			dataTableMapping.ColumnMappings.Add("fechaUltimaGestion", "fechaUltimaGestion");
			dataTableMapping.ColumnMappings.Add("usuarioUltimaGestion", "usuarioUltimaGestion");
			dataTableMapping.ColumnMappings.Add("esPermanente", "esPermanente");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[THorario] WHERE (([idHorario] = @Original_idHorario) AND ((@IsNull_NombreHorario = 1 AND [NombreHorario] IS NULL) OR ([NombreHorario] = @Original_NombreHorario)) AND ([esMaestro] = @Original_esMaestro) AND ((@IsNull_fechaInicio = 1 AND [fechaInicio] IS NULL) OR ([fechaInicio] = @Original_fechaInicio)) AND ((@IsNull_fechaFin = 1 AND [fechaFin] IS NULL) OR ([fechaFin] = @Original_fechaFin)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_esPermanente = 1 AND [esPermanente] IS NULL) OR ([esPermanente] = @Original_esPermanente)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_NombreHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NombreHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_NombreHorario", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_esMaestro", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esMaestro", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaInicio", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaFin", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaFin", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaFin", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_esPermanente", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esPermanente", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_esPermanente", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esPermanente", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[THorario] ([NombreHorario], [esMaestro], [fechaInicio], [fechaFin], [ObservacionesHorario], [fechaUltimaGestion], [usuarioUltimaGestion], [esPermanente]) VALUES (@NombreHorario, @esMaestro, @fechaInicio, @fechaFin, @ObservacionesHorario, @fechaUltimaGestion, @usuarioUltimaGestion, @esPermanente);\r\nSELECT idHorario, NombreHorario, esMaestro, fechaInicio, fechaFin, ObservacionesHorario, fechaUltimaGestion, usuarioUltimaGestion, esPermanente FROM THorario WHERE (idHorario = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@NombreHorario", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@esMaestro", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esMaestro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaFin", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ObservacionesHorario", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@esPermanente", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esPermanente", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[THorario] SET [NombreHorario] = @NombreHorario, [esMaestro] = @esMaestro, [fechaInicio] = @fechaInicio, [fechaFin] = @fechaFin, [ObservacionesHorario] = @ObservacionesHorario, [fechaUltimaGestion] = @fechaUltimaGestion, [usuarioUltimaGestion] = @usuarioUltimaGestion, [esPermanente] = @esPermanente WHERE (([idHorario] = @Original_idHorario) AND ((@IsNull_NombreHorario = 1 AND [NombreHorario] IS NULL) OR ([NombreHorario] = @Original_NombreHorario)) AND ([esMaestro] = @Original_esMaestro) AND ((@IsNull_fechaInicio = 1 AND [fechaInicio] IS NULL) OR ([fechaInicio] = @Original_fechaInicio)) AND ((@IsNull_fechaFin = 1 AND [fechaFin] IS NULL) OR ([fechaFin] = @Original_fechaFin)) AND ((@IsNull_fechaUltimaGestion = 1 AND [fechaUltimaGestion] IS NULL) OR ([fechaUltimaGestion] = @Original_fechaUltimaGestion)) AND ((@IsNull_usuarioUltimaGestion = 1 AND [usuarioUltimaGestion] IS NULL) OR ([usuarioUltimaGestion] = @Original_usuarioUltimaGestion)) AND ((@IsNull_esPermanente = 1 AND [esPermanente] IS NULL) OR ([esPermanente] = @Original_esPermanente)));\r\nSELECT idHorario, NombreHorario, esMaestro, fechaInicio, fechaFin, ObservacionesHorario, fechaUltimaGestion, usuarioUltimaGestion, esPermanente FROM THorario WHERE (idHorario = @idHorario)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NombreHorario", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@esMaestro", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esMaestro", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaFin", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ObservacionesHorario", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ObservacionesHorario", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@esPermanente", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esPermanente", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_NombreHorario", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NombreHorario", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_NombreHorario", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreHorario", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_esMaestro", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esMaestro", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaInicio", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaInicio", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaInicio", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaFin", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaFin", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaFin", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaFin", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fechaUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fechaUltimaGestion", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fechaUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_usuarioUltimaGestion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "usuarioUltimaGestion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_esPermanente", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esPermanente", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_esPermanente", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esPermanente", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idHorario", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idHorario", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idHorario, NombreHorario, esMaestro, fechaInicio, fechaFin, ObservacionesHorario, fechaUltimaGestion, usuarioUltimaGestion, esPermanente FROM dbo.THorario";
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
		public virtual int Insert(string NombreHorario, bool esMaestro, DateTime? fechaInicio, DateTime? fechaFin, string ObservacionesHorario, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? esPermanente)
		{
			int num;
			if (NombreHorario != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = NombreHorario;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			this.Adapter.InsertCommand.Parameters[1].Value = esMaestro;
			if (!fechaInicio.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = fechaInicio.Value;
			}
			if (!fechaFin.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = fechaFin.Value;
			}
			if (ObservacionesHorario != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = ObservacionesHorario;
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
			if (!esPermanente.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = esPermanente.Value;
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
		public virtual int Update(masterDBACDataSet.THorarioDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "THorario");
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
		public virtual int Update(string NombreHorario, bool esMaestro, DateTime? fechaInicio, DateTime? fechaFin, string ObservacionesHorario, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? esPermanente, int Original_idHorario, string Original_NombreHorario, bool Original_esMaestro, DateTime? Original_fechaInicio, DateTime? Original_fechaFin, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_esPermanente, int idHorario)
		{
			int num;
			if (NombreHorario != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = NombreHorario;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[1].Value = esMaestro;
			if (!fechaInicio.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = fechaInicio.Value;
			}
			if (!fechaFin.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = fechaFin.Value;
			}
			if (ObservacionesHorario != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = ObservacionesHorario;
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
			if (!esPermanente.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = esPermanente.Value;
			}
			this.Adapter.UpdateCommand.Parameters[8].Value = Original_idHorario;
			if (Original_NombreHorario != null)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_NombreHorario;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[11].Value = Original_esMaestro;
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
			if (!Original_fechaFin.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_fechaFin.Value;
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
			if (!Original_esPermanente.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 1;
				this.Adapter.UpdateCommand.Parameters[21].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[20].Value = 0;
				this.Adapter.UpdateCommand.Parameters[21].Value = Original_esPermanente.Value;
			}
			this.Adapter.UpdateCommand.Parameters[22].Value = idHorario;
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
		public virtual int Update(string NombreHorario, bool esMaestro, DateTime? fechaInicio, DateTime? fechaFin, string ObservacionesHorario, DateTime? fechaUltimaGestion, int? usuarioUltimaGestion, bool? esPermanente, int Original_idHorario, string Original_NombreHorario, bool Original_esMaestro, DateTime? Original_fechaInicio, DateTime? Original_fechaFin, DateTime? Original_fechaUltimaGestion, int? Original_usuarioUltimaGestion, bool? Original_esPermanente)
		{
			int num = this.Update(NombreHorario, esMaestro, fechaInicio, fechaFin, ObservacionesHorario, fechaUltimaGestion, usuarioUltimaGestion, esPermanente, Original_idHorario, Original_NombreHorario, Original_esMaestro, Original_fechaInicio, Original_fechaFin, Original_fechaUltimaGestion, Original_usuarioUltimaGestion, Original_esPermanente, Original_idHorario);
			return num;
		}
	}
}