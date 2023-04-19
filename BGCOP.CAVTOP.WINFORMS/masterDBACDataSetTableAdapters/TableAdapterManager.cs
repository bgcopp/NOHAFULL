using BGCOP.CAVTOP.WINFORMS;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters
{
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	[ToolboxItem(true)]
	public class TableAdapterManager : Component
	{
		private TableAdapterManager.UpdateOrderOption _updateOrder;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TCargoTableAdapter _tCargoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TDiasHorarioTableAdapter _tDiasHorarioTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TDivisionEmpresaTableAdapter _tDivisionEmpresaTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpleadoTableAdapter _tEmpleadoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpleadoVehiculoTableAdapter _tEmpleadoVehiculoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpresaTableAdapter _tEmpresaTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpresaVisitanteTableAdapter _tEmpresaVisitanteTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEstadoTableAdapter _tEstadoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TFestivosTableAdapter _tFestivosTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.THorarioTableAdapter _tHorarioTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TipoVehiculoTableAdapter _tipoVehiculoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TMarcaVehiculoTableAdapter _tMarcaVehiculoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TModeloVehiculoTableAdapter _tModeloVehiculoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TPanelTableAdapter _tPanelTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TParqueoTableAdapter _tParqueoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TRegistroEmpleadoTableAdapter _tRegistroEmpleadoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TRegistroVehiculoTableAdapter _tRegistroVehiculoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTarjetaTableAdapter _tTarjetaTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTipoIdentificacionTableAdapter _tTipoIdentificacionTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTipoRegistroTableAdapter _tTipoRegistroTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTipoUsuarioTableAdapter _tTipoUsuarioTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TUsuarioTableAdapter _tUsuarioTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVehiculoTableAdapter _tVehiculoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TvehiculoParqueoTableAdapter _tvehiculoParqueoTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitanteTableAdapter _tVisitanteTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitanteVisitaProgramadaTableAdapter _tVisitanteVisitaProgramadaTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitaProgramadaTableAdapter _tVisitaProgramadaTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TinnerTableAdapter _tinnerTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TInnerAccionTableAdapter _tInnerAccionTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TMarcacionTableAdapter _tMarcacionTableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TRegistroVehiculo1TableAdapter _tRegistroVehiculo1TableAdapter;

		private BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitanteVisitaProgramadaLogTableAdapter _tVisitanteVisitaProgramadaLogTableAdapter;

		private bool _backupDataSetBeforeUpdate;

		private IDbConnection _connection;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return this._backupDataSetBeforeUpdate;
			}
			set
			{
				this._backupDataSetBeforeUpdate = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public IDbConnection Connection
		{
			get
			{
				IDbConnection connection;
				if (this._connection != null)
				{
					connection = this._connection;
				}
				else if (!(this._tCargoTableAdapter == null ? true : this._tCargoTableAdapter.Connection == null))
				{
					connection = this._tCargoTableAdapter.Connection;
				}
				else if (!(this._tDiasHorarioTableAdapter == null ? true : this._tDiasHorarioTableAdapter.Connection == null))
				{
					connection = this._tDiasHorarioTableAdapter.Connection;
				}
				else if (!(this._tDivisionEmpresaTableAdapter == null ? true : this._tDivisionEmpresaTableAdapter.Connection == null))
				{
					connection = this._tDivisionEmpresaTableAdapter.Connection;
				}
				else if (!(this._tEmpleadoTableAdapter == null ? true : this._tEmpleadoTableAdapter.Connection == null))
				{
					connection = this._tEmpleadoTableAdapter.Connection;
				}
				else if (!(this._tEmpleadoVehiculoTableAdapter == null ? true : this._tEmpleadoVehiculoTableAdapter.Connection == null))
				{
					connection = this._tEmpleadoVehiculoTableAdapter.Connection;
				}
				else if (!(this._tEmpresaTableAdapter == null ? true : this._tEmpresaTableAdapter.Connection == null))
				{
					connection = this._tEmpresaTableAdapter.Connection;
				}
				else if (!(this._tEmpresaVisitanteTableAdapter == null ? true : this._tEmpresaVisitanteTableAdapter.Connection == null))
				{
					connection = this._tEmpresaVisitanteTableAdapter.Connection;
				}
				else if (!(this._tEstadoTableAdapter == null ? true : this._tEstadoTableAdapter.Connection == null))
				{
					connection = this._tEstadoTableAdapter.Connection;
				}
				else if (!(this._tFestivosTableAdapter == null ? true : this._tFestivosTableAdapter.Connection == null))
				{
					connection = this._tFestivosTableAdapter.Connection;
				}
				else if (!(this._tHorarioTableAdapter == null ? true : this._tHorarioTableAdapter.Connection == null))
				{
					connection = this._tHorarioTableAdapter.Connection;
				}
				else if (!(this._tipoVehiculoTableAdapter == null ? true : this._tipoVehiculoTableAdapter.Connection == null))
				{
					connection = this._tipoVehiculoTableAdapter.Connection;
				}
				else if (!(this._tMarcaVehiculoTableAdapter == null ? true : this._tMarcaVehiculoTableAdapter.Connection == null))
				{
					connection = this._tMarcaVehiculoTableAdapter.Connection;
				}
				else if (!(this._tModeloVehiculoTableAdapter == null ? true : this._tModeloVehiculoTableAdapter.Connection == null))
				{
					connection = this._tModeloVehiculoTableAdapter.Connection;
				}
				else if (!(this._tPanelTableAdapter == null ? true : this._tPanelTableAdapter.Connection == null))
				{
					connection = this._tPanelTableAdapter.Connection;
				}
				else if (!(this._tParqueoTableAdapter == null ? true : this._tParqueoTableAdapter.Connection == null))
				{
					connection = this._tParqueoTableAdapter.Connection;
				}
				else if (!(this._tRegistroEmpleadoTableAdapter == null ? true : this._tRegistroEmpleadoTableAdapter.Connection == null))
				{
					connection = this._tRegistroEmpleadoTableAdapter.Connection;
				}
				else if (!(this._tRegistroVehiculoTableAdapter == null ? true : this._tRegistroVehiculoTableAdapter.Connection == null))
				{
					connection = this._tRegistroVehiculoTableAdapter.Connection;
				}
				else if (!(this._tTarjetaTableAdapter == null ? true : this._tTarjetaTableAdapter.Connection == null))
				{
					connection = this._tTarjetaTableAdapter.Connection;
				}
				else if (!(this._tTipoIdentificacionTableAdapter == null ? true : this._tTipoIdentificacionTableAdapter.Connection == null))
				{
					connection = this._tTipoIdentificacionTableAdapter.Connection;
				}
				else if (!(this._tTipoRegistroTableAdapter == null ? true : this._tTipoRegistroTableAdapter.Connection == null))
				{
					connection = this._tTipoRegistroTableAdapter.Connection;
				}
				else if (!(this._tTipoUsuarioTableAdapter == null ? true : this._tTipoUsuarioTableAdapter.Connection == null))
				{
					connection = this._tTipoUsuarioTableAdapter.Connection;
				}
				else if (!(this._tUsuarioTableAdapter == null ? true : this._tUsuarioTableAdapter.Connection == null))
				{
					connection = this._tUsuarioTableAdapter.Connection;
				}
				else if (!(this._tVehiculoTableAdapter == null ? true : this._tVehiculoTableAdapter.Connection == null))
				{
					connection = this._tVehiculoTableAdapter.Connection;
				}
				else if (!(this._tvehiculoParqueoTableAdapter == null ? true : this._tvehiculoParqueoTableAdapter.Connection == null))
				{
					connection = this._tvehiculoParqueoTableAdapter.Connection;
				}
				else if (!(this._tVisitanteTableAdapter == null ? true : this._tVisitanteTableAdapter.Connection == null))
				{
					connection = this._tVisitanteTableAdapter.Connection;
				}
				else if (!(this._tVisitanteVisitaProgramadaTableAdapter == null ? true : this._tVisitanteVisitaProgramadaTableAdapter.Connection == null))
				{
					connection = this._tVisitanteVisitaProgramadaTableAdapter.Connection;
				}
				else if (!(this._tVisitaProgramadaTableAdapter == null ? true : this._tVisitaProgramadaTableAdapter.Connection == null))
				{
					connection = this._tVisitaProgramadaTableAdapter.Connection;
				}
				else if (!(this._tinnerTableAdapter == null ? true : this._tinnerTableAdapter.Connection == null))
				{
					connection = this._tinnerTableAdapter.Connection;
				}
				else if (!(this._tInnerAccionTableAdapter == null ? true : this._tInnerAccionTableAdapter.Connection == null))
				{
					connection = this._tInnerAccionTableAdapter.Connection;
				}
				else if (!(this._tMarcacionTableAdapter == null ? true : this._tMarcacionTableAdapter.Connection == null))
				{
					connection = this._tMarcacionTableAdapter.Connection;
				}
				else if (!(this._tRegistroVehiculo1TableAdapter == null ? true : this._tRegistroVehiculo1TableAdapter.Connection == null))
				{
					connection = this._tRegistroVehiculo1TableAdapter.Connection;
				}
				else if ((this._tVisitanteVisitaProgramadaLogTableAdapter == null ? true : this._tVisitanteVisitaProgramadaLogTableAdapter.Connection == null))
				{
					connection = null;
				}
				else
				{
					connection = this._tVisitanteVisitaProgramadaLogTableAdapter.Connection;
				}
				return connection;
			}
			set
			{
				this._connection = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TableAdapterInstanceCount
		{
			get
			{
				int num = 0;
				if (this._tCargoTableAdapter != null)
				{
					num++;
				}
				if (this._tDiasHorarioTableAdapter != null)
				{
					num++;
				}
				if (this._tDivisionEmpresaTableAdapter != null)
				{
					num++;
				}
				if (this._tEmpleadoTableAdapter != null)
				{
					num++;
				}
				if (this._tEmpleadoVehiculoTableAdapter != null)
				{
					num++;
				}
				if (this._tEmpresaTableAdapter != null)
				{
					num++;
				}
				if (this._tEmpresaVisitanteTableAdapter != null)
				{
					num++;
				}
				if (this._tEstadoTableAdapter != null)
				{
					num++;
				}
				if (this._tFestivosTableAdapter != null)
				{
					num++;
				}
				if (this._tHorarioTableAdapter != null)
				{
					num++;
				}
				if (this._tipoVehiculoTableAdapter != null)
				{
					num++;
				}
				if (this._tMarcaVehiculoTableAdapter != null)
				{
					num++;
				}
				if (this._tModeloVehiculoTableAdapter != null)
				{
					num++;
				}
				if (this._tPanelTableAdapter != null)
				{
					num++;
				}
				if (this._tParqueoTableAdapter != null)
				{
					num++;
				}
				if (this._tRegistroEmpleadoTableAdapter != null)
				{
					num++;
				}
				if (this._tRegistroVehiculoTableAdapter != null)
				{
					num++;
				}
				if (this._tTarjetaTableAdapter != null)
				{
					num++;
				}
				if (this._tTipoIdentificacionTableAdapter != null)
				{
					num++;
				}
				if (this._tTipoRegistroTableAdapter != null)
				{
					num++;
				}
				if (this._tTipoUsuarioTableAdapter != null)
				{
					num++;
				}
				if (this._tUsuarioTableAdapter != null)
				{
					num++;
				}
				if (this._tVehiculoTableAdapter != null)
				{
					num++;
				}
				if (this._tvehiculoParqueoTableAdapter != null)
				{
					num++;
				}
				if (this._tVisitanteTableAdapter != null)
				{
					num++;
				}
				if (this._tVisitanteVisitaProgramadaTableAdapter != null)
				{
					num++;
				}
				if (this._tVisitaProgramadaTableAdapter != null)
				{
					num++;
				}
				if (this._tinnerTableAdapter != null)
				{
					num++;
				}
				if (this._tInnerAccionTableAdapter != null)
				{
					num++;
				}
				if (this._tMarcacionTableAdapter != null)
				{
					num++;
				}
				if (this._tRegistroVehiculo1TableAdapter != null)
				{
					num++;
				}
				if (this._tVisitanteVisitaProgramadaLogTableAdapter != null)
				{
					num++;
				}
				return num;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TCargoTableAdapter TCargoTableAdapter
		{
			get
			{
				return this._tCargoTableAdapter;
			}
			set
			{
				this._tCargoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TDiasHorarioTableAdapter TDiasHorarioTableAdapter
		{
			get
			{
				return this._tDiasHorarioTableAdapter;
			}
			set
			{
				this._tDiasHorarioTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TDivisionEmpresaTableAdapter TDivisionEmpresaTableAdapter
		{
			get
			{
				return this._tDivisionEmpresaTableAdapter;
			}
			set
			{
				this._tDivisionEmpresaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpleadoTableAdapter TEmpleadoTableAdapter
		{
			get
			{
				return this._tEmpleadoTableAdapter;
			}
			set
			{
				this._tEmpleadoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpleadoVehiculoTableAdapter TEmpleadoVehiculoTableAdapter
		{
			get
			{
				return this._tEmpleadoVehiculoTableAdapter;
			}
			set
			{
				this._tEmpleadoVehiculoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpresaTableAdapter TEmpresaTableAdapter
		{
			get
			{
				return this._tEmpresaTableAdapter;
			}
			set
			{
				this._tEmpresaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEmpresaVisitanteTableAdapter TEmpresaVisitanteTableAdapter
		{
			get
			{
				return this._tEmpresaVisitanteTableAdapter;
			}
			set
			{
				this._tEmpresaVisitanteTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TEstadoTableAdapter TEstadoTableAdapter
		{
			get
			{
				return this._tEstadoTableAdapter;
			}
			set
			{
				this._tEstadoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TFestivosTableAdapter TFestivosTableAdapter
		{
			get
			{
				return this._tFestivosTableAdapter;
			}
			set
			{
				this._tFestivosTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.THorarioTableAdapter THorarioTableAdapter
		{
			get
			{
				return this._tHorarioTableAdapter;
			}
			set
			{
				this._tHorarioTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TInnerAccionTableAdapter TInnerAccionTableAdapter
		{
			get
			{
				return this._tInnerAccionTableAdapter;
			}
			set
			{
				this._tInnerAccionTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TinnerTableAdapter TinnerTableAdapter
		{
			get
			{
				return this._tinnerTableAdapter;
			}
			set
			{
				this._tinnerTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TipoVehiculoTableAdapter TipoVehiculoTableAdapter
		{
			get
			{
				return this._tipoVehiculoTableAdapter;
			}
			set
			{
				this._tipoVehiculoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TMarcacionTableAdapter TMarcacionTableAdapter
		{
			get
			{
				return this._tMarcacionTableAdapter;
			}
			set
			{
				this._tMarcacionTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TMarcaVehiculoTableAdapter TMarcaVehiculoTableAdapter
		{
			get
			{
				return this._tMarcaVehiculoTableAdapter;
			}
			set
			{
				this._tMarcaVehiculoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TModeloVehiculoTableAdapter TModeloVehiculoTableAdapter
		{
			get
			{
				return this._tModeloVehiculoTableAdapter;
			}
			set
			{
				this._tModeloVehiculoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TPanelTableAdapter TPanelTableAdapter
		{
			get
			{
				return this._tPanelTableAdapter;
			}
			set
			{
				this._tPanelTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TParqueoTableAdapter TParqueoTableAdapter
		{
			get
			{
				return this._tParqueoTableAdapter;
			}
			set
			{
				this._tParqueoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TRegistroEmpleadoTableAdapter TRegistroEmpleadoTableAdapter
		{
			get
			{
				return this._tRegistroEmpleadoTableAdapter;
			}
			set
			{
				this._tRegistroEmpleadoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TRegistroVehiculo1TableAdapter TRegistroVehiculo1TableAdapter
		{
			get
			{
				return this._tRegistroVehiculo1TableAdapter;
			}
			set
			{
				this._tRegistroVehiculo1TableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TRegistroVehiculoTableAdapter TRegistroVehiculoTableAdapter
		{
			get
			{
				return this._tRegistroVehiculoTableAdapter;
			}
			set
			{
				this._tRegistroVehiculoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTarjetaTableAdapter TTarjetaTableAdapter
		{
			get
			{
				return this._tTarjetaTableAdapter;
			}
			set
			{
				this._tTarjetaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTipoIdentificacionTableAdapter TTipoIdentificacionTableAdapter
		{
			get
			{
				return this._tTipoIdentificacionTableAdapter;
			}
			set
			{
				this._tTipoIdentificacionTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTipoRegistroTableAdapter TTipoRegistroTableAdapter
		{
			get
			{
				return this._tTipoRegistroTableAdapter;
			}
			set
			{
				this._tTipoRegistroTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TTipoUsuarioTableAdapter TTipoUsuarioTableAdapter
		{
			get
			{
				return this._tTipoUsuarioTableAdapter;
			}
			set
			{
				this._tTipoUsuarioTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TUsuarioTableAdapter TUsuarioTableAdapter
		{
			get
			{
				return this._tUsuarioTableAdapter;
			}
			set
			{
				this._tUsuarioTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TvehiculoParqueoTableAdapter TvehiculoParqueoTableAdapter
		{
			get
			{
				return this._tvehiculoParqueoTableAdapter;
			}
			set
			{
				this._tvehiculoParqueoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVehiculoTableAdapter TVehiculoTableAdapter
		{
			get
			{
				return this._tVehiculoTableAdapter;
			}
			set
			{
				this._tVehiculoTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitanteTableAdapter TVisitanteTableAdapter
		{
			get
			{
				return this._tVisitanteTableAdapter;
			}
			set
			{
				this._tVisitanteTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitanteVisitaProgramadaLogTableAdapter TVisitanteVisitaProgramadaLogTableAdapter
		{
			get
			{
				return this._tVisitanteVisitaProgramadaLogTableAdapter;
			}
			set
			{
				this._tVisitanteVisitaProgramadaLogTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitanteVisitaProgramadaTableAdapter TVisitanteVisitaProgramadaTableAdapter
		{
			get
			{
				return this._tVisitanteVisitaProgramadaTableAdapter;
			}
			set
			{
				this._tVisitanteVisitaProgramadaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BGCOP.CAVTOP.WINFORMS.masterDBACDataSetTableAdapters.TVisitaProgramadaTableAdapter TVisitaProgramadaTableAdapter
		{
			get
			{
				return this._tVisitaProgramadaTableAdapter;
			}
			set
			{
				this._tVisitaProgramadaTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TableAdapterManager.UpdateOrderOption UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
			}
		}

		public TableAdapterManager()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			DataRow[] array;
			if (!(updatedRows == null ? false : (int)updatedRows.Length >= 1))
			{
				array = updatedRows;
			}
			else if ((allAddedRows == null ? false : allAddedRows.Count >= 1))
			{
				List<DataRow> dataRows = new List<DataRow>();
				for (int i = 0; i < (int)updatedRows.Length; i++)
				{
					DataRow dataRow = updatedRows[i];
					if (!allAddedRows.Contains(dataRow))
					{
						dataRows.Add(dataRow);
					}
				}
				array = dataRows.ToArray();
			}
			else
			{
				array = updatedRows;
			}
			return array;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			bool flag;
			if (this._connection != null)
			{
				flag = true;
			}
			else if ((this.Connection == null ? false : inputConnection != null))
			{
				flag = (!string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal) ? false : true);
			}
			else
			{
				flag = true;
			}
			return flag;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int UpdateAll(masterDBACDataSet dataSet)
		{
			DataRow[] dataRowArray;
			int i;
			DataRow dataRow;
			int num;
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (dataSet.HasChanges())
			{
				if ((this._tCargoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tCargoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tDiasHorarioTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tDiasHorarioTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tDivisionEmpresaTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tDivisionEmpresaTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tEmpleadoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tEmpleadoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tEmpleadoVehiculoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tEmpleadoVehiculoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tEmpresaTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tEmpresaTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tEmpresaVisitanteTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tEmpresaVisitanteTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tEstadoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tEstadoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tFestivosTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tFestivosTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tHorarioTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tHorarioTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tipoVehiculoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tipoVehiculoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tMarcaVehiculoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tMarcaVehiculoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tModeloVehiculoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tModeloVehiculoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tPanelTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tPanelTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tParqueoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tParqueoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tRegistroEmpleadoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tRegistroEmpleadoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tRegistroVehiculoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tRegistroVehiculoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tTarjetaTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tTarjetaTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tTipoIdentificacionTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tTipoIdentificacionTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tTipoRegistroTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tTipoRegistroTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tTipoUsuarioTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tTipoUsuarioTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tUsuarioTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tUsuarioTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tVehiculoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tVehiculoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tvehiculoParqueoTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tvehiculoParqueoTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tVisitanteTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tVisitanteTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tVisitanteVisitaProgramadaTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tVisitanteVisitaProgramadaTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tVisitaProgramadaTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tVisitaProgramadaTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tinnerTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tinnerTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tInnerAccionTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tInnerAccionTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tMarcacionTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tMarcacionTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tRegistroVehiculo1TableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tRegistroVehiculo1TableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._tVisitanteVisitaProgramadaLogTableAdapter == null ? false : !this.MatchTableAdapterConnection(this._tVisitanteVisitaProgramadaLogTableAdapter.Connection)))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				IDbConnection connection = this.Connection;
				if (connection == null)
				{
					throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
				}
				bool flag = false;
				if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
				{
					connection.Close();
				}
				if (connection.State == ConnectionState.Closed)
				{
					connection.Open();
					flag = true;
				}
				IDbTransaction dbTransaction = connection.BeginTransaction();
				if (dbTransaction == null)
				{
					throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
				}
				List<DataRow> dataRows = new List<DataRow>();
				List<DataRow> dataRows1 = new List<DataRow>();
				List<DataAdapter> dataAdapters = new List<DataAdapter>();
				Dictionary<object, IDbConnection> objs = new Dictionary<object, IDbConnection>();
				int num1 = 0;
				DataSet dataSet1 = null;
				if (this.BackupDataSetBeforeUpdate)
				{
					dataSet1 = new DataSet();
					dataSet1.Merge(dataSet);
				}
				try
				{
					try
					{
						if (this._tCargoTableAdapter != null)
						{
							objs.Add(this._tCargoTableAdapter, this._tCargoTableAdapter.Connection);
							this._tCargoTableAdapter.Connection = (SqlConnection)connection;
							this._tCargoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tCargoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tCargoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tCargoTableAdapter.Adapter);
							}
						}
						if (this._tDiasHorarioTableAdapter != null)
						{
							objs.Add(this._tDiasHorarioTableAdapter, this._tDiasHorarioTableAdapter.Connection);
							this._tDiasHorarioTableAdapter.Connection = (SqlConnection)connection;
							this._tDiasHorarioTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tDiasHorarioTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tDiasHorarioTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tDiasHorarioTableAdapter.Adapter);
							}
						}
						if (this._tDivisionEmpresaTableAdapter != null)
						{
							objs.Add(this._tDivisionEmpresaTableAdapter, this._tDivisionEmpresaTableAdapter.Connection);
							this._tDivisionEmpresaTableAdapter.Connection = (SqlConnection)connection;
							this._tDivisionEmpresaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tDivisionEmpresaTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tDivisionEmpresaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tDivisionEmpresaTableAdapter.Adapter);
							}
						}
						if (this._tEmpleadoTableAdapter != null)
						{
							objs.Add(this._tEmpleadoTableAdapter, this._tEmpleadoTableAdapter.Connection);
							this._tEmpleadoTableAdapter.Connection = (SqlConnection)connection;
							this._tEmpleadoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tEmpleadoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tEmpleadoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tEmpleadoTableAdapter.Adapter);
							}
						}
						if (this._tEmpleadoVehiculoTableAdapter != null)
						{
							objs.Add(this._tEmpleadoVehiculoTableAdapter, this._tEmpleadoVehiculoTableAdapter.Connection);
							this._tEmpleadoVehiculoTableAdapter.Connection = (SqlConnection)connection;
							this._tEmpleadoVehiculoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tEmpleadoVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tEmpleadoVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tEmpleadoVehiculoTableAdapter.Adapter);
							}
						}
						if (this._tEmpresaTableAdapter != null)
						{
							objs.Add(this._tEmpresaTableAdapter, this._tEmpresaTableAdapter.Connection);
							this._tEmpresaTableAdapter.Connection = (SqlConnection)connection;
							this._tEmpresaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tEmpresaTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tEmpresaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tEmpresaTableAdapter.Adapter);
							}
						}
						if (this._tEmpresaVisitanteTableAdapter != null)
						{
							objs.Add(this._tEmpresaVisitanteTableAdapter, this._tEmpresaVisitanteTableAdapter.Connection);
							this._tEmpresaVisitanteTableAdapter.Connection = (SqlConnection)connection;
							this._tEmpresaVisitanteTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tEmpresaVisitanteTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tEmpresaVisitanteTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tEmpresaVisitanteTableAdapter.Adapter);
							}
						}
						if (this._tEstadoTableAdapter != null)
						{
							objs.Add(this._tEstadoTableAdapter, this._tEstadoTableAdapter.Connection);
							this._tEstadoTableAdapter.Connection = (SqlConnection)connection;
							this._tEstadoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tEstadoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tEstadoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tEstadoTableAdapter.Adapter);
							}
						}
						if (this._tFestivosTableAdapter != null)
						{
							objs.Add(this._tFestivosTableAdapter, this._tFestivosTableAdapter.Connection);
							this._tFestivosTableAdapter.Connection = (SqlConnection)connection;
							this._tFestivosTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tFestivosTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tFestivosTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tFestivosTableAdapter.Adapter);
							}
						}
						if (this._tHorarioTableAdapter != null)
						{
							objs.Add(this._tHorarioTableAdapter, this._tHorarioTableAdapter.Connection);
							this._tHorarioTableAdapter.Connection = (SqlConnection)connection;
							this._tHorarioTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tHorarioTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tHorarioTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tHorarioTableAdapter.Adapter);
							}
						}
						if (this._tipoVehiculoTableAdapter != null)
						{
							objs.Add(this._tipoVehiculoTableAdapter, this._tipoVehiculoTableAdapter.Connection);
							this._tipoVehiculoTableAdapter.Connection = (SqlConnection)connection;
							this._tipoVehiculoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tipoVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tipoVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tipoVehiculoTableAdapter.Adapter);
							}
						}
						if (this._tMarcaVehiculoTableAdapter != null)
						{
							objs.Add(this._tMarcaVehiculoTableAdapter, this._tMarcaVehiculoTableAdapter.Connection);
							this._tMarcaVehiculoTableAdapter.Connection = (SqlConnection)connection;
							this._tMarcaVehiculoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tMarcaVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tMarcaVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tMarcaVehiculoTableAdapter.Adapter);
							}
						}
						if (this._tModeloVehiculoTableAdapter != null)
						{
							objs.Add(this._tModeloVehiculoTableAdapter, this._tModeloVehiculoTableAdapter.Connection);
							this._tModeloVehiculoTableAdapter.Connection = (SqlConnection)connection;
							this._tModeloVehiculoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tModeloVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tModeloVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tModeloVehiculoTableAdapter.Adapter);
							}
						}
						if (this._tPanelTableAdapter != null)
						{
							objs.Add(this._tPanelTableAdapter, this._tPanelTableAdapter.Connection);
							this._tPanelTableAdapter.Connection = (SqlConnection)connection;
							this._tPanelTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tPanelTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tPanelTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tPanelTableAdapter.Adapter);
							}
						}
						if (this._tParqueoTableAdapter != null)
						{
							objs.Add(this._tParqueoTableAdapter, this._tParqueoTableAdapter.Connection);
							this._tParqueoTableAdapter.Connection = (SqlConnection)connection;
							this._tParqueoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tParqueoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tParqueoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tParqueoTableAdapter.Adapter);
							}
						}
						if (this._tRegistroEmpleadoTableAdapter != null)
						{
							objs.Add(this._tRegistroEmpleadoTableAdapter, this._tRegistroEmpleadoTableAdapter.Connection);
							this._tRegistroEmpleadoTableAdapter.Connection = (SqlConnection)connection;
							this._tRegistroEmpleadoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tRegistroEmpleadoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tRegistroEmpleadoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tRegistroEmpleadoTableAdapter.Adapter);
							}
						}
						if (this._tRegistroVehiculoTableAdapter != null)
						{
							objs.Add(this._tRegistroVehiculoTableAdapter, this._tRegistroVehiculoTableAdapter.Connection);
							this._tRegistroVehiculoTableAdapter.Connection = (SqlConnection)connection;
							this._tRegistroVehiculoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tRegistroVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tRegistroVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tRegistroVehiculoTableAdapter.Adapter);
							}
						}
						if (this._tTarjetaTableAdapter != null)
						{
							objs.Add(this._tTarjetaTableAdapter, this._tTarjetaTableAdapter.Connection);
							this._tTarjetaTableAdapter.Connection = (SqlConnection)connection;
							this._tTarjetaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tTarjetaTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tTarjetaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tTarjetaTableAdapter.Adapter);
							}
						}
						if (this._tTipoIdentificacionTableAdapter != null)
						{
							objs.Add(this._tTipoIdentificacionTableAdapter, this._tTipoIdentificacionTableAdapter.Connection);
							this._tTipoIdentificacionTableAdapter.Connection = (SqlConnection)connection;
							this._tTipoIdentificacionTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tTipoIdentificacionTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tTipoIdentificacionTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tTipoIdentificacionTableAdapter.Adapter);
							}
						}
						if (this._tTipoRegistroTableAdapter != null)
						{
							objs.Add(this._tTipoRegistroTableAdapter, this._tTipoRegistroTableAdapter.Connection);
							this._tTipoRegistroTableAdapter.Connection = (SqlConnection)connection;
							this._tTipoRegistroTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tTipoRegistroTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tTipoRegistroTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tTipoRegistroTableAdapter.Adapter);
							}
						}
						if (this._tTipoUsuarioTableAdapter != null)
						{
							objs.Add(this._tTipoUsuarioTableAdapter, this._tTipoUsuarioTableAdapter.Connection);
							this._tTipoUsuarioTableAdapter.Connection = (SqlConnection)connection;
							this._tTipoUsuarioTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tTipoUsuarioTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tTipoUsuarioTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tTipoUsuarioTableAdapter.Adapter);
							}
						}
						if (this._tUsuarioTableAdapter != null)
						{
							objs.Add(this._tUsuarioTableAdapter, this._tUsuarioTableAdapter.Connection);
							this._tUsuarioTableAdapter.Connection = (SqlConnection)connection;
							this._tUsuarioTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tUsuarioTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tUsuarioTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tUsuarioTableAdapter.Adapter);
							}
						}
						if (this._tVehiculoTableAdapter != null)
						{
							objs.Add(this._tVehiculoTableAdapter, this._tVehiculoTableAdapter.Connection);
							this._tVehiculoTableAdapter.Connection = (SqlConnection)connection;
							this._tVehiculoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tVehiculoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tVehiculoTableAdapter.Adapter);
							}
						}
						if (this._tvehiculoParqueoTableAdapter != null)
						{
							objs.Add(this._tvehiculoParqueoTableAdapter, this._tvehiculoParqueoTableAdapter.Connection);
							this._tvehiculoParqueoTableAdapter.Connection = (SqlConnection)connection;
							this._tvehiculoParqueoTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tvehiculoParqueoTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tvehiculoParqueoTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tvehiculoParqueoTableAdapter.Adapter);
							}
						}
						if (this._tVisitanteTableAdapter != null)
						{
							objs.Add(this._tVisitanteTableAdapter, this._tVisitanteTableAdapter.Connection);
							this._tVisitanteTableAdapter.Connection = (SqlConnection)connection;
							this._tVisitanteTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tVisitanteTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tVisitanteTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tVisitanteTableAdapter.Adapter);
							}
						}
						if (this._tVisitanteVisitaProgramadaTableAdapter != null)
						{
							objs.Add(this._tVisitanteVisitaProgramadaTableAdapter, this._tVisitanteVisitaProgramadaTableAdapter.Connection);
							this._tVisitanteVisitaProgramadaTableAdapter.Connection = (SqlConnection)connection;
							this._tVisitanteVisitaProgramadaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tVisitanteVisitaProgramadaTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tVisitanteVisitaProgramadaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tVisitanteVisitaProgramadaTableAdapter.Adapter);
							}
						}
						if (this._tVisitaProgramadaTableAdapter != null)
						{
							objs.Add(this._tVisitaProgramadaTableAdapter, this._tVisitaProgramadaTableAdapter.Connection);
							this._tVisitaProgramadaTableAdapter.Connection = (SqlConnection)connection;
							this._tVisitaProgramadaTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tVisitaProgramadaTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tVisitaProgramadaTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tVisitaProgramadaTableAdapter.Adapter);
							}
						}
						if (this._tinnerTableAdapter != null)
						{
							objs.Add(this._tinnerTableAdapter, this._tinnerTableAdapter.Connection);
							this._tinnerTableAdapter.Connection = (SqlConnection)connection;
							this._tinnerTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tinnerTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tinnerTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tinnerTableAdapter.Adapter);
							}
						}
						if (this._tInnerAccionTableAdapter != null)
						{
							objs.Add(this._tInnerAccionTableAdapter, this._tInnerAccionTableAdapter.Connection);
							this._tInnerAccionTableAdapter.Connection = (SqlConnection)connection;
							this._tInnerAccionTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tInnerAccionTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tInnerAccionTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tInnerAccionTableAdapter.Adapter);
							}
						}
						if (this._tMarcacionTableAdapter != null)
						{
							objs.Add(this._tMarcacionTableAdapter, this._tMarcacionTableAdapter.Connection);
							this._tMarcacionTableAdapter.Connection = (SqlConnection)connection;
							this._tMarcacionTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tMarcacionTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tMarcacionTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tMarcacionTableAdapter.Adapter);
							}
						}
						if (this._tRegistroVehiculo1TableAdapter != null)
						{
							objs.Add(this._tRegistroVehiculo1TableAdapter, this._tRegistroVehiculo1TableAdapter.Connection);
							this._tRegistroVehiculo1TableAdapter.Connection = (SqlConnection)connection;
							this._tRegistroVehiculo1TableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tRegistroVehiculo1TableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tRegistroVehiculo1TableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tRegistroVehiculo1TableAdapter.Adapter);
							}
						}
						if (this._tVisitanteVisitaProgramadaLogTableAdapter != null)
						{
							objs.Add(this._tVisitanteVisitaProgramadaLogTableAdapter, this._tVisitanteVisitaProgramadaLogTableAdapter.Connection);
							this._tVisitanteVisitaProgramadaLogTableAdapter.Connection = (SqlConnection)connection;
							this._tVisitanteVisitaProgramadaLogTableAdapter.Transaction = (SqlTransaction)dbTransaction;
							if (this._tVisitanteVisitaProgramadaLogTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._tVisitanteVisitaProgramadaLogTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								dataAdapters.Add(this._tVisitanteVisitaProgramadaLogTableAdapter.Adapter);
							}
						}
						if (this.UpdateOrder != TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
						{
							num1 += this.UpdateInsertedRows(dataSet, dataRows1);
							num1 += this.UpdateUpdatedRows(dataSet, dataRows, dataRows1);
						}
						else
						{
							num1 += this.UpdateUpdatedRows(dataSet, dataRows, dataRows1);
							num1 += this.UpdateInsertedRows(dataSet, dataRows1);
						}
						num1 += this.UpdateDeletedRows(dataSet, dataRows);
						dbTransaction.Commit();
						if (0 < dataRows1.Count)
						{
							dataRowArray = new DataRow[dataRows1.Count];
							dataRows1.CopyTo(dataRowArray);
							for (i = 0; i < (int)dataRowArray.Length; i++)
							{
								dataRow = dataRowArray[i];
								dataRow.AcceptChanges();
							}
						}
						if (0 < dataRows.Count)
						{
							dataRowArray = new DataRow[dataRows.Count];
							dataRows.CopyTo(dataRowArray);
							for (i = 0; i < (int)dataRowArray.Length; i++)
							{
								dataRow = dataRowArray[i];
								dataRow.AcceptChanges();
							}
						}
					}
					catch (Exception exception1)
					{
						Exception exception = exception1;
						dbTransaction.Rollback();
						if (this.BackupDataSetBeforeUpdate)
						{
							Debug.Assert(dataSet1 != null);
							dataSet.Clear();
							dataSet.Merge(dataSet1);
						}
						else if (0 < dataRows1.Count)
						{
							dataRowArray = new DataRow[dataRows1.Count];
							dataRows1.CopyTo(dataRowArray);
							for (i = 0; i < (int)dataRowArray.Length; i++)
							{
								dataRow = dataRowArray[i];
								dataRow.AcceptChanges();
								dataRow.SetAdded();
							}
						}
						throw exception;
					}
				}
				finally
				{
					if (flag)
					{
						connection.Close();
					}
					if (this._tCargoTableAdapter != null)
					{
						this._tCargoTableAdapter.Connection = (SqlConnection)objs[this._tCargoTableAdapter];
						this._tCargoTableAdapter.Transaction = null;
					}
					if (this._tDiasHorarioTableAdapter != null)
					{
						this._tDiasHorarioTableAdapter.Connection = (SqlConnection)objs[this._tDiasHorarioTableAdapter];
						this._tDiasHorarioTableAdapter.Transaction = null;
					}
					if (this._tDivisionEmpresaTableAdapter != null)
					{
						this._tDivisionEmpresaTableAdapter.Connection = (SqlConnection)objs[this._tDivisionEmpresaTableAdapter];
						this._tDivisionEmpresaTableAdapter.Transaction = null;
					}
					if (this._tEmpleadoTableAdapter != null)
					{
						this._tEmpleadoTableAdapter.Connection = (SqlConnection)objs[this._tEmpleadoTableAdapter];
						this._tEmpleadoTableAdapter.Transaction = null;
					}
					if (this._tEmpleadoVehiculoTableAdapter != null)
					{
						this._tEmpleadoVehiculoTableAdapter.Connection = (SqlConnection)objs[this._tEmpleadoVehiculoTableAdapter];
						this._tEmpleadoVehiculoTableAdapter.Transaction = null;
					}
					if (this._tEmpresaTableAdapter != null)
					{
						this._tEmpresaTableAdapter.Connection = (SqlConnection)objs[this._tEmpresaTableAdapter];
						this._tEmpresaTableAdapter.Transaction = null;
					}
					if (this._tEmpresaVisitanteTableAdapter != null)
					{
						this._tEmpresaVisitanteTableAdapter.Connection = (SqlConnection)objs[this._tEmpresaVisitanteTableAdapter];
						this._tEmpresaVisitanteTableAdapter.Transaction = null;
					}
					if (this._tEstadoTableAdapter != null)
					{
						this._tEstadoTableAdapter.Connection = (SqlConnection)objs[this._tEstadoTableAdapter];
						this._tEstadoTableAdapter.Transaction = null;
					}
					if (this._tFestivosTableAdapter != null)
					{
						this._tFestivosTableAdapter.Connection = (SqlConnection)objs[this._tFestivosTableAdapter];
						this._tFestivosTableAdapter.Transaction = null;
					}
					if (this._tHorarioTableAdapter != null)
					{
						this._tHorarioTableAdapter.Connection = (SqlConnection)objs[this._tHorarioTableAdapter];
						this._tHorarioTableAdapter.Transaction = null;
					}
					if (this._tipoVehiculoTableAdapter != null)
					{
						this._tipoVehiculoTableAdapter.Connection = (SqlConnection)objs[this._tipoVehiculoTableAdapter];
						this._tipoVehiculoTableAdapter.Transaction = null;
					}
					if (this._tMarcaVehiculoTableAdapter != null)
					{
						this._tMarcaVehiculoTableAdapter.Connection = (SqlConnection)objs[this._tMarcaVehiculoTableAdapter];
						this._tMarcaVehiculoTableAdapter.Transaction = null;
					}
					if (this._tModeloVehiculoTableAdapter != null)
					{
						this._tModeloVehiculoTableAdapter.Connection = (SqlConnection)objs[this._tModeloVehiculoTableAdapter];
						this._tModeloVehiculoTableAdapter.Transaction = null;
					}
					if (this._tPanelTableAdapter != null)
					{
						this._tPanelTableAdapter.Connection = (SqlConnection)objs[this._tPanelTableAdapter];
						this._tPanelTableAdapter.Transaction = null;
					}
					if (this._tParqueoTableAdapter != null)
					{
						this._tParqueoTableAdapter.Connection = (SqlConnection)objs[this._tParqueoTableAdapter];
						this._tParqueoTableAdapter.Transaction = null;
					}
					if (this._tRegistroEmpleadoTableAdapter != null)
					{
						this._tRegistroEmpleadoTableAdapter.Connection = (SqlConnection)objs[this._tRegistroEmpleadoTableAdapter];
						this._tRegistroEmpleadoTableAdapter.Transaction = null;
					}
					if (this._tRegistroVehiculoTableAdapter != null)
					{
						this._tRegistroVehiculoTableAdapter.Connection = (SqlConnection)objs[this._tRegistroVehiculoTableAdapter];
						this._tRegistroVehiculoTableAdapter.Transaction = null;
					}
					if (this._tTarjetaTableAdapter != null)
					{
						this._tTarjetaTableAdapter.Connection = (SqlConnection)objs[this._tTarjetaTableAdapter];
						this._tTarjetaTableAdapter.Transaction = null;
					}
					if (this._tTipoIdentificacionTableAdapter != null)
					{
						this._tTipoIdentificacionTableAdapter.Connection = (SqlConnection)objs[this._tTipoIdentificacionTableAdapter];
						this._tTipoIdentificacionTableAdapter.Transaction = null;
					}
					if (this._tTipoRegistroTableAdapter != null)
					{
						this._tTipoRegistroTableAdapter.Connection = (SqlConnection)objs[this._tTipoRegistroTableAdapter];
						this._tTipoRegistroTableAdapter.Transaction = null;
					}
					if (this._tTipoUsuarioTableAdapter != null)
					{
						this._tTipoUsuarioTableAdapter.Connection = (SqlConnection)objs[this._tTipoUsuarioTableAdapter];
						this._tTipoUsuarioTableAdapter.Transaction = null;
					}
					if (this._tUsuarioTableAdapter != null)
					{
						this._tUsuarioTableAdapter.Connection = (SqlConnection)objs[this._tUsuarioTableAdapter];
						this._tUsuarioTableAdapter.Transaction = null;
					}
					if (this._tVehiculoTableAdapter != null)
					{
						this._tVehiculoTableAdapter.Connection = (SqlConnection)objs[this._tVehiculoTableAdapter];
						this._tVehiculoTableAdapter.Transaction = null;
					}
					if (this._tvehiculoParqueoTableAdapter != null)
					{
						this._tvehiculoParqueoTableAdapter.Connection = (SqlConnection)objs[this._tvehiculoParqueoTableAdapter];
						this._tvehiculoParqueoTableAdapter.Transaction = null;
					}
					if (this._tVisitanteTableAdapter != null)
					{
						this._tVisitanteTableAdapter.Connection = (SqlConnection)objs[this._tVisitanteTableAdapter];
						this._tVisitanteTableAdapter.Transaction = null;
					}
					if (this._tVisitanteVisitaProgramadaTableAdapter != null)
					{
						this._tVisitanteVisitaProgramadaTableAdapter.Connection = (SqlConnection)objs[this._tVisitanteVisitaProgramadaTableAdapter];
						this._tVisitanteVisitaProgramadaTableAdapter.Transaction = null;
					}
					if (this._tVisitaProgramadaTableAdapter != null)
					{
						this._tVisitaProgramadaTableAdapter.Connection = (SqlConnection)objs[this._tVisitaProgramadaTableAdapter];
						this._tVisitaProgramadaTableAdapter.Transaction = null;
					}
					if (this._tinnerTableAdapter != null)
					{
						this._tinnerTableAdapter.Connection = (SqlConnection)objs[this._tinnerTableAdapter];
						this._tinnerTableAdapter.Transaction = null;
					}
					if (this._tInnerAccionTableAdapter != null)
					{
						this._tInnerAccionTableAdapter.Connection = (SqlConnection)objs[this._tInnerAccionTableAdapter];
						this._tInnerAccionTableAdapter.Transaction = null;
					}
					if (this._tMarcacionTableAdapter != null)
					{
						this._tMarcacionTableAdapter.Connection = (SqlConnection)objs[this._tMarcacionTableAdapter];
						this._tMarcacionTableAdapter.Transaction = null;
					}
					if (this._tRegistroVehiculo1TableAdapter != null)
					{
						this._tRegistroVehiculo1TableAdapter.Connection = (SqlConnection)objs[this._tRegistroVehiculo1TableAdapter];
						this._tRegistroVehiculo1TableAdapter.Transaction = null;
					}
					if (this._tVisitanteVisitaProgramadaLogTableAdapter != null)
					{
						this._tVisitanteVisitaProgramadaLogTableAdapter.Connection = (SqlConnection)objs[this._tVisitanteVisitaProgramadaLogTableAdapter];
						this._tVisitanteVisitaProgramadaLogTableAdapter.Transaction = null;
					}
					if (0 < dataAdapters.Count)
					{
						DataAdapter[] dataAdapterArray = new DataAdapter[dataAdapters.Count];
						dataAdapters.CopyTo(dataAdapterArray);
						for (i = 0; i < (int)dataAdapterArray.Length; i++)
						{
							dataAdapterArray[i].AcceptChangesDuringUpdate = true;
						}
					}
				}
				num = num1;
			}
			else
			{
				num = 0;
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(masterDBACDataSet dataSet, List<DataRow> allChangedRows)
		{
			DataRow[] dataRowArray;
			int num = 0;
			if (this._tRegistroVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TRegistroVehiculo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tRegistroVehiculoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tRegistroEmpleadoTableAdapter != null)
			{
				dataRowArray = dataSet.TRegistroEmpleado.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tRegistroEmpleadoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTarjetaTableAdapter != null)
			{
				dataRowArray = dataSet.TTarjeta.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTarjetaTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tvehiculoParqueoTableAdapter != null)
			{
				dataRowArray = dataSet.TvehiculoParqueo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tvehiculoParqueoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tUsuarioTableAdapter != null)
			{
				dataRowArray = dataSet.TUsuario.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tUsuarioTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpleadoVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpleadoVehiculo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpleadoVehiculoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tDiasHorarioTableAdapter != null)
			{
				dataRowArray = dataSet.TDiasHorario.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tDiasHorarioTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpresaVisitanteTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpresaVisitante.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpresaVisitanteTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tPanelTableAdapter != null)
			{
				dataRowArray = dataSet.TPanel.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tPanelTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tFestivosTableAdapter != null)
			{
				dataRowArray = dataSet.TFestivos.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tFestivosTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tinnerTableAdapter != null)
			{
				dataRowArray = dataSet.Tinner.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tinnerTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tInnerAccionTableAdapter != null)
			{
				dataRowArray = dataSet.TInnerAccion.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tInnerAccionTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tRegistroVehiculo1TableAdapter != null)
			{
				dataRowArray = dataSet.TRegistroVehiculo1.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tRegistroVehiculo1TableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitanteVisitaProgramadaLogTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitanteVisitaProgramadaLog.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitanteVisitaProgramadaLogTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitanteVisitaProgramadaTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitanteVisitaProgramada.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitanteVisitaProgramadaTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tMarcacionTableAdapter != null)
			{
				dataRowArray = dataSet.TMarcacion.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tMarcacionTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TVehiculo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVehiculoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpleadoTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpleado.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpleadoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitaProgramadaTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitaProgramada.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitaProgramadaTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTipoRegistroTableAdapter != null)
			{
				dataRowArray = dataSet.TTipoRegistro.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTipoRegistroTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitanteTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitante.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitanteTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTipoUsuarioTableAdapter != null)
			{
				dataRowArray = dataSet.TTipoUsuario.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTipoUsuarioTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tParqueoTableAdapter != null)
			{
				dataRowArray = dataSet.TParqueo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tParqueoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tCargoTableAdapter != null)
			{
				dataRowArray = dataSet.TCargo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tCargoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tDivisionEmpresaTableAdapter != null)
			{
				dataRowArray = dataSet.TDivisionEmpresa.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tDivisionEmpresaTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTipoIdentificacionTableAdapter != null)
			{
				dataRowArray = dataSet.TTipoIdentificacion.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTipoIdentificacionTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tModeloVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TModeloVehiculo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tModeloVehiculoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tHorarioTableAdapter != null)
			{
				dataRowArray = dataSet.THorario.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tHorarioTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEstadoTableAdapter != null)
			{
				dataRowArray = dataSet.TEstado.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEstadoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tipoVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TipoVehiculo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tipoVehiculoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpresaTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpresa.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpresaTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			if (this._tMarcaVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TMarcaVehiculo.Select(null, null, DataViewRowState.Deleted);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tMarcaVehiculoTableAdapter.Update(dataRowArray);
					allChangedRows.AddRange(dataRowArray);
				}
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateInsertedRows(masterDBACDataSet dataSet, List<DataRow> allAddedRows)
		{
			DataRow[] dataRowArray;
			int num = 0;
			if (this._tMarcaVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TMarcaVehiculo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tMarcaVehiculoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpresaTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpresa.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpresaTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tipoVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TipoVehiculo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tipoVehiculoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEstadoTableAdapter != null)
			{
				dataRowArray = dataSet.TEstado.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEstadoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tHorarioTableAdapter != null)
			{
				dataRowArray = dataSet.THorario.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tHorarioTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tModeloVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TModeloVehiculo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tModeloVehiculoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTipoIdentificacionTableAdapter != null)
			{
				dataRowArray = dataSet.TTipoIdentificacion.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTipoIdentificacionTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tDivisionEmpresaTableAdapter != null)
			{
				dataRowArray = dataSet.TDivisionEmpresa.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tDivisionEmpresaTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tCargoTableAdapter != null)
			{
				dataRowArray = dataSet.TCargo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tCargoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tParqueoTableAdapter != null)
			{
				dataRowArray = dataSet.TParqueo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tParqueoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTipoUsuarioTableAdapter != null)
			{
				dataRowArray = dataSet.TTipoUsuario.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTipoUsuarioTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitanteTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitante.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitanteTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTipoRegistroTableAdapter != null)
			{
				dataRowArray = dataSet.TTipoRegistro.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTipoRegistroTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitaProgramadaTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitaProgramada.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitaProgramadaTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpleadoTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpleado.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpleadoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TVehiculo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVehiculoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tMarcacionTableAdapter != null)
			{
				dataRowArray = dataSet.TMarcacion.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tMarcacionTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitanteVisitaProgramadaTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitanteVisitaProgramada.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitanteVisitaProgramadaTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tVisitanteVisitaProgramadaLogTableAdapter != null)
			{
				dataRowArray = dataSet.TVisitanteVisitaProgramadaLog.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tVisitanteVisitaProgramadaLogTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tRegistroVehiculo1TableAdapter != null)
			{
				dataRowArray = dataSet.TRegistroVehiculo1.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tRegistroVehiculo1TableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tInnerAccionTableAdapter != null)
			{
				dataRowArray = dataSet.TInnerAccion.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tInnerAccionTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tinnerTableAdapter != null)
			{
				dataRowArray = dataSet.Tinner.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tinnerTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tFestivosTableAdapter != null)
			{
				dataRowArray = dataSet.TFestivos.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tFestivosTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tPanelTableAdapter != null)
			{
				dataRowArray = dataSet.TPanel.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tPanelTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpresaVisitanteTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpresaVisitante.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpresaVisitanteTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tDiasHorarioTableAdapter != null)
			{
				dataRowArray = dataSet.TDiasHorario.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tDiasHorarioTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tEmpleadoVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TEmpleadoVehiculo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tEmpleadoVehiculoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tUsuarioTableAdapter != null)
			{
				dataRowArray = dataSet.TUsuario.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tUsuarioTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tvehiculoParqueoTableAdapter != null)
			{
				dataRowArray = dataSet.TvehiculoParqueo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tvehiculoParqueoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tTarjetaTableAdapter != null)
			{
				dataRowArray = dataSet.TTarjeta.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tTarjetaTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tRegistroEmpleadoTableAdapter != null)
			{
				dataRowArray = dataSet.TRegistroEmpleado.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tRegistroEmpleadoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			if (this._tRegistroVehiculoTableAdapter != null)
			{
				dataRowArray = dataSet.TRegistroVehiculo.Select(null, null, DataViewRowState.Added);
				if ((dataRowArray == null ? false : 0 < (int)dataRowArray.Length))
				{
					num += this._tRegistroVehiculoTableAdapter.Update(dataRowArray);
					allAddedRows.AddRange(dataRowArray);
				}
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(masterDBACDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			DataRow[] realUpdatedRows;
			int num = 0;
			if (this._tMarcaVehiculoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TMarcaVehiculo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tMarcaVehiculoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tEmpresaTableAdapter != null)
			{
				realUpdatedRows = dataSet.TEmpresa.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tEmpresaTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tipoVehiculoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TipoVehiculo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tipoVehiculoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tEstadoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TEstado.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tEstadoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tHorarioTableAdapter != null)
			{
				realUpdatedRows = dataSet.THorario.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tHorarioTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tModeloVehiculoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TModeloVehiculo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tModeloVehiculoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tTipoIdentificacionTableAdapter != null)
			{
				realUpdatedRows = dataSet.TTipoIdentificacion.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tTipoIdentificacionTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tDivisionEmpresaTableAdapter != null)
			{
				realUpdatedRows = dataSet.TDivisionEmpresa.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tDivisionEmpresaTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tCargoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TCargo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tCargoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tParqueoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TParqueo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tParqueoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tTipoUsuarioTableAdapter != null)
			{
				realUpdatedRows = dataSet.TTipoUsuario.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tTipoUsuarioTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tVisitanteTableAdapter != null)
			{
				realUpdatedRows = dataSet.TVisitante.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tVisitanteTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tTipoRegistroTableAdapter != null)
			{
				realUpdatedRows = dataSet.TTipoRegistro.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tTipoRegistroTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tVisitaProgramadaTableAdapter != null)
			{
				realUpdatedRows = dataSet.TVisitaProgramada.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tVisitaProgramadaTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tEmpleadoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TEmpleado.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tEmpleadoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tVehiculoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TVehiculo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tVehiculoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tMarcacionTableAdapter != null)
			{
				realUpdatedRows = dataSet.TMarcacion.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tMarcacionTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tVisitanteVisitaProgramadaTableAdapter != null)
			{
				realUpdatedRows = dataSet.TVisitanteVisitaProgramada.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tVisitanteVisitaProgramadaTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tVisitanteVisitaProgramadaLogTableAdapter != null)
			{
				realUpdatedRows = dataSet.TVisitanteVisitaProgramadaLog.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tVisitanteVisitaProgramadaLogTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tRegistroVehiculo1TableAdapter != null)
			{
				realUpdatedRows = dataSet.TRegistroVehiculo1.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tRegistroVehiculo1TableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tInnerAccionTableAdapter != null)
			{
				realUpdatedRows = dataSet.TInnerAccion.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tInnerAccionTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tinnerTableAdapter != null)
			{
				realUpdatedRows = dataSet.Tinner.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tinnerTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tFestivosTableAdapter != null)
			{
				realUpdatedRows = dataSet.TFestivos.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tFestivosTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tPanelTableAdapter != null)
			{
				realUpdatedRows = dataSet.TPanel.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tPanelTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tEmpresaVisitanteTableAdapter != null)
			{
				realUpdatedRows = dataSet.TEmpresaVisitante.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tEmpresaVisitanteTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tDiasHorarioTableAdapter != null)
			{
				realUpdatedRows = dataSet.TDiasHorario.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tDiasHorarioTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tEmpleadoVehiculoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TEmpleadoVehiculo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tEmpleadoVehiculoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tUsuarioTableAdapter != null)
			{
				realUpdatedRows = dataSet.TUsuario.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tUsuarioTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tvehiculoParqueoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TvehiculoParqueo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tvehiculoParqueoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tTarjetaTableAdapter != null)
			{
				realUpdatedRows = dataSet.TTarjeta.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tTarjetaTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tRegistroEmpleadoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TRegistroEmpleado.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tRegistroEmpleadoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			if (this._tRegistroVehiculoTableAdapter != null)
			{
				realUpdatedRows = dataSet.TRegistroVehiculo.Select(null, null, DataViewRowState.ModifiedCurrent);
				realUpdatedRows = this.GetRealUpdatedRows(realUpdatedRows, allAddedRows);
				if ((realUpdatedRows == null ? false : 0 < (int)realUpdatedRows.Length))
				{
					num += this._tRegistroVehiculoTableAdapter.Update(realUpdatedRows);
					allChangedRows.AddRange(realUpdatedRows);
				}
			}
			return num;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			private DataRelation _relation;

			private int _childFirst;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				this._relation = relation;
				if (!childFirst)
				{
					this._childFirst = 1;
				}
				else
				{
					this._childFirst = -1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Compare(DataRow row1, DataRow row2)
			{
				int num;
				if (object.ReferenceEquals(row1, row2))
				{
					num = 0;
				}
				else if (row1 == null)
				{
					num = -1;
				}
				else if (row2 != null)
				{
					int num1 = 0;
					DataRow root = this.GetRoot(row1, out num1);
					int num2 = 0;
					DataRow dataRow = this.GetRoot(row2, out num2);
					if (!object.ReferenceEquals(root, dataRow))
					{
						Debug.Assert((root.Table == null ? false : dataRow.Table != null));
						num = (root.Table.Rows.IndexOf(root) >= dataRow.Table.Rows.IndexOf(dataRow) ? 1 : -1);
					}
					else
					{
						num = this._childFirst * num1.CompareTo(num2);
					}
				}
				else
				{
					num = 1;
				}
				return num;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, out int distance)
			{
				Debug.Assert(row != null);
				DataRow dataRow = row;
				distance = 0;
				IDictionary<DataRow, DataRow> dataRows = new Dictionary<DataRow, DataRow>();
				dataRows[row] = row;
				DataRow parentRow = row.GetParentRow(this._relation, DataRowVersion.Default);
				while (true)
				{
					if ((parentRow == null ? true : dataRows.ContainsKey(parentRow)))
					{
						break;
					}
					distance++;
					dataRow = parentRow;
					dataRows[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Default);
				}
				if (distance == 0)
				{
					dataRows.Clear();
					dataRows[row] = row;
					parentRow = row.GetParentRow(this._relation, DataRowVersion.Original);
					while (true)
					{
						if ((parentRow == null ? true : dataRows.ContainsKey(parentRow)))
						{
							break;
						}
						distance++;
						dataRow = parentRow;
						dataRows[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(this._relation, DataRowVersion.Original);
					}
				}
				return dataRow;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			InsertUpdateDelete,
			UpdateInsertDelete
		}
	}
}