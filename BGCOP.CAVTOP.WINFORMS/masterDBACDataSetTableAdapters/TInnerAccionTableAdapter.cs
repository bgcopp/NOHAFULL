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
	public class TInnerAccionTableAdapter : Component
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
		public TInnerAccionTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_id, int? Original_CodeInner, string Original_CodigoAccion, DateTime? Original_fecha, int? Original_Cumplido)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_id;
			if (!Original_CodeInner.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_CodeInner.Value;
			}
			if (Original_CodigoAccion != null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_CodigoAccion;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			if (!Original_fecha.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_fecha.Value;
			}
			if (!Original_Cumplido.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_Cumplido.Value;
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
		public virtual int Fill(masterDBACDataSet.TInnerAccionDataTable dataTable)
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
		public virtual masterDBACDataSet.TInnerAccionDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TInnerAccionDataTable tInnerAccionDataTable = new masterDBACDataSet.TInnerAccionDataTable();
			this.Adapter.Fill(tInnerAccionDataTable);
			return tInnerAccionDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TInnerAccion"
			};
			dataTableMapping.ColumnMappings.Add("id", "id");
			dataTableMapping.ColumnMappings.Add("CodeInner", "CodeInner");
			dataTableMapping.ColumnMappings.Add("CodigoAccion", "CodigoAccion");
			dataTableMapping.ColumnMappings.Add("fecha", "fecha");
			dataTableMapping.ColumnMappings.Add("Cumplido", "Cumplido");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[TInnerAccion] WHERE (([id] = @Original_id) AND ((@IsNull_CodeInner = 1 AND [CodeInner] IS NULL) OR ([CodeInner] = @Original_CodeInner)) AND ((@IsNull_CodigoAccion = 1 AND [CodigoAccion] IS NULL) OR ([CodigoAccion] = @Original_CodigoAccion)) AND ((@IsNull_fecha = 1 AND [fecha] IS NULL) OR ([fecha] = @Original_fecha)) AND ((@IsNull_Cumplido = 1 AND [Cumplido] IS NULL) OR ([Cumplido] = @Original_Cumplido)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CodigoAccion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodigoAccion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CodigoAccion", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "CodigoAccion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_fecha", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fecha", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fecha", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_Cumplido", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Cumplido", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_Cumplido", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Cumplido", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[TInnerAccion] ([CodeInner], [CodigoAccion], [fecha], [Cumplido]) VALUES (@CodeInner, @CodigoAccion, @fecha, @Cumplido);\r\nSELECT id, CodeInner, CodigoAccion, fecha, Cumplido FROM TInnerAccion WHERE (id = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CodigoAccion", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "CodigoAccion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fecha", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Cumplido", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Cumplido", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[TInnerAccion] SET [CodeInner] = @CodeInner, [CodigoAccion] = @CodigoAccion, [fecha] = @fecha, [Cumplido] = @Cumplido WHERE (([id] = @Original_id) AND ((@IsNull_CodeInner = 1 AND [CodeInner] IS NULL) OR ([CodeInner] = @Original_CodeInner)) AND ((@IsNull_CodigoAccion = 1 AND [CodigoAccion] IS NULL) OR ([CodigoAccion] = @Original_CodigoAccion)) AND ((@IsNull_fecha = 1 AND [fecha] IS NULL) OR ([fecha] = @Original_fecha)) AND ((@IsNull_Cumplido = 1 AND [Cumplido] IS NULL) OR ([Cumplido] = @Original_Cumplido)));\r\nSELECT id, CodeInner, CodigoAccion, fecha, Cumplido FROM TInnerAccion WHERE (id = @id)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CodigoAccion", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "CodigoAccion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fecha", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Cumplido", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Cumplido", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Decimal, 0, ParameterDirection.Input, 18, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CodigoAccion", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodigoAccion", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CodigoAccion", SqlDbType.NChar, 0, ParameterDirection.Input, 0, 0, "CodigoAccion", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_fecha", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "fecha", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_fecha", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "fecha", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_Cumplido", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Cumplido", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_Cumplido", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "Cumplido", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 0, "id", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT id, CodeInner, CodigoAccion, fecha, Cumplido FROM dbo.TInnerAccion";
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
		public virtual int Insert(int? CodeInner, string CodigoAccion, DateTime? fecha, int? Cumplido)
		{
			int num;
			if (!CodeInner.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = CodeInner.Value;
			}
			if (CodigoAccion != null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = CodigoAccion;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			if (!fecha.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = fecha.Value;
			}
			if (!Cumplido.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = Cumplido.Value;
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
		public virtual int Update(masterDBACDataSet.TInnerAccionDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TInnerAccion");
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
		public virtual int Update(int? CodeInner, string CodigoAccion, DateTime? fecha, int? Cumplido, decimal Original_id, int? Original_CodeInner, string Original_CodigoAccion, DateTime? Original_fecha, int? Original_Cumplido, decimal id)
		{
			int num;
			if (!CodeInner.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = CodeInner.Value;
			}
			if (CodigoAccion != null)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = CodigoAccion;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			if (!fecha.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = fecha.Value;
			}
			if (!Cumplido.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = Cumplido.Value;
			}
			this.Adapter.UpdateCommand.Parameters[4].Value = Original_id;
			if (!Original_CodeInner.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = 1;
				this.Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = 0;
				this.Adapter.UpdateCommand.Parameters[6].Value = Original_CodeInner.Value;
			}
			if (Original_CodigoAccion != null)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 0;
				this.Adapter.UpdateCommand.Parameters[8].Value = Original_CodigoAccion;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 1;
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			if (!Original_fecha.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_fecha.Value;
			}
			if (!Original_Cumplido.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 1;
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 0;
				this.Adapter.UpdateCommand.Parameters[12].Value = Original_Cumplido.Value;
			}
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

		[DataObjectMethod(DataObjectMethodType.Update, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(int? CodeInner, string CodigoAccion, DateTime? fecha, int? Cumplido, decimal Original_id, int? Original_CodeInner, string Original_CodigoAccion, DateTime? Original_fecha, int? Original_Cumplido)
		{
			int num = this.Update(CodeInner, CodigoAccion, fecha, Cumplido, Original_id, Original_CodeInner, Original_CodigoAccion, Original_fecha, Original_Cumplido, Original_id);
			return num;
		}
	}
}