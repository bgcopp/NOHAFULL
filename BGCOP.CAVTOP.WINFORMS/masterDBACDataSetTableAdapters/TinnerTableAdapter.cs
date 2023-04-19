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
	public class TinnerTableAdapter : Component
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
		public TinnerTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_id, int? Original_CodeInner, string Original_NombreInner, bool? Original_esActivo, bool? Original_esinnerNet, int? Original_puertoCom)
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
			if (Original_NombreInner != null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_NombreInner;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			if (!Original_esActivo.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_esActivo.Value;
			}
			if (!Original_esinnerNet.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_esinnerNet.Value;
			}
			if (!Original_puertoCom.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_puertoCom.Value;
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
		public virtual int Fill(masterDBACDataSet.TinnerDataTable dataTable)
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
		public virtual masterDBACDataSet.TinnerDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TinnerDataTable tinnerDataTable = new masterDBACDataSet.TinnerDataTable();
			this.Adapter.Fill(tinnerDataTable);
			return tinnerDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "Tinner"
			};
			dataTableMapping.ColumnMappings.Add("id", "id");
			dataTableMapping.ColumnMappings.Add("CodeInner", "CodeInner");
			dataTableMapping.ColumnMappings.Add("NombreInner", "NombreInner");
			dataTableMapping.ColumnMappings.Add("esActivo", "esActivo");
			dataTableMapping.ColumnMappings.Add("esinnerNet", "esinnerNet");
			dataTableMapping.ColumnMappings.Add("puertoCom", "puertoCom");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[Tinner] WHERE (([id] = @Original_id) AND ((@IsNull_CodeInner = 1 AND [CodeInner] IS NULL) OR ([CodeInner] = @Original_CodeInner)) AND ((@IsNull_NombreInner = 1 AND [NombreInner] IS NULL) OR ([NombreInner] = @Original_NombreInner)) AND ((@IsNull_esActivo = 1 AND [esActivo] IS NULL) OR ([esActivo] = @Original_esActivo)) AND ((@IsNull_esinnerNet = 1 AND [esinnerNet] IS NULL) OR ([esinnerNet] = @Original_esinnerNet)) AND ((@IsNull_puertoCom = 1 AND [puertoCom] IS NULL) OR ([puertoCom] = @Original_puertoCom)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_NombreInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NombreInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_NombreInner", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_esActivo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esActivo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_esActivo", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esActivo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_esinnerNet", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esinnerNet", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_esinnerNet", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esinnerNet", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_puertoCom", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoCom", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_puertoCom", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoCom", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[Tinner] ([CodeInner], [NombreInner], [esActivo], [esinnerNet], [puertoCom]) VALUES (@CodeInner, @NombreInner, @esActivo, @esinnerNet, @puertoCom);\r\nSELECT id, CodeInner, NombreInner, esActivo, esinnerNet, puertoCom FROM Tinner WHERE (id = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@NombreInner", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@esActivo", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esActivo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@esinnerNet", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esinnerNet", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@puertoCom", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoCom", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[Tinner] SET [CodeInner] = @CodeInner, [NombreInner] = @NombreInner, [esActivo] = @esActivo, [esinnerNet] = @esinnerNet, [puertoCom] = @puertoCom WHERE (([id] = @Original_id) AND ((@IsNull_CodeInner = 1 AND [CodeInner] IS NULL) OR ([CodeInner] = @Original_CodeInner)) AND ((@IsNull_NombreInner = 1 AND [NombreInner] IS NULL) OR ([NombreInner] = @Original_NombreInner)) AND ((@IsNull_esActivo = 1 AND [esActivo] IS NULL) OR ([esActivo] = @Original_esActivo)) AND ((@IsNull_esinnerNet = 1 AND [esinnerNet] IS NULL) OR ([esinnerNet] = @Original_esinnerNet)) AND ((@IsNull_puertoCom = 1 AND [puertoCom] IS NULL) OR ([puertoCom] = @Original_puertoCom)));\r\nSELECT id, CodeInner, NombreInner, esActivo, esinnerNet, puertoCom FROM Tinner WHERE (id = @id)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NombreInner", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreInner", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@esActivo", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esActivo", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@esinnerNet", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esinnerNet", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@puertoCom", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoCom", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_id", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_CodeInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "CodeInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_NombreInner", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NombreInner", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_NombreInner", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NombreInner", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_esActivo", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esActivo", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_esActivo", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esActivo", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_esinnerNet", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "esinnerNet", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_esinnerNet", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "esinnerNet", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_puertoCom", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoCom", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_puertoCom", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoCom", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "id", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT id, CodeInner, NombreInner, esActivo, esinnerNet, puertoCom FROM dbo.Tinner";
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
		public virtual int Insert(int? CodeInner, string NombreInner, bool? esActivo, bool? esinnerNet, int? puertoCom)
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
			if (NombreInner != null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = NombreInner;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			if (!esActivo.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = esActivo.Value;
			}
			if (!esinnerNet.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = esinnerNet.Value;
			}
			if (!puertoCom.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = puertoCom.Value;
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
		public virtual int Update(masterDBACDataSet.TinnerDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "Tinner");
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
		public virtual int Update(int? CodeInner, string NombreInner, bool? esActivo, bool? esinnerNet, int? puertoCom, int Original_id, int? Original_CodeInner, string Original_NombreInner, bool? Original_esActivo, bool? Original_esinnerNet, int? Original_puertoCom, int id)
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
			if (NombreInner != null)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = NombreInner;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			if (!esActivo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = esActivo.Value;
			}
			if (!esinnerNet.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = esinnerNet.Value;
			}
			if (!puertoCom.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = puertoCom.Value;
			}
			this.Adapter.UpdateCommand.Parameters[5].Value = Original_id;
			if (!Original_CodeInner.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = 1;
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = 0;
				this.Adapter.UpdateCommand.Parameters[7].Value = Original_CodeInner.Value;
			}
			if (Original_NombreInner != null)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 0;
				this.Adapter.UpdateCommand.Parameters[9].Value = Original_NombreInner;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 1;
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			if (!Original_esActivo.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 1;
				this.Adapter.UpdateCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[10].Value = 0;
				this.Adapter.UpdateCommand.Parameters[11].Value = Original_esActivo.Value;
			}
			if (!Original_esinnerNet.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 1;
				this.Adapter.UpdateCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[12].Value = 0;
				this.Adapter.UpdateCommand.Parameters[13].Value = Original_esinnerNet.Value;
			}
			if (!Original_puertoCom.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 1;
				this.Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[14].Value = 0;
				this.Adapter.UpdateCommand.Parameters[15].Value = Original_puertoCom.Value;
			}
			this.Adapter.UpdateCommand.Parameters[16].Value = id;
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
		public virtual int Update(int? CodeInner, string NombreInner, bool? esActivo, bool? esinnerNet, int? puertoCom, int Original_id, int? Original_CodeInner, string Original_NombreInner, bool? Original_esActivo, bool? Original_esinnerNet, int? Original_puertoCom)
		{
			int num = this.Update(CodeInner, NombreInner, esActivo, esinnerNet, puertoCom, Original_id, Original_CodeInner, Original_NombreInner, Original_esActivo, Original_esinnerNet, Original_puertoCom, Original_id);
			return num;
		}
	}
}