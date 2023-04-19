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
	public class TPanelTableAdapter : Component
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
		public TPanelTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(int Original_idPanel, string Original_descrpcionPanel, string Original_direccionIP, string Original_puertoPanel)
		{
			int num;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_idPanel;
			if (Original_descrpcionPanel != null)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_descrpcionPanel;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			if (Original_direccionIP != null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_direccionIP;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			if (Original_puertoPanel != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_puertoPanel;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
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
		public virtual int Fill(masterDBACDataSet.TPanelDataTable dataTable)
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
		public virtual masterDBACDataSet.TPanelDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			masterDBACDataSet.TPanelDataTable tPanelDataTable = new masterDBACDataSet.TPanelDataTable();
			this.Adapter.Fill(tPanelDataTable);
			return tPanelDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "TPanel"
			};
			dataTableMapping.ColumnMappings.Add("idPanel", "idPanel");
			dataTableMapping.ColumnMappings.Add("descrpcionPanel", "descrpcionPanel");
			dataTableMapping.ColumnMappings.Add("direccionIP", "direccionIP");
			dataTableMapping.ColumnMappings.Add("puertoPanel", "puertoPanel");
			this._adapter.TableMappings.Add((object)dataTableMapping);
			this._adapter.DeleteCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM [dbo].[TPanel] WHERE (([idPanel] = @Original_idPanel) AND ((@IsNull_descrpcionPanel = 1 AND [descrpcionPanel] IS NULL) OR ([descrpcionPanel] = @Original_descrpcionPanel)) AND ((@IsNull_direccionIP = 1 AND [direccionIP] IS NULL) OR ([direccionIP] = @Original_direccionIP)) AND ((@IsNull_puertoPanel = 1 AND [puertoPanel] IS NULL) OR ([puertoPanel] = @Original_puertoPanel)))",
				CommandType = CommandType.Text
			};
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_descrpcionPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "descrpcionPanel", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_descrpcionPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "descrpcionPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_direccionIP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "direccionIP", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_direccionIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccionIP", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_puertoPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoPanel", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_puertoPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "puertoPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[TPanel] ([descrpcionPanel], [direccionIP], [puertoPanel]) VALUES (@descrpcionPanel, @direccionIP, @puertoPanel);\r\nSELECT idPanel, descrpcionPanel, direccionIP, puertoPanel FROM TPanel WHERE (idPanel = SCOPE_IDENTITY())",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@descrpcionPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "descrpcionPanel", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@direccionIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccionIP", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@puertoPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "puertoPanel", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE [dbo].[TPanel] SET [descrpcionPanel] = @descrpcionPanel, [direccionIP] = @direccionIP, [puertoPanel] = @puertoPanel WHERE (([idPanel] = @Original_idPanel) AND ((@IsNull_descrpcionPanel = 1 AND [descrpcionPanel] IS NULL) OR ([descrpcionPanel] = @Original_descrpcionPanel)) AND ((@IsNull_direccionIP = 1 AND [direccionIP] IS NULL) OR ([direccionIP] = @Original_direccionIP)) AND ((@IsNull_puertoPanel = 1 AND [puertoPanel] IS NULL) OR ([puertoPanel] = @Original_puertoPanel)));\r\nSELECT idPanel, descrpcionPanel, direccionIP, puertoPanel FROM TPanel WHERE (idPanel = @idPanel)",
				CommandType = CommandType.Text
			};
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@descrpcionPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "descrpcionPanel", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@direccionIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccionIP", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@puertoPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "puertoPanel", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_idPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_descrpcionPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "descrpcionPanel", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_descrpcionPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "descrpcionPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_direccionIP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "direccionIP", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_direccionIP", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "direccionIP", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_puertoPanel", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "puertoPanel", DataRowVersion.Original, true, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_puertoPanel", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "puertoPanel", DataRowVersion.Original, false, null, "", "", ""));
			this._adapter.UpdateCommand.Parameters.Add(new SqlParameter("@idPanel", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "idPanel", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT idPanel, descrpcionPanel, direccionIP, puertoPanel FROM dbo.TPanel";
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
		public virtual int Insert(string descrpcionPanel, string direccionIP, string puertoPanel)
		{
			int num;
			if (descrpcionPanel != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = descrpcionPanel;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (direccionIP != null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = direccionIP;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			if (puertoPanel != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = puertoPanel;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
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
		public virtual int Update(masterDBACDataSet.TPanelDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(masterDBACDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "TPanel");
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
		public virtual int Update(string descrpcionPanel, string direccionIP, string puertoPanel, int Original_idPanel, string Original_descrpcionPanel, string Original_direccionIP, string Original_puertoPanel, int idPanel)
		{
			int num;
			if (descrpcionPanel != null)
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = descrpcionPanel;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[0].Value = DBNull.Value;
			}
			if (direccionIP != null)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = direccionIP;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			if (puertoPanel != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = puertoPanel;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[3].Value = Original_idPanel;
			if (Original_descrpcionPanel != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = 0;
				this.Adapter.UpdateCommand.Parameters[5].Value = Original_descrpcionPanel;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = 1;
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			if (Original_direccionIP != null)
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = 0;
				this.Adapter.UpdateCommand.Parameters[7].Value = Original_direccionIP;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[6].Value = 1;
				this.Adapter.UpdateCommand.Parameters[7].Value = DBNull.Value;
			}
			if (Original_puertoPanel != null)
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 0;
				this.Adapter.UpdateCommand.Parameters[9].Value = Original_puertoPanel;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[8].Value = 1;
				this.Adapter.UpdateCommand.Parameters[9].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[10].Value = idPanel;
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
		public virtual int Update(string descrpcionPanel, string direccionIP, string puertoPanel, int Original_idPanel, string Original_descrpcionPanel, string Original_direccionIP, string Original_puertoPanel)
		{
			int num = this.Update(descrpcionPanel, direccionIP, puertoPanel, Original_idPanel, Original_descrpcionPanel, Original_direccionIP, Original_puertoPanel, Original_idPanel);
			return num;
		}
	}
}