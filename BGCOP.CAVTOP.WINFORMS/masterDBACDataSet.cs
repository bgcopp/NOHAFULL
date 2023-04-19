using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BGCOP.CAVTOP.WINFORMS
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	[ToolboxItem(true)]
	[XmlRoot("masterDBACDataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class masterDBACDataSet : DataSet
	{
		private masterDBACDataSet.TCargoDataTable tableTCargo;

		private masterDBACDataSet.TDiasHorarioDataTable tableTDiasHorario;

		private masterDBACDataSet.TDivisionEmpresaDataTable tableTDivisionEmpresa;

		private masterDBACDataSet.TEmpleadoDataTable tableTEmpleado;

		private masterDBACDataSet.TEmpleadoVehiculoDataTable tableTEmpleadoVehiculo;

		private masterDBACDataSet.TEmpresaDataTable tableTEmpresa;

		private masterDBACDataSet.TEmpresaVisitanteDataTable tableTEmpresaVisitante;

		private masterDBACDataSet.TEstadoDataTable tableTEstado;

		private masterDBACDataSet.TFestivosDataTable tableTFestivos;

		private masterDBACDataSet.THorarioDataTable tableTHorario;

		private masterDBACDataSet.TipoVehiculoDataTable tableTipoVehiculo;

		private masterDBACDataSet.TMarcaVehiculoDataTable tableTMarcaVehiculo;

		private masterDBACDataSet.TModeloVehiculoDataTable tableTModeloVehiculo;

		private masterDBACDataSet.TPanelDataTable tableTPanel;

		private masterDBACDataSet.TParqueoDataTable tableTParqueo;

		private masterDBACDataSet.TRegistroEmpleadoDataTable tableTRegistroEmpleado;

		private masterDBACDataSet.TRegistroVehiculoDataTable tableTRegistroVehiculo;

		private masterDBACDataSet.TTarjetaDataTable tableTTarjeta;

		private masterDBACDataSet.TTipoIdentificacionDataTable tableTTipoIdentificacion;

		private masterDBACDataSet.TTipoRegistroDataTable tableTTipoRegistro;

		private masterDBACDataSet.TTipoUsuarioDataTable tableTTipoUsuario;

		private masterDBACDataSet.TUsuarioDataTable tableTUsuario;

		private masterDBACDataSet.TVehiculoDataTable tableTVehiculo;

		private masterDBACDataSet.TvehiculoParqueoDataTable tableTvehiculoParqueo;

		private masterDBACDataSet.TVisitanteDataTable tableTVisitante;

		private masterDBACDataSet.TVisitanteVisitaProgramadaDataTable tableTVisitanteVisitaProgramada;

		private masterDBACDataSet.TVisitaProgramadaDataTable tableTVisitaProgramada;

		private masterDBACDataSet.viEmpleadoDataTable tableviEmpleado;

		private masterDBACDataSet.viParqueoVehiculoDataTable tableviParqueoVehiculo;

		private masterDBACDataSet.viVehiculoDataTable tableviVehiculo;

		private masterDBACDataSet.TinnerDataTable tableTinner;

		private masterDBACDataSet.TInnerAccionDataTable tableTInnerAccion;

		private masterDBACDataSet.TMarcacionDataTable tableTMarcacion;

		private masterDBACDataSet.TRegistroVehiculo1DataTable tableTRegistroVehiculo1;

		private masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable tableTVisitanteVisitaProgramadaLog;

		private DataRelation relationFK_TDiasHorario_THorario;

		private DataRelation relationFK_TDivisionEmpresa_TEmpresa;

		private DataRelation relationFK_TEmpleado_TCargo;

		private DataRelation relationFK_TEmpleado_TDivisionEmpresa;

		private DataRelation relationFK_TEmpleado_TEstado;

		private DataRelation relationFK_TEmpleado_THorario;

		private DataRelation relationFK_TEmpleado_TTipoIdentificacion;

		private DataRelation relationFK_TModeloVehiculo_MarcaVehiculo;

		private DataRelation relationFK_TModeloVehiculo_TipoVehiculo;

		private DataRelation relationFK_TRegistroEmpleado_TEmpleado;

		private DataRelation relationFK_TRegistroEmpleado_TTipoRegistro;

		private DataRelation relationFK_TRegistroVehiculo_TTipoRegistro;

		private DataRelation relationFK_TRegistroVehiculo_TVehiculo;

		private DataRelation relationFK_TUsuario_TTipoUsuario;

		private DataRelation relationFK_TVehiculo_TModeloVehiculo;

		private DataRelation relationFK_TVisitante_TTipoIdentificacion;

		private DataRelation relationFK_TVisitanteVisitaProgramada_TEmpleado;

		private DataRelation relationFK_TVisitanteVisitaProgramada_TVisitante;

		private DataRelation relationFK_TVisitanteVisitaProgramada_TVisitaProgramada;

		private DataRelation relationFK_TRegistroVehiculo_TTipoRegistro1;

		private DataRelation relationFK_TRegistroVehiculo_TVehiculo1;

		private DataRelation relationFK_TVisitanteVisitaProgramadaLog_TEmpleado;

		private DataRelation relationFK_TVisitanteVisitaProgramadaLog_TVisitante;

		private DataRelation relationFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada;

		private DataRelation relationFK_TEmpleadoVehiculo_TEmpleado;

		private DataRelation relationFK_TEmpleadoVehiculo_TVehiculo;

		private DataRelation relationFK_TvehiculoParqueo_Tparqueo;

		private DataRelation relationFK_TvehiculoParqueo_TVehiculo;

		private System.Data.SchemaSerializationMode _schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[Browsable(true)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override System.Data.SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TCargoDataTable TCargo
		{
			get
			{
				return this.tableTCargo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TDiasHorarioDataTable TDiasHorario
		{
			get
			{
				return this.tableTDiasHorario;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TDivisionEmpresaDataTable TDivisionEmpresa
		{
			get
			{
				return this.tableTDivisionEmpresa;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TEmpleadoDataTable TEmpleado
		{
			get
			{
				return this.tableTEmpleado;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TEmpleadoVehiculoDataTable TEmpleadoVehiculo
		{
			get
			{
				return this.tableTEmpleadoVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TEmpresaDataTable TEmpresa
		{
			get
			{
				return this.tableTEmpresa;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TEmpresaVisitanteDataTable TEmpresaVisitante
		{
			get
			{
				return this.tableTEmpresaVisitante;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TEstadoDataTable TEstado
		{
			get
			{
				return this.tableTEstado;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TFestivosDataTable TFestivos
		{
			get
			{
				return this.tableTFestivos;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.THorarioDataTable THorario
		{
			get
			{
				return this.tableTHorario;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TinnerDataTable Tinner
		{
			get
			{
				return this.tableTinner;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TInnerAccionDataTable TInnerAccion
		{
			get
			{
				return this.tableTInnerAccion;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TipoVehiculoDataTable TipoVehiculo
		{
			get
			{
				return this.tableTipoVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TMarcacionDataTable TMarcacion
		{
			get
			{
				return this.tableTMarcacion;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TMarcaVehiculoDataTable TMarcaVehiculo
		{
			get
			{
				return this.tableTMarcaVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TModeloVehiculoDataTable TModeloVehiculo
		{
			get
			{
				return this.tableTModeloVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TPanelDataTable TPanel
		{
			get
			{
				return this.tableTPanel;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TParqueoDataTable TParqueo
		{
			get
			{
				return this.tableTParqueo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TRegistroEmpleadoDataTable TRegistroEmpleado
		{
			get
			{
				return this.tableTRegistroEmpleado;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TRegistroVehiculoDataTable TRegistroVehiculo
		{
			get
			{
				return this.tableTRegistroVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TRegistroVehiculo1DataTable TRegistroVehiculo1
		{
			get
			{
				return this.tableTRegistroVehiculo1;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TTarjetaDataTable TTarjeta
		{
			get
			{
				return this.tableTTarjeta;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TTipoIdentificacionDataTable TTipoIdentificacion
		{
			get
			{
				return this.tableTTipoIdentificacion;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TTipoRegistroDataTable TTipoRegistro
		{
			get
			{
				return this.tableTTipoRegistro;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TTipoUsuarioDataTable TTipoUsuario
		{
			get
			{
				return this.tableTTipoUsuario;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TUsuarioDataTable TUsuario
		{
			get
			{
				return this.tableTUsuario;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TVehiculoDataTable TVehiculo
		{
			get
			{
				return this.tableTVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TvehiculoParqueoDataTable TvehiculoParqueo
		{
			get
			{
				return this.tableTvehiculoParqueo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TVisitanteDataTable TVisitante
		{
			get
			{
				return this.tableTVisitante;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TVisitanteVisitaProgramadaDataTable TVisitanteVisitaProgramada
		{
			get
			{
				return this.tableTVisitanteVisitaProgramada;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable TVisitanteVisitaProgramadaLog
		{
			get
			{
				return this.tableTVisitanteVisitaProgramadaLog;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.TVisitaProgramadaDataTable TVisitaProgramada
		{
			get
			{
				return this.tableTVisitaProgramada;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.viEmpleadoDataTable viEmpleado
		{
			get
			{
				return this.tableviEmpleado;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.viParqueoVehiculoDataTable viParqueoVehiculo
		{
			get
			{
				return this.tableviParqueoVehiculo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet.viVehiculoDataTable viVehiculo
		{
			get
			{
				return this.tableviVehiculo;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public masterDBACDataSet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected masterDBACDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (!base.IsBinarySerialized(info, context))
			{
				string value = (string)info.GetValue("XmlSchema", typeof(string));
				if (base.DetermineSchemaSerializationMode(info, context) != System.Data.SchemaSerializationMode.IncludeSchema)
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(value)));
				}
				else
				{
					DataSet dataSet = new DataSet();
					dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(value)));
					if (dataSet.Tables["TCargo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TCargoDataTable(dataSet.Tables["TCargo"]));
					}
					if (dataSet.Tables["TDiasHorario"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TDiasHorarioDataTable(dataSet.Tables["TDiasHorario"]));
					}
					if (dataSet.Tables["TDivisionEmpresa"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TDivisionEmpresaDataTable(dataSet.Tables["TDivisionEmpresa"]));
					}
					if (dataSet.Tables["TEmpleado"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TEmpleadoDataTable(dataSet.Tables["TEmpleado"]));
					}
					if (dataSet.Tables["TEmpleadoVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TEmpleadoVehiculoDataTable(dataSet.Tables["TEmpleadoVehiculo"]));
					}
					if (dataSet.Tables["TEmpresa"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TEmpresaDataTable(dataSet.Tables["TEmpresa"]));
					}
					if (dataSet.Tables["TEmpresaVisitante"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TEmpresaVisitanteDataTable(dataSet.Tables["TEmpresaVisitante"]));
					}
					if (dataSet.Tables["TEstado"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TEstadoDataTable(dataSet.Tables["TEstado"]));
					}
					if (dataSet.Tables["TFestivos"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TFestivosDataTable(dataSet.Tables["TFestivos"]));
					}
					if (dataSet.Tables["THorario"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.THorarioDataTable(dataSet.Tables["THorario"]));
					}
					if (dataSet.Tables["TipoVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TipoVehiculoDataTable(dataSet.Tables["TipoVehiculo"]));
					}
					if (dataSet.Tables["TMarcaVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TMarcaVehiculoDataTable(dataSet.Tables["TMarcaVehiculo"]));
					}
					if (dataSet.Tables["TModeloVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TModeloVehiculoDataTable(dataSet.Tables["TModeloVehiculo"]));
					}
					if (dataSet.Tables["TPanel"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TPanelDataTable(dataSet.Tables["TPanel"]));
					}
					if (dataSet.Tables["TParqueo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TParqueoDataTable(dataSet.Tables["TParqueo"]));
					}
					if (dataSet.Tables["TRegistroEmpleado"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TRegistroEmpleadoDataTable(dataSet.Tables["TRegistroEmpleado"]));
					}
					if (dataSet.Tables["TRegistroVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TRegistroVehiculoDataTable(dataSet.Tables["TRegistroVehiculo"]));
					}
					if (dataSet.Tables["TTarjeta"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TTarjetaDataTable(dataSet.Tables["TTarjeta"]));
					}
					if (dataSet.Tables["TTipoIdentificacion"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TTipoIdentificacionDataTable(dataSet.Tables["TTipoIdentificacion"]));
					}
					if (dataSet.Tables["TTipoRegistro"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TTipoRegistroDataTable(dataSet.Tables["TTipoRegistro"]));
					}
					if (dataSet.Tables["TTipoUsuario"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TTipoUsuarioDataTable(dataSet.Tables["TTipoUsuario"]));
					}
					if (dataSet.Tables["TUsuario"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TUsuarioDataTable(dataSet.Tables["TUsuario"]));
					}
					if (dataSet.Tables["TVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TVehiculoDataTable(dataSet.Tables["TVehiculo"]));
					}
					if (dataSet.Tables["TvehiculoParqueo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TvehiculoParqueoDataTable(dataSet.Tables["TvehiculoParqueo"]));
					}
					if (dataSet.Tables["TVisitante"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TVisitanteDataTable(dataSet.Tables["TVisitante"]));
					}
					if (dataSet.Tables["TVisitanteVisitaProgramada"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TVisitanteVisitaProgramadaDataTable(dataSet.Tables["TVisitanteVisitaProgramada"]));
					}
					if (dataSet.Tables["TVisitaProgramada"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TVisitaProgramadaDataTable(dataSet.Tables["TVisitaProgramada"]));
					}
					if (dataSet.Tables["viEmpleado"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.viEmpleadoDataTable(dataSet.Tables["viEmpleado"]));
					}
					if (dataSet.Tables["viParqueoVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.viParqueoVehiculoDataTable(dataSet.Tables["viParqueoVehiculo"]));
					}
					if (dataSet.Tables["viVehiculo"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.viVehiculoDataTable(dataSet.Tables["viVehiculo"]));
					}
					if (dataSet.Tables["Tinner"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TinnerDataTable(dataSet.Tables["Tinner"]));
					}
					if (dataSet.Tables["TInnerAccion"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TInnerAccionDataTable(dataSet.Tables["TInnerAccion"]));
					}
					if (dataSet.Tables["TMarcacion"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TMarcacionDataTable(dataSet.Tables["TMarcacion"]));
					}
					if (dataSet.Tables["TRegistroVehiculo1"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TRegistroVehiculo1DataTable(dataSet.Tables["TRegistroVehiculo1"]));
					}
					if (dataSet.Tables["TVisitanteVisitaProgramadaLog"] != null)
					{
						base.Tables.Add(new masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable(dataSet.Tables["TVisitanteVisitaProgramadaLog"]));
					}
					base.DataSetName = dataSet.DataSetName;
					base.Prefix = dataSet.Prefix;
					base.Namespace = dataSet.Namespace;
					base.Locale = dataSet.Locale;
					base.CaseSensitive = dataSet.CaseSensitive;
					base.EnforceConstraints = dataSet.EnforceConstraints;
					base.Merge(dataSet, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += collectionChangeEventHandler;
				this.Relations.CollectionChanged += collectionChangeEventHandler;
			}
			else
			{
				this.InitVars(false);
				CollectionChangeEventHandler collectionChangeEventHandler1 = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += collectionChangeEventHandler1;
				this.Relations.CollectionChanged += collectionChangeEventHandler1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			masterDBACDataSet schemaSerializationMode = (masterDBACDataSet)base.Clone();
			schemaSerializationMode.InitVars();
			schemaSerializationMode.SchemaSerializationMode = this.SchemaSerializationMode;
			return schemaSerializationMode;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = (long)0;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType;
			masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
			XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
			{
				Namespace = _masterDBACDataSet.Namespace
			};
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType1.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream1 = new MemoryStream();
				try
				{
					XmlSchema current = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						current = (XmlSchema)enumerator.Current;
						memoryStream1.SetLength((long)0);
						current.Write(memoryStream1);
						if (memoryStream.Length == memoryStream1.Length)
						{
							memoryStream.Position = (long)0;
							memoryStream1.Position = (long)0;
							while (true)
							{
								if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
								{
									break;
								}
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								xmlSchemaComplexType = xmlSchemaComplexType1;
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream1 != null)
					{
						memoryStream1.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			xmlSchemaComplexType = xmlSchemaComplexType1;
			return xmlSchemaComplexType;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "masterDBACDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/masterDBACDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tableTCargo = new masterDBACDataSet.TCargoDataTable();
			base.Tables.Add(this.tableTCargo);
			this.tableTDiasHorario = new masterDBACDataSet.TDiasHorarioDataTable();
			base.Tables.Add(this.tableTDiasHorario);
			this.tableTDivisionEmpresa = new masterDBACDataSet.TDivisionEmpresaDataTable();
			base.Tables.Add(this.tableTDivisionEmpresa);
			this.tableTEmpleado = new masterDBACDataSet.TEmpleadoDataTable();
			base.Tables.Add(this.tableTEmpleado);
			this.tableTEmpleadoVehiculo = new masterDBACDataSet.TEmpleadoVehiculoDataTable();
			base.Tables.Add(this.tableTEmpleadoVehiculo);
			this.tableTEmpresa = new masterDBACDataSet.TEmpresaDataTable();
			base.Tables.Add(this.tableTEmpresa);
			this.tableTEmpresaVisitante = new masterDBACDataSet.TEmpresaVisitanteDataTable();
			base.Tables.Add(this.tableTEmpresaVisitante);
			this.tableTEstado = new masterDBACDataSet.TEstadoDataTable();
			base.Tables.Add(this.tableTEstado);
			this.tableTFestivos = new masterDBACDataSet.TFestivosDataTable();
			base.Tables.Add(this.tableTFestivos);
			this.tableTHorario = new masterDBACDataSet.THorarioDataTable();
			base.Tables.Add(this.tableTHorario);
			this.tableTipoVehiculo = new masterDBACDataSet.TipoVehiculoDataTable();
			base.Tables.Add(this.tableTipoVehiculo);
			this.tableTMarcaVehiculo = new masterDBACDataSet.TMarcaVehiculoDataTable();
			base.Tables.Add(this.tableTMarcaVehiculo);
			this.tableTModeloVehiculo = new masterDBACDataSet.TModeloVehiculoDataTable();
			base.Tables.Add(this.tableTModeloVehiculo);
			this.tableTPanel = new masterDBACDataSet.TPanelDataTable();
			base.Tables.Add(this.tableTPanel);
			this.tableTParqueo = new masterDBACDataSet.TParqueoDataTable();
			base.Tables.Add(this.tableTParqueo);
			this.tableTRegistroEmpleado = new masterDBACDataSet.TRegistroEmpleadoDataTable();
			base.Tables.Add(this.tableTRegistroEmpleado);
			this.tableTRegistroVehiculo = new masterDBACDataSet.TRegistroVehiculoDataTable();
			base.Tables.Add(this.tableTRegistroVehiculo);
			this.tableTTarjeta = new masterDBACDataSet.TTarjetaDataTable();
			base.Tables.Add(this.tableTTarjeta);
			this.tableTTipoIdentificacion = new masterDBACDataSet.TTipoIdentificacionDataTable();
			base.Tables.Add(this.tableTTipoIdentificacion);
			this.tableTTipoRegistro = new masterDBACDataSet.TTipoRegistroDataTable();
			base.Tables.Add(this.tableTTipoRegistro);
			this.tableTTipoUsuario = new masterDBACDataSet.TTipoUsuarioDataTable();
			base.Tables.Add(this.tableTTipoUsuario);
			this.tableTUsuario = new masterDBACDataSet.TUsuarioDataTable();
			base.Tables.Add(this.tableTUsuario);
			this.tableTVehiculo = new masterDBACDataSet.TVehiculoDataTable();
			base.Tables.Add(this.tableTVehiculo);
			this.tableTvehiculoParqueo = new masterDBACDataSet.TvehiculoParqueoDataTable();
			base.Tables.Add(this.tableTvehiculoParqueo);
			this.tableTVisitante = new masterDBACDataSet.TVisitanteDataTable();
			base.Tables.Add(this.tableTVisitante);
			this.tableTVisitanteVisitaProgramada = new masterDBACDataSet.TVisitanteVisitaProgramadaDataTable();
			base.Tables.Add(this.tableTVisitanteVisitaProgramada);
			this.tableTVisitaProgramada = new masterDBACDataSet.TVisitaProgramadaDataTable();
			base.Tables.Add(this.tableTVisitaProgramada);
			this.tableviEmpleado = new masterDBACDataSet.viEmpleadoDataTable();
			base.Tables.Add(this.tableviEmpleado);
			this.tableviParqueoVehiculo = new masterDBACDataSet.viParqueoVehiculoDataTable();
			base.Tables.Add(this.tableviParqueoVehiculo);
			this.tableviVehiculo = new masterDBACDataSet.viVehiculoDataTable();
			base.Tables.Add(this.tableviVehiculo);
			this.tableTinner = new masterDBACDataSet.TinnerDataTable();
			base.Tables.Add(this.tableTinner);
			this.tableTInnerAccion = new masterDBACDataSet.TInnerAccionDataTable();
			base.Tables.Add(this.tableTInnerAccion);
			this.tableTMarcacion = new masterDBACDataSet.TMarcacionDataTable();
			base.Tables.Add(this.tableTMarcacion);
			this.tableTRegistroVehiculo1 = new masterDBACDataSet.TRegistroVehiculo1DataTable();
			base.Tables.Add(this.tableTRegistroVehiculo1);
			this.tableTVisitanteVisitaProgramadaLog = new masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable();
			base.Tables.Add(this.tableTVisitanteVisitaProgramadaLog);
			DataColumn[] idEmpresaColumn = new DataColumn[] { this.tableTHorario.idHorarioColumn };
			DataColumn[] dataColumnArray = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTDiasHorario.idHorarioColumn };
			this.relationFK_TDiasHorario_THorario = new DataRelation("FK_TDiasHorario_THorario", dataColumnArray, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TDiasHorario_THorario);
			idEmpresaColumn = new DataColumn[] { this.tableTEmpresa.idEmpresaColumn };
			DataColumn[] dataColumnArray1 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTDivisionEmpresa.IdEmpresaColumn };
			this.relationFK_TDivisionEmpresa_TEmpresa = new DataRelation("FK_TDivisionEmpresa_TEmpresa", dataColumnArray1, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TDivisionEmpresa_TEmpresa);
			idEmpresaColumn = new DataColumn[] { this.tableTCargo.idCargoColumn };
			DataColumn[] dataColumnArray2 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idCargoColumn };
			this.relationFK_TEmpleado_TCargo = new DataRelation("FK_TEmpleado_TCargo", dataColumnArray2, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleado_TCargo);
			idEmpresaColumn = new DataColumn[] { this.tableTDivisionEmpresa.IdDivisionEmpresaColumn };
			DataColumn[] dataColumnArray3 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idDivisionEmpresaColumn };
			this.relationFK_TEmpleado_TDivisionEmpresa = new DataRelation("FK_TEmpleado_TDivisionEmpresa", dataColumnArray3, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleado_TDivisionEmpresa);
			idEmpresaColumn = new DataColumn[] { this.tableTEstado.idTipoEstadoColumn };
			DataColumn[] dataColumnArray4 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idTipoEstadoColumn };
			this.relationFK_TEmpleado_TEstado = new DataRelation("FK_TEmpleado_TEstado", dataColumnArray4, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleado_TEstado);
			idEmpresaColumn = new DataColumn[] { this.tableTHorario.idHorarioColumn };
			DataColumn[] dataColumnArray5 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idHorarioColumn };
			this.relationFK_TEmpleado_THorario = new DataRelation("FK_TEmpleado_THorario", dataColumnArray5, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleado_THorario);
			idEmpresaColumn = new DataColumn[] { this.tableTTipoIdentificacion.idTipoIdentificacionColumn };
			DataColumn[] dataColumnArray6 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idTipoIdentificacionColumn };
			this.relationFK_TEmpleado_TTipoIdentificacion = new DataRelation("FK_TEmpleado_TTipoIdentificacion", dataColumnArray6, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleado_TTipoIdentificacion);
			idEmpresaColumn = new DataColumn[] { this.tableTMarcaVehiculo.idMarcaVehiculoColumn };
			DataColumn[] dataColumnArray7 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTModeloVehiculo.idMarcaVehiculoColumn };
			this.relationFK_TModeloVehiculo_MarcaVehiculo = new DataRelation("FK_TModeloVehiculo_MarcaVehiculo", dataColumnArray7, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TModeloVehiculo_MarcaVehiculo);
			idEmpresaColumn = new DataColumn[] { this.tableTipoVehiculo.idTipoVehiculoColumn };
			DataColumn[] dataColumnArray8 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTModeloVehiculo.idTipoVehiculoColumn };
			this.relationFK_TModeloVehiculo_TipoVehiculo = new DataRelation("FK_TModeloVehiculo_TipoVehiculo", dataColumnArray8, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TModeloVehiculo_TipoVehiculo);
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idEmpleadoColumn };
			DataColumn[] dataColumnArray9 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTRegistroEmpleado.idEmpleadoColumn };
			this.relationFK_TRegistroEmpleado_TEmpleado = new DataRelation("FK_TRegistroEmpleado_TEmpleado", dataColumnArray9, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TRegistroEmpleado_TEmpleado);
			idEmpresaColumn = new DataColumn[] { this.tableTTipoRegistro.idTipoRegistroColumn };
			DataColumn[] dataColumnArray10 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTRegistroEmpleado.idTipoRegistroColumn };
			this.relationFK_TRegistroEmpleado_TTipoRegistro = new DataRelation("FK_TRegistroEmpleado_TTipoRegistro", dataColumnArray10, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TRegistroEmpleado_TTipoRegistro);
			idEmpresaColumn = new DataColumn[] { this.tableTTipoRegistro.idTipoRegistroColumn };
			DataColumn[] dataColumnArray11 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTRegistroVehiculo.idTipoRegistroColumn };
			this.relationFK_TRegistroVehiculo_TTipoRegistro = new DataRelation("FK_TRegistroVehiculo_TTipoRegistro", dataColumnArray11, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TRegistroVehiculo_TTipoRegistro);
			idEmpresaColumn = new DataColumn[] { this.tableTVehiculo.idVehiculoColumn };
			DataColumn[] dataColumnArray12 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTRegistroVehiculo.idVehiculoColumn };
			this.relationFK_TRegistroVehiculo_TVehiculo = new DataRelation("FK_TRegistroVehiculo_TVehiculo", dataColumnArray12, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TRegistroVehiculo_TVehiculo);
			idEmpresaColumn = new DataColumn[] { this.tableTTipoUsuario.idTipoUsuarioColumn };
			DataColumn[] dataColumnArray13 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTUsuario.idTipoUsuarioColumn };
			this.relationFK_TUsuario_TTipoUsuario = new DataRelation("FK_TUsuario_TTipoUsuario", dataColumnArray13, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TUsuario_TTipoUsuario);
			idEmpresaColumn = new DataColumn[] { this.tableTModeloVehiculo.idModeloVehiculoColumn };
			DataColumn[] dataColumnArray14 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVehiculo.idModeloVehiculoColumn };
			this.relationFK_TVehiculo_TModeloVehiculo = new DataRelation("FK_TVehiculo_TModeloVehiculo", dataColumnArray14, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVehiculo_TModeloVehiculo);
			idEmpresaColumn = new DataColumn[] { this.tableTTipoIdentificacion.idTipoIdentificacionColumn };
			DataColumn[] dataColumnArray15 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitante.idTipoIdentificacionColumn };
			this.relationFK_TVisitante_TTipoIdentificacion = new DataRelation("FK_TVisitante_TTipoIdentificacion", dataColumnArray15, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitante_TTipoIdentificacion);
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idEmpleadoColumn };
			DataColumn[] dataColumnArray16 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitanteVisitaProgramada.idEmpleadoAutorizaEntradaColumn };
			this.relationFK_TVisitanteVisitaProgramada_TEmpleado = new DataRelation("FK_TVisitanteVisitaProgramada_TEmpleado", dataColumnArray16, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitanteVisitaProgramada_TEmpleado);
			idEmpresaColumn = new DataColumn[] { this.tableTVisitante.idVisitanteColumn };
			DataColumn[] dataColumnArray17 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitanteVisitaProgramada.idVisitanteColumn };
			this.relationFK_TVisitanteVisitaProgramada_TVisitante = new DataRelation("FK_TVisitanteVisitaProgramada_TVisitante", dataColumnArray17, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitanteVisitaProgramada_TVisitante);
			idEmpresaColumn = new DataColumn[] { this.tableTVisitaProgramada.idVisitaProgramadaColumn };
			DataColumn[] dataColumnArray18 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitanteVisitaProgramada.idVisitaProgramadaColumn };
			this.relationFK_TVisitanteVisitaProgramada_TVisitaProgramada = new DataRelation("FK_TVisitanteVisitaProgramada_TVisitaProgramada", dataColumnArray18, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitanteVisitaProgramada_TVisitaProgramada);
			idEmpresaColumn = new DataColumn[] { this.tableTTipoRegistro.idTipoRegistroColumn };
			DataColumn[] dataColumnArray19 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTRegistroVehiculo1.idTipoRegistroColumn };
			this.relationFK_TRegistroVehiculo_TTipoRegistro1 = new DataRelation("FK_TRegistroVehiculo_TTipoRegistro1", dataColumnArray19, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TRegistroVehiculo_TTipoRegistro1);
			idEmpresaColumn = new DataColumn[] { this.tableTVehiculo.idVehiculoColumn };
			DataColumn[] dataColumnArray20 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTRegistroVehiculo1.idVehiculoColumn };
			this.relationFK_TRegistroVehiculo_TVehiculo1 = new DataRelation("FK_TRegistroVehiculo_TVehiculo1", dataColumnArray20, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TRegistroVehiculo_TVehiculo1);
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idEmpleadoColumn };
			DataColumn[] dataColumnArray21 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitanteVisitaProgramadaLog.idEmpleadoAutorizaEntradaColumn };
			this.relationFK_TVisitanteVisitaProgramadaLog_TEmpleado = new DataRelation("FK_TVisitanteVisitaProgramadaLog_TEmpleado", dataColumnArray21, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitanteVisitaProgramadaLog_TEmpleado);
			idEmpresaColumn = new DataColumn[] { this.tableTVisitante.idVisitanteColumn };
			DataColumn[] dataColumnArray22 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitanteVisitaProgramadaLog.idVisitanteColumn };
			this.relationFK_TVisitanteVisitaProgramadaLog_TVisitante = new DataRelation("FK_TVisitanteVisitaProgramadaLog_TVisitante", dataColumnArray22, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitanteVisitaProgramadaLog_TVisitante);
			idEmpresaColumn = new DataColumn[] { this.tableTVisitaProgramada.idVisitaProgramadaColumn };
			DataColumn[] dataColumnArray23 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTVisitanteVisitaProgramadaLog.idVisitaProgramadaColumn };
			this.relationFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada = new DataRelation("FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada", dataColumnArray23, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada);
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleado.idEmpleadoColumn };
			DataColumn[] dataColumnArray24 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleadoVehiculo.IdEmpleadoColumn };
			this.relationFK_TEmpleadoVehiculo_TEmpleado = new DataRelation("FK_TEmpleadoVehiculo_TEmpleado", dataColumnArray24, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleadoVehiculo_TEmpleado);
			idEmpresaColumn = new DataColumn[] { this.tableTVehiculo.idVehiculoColumn };
			DataColumn[] dataColumnArray25 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTEmpleadoVehiculo.IdVehiculoColumn };
			this.relationFK_TEmpleadoVehiculo_TVehiculo = new DataRelation("FK_TEmpleadoVehiculo_TVehiculo", dataColumnArray25, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TEmpleadoVehiculo_TVehiculo);
			idEmpresaColumn = new DataColumn[] { this.tableTParqueo.idParqueaderoColumn };
			DataColumn[] dataColumnArray26 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTvehiculoParqueo.idParqueaderoColumn };
			this.relationFK_TvehiculoParqueo_Tparqueo = new DataRelation("FK_TvehiculoParqueo_Tparqueo", dataColumnArray26, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TvehiculoParqueo_Tparqueo);
			idEmpresaColumn = new DataColumn[] { this.tableTVehiculo.idVehiculoColumn };
			DataColumn[] dataColumnArray27 = idEmpresaColumn;
			idEmpresaColumn = new DataColumn[] { this.tableTvehiculoParqueo.idVehiculoColumn };
			this.relationFK_TvehiculoParqueo_TVehiculo = new DataRelation("FK_TvehiculoParqueo_TVehiculo", dataColumnArray27, idEmpresaColumn, false);
			this.Relations.Add(this.relationFK_TvehiculoParqueo_TVehiculo);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableTCargo = (masterDBACDataSet.TCargoDataTable)base.Tables["TCargo"];
			if (initTable)
			{
				if (this.tableTCargo != null)
				{
					this.tableTCargo.InitVars();
				}
			}
			this.tableTDiasHorario = (masterDBACDataSet.TDiasHorarioDataTable)base.Tables["TDiasHorario"];
			if (initTable)
			{
				if (this.tableTDiasHorario != null)
				{
					this.tableTDiasHorario.InitVars();
				}
			}
			this.tableTDivisionEmpresa = (masterDBACDataSet.TDivisionEmpresaDataTable)base.Tables["TDivisionEmpresa"];
			if (initTable)
			{
				if (this.tableTDivisionEmpresa != null)
				{
					this.tableTDivisionEmpresa.InitVars();
				}
			}
			this.tableTEmpleado = (masterDBACDataSet.TEmpleadoDataTable)base.Tables["TEmpleado"];
			if (initTable)
			{
				if (this.tableTEmpleado != null)
				{
					this.tableTEmpleado.InitVars();
				}
			}
			this.tableTEmpleadoVehiculo = (masterDBACDataSet.TEmpleadoVehiculoDataTable)base.Tables["TEmpleadoVehiculo"];
			if (initTable)
			{
				if (this.tableTEmpleadoVehiculo != null)
				{
					this.tableTEmpleadoVehiculo.InitVars();
				}
			}
			this.tableTEmpresa = (masterDBACDataSet.TEmpresaDataTable)base.Tables["TEmpresa"];
			if (initTable)
			{
				if (this.tableTEmpresa != null)
				{
					this.tableTEmpresa.InitVars();
				}
			}
			this.tableTEmpresaVisitante = (masterDBACDataSet.TEmpresaVisitanteDataTable)base.Tables["TEmpresaVisitante"];
			if (initTable)
			{
				if (this.tableTEmpresaVisitante != null)
				{
					this.tableTEmpresaVisitante.InitVars();
				}
			}
			this.tableTEstado = (masterDBACDataSet.TEstadoDataTable)base.Tables["TEstado"];
			if (initTable)
			{
				if (this.tableTEstado != null)
				{
					this.tableTEstado.InitVars();
				}
			}
			this.tableTFestivos = (masterDBACDataSet.TFestivosDataTable)base.Tables["TFestivos"];
			if (initTable)
			{
				if (this.tableTFestivos != null)
				{
					this.tableTFestivos.InitVars();
				}
			}
			this.tableTHorario = (masterDBACDataSet.THorarioDataTable)base.Tables["THorario"];
			if (initTable)
			{
				if (this.tableTHorario != null)
				{
					this.tableTHorario.InitVars();
				}
			}
			this.tableTipoVehiculo = (masterDBACDataSet.TipoVehiculoDataTable)base.Tables["TipoVehiculo"];
			if (initTable)
			{
				if (this.tableTipoVehiculo != null)
				{
					this.tableTipoVehiculo.InitVars();
				}
			}
			this.tableTMarcaVehiculo = (masterDBACDataSet.TMarcaVehiculoDataTable)base.Tables["TMarcaVehiculo"];
			if (initTable)
			{
				if (this.tableTMarcaVehiculo != null)
				{
					this.tableTMarcaVehiculo.InitVars();
				}
			}
			this.tableTModeloVehiculo = (masterDBACDataSet.TModeloVehiculoDataTable)base.Tables["TModeloVehiculo"];
			if (initTable)
			{
				if (this.tableTModeloVehiculo != null)
				{
					this.tableTModeloVehiculo.InitVars();
				}
			}
			this.tableTPanel = (masterDBACDataSet.TPanelDataTable)base.Tables["TPanel"];
			if (initTable)
			{
				if (this.tableTPanel != null)
				{
					this.tableTPanel.InitVars();
				}
			}
			this.tableTParqueo = (masterDBACDataSet.TParqueoDataTable)base.Tables["TParqueo"];
			if (initTable)
			{
				if (this.tableTParqueo != null)
				{
					this.tableTParqueo.InitVars();
				}
			}
			this.tableTRegistroEmpleado = (masterDBACDataSet.TRegistroEmpleadoDataTable)base.Tables["TRegistroEmpleado"];
			if (initTable)
			{
				if (this.tableTRegistroEmpleado != null)
				{
					this.tableTRegistroEmpleado.InitVars();
				}
			}
			this.tableTRegistroVehiculo = (masterDBACDataSet.TRegistroVehiculoDataTable)base.Tables["TRegistroVehiculo"];
			if (initTable)
			{
				if (this.tableTRegistroVehiculo != null)
				{
					this.tableTRegistroVehiculo.InitVars();
				}
			}
			this.tableTTarjeta = (masterDBACDataSet.TTarjetaDataTable)base.Tables["TTarjeta"];
			if (initTable)
			{
				if (this.tableTTarjeta != null)
				{
					this.tableTTarjeta.InitVars();
				}
			}
			this.tableTTipoIdentificacion = (masterDBACDataSet.TTipoIdentificacionDataTable)base.Tables["TTipoIdentificacion"];
			if (initTable)
			{
				if (this.tableTTipoIdentificacion != null)
				{
					this.tableTTipoIdentificacion.InitVars();
				}
			}
			this.tableTTipoRegistro = (masterDBACDataSet.TTipoRegistroDataTable)base.Tables["TTipoRegistro"];
			if (initTable)
			{
				if (this.tableTTipoRegistro != null)
				{
					this.tableTTipoRegistro.InitVars();
				}
			}
			this.tableTTipoUsuario = (masterDBACDataSet.TTipoUsuarioDataTable)base.Tables["TTipoUsuario"];
			if (initTable)
			{
				if (this.tableTTipoUsuario != null)
				{
					this.tableTTipoUsuario.InitVars();
				}
			}
			this.tableTUsuario = (masterDBACDataSet.TUsuarioDataTable)base.Tables["TUsuario"];
			if (initTable)
			{
				if (this.tableTUsuario != null)
				{
					this.tableTUsuario.InitVars();
				}
			}
			this.tableTVehiculo = (masterDBACDataSet.TVehiculoDataTable)base.Tables["TVehiculo"];
			if (initTable)
			{
				if (this.tableTVehiculo != null)
				{
					this.tableTVehiculo.InitVars();
				}
			}
			this.tableTvehiculoParqueo = (masterDBACDataSet.TvehiculoParqueoDataTable)base.Tables["TvehiculoParqueo"];
			if (initTable)
			{
				if (this.tableTvehiculoParqueo != null)
				{
					this.tableTvehiculoParqueo.InitVars();
				}
			}
			this.tableTVisitante = (masterDBACDataSet.TVisitanteDataTable)base.Tables["TVisitante"];
			if (initTable)
			{
				if (this.tableTVisitante != null)
				{
					this.tableTVisitante.InitVars();
				}
			}
			this.tableTVisitanteVisitaProgramada = (masterDBACDataSet.TVisitanteVisitaProgramadaDataTable)base.Tables["TVisitanteVisitaProgramada"];
			if (initTable)
			{
				if (this.tableTVisitanteVisitaProgramada != null)
				{
					this.tableTVisitanteVisitaProgramada.InitVars();
				}
			}
			this.tableTVisitaProgramada = (masterDBACDataSet.TVisitaProgramadaDataTable)base.Tables["TVisitaProgramada"];
			if (initTable)
			{
				if (this.tableTVisitaProgramada != null)
				{
					this.tableTVisitaProgramada.InitVars();
				}
			}
			this.tableviEmpleado = (masterDBACDataSet.viEmpleadoDataTable)base.Tables["viEmpleado"];
			if (initTable)
			{
				if (this.tableviEmpleado != null)
				{
					this.tableviEmpleado.InitVars();
				}
			}
			this.tableviParqueoVehiculo = (masterDBACDataSet.viParqueoVehiculoDataTable)base.Tables["viParqueoVehiculo"];
			if (initTable)
			{
				if (this.tableviParqueoVehiculo != null)
				{
					this.tableviParqueoVehiculo.InitVars();
				}
			}
			this.tableviVehiculo = (masterDBACDataSet.viVehiculoDataTable)base.Tables["viVehiculo"];
			if (initTable)
			{
				if (this.tableviVehiculo != null)
				{
					this.tableviVehiculo.InitVars();
				}
			}
			this.tableTinner = (masterDBACDataSet.TinnerDataTable)base.Tables["Tinner"];
			if (initTable)
			{
				if (this.tableTinner != null)
				{
					this.tableTinner.InitVars();
				}
			}
			this.tableTInnerAccion = (masterDBACDataSet.TInnerAccionDataTable)base.Tables["TInnerAccion"];
			if (initTable)
			{
				if (this.tableTInnerAccion != null)
				{
					this.tableTInnerAccion.InitVars();
				}
			}
			this.tableTMarcacion = (masterDBACDataSet.TMarcacionDataTable)base.Tables["TMarcacion"];
			if (initTable)
			{
				if (this.tableTMarcacion != null)
				{
					this.tableTMarcacion.InitVars();
				}
			}
			this.tableTRegistroVehiculo1 = (masterDBACDataSet.TRegistroVehiculo1DataTable)base.Tables["TRegistroVehiculo1"];
			if (initTable)
			{
				if (this.tableTRegistroVehiculo1 != null)
				{
					this.tableTRegistroVehiculo1.InitVars();
				}
			}
			this.tableTVisitanteVisitaProgramadaLog = (masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable)base.Tables["TVisitanteVisitaProgramadaLog"];
			if (initTable)
			{
				if (this.tableTVisitanteVisitaProgramadaLog != null)
				{
					this.tableTVisitanteVisitaProgramadaLog.InitVars();
				}
			}
			this.relationFK_TDiasHorario_THorario = this.Relations["FK_TDiasHorario_THorario"];
			this.relationFK_TDivisionEmpresa_TEmpresa = this.Relations["FK_TDivisionEmpresa_TEmpresa"];
			this.relationFK_TEmpleado_TCargo = this.Relations["FK_TEmpleado_TCargo"];
			this.relationFK_TEmpleado_TDivisionEmpresa = this.Relations["FK_TEmpleado_TDivisionEmpresa"];
			this.relationFK_TEmpleado_TEstado = this.Relations["FK_TEmpleado_TEstado"];
			this.relationFK_TEmpleado_THorario = this.Relations["FK_TEmpleado_THorario"];
			this.relationFK_TEmpleado_TTipoIdentificacion = this.Relations["FK_TEmpleado_TTipoIdentificacion"];
			this.relationFK_TModeloVehiculo_MarcaVehiculo = this.Relations["FK_TModeloVehiculo_MarcaVehiculo"];
			this.relationFK_TModeloVehiculo_TipoVehiculo = this.Relations["FK_TModeloVehiculo_TipoVehiculo"];
			this.relationFK_TRegistroEmpleado_TEmpleado = this.Relations["FK_TRegistroEmpleado_TEmpleado"];
			this.relationFK_TRegistroEmpleado_TTipoRegistro = this.Relations["FK_TRegistroEmpleado_TTipoRegistro"];
			this.relationFK_TRegistroVehiculo_TTipoRegistro = this.Relations["FK_TRegistroVehiculo_TTipoRegistro"];
			this.relationFK_TRegistroVehiculo_TVehiculo = this.Relations["FK_TRegistroVehiculo_TVehiculo"];
			this.relationFK_TUsuario_TTipoUsuario = this.Relations["FK_TUsuario_TTipoUsuario"];
			this.relationFK_TVehiculo_TModeloVehiculo = this.Relations["FK_TVehiculo_TModeloVehiculo"];
			this.relationFK_TVisitante_TTipoIdentificacion = this.Relations["FK_TVisitante_TTipoIdentificacion"];
			this.relationFK_TVisitanteVisitaProgramada_TEmpleado = this.Relations["FK_TVisitanteVisitaProgramada_TEmpleado"];
			this.relationFK_TVisitanteVisitaProgramada_TVisitante = this.Relations["FK_TVisitanteVisitaProgramada_TVisitante"];
			this.relationFK_TVisitanteVisitaProgramada_TVisitaProgramada = this.Relations["FK_TVisitanteVisitaProgramada_TVisitaProgramada"];
			this.relationFK_TRegistroVehiculo_TTipoRegistro1 = this.Relations["FK_TRegistroVehiculo_TTipoRegistro1"];
			this.relationFK_TRegistroVehiculo_TVehiculo1 = this.Relations["FK_TRegistroVehiculo_TVehiculo1"];
			this.relationFK_TVisitanteVisitaProgramadaLog_TEmpleado = this.Relations["FK_TVisitanteVisitaProgramadaLog_TEmpleado"];
			this.relationFK_TVisitanteVisitaProgramadaLog_TVisitante = this.Relations["FK_TVisitanteVisitaProgramadaLog_TVisitante"];
			this.relationFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada = this.Relations["FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada"];
			this.relationFK_TEmpleadoVehiculo_TEmpleado = this.Relations["FK_TEmpleadoVehiculo_TEmpleado"];
			this.relationFK_TEmpleadoVehiculo_TVehiculo = this.Relations["FK_TEmpleadoVehiculo_TVehiculo"];
			this.relationFK_TvehiculoParqueo_Tparqueo = this.Relations["FK_TvehiculoParqueo_Tparqueo"];
			this.relationFK_TvehiculoParqueo_TVehiculo = this.Relations["FK_TvehiculoParqueo_TVehiculo"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) != System.Data.SchemaSerializationMode.IncludeSchema)
			{
				base.ReadXml(reader);
				this.InitVars();
			}
			else
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["TCargo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TCargoDataTable(dataSet.Tables["TCargo"]));
				}
				if (dataSet.Tables["TDiasHorario"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TDiasHorarioDataTable(dataSet.Tables["TDiasHorario"]));
				}
				if (dataSet.Tables["TDivisionEmpresa"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TDivisionEmpresaDataTable(dataSet.Tables["TDivisionEmpresa"]));
				}
				if (dataSet.Tables["TEmpleado"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TEmpleadoDataTable(dataSet.Tables["TEmpleado"]));
				}
				if (dataSet.Tables["TEmpleadoVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TEmpleadoVehiculoDataTable(dataSet.Tables["TEmpleadoVehiculo"]));
				}
				if (dataSet.Tables["TEmpresa"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TEmpresaDataTable(dataSet.Tables["TEmpresa"]));
				}
				if (dataSet.Tables["TEmpresaVisitante"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TEmpresaVisitanteDataTable(dataSet.Tables["TEmpresaVisitante"]));
				}
				if (dataSet.Tables["TEstado"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TEstadoDataTable(dataSet.Tables["TEstado"]));
				}
				if (dataSet.Tables["TFestivos"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TFestivosDataTable(dataSet.Tables["TFestivos"]));
				}
				if (dataSet.Tables["THorario"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.THorarioDataTable(dataSet.Tables["THorario"]));
				}
				if (dataSet.Tables["TipoVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TipoVehiculoDataTable(dataSet.Tables["TipoVehiculo"]));
				}
				if (dataSet.Tables["TMarcaVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TMarcaVehiculoDataTable(dataSet.Tables["TMarcaVehiculo"]));
				}
				if (dataSet.Tables["TModeloVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TModeloVehiculoDataTable(dataSet.Tables["TModeloVehiculo"]));
				}
				if (dataSet.Tables["TPanel"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TPanelDataTable(dataSet.Tables["TPanel"]));
				}
				if (dataSet.Tables["TParqueo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TParqueoDataTable(dataSet.Tables["TParqueo"]));
				}
				if (dataSet.Tables["TRegistroEmpleado"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TRegistroEmpleadoDataTable(dataSet.Tables["TRegistroEmpleado"]));
				}
				if (dataSet.Tables["TRegistroVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TRegistroVehiculoDataTable(dataSet.Tables["TRegistroVehiculo"]));
				}
				if (dataSet.Tables["TTarjeta"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TTarjetaDataTable(dataSet.Tables["TTarjeta"]));
				}
				if (dataSet.Tables["TTipoIdentificacion"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TTipoIdentificacionDataTable(dataSet.Tables["TTipoIdentificacion"]));
				}
				if (dataSet.Tables["TTipoRegistro"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TTipoRegistroDataTable(dataSet.Tables["TTipoRegistro"]));
				}
				if (dataSet.Tables["TTipoUsuario"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TTipoUsuarioDataTable(dataSet.Tables["TTipoUsuario"]));
				}
				if (dataSet.Tables["TUsuario"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TUsuarioDataTable(dataSet.Tables["TUsuario"]));
				}
				if (dataSet.Tables["TVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TVehiculoDataTable(dataSet.Tables["TVehiculo"]));
				}
				if (dataSet.Tables["TvehiculoParqueo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TvehiculoParqueoDataTable(dataSet.Tables["TvehiculoParqueo"]));
				}
				if (dataSet.Tables["TVisitante"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TVisitanteDataTable(dataSet.Tables["TVisitante"]));
				}
				if (dataSet.Tables["TVisitanteVisitaProgramada"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TVisitanteVisitaProgramadaDataTable(dataSet.Tables["TVisitanteVisitaProgramada"]));
				}
				if (dataSet.Tables["TVisitaProgramada"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TVisitaProgramadaDataTable(dataSet.Tables["TVisitaProgramada"]));
				}
				if (dataSet.Tables["viEmpleado"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.viEmpleadoDataTable(dataSet.Tables["viEmpleado"]));
				}
				if (dataSet.Tables["viParqueoVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.viParqueoVehiculoDataTable(dataSet.Tables["viParqueoVehiculo"]));
				}
				if (dataSet.Tables["viVehiculo"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.viVehiculoDataTable(dataSet.Tables["viVehiculo"]));
				}
				if (dataSet.Tables["Tinner"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TinnerDataTable(dataSet.Tables["Tinner"]));
				}
				if (dataSet.Tables["TInnerAccion"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TInnerAccionDataTable(dataSet.Tables["TInnerAccion"]));
				}
				if (dataSet.Tables["TMarcacion"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TMarcacionDataTable(dataSet.Tables["TMarcacion"]));
				}
				if (dataSet.Tables["TRegistroVehiculo1"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TRegistroVehiculo1DataTable(dataSet.Tables["TRegistroVehiculo1"]));
				}
				if (dataSet.Tables["TVisitanteVisitaProgramadaLog"] != null)
				{
					base.Tables.Add(new masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable(dataSet.Tables["TVisitanteVisitaProgramadaLog"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTCargo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTDiasHorario()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTDivisionEmpresa()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTEmpleado()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTEmpleadoVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTEmpresa()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTEmpresaVisitante()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTEstado()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTFestivos()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTHorario()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTinner()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTInnerAccion()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTipoVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTMarcacion()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTMarcaVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTModeloVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTPanel()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTParqueo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTRegistroEmpleado()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTRegistroVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTRegistroVehiculo1()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTTarjeta()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTTipoIdentificacion()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTTipoRegistro()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTTipoUsuario()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTUsuario()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTvehiculoParqueo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTVisitante()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTVisitanteVisitaProgramada()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTVisitanteVisitaProgramadaLog()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeTVisitaProgramada()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeviEmpleado()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeviParqueoVehiculo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeviVehiculo()
		{
			return false;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TCargoDataTable : TypedTableBase<masterDBACDataSet.TCargoRow>
		{
			private DataColumn columnidCargo;

			private DataColumn columnNombreCargo;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idCargoColumn
			{
				get
				{
					return this.columnidCargo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TCargoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TCargoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreCargoColumn
			{
				get
				{
					return this.columnNombreCargo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TCargoDataTable()
			{
				base.TableName = "TCargo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TCargoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TCargoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTCargoRow(masterDBACDataSet.TCargoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TCargoRow AddTCargoRow(string NombreCargo, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TCargoRow tCargoRow = (masterDBACDataSet.TCargoRow)base.NewRow();
				object[] nombreCargo = new object[] { null, NombreCargo, fechaUltimaGestion, usuarioUltimaGestion };
				tCargoRow.ItemArray = nombreCargo;
				base.Rows.Add(tCargoRow);
				return tCargoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TCargoDataTable tCargoDataTable = (masterDBACDataSet.TCargoDataTable)base.Clone();
				tCargoDataTable.InitVars();
				return tCargoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TCargoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TCargoRow FindByidCargo(int idCargo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idCargo };
				return (masterDBACDataSet.TCargoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TCargoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TCargoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidCargo = new DataColumn("idCargo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCargo);
				this.columnNombreCargo = new DataColumn("NombreCargo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreCargo);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidCargo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidCargo.AutoIncrement = true;
				this.columnidCargo.AutoIncrementSeed = (long)-1;
				this.columnidCargo.AutoIncrementStep = (long)-1;
				this.columnidCargo.AllowDBNull = false;
				this.columnidCargo.ReadOnly = true;
				this.columnidCargo.Unique = true;
				this.columnNombreCargo.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidCargo = base.Columns["idCargo"];
				this.columnNombreCargo = base.Columns["NombreCargo"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TCargoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TCargoRow NewTCargoRow()
			{
				return (masterDBACDataSet.TCargoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TCargoRowChanged != null)
				{
					this.TCargoRowChanged(this, new masterDBACDataSet.TCargoRowChangeEvent((masterDBACDataSet.TCargoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TCargoRowChanging != null)
				{
					this.TCargoRowChanging(this, new masterDBACDataSet.TCargoRowChangeEvent((masterDBACDataSet.TCargoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TCargoRowDeleted != null)
				{
					this.TCargoRowDeleted(this, new masterDBACDataSet.TCargoRowChangeEvent((masterDBACDataSet.TCargoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TCargoRowDeleting != null)
				{
					this.TCargoRowDeleting(this, new masterDBACDataSet.TCargoRowChangeEvent((masterDBACDataSet.TCargoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTCargoRow(masterDBACDataSet.TCargoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TCargoRowChangeEventHandler TCargoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TCargoRowChangeEventHandler TCargoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TCargoRowChangeEventHandler TCargoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TCargoRowChangeEventHandler TCargoRowDeleting;
		}

		public class TCargoRow : DataRow
		{
			private masterDBACDataSet.TCargoDataTable tableTCargo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTCargo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TCargo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTCargo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idCargo
			{
				get
				{
					return (int)base[this.tableTCargo.idCargoColumn];
				}
				set
				{
					base[this.tableTCargo.idCargoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreCargo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTCargo.NombreCargoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreCargo' in table 'TCargo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTCargo.NombreCargoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTCargo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TCargo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTCargo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TCargoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTCargo = (masterDBACDataSet.TCargoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow[] GetTEmpleadoRows()
			{
				masterDBACDataSet.TEmpleadoRow[] tEmpleadoRowArray;
				tEmpleadoRowArray = (base.Table.ChildRelations["FK_TEmpleado_TCargo"] != null ? (masterDBACDataSet.TEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleado_TCargo"]) : new masterDBACDataSet.TEmpleadoRow[0]);
				return tEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTCargo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreCargoNull()
			{
				return base.IsNull(this.tableTCargo.NombreCargoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTCargo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTCargo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreCargoNull()
			{
				base[this.tableTCargo.NombreCargoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTCargo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TCargoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TCargoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TCargoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TCargoRowChangeEvent(masterDBACDataSet.TCargoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TCargoRowChangeEventHandler(object sender, masterDBACDataSet.TCargoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TDiasHorarioDataTable : TypedTableBase<masterDBACDataSet.TDiasHorarioRow>
		{
			private DataColumn columnidDiasHorario;

			private DataColumn columnidHorario;

			private DataColumn columndia;

			private DataColumn columnentrada;

			private DataColumn columnsalida;

			private DataColumn columnObservacionesDia;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn diaColumn
			{
				get
				{
					return this.columndia;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn entradaColumn
			{
				get
				{
					return this.columnentrada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idDiasHorarioColumn
			{
				get
				{
					return this.columnidDiasHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idHorarioColumn
			{
				get
				{
					return this.columnidHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDiasHorarioRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TDiasHorarioRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesDiaColumn
			{
				get
				{
					return this.columnObservacionesDia;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn salidaColumn
			{
				get
				{
					return this.columnsalida;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TDiasHorarioDataTable()
			{
				base.TableName = "TDiasHorario";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TDiasHorarioDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TDiasHorarioDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTDiasHorarioRow(masterDBACDataSet.TDiasHorarioRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDiasHorarioRow AddTDiasHorarioRow(masterDBACDataSet.THorarioRow parentTHorarioRowByFK_TDiasHorario_THorario, byte dia, string entrada, string salida, string ObservacionesDia, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TDiasHorarioRow tDiasHorarioRow = (masterDBACDataSet.TDiasHorarioRow)base.NewRow();
				object[] objArray = new object[] { null, null, dia, entrada, salida, ObservacionesDia, fechaUltimaGestion, usuarioUltimaGestion };
				object[] item = objArray;
				if (parentTHorarioRowByFK_TDiasHorario_THorario != null)
				{
					item[1] = parentTHorarioRowByFK_TDiasHorario_THorario[0];
				}
				tDiasHorarioRow.ItemArray = item;
				base.Rows.Add(tDiasHorarioRow);
				return tDiasHorarioRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TDiasHorarioDataTable tDiasHorarioDataTable = (masterDBACDataSet.TDiasHorarioDataTable)base.Clone();
				tDiasHorarioDataTable.InitVars();
				return tDiasHorarioDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TDiasHorarioDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDiasHorarioRow FindByidDiasHorario(int idDiasHorario)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idDiasHorario };
				return (masterDBACDataSet.TDiasHorarioRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TDiasHorarioRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TDiasHorarioDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidDiasHorario = new DataColumn("idDiasHorario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidDiasHorario);
				this.columnidHorario = new DataColumn("idHorario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidHorario);
				this.columndia = new DataColumn("dia", typeof(byte), null, MappingType.Element);
				base.Columns.Add(this.columndia);
				this.columnentrada = new DataColumn("entrada", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnentrada);
				this.columnsalida = new DataColumn("salida", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnsalida);
				this.columnObservacionesDia = new DataColumn("ObservacionesDia", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesDia);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidDiasHorario };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidDiasHorario.AutoIncrement = true;
				this.columnidDiasHorario.AutoIncrementSeed = (long)-1;
				this.columnidDiasHorario.AutoIncrementStep = (long)-1;
				this.columnidDiasHorario.AllowDBNull = false;
				this.columnidDiasHorario.ReadOnly = true;
				this.columnidDiasHorario.Unique = true;
				this.columnentrada.MaxLength = 15;
				this.columnsalida.MaxLength = 15;
				this.columnObservacionesDia.MaxLength = 2147483647;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidDiasHorario = base.Columns["idDiasHorario"];
				this.columnidHorario = base.Columns["idHorario"];
				this.columndia = base.Columns["dia"];
				this.columnentrada = base.Columns["entrada"];
				this.columnsalida = base.Columns["salida"];
				this.columnObservacionesDia = base.Columns["ObservacionesDia"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TDiasHorarioRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDiasHorarioRow NewTDiasHorarioRow()
			{
				return (masterDBACDataSet.TDiasHorarioRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TDiasHorarioRowChanged != null)
				{
					this.TDiasHorarioRowChanged(this, new masterDBACDataSet.TDiasHorarioRowChangeEvent((masterDBACDataSet.TDiasHorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TDiasHorarioRowChanging != null)
				{
					this.TDiasHorarioRowChanging(this, new masterDBACDataSet.TDiasHorarioRowChangeEvent((masterDBACDataSet.TDiasHorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TDiasHorarioRowDeleted != null)
				{
					this.TDiasHorarioRowDeleted(this, new masterDBACDataSet.TDiasHorarioRowChangeEvent((masterDBACDataSet.TDiasHorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TDiasHorarioRowDeleting != null)
				{
					this.TDiasHorarioRowDeleting(this, new masterDBACDataSet.TDiasHorarioRowChangeEvent((masterDBACDataSet.TDiasHorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTDiasHorarioRow(masterDBACDataSet.TDiasHorarioRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDiasHorarioRowChangeEventHandler TDiasHorarioRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDiasHorarioRowChangeEventHandler TDiasHorarioRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDiasHorarioRowChangeEventHandler TDiasHorarioRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDiasHorarioRowChangeEventHandler TDiasHorarioRowDeleting;
		}

		public class TDiasHorarioRow : DataRow
		{
			private masterDBACDataSet.TDiasHorarioDataTable tableTDiasHorario;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte dia
			{
				get
				{
					byte item;
					try
					{
						item = (byte)base[this.tableTDiasHorario.diaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.diaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string entrada
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTDiasHorario.entradaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'entrada' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.entradaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTDiasHorario.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idDiasHorario
			{
				get
				{
					return (int)base[this.tableTDiasHorario.idDiasHorarioColumn];
				}
				set
				{
					base[this.tableTDiasHorario.idDiasHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idHorario
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTDiasHorario.idHorarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idHorario' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.idHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesDia
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTDiasHorario.ObservacionesDiaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesDia' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.ObservacionesDiaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string salida
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTDiasHorario.salidaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'salida' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.salidaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow THorarioRow
			{
				get
				{
					masterDBACDataSet.THorarioRow parentRow = (masterDBACDataSet.THorarioRow)base.GetParentRow(base.Table.ParentRelations["FK_TDiasHorario_THorario"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TDiasHorario_THorario"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTDiasHorario.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TDiasHorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDiasHorario.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TDiasHorarioRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTDiasHorario = (masterDBACDataSet.TDiasHorarioDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdiaNull()
			{
				return base.IsNull(this.tableTDiasHorario.diaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsentradaNull()
			{
				return base.IsNull(this.tableTDiasHorario.entradaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTDiasHorario.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidHorarioNull()
			{
				return base.IsNull(this.tableTDiasHorario.idHorarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesDiaNull()
			{
				return base.IsNull(this.tableTDiasHorario.ObservacionesDiaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IssalidaNull()
			{
				return base.IsNull(this.tableTDiasHorario.salidaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTDiasHorario.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdiaNull()
			{
				base[this.tableTDiasHorario.diaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetentradaNull()
			{
				base[this.tableTDiasHorario.entradaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTDiasHorario.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidHorarioNull()
			{
				base[this.tableTDiasHorario.idHorarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesDiaNull()
			{
				base[this.tableTDiasHorario.ObservacionesDiaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetsalidaNull()
			{
				base[this.tableTDiasHorario.salidaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTDiasHorario.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TDiasHorarioRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TDiasHorarioRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDiasHorarioRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TDiasHorarioRowChangeEvent(masterDBACDataSet.TDiasHorarioRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TDiasHorarioRowChangeEventHandler(object sender, masterDBACDataSet.TDiasHorarioRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TDivisionEmpresaDataTable : TypedTableBase<masterDBACDataSet.TDivisionEmpresaRow>
		{
			private DataColumn columnIdDivisionEmpresa;

			private DataColumn columnIdEmpresa;

			private DataColumn columnNombreDivision;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnpiso;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdDivisionEmpresaColumn
			{
				get
				{
					return this.columnIdDivisionEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdEmpresaColumn
			{
				get
				{
					return this.columnIdEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TDivisionEmpresaRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreDivisionColumn
			{
				get
				{
					return this.columnNombreDivision;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn pisoColumn
			{
				get
				{
					return this.columnpiso;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TDivisionEmpresaDataTable()
			{
				base.TableName = "TDivisionEmpresa";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TDivisionEmpresaDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TDivisionEmpresaDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTDivisionEmpresaRow(masterDBACDataSet.TDivisionEmpresaRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow AddTDivisionEmpresaRow(masterDBACDataSet.TEmpresaRow parentTEmpresaRowByFK_TDivisionEmpresa_TEmpresa, string NombreDivision, DateTime fechaUltimaGestion, int usuarioUltimaGestion, string piso)
			{
				masterDBACDataSet.TDivisionEmpresaRow tDivisionEmpresaRow = (masterDBACDataSet.TDivisionEmpresaRow)base.NewRow();
				object[] nombreDivision = new object[] { null, null, NombreDivision, fechaUltimaGestion, usuarioUltimaGestion, piso };
				object[] item = nombreDivision;
				if (parentTEmpresaRowByFK_TDivisionEmpresa_TEmpresa != null)
				{
					item[1] = parentTEmpresaRowByFK_TDivisionEmpresa_TEmpresa[0];
				}
				tDivisionEmpresaRow.ItemArray = item;
				base.Rows.Add(tDivisionEmpresaRow);
				return tDivisionEmpresaRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TDivisionEmpresaDataTable tDivisionEmpresaDataTable = (masterDBACDataSet.TDivisionEmpresaDataTable)base.Clone();
				tDivisionEmpresaDataTable.InitVars();
				return tDivisionEmpresaDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TDivisionEmpresaDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow FindByIdDivisionEmpresa(int IdDivisionEmpresa)
			{
				DataRowCollection rows = base.Rows;
				object[] idDivisionEmpresa = new object[] { IdDivisionEmpresa };
				return (masterDBACDataSet.TDivisionEmpresaRow)rows.Find(idDivisionEmpresa);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TDivisionEmpresaRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TDivisionEmpresaDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnIdDivisionEmpresa = new DataColumn("IdDivisionEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdDivisionEmpresa);
				this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdEmpresa);
				this.columnNombreDivision = new DataColumn("NombreDivision", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreDivision);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnpiso = new DataColumn("piso", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpiso);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnIdDivisionEmpresa };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnIdDivisionEmpresa.AutoIncrement = true;
				this.columnIdDivisionEmpresa.AutoIncrementSeed = (long)-1;
				this.columnIdDivisionEmpresa.AutoIncrementStep = (long)-1;
				this.columnIdDivisionEmpresa.AllowDBNull = false;
				this.columnIdDivisionEmpresa.ReadOnly = true;
				this.columnIdDivisionEmpresa.Unique = true;
				this.columnNombreDivision.MaxLength = 100;
				this.columnpiso.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnIdDivisionEmpresa = base.Columns["IdDivisionEmpresa"];
				this.columnIdEmpresa = base.Columns["IdEmpresa"];
				this.columnNombreDivision = base.Columns["NombreDivision"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnpiso = base.Columns["piso"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TDivisionEmpresaRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow NewTDivisionEmpresaRow()
			{
				return (masterDBACDataSet.TDivisionEmpresaRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TDivisionEmpresaRowChanged != null)
				{
					this.TDivisionEmpresaRowChanged(this, new masterDBACDataSet.TDivisionEmpresaRowChangeEvent((masterDBACDataSet.TDivisionEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TDivisionEmpresaRowChanging != null)
				{
					this.TDivisionEmpresaRowChanging(this, new masterDBACDataSet.TDivisionEmpresaRowChangeEvent((masterDBACDataSet.TDivisionEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TDivisionEmpresaRowDeleted != null)
				{
					this.TDivisionEmpresaRowDeleted(this, new masterDBACDataSet.TDivisionEmpresaRowChangeEvent((masterDBACDataSet.TDivisionEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TDivisionEmpresaRowDeleting != null)
				{
					this.TDivisionEmpresaRowDeleting(this, new masterDBACDataSet.TDivisionEmpresaRowChangeEvent((masterDBACDataSet.TDivisionEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTDivisionEmpresaRow(masterDBACDataSet.TDivisionEmpresaRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDivisionEmpresaRowChangeEventHandler TDivisionEmpresaRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDivisionEmpresaRowChangeEventHandler TDivisionEmpresaRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDivisionEmpresaRowChangeEventHandler TDivisionEmpresaRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TDivisionEmpresaRowChangeEventHandler TDivisionEmpresaRowDeleting;
		}

		public class TDivisionEmpresaRow : DataRow
		{
			private masterDBACDataSet.TDivisionEmpresaDataTable tableTDivisionEmpresa;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTDivisionEmpresa.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TDivisionEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDivisionEmpresa.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int IdDivisionEmpresa
			{
				get
				{
					return (int)base[this.tableTDivisionEmpresa.IdDivisionEmpresaColumn];
				}
				set
				{
					base[this.tableTDivisionEmpresa.IdDivisionEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int IdEmpresa
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTDivisionEmpresa.IdEmpresaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'IdEmpresa' in table 'TDivisionEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDivisionEmpresa.IdEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreDivision
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTDivisionEmpresa.NombreDivisionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreDivision' in table 'TDivisionEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDivisionEmpresa.NombreDivisionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string piso
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTDivisionEmpresa.pisoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'piso' in table 'TDivisionEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDivisionEmpresa.pisoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaRow TEmpresaRow
			{
				get
				{
					masterDBACDataSet.TEmpresaRow parentRow = (masterDBACDataSet.TEmpresaRow)base.GetParentRow(base.Table.ParentRelations["FK_TDivisionEmpresa_TEmpresa"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TDivisionEmpresa_TEmpresa"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTDivisionEmpresa.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TDivisionEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTDivisionEmpresa.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TDivisionEmpresaRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTDivisionEmpresa = (masterDBACDataSet.TDivisionEmpresaDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow[] GetTEmpleadoRows()
			{
				masterDBACDataSet.TEmpleadoRow[] tEmpleadoRowArray;
				tEmpleadoRowArray = (base.Table.ChildRelations["FK_TEmpleado_TDivisionEmpresa"] != null ? (masterDBACDataSet.TEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleado_TDivisionEmpresa"]) : new masterDBACDataSet.TEmpleadoRow[0]);
				return tEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTDivisionEmpresa.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIdEmpresaNull()
			{
				return base.IsNull(this.tableTDivisionEmpresa.IdEmpresaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreDivisionNull()
			{
				return base.IsNull(this.tableTDivisionEmpresa.NombreDivisionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspisoNull()
			{
				return base.IsNull(this.tableTDivisionEmpresa.pisoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTDivisionEmpresa.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTDivisionEmpresa.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdEmpresaNull()
			{
				base[this.tableTDivisionEmpresa.IdEmpresaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreDivisionNull()
			{
				base[this.tableTDivisionEmpresa.NombreDivisionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpisoNull()
			{
				base[this.tableTDivisionEmpresa.pisoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTDivisionEmpresa.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TDivisionEmpresaRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TDivisionEmpresaRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TDivisionEmpresaRowChangeEvent(masterDBACDataSet.TDivisionEmpresaRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TDivisionEmpresaRowChangeEventHandler(object sender, masterDBACDataSet.TDivisionEmpresaRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TEmpleadoDataTable : TypedTableBase<masterDBACDataSet.TEmpleadoRow>
		{
			private DataColumn columnidEmpleado;

			private DataColumn columnnombre;

			private DataColumn columnidTipoIdentificacion;

			private DataColumn columnidentificacion;

			private DataColumn columnNotarjeta;

			private DataColumn columnfoto;

			private DataColumn columnidCargo;

			private DataColumn columnidTipoEstado;

			private DataColumn columnidEmpresa;

			private DataColumn columnidDivisionEmpresa;

			private DataColumn columnidHorario;

			private DataColumn columnobservaciones;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnusuarioHuella;

			private DataColumn columnidTarjeta;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fotoColumn
			{
				get
				{
					return this.columnfoto;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idCargoColumn
			{
				get
				{
					return this.columnidCargo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idDivisionEmpresaColumn
			{
				get
				{
					return this.columnidDivisionEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoColumn
			{
				get
				{
					return this.columnidEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpresaColumn
			{
				get
				{
					return this.columnidEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn identificacionColumn
			{
				get
				{
					return this.columnidentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idHorarioColumn
			{
				get
				{
					return this.columnidHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTarjetaColumn
			{
				get
				{
					return this.columnidTarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoEstadoColumn
			{
				get
				{
					return this.columnidTipoEstado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoIdentificacionColumn
			{
				get
				{
					return this.columnidTipoIdentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TEmpleadoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nombreColumn
			{
				get
				{
					return this.columnnombre;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NotarjetaColumn
			{
				get
				{
					return this.columnNotarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn observacionesColumn
			{
				get
				{
					return this.columnobservaciones;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioHuellaColumn
			{
				get
				{
					return this.columnusuarioHuella;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpleadoDataTable()
			{
				base.TableName = "TEmpleado";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpleadoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TEmpleadoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTEmpleadoRow(masterDBACDataSet.TEmpleadoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow AddTEmpleadoRow(string nombre, masterDBACDataSet.TTipoIdentificacionRow parentTTipoIdentificacionRowByFK_TEmpleado_TTipoIdentificacion, string identificacion, string Notarjeta, byte[] foto, masterDBACDataSet.TCargoRow parentTCargoRowByFK_TEmpleado_TCargo, masterDBACDataSet.TEstadoRow parentTEstadoRowByFK_TEmpleado_TEstado, int idEmpresa, masterDBACDataSet.TDivisionEmpresaRow parentTDivisionEmpresaRowByFK_TEmpleado_TDivisionEmpresa, masterDBACDataSet.THorarioRow parentTHorarioRowByFK_TEmpleado_THorario, string observaciones, DateTime fechaUltimaGestion, int usuarioUltimaGestion, string usuarioHuella, int idTarjeta)
			{
				masterDBACDataSet.TEmpleadoRow tEmpleadoRow = (masterDBACDataSet.TEmpleadoRow)base.NewRow();
				object[] objArray = new object[] { null, nombre, null, identificacion, Notarjeta, foto, null, null, idEmpresa, null, null, observaciones, fechaUltimaGestion, usuarioUltimaGestion, usuarioHuella, idTarjeta };
				object[] item = objArray;
				if (parentTTipoIdentificacionRowByFK_TEmpleado_TTipoIdentificacion != null)
				{
					item[2] = parentTTipoIdentificacionRowByFK_TEmpleado_TTipoIdentificacion[0];
				}
				if (parentTCargoRowByFK_TEmpleado_TCargo != null)
				{
					item[6] = parentTCargoRowByFK_TEmpleado_TCargo[0];
				}
				if (parentTEstadoRowByFK_TEmpleado_TEstado != null)
				{
					item[7] = parentTEstadoRowByFK_TEmpleado_TEstado[0];
				}
				if (parentTDivisionEmpresaRowByFK_TEmpleado_TDivisionEmpresa != null)
				{
					item[9] = parentTDivisionEmpresaRowByFK_TEmpleado_TDivisionEmpresa[0];
				}
				if (parentTHorarioRowByFK_TEmpleado_THorario != null)
				{
					item[10] = parentTHorarioRowByFK_TEmpleado_THorario[0];
				}
				tEmpleadoRow.ItemArray = item;
				base.Rows.Add(tEmpleadoRow);
				return tEmpleadoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TEmpleadoDataTable tEmpleadoDataTable = (masterDBACDataSet.TEmpleadoDataTable)base.Clone();
				tEmpleadoDataTable.InitVars();
				return tEmpleadoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TEmpleadoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow FindByidEmpleado(int idEmpleado)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idEmpleado };
				return (masterDBACDataSet.TEmpleadoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TEmpleadoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TEmpleadoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidEmpleado = new DataColumn("idEmpleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleado);
				this.columnnombre = new DataColumn("nombre", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnombre);
				this.columnidTipoIdentificacion = new DataColumn("idTipoIdentificacion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoIdentificacion);
				this.columnidentificacion = new DataColumn("identificacion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnidentificacion);
				this.columnNotarjeta = new DataColumn("Notarjeta", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNotarjeta);
				this.columnfoto = new DataColumn("foto", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnfoto);
				this.columnidCargo = new DataColumn("idCargo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCargo);
				this.columnidTipoEstado = new DataColumn("idTipoEstado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoEstado);
				this.columnidEmpresa = new DataColumn("idEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpresa);
				this.columnidDivisionEmpresa = new DataColumn("idDivisionEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidDivisionEmpresa);
				this.columnidHorario = new DataColumn("idHorario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidHorario);
				this.columnobservaciones = new DataColumn("observaciones", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnobservaciones);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnusuarioHuella = new DataColumn("usuarioHuella", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioHuella);
				this.columnidTarjeta = new DataColumn("idTarjeta", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTarjeta);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidEmpleado };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidEmpleado.AutoIncrement = true;
				this.columnidEmpleado.AutoIncrementSeed = (long)-1;
				this.columnidEmpleado.AutoIncrementStep = (long)-1;
				this.columnidEmpleado.AllowDBNull = false;
				this.columnidEmpleado.ReadOnly = true;
				this.columnidEmpleado.Unique = true;
				this.columnnombre.AllowDBNull = false;
				this.columnnombre.MaxLength = 70;
				this.columnidentificacion.MaxLength = 25;
				this.columnNotarjeta.MaxLength = 30;
				this.columnidTipoEstado.AllowDBNull = false;
				this.columnidEmpresa.AllowDBNull = false;
				this.columnidDivisionEmpresa.AllowDBNull = false;
				this.columnobservaciones.MaxLength = 2147483647;
				this.columnusuarioHuella.MaxLength = 10;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidEmpleado = base.Columns["idEmpleado"];
				this.columnnombre = base.Columns["nombre"];
				this.columnidTipoIdentificacion = base.Columns["idTipoIdentificacion"];
				this.columnidentificacion = base.Columns["identificacion"];
				this.columnNotarjeta = base.Columns["Notarjeta"];
				this.columnfoto = base.Columns["foto"];
				this.columnidCargo = base.Columns["idCargo"];
				this.columnidTipoEstado = base.Columns["idTipoEstado"];
				this.columnidEmpresa = base.Columns["idEmpresa"];
				this.columnidDivisionEmpresa = base.Columns["idDivisionEmpresa"];
				this.columnidHorario = base.Columns["idHorario"];
				this.columnobservaciones = base.Columns["observaciones"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnusuarioHuella = base.Columns["usuarioHuella"];
				this.columnidTarjeta = base.Columns["idTarjeta"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TEmpleadoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow NewTEmpleadoRow()
			{
				return (masterDBACDataSet.TEmpleadoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TEmpleadoRowChanged != null)
				{
					this.TEmpleadoRowChanged(this, new masterDBACDataSet.TEmpleadoRowChangeEvent((masterDBACDataSet.TEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TEmpleadoRowChanging != null)
				{
					this.TEmpleadoRowChanging(this, new masterDBACDataSet.TEmpleadoRowChangeEvent((masterDBACDataSet.TEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TEmpleadoRowDeleted != null)
				{
					this.TEmpleadoRowDeleted(this, new masterDBACDataSet.TEmpleadoRowChangeEvent((masterDBACDataSet.TEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TEmpleadoRowDeleting != null)
				{
					this.TEmpleadoRowDeleting(this, new masterDBACDataSet.TEmpleadoRowChangeEvent((masterDBACDataSet.TEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTEmpleadoRow(masterDBACDataSet.TEmpleadoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoRowChangeEventHandler TEmpleadoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoRowChangeEventHandler TEmpleadoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoRowChangeEventHandler TEmpleadoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoRowChangeEventHandler TEmpleadoRowDeleting;
		}

		public class TEmpleadoRow : DataRow
		{
			private masterDBACDataSet.TEmpleadoDataTable tableTEmpleado;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTEmpleado.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] foto
			{
				get
				{
					byte[] item;
					try
					{
						item = (byte[])base[this.tableTEmpleado.fotoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'foto' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.fotoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idCargo
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleado.idCargoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idCargo' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.idCargoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idDivisionEmpresa
			{
				get
				{
					return (int)base[this.tableTEmpleado.idDivisionEmpresaColumn];
				}
				set
				{
					base[this.tableTEmpleado.idDivisionEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleado
			{
				get
				{
					return (int)base[this.tableTEmpleado.idEmpleadoColumn];
				}
				set
				{
					base[this.tableTEmpleado.idEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpresa
			{
				get
				{
					return (int)base[this.tableTEmpleado.idEmpresaColumn];
				}
				set
				{
					base[this.tableTEmpleado.idEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string identificacion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpleado.identificacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'identificacion' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.identificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idHorario
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleado.idHorarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idHorario' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.idHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTarjeta
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleado.idTarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTarjeta' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.idTarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoEstado
			{
				get
				{
					return (int)base[this.tableTEmpleado.idTipoEstadoColumn];
				}
				set
				{
					base[this.tableTEmpleado.idTipoEstadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoIdentificacion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleado.idTipoIdentificacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoIdentificacion' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.idTipoIdentificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nombre
			{
				get
				{
					return (string)base[this.tableTEmpleado.nombreColumn];
				}
				set
				{
					base[this.tableTEmpleado.nombreColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Notarjeta
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpleado.NotarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Notarjeta' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.NotarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string observaciones
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpleado.observacionesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'observaciones' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.observacionesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TCargoRow TCargoRow
			{
				get
				{
					masterDBACDataSet.TCargoRow parentRow = (masterDBACDataSet.TCargoRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleado_TCargo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleado_TCargo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow TDivisionEmpresaRow
			{
				get
				{
					masterDBACDataSet.TDivisionEmpresaRow parentRow = (masterDBACDataSet.TDivisionEmpresaRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleado_TDivisionEmpresa"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleado_TDivisionEmpresa"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEstadoRow TEstadoRow
			{
				get
				{
					masterDBACDataSet.TEstadoRow parentRow = (masterDBACDataSet.TEstadoRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleado_TEstado"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleado_TEstado"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow THorarioRow
			{
				get
				{
					masterDBACDataSet.THorarioRow parentRow = (masterDBACDataSet.THorarioRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleado_THorario"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleado_THorario"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow TTipoIdentificacionRow
			{
				get
				{
					masterDBACDataSet.TTipoIdentificacionRow parentRow = (masterDBACDataSet.TTipoIdentificacionRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleado_TTipoIdentificacion"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleado_TTipoIdentificacion"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string usuarioHuella
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpleado.usuarioHuellaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioHuella' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.usuarioHuellaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleado.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleado.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpleadoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTEmpleado = (masterDBACDataSet.TEmpleadoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoVehiculoRow[] GetTEmpleadoVehiculoRows()
			{
				masterDBACDataSet.TEmpleadoVehiculoRow[] tEmpleadoVehiculoRowArray;
				tEmpleadoVehiculoRowArray = (base.Table.ChildRelations["FK_TEmpleadoVehiculo_TEmpleado"] != null ? (masterDBACDataSet.TEmpleadoVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleadoVehiculo_TEmpleado"]) : new masterDBACDataSet.TEmpleadoVehiculoRow[0]);
				return tEmpleadoVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow[] GetTRegistroEmpleadoRows()
			{
				masterDBACDataSet.TRegistroEmpleadoRow[] tRegistroEmpleadoRowArray;
				tRegistroEmpleadoRowArray = (base.Table.ChildRelations["FK_TRegistroEmpleado_TEmpleado"] != null ? (masterDBACDataSet.TRegistroEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TRegistroEmpleado_TEmpleado"]) : new masterDBACDataSet.TRegistroEmpleadoRow[0]);
				return tRegistroEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[] GetTVisitanteVisitaProgramadaLogRows()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[] tVisitanteVisitaProgramadaLogRowArray;
				tVisitanteVisitaProgramadaLogRowArray = (base.Table.ChildRelations["FK_TVisitanteVisitaProgramadaLog_TEmpleado"] != null ? (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitanteVisitaProgramadaLog_TEmpleado"]) : new masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[0]);
				return tVisitanteVisitaProgramadaLogRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow[] GetTVisitanteVisitaProgramadaRows()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaRow[] tVisitanteVisitaProgramadaRowArray;
				tVisitanteVisitaProgramadaRowArray = (base.Table.ChildRelations["FK_TVisitanteVisitaProgramada_TEmpleado"] != null ? (masterDBACDataSet.TVisitanteVisitaProgramadaRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitanteVisitaProgramada_TEmpleado"]) : new masterDBACDataSet.TVisitanteVisitaProgramadaRow[0]);
				return tVisitanteVisitaProgramadaRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpleado.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfotoNull()
			{
				return base.IsNull(this.tableTEmpleado.fotoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidCargoNull()
			{
				return base.IsNull(this.tableTEmpleado.idCargoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidentificacionNull()
			{
				return base.IsNull(this.tableTEmpleado.identificacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidHorarioNull()
			{
				return base.IsNull(this.tableTEmpleado.idHorarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTarjetaNull()
			{
				return base.IsNull(this.tableTEmpleado.idTarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoIdentificacionNull()
			{
				return base.IsNull(this.tableTEmpleado.idTipoIdentificacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNotarjetaNull()
			{
				return base.IsNull(this.tableTEmpleado.NotarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsobservacionesNull()
			{
				return base.IsNull(this.tableTEmpleado.observacionesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioHuellaNull()
			{
				return base.IsNull(this.tableTEmpleado.usuarioHuellaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpleado.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTEmpleado.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfotoNull()
			{
				base[this.tableTEmpleado.fotoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidCargoNull()
			{
				base[this.tableTEmpleado.idCargoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidentificacionNull()
			{
				base[this.tableTEmpleado.identificacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidHorarioNull()
			{
				base[this.tableTEmpleado.idHorarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTarjetaNull()
			{
				base[this.tableTEmpleado.idTarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoIdentificacionNull()
			{
				base[this.tableTEmpleado.idTipoIdentificacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNotarjetaNull()
			{
				base[this.tableTEmpleado.NotarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetobservacionesNull()
			{
				base[this.tableTEmpleado.observacionesColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioHuellaNull()
			{
				base[this.tableTEmpleado.usuarioHuellaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTEmpleado.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TEmpleadoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TEmpleadoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpleadoRowChangeEvent(masterDBACDataSet.TEmpleadoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TEmpleadoRowChangeEventHandler(object sender, masterDBACDataSet.TEmpleadoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TEmpleadoVehiculoDataTable : TypedTableBase<masterDBACDataSet.TEmpleadoVehiculoRow>
		{
			private DataColumn columnIdEmpleado;

			private DataColumn columnIdVehiculo;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnid;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdEmpleadoColumn
			{
				get
				{
					return this.columnIdEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdVehiculoColumn
			{
				get
				{
					return this.columnIdVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TEmpleadoVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpleadoVehiculoDataTable()
			{
				base.TableName = "TEmpleadoVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpleadoVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TEmpleadoVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTEmpleadoVehiculoRow(masterDBACDataSet.TEmpleadoVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoVehiculoRow AddTEmpleadoVehiculoRow(masterDBACDataSet.TEmpleadoRow parentTEmpleadoRowByFK_TEmpleadoVehiculo_TEmpleado, masterDBACDataSet.TVehiculoRow parentTVehiculoRowByFK_TEmpleadoVehiculo_TVehiculo, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TEmpleadoVehiculoRow tEmpleadoVehiculoRow = (masterDBACDataSet.TEmpleadoVehiculoRow)base.NewRow();
				object[] objArray = new object[] { null, null, fechaUltimaGestion, usuarioUltimaGestion, null };
				object[] item = objArray;
				if (parentTEmpleadoRowByFK_TEmpleadoVehiculo_TEmpleado != null)
				{
					item[0] = parentTEmpleadoRowByFK_TEmpleadoVehiculo_TEmpleado[0];
				}
				if (parentTVehiculoRowByFK_TEmpleadoVehiculo_TVehiculo != null)
				{
					item[1] = parentTVehiculoRowByFK_TEmpleadoVehiculo_TVehiculo[0];
				}
				tEmpleadoVehiculoRow.ItemArray = item;
				base.Rows.Add(tEmpleadoVehiculoRow);
				return tEmpleadoVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TEmpleadoVehiculoDataTable tEmpleadoVehiculoDataTable = (masterDBACDataSet.TEmpleadoVehiculoDataTable)base.Clone();
				tEmpleadoVehiculoDataTable.InitVars();
				return tEmpleadoVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TEmpleadoVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TEmpleadoVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TEmpleadoVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnIdEmpleado = new DataColumn("IdEmpleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdEmpleado);
				this.columnIdVehiculo = new DataColumn("IdVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdVehiculo);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnid };
				constraints.Add(new UniqueConstraint("Constraint2", dataColumnArray, false));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = (long)-1;
				this.columnid.AutoIncrementStep = (long)-1;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnIdEmpleado = base.Columns["IdEmpleado"];
				this.columnIdVehiculo = base.Columns["IdVehiculo"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnid = base.Columns["id"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TEmpleadoVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoVehiculoRow NewTEmpleadoVehiculoRow()
			{
				return (masterDBACDataSet.TEmpleadoVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TEmpleadoVehiculoRowChanged != null)
				{
					this.TEmpleadoVehiculoRowChanged(this, new masterDBACDataSet.TEmpleadoVehiculoRowChangeEvent((masterDBACDataSet.TEmpleadoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TEmpleadoVehiculoRowChanging != null)
				{
					this.TEmpleadoVehiculoRowChanging(this, new masterDBACDataSet.TEmpleadoVehiculoRowChangeEvent((masterDBACDataSet.TEmpleadoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TEmpleadoVehiculoRowDeleted != null)
				{
					this.TEmpleadoVehiculoRowDeleted(this, new masterDBACDataSet.TEmpleadoVehiculoRowChangeEvent((masterDBACDataSet.TEmpleadoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TEmpleadoVehiculoRowDeleting != null)
				{
					this.TEmpleadoVehiculoRowDeleting(this, new masterDBACDataSet.TEmpleadoVehiculoRowChangeEvent((masterDBACDataSet.TEmpleadoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTEmpleadoVehiculoRow(masterDBACDataSet.TEmpleadoVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoVehiculoRowChangeEventHandler TEmpleadoVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoVehiculoRowChangeEventHandler TEmpleadoVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoVehiculoRowChangeEventHandler TEmpleadoVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpleadoVehiculoRowChangeEventHandler TEmpleadoVehiculoRowDeleting;
		}

		public class TEmpleadoVehiculoRow : DataRow
		{
			private masterDBACDataSet.TEmpleadoVehiculoDataTable tableTEmpleadoVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTEmpleadoVehiculo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TEmpleadoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleadoVehiculo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.tableTEmpleadoVehiculo.idColumn];
				}
				set
				{
					base[this.tableTEmpleadoVehiculo.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int IdEmpleado
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleadoVehiculo.IdEmpleadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'IdEmpleado' in table 'TEmpleadoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleadoVehiculo.IdEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int IdVehiculo
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleadoVehiculo.IdVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'IdVehiculo' in table 'TEmpleadoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleadoVehiculo.IdVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow TEmpleadoRow
			{
				get
				{
					masterDBACDataSet.TEmpleadoRow parentRow = (masterDBACDataSet.TEmpleadoRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleadoVehiculo_TEmpleado"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleadoVehiculo_TEmpleado"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow TVehiculoRow
			{
				get
				{
					masterDBACDataSet.TVehiculoRow parentRow = (masterDBACDataSet.TVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TEmpleadoVehiculo_TVehiculo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TEmpleadoVehiculo_TVehiculo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpleadoVehiculo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TEmpleadoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpleadoVehiculo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpleadoVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTEmpleadoVehiculo = (masterDBACDataSet.TEmpleadoVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpleadoVehiculo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIdEmpleadoNull()
			{
				return base.IsNull(this.tableTEmpleadoVehiculo.IdEmpleadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIdVehiculoNull()
			{
				return base.IsNull(this.tableTEmpleadoVehiculo.IdVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpleadoVehiculo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTEmpleadoVehiculo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdEmpleadoNull()
			{
				base[this.tableTEmpleadoVehiculo.IdEmpleadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdVehiculoNull()
			{
				base[this.tableTEmpleadoVehiculo.IdVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTEmpleadoVehiculo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TEmpleadoVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TEmpleadoVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpleadoVehiculoRowChangeEvent(masterDBACDataSet.TEmpleadoVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TEmpleadoVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.TEmpleadoVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TEmpresaDataTable : TypedTableBase<masterDBACDataSet.TEmpresaRow>
		{
			private DataColumn columnidEmpresa;

			private DataColumn columnnit;

			private DataColumn columnRazonSocial;

			private DataColumn columntelefonos;

			private DataColumn columntelContactoInterno;

			private DataColumn columnEmpleadoContacto;

			private DataColumn columnObservacioneEmpresa;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnCargoContacto;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CargoContactoColumn
			{
				get
				{
					return this.columnCargoContacto;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EmpleadoContactoColumn
			{
				get
				{
					return this.columnEmpleadoContacto;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpresaColumn
			{
				get
				{
					return this.columnidEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TEmpresaRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nitColumn
			{
				get
				{
					return this.columnnit;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacioneEmpresaColumn
			{
				get
				{
					return this.columnObservacioneEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RazonSocialColumn
			{
				get
				{
					return this.columnRazonSocial;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn telContactoInternoColumn
			{
				get
				{
					return this.columntelContactoInterno;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn telefonosColumn
			{
				get
				{
					return this.columntelefonos;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpresaDataTable()
			{
				base.TableName = "TEmpresa";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpresaDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TEmpresaDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTEmpresaRow(masterDBACDataSet.TEmpresaRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaRow AddTEmpresaRow(string nit, string RazonSocial, string telefonos, string telContactoInterno, string EmpleadoContacto, string ObservacioneEmpresa, DateTime fechaUltimaGestion, int usuarioUltimaGestion, string CargoContacto)
			{
				masterDBACDataSet.TEmpresaRow tEmpresaRow = (masterDBACDataSet.TEmpresaRow)base.NewRow();
				object[] objArray = new object[] { null, nit, RazonSocial, telefonos, telContactoInterno, EmpleadoContacto, ObservacioneEmpresa, fechaUltimaGestion, usuarioUltimaGestion, CargoContacto };
				tEmpresaRow.ItemArray = objArray;
				base.Rows.Add(tEmpresaRow);
				return tEmpresaRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TEmpresaDataTable tEmpresaDataTable = (masterDBACDataSet.TEmpresaDataTable)base.Clone();
				tEmpresaDataTable.InitVars();
				return tEmpresaDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TEmpresaDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaRow FindByidEmpresa(int idEmpresa)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idEmpresa };
				return (masterDBACDataSet.TEmpresaRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TEmpresaRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TEmpresaDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidEmpresa = new DataColumn("idEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpresa);
				this.columnnit = new DataColumn("nit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnit);
				this.columnRazonSocial = new DataColumn("RazonSocial", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRazonSocial);
				this.columntelefonos = new DataColumn("telefonos", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntelefonos);
				this.columntelContactoInterno = new DataColumn("telContactoInterno", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntelContactoInterno);
				this.columnEmpleadoContacto = new DataColumn("EmpleadoContacto", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEmpleadoContacto);
				this.columnObservacioneEmpresa = new DataColumn("ObservacioneEmpresa", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacioneEmpresa);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnCargoContacto = new DataColumn("CargoContacto", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCargoContacto);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidEmpresa };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidEmpresa.AutoIncrement = true;
				this.columnidEmpresa.AutoIncrementSeed = (long)-1;
				this.columnidEmpresa.AutoIncrementStep = (long)-1;
				this.columnidEmpresa.AllowDBNull = false;
				this.columnidEmpresa.ReadOnly = true;
				this.columnidEmpresa.Unique = true;
				this.columnnit.MaxLength = 30;
				this.columnRazonSocial.MaxLength = 50;
				this.columntelefonos.MaxLength = 50;
				this.columntelContactoInterno.MaxLength = 20;
				this.columnEmpleadoContacto.MaxLength = 100;
				this.columnObservacioneEmpresa.MaxLength = 2147483647;
				this.columnCargoContacto.MaxLength = 100;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidEmpresa = base.Columns["idEmpresa"];
				this.columnnit = base.Columns["nit"];
				this.columnRazonSocial = base.Columns["RazonSocial"];
				this.columntelefonos = base.Columns["telefonos"];
				this.columntelContactoInterno = base.Columns["telContactoInterno"];
				this.columnEmpleadoContacto = base.Columns["EmpleadoContacto"];
				this.columnObservacioneEmpresa = base.Columns["ObservacioneEmpresa"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnCargoContacto = base.Columns["CargoContacto"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TEmpresaRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaRow NewTEmpresaRow()
			{
				return (masterDBACDataSet.TEmpresaRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TEmpresaRowChanged != null)
				{
					this.TEmpresaRowChanged(this, new masterDBACDataSet.TEmpresaRowChangeEvent((masterDBACDataSet.TEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TEmpresaRowChanging != null)
				{
					this.TEmpresaRowChanging(this, new masterDBACDataSet.TEmpresaRowChangeEvent((masterDBACDataSet.TEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TEmpresaRowDeleted != null)
				{
					this.TEmpresaRowDeleted(this, new masterDBACDataSet.TEmpresaRowChangeEvent((masterDBACDataSet.TEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TEmpresaRowDeleting != null)
				{
					this.TEmpresaRowDeleting(this, new masterDBACDataSet.TEmpresaRowChangeEvent((masterDBACDataSet.TEmpresaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTEmpresaRow(masterDBACDataSet.TEmpresaRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaRowChangeEventHandler TEmpresaRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaRowChangeEventHandler TEmpresaRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaRowChangeEventHandler TEmpresaRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaRowChangeEventHandler TEmpresaRowDeleting;
		}

		public class TEmpresaRow : DataRow
		{
			private masterDBACDataSet.TEmpresaDataTable tableTEmpresa;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CargoContacto
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.CargoContactoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'CargoContacto' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.CargoContactoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string EmpleadoContacto
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.EmpleadoContactoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'EmpleadoContacto' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.EmpleadoContactoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTEmpresa.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpresa
			{
				get
				{
					return (int)base[this.tableTEmpresa.idEmpresaColumn];
				}
				set
				{
					base[this.tableTEmpresa.idEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nit
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.nitColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'nit' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.nitColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacioneEmpresa
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.ObservacioneEmpresaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacioneEmpresa' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.ObservacioneEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string RazonSocial
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.RazonSocialColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'RazonSocial' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.RazonSocialColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string telContactoInterno
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.telContactoInternoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'telContactoInterno' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.telContactoInternoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string telefonos
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresa.telefonosColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'telefonos' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.telefonosColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpresa.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TEmpresa' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresa.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpresaRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTEmpresa = (masterDBACDataSet.TEmpresaDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDivisionEmpresaRow[] GetTDivisionEmpresaRows()
			{
				masterDBACDataSet.TDivisionEmpresaRow[] tDivisionEmpresaRowArray;
				tDivisionEmpresaRowArray = (base.Table.ChildRelations["FK_TDivisionEmpresa_TEmpresa"] != null ? (masterDBACDataSet.TDivisionEmpresaRow[])base.GetChildRows(base.Table.ChildRelations["FK_TDivisionEmpresa_TEmpresa"]) : new masterDBACDataSet.TDivisionEmpresaRow[0]);
				return tDivisionEmpresaRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCargoContactoNull()
			{
				return base.IsNull(this.tableTEmpresa.CargoContactoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEmpleadoContactoNull()
			{
				return base.IsNull(this.tableTEmpresa.EmpleadoContactoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpresa.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnitNull()
			{
				return base.IsNull(this.tableTEmpresa.nitColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacioneEmpresaNull()
			{
				return base.IsNull(this.tableTEmpresa.ObservacioneEmpresaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRazonSocialNull()
			{
				return base.IsNull(this.tableTEmpresa.RazonSocialColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstelContactoInternoNull()
			{
				return base.IsNull(this.tableTEmpresa.telContactoInternoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstelefonosNull()
			{
				return base.IsNull(this.tableTEmpresa.telefonosColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpresa.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCargoContactoNull()
			{
				base[this.tableTEmpresa.CargoContactoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEmpleadoContactoNull()
			{
				base[this.tableTEmpresa.EmpleadoContactoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTEmpresa.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnitNull()
			{
				base[this.tableTEmpresa.nitColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacioneEmpresaNull()
			{
				base[this.tableTEmpresa.ObservacioneEmpresaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRazonSocialNull()
			{
				base[this.tableTEmpresa.RazonSocialColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettelContactoInternoNull()
			{
				base[this.tableTEmpresa.telContactoInternoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettelefonosNull()
			{
				base[this.tableTEmpresa.telefonosColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTEmpresa.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TEmpresaRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TEmpresaRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpresaRowChangeEvent(masterDBACDataSet.TEmpresaRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TEmpresaRowChangeEventHandler(object sender, masterDBACDataSet.TEmpresaRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TEmpresaVisitanteDataTable : TypedTableBase<masterDBACDataSet.TEmpresaVisitanteRow>
		{
			private DataColumn columnidEmpresaVisitante;

			private DataColumn columnrazonSocialEV;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpresaVisitanteColumn
			{
				get
				{
					return this.columnidEmpresaVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaVisitanteRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TEmpresaVisitanteRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn razonSocialEVColumn
			{
				get
				{
					return this.columnrazonSocialEV;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpresaVisitanteDataTable()
			{
				base.TableName = "TEmpresaVisitante";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpresaVisitanteDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TEmpresaVisitanteDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTEmpresaVisitanteRow(masterDBACDataSet.TEmpresaVisitanteRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaVisitanteRow AddTEmpresaVisitanteRow(string razonSocialEV, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TEmpresaVisitanteRow tEmpresaVisitanteRow = (masterDBACDataSet.TEmpresaVisitanteRow)base.NewRow();
				object[] objArray = new object[] { null, razonSocialEV, fechaUltimaGestion, usuarioUltimaGestion };
				tEmpresaVisitanteRow.ItemArray = objArray;
				base.Rows.Add(tEmpresaVisitanteRow);
				return tEmpresaVisitanteRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TEmpresaVisitanteDataTable tEmpresaVisitanteDataTable = (masterDBACDataSet.TEmpresaVisitanteDataTable)base.Clone();
				tEmpresaVisitanteDataTable.InitVars();
				return tEmpresaVisitanteDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TEmpresaVisitanteDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaVisitanteRow FindByidEmpresaVisitante(int idEmpresaVisitante)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idEmpresaVisitante };
				return (masterDBACDataSet.TEmpresaVisitanteRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TEmpresaVisitanteRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TEmpresaVisitanteDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidEmpresaVisitante = new DataColumn("idEmpresaVisitante", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpresaVisitante);
				this.columnrazonSocialEV = new DataColumn("razonSocialEV", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnrazonSocialEV);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidEmpresaVisitante };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidEmpresaVisitante.AutoIncrement = true;
				this.columnidEmpresaVisitante.AutoIncrementSeed = (long)-1;
				this.columnidEmpresaVisitante.AutoIncrementStep = (long)-1;
				this.columnidEmpresaVisitante.AllowDBNull = false;
				this.columnidEmpresaVisitante.ReadOnly = true;
				this.columnidEmpresaVisitante.Unique = true;
				this.columnrazonSocialEV.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidEmpresaVisitante = base.Columns["idEmpresaVisitante"];
				this.columnrazonSocialEV = base.Columns["razonSocialEV"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TEmpresaVisitanteRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaVisitanteRow NewTEmpresaVisitanteRow()
			{
				return (masterDBACDataSet.TEmpresaVisitanteRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TEmpresaVisitanteRowChanged != null)
				{
					this.TEmpresaVisitanteRowChanged(this, new masterDBACDataSet.TEmpresaVisitanteRowChangeEvent((masterDBACDataSet.TEmpresaVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TEmpresaVisitanteRowChanging != null)
				{
					this.TEmpresaVisitanteRowChanging(this, new masterDBACDataSet.TEmpresaVisitanteRowChangeEvent((masterDBACDataSet.TEmpresaVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TEmpresaVisitanteRowDeleted != null)
				{
					this.TEmpresaVisitanteRowDeleted(this, new masterDBACDataSet.TEmpresaVisitanteRowChangeEvent((masterDBACDataSet.TEmpresaVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TEmpresaVisitanteRowDeleting != null)
				{
					this.TEmpresaVisitanteRowDeleting(this, new masterDBACDataSet.TEmpresaVisitanteRowChangeEvent((masterDBACDataSet.TEmpresaVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTEmpresaVisitanteRow(masterDBACDataSet.TEmpresaVisitanteRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaVisitanteRowChangeEventHandler TEmpresaVisitanteRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaVisitanteRowChangeEventHandler TEmpresaVisitanteRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaVisitanteRowChangeEventHandler TEmpresaVisitanteRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEmpresaVisitanteRowChangeEventHandler TEmpresaVisitanteRowDeleting;
		}

		public class TEmpresaVisitanteRow : DataRow
		{
			private masterDBACDataSet.TEmpresaVisitanteDataTable tableTEmpresaVisitante;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTEmpresaVisitante.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TEmpresaVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresaVisitante.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpresaVisitante
			{
				get
				{
					return (int)base[this.tableTEmpresaVisitante.idEmpresaVisitanteColumn];
				}
				set
				{
					base[this.tableTEmpresaVisitante.idEmpresaVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string razonSocialEV
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEmpresaVisitante.razonSocialEVColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'razonSocialEV' in table 'TEmpresaVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresaVisitante.razonSocialEVColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEmpresaVisitante.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TEmpresaVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEmpresaVisitante.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEmpresaVisitanteRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTEmpresaVisitante = (masterDBACDataSet.TEmpresaVisitanteDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpresaVisitante.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsrazonSocialEVNull()
			{
				return base.IsNull(this.tableTEmpresaVisitante.razonSocialEVColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTEmpresaVisitante.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTEmpresaVisitante.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetrazonSocialEVNull()
			{
				base[this.tableTEmpresaVisitante.razonSocialEVColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTEmpresaVisitante.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TEmpresaVisitanteRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TEmpresaVisitanteRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpresaVisitanteRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEmpresaVisitanteRowChangeEvent(masterDBACDataSet.TEmpresaVisitanteRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TEmpresaVisitanteRowChangeEventHandler(object sender, masterDBACDataSet.TEmpresaVisitanteRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TEstadoDataTable : TypedTableBase<masterDBACDataSet.TEstadoRow>
		{
			private DataColumn columnidTipoEstado;

			private DataColumn columnNombreEstado;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoEstadoColumn
			{
				get
				{
					return this.columnidTipoEstado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEstadoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TEstadoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreEstadoColumn
			{
				get
				{
					return this.columnNombreEstado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEstadoDataTable()
			{
				base.TableName = "TEstado";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEstadoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TEstadoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTEstadoRow(masterDBACDataSet.TEstadoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEstadoRow AddTEstadoRow(string NombreEstado, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TEstadoRow tEstadoRow = (masterDBACDataSet.TEstadoRow)base.NewRow();
				object[] nombreEstado = new object[] { null, NombreEstado, fechaUltimaGestion, usuarioUltimaGestion };
				tEstadoRow.ItemArray = nombreEstado;
				base.Rows.Add(tEstadoRow);
				return tEstadoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TEstadoDataTable tEstadoDataTable = (masterDBACDataSet.TEstadoDataTable)base.Clone();
				tEstadoDataTable.InitVars();
				return tEstadoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TEstadoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEstadoRow FindByidTipoEstado(int idTipoEstado)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTipoEstado };
				return (masterDBACDataSet.TEstadoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TEstadoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TEstadoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTipoEstado = new DataColumn("idTipoEstado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoEstado);
				this.columnNombreEstado = new DataColumn("NombreEstado", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreEstado);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTipoEstado };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTipoEstado.AutoIncrement = true;
				this.columnidTipoEstado.AutoIncrementSeed = (long)-1;
				this.columnidTipoEstado.AutoIncrementStep = (long)-1;
				this.columnidTipoEstado.AllowDBNull = false;
				this.columnidTipoEstado.ReadOnly = true;
				this.columnidTipoEstado.Unique = true;
				this.columnNombreEstado.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTipoEstado = base.Columns["idTipoEstado"];
				this.columnNombreEstado = base.Columns["NombreEstado"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TEstadoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEstadoRow NewTEstadoRow()
			{
				return (masterDBACDataSet.TEstadoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TEstadoRowChanged != null)
				{
					this.TEstadoRowChanged(this, new masterDBACDataSet.TEstadoRowChangeEvent((masterDBACDataSet.TEstadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TEstadoRowChanging != null)
				{
					this.TEstadoRowChanging(this, new masterDBACDataSet.TEstadoRowChangeEvent((masterDBACDataSet.TEstadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TEstadoRowDeleted != null)
				{
					this.TEstadoRowDeleted(this, new masterDBACDataSet.TEstadoRowChangeEvent((masterDBACDataSet.TEstadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TEstadoRowDeleting != null)
				{
					this.TEstadoRowDeleting(this, new masterDBACDataSet.TEstadoRowChangeEvent((masterDBACDataSet.TEstadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTEstadoRow(masterDBACDataSet.TEstadoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEstadoRowChangeEventHandler TEstadoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEstadoRowChangeEventHandler TEstadoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEstadoRowChangeEventHandler TEstadoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TEstadoRowChangeEventHandler TEstadoRowDeleting;
		}

		public class TEstadoRow : DataRow
		{
			private masterDBACDataSet.TEstadoDataTable tableTEstado;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTEstado.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TEstado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEstado.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoEstado
			{
				get
				{
					return (int)base[this.tableTEstado.idTipoEstadoColumn];
				}
				set
				{
					base[this.tableTEstado.idTipoEstadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreEstado
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTEstado.NombreEstadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreEstado' in table 'TEstado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEstado.NombreEstadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTEstado.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TEstado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTEstado.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TEstadoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTEstado = (masterDBACDataSet.TEstadoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow[] GetTEmpleadoRows()
			{
				masterDBACDataSet.TEmpleadoRow[] tEmpleadoRowArray;
				tEmpleadoRowArray = (base.Table.ChildRelations["FK_TEmpleado_TEstado"] != null ? (masterDBACDataSet.TEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleado_TEstado"]) : new masterDBACDataSet.TEmpleadoRow[0]);
				return tEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTEstado.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreEstadoNull()
			{
				return base.IsNull(this.tableTEstado.NombreEstadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTEstado.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTEstado.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreEstadoNull()
			{
				base[this.tableTEstado.NombreEstadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTEstado.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TEstadoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TEstadoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEstadoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TEstadoRowChangeEvent(masterDBACDataSet.TEstadoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TEstadoRowChangeEventHandler(object sender, masterDBACDataSet.TEstadoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TFestivosDataTable : TypedTableBase<masterDBACDataSet.TFestivosRow>
		{
			private DataColumn columnidFestivo;

			private DataColumn columnfechaFestivo;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaFestivoColumn
			{
				get
				{
					return this.columnfechaFestivo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idFestivoColumn
			{
				get
				{
					return this.columnidFestivo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TFestivosRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TFestivosRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TFestivosDataTable()
			{
				base.TableName = "TFestivos";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TFestivosDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TFestivosDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTFestivosRow(masterDBACDataSet.TFestivosRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TFestivosRow AddTFestivosRow(DateTime fechaFestivo)
			{
				masterDBACDataSet.TFestivosRow tFestivosRow = (masterDBACDataSet.TFestivosRow)base.NewRow();
				tFestivosRow.ItemArray = new object[] { null, fechaFestivo };
				base.Rows.Add(tFestivosRow);
				return tFestivosRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TFestivosDataTable tFestivosDataTable = (masterDBACDataSet.TFestivosDataTable)base.Clone();
				tFestivosDataTable.InitVars();
				return tFestivosDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TFestivosDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TFestivosRow FindByidFestivo(int idFestivo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idFestivo };
				return (masterDBACDataSet.TFestivosRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TFestivosRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TFestivosDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidFestivo = new DataColumn("idFestivo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidFestivo);
				this.columnfechaFestivo = new DataColumn("fechaFestivo", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaFestivo);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidFestivo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidFestivo.AutoIncrement = true;
				this.columnidFestivo.AutoIncrementSeed = (long)-1;
				this.columnidFestivo.AutoIncrementStep = (long)-1;
				this.columnidFestivo.AllowDBNull = false;
				this.columnidFestivo.ReadOnly = true;
				this.columnidFestivo.Unique = true;
				this.columnfechaFestivo.AllowDBNull = false;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidFestivo = base.Columns["idFestivo"];
				this.columnfechaFestivo = base.Columns["fechaFestivo"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TFestivosRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TFestivosRow NewTFestivosRow()
			{
				return (masterDBACDataSet.TFestivosRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TFestivosRowChanged != null)
				{
					this.TFestivosRowChanged(this, new masterDBACDataSet.TFestivosRowChangeEvent((masterDBACDataSet.TFestivosRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TFestivosRowChanging != null)
				{
					this.TFestivosRowChanging(this, new masterDBACDataSet.TFestivosRowChangeEvent((masterDBACDataSet.TFestivosRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TFestivosRowDeleted != null)
				{
					this.TFestivosRowDeleted(this, new masterDBACDataSet.TFestivosRowChangeEvent((masterDBACDataSet.TFestivosRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TFestivosRowDeleting != null)
				{
					this.TFestivosRowDeleting(this, new masterDBACDataSet.TFestivosRowChangeEvent((masterDBACDataSet.TFestivosRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTFestivosRow(masterDBACDataSet.TFestivosRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TFestivosRowChangeEventHandler TFestivosRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TFestivosRowChangeEventHandler TFestivosRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TFestivosRowChangeEventHandler TFestivosRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TFestivosRowChangeEventHandler TFestivosRowDeleting;
		}

		public class TFestivosRow : DataRow
		{
			private masterDBACDataSet.TFestivosDataTable tableTFestivos;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaFestivo
			{
				get
				{
					return (DateTime)base[this.tableTFestivos.fechaFestivoColumn];
				}
				set
				{
					base[this.tableTFestivos.fechaFestivoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idFestivo
			{
				get
				{
					return (int)base[this.tableTFestivos.idFestivoColumn];
				}
				set
				{
					base[this.tableTFestivos.idFestivoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TFestivosRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTFestivos = (masterDBACDataSet.TFestivosDataTable)base.Table;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TFestivosRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TFestivosRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TFestivosRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TFestivosRowChangeEvent(masterDBACDataSet.TFestivosRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TFestivosRowChangeEventHandler(object sender, masterDBACDataSet.TFestivosRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class THorarioDataTable : TypedTableBase<masterDBACDataSet.THorarioRow>
		{
			private DataColumn columnidHorario;

			private DataColumn columnNombreHorario;

			private DataColumn columnesMaestro;

			private DataColumn columnfechaInicio;

			private DataColumn columnfechaFin;

			private DataColumn columnObservacionesHorario;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnesPermanente;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn esMaestroColumn
			{
				get
				{
					return this.columnesMaestro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn esPermanenteColumn
			{
				get
				{
					return this.columnesPermanente;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaFinColumn
			{
				get
				{
					return this.columnfechaFin;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaInicioColumn
			{
				get
				{
					return this.columnfechaInicio;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idHorarioColumn
			{
				get
				{
					return this.columnidHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.THorarioRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreHorarioColumn
			{
				get
				{
					return this.columnNombreHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesHorarioColumn
			{
				get
				{
					return this.columnObservacionesHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public THorarioDataTable()
			{
				base.TableName = "THorario";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal THorarioDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected THorarioDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTHorarioRow(masterDBACDataSet.THorarioRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow AddTHorarioRow(string NombreHorario, bool esMaestro, DateTime fechaInicio, DateTime fechaFin, string ObservacionesHorario, DateTime fechaUltimaGestion, int usuarioUltimaGestion, bool esPermanente)
			{
				masterDBACDataSet.THorarioRow tHorarioRow = (masterDBACDataSet.THorarioRow)base.NewRow();
				object[] nombreHorario = new object[] { null, NombreHorario, esMaestro, fechaInicio, fechaFin, ObservacionesHorario, fechaUltimaGestion, usuarioUltimaGestion, esPermanente };
				tHorarioRow.ItemArray = nombreHorario;
				base.Rows.Add(tHorarioRow);
				return tHorarioRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.THorarioDataTable tHorarioDataTable = (masterDBACDataSet.THorarioDataTable)base.Clone();
				tHorarioDataTable.InitVars();
				return tHorarioDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.THorarioDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow FindByidHorario(int idHorario)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idHorario };
				return (masterDBACDataSet.THorarioRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.THorarioRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "THorarioDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidHorario = new DataColumn("idHorario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidHorario);
				this.columnNombreHorario = new DataColumn("NombreHorario", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreHorario);
				this.columnesMaestro = new DataColumn("esMaestro", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnesMaestro);
				this.columnfechaInicio = new DataColumn("fechaInicio", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaInicio);
				this.columnfechaFin = new DataColumn("fechaFin", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaFin);
				this.columnObservacionesHorario = new DataColumn("ObservacionesHorario", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesHorario);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnesPermanente = new DataColumn("esPermanente", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnesPermanente);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidHorario };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidHorario.AutoIncrement = true;
				this.columnidHorario.AutoIncrementSeed = (long)-1;
				this.columnidHorario.AutoIncrementStep = (long)-1;
				this.columnidHorario.AllowDBNull = false;
				this.columnidHorario.ReadOnly = true;
				this.columnidHorario.Unique = true;
				this.columnNombreHorario.MaxLength = 50;
				this.columnesMaestro.AllowDBNull = false;
				this.columnObservacionesHorario.MaxLength = 2147483647;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidHorario = base.Columns["idHorario"];
				this.columnNombreHorario = base.Columns["NombreHorario"];
				this.columnesMaestro = base.Columns["esMaestro"];
				this.columnfechaInicio = base.Columns["fechaInicio"];
				this.columnfechaFin = base.Columns["fechaFin"];
				this.columnObservacionesHorario = base.Columns["ObservacionesHorario"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnesPermanente = base.Columns["esPermanente"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.THorarioRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow NewTHorarioRow()
			{
				return (masterDBACDataSet.THorarioRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.THorarioRowChanged != null)
				{
					this.THorarioRowChanged(this, new masterDBACDataSet.THorarioRowChangeEvent((masterDBACDataSet.THorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.THorarioRowChanging != null)
				{
					this.THorarioRowChanging(this, new masterDBACDataSet.THorarioRowChangeEvent((masterDBACDataSet.THorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.THorarioRowDeleted != null)
				{
					this.THorarioRowDeleted(this, new masterDBACDataSet.THorarioRowChangeEvent((masterDBACDataSet.THorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.THorarioRowDeleting != null)
				{
					this.THorarioRowDeleting(this, new masterDBACDataSet.THorarioRowChangeEvent((masterDBACDataSet.THorarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTHorarioRow(masterDBACDataSet.THorarioRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.THorarioRowChangeEventHandler THorarioRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.THorarioRowChangeEventHandler THorarioRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.THorarioRowChangeEventHandler THorarioRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.THorarioRowChangeEventHandler THorarioRowDeleting;
		}

		public class THorarioRow : DataRow
		{
			private masterDBACDataSet.THorarioDataTable tableTHorario;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool esMaestro
			{
				get
				{
					return (bool)base[this.tableTHorario.esMaestroColumn];
				}
				set
				{
					base[this.tableTHorario.esMaestroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool esPermanente
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTHorario.esPermanenteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'esPermanente' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.esPermanenteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaFin
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTHorario.fechaFinColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaFin' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.fechaFinColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaInicio
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTHorario.fechaInicioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaInicio' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.fechaInicioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTHorario.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idHorario
			{
				get
				{
					return (int)base[this.tableTHorario.idHorarioColumn];
				}
				set
				{
					base[this.tableTHorario.idHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreHorario
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTHorario.NombreHorarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreHorario' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.NombreHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesHorario
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTHorario.ObservacionesHorarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesHorario' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.ObservacionesHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTHorario.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'THorario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTHorario.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal THorarioRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTHorario = (masterDBACDataSet.THorarioDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TDiasHorarioRow[] GetTDiasHorarioRows()
			{
				masterDBACDataSet.TDiasHorarioRow[] tDiasHorarioRowArray;
				tDiasHorarioRowArray = (base.Table.ChildRelations["FK_TDiasHorario_THorario"] != null ? (masterDBACDataSet.TDiasHorarioRow[])base.GetChildRows(base.Table.ChildRelations["FK_TDiasHorario_THorario"]) : new masterDBACDataSet.TDiasHorarioRow[0]);
				return tDiasHorarioRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow[] GetTEmpleadoRows()
			{
				masterDBACDataSet.TEmpleadoRow[] tEmpleadoRowArray;
				tEmpleadoRowArray = (base.Table.ChildRelations["FK_TEmpleado_THorario"] != null ? (masterDBACDataSet.TEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleado_THorario"]) : new masterDBACDataSet.TEmpleadoRow[0]);
				return tEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsesPermanenteNull()
			{
				return base.IsNull(this.tableTHorario.esPermanenteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaFinNull()
			{
				return base.IsNull(this.tableTHorario.fechaFinColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaInicioNull()
			{
				return base.IsNull(this.tableTHorario.fechaInicioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTHorario.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreHorarioNull()
			{
				return base.IsNull(this.tableTHorario.NombreHorarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesHorarioNull()
			{
				return base.IsNull(this.tableTHorario.ObservacionesHorarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTHorario.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetesPermanenteNull()
			{
				base[this.tableTHorario.esPermanenteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaFinNull()
			{
				base[this.tableTHorario.fechaFinColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaInicioNull()
			{
				base[this.tableTHorario.fechaInicioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTHorario.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreHorarioNull()
			{
				base[this.tableTHorario.NombreHorarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesHorarioNull()
			{
				base[this.tableTHorario.ObservacionesHorarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTHorario.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class THorarioRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.THorarioRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.THorarioRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public THorarioRowChangeEvent(masterDBACDataSet.THorarioRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void THorarioRowChangeEventHandler(object sender, masterDBACDataSet.THorarioRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TInnerAccionDataTable : TypedTableBase<masterDBACDataSet.TInnerAccionRow>
		{
			private DataColumn columnid;

			private DataColumn columnCodeInner;

			private DataColumn columnCodigoAccion;

			private DataColumn columnfecha;

			private DataColumn columnCumplido;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CodeInnerColumn
			{
				get
				{
					return this.columnCodeInner;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CodigoAccionColumn
			{
				get
				{
					return this.columnCodigoAccion;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CumplidoColumn
			{
				get
				{
					return this.columnCumplido;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaColumn
			{
				get
				{
					return this.columnfecha;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TInnerAccionRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TInnerAccionRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TInnerAccionDataTable()
			{
				base.TableName = "TInnerAccion";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TInnerAccionDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TInnerAccionDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTInnerAccionRow(masterDBACDataSet.TInnerAccionRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TInnerAccionRow AddTInnerAccionRow(int CodeInner, string CodigoAccion, DateTime fecha, int Cumplido)
			{
				masterDBACDataSet.TInnerAccionRow tInnerAccionRow = (masterDBACDataSet.TInnerAccionRow)base.NewRow();
				object[] codeInner = new object[] { null, CodeInner, CodigoAccion, fecha, Cumplido };
				tInnerAccionRow.ItemArray = codeInner;
				base.Rows.Add(tInnerAccionRow);
				return tInnerAccionRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TInnerAccionDataTable tInnerAccionDataTable = (masterDBACDataSet.TInnerAccionDataTable)base.Clone();
				tInnerAccionDataTable.InitVars();
				return tInnerAccionDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TInnerAccionDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TInnerAccionRow FindByid(decimal id)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { id };
				return (masterDBACDataSet.TInnerAccionRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TInnerAccionRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TInnerAccionDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnid = new DataColumn("id", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnCodeInner = new DataColumn("CodeInner", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCodeInner);
				this.columnCodigoAccion = new DataColumn("CodigoAccion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCodigoAccion);
				this.columnfecha = new DataColumn("fecha", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfecha);
				this.columnCumplido = new DataColumn("Cumplido", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCumplido);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnid };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = (long)-1;
				this.columnid.AutoIncrementStep = (long)-1;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnCodigoAccion.MaxLength = 10;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnid = base.Columns["id"];
				this.columnCodeInner = base.Columns["CodeInner"];
				this.columnCodigoAccion = base.Columns["CodigoAccion"];
				this.columnfecha = base.Columns["fecha"];
				this.columnCumplido = base.Columns["Cumplido"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TInnerAccionRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TInnerAccionRow NewTInnerAccionRow()
			{
				return (masterDBACDataSet.TInnerAccionRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TInnerAccionRowChanged != null)
				{
					this.TInnerAccionRowChanged(this, new masterDBACDataSet.TInnerAccionRowChangeEvent((masterDBACDataSet.TInnerAccionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TInnerAccionRowChanging != null)
				{
					this.TInnerAccionRowChanging(this, new masterDBACDataSet.TInnerAccionRowChangeEvent((masterDBACDataSet.TInnerAccionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TInnerAccionRowDeleted != null)
				{
					this.TInnerAccionRowDeleted(this, new masterDBACDataSet.TInnerAccionRowChangeEvent((masterDBACDataSet.TInnerAccionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TInnerAccionRowDeleting != null)
				{
					this.TInnerAccionRowDeleting(this, new masterDBACDataSet.TInnerAccionRowChangeEvent((masterDBACDataSet.TInnerAccionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTInnerAccionRow(masterDBACDataSet.TInnerAccionRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TInnerAccionRowChangeEventHandler TInnerAccionRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TInnerAccionRowChangeEventHandler TInnerAccionRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TInnerAccionRowChangeEventHandler TInnerAccionRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TInnerAccionRowChangeEventHandler TInnerAccionRowDeleting;
		}

		public class TInnerAccionRow : DataRow
		{
			private masterDBACDataSet.TInnerAccionDataTable tableTInnerAccion;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int CodeInner
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTInnerAccion.CodeInnerColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'CodeInner' in table 'TInnerAccion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTInnerAccion.CodeInnerColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CodigoAccion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTInnerAccion.CodigoAccionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'CodigoAccion' in table 'TInnerAccion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTInnerAccion.CodigoAccionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Cumplido
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTInnerAccion.CumplidoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Cumplido' in table 'TInnerAccion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTInnerAccion.CumplidoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fecha
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTInnerAccion.fechaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fecha' in table 'TInnerAccion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTInnerAccion.fechaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal id
			{
				get
				{
					return (decimal)base[this.tableTInnerAccion.idColumn];
				}
				set
				{
					base[this.tableTInnerAccion.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TInnerAccionRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTInnerAccion = (masterDBACDataSet.TInnerAccionDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCodeInnerNull()
			{
				return base.IsNull(this.tableTInnerAccion.CodeInnerColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCodigoAccionNull()
			{
				return base.IsNull(this.tableTInnerAccion.CodigoAccionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCumplidoNull()
			{
				return base.IsNull(this.tableTInnerAccion.CumplidoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaNull()
			{
				return base.IsNull(this.tableTInnerAccion.fechaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCodeInnerNull()
			{
				base[this.tableTInnerAccion.CodeInnerColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCodigoAccionNull()
			{
				base[this.tableTInnerAccion.CodigoAccionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCumplidoNull()
			{
				base[this.tableTInnerAccion.CumplidoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaNull()
			{
				base[this.tableTInnerAccion.fechaColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TInnerAccionRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TInnerAccionRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TInnerAccionRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TInnerAccionRowChangeEvent(masterDBACDataSet.TInnerAccionRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TInnerAccionRowChangeEventHandler(object sender, masterDBACDataSet.TInnerAccionRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TinnerDataTable : TypedTableBase<masterDBACDataSet.TinnerRow>
		{
			private DataColumn columnid;

			private DataColumn columnCodeInner;

			private DataColumn columnNombreInner;

			private DataColumn columnesActivo;

			private DataColumn columnesinnerNet;

			private DataColumn columnpuertoCom;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CodeInnerColumn
			{
				get
				{
					return this.columnCodeInner;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn esActivoColumn
			{
				get
				{
					return this.columnesActivo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn esinnerNetColumn
			{
				get
				{
					return this.columnesinnerNet;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TinnerRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TinnerRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreInnerColumn
			{
				get
				{
					return this.columnNombreInner;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn puertoComColumn
			{
				get
				{
					return this.columnpuertoCom;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TinnerDataTable()
			{
				base.TableName = "Tinner";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TinnerDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TinnerDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTinnerRow(masterDBACDataSet.TinnerRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TinnerRow AddTinnerRow(int CodeInner, string NombreInner, bool esActivo, bool esinnerNet, int puertoCom)
			{
				masterDBACDataSet.TinnerRow tinnerRow = (masterDBACDataSet.TinnerRow)base.NewRow();
				object[] codeInner = new object[] { null, CodeInner, NombreInner, esActivo, esinnerNet, puertoCom };
				tinnerRow.ItemArray = codeInner;
				base.Rows.Add(tinnerRow);
				return tinnerRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TinnerDataTable tinnerDataTable = (masterDBACDataSet.TinnerDataTable)base.Clone();
				tinnerDataTable.InitVars();
				return tinnerDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TinnerDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TinnerRow FindByid(int id)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { id };
				return (masterDBACDataSet.TinnerRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TinnerRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TinnerDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnCodeInner = new DataColumn("CodeInner", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCodeInner);
				this.columnNombreInner = new DataColumn("NombreInner", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreInner);
				this.columnesActivo = new DataColumn("esActivo", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnesActivo);
				this.columnesinnerNet = new DataColumn("esinnerNet", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnesinnerNet);
				this.columnpuertoCom = new DataColumn("puertoCom", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnpuertoCom);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnid };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = (long)-1;
				this.columnid.AutoIncrementStep = (long)-1;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnNombreInner.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnid = base.Columns["id"];
				this.columnCodeInner = base.Columns["CodeInner"];
				this.columnNombreInner = base.Columns["NombreInner"];
				this.columnesActivo = base.Columns["esActivo"];
				this.columnesinnerNet = base.Columns["esinnerNet"];
				this.columnpuertoCom = base.Columns["puertoCom"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TinnerRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TinnerRow NewTinnerRow()
			{
				return (masterDBACDataSet.TinnerRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TinnerRowChanged != null)
				{
					this.TinnerRowChanged(this, new masterDBACDataSet.TinnerRowChangeEvent((masterDBACDataSet.TinnerRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TinnerRowChanging != null)
				{
					this.TinnerRowChanging(this, new masterDBACDataSet.TinnerRowChangeEvent((masterDBACDataSet.TinnerRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TinnerRowDeleted != null)
				{
					this.TinnerRowDeleted(this, new masterDBACDataSet.TinnerRowChangeEvent((masterDBACDataSet.TinnerRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TinnerRowDeleting != null)
				{
					this.TinnerRowDeleting(this, new masterDBACDataSet.TinnerRowChangeEvent((masterDBACDataSet.TinnerRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTinnerRow(masterDBACDataSet.TinnerRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TinnerRowChangeEventHandler TinnerRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TinnerRowChangeEventHandler TinnerRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TinnerRowChangeEventHandler TinnerRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TinnerRowChangeEventHandler TinnerRowDeleting;
		}

		public class TinnerRow : DataRow
		{
			private masterDBACDataSet.TinnerDataTable tableTinner;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int CodeInner
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTinner.CodeInnerColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'CodeInner' in table 'Tinner' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTinner.CodeInnerColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool esActivo
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTinner.esActivoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'esActivo' in table 'Tinner' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTinner.esActivoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool esinnerNet
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTinner.esinnerNetColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'esinnerNet' in table 'Tinner' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTinner.esinnerNetColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.tableTinner.idColumn];
				}
				set
				{
					base[this.tableTinner.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreInner
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTinner.NombreInnerColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreInner' in table 'Tinner' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTinner.NombreInnerColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int puertoCom
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTinner.puertoComColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'puertoCom' in table 'Tinner' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTinner.puertoComColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TinnerRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTinner = (masterDBACDataSet.TinnerDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCodeInnerNull()
			{
				return base.IsNull(this.tableTinner.CodeInnerColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsesActivoNull()
			{
				return base.IsNull(this.tableTinner.esActivoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsesinnerNetNull()
			{
				return base.IsNull(this.tableTinner.esinnerNetColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreInnerNull()
			{
				return base.IsNull(this.tableTinner.NombreInnerColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspuertoComNull()
			{
				return base.IsNull(this.tableTinner.puertoComColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCodeInnerNull()
			{
				base[this.tableTinner.CodeInnerColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetesActivoNull()
			{
				base[this.tableTinner.esActivoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetesinnerNetNull()
			{
				base[this.tableTinner.esinnerNetColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreInnerNull()
			{
				base[this.tableTinner.NombreInnerColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpuertoComNull()
			{
				base[this.tableTinner.puertoComColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TinnerRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TinnerRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TinnerRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TinnerRowChangeEvent(masterDBACDataSet.TinnerRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TinnerRowChangeEventHandler(object sender, masterDBACDataSet.TinnerRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TipoVehiculoDataTable : TypedTableBase<masterDBACDataSet.TipoVehiculoRow>
		{
			private DataColumn columnidTipoVehiculo;

			private DataColumn columnNombreTipoVehiculo;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoVehiculoColumn
			{
				get
				{
					return this.columnidTipoVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TipoVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TipoVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreTipoVehiculoColumn
			{
				get
				{
					return this.columnNombreTipoVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TipoVehiculoDataTable()
			{
				base.TableName = "TipoVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TipoVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TipoVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTipoVehiculoRow(masterDBACDataSet.TipoVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TipoVehiculoRow AddTipoVehiculoRow(byte idTipoVehiculo, string NombreTipoVehiculo, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TipoVehiculoRow tipoVehiculoRow = (masterDBACDataSet.TipoVehiculoRow)base.NewRow();
				object[] objArray = new object[] { idTipoVehiculo, NombreTipoVehiculo, fechaUltimaGestion, usuarioUltimaGestion };
				tipoVehiculoRow.ItemArray = objArray;
				base.Rows.Add(tipoVehiculoRow);
				return tipoVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TipoVehiculoDataTable tipoVehiculoDataTable = (masterDBACDataSet.TipoVehiculoDataTable)base.Clone();
				tipoVehiculoDataTable.InitVars();
				return tipoVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TipoVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TipoVehiculoRow FindByidTipoVehiculo(byte idTipoVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTipoVehiculo };
				return (masterDBACDataSet.TipoVehiculoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TipoVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TipoVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTipoVehiculo = new DataColumn("idTipoVehiculo", typeof(byte), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoVehiculo);
				this.columnNombreTipoVehiculo = new DataColumn("NombreTipoVehiculo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreTipoVehiculo);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTipoVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTipoVehiculo.AllowDBNull = false;
				this.columnidTipoVehiculo.ReadOnly = true;
				this.columnidTipoVehiculo.Unique = true;
				this.columnNombreTipoVehiculo.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTipoVehiculo = base.Columns["idTipoVehiculo"];
				this.columnNombreTipoVehiculo = base.Columns["NombreTipoVehiculo"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TipoVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TipoVehiculoRow NewTipoVehiculoRow()
			{
				return (masterDBACDataSet.TipoVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TipoVehiculoRowChanged != null)
				{
					this.TipoVehiculoRowChanged(this, new masterDBACDataSet.TipoVehiculoRowChangeEvent((masterDBACDataSet.TipoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TipoVehiculoRowChanging != null)
				{
					this.TipoVehiculoRowChanging(this, new masterDBACDataSet.TipoVehiculoRowChangeEvent((masterDBACDataSet.TipoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TipoVehiculoRowDeleted != null)
				{
					this.TipoVehiculoRowDeleted(this, new masterDBACDataSet.TipoVehiculoRowChangeEvent((masterDBACDataSet.TipoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TipoVehiculoRowDeleting != null)
				{
					this.TipoVehiculoRowDeleting(this, new masterDBACDataSet.TipoVehiculoRowChangeEvent((masterDBACDataSet.TipoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTipoVehiculoRow(masterDBACDataSet.TipoVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TipoVehiculoRowChangeEventHandler TipoVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TipoVehiculoRowChangeEventHandler TipoVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TipoVehiculoRowChangeEventHandler TipoVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TipoVehiculoRowChangeEventHandler TipoVehiculoRowDeleting;
		}

		public class TipoVehiculoRow : DataRow
		{
			private masterDBACDataSet.TipoVehiculoDataTable tableTipoVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTipoVehiculo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TipoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTipoVehiculo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte idTipoVehiculo
			{
				get
				{
					return (byte)base[this.tableTipoVehiculo.idTipoVehiculoColumn];
				}
				set
				{
					base[this.tableTipoVehiculo.idTipoVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreTipoVehiculo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTipoVehiculo.NombreTipoVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreTipoVehiculo' in table 'TipoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTipoVehiculo.NombreTipoVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTipoVehiculo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TipoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTipoVehiculo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TipoVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTipoVehiculo = (masterDBACDataSet.TipoVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow[] GetTModeloVehiculoRows()
			{
				masterDBACDataSet.TModeloVehiculoRow[] tModeloVehiculoRowArray;
				tModeloVehiculoRowArray = (base.Table.ChildRelations["FK_TModeloVehiculo_TipoVehiculo"] != null ? (masterDBACDataSet.TModeloVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TModeloVehiculo_TipoVehiculo"]) : new masterDBACDataSet.TModeloVehiculoRow[0]);
				return tModeloVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTipoVehiculo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreTipoVehiculoNull()
			{
				return base.IsNull(this.tableTipoVehiculo.NombreTipoVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTipoVehiculo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTipoVehiculo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreTipoVehiculoNull()
			{
				base[this.tableTipoVehiculo.NombreTipoVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTipoVehiculo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TipoVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TipoVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TipoVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TipoVehiculoRowChangeEvent(masterDBACDataSet.TipoVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TipoVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.TipoVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TMarcacionDataTable : TypedTableBase<masterDBACDataSet.TMarcacionRow>
		{
			private DataColumn columnidMarcacion;

			private DataColumn columnNoTarjeta;

			private DataColumn columnfechaMarcacion;

			private DataColumn columnNoInner;

			private DataColumn columnidVisitante;

			private DataColumn columnidEmpleado;

			private DataColumn columnidVisitanteVistaP;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaMarcacionColumn
			{
				get
				{
					return this.columnfechaMarcacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoColumn
			{
				get
				{
					return this.columnidEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idMarcacionColumn
			{
				get
				{
					return this.columnidMarcacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitanteColumn
			{
				get
				{
					return this.columnidVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitanteVistaPColumn
			{
				get
				{
					return this.columnidVisitanteVistaP;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcacionRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TMarcacionRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NoInnerColumn
			{
				get
				{
					return this.columnNoInner;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NoTarjetaColumn
			{
				get
				{
					return this.columnNoTarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TMarcacionDataTable()
			{
				base.TableName = "TMarcacion";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TMarcacionDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TMarcacionDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTMarcacionRow(masterDBACDataSet.TMarcacionRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcacionRow AddTMarcacionRow(string NoTarjeta, DateTime fechaMarcacion, string NoInner, decimal idVisitante, int idEmpleado, decimal idVisitanteVistaP)
			{
				masterDBACDataSet.TMarcacionRow tMarcacionRow = (masterDBACDataSet.TMarcacionRow)base.NewRow();
				object[] noTarjeta = new object[] { null, NoTarjeta, fechaMarcacion, NoInner, idVisitante, idEmpleado, idVisitanteVistaP };
				tMarcacionRow.ItemArray = noTarjeta;
				base.Rows.Add(tMarcacionRow);
				return tMarcacionRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TMarcacionDataTable tMarcacionDataTable = (masterDBACDataSet.TMarcacionDataTable)base.Clone();
				tMarcacionDataTable.InitVars();
				return tMarcacionDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TMarcacionDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcacionRow FindByidMarcacion(decimal idMarcacion)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idMarcacion };
				return (masterDBACDataSet.TMarcacionRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TMarcacionRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TMarcacionDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidMarcacion = new DataColumn("idMarcacion", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidMarcacion);
				this.columnNoTarjeta = new DataColumn("NoTarjeta", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNoTarjeta);
				this.columnfechaMarcacion = new DataColumn("fechaMarcacion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaMarcacion);
				this.columnNoInner = new DataColumn("NoInner", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNoInner);
				this.columnidVisitante = new DataColumn("idVisitante", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitante);
				this.columnidEmpleado = new DataColumn("idEmpleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleado);
				this.columnidVisitanteVistaP = new DataColumn("idVisitanteVistaP", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitanteVistaP);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidMarcacion };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidMarcacion.AutoIncrement = true;
				this.columnidMarcacion.AutoIncrementSeed = (long)-1;
				this.columnidMarcacion.AutoIncrementStep = (long)-1;
				this.columnidMarcacion.AllowDBNull = false;
				this.columnidMarcacion.ReadOnly = true;
				this.columnidMarcacion.Unique = true;
				this.columnNoTarjeta.MaxLength = 50;
				this.columnNoInner.MaxLength = 10;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidMarcacion = base.Columns["idMarcacion"];
				this.columnNoTarjeta = base.Columns["NoTarjeta"];
				this.columnfechaMarcacion = base.Columns["fechaMarcacion"];
				this.columnNoInner = base.Columns["NoInner"];
				this.columnidVisitante = base.Columns["idVisitante"];
				this.columnidEmpleado = base.Columns["idEmpleado"];
				this.columnidVisitanteVistaP = base.Columns["idVisitanteVistaP"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TMarcacionRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcacionRow NewTMarcacionRow()
			{
				return (masterDBACDataSet.TMarcacionRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TMarcacionRowChanged != null)
				{
					this.TMarcacionRowChanged(this, new masterDBACDataSet.TMarcacionRowChangeEvent((masterDBACDataSet.TMarcacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TMarcacionRowChanging != null)
				{
					this.TMarcacionRowChanging(this, new masterDBACDataSet.TMarcacionRowChangeEvent((masterDBACDataSet.TMarcacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TMarcacionRowDeleted != null)
				{
					this.TMarcacionRowDeleted(this, new masterDBACDataSet.TMarcacionRowChangeEvent((masterDBACDataSet.TMarcacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TMarcacionRowDeleting != null)
				{
					this.TMarcacionRowDeleting(this, new masterDBACDataSet.TMarcacionRowChangeEvent((masterDBACDataSet.TMarcacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTMarcacionRow(masterDBACDataSet.TMarcacionRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcacionRowChangeEventHandler TMarcacionRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcacionRowChangeEventHandler TMarcacionRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcacionRowChangeEventHandler TMarcacionRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcacionRowChangeEventHandler TMarcacionRowDeleting;
		}

		public class TMarcacionRow : DataRow
		{
			private masterDBACDataSet.TMarcacionDataTable tableTMarcacion;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaMarcacion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTMarcacion.fechaMarcacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaMarcacion' in table 'TMarcacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcacion.fechaMarcacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleado
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTMarcacion.idEmpleadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpleado' in table 'TMarcacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcacion.idEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idMarcacion
			{
				get
				{
					return (decimal)base[this.tableTMarcacion.idMarcacionColumn];
				}
				set
				{
					base[this.tableTMarcacion.idMarcacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitante
			{
				get
				{
					decimal item;
					try
					{
						item = (decimal)base[this.tableTMarcacion.idVisitanteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idVisitante' in table 'TMarcacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcacion.idVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitanteVistaP
			{
				get
				{
					decimal item;
					try
					{
						item = (decimal)base[this.tableTMarcacion.idVisitanteVistaPColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idVisitanteVistaP' in table 'TMarcacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcacion.idVisitanteVistaPColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NoInner
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTMarcacion.NoInnerColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NoInner' in table 'TMarcacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcacion.NoInnerColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NoTarjeta
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTMarcacion.NoTarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NoTarjeta' in table 'TMarcacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcacion.NoTarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TMarcacionRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTMarcacion = (masterDBACDataSet.TMarcacionDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaMarcacionNull()
			{
				return base.IsNull(this.tableTMarcacion.fechaMarcacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpleadoNull()
			{
				return base.IsNull(this.tableTMarcacion.idEmpleadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidVisitanteNull()
			{
				return base.IsNull(this.tableTMarcacion.idVisitanteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidVisitanteVistaPNull()
			{
				return base.IsNull(this.tableTMarcacion.idVisitanteVistaPColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNoInnerNull()
			{
				return base.IsNull(this.tableTMarcacion.NoInnerColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNoTarjetaNull()
			{
				return base.IsNull(this.tableTMarcacion.NoTarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaMarcacionNull()
			{
				base[this.tableTMarcacion.fechaMarcacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpleadoNull()
			{
				base[this.tableTMarcacion.idEmpleadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidVisitanteNull()
			{
				base[this.tableTMarcacion.idVisitanteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidVisitanteVistaPNull()
			{
				base[this.tableTMarcacion.idVisitanteVistaPColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNoInnerNull()
			{
				base[this.tableTMarcacion.NoInnerColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNoTarjetaNull()
			{
				base[this.tableTMarcacion.NoTarjetaColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TMarcacionRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TMarcacionRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcacionRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TMarcacionRowChangeEvent(masterDBACDataSet.TMarcacionRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TMarcacionRowChangeEventHandler(object sender, masterDBACDataSet.TMarcacionRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TMarcaVehiculoDataTable : TypedTableBase<masterDBACDataSet.TMarcaVehiculoRow>
		{
			private DataColumn columnidMarcaVehiculo;

			private DataColumn columnNombreMarcaVehiculo;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idMarcaVehiculoColumn
			{
				get
				{
					return this.columnidMarcaVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcaVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TMarcaVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreMarcaVehiculoColumn
			{
				get
				{
					return this.columnNombreMarcaVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TMarcaVehiculoDataTable()
			{
				base.TableName = "TMarcaVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TMarcaVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TMarcaVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTMarcaVehiculoRow(masterDBACDataSet.TMarcaVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcaVehiculoRow AddTMarcaVehiculoRow(string NombreMarcaVehiculo, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TMarcaVehiculoRow tMarcaVehiculoRow = (masterDBACDataSet.TMarcaVehiculoRow)base.NewRow();
				object[] nombreMarcaVehiculo = new object[] { null, NombreMarcaVehiculo, fechaUltimaGestion, usuarioUltimaGestion };
				tMarcaVehiculoRow.ItemArray = nombreMarcaVehiculo;
				base.Rows.Add(tMarcaVehiculoRow);
				return tMarcaVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TMarcaVehiculoDataTable tMarcaVehiculoDataTable = (masterDBACDataSet.TMarcaVehiculoDataTable)base.Clone();
				tMarcaVehiculoDataTable.InitVars();
				return tMarcaVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TMarcaVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcaVehiculoRow FindByidMarcaVehiculo(short idMarcaVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idMarcaVehiculo };
				return (masterDBACDataSet.TMarcaVehiculoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TMarcaVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TMarcaVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidMarcaVehiculo = new DataColumn("idMarcaVehiculo", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnidMarcaVehiculo);
				this.columnNombreMarcaVehiculo = new DataColumn("NombreMarcaVehiculo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreMarcaVehiculo);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidMarcaVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidMarcaVehiculo.AutoIncrement = true;
				this.columnidMarcaVehiculo.AutoIncrementSeed = (long)-1;
				this.columnidMarcaVehiculo.AutoIncrementStep = (long)-1;
				this.columnidMarcaVehiculo.AllowDBNull = false;
				this.columnidMarcaVehiculo.ReadOnly = true;
				this.columnidMarcaVehiculo.Unique = true;
				this.columnNombreMarcaVehiculo.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidMarcaVehiculo = base.Columns["idMarcaVehiculo"];
				this.columnNombreMarcaVehiculo = base.Columns["NombreMarcaVehiculo"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TMarcaVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcaVehiculoRow NewTMarcaVehiculoRow()
			{
				return (masterDBACDataSet.TMarcaVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TMarcaVehiculoRowChanged != null)
				{
					this.TMarcaVehiculoRowChanged(this, new masterDBACDataSet.TMarcaVehiculoRowChangeEvent((masterDBACDataSet.TMarcaVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TMarcaVehiculoRowChanging != null)
				{
					this.TMarcaVehiculoRowChanging(this, new masterDBACDataSet.TMarcaVehiculoRowChangeEvent((masterDBACDataSet.TMarcaVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TMarcaVehiculoRowDeleted != null)
				{
					this.TMarcaVehiculoRowDeleted(this, new masterDBACDataSet.TMarcaVehiculoRowChangeEvent((masterDBACDataSet.TMarcaVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TMarcaVehiculoRowDeleting != null)
				{
					this.TMarcaVehiculoRowDeleting(this, new masterDBACDataSet.TMarcaVehiculoRowChangeEvent((masterDBACDataSet.TMarcaVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTMarcaVehiculoRow(masterDBACDataSet.TMarcaVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcaVehiculoRowChangeEventHandler TMarcaVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcaVehiculoRowChangeEventHandler TMarcaVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcaVehiculoRowChangeEventHandler TMarcaVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TMarcaVehiculoRowChangeEventHandler TMarcaVehiculoRowDeleting;
		}

		public class TMarcaVehiculoRow : DataRow
		{
			private masterDBACDataSet.TMarcaVehiculoDataTable tableTMarcaVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTMarcaVehiculo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TMarcaVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcaVehiculo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public short idMarcaVehiculo
			{
				get
				{
					return (short)base[this.tableTMarcaVehiculo.idMarcaVehiculoColumn];
				}
				set
				{
					base[this.tableTMarcaVehiculo.idMarcaVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreMarcaVehiculo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTMarcaVehiculo.NombreMarcaVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreMarcaVehiculo' in table 'TMarcaVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcaVehiculo.NombreMarcaVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTMarcaVehiculo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TMarcaVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTMarcaVehiculo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TMarcaVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTMarcaVehiculo = (masterDBACDataSet.TMarcaVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow[] GetTModeloVehiculoRows()
			{
				masterDBACDataSet.TModeloVehiculoRow[] tModeloVehiculoRowArray;
				tModeloVehiculoRowArray = (base.Table.ChildRelations["FK_TModeloVehiculo_MarcaVehiculo"] != null ? (masterDBACDataSet.TModeloVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TModeloVehiculo_MarcaVehiculo"]) : new masterDBACDataSet.TModeloVehiculoRow[0]);
				return tModeloVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTMarcaVehiculo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreMarcaVehiculoNull()
			{
				return base.IsNull(this.tableTMarcaVehiculo.NombreMarcaVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTMarcaVehiculo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTMarcaVehiculo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreMarcaVehiculoNull()
			{
				base[this.tableTMarcaVehiculo.NombreMarcaVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTMarcaVehiculo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TMarcaVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TMarcaVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcaVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TMarcaVehiculoRowChangeEvent(masterDBACDataSet.TMarcaVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TMarcaVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.TMarcaVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TModeloVehiculoDataTable : TypedTableBase<masterDBACDataSet.TModeloVehiculoRow>
		{
			private DataColumn columnidModeloVehiculo;

			private DataColumn columnidMarcaVehiculo;

			private DataColumn columnNombreModelo;

			private DataColumn columnidTipoVehiculo;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idMarcaVehiculoColumn
			{
				get
				{
					return this.columnidMarcaVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idModeloVehiculoColumn
			{
				get
				{
					return this.columnidModeloVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoVehiculoColumn
			{
				get
				{
					return this.columnidTipoVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TModeloVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreModeloColumn
			{
				get
				{
					return this.columnNombreModelo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TModeloVehiculoDataTable()
			{
				base.TableName = "TModeloVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TModeloVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TModeloVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTModeloVehiculoRow(masterDBACDataSet.TModeloVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow AddTModeloVehiculoRow(masterDBACDataSet.TMarcaVehiculoRow parentTMarcaVehiculoRowByFK_TModeloVehiculo_MarcaVehiculo, string NombreModelo, masterDBACDataSet.TipoVehiculoRow parentTipoVehiculoRowByFK_TModeloVehiculo_TipoVehiculo, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TModeloVehiculoRow tModeloVehiculoRow = (masterDBACDataSet.TModeloVehiculoRow)base.NewRow();
				object[] nombreModelo = new object[] { null, null, NombreModelo, null, fechaUltimaGestion, usuarioUltimaGestion };
				object[] item = nombreModelo;
				if (parentTMarcaVehiculoRowByFK_TModeloVehiculo_MarcaVehiculo != null)
				{
					item[1] = parentTMarcaVehiculoRowByFK_TModeloVehiculo_MarcaVehiculo[0];
				}
				if (parentTipoVehiculoRowByFK_TModeloVehiculo_TipoVehiculo != null)
				{
					item[3] = parentTipoVehiculoRowByFK_TModeloVehiculo_TipoVehiculo[0];
				}
				tModeloVehiculoRow.ItemArray = item;
				base.Rows.Add(tModeloVehiculoRow);
				return tModeloVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TModeloVehiculoDataTable tModeloVehiculoDataTable = (masterDBACDataSet.TModeloVehiculoDataTable)base.Clone();
				tModeloVehiculoDataTable.InitVars();
				return tModeloVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TModeloVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow FindByidModeloVehiculo(short idModeloVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idModeloVehiculo };
				return (masterDBACDataSet.TModeloVehiculoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TModeloVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TModeloVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidModeloVehiculo = new DataColumn("idModeloVehiculo", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnidModeloVehiculo);
				this.columnidMarcaVehiculo = new DataColumn("idMarcaVehiculo", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnidMarcaVehiculo);
				this.columnNombreModelo = new DataColumn("NombreModelo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreModelo);
				this.columnidTipoVehiculo = new DataColumn("idTipoVehiculo", typeof(byte), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoVehiculo);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidModeloVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidModeloVehiculo.AutoIncrement = true;
				this.columnidModeloVehiculo.AutoIncrementSeed = (long)-1;
				this.columnidModeloVehiculo.AutoIncrementStep = (long)-1;
				this.columnidModeloVehiculo.AllowDBNull = false;
				this.columnidModeloVehiculo.ReadOnly = true;
				this.columnidModeloVehiculo.Unique = true;
				this.columnNombreModelo.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidModeloVehiculo = base.Columns["idModeloVehiculo"];
				this.columnidMarcaVehiculo = base.Columns["idMarcaVehiculo"];
				this.columnNombreModelo = base.Columns["NombreModelo"];
				this.columnidTipoVehiculo = base.Columns["idTipoVehiculo"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TModeloVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow NewTModeloVehiculoRow()
			{
				return (masterDBACDataSet.TModeloVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TModeloVehiculoRowChanged != null)
				{
					this.TModeloVehiculoRowChanged(this, new masterDBACDataSet.TModeloVehiculoRowChangeEvent((masterDBACDataSet.TModeloVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TModeloVehiculoRowChanging != null)
				{
					this.TModeloVehiculoRowChanging(this, new masterDBACDataSet.TModeloVehiculoRowChangeEvent((masterDBACDataSet.TModeloVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TModeloVehiculoRowDeleted != null)
				{
					this.TModeloVehiculoRowDeleted(this, new masterDBACDataSet.TModeloVehiculoRowChangeEvent((masterDBACDataSet.TModeloVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TModeloVehiculoRowDeleting != null)
				{
					this.TModeloVehiculoRowDeleting(this, new masterDBACDataSet.TModeloVehiculoRowChangeEvent((masterDBACDataSet.TModeloVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTModeloVehiculoRow(masterDBACDataSet.TModeloVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TModeloVehiculoRowChangeEventHandler TModeloVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TModeloVehiculoRowChangeEventHandler TModeloVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TModeloVehiculoRowChangeEventHandler TModeloVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TModeloVehiculoRowChangeEventHandler TModeloVehiculoRowDeleting;
		}

		public class TModeloVehiculoRow : DataRow
		{
			private masterDBACDataSet.TModeloVehiculoDataTable tableTModeloVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTModeloVehiculo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TModeloVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTModeloVehiculo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public short idMarcaVehiculo
			{
				get
				{
					short item;
					try
					{
						item = (short)base[this.tableTModeloVehiculo.idMarcaVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idMarcaVehiculo' in table 'TModeloVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTModeloVehiculo.idMarcaVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public short idModeloVehiculo
			{
				get
				{
					return (short)base[this.tableTModeloVehiculo.idModeloVehiculoColumn];
				}
				set
				{
					base[this.tableTModeloVehiculo.idModeloVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte idTipoVehiculo
			{
				get
				{
					byte item;
					try
					{
						item = (byte)base[this.tableTModeloVehiculo.idTipoVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoVehiculo' in table 'TModeloVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTModeloVehiculo.idTipoVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreModelo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTModeloVehiculo.NombreModeloColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreModelo' in table 'TModeloVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTModeloVehiculo.NombreModeloColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TipoVehiculoRow TipoVehiculoRow
			{
				get
				{
					masterDBACDataSet.TipoVehiculoRow parentRow = (masterDBACDataSet.TipoVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TModeloVehiculo_TipoVehiculo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TModeloVehiculo_TipoVehiculo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TMarcaVehiculoRow TMarcaVehiculoRow
			{
				get
				{
					masterDBACDataSet.TMarcaVehiculoRow parentRow = (masterDBACDataSet.TMarcaVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TModeloVehiculo_MarcaVehiculo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TModeloVehiculo_MarcaVehiculo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTModeloVehiculo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TModeloVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTModeloVehiculo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TModeloVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTModeloVehiculo = (masterDBACDataSet.TModeloVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow[] GetTVehiculoRows()
			{
				masterDBACDataSet.TVehiculoRow[] tVehiculoRowArray;
				tVehiculoRowArray = (base.Table.ChildRelations["FK_TVehiculo_TModeloVehiculo"] != null ? (masterDBACDataSet.TVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVehiculo_TModeloVehiculo"]) : new masterDBACDataSet.TVehiculoRow[0]);
				return tVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTModeloVehiculo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidMarcaVehiculoNull()
			{
				return base.IsNull(this.tableTModeloVehiculo.idMarcaVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoVehiculoNull()
			{
				return base.IsNull(this.tableTModeloVehiculo.idTipoVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreModeloNull()
			{
				return base.IsNull(this.tableTModeloVehiculo.NombreModeloColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTModeloVehiculo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTModeloVehiculo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidMarcaVehiculoNull()
			{
				base[this.tableTModeloVehiculo.idMarcaVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoVehiculoNull()
			{
				base[this.tableTModeloVehiculo.idTipoVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreModeloNull()
			{
				base[this.tableTModeloVehiculo.NombreModeloColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTModeloVehiculo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TModeloVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TModeloVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TModeloVehiculoRowChangeEvent(masterDBACDataSet.TModeloVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TModeloVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.TModeloVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TPanelDataTable : TypedTableBase<masterDBACDataSet.TPanelRow>
		{
			private DataColumn columnidPanel;

			private DataColumn columndescrpcionPanel;

			private DataColumn columndireccionIP;

			private DataColumn columnpuertoPanel;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn descrpcionPanelColumn
			{
				get
				{
					return this.columndescrpcionPanel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn direccionIPColumn
			{
				get
				{
					return this.columndireccionIP;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idPanelColumn
			{
				get
				{
					return this.columnidPanel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TPanelRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TPanelRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn puertoPanelColumn
			{
				get
				{
					return this.columnpuertoPanel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TPanelDataTable()
			{
				base.TableName = "TPanel";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TPanelDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TPanelDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTPanelRow(masterDBACDataSet.TPanelRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TPanelRow AddTPanelRow(string descrpcionPanel, string direccionIP, string puertoPanel)
			{
				masterDBACDataSet.TPanelRow tPanelRow = (masterDBACDataSet.TPanelRow)base.NewRow();
				object[] objArray = new object[] { null, descrpcionPanel, direccionIP, puertoPanel };
				tPanelRow.ItemArray = objArray;
				base.Rows.Add(tPanelRow);
				return tPanelRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TPanelDataTable tPanelDataTable = (masterDBACDataSet.TPanelDataTable)base.Clone();
				tPanelDataTable.InitVars();
				return tPanelDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TPanelDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TPanelRow FindByidPanel(int idPanel)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idPanel };
				return (masterDBACDataSet.TPanelRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TPanelRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TPanelDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidPanel = new DataColumn("idPanel", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidPanel);
				this.columndescrpcionPanel = new DataColumn("descrpcionPanel", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndescrpcionPanel);
				this.columndireccionIP = new DataColumn("direccionIP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndireccionIP);
				this.columnpuertoPanel = new DataColumn("puertoPanel", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpuertoPanel);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidPanel };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidPanel.AutoIncrement = true;
				this.columnidPanel.AutoIncrementSeed = (long)-1;
				this.columnidPanel.AutoIncrementStep = (long)-1;
				this.columnidPanel.AllowDBNull = false;
				this.columnidPanel.ReadOnly = true;
				this.columnidPanel.Unique = true;
				this.columndescrpcionPanel.MaxLength = 50;
				this.columndireccionIP.MaxLength = 20;
				this.columnpuertoPanel.MaxLength = 20;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidPanel = base.Columns["idPanel"];
				this.columndescrpcionPanel = base.Columns["descrpcionPanel"];
				this.columndireccionIP = base.Columns["direccionIP"];
				this.columnpuertoPanel = base.Columns["puertoPanel"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TPanelRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TPanelRow NewTPanelRow()
			{
				return (masterDBACDataSet.TPanelRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TPanelRowChanged != null)
				{
					this.TPanelRowChanged(this, new masterDBACDataSet.TPanelRowChangeEvent((masterDBACDataSet.TPanelRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TPanelRowChanging != null)
				{
					this.TPanelRowChanging(this, new masterDBACDataSet.TPanelRowChangeEvent((masterDBACDataSet.TPanelRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TPanelRowDeleted != null)
				{
					this.TPanelRowDeleted(this, new masterDBACDataSet.TPanelRowChangeEvent((masterDBACDataSet.TPanelRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TPanelRowDeleting != null)
				{
					this.TPanelRowDeleting(this, new masterDBACDataSet.TPanelRowChangeEvent((masterDBACDataSet.TPanelRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTPanelRow(masterDBACDataSet.TPanelRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TPanelRowChangeEventHandler TPanelRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TPanelRowChangeEventHandler TPanelRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TPanelRowChangeEventHandler TPanelRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TPanelRowChangeEventHandler TPanelRowDeleting;
		}

		public class TPanelRow : DataRow
		{
			private masterDBACDataSet.TPanelDataTable tableTPanel;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string descrpcionPanel
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTPanel.descrpcionPanelColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'descrpcionPanel' in table 'TPanel' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTPanel.descrpcionPanelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string direccionIP
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTPanel.direccionIPColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'direccionIP' in table 'TPanel' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTPanel.direccionIPColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idPanel
			{
				get
				{
					return (int)base[this.tableTPanel.idPanelColumn];
				}
				set
				{
					base[this.tableTPanel.idPanelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string puertoPanel
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTPanel.puertoPanelColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'puertoPanel' in table 'TPanel' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTPanel.puertoPanelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TPanelRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTPanel = (masterDBACDataSet.TPanelDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdescrpcionPanelNull()
			{
				return base.IsNull(this.tableTPanel.descrpcionPanelColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdireccionIPNull()
			{
				return base.IsNull(this.tableTPanel.direccionIPColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspuertoPanelNull()
			{
				return base.IsNull(this.tableTPanel.puertoPanelColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdescrpcionPanelNull()
			{
				base[this.tableTPanel.descrpcionPanelColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdireccionIPNull()
			{
				base[this.tableTPanel.direccionIPColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpuertoPanelNull()
			{
				base[this.tableTPanel.puertoPanelColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TPanelRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TPanelRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TPanelRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TPanelRowChangeEvent(masterDBACDataSet.TPanelRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TPanelRowChangeEventHandler(object sender, masterDBACDataSet.TPanelRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TParqueoDataTable : TypedTableBase<masterDBACDataSet.TParqueoRow>
		{
			private DataColumn columnidParqueadero;

			private DataColumn columnnParqueo;

			private DataColumn columnobservacionesParqueo;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnestaocupado;

			private DataColumn columnocupadopor;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn estaocupadoColumn
			{
				get
				{
					return this.columnestaocupado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idParqueaderoColumn
			{
				get
				{
					return this.columnidParqueadero;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TParqueoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TParqueoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nParqueoColumn
			{
				get
				{
					return this.columnnParqueo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn observacionesParqueoColumn
			{
				get
				{
					return this.columnobservacionesParqueo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ocupadoporColumn
			{
				get
				{
					return this.columnocupadopor;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TParqueoDataTable()
			{
				base.TableName = "TParqueo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TParqueoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TParqueoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTParqueoRow(masterDBACDataSet.TParqueoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TParqueoRow AddTParqueoRow(string nParqueo, string observacionesParqueo, DateTime fechaUltimaGestion, int usuarioUltimaGestion, bool estaocupado, string ocupadopor)
			{
				masterDBACDataSet.TParqueoRow tParqueoRow = (masterDBACDataSet.TParqueoRow)base.NewRow();
				object[] objArray = new object[] { null, nParqueo, observacionesParqueo, fechaUltimaGestion, usuarioUltimaGestion, estaocupado, ocupadopor };
				tParqueoRow.ItemArray = objArray;
				base.Rows.Add(tParqueoRow);
				return tParqueoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TParqueoDataTable tParqueoDataTable = (masterDBACDataSet.TParqueoDataTable)base.Clone();
				tParqueoDataTable.InitVars();
				return tParqueoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TParqueoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TParqueoRow FindByidParqueadero(int idParqueadero)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idParqueadero };
				return (masterDBACDataSet.TParqueoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TParqueoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TParqueoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidParqueadero = new DataColumn("idParqueadero", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParqueadero);
				this.columnnParqueo = new DataColumn("nParqueo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnParqueo);
				this.columnobservacionesParqueo = new DataColumn("observacionesParqueo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnobservacionesParqueo);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnestaocupado = new DataColumn("estaocupado", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnestaocupado);
				this.columnocupadopor = new DataColumn("ocupadopor", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnocupadopor);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidParqueadero };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidParqueadero.AutoIncrement = true;
				this.columnidParqueadero.AutoIncrementSeed = (long)-1;
				this.columnidParqueadero.AutoIncrementStep = (long)-1;
				this.columnidParqueadero.AllowDBNull = false;
				this.columnidParqueadero.ReadOnly = true;
				this.columnidParqueadero.Unique = true;
				this.columnnParqueo.MaxLength = 30;
				this.columnobservacionesParqueo.MaxLength = 50;
				this.columnocupadopor.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidParqueadero = base.Columns["idParqueadero"];
				this.columnnParqueo = base.Columns["nParqueo"];
				this.columnobservacionesParqueo = base.Columns["observacionesParqueo"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnestaocupado = base.Columns["estaocupado"];
				this.columnocupadopor = base.Columns["ocupadopor"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TParqueoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TParqueoRow NewTParqueoRow()
			{
				return (masterDBACDataSet.TParqueoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TParqueoRowChanged != null)
				{
					this.TParqueoRowChanged(this, new masterDBACDataSet.TParqueoRowChangeEvent((masterDBACDataSet.TParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TParqueoRowChanging != null)
				{
					this.TParqueoRowChanging(this, new masterDBACDataSet.TParqueoRowChangeEvent((masterDBACDataSet.TParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TParqueoRowDeleted != null)
				{
					this.TParqueoRowDeleted(this, new masterDBACDataSet.TParqueoRowChangeEvent((masterDBACDataSet.TParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TParqueoRowDeleting != null)
				{
					this.TParqueoRowDeleting(this, new masterDBACDataSet.TParqueoRowChangeEvent((masterDBACDataSet.TParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTParqueoRow(masterDBACDataSet.TParqueoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TParqueoRowChangeEventHandler TParqueoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TParqueoRowChangeEventHandler TParqueoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TParqueoRowChangeEventHandler TParqueoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TParqueoRowChangeEventHandler TParqueoRowDeleting;
		}

		public class TParqueoRow : DataRow
		{
			private masterDBACDataSet.TParqueoDataTable tableTParqueo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool estaocupado
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTParqueo.estaocupadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'estaocupado' in table 'TParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTParqueo.estaocupadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTParqueo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTParqueo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idParqueadero
			{
				get
				{
					return (int)base[this.tableTParqueo.idParqueaderoColumn];
				}
				set
				{
					base[this.tableTParqueo.idParqueaderoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nParqueo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTParqueo.nParqueoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'nParqueo' in table 'TParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTParqueo.nParqueoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string observacionesParqueo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTParqueo.observacionesParqueoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'observacionesParqueo' in table 'TParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTParqueo.observacionesParqueoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ocupadopor
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTParqueo.ocupadoporColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ocupadopor' in table 'TParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTParqueo.ocupadoporColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTParqueo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTParqueo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TParqueoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTParqueo = (masterDBACDataSet.TParqueoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TvehiculoParqueoRow[] GetTvehiculoParqueoRows()
			{
				masterDBACDataSet.TvehiculoParqueoRow[] tvehiculoParqueoRowArray;
				tvehiculoParqueoRowArray = (base.Table.ChildRelations["FK_TvehiculoParqueo_Tparqueo"] != null ? (masterDBACDataSet.TvehiculoParqueoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TvehiculoParqueo_Tparqueo"]) : new masterDBACDataSet.TvehiculoParqueoRow[0]);
				return tvehiculoParqueoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsestaocupadoNull()
			{
				return base.IsNull(this.tableTParqueo.estaocupadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTParqueo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnParqueoNull()
			{
				return base.IsNull(this.tableTParqueo.nParqueoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsobservacionesParqueoNull()
			{
				return base.IsNull(this.tableTParqueo.observacionesParqueoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsocupadoporNull()
			{
				return base.IsNull(this.tableTParqueo.ocupadoporColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTParqueo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetestaocupadoNull()
			{
				base[this.tableTParqueo.estaocupadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTParqueo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnParqueoNull()
			{
				base[this.tableTParqueo.nParqueoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetobservacionesParqueoNull()
			{
				base[this.tableTParqueo.observacionesParqueoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetocupadoporNull()
			{
				base[this.tableTParqueo.ocupadoporColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTParqueo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TParqueoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TParqueoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TParqueoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TParqueoRowChangeEvent(masterDBACDataSet.TParqueoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TParqueoRowChangeEventHandler(object sender, masterDBACDataSet.TParqueoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TRegistroEmpleadoDataTable : TypedTableBase<masterDBACDataSet.TRegistroEmpleadoRow>
		{
			private DataColumn columnidRegistroEmpleado;

			private DataColumn columnidEmpleado;

			private DataColumn columnfechadeRegistro;

			private DataColumn columnidPanel;

			private DataColumn columnidTipoRegistro;

			private DataColumn columndescripcionRegistro;

			private DataColumn columnObservacionesRegistro;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn descripcionRegistroColumn
			{
				get
				{
					return this.columndescripcionRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechadeRegistroColumn
			{
				get
				{
					return this.columnfechadeRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoColumn
			{
				get
				{
					return this.columnidEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idPanelColumn
			{
				get
				{
					return this.columnidPanel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRegistroEmpleadoColumn
			{
				get
				{
					return this.columnidRegistroEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoRegistroColumn
			{
				get
				{
					return this.columnidTipoRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TRegistroEmpleadoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesRegistroColumn
			{
				get
				{
					return this.columnObservacionesRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TRegistroEmpleadoDataTable()
			{
				base.TableName = "TRegistroEmpleado";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TRegistroEmpleadoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TRegistroEmpleadoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTRegistroEmpleadoRow(masterDBACDataSet.TRegistroEmpleadoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow AddTRegistroEmpleadoRow(masterDBACDataSet.TEmpleadoRow parentTEmpleadoRowByFK_TRegistroEmpleado_TEmpleado, DateTime fechadeRegistro, int idPanel, masterDBACDataSet.TTipoRegistroRow parentTTipoRegistroRowByFK_TRegistroEmpleado_TTipoRegistro, string descripcionRegistro, string ObservacionesRegistro, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TRegistroEmpleadoRow tRegistroEmpleadoRow = (masterDBACDataSet.TRegistroEmpleadoRow)base.NewRow();
				object[] objArray = new object[] { null, null, fechadeRegistro, idPanel, null, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion };
				object[] item = objArray;
				if (parentTEmpleadoRowByFK_TRegistroEmpleado_TEmpleado != null)
				{
					item[1] = parentTEmpleadoRowByFK_TRegistroEmpleado_TEmpleado[0];
				}
				if (parentTTipoRegistroRowByFK_TRegistroEmpleado_TTipoRegistro != null)
				{
					item[4] = parentTTipoRegistroRowByFK_TRegistroEmpleado_TTipoRegistro[0];
				}
				tRegistroEmpleadoRow.ItemArray = item;
				base.Rows.Add(tRegistroEmpleadoRow);
				return tRegistroEmpleadoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TRegistroEmpleadoDataTable tRegistroEmpleadoDataTable = (masterDBACDataSet.TRegistroEmpleadoDataTable)base.Clone();
				tRegistroEmpleadoDataTable.InitVars();
				return tRegistroEmpleadoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TRegistroEmpleadoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow FindByidRegistroEmpleado(decimal idRegistroEmpleado)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idRegistroEmpleado };
				return (masterDBACDataSet.TRegistroEmpleadoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TRegistroEmpleadoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TRegistroEmpleadoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidRegistroEmpleado = new DataColumn("idRegistroEmpleado", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidRegistroEmpleado);
				this.columnidEmpleado = new DataColumn("idEmpleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleado);
				this.columnfechadeRegistro = new DataColumn("fechadeRegistro", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechadeRegistro);
				this.columnidPanel = new DataColumn("idPanel", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidPanel);
				this.columnidTipoRegistro = new DataColumn("idTipoRegistro", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoRegistro);
				this.columndescripcionRegistro = new DataColumn("descripcionRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndescripcionRegistro);
				this.columnObservacionesRegistro = new DataColumn("ObservacionesRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesRegistro);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidRegistroEmpleado };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidRegistroEmpleado.AutoIncrement = true;
				this.columnidRegistroEmpleado.AutoIncrementSeed = (long)-1;
				this.columnidRegistroEmpleado.AutoIncrementStep = (long)-1;
				this.columnidRegistroEmpleado.AllowDBNull = false;
				this.columnidRegistroEmpleado.ReadOnly = true;
				this.columnidRegistroEmpleado.Unique = true;
				this.columndescripcionRegistro.MaxLength = 2147483647;
				this.columnObservacionesRegistro.MaxLength = 2147483647;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidRegistroEmpleado = base.Columns["idRegistroEmpleado"];
				this.columnidEmpleado = base.Columns["idEmpleado"];
				this.columnfechadeRegistro = base.Columns["fechadeRegistro"];
				this.columnidPanel = base.Columns["idPanel"];
				this.columnidTipoRegistro = base.Columns["idTipoRegistro"];
				this.columndescripcionRegistro = base.Columns["descripcionRegistro"];
				this.columnObservacionesRegistro = base.Columns["ObservacionesRegistro"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TRegistroEmpleadoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow NewTRegistroEmpleadoRow()
			{
				return (masterDBACDataSet.TRegistroEmpleadoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TRegistroEmpleadoRowChanged != null)
				{
					this.TRegistroEmpleadoRowChanged(this, new masterDBACDataSet.TRegistroEmpleadoRowChangeEvent((masterDBACDataSet.TRegistroEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TRegistroEmpleadoRowChanging != null)
				{
					this.TRegistroEmpleadoRowChanging(this, new masterDBACDataSet.TRegistroEmpleadoRowChangeEvent((masterDBACDataSet.TRegistroEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TRegistroEmpleadoRowDeleted != null)
				{
					this.TRegistroEmpleadoRowDeleted(this, new masterDBACDataSet.TRegistroEmpleadoRowChangeEvent((masterDBACDataSet.TRegistroEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TRegistroEmpleadoRowDeleting != null)
				{
					this.TRegistroEmpleadoRowDeleting(this, new masterDBACDataSet.TRegistroEmpleadoRowChangeEvent((masterDBACDataSet.TRegistroEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTRegistroEmpleadoRow(masterDBACDataSet.TRegistroEmpleadoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroEmpleadoRowChangeEventHandler TRegistroEmpleadoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroEmpleadoRowChangeEventHandler TRegistroEmpleadoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroEmpleadoRowChangeEventHandler TRegistroEmpleadoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroEmpleadoRowChangeEventHandler TRegistroEmpleadoRowDeleting;
		}

		public class TRegistroEmpleadoRow : DataRow
		{
			private masterDBACDataSet.TRegistroEmpleadoDataTable tableTRegistroEmpleado;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string descripcionRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroEmpleado.descripcionRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'descripcionRegistro' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.descripcionRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechadeRegistro
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTRegistroEmpleado.fechadeRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechadeRegistro' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.fechadeRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTRegistroEmpleado.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleado
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroEmpleado.idEmpleadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpleado' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.idEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idPanel
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroEmpleado.idPanelColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idPanel' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.idPanelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idRegistroEmpleado
			{
				get
				{
					return (decimal)base[this.tableTRegistroEmpleado.idRegistroEmpleadoColumn];
				}
				set
				{
					base[this.tableTRegistroEmpleado.idRegistroEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoRegistro
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroEmpleado.idTipoRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoRegistro' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.idTipoRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroEmpleado.ObservacionesRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesRegistro' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.ObservacionesRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow TEmpleadoRow
			{
				get
				{
					masterDBACDataSet.TEmpleadoRow parentRow = (masterDBACDataSet.TEmpleadoRow)base.GetParentRow(base.Table.ParentRelations["FK_TRegistroEmpleado_TEmpleado"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TRegistroEmpleado_TEmpleado"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow TTipoRegistroRow
			{
				get
				{
					masterDBACDataSet.TTipoRegistroRow parentRow = (masterDBACDataSet.TTipoRegistroRow)base.GetParentRow(base.Table.ParentRelations["FK_TRegistroEmpleado_TTipoRegistro"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TRegistroEmpleado_TTipoRegistro"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroEmpleado.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TRegistroEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroEmpleado.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TRegistroEmpleadoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTRegistroEmpleado = (masterDBACDataSet.TRegistroEmpleadoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdescripcionRegistroNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.descripcionRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechadeRegistroNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.fechadeRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpleadoNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.idEmpleadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidPanelNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.idPanelColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoRegistroNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.idTipoRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesRegistroNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.ObservacionesRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTRegistroEmpleado.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdescripcionRegistroNull()
			{
				base[this.tableTRegistroEmpleado.descripcionRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechadeRegistroNull()
			{
				base[this.tableTRegistroEmpleado.fechadeRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTRegistroEmpleado.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpleadoNull()
			{
				base[this.tableTRegistroEmpleado.idEmpleadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidPanelNull()
			{
				base[this.tableTRegistroEmpleado.idPanelColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoRegistroNull()
			{
				base[this.tableTRegistroEmpleado.idTipoRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesRegistroNull()
			{
				base[this.tableTRegistroEmpleado.ObservacionesRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTRegistroEmpleado.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TRegistroEmpleadoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TRegistroEmpleadoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TRegistroEmpleadoRowChangeEvent(masterDBACDataSet.TRegistroEmpleadoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TRegistroEmpleadoRowChangeEventHandler(object sender, masterDBACDataSet.TRegistroEmpleadoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TRegistroVehiculo1DataTable : TypedTableBase<masterDBACDataSet.TRegistroVehiculo1Row>
		{
			private DataColumn columnidRegistroVehiculo;

			private DataColumn columnidVehiculo;

			private DataColumn columnfechadeRegistro;

			private DataColumn columnidPanel;

			private DataColumn columnidTipoRegistro;

			private DataColumn columndescripcionRegistro;

			private DataColumn columnObservacionesRegistro;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnidempleado;

			private DataColumn columnmregistro;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn descripcionRegistroColumn
			{
				get
				{
					return this.columndescripcionRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechadeRegistroColumn
			{
				get
				{
					return this.columnfechadeRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idempleadoColumn
			{
				get
				{
					return this.columnidempleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idPanelColumn
			{
				get
				{
					return this.columnidPanel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRegistroVehiculoColumn
			{
				get
				{
					return this.columnidRegistroVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoRegistroColumn
			{
				get
				{
					return this.columnidTipoRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVehiculoColumn
			{
				get
				{
					return this.columnidVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row this[int index]
			{
				get
				{
					return (masterDBACDataSet.TRegistroVehiculo1Row)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn mregistroColumn
			{
				get
				{
					return this.columnmregistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesRegistroColumn
			{
				get
				{
					return this.columnObservacionesRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TRegistroVehiculo1DataTable()
			{
				base.TableName = "TRegistroVehiculo1";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TRegistroVehiculo1DataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TRegistroVehiculo1DataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTRegistroVehiculo1Row(masterDBACDataSet.TRegistroVehiculo1Row row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row AddTRegistroVehiculo1Row(masterDBACDataSet.TVehiculoRow parentTVehiculoRowByFK_TRegistroVehiculo_TVehiculo1, DateTime fechadeRegistro, int idPanel, masterDBACDataSet.TTipoRegistroRow parentTTipoRegistroRowByFK_TRegistroVehiculo_TTipoRegistro1, string descripcionRegistro, string ObservacionesRegistro, DateTime fechaUltimaGestion, int usuarioUltimaGestion, int idempleado, string mregistro)
			{
				masterDBACDataSet.TRegistroVehiculo1Row tRegistroVehiculo1Row = (masterDBACDataSet.TRegistroVehiculo1Row)base.NewRow();
				object[] objArray = new object[] { null, null, fechadeRegistro, idPanel, null, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion, idempleado, mregistro };
				object[] item = objArray;
				if (parentTVehiculoRowByFK_TRegistroVehiculo_TVehiculo1 != null)
				{
					item[1] = parentTVehiculoRowByFK_TRegistroVehiculo_TVehiculo1[0];
				}
				if (parentTTipoRegistroRowByFK_TRegistroVehiculo_TTipoRegistro1 != null)
				{
					item[4] = parentTTipoRegistroRowByFK_TRegistroVehiculo_TTipoRegistro1[0];
				}
				tRegistroVehiculo1Row.ItemArray = item;
				base.Rows.Add(tRegistroVehiculo1Row);
				return tRegistroVehiculo1Row;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TRegistroVehiculo1DataTable tRegistroVehiculo1DataTable = (masterDBACDataSet.TRegistroVehiculo1DataTable)base.Clone();
				tRegistroVehiculo1DataTable.InitVars();
				return tRegistroVehiculo1DataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TRegistroVehiculo1DataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row FindByidRegistroVehiculo(decimal idRegistroVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idRegistroVehiculo };
				return (masterDBACDataSet.TRegistroVehiculo1Row)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TRegistroVehiculo1Row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TRegistroVehiculo1DataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidRegistroVehiculo = new DataColumn("idRegistroVehiculo", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidRegistroVehiculo);
				this.columnidVehiculo = new DataColumn("idVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidVehiculo);
				this.columnfechadeRegistro = new DataColumn("fechadeRegistro", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechadeRegistro);
				this.columnidPanel = new DataColumn("idPanel", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidPanel);
				this.columnidTipoRegistro = new DataColumn("idTipoRegistro", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoRegistro);
				this.columndescripcionRegistro = new DataColumn("descripcionRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndescripcionRegistro);
				this.columnObservacionesRegistro = new DataColumn("ObservacionesRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesRegistro);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnidempleado = new DataColumn("idempleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidempleado);
				this.columnmregistro = new DataColumn("mregistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnmregistro);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidRegistroVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidRegistroVehiculo.AutoIncrement = true;
				this.columnidRegistroVehiculo.AutoIncrementSeed = (long)-1;
				this.columnidRegistroVehiculo.AutoIncrementStep = (long)-1;
				this.columnidRegistroVehiculo.AllowDBNull = false;
				this.columnidRegistroVehiculo.ReadOnly = true;
				this.columnidRegistroVehiculo.Unique = true;
				this.columndescripcionRegistro.MaxLength = 2147483647;
				this.columnObservacionesRegistro.MaxLength = 2147483647;
				this.columnmregistro.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidRegistroVehiculo = base.Columns["idRegistroVehiculo"];
				this.columnidVehiculo = base.Columns["idVehiculo"];
				this.columnfechadeRegistro = base.Columns["fechadeRegistro"];
				this.columnidPanel = base.Columns["idPanel"];
				this.columnidTipoRegistro = base.Columns["idTipoRegistro"];
				this.columndescripcionRegistro = base.Columns["descripcionRegistro"];
				this.columnObservacionesRegistro = base.Columns["ObservacionesRegistro"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnidempleado = base.Columns["idempleado"];
				this.columnmregistro = base.Columns["mregistro"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TRegistroVehiculo1Row(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row NewTRegistroVehiculo1Row()
			{
				return (masterDBACDataSet.TRegistroVehiculo1Row)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TRegistroVehiculo1RowChanged != null)
				{
					this.TRegistroVehiculo1RowChanged(this, new masterDBACDataSet.TRegistroVehiculo1RowChangeEvent((masterDBACDataSet.TRegistroVehiculo1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TRegistroVehiculo1RowChanging != null)
				{
					this.TRegistroVehiculo1RowChanging(this, new masterDBACDataSet.TRegistroVehiculo1RowChangeEvent((masterDBACDataSet.TRegistroVehiculo1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TRegistroVehiculo1RowDeleted != null)
				{
					this.TRegistroVehiculo1RowDeleted(this, new masterDBACDataSet.TRegistroVehiculo1RowChangeEvent((masterDBACDataSet.TRegistroVehiculo1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TRegistroVehiculo1RowDeleting != null)
				{
					this.TRegistroVehiculo1RowDeleting(this, new masterDBACDataSet.TRegistroVehiculo1RowChangeEvent((masterDBACDataSet.TRegistroVehiculo1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTRegistroVehiculo1Row(masterDBACDataSet.TRegistroVehiculo1Row row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculo1RowChangeEventHandler TRegistroVehiculo1RowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculo1RowChangeEventHandler TRegistroVehiculo1RowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculo1RowChangeEventHandler TRegistroVehiculo1RowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculo1RowChangeEventHandler TRegistroVehiculo1RowDeleting;
		}

		public class TRegistroVehiculo1Row : DataRow
		{
			private masterDBACDataSet.TRegistroVehiculo1DataTable tableTRegistroVehiculo1;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string descripcionRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroVehiculo1.descripcionRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'descripcionRegistro' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.descripcionRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechadeRegistro
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTRegistroVehiculo1.fechadeRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechadeRegistro' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.fechadeRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTRegistroVehiculo1.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idempleado
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo1.idempleadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idempleado' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.idempleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idPanel
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo1.idPanelColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idPanel' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.idPanelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idRegistroVehiculo
			{
				get
				{
					return (decimal)base[this.tableTRegistroVehiculo1.idRegistroVehiculoColumn];
				}
				set
				{
					base[this.tableTRegistroVehiculo1.idRegistroVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoRegistro
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo1.idTipoRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoRegistro' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.idTipoRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idVehiculo
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo1.idVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idVehiculo' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.idVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string mregistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroVehiculo1.mregistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'mregistro' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.mregistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroVehiculo1.ObservacionesRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesRegistro' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.ObservacionesRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow TTipoRegistroRow
			{
				get
				{
					masterDBACDataSet.TTipoRegistroRow parentRow = (masterDBACDataSet.TTipoRegistroRow)base.GetParentRow(base.Table.ParentRelations["FK_TRegistroVehiculo_TTipoRegistro1"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TRegistroVehiculo_TTipoRegistro1"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow TVehiculoRow
			{
				get
				{
					masterDBACDataSet.TVehiculoRow parentRow = (masterDBACDataSet.TVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TRegistroVehiculo_TVehiculo1"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TRegistroVehiculo_TVehiculo1"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo1.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TRegistroVehiculo1' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo1.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TRegistroVehiculo1Row(DataRowBuilder rb) : base(rb)
			{
				this.tableTRegistroVehiculo1 = (masterDBACDataSet.TRegistroVehiculo1DataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdescripcionRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.descripcionRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechadeRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.fechadeRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidempleadoNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.idempleadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidPanelNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.idPanelColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.idTipoRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidVehiculoNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.idVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsmregistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.mregistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.ObservacionesRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo1.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdescripcionRegistroNull()
			{
				base[this.tableTRegistroVehiculo1.descripcionRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechadeRegistroNull()
			{
				base[this.tableTRegistroVehiculo1.fechadeRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTRegistroVehiculo1.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidempleadoNull()
			{
				base[this.tableTRegistroVehiculo1.idempleadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidPanelNull()
			{
				base[this.tableTRegistroVehiculo1.idPanelColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoRegistroNull()
			{
				base[this.tableTRegistroVehiculo1.idTipoRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidVehiculoNull()
			{
				base[this.tableTRegistroVehiculo1.idVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetmregistroNull()
			{
				base[this.tableTRegistroVehiculo1.mregistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesRegistroNull()
			{
				base[this.tableTRegistroVehiculo1.ObservacionesRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTRegistroVehiculo1.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TRegistroVehiculo1RowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TRegistroVehiculo1Row eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TRegistroVehiculo1RowChangeEvent(masterDBACDataSet.TRegistroVehiculo1Row row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TRegistroVehiculo1RowChangeEventHandler(object sender, masterDBACDataSet.TRegistroVehiculo1RowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TRegistroVehiculoDataTable : TypedTableBase<masterDBACDataSet.TRegistroVehiculoRow>
		{
			private DataColumn columnidRegistroVehiculo;

			private DataColumn columnidVehiculo;

			private DataColumn columnfechadeRegistro;

			private DataColumn columnidPanel;

			private DataColumn columnidTipoRegistro;

			private DataColumn columndescripcionRegistro;

			private DataColumn columnObservacionesRegistro;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnidRegistroVehiculo1;

			private DataColumn columnidempleado;

			private DataColumn columnmregistro;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn descripcionRegistroColumn
			{
				get
				{
					return this.columndescripcionRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechadeRegistroColumn
			{
				get
				{
					return this.columnfechadeRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idempleadoColumn
			{
				get
				{
					return this.columnidempleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idPanelColumn
			{
				get
				{
					return this.columnidPanel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRegistroVehiculo1Column
			{
				get
				{
					return this.columnidRegistroVehiculo1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRegistroVehiculoColumn
			{
				get
				{
					return this.columnidRegistroVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoRegistroColumn
			{
				get
				{
					return this.columnidTipoRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVehiculoColumn
			{
				get
				{
					return this.columnidVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TRegistroVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn mregistroColumn
			{
				get
				{
					return this.columnmregistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesRegistroColumn
			{
				get
				{
					return this.columnObservacionesRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TRegistroVehiculoDataTable()
			{
				base.TableName = "TRegistroVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TRegistroVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TRegistroVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTRegistroVehiculoRow(masterDBACDataSet.TRegistroVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow AddTRegistroVehiculoRow(masterDBACDataSet.TVehiculoRow parentTVehiculoRowByFK_TRegistroVehiculo_TVehiculo, DateTime fechadeRegistro, int idPanel, masterDBACDataSet.TTipoRegistroRow parentTTipoRegistroRowByFK_TRegistroVehiculo_TTipoRegistro, string descripcionRegistro, string ObservacionesRegistro, DateTime fechaUltimaGestion, int usuarioUltimaGestion, int idempleado, string mregistro)
			{
				masterDBACDataSet.TRegistroVehiculoRow tRegistroVehiculoRow = (masterDBACDataSet.TRegistroVehiculoRow)base.NewRow();
				object[] objArray = new object[] { null, null, fechadeRegistro, idPanel, null, descripcionRegistro, ObservacionesRegistro, fechaUltimaGestion, usuarioUltimaGestion, null, idempleado, mregistro };
				object[] item = objArray;
				if (parentTVehiculoRowByFK_TRegistroVehiculo_TVehiculo != null)
				{
					item[1] = parentTVehiculoRowByFK_TRegistroVehiculo_TVehiculo[0];
				}
				if (parentTTipoRegistroRowByFK_TRegistroVehiculo_TTipoRegistro != null)
				{
					item[4] = parentTTipoRegistroRowByFK_TRegistroVehiculo_TTipoRegistro[0];
				}
				tRegistroVehiculoRow.ItemArray = item;
				base.Rows.Add(tRegistroVehiculoRow);
				return tRegistroVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TRegistroVehiculoDataTable tRegistroVehiculoDataTable = (masterDBACDataSet.TRegistroVehiculoDataTable)base.Clone();
				tRegistroVehiculoDataTable.InitVars();
				return tRegistroVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TRegistroVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow FindByidRegistroVehiculo(int idRegistroVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idRegistroVehiculo };
				return (masterDBACDataSet.TRegistroVehiculoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TRegistroVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TRegistroVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidRegistroVehiculo = new DataColumn("idRegistroVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRegistroVehiculo);
				this.columnidVehiculo = new DataColumn("idVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidVehiculo);
				this.columnfechadeRegistro = new DataColumn("fechadeRegistro", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechadeRegistro);
				this.columnidPanel = new DataColumn("idPanel", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidPanel);
				this.columnidTipoRegistro = new DataColumn("idTipoRegistro", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoRegistro);
				this.columndescripcionRegistro = new DataColumn("descripcionRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndescripcionRegistro);
				this.columnObservacionesRegistro = new DataColumn("ObservacionesRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesRegistro);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnidRegistroVehiculo1 = new DataColumn("idRegistroVehiculo1", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidRegistroVehiculo1);
				this.columnidempleado = new DataColumn("idempleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidempleado);
				this.columnmregistro = new DataColumn("mregistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnmregistro);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidRegistroVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				ConstraintCollection constraintCollection = base.Constraints;
				dataColumnArray = new DataColumn[] { this.columnidRegistroVehiculo1 };
				constraintCollection.Add(new UniqueConstraint("Constraint2", dataColumnArray, false));
				this.columnidRegistroVehiculo.AutoIncrement = true;
				this.columnidRegistroVehiculo.AutoIncrementSeed = (long)-1;
				this.columnidRegistroVehiculo.AutoIncrementStep = (long)-1;
				this.columnidRegistroVehiculo.AllowDBNull = false;
				this.columnidRegistroVehiculo.ReadOnly = true;
				this.columnidRegistroVehiculo.Unique = true;
				this.columndescripcionRegistro.MaxLength = 2147483647;
				this.columnObservacionesRegistro.MaxLength = 2147483647;
				this.columnidRegistroVehiculo1.AutoIncrement = true;
				this.columnidRegistroVehiculo1.AutoIncrementSeed = (long)-1;
				this.columnidRegistroVehiculo1.AutoIncrementStep = (long)-1;
				this.columnidRegistroVehiculo1.AllowDBNull = false;
				this.columnidRegistroVehiculo1.ReadOnly = true;
				this.columnidRegistroVehiculo1.Unique = true;
				this.columnidRegistroVehiculo1.Caption = "idRegistroVehiculo";
				this.columnmregistro.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidRegistroVehiculo = base.Columns["idRegistroVehiculo"];
				this.columnidVehiculo = base.Columns["idVehiculo"];
				this.columnfechadeRegistro = base.Columns["fechadeRegistro"];
				this.columnidPanel = base.Columns["idPanel"];
				this.columnidTipoRegistro = base.Columns["idTipoRegistro"];
				this.columndescripcionRegistro = base.Columns["descripcionRegistro"];
				this.columnObservacionesRegistro = base.Columns["ObservacionesRegistro"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnidRegistroVehiculo1 = base.Columns["idRegistroVehiculo1"];
				this.columnidempleado = base.Columns["idempleado"];
				this.columnmregistro = base.Columns["mregistro"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TRegistroVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow NewTRegistroVehiculoRow()
			{
				return (masterDBACDataSet.TRegistroVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TRegistroVehiculoRowChanged != null)
				{
					this.TRegistroVehiculoRowChanged(this, new masterDBACDataSet.TRegistroVehiculoRowChangeEvent((masterDBACDataSet.TRegistroVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TRegistroVehiculoRowChanging != null)
				{
					this.TRegistroVehiculoRowChanging(this, new masterDBACDataSet.TRegistroVehiculoRowChangeEvent((masterDBACDataSet.TRegistroVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TRegistroVehiculoRowDeleted != null)
				{
					this.TRegistroVehiculoRowDeleted(this, new masterDBACDataSet.TRegistroVehiculoRowChangeEvent((masterDBACDataSet.TRegistroVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TRegistroVehiculoRowDeleting != null)
				{
					this.TRegistroVehiculoRowDeleting(this, new masterDBACDataSet.TRegistroVehiculoRowChangeEvent((masterDBACDataSet.TRegistroVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTRegistroVehiculoRow(masterDBACDataSet.TRegistroVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculoRowChangeEventHandler TRegistroVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculoRowChangeEventHandler TRegistroVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculoRowChangeEventHandler TRegistroVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TRegistroVehiculoRowChangeEventHandler TRegistroVehiculoRowDeleting;
		}

		public class TRegistroVehiculoRow : DataRow
		{
			private masterDBACDataSet.TRegistroVehiculoDataTable tableTRegistroVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string descripcionRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroVehiculo.descripcionRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'descripcionRegistro' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.descripcionRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechadeRegistro
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTRegistroVehiculo.fechadeRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechadeRegistro' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.fechadeRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTRegistroVehiculo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idempleado
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo.idempleadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idempleado' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.idempleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idPanel
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo.idPanelColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idPanel' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.idPanelColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idRegistroVehiculo
			{
				get
				{
					return (int)base[this.tableTRegistroVehiculo.idRegistroVehiculoColumn];
				}
				set
				{
					base[this.tableTRegistroVehiculo.idRegistroVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idRegistroVehiculo1
			{
				get
				{
					return (decimal)base[this.tableTRegistroVehiculo.idRegistroVehiculo1Column];
				}
				set
				{
					base[this.tableTRegistroVehiculo.idRegistroVehiculo1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoRegistro
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo.idTipoRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoRegistro' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.idTipoRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idVehiculo
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo.idVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idVehiculo' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.idVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string mregistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroVehiculo.mregistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'mregistro' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.mregistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTRegistroVehiculo.ObservacionesRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesRegistro' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.ObservacionesRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow TTipoRegistroRow
			{
				get
				{
					masterDBACDataSet.TTipoRegistroRow parentRow = (masterDBACDataSet.TTipoRegistroRow)base.GetParentRow(base.Table.ParentRelations["FK_TRegistroVehiculo_TTipoRegistro"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TRegistroVehiculo_TTipoRegistro"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow TVehiculoRow
			{
				get
				{
					masterDBACDataSet.TVehiculoRow parentRow = (masterDBACDataSet.TVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TRegistroVehiculo_TVehiculo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TRegistroVehiculo_TVehiculo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTRegistroVehiculo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TRegistroVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTRegistroVehiculo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TRegistroVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTRegistroVehiculo = (masterDBACDataSet.TRegistroVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdescripcionRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.descripcionRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechadeRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.fechadeRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidempleadoNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.idempleadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidPanelNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.idPanelColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.idTipoRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidVehiculoNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.idVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsmregistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.mregistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesRegistroNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.ObservacionesRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTRegistroVehiculo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdescripcionRegistroNull()
			{
				base[this.tableTRegistroVehiculo.descripcionRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechadeRegistroNull()
			{
				base[this.tableTRegistroVehiculo.fechadeRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTRegistroVehiculo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidempleadoNull()
			{
				base[this.tableTRegistroVehiculo.idempleadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidPanelNull()
			{
				base[this.tableTRegistroVehiculo.idPanelColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoRegistroNull()
			{
				base[this.tableTRegistroVehiculo.idTipoRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidVehiculoNull()
			{
				base[this.tableTRegistroVehiculo.idVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetmregistroNull()
			{
				base[this.tableTRegistroVehiculo.mregistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesRegistroNull()
			{
				base[this.tableTRegistroVehiculo.ObservacionesRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTRegistroVehiculo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TRegistroVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TRegistroVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TRegistroVehiculoRowChangeEvent(masterDBACDataSet.TRegistroVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TRegistroVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.TRegistroVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TTarjetaDataTable : TypedTableBase<masterDBACDataSet.TTarjetaRow>
		{
			private DataColumn columnidTarjeta;

			private DataColumn columnnumtarjeta;

			private DataColumn columnidHorario;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnactiva;

			private DataColumn columnesvisitante;

			private DataColumn columnesutilizada;

			private DataColumn columnfechavisi1;

			private DataColumn columnfechavisi2;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn activaColumn
			{
				get
				{
					return this.columnactiva;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn esutilizadaColumn
			{
				get
				{
					return this.columnesutilizada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn esvisitanteColumn
			{
				get
				{
					return this.columnesvisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechavisi1Column
			{
				get
				{
					return this.columnfechavisi1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechavisi2Column
			{
				get
				{
					return this.columnfechavisi2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idHorarioColumn
			{
				get
				{
					return this.columnidHorario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTarjetaColumn
			{
				get
				{
					return this.columnidTarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTarjetaRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TTarjetaRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn numtarjetaColumn
			{
				get
				{
					return this.columnnumtarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTarjetaDataTable()
			{
				base.TableName = "TTarjeta";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTarjetaDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TTarjetaDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTTarjetaRow(masterDBACDataSet.TTarjetaRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTarjetaRow AddTTarjetaRow(string numtarjeta, int idHorario, DateTime fechaUltimaGestion, int usuarioUltimaGestion, bool activa, bool esvisitante, bool esutilizada, DateTime fechavisi1, DateTime fechavisi2)
			{
				masterDBACDataSet.TTarjetaRow tTarjetaRow = (masterDBACDataSet.TTarjetaRow)base.NewRow();
				object[] objArray = new object[] { null, numtarjeta, idHorario, fechaUltimaGestion, usuarioUltimaGestion, activa, esvisitante, esutilizada, fechavisi1, fechavisi2 };
				tTarjetaRow.ItemArray = objArray;
				base.Rows.Add(tTarjetaRow);
				return tTarjetaRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TTarjetaDataTable tTarjetaDataTable = (masterDBACDataSet.TTarjetaDataTable)base.Clone();
				tTarjetaDataTable.InitVars();
				return tTarjetaDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TTarjetaDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTarjetaRow FindByidTarjeta(int idTarjeta)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTarjeta };
				return (masterDBACDataSet.TTarjetaRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TTarjetaRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TTarjetaDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTarjeta = new DataColumn("idTarjeta", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTarjeta);
				this.columnnumtarjeta = new DataColumn("numtarjeta", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnumtarjeta);
				this.columnidHorario = new DataColumn("idHorario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidHorario);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnactiva = new DataColumn("activa", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnactiva);
				this.columnesvisitante = new DataColumn("esvisitante", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnesvisitante);
				this.columnesutilizada = new DataColumn("esutilizada", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnesutilizada);
				this.columnfechavisi1 = new DataColumn("fechavisi1", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechavisi1);
				this.columnfechavisi2 = new DataColumn("fechavisi2", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechavisi2);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTarjeta };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTarjeta.AutoIncrement = true;
				this.columnidTarjeta.AutoIncrementSeed = (long)-1;
				this.columnidTarjeta.AutoIncrementStep = (long)-1;
				this.columnidTarjeta.AllowDBNull = false;
				this.columnidTarjeta.ReadOnly = true;
				this.columnidTarjeta.Unique = true;
				this.columnnumtarjeta.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTarjeta = base.Columns["idTarjeta"];
				this.columnnumtarjeta = base.Columns["numtarjeta"];
				this.columnidHorario = base.Columns["idHorario"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnactiva = base.Columns["activa"];
				this.columnesvisitante = base.Columns["esvisitante"];
				this.columnesutilizada = base.Columns["esutilizada"];
				this.columnfechavisi1 = base.Columns["fechavisi1"];
				this.columnfechavisi2 = base.Columns["fechavisi2"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TTarjetaRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTarjetaRow NewTTarjetaRow()
			{
				return (masterDBACDataSet.TTarjetaRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TTarjetaRowChanged != null)
				{
					this.TTarjetaRowChanged(this, new masterDBACDataSet.TTarjetaRowChangeEvent((masterDBACDataSet.TTarjetaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TTarjetaRowChanging != null)
				{
					this.TTarjetaRowChanging(this, new masterDBACDataSet.TTarjetaRowChangeEvent((masterDBACDataSet.TTarjetaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TTarjetaRowDeleted != null)
				{
					this.TTarjetaRowDeleted(this, new masterDBACDataSet.TTarjetaRowChangeEvent((masterDBACDataSet.TTarjetaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TTarjetaRowDeleting != null)
				{
					this.TTarjetaRowDeleting(this, new masterDBACDataSet.TTarjetaRowChangeEvent((masterDBACDataSet.TTarjetaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTTarjetaRow(masterDBACDataSet.TTarjetaRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTarjetaRowChangeEventHandler TTarjetaRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTarjetaRowChangeEventHandler TTarjetaRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTarjetaRowChangeEventHandler TTarjetaRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTarjetaRowChangeEventHandler TTarjetaRowDeleting;
		}

		public class TTarjetaRow : DataRow
		{
			private masterDBACDataSet.TTarjetaDataTable tableTTarjeta;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool activa
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTTarjeta.activaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'activa' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.activaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool esutilizada
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTTarjeta.esutilizadaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'esutilizada' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.esutilizadaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool esvisitante
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTTarjeta.esvisitanteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'esvisitante' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.esvisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTTarjeta.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechavisi1
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTTarjeta.fechavisi1Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechavisi1' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.fechavisi1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechavisi2
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTTarjeta.fechavisi2Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechavisi2' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.fechavisi2Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idHorario
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTTarjeta.idHorarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idHorario' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.idHorarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTarjeta
			{
				get
				{
					return (int)base[this.tableTTarjeta.idTarjetaColumn];
				}
				set
				{
					base[this.tableTTarjeta.idTarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string numtarjeta
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTTarjeta.numtarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'numtarjeta' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.numtarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTTarjeta.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TTarjeta' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTarjeta.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTarjetaRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTTarjeta = (masterDBACDataSet.TTarjetaDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsactivaNull()
			{
				return base.IsNull(this.tableTTarjeta.activaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsesutilizadaNull()
			{
				return base.IsNull(this.tableTTarjeta.esutilizadaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsesvisitanteNull()
			{
				return base.IsNull(this.tableTTarjeta.esvisitanteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTTarjeta.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfechavisi1Null()
			{
				return base.IsNull(this.tableTTarjeta.fechavisi1Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isfechavisi2Null()
			{
				return base.IsNull(this.tableTTarjeta.fechavisi2Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidHorarioNull()
			{
				return base.IsNull(this.tableTTarjeta.idHorarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnumtarjetaNull()
			{
				return base.IsNull(this.tableTTarjeta.numtarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTTarjeta.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetactivaNull()
			{
				base[this.tableTTarjeta.activaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetesutilizadaNull()
			{
				base[this.tableTTarjeta.esutilizadaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetesvisitanteNull()
			{
				base[this.tableTTarjeta.esvisitanteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTTarjeta.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfechavisi1Null()
			{
				base[this.tableTTarjeta.fechavisi1Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setfechavisi2Null()
			{
				base[this.tableTTarjeta.fechavisi2Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidHorarioNull()
			{
				base[this.tableTTarjeta.idHorarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnumtarjetaNull()
			{
				base[this.tableTTarjeta.numtarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTTarjeta.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TTarjetaRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TTarjetaRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTarjetaRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTarjetaRowChangeEvent(masterDBACDataSet.TTarjetaRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TTarjetaRowChangeEventHandler(object sender, masterDBACDataSet.TTarjetaRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TTipoIdentificacionDataTable : TypedTableBase<masterDBACDataSet.TTipoIdentificacionRow>
		{
			private DataColumn columnidTipoIdentificacion;

			private DataColumn columndescripcionIdentificacion;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn descripcionIdentificacionColumn
			{
				get
				{
					return this.columndescripcionIdentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoIdentificacionColumn
			{
				get
				{
					return this.columnidTipoIdentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TTipoIdentificacionRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTipoIdentificacionDataTable()
			{
				base.TableName = "TTipoIdentificacion";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTipoIdentificacionDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TTipoIdentificacionDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTTipoIdentificacionRow(masterDBACDataSet.TTipoIdentificacionRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow AddTTipoIdentificacionRow(string descripcionIdentificacion, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TTipoIdentificacionRow tTipoIdentificacionRow = (masterDBACDataSet.TTipoIdentificacionRow)base.NewRow();
				object[] objArray = new object[] { null, descripcionIdentificacion, fechaUltimaGestion, usuarioUltimaGestion };
				tTipoIdentificacionRow.ItemArray = objArray;
				base.Rows.Add(tTipoIdentificacionRow);
				return tTipoIdentificacionRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TTipoIdentificacionDataTable tTipoIdentificacionDataTable = (masterDBACDataSet.TTipoIdentificacionDataTable)base.Clone();
				tTipoIdentificacionDataTable.InitVars();
				return tTipoIdentificacionDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TTipoIdentificacionDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow FindByidTipoIdentificacion(int idTipoIdentificacion)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTipoIdentificacion };
				return (masterDBACDataSet.TTipoIdentificacionRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TTipoIdentificacionRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TTipoIdentificacionDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTipoIdentificacion = new DataColumn("idTipoIdentificacion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoIdentificacion);
				this.columndescripcionIdentificacion = new DataColumn("descripcionIdentificacion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndescripcionIdentificacion);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTipoIdentificacion };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTipoIdentificacion.AutoIncrement = true;
				this.columnidTipoIdentificacion.AutoIncrementSeed = (long)-1;
				this.columnidTipoIdentificacion.AutoIncrementStep = (long)-1;
				this.columnidTipoIdentificacion.AllowDBNull = false;
				this.columnidTipoIdentificacion.ReadOnly = true;
				this.columnidTipoIdentificacion.Unique = true;
				this.columndescripcionIdentificacion.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTipoIdentificacion = base.Columns["idTipoIdentificacion"];
				this.columndescripcionIdentificacion = base.Columns["descripcionIdentificacion"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TTipoIdentificacionRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow NewTTipoIdentificacionRow()
			{
				return (masterDBACDataSet.TTipoIdentificacionRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TTipoIdentificacionRowChanged != null)
				{
					this.TTipoIdentificacionRowChanged(this, new masterDBACDataSet.TTipoIdentificacionRowChangeEvent((masterDBACDataSet.TTipoIdentificacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TTipoIdentificacionRowChanging != null)
				{
					this.TTipoIdentificacionRowChanging(this, new masterDBACDataSet.TTipoIdentificacionRowChangeEvent((masterDBACDataSet.TTipoIdentificacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TTipoIdentificacionRowDeleted != null)
				{
					this.TTipoIdentificacionRowDeleted(this, new masterDBACDataSet.TTipoIdentificacionRowChangeEvent((masterDBACDataSet.TTipoIdentificacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TTipoIdentificacionRowDeleting != null)
				{
					this.TTipoIdentificacionRowDeleting(this, new masterDBACDataSet.TTipoIdentificacionRowChangeEvent((masterDBACDataSet.TTipoIdentificacionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTTipoIdentificacionRow(masterDBACDataSet.TTipoIdentificacionRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoIdentificacionRowChangeEventHandler TTipoIdentificacionRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoIdentificacionRowChangeEventHandler TTipoIdentificacionRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoIdentificacionRowChangeEventHandler TTipoIdentificacionRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoIdentificacionRowChangeEventHandler TTipoIdentificacionRowDeleting;
		}

		public class TTipoIdentificacionRow : DataRow
		{
			private masterDBACDataSet.TTipoIdentificacionDataTable tableTTipoIdentificacion;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string descripcionIdentificacion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTTipoIdentificacion.descripcionIdentificacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'descripcionIdentificacion' in table 'TTipoIdentificacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoIdentificacion.descripcionIdentificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTTipoIdentificacion.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TTipoIdentificacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoIdentificacion.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoIdentificacion
			{
				get
				{
					return (int)base[this.tableTTipoIdentificacion.idTipoIdentificacionColumn];
				}
				set
				{
					base[this.tableTTipoIdentificacion.idTipoIdentificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTTipoIdentificacion.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TTipoIdentificacion' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoIdentificacion.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTipoIdentificacionRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTTipoIdentificacion = (masterDBACDataSet.TTipoIdentificacionDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow[] GetTEmpleadoRows()
			{
				masterDBACDataSet.TEmpleadoRow[] tEmpleadoRowArray;
				tEmpleadoRowArray = (base.Table.ChildRelations["FK_TEmpleado_TTipoIdentificacion"] != null ? (masterDBACDataSet.TEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleado_TTipoIdentificacion"]) : new masterDBACDataSet.TEmpleadoRow[0]);
				return tEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow[] GetTVisitanteRows()
			{
				masterDBACDataSet.TVisitanteRow[] tVisitanteRowArray;
				tVisitanteRowArray = (base.Table.ChildRelations["FK_TVisitante_TTipoIdentificacion"] != null ? (masterDBACDataSet.TVisitanteRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitante_TTipoIdentificacion"]) : new masterDBACDataSet.TVisitanteRow[0]);
				return tVisitanteRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdescripcionIdentificacionNull()
			{
				return base.IsNull(this.tableTTipoIdentificacion.descripcionIdentificacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTTipoIdentificacion.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTTipoIdentificacion.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdescripcionIdentificacionNull()
			{
				base[this.tableTTipoIdentificacion.descripcionIdentificacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTTipoIdentificacion.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTTipoIdentificacion.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TTipoIdentificacionRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TTipoIdentificacionRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTipoIdentificacionRowChangeEvent(masterDBACDataSet.TTipoIdentificacionRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TTipoIdentificacionRowChangeEventHandler(object sender, masterDBACDataSet.TTipoIdentificacionRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TTipoRegistroDataTable : TypedTableBase<masterDBACDataSet.TTipoRegistroRow>
		{
			private DataColumn columnidTipoRegistro;

			private DataColumn columnTipoRegistro;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoRegistroColumn
			{
				get
				{
					return this.columnidTipoRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TTipoRegistroRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TipoRegistroColumn
			{
				get
				{
					return this.columnTipoRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTipoRegistroDataTable()
			{
				base.TableName = "TTipoRegistro";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTipoRegistroDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TTipoRegistroDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTTipoRegistroRow(masterDBACDataSet.TTipoRegistroRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow AddTTipoRegistroRow(string TipoRegistro)
			{
				masterDBACDataSet.TTipoRegistroRow tipoRegistro = (masterDBACDataSet.TTipoRegistroRow)base.NewRow();
				tipoRegistro.ItemArray = new object[] { null, TipoRegistro };
				base.Rows.Add(tipoRegistro);
				return tipoRegistro;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TTipoRegistroDataTable tTipoRegistroDataTable = (masterDBACDataSet.TTipoRegistroDataTable)base.Clone();
				tTipoRegistroDataTable.InitVars();
				return tTipoRegistroDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TTipoRegistroDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow FindByidTipoRegistro(int idTipoRegistro)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTipoRegistro };
				return (masterDBACDataSet.TTipoRegistroRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TTipoRegistroRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TTipoRegistroDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTipoRegistro = new DataColumn("idTipoRegistro", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoRegistro);
				this.columnTipoRegistro = new DataColumn("TipoRegistro", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTipoRegistro);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTipoRegistro };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTipoRegistro.AutoIncrement = true;
				this.columnidTipoRegistro.AutoIncrementSeed = (long)-1;
				this.columnidTipoRegistro.AutoIncrementStep = (long)-1;
				this.columnidTipoRegistro.AllowDBNull = false;
				this.columnidTipoRegistro.ReadOnly = true;
				this.columnidTipoRegistro.Unique = true;
				this.columnTipoRegistro.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTipoRegistro = base.Columns["idTipoRegistro"];
				this.columnTipoRegistro = base.Columns["TipoRegistro"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TTipoRegistroRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow NewTTipoRegistroRow()
			{
				return (masterDBACDataSet.TTipoRegistroRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TTipoRegistroRowChanged != null)
				{
					this.TTipoRegistroRowChanged(this, new masterDBACDataSet.TTipoRegistroRowChangeEvent((masterDBACDataSet.TTipoRegistroRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TTipoRegistroRowChanging != null)
				{
					this.TTipoRegistroRowChanging(this, new masterDBACDataSet.TTipoRegistroRowChangeEvent((masterDBACDataSet.TTipoRegistroRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TTipoRegistroRowDeleted != null)
				{
					this.TTipoRegistroRowDeleted(this, new masterDBACDataSet.TTipoRegistroRowChangeEvent((masterDBACDataSet.TTipoRegistroRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TTipoRegistroRowDeleting != null)
				{
					this.TTipoRegistroRowDeleting(this, new masterDBACDataSet.TTipoRegistroRowChangeEvent((masterDBACDataSet.TTipoRegistroRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTTipoRegistroRow(masterDBACDataSet.TTipoRegistroRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoRegistroRowChangeEventHandler TTipoRegistroRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoRegistroRowChangeEventHandler TTipoRegistroRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoRegistroRowChangeEventHandler TTipoRegistroRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoRegistroRowChangeEventHandler TTipoRegistroRowDeleting;
		}

		public class TTipoRegistroRow : DataRow
		{
			private masterDBACDataSet.TTipoRegistroDataTable tableTTipoRegistro;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoRegistro
			{
				get
				{
					return (int)base[this.tableTTipoRegistro.idTipoRegistroColumn];
				}
				set
				{
					base[this.tableTTipoRegistro.idTipoRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string TipoRegistro
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTTipoRegistro.TipoRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'TipoRegistro' in table 'TTipoRegistro' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoRegistro.TipoRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTipoRegistroRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTTipoRegistro = (masterDBACDataSet.TTipoRegistroDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroEmpleadoRow[] GetTRegistroEmpleadoRows()
			{
				masterDBACDataSet.TRegistroEmpleadoRow[] tRegistroEmpleadoRowArray;
				tRegistroEmpleadoRowArray = (base.Table.ChildRelations["FK_TRegistroEmpleado_TTipoRegistro"] != null ? (masterDBACDataSet.TRegistroEmpleadoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TRegistroEmpleado_TTipoRegistro"]) : new masterDBACDataSet.TRegistroEmpleadoRow[0]);
				return tRegistroEmpleadoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row[] GetTRegistroVehiculo1Rows()
			{
				masterDBACDataSet.TRegistroVehiculo1Row[] tRegistroVehiculo1RowArray;
				tRegistroVehiculo1RowArray = (base.Table.ChildRelations["FK_TRegistroVehiculo_TTipoRegistro1"] != null ? (masterDBACDataSet.TRegistroVehiculo1Row[])base.GetChildRows(base.Table.ChildRelations["FK_TRegistroVehiculo_TTipoRegistro1"]) : new masterDBACDataSet.TRegistroVehiculo1Row[0]);
				return tRegistroVehiculo1RowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow[] GetTRegistroVehiculoRows()
			{
				masterDBACDataSet.TRegistroVehiculoRow[] tRegistroVehiculoRowArray;
				tRegistroVehiculoRowArray = (base.Table.ChildRelations["FK_TRegistroVehiculo_TTipoRegistro"] != null ? (masterDBACDataSet.TRegistroVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TRegistroVehiculo_TTipoRegistro"]) : new masterDBACDataSet.TRegistroVehiculoRow[0]);
				return tRegistroVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTipoRegistroNull()
			{
				return base.IsNull(this.tableTTipoRegistro.TipoRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTipoRegistroNull()
			{
				base[this.tableTTipoRegistro.TipoRegistroColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TTipoRegistroRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TTipoRegistroRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoRegistroRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTipoRegistroRowChangeEvent(masterDBACDataSet.TTipoRegistroRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TTipoRegistroRowChangeEventHandler(object sender, masterDBACDataSet.TTipoRegistroRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TTipoUsuarioDataTable : TypedTableBase<masterDBACDataSet.TTipoUsuarioRow>
		{
			private DataColumn columnidTipoUsuario;

			private DataColumn columnNombreTipoUsuario;

			private DataColumn columnpermisos;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoUsuarioColumn
			{
				get
				{
					return this.columnidTipoUsuario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoUsuarioRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TTipoUsuarioRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreTipoUsuarioColumn
			{
				get
				{
					return this.columnNombreTipoUsuario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn permisosColumn
			{
				get
				{
					return this.columnpermisos;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTipoUsuarioDataTable()
			{
				base.TableName = "TTipoUsuario";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTipoUsuarioDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TTipoUsuarioDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTTipoUsuarioRow(masterDBACDataSet.TTipoUsuarioRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoUsuarioRow AddTTipoUsuarioRow(string NombreTipoUsuario, string permisos, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TTipoUsuarioRow tTipoUsuarioRow = (masterDBACDataSet.TTipoUsuarioRow)base.NewRow();
				object[] nombreTipoUsuario = new object[] { null, NombreTipoUsuario, permisos, fechaUltimaGestion, usuarioUltimaGestion };
				tTipoUsuarioRow.ItemArray = nombreTipoUsuario;
				base.Rows.Add(tTipoUsuarioRow);
				return tTipoUsuarioRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TTipoUsuarioDataTable tTipoUsuarioDataTable = (masterDBACDataSet.TTipoUsuarioDataTable)base.Clone();
				tTipoUsuarioDataTable.InitVars();
				return tTipoUsuarioDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TTipoUsuarioDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoUsuarioRow FindByidTipoUsuario(int idTipoUsuario)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTipoUsuario };
				return (masterDBACDataSet.TTipoUsuarioRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TTipoUsuarioRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TTipoUsuarioDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTipoUsuario = new DataColumn("idTipoUsuario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoUsuario);
				this.columnNombreTipoUsuario = new DataColumn("NombreTipoUsuario", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreTipoUsuario);
				this.columnpermisos = new DataColumn("permisos", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpermisos);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTipoUsuario };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTipoUsuario.AutoIncrement = true;
				this.columnidTipoUsuario.AutoIncrementSeed = (long)-1;
				this.columnidTipoUsuario.AutoIncrementStep = (long)-1;
				this.columnidTipoUsuario.AllowDBNull = false;
				this.columnidTipoUsuario.ReadOnly = true;
				this.columnidTipoUsuario.Unique = true;
				this.columnNombreTipoUsuario.MaxLength = 50;
				this.columnpermisos.AllowDBNull = false;
				this.columnpermisos.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTipoUsuario = base.Columns["idTipoUsuario"];
				this.columnNombreTipoUsuario = base.Columns["NombreTipoUsuario"];
				this.columnpermisos = base.Columns["permisos"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TTipoUsuarioRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoUsuarioRow NewTTipoUsuarioRow()
			{
				return (masterDBACDataSet.TTipoUsuarioRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TTipoUsuarioRowChanged != null)
				{
					this.TTipoUsuarioRowChanged(this, new masterDBACDataSet.TTipoUsuarioRowChangeEvent((masterDBACDataSet.TTipoUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TTipoUsuarioRowChanging != null)
				{
					this.TTipoUsuarioRowChanging(this, new masterDBACDataSet.TTipoUsuarioRowChangeEvent((masterDBACDataSet.TTipoUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TTipoUsuarioRowDeleted != null)
				{
					this.TTipoUsuarioRowDeleted(this, new masterDBACDataSet.TTipoUsuarioRowChangeEvent((masterDBACDataSet.TTipoUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TTipoUsuarioRowDeleting != null)
				{
					this.TTipoUsuarioRowDeleting(this, new masterDBACDataSet.TTipoUsuarioRowChangeEvent((masterDBACDataSet.TTipoUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTTipoUsuarioRow(masterDBACDataSet.TTipoUsuarioRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoUsuarioRowChangeEventHandler TTipoUsuarioRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoUsuarioRowChangeEventHandler TTipoUsuarioRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoUsuarioRowChangeEventHandler TTipoUsuarioRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TTipoUsuarioRowChangeEventHandler TTipoUsuarioRowDeleting;
		}

		public class TTipoUsuarioRow : DataRow
		{
			private masterDBACDataSet.TTipoUsuarioDataTable tableTTipoUsuario;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTTipoUsuario.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TTipoUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoUsuario.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoUsuario
			{
				get
				{
					return (int)base[this.tableTTipoUsuario.idTipoUsuarioColumn];
				}
				set
				{
					base[this.tableTTipoUsuario.idTipoUsuarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreTipoUsuario
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTTipoUsuario.NombreTipoUsuarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreTipoUsuario' in table 'TTipoUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoUsuario.NombreTipoUsuarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string permisos
			{
				get
				{
					return (string)base[this.tableTTipoUsuario.permisosColumn];
				}
				set
				{
					base[this.tableTTipoUsuario.permisosColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTTipoUsuario.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TTipoUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTTipoUsuario.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TTipoUsuarioRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTTipoUsuario = (masterDBACDataSet.TTipoUsuarioDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TUsuarioRow[] GetTUsuarioRows()
			{
				masterDBACDataSet.TUsuarioRow[] tUsuarioRowArray;
				tUsuarioRowArray = (base.Table.ChildRelations["FK_TUsuario_TTipoUsuario"] != null ? (masterDBACDataSet.TUsuarioRow[])base.GetChildRows(base.Table.ChildRelations["FK_TUsuario_TTipoUsuario"]) : new masterDBACDataSet.TUsuarioRow[0]);
				return tUsuarioRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTTipoUsuario.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreTipoUsuarioNull()
			{
				return base.IsNull(this.tableTTipoUsuario.NombreTipoUsuarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTTipoUsuario.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTTipoUsuario.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreTipoUsuarioNull()
			{
				base[this.tableTTipoUsuario.NombreTipoUsuarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTTipoUsuario.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TTipoUsuarioRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TTipoUsuarioRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoUsuarioRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TTipoUsuarioRowChangeEvent(masterDBACDataSet.TTipoUsuarioRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TTipoUsuarioRowChangeEventHandler(object sender, masterDBACDataSet.TTipoUsuarioRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TUsuarioDataTable : TypedTableBase<masterDBACDataSet.TUsuarioRow>
		{
			private DataColumn columnidUsuario;

			private DataColumn columnnombre;

			private DataColumn columnlogin;

			private DataColumn columnpassword;

			private DataColumn columnidTipoUsuario;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnfotoUsuario;

			private DataColumn columnactivo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn activoColumn
			{
				get
				{
					return this.columnactivo;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fotoUsuarioColumn
			{
				get
				{
					return this.columnfotoUsuario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoUsuarioColumn
			{
				get
				{
					return this.columnidTipoUsuario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idUsuarioColumn
			{
				get
				{
					return this.columnidUsuario;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TUsuarioRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TUsuarioRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn loginColumn
			{
				get
				{
					return this.columnlogin;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nombreColumn
			{
				get
				{
					return this.columnnombre;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn passwordColumn
			{
				get
				{
					return this.columnpassword;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TUsuarioDataTable()
			{
				base.TableName = "TUsuario";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TUsuarioDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TUsuarioDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTUsuarioRow(masterDBACDataSet.TUsuarioRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TUsuarioRow AddTUsuarioRow(string nombre, string login, byte[] password, masterDBACDataSet.TTipoUsuarioRow parentTTipoUsuarioRowByFK_TUsuario_TTipoUsuario, DateTime fechaUltimaGestion, int usuarioUltimaGestion, byte[] fotoUsuario, short activo)
			{
				masterDBACDataSet.TUsuarioRow tUsuarioRow = (masterDBACDataSet.TUsuarioRow)base.NewRow();
				object[] objArray = new object[] { null, nombre, login, password, null, fechaUltimaGestion, usuarioUltimaGestion, fotoUsuario, activo };
				object[] item = objArray;
				if (parentTTipoUsuarioRowByFK_TUsuario_TTipoUsuario != null)
				{
					item[4] = parentTTipoUsuarioRowByFK_TUsuario_TTipoUsuario[0];
				}
				tUsuarioRow.ItemArray = item;
				base.Rows.Add(tUsuarioRow);
				return tUsuarioRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TUsuarioDataTable tUsuarioDataTable = (masterDBACDataSet.TUsuarioDataTable)base.Clone();
				tUsuarioDataTable.InitVars();
				return tUsuarioDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TUsuarioDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TUsuarioRow FindByidUsuario(int idUsuario)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idUsuario };
				return (masterDBACDataSet.TUsuarioRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TUsuarioRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TUsuarioDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidUsuario = new DataColumn("idUsuario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidUsuario);
				this.columnnombre = new DataColumn("nombre", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnombre);
				this.columnlogin = new DataColumn("login", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnlogin);
				this.columnpassword = new DataColumn("password", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnpassword);
				this.columnidTipoUsuario = new DataColumn("idTipoUsuario", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoUsuario);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnfotoUsuario = new DataColumn("fotoUsuario", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnfotoUsuario);
				this.columnactivo = new DataColumn("activo", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnactivo);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidUsuario };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidUsuario.AutoIncrement = true;
				this.columnidUsuario.AutoIncrementSeed = (long)-1;
				this.columnidUsuario.AutoIncrementStep = (long)-1;
				this.columnidUsuario.AllowDBNull = false;
				this.columnidUsuario.ReadOnly = true;
				this.columnidUsuario.Unique = true;
				this.columnnombre.MaxLength = 80;
				this.columnlogin.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidUsuario = base.Columns["idUsuario"];
				this.columnnombre = base.Columns["nombre"];
				this.columnlogin = base.Columns["login"];
				this.columnpassword = base.Columns["password"];
				this.columnidTipoUsuario = base.Columns["idTipoUsuario"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnfotoUsuario = base.Columns["fotoUsuario"];
				this.columnactivo = base.Columns["activo"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TUsuarioRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TUsuarioRow NewTUsuarioRow()
			{
				return (masterDBACDataSet.TUsuarioRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TUsuarioRowChanged != null)
				{
					this.TUsuarioRowChanged(this, new masterDBACDataSet.TUsuarioRowChangeEvent((masterDBACDataSet.TUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TUsuarioRowChanging != null)
				{
					this.TUsuarioRowChanging(this, new masterDBACDataSet.TUsuarioRowChangeEvent((masterDBACDataSet.TUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TUsuarioRowDeleted != null)
				{
					this.TUsuarioRowDeleted(this, new masterDBACDataSet.TUsuarioRowChangeEvent((masterDBACDataSet.TUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TUsuarioRowDeleting != null)
				{
					this.TUsuarioRowDeleting(this, new masterDBACDataSet.TUsuarioRowChangeEvent((masterDBACDataSet.TUsuarioRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTUsuarioRow(masterDBACDataSet.TUsuarioRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TUsuarioRowChangeEventHandler TUsuarioRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TUsuarioRowChangeEventHandler TUsuarioRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TUsuarioRowChangeEventHandler TUsuarioRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TUsuarioRowChangeEventHandler TUsuarioRowDeleting;
		}

		public class TUsuarioRow : DataRow
		{
			private masterDBACDataSet.TUsuarioDataTable tableTUsuario;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public short activo
			{
				get
				{
					short item;
					try
					{
						item = (short)base[this.tableTUsuario.activoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'activo' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.activoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTUsuario.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] fotoUsuario
			{
				get
				{
					byte[] item;
					try
					{
						item = (byte[])base[this.tableTUsuario.fotoUsuarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fotoUsuario' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.fotoUsuarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoUsuario
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTUsuario.idTipoUsuarioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoUsuario' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.idTipoUsuarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idUsuario
			{
				get
				{
					return (int)base[this.tableTUsuario.idUsuarioColumn];
				}
				set
				{
					base[this.tableTUsuario.idUsuarioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string login
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTUsuario.loginColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'login' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.loginColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nombre
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTUsuario.nombreColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'nombre' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.nombreColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] password
			{
				get
				{
					byte[] item;
					try
					{
						item = (byte[])base[this.tableTUsuario.passwordColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'password' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.passwordColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoUsuarioRow TTipoUsuarioRow
			{
				get
				{
					masterDBACDataSet.TTipoUsuarioRow parentRow = (masterDBACDataSet.TTipoUsuarioRow)base.GetParentRow(base.Table.ParentRelations["FK_TUsuario_TTipoUsuario"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TUsuario_TTipoUsuario"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTUsuario.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TUsuario' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTUsuario.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TUsuarioRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTUsuario = (masterDBACDataSet.TUsuarioDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsactivoNull()
			{
				return base.IsNull(this.tableTUsuario.activoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTUsuario.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfotoUsuarioNull()
			{
				return base.IsNull(this.tableTUsuario.fotoUsuarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoUsuarioNull()
			{
				return base.IsNull(this.tableTUsuario.idTipoUsuarioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsloginNull()
			{
				return base.IsNull(this.tableTUsuario.loginColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnombreNull()
			{
				return base.IsNull(this.tableTUsuario.nombreColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspasswordNull()
			{
				return base.IsNull(this.tableTUsuario.passwordColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTUsuario.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetactivoNull()
			{
				base[this.tableTUsuario.activoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTUsuario.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfotoUsuarioNull()
			{
				base[this.tableTUsuario.fotoUsuarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoUsuarioNull()
			{
				base[this.tableTUsuario.idTipoUsuarioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetloginNull()
			{
				base[this.tableTUsuario.loginColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnombreNull()
			{
				base[this.tableTUsuario.nombreColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpasswordNull()
			{
				base[this.tableTUsuario.passwordColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTUsuario.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TUsuarioRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TUsuarioRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TUsuarioRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TUsuarioRowChangeEvent(masterDBACDataSet.TUsuarioRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TUsuarioRowChangeEventHandler(object sender, masterDBACDataSet.TUsuarioRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TVehiculoDataTable : TypedTableBase<masterDBACDataSet.TVehiculoRow>
		{
			private DataColumn columnidVehiculo;

			private DataColumn columnPlaca;

			private DataColumn columnidModeloVehiculo;

			private DataColumn columnCodigodeBarras;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columncolor;

			private DataColumn columnestaOcupado;

			private DataColumn columnfechaUltOcup;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CodigodeBarrasColumn
			{
				get
				{
					return this.columnCodigodeBarras;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn colorColumn
			{
				get
				{
					return this.columncolor;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn estaOcupadoColumn
			{
				get
				{
					return this.columnestaOcupado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltOcupColumn
			{
				get
				{
					return this.columnfechaUltOcup;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idModeloVehiculoColumn
			{
				get
				{
					return this.columnidModeloVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVehiculoColumn
			{
				get
				{
					return this.columnidVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PlacaColumn
			{
				get
				{
					return this.columnPlaca;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVehiculoDataTable()
			{
				base.TableName = "TVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTVehiculoRow(masterDBACDataSet.TVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow AddTVehiculoRow(string Placa, masterDBACDataSet.TModeloVehiculoRow parentTModeloVehiculoRowByFK_TVehiculo_TModeloVehiculo, string CodigodeBarras, DateTime fechaUltimaGestion, int usuarioUltimaGestion, string color, bool estaOcupado, DateTime fechaUltOcup)
			{
				masterDBACDataSet.TVehiculoRow tVehiculoRow = (masterDBACDataSet.TVehiculoRow)base.NewRow();
				object[] placa = new object[] { null, Placa, null, CodigodeBarras, fechaUltimaGestion, usuarioUltimaGestion, color, estaOcupado, fechaUltOcup };
				object[] item = placa;
				if (parentTModeloVehiculoRowByFK_TVehiculo_TModeloVehiculo != null)
				{
					item[2] = parentTModeloVehiculoRowByFK_TVehiculo_TModeloVehiculo[0];
				}
				tVehiculoRow.ItemArray = item;
				base.Rows.Add(tVehiculoRow);
				return tVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TVehiculoDataTable tVehiculoDataTable = (masterDBACDataSet.TVehiculoDataTable)base.Clone();
				tVehiculoDataTable.InitVars();
				return tVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow FindByidVehiculo(int idVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idVehiculo };
				return (masterDBACDataSet.TVehiculoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidVehiculo = new DataColumn("idVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidVehiculo);
				this.columnPlaca = new DataColumn("Placa", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPlaca);
				this.columnidModeloVehiculo = new DataColumn("idModeloVehiculo", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnidModeloVehiculo);
				this.columnCodigodeBarras = new DataColumn("CodigodeBarras", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCodigodeBarras);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columncolor = new DataColumn("color", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncolor);
				this.columnestaOcupado = new DataColumn("estaOcupado", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnestaOcupado);
				this.columnfechaUltOcup = new DataColumn("fechaUltOcup", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltOcup);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidVehiculo.AutoIncrement = true;
				this.columnidVehiculo.AutoIncrementSeed = (long)-1;
				this.columnidVehiculo.AutoIncrementStep = (long)-1;
				this.columnidVehiculo.AllowDBNull = false;
				this.columnidVehiculo.ReadOnly = true;
				this.columnidVehiculo.Unique = true;
				this.columnPlaca.MaxLength = 8;
				this.columnCodigodeBarras.MaxLength = 50;
				this.columncolor.MaxLength = 30;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidVehiculo = base.Columns["idVehiculo"];
				this.columnPlaca = base.Columns["Placa"];
				this.columnidModeloVehiculo = base.Columns["idModeloVehiculo"];
				this.columnCodigodeBarras = base.Columns["CodigodeBarras"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columncolor = base.Columns["color"];
				this.columnestaOcupado = base.Columns["estaOcupado"];
				this.columnfechaUltOcup = base.Columns["fechaUltOcup"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow NewTVehiculoRow()
			{
				return (masterDBACDataSet.TVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TVehiculoRowChanged != null)
				{
					this.TVehiculoRowChanged(this, new masterDBACDataSet.TVehiculoRowChangeEvent((masterDBACDataSet.TVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TVehiculoRowChanging != null)
				{
					this.TVehiculoRowChanging(this, new masterDBACDataSet.TVehiculoRowChangeEvent((masterDBACDataSet.TVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TVehiculoRowDeleted != null)
				{
					this.TVehiculoRowDeleted(this, new masterDBACDataSet.TVehiculoRowChangeEvent((masterDBACDataSet.TVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TVehiculoRowDeleting != null)
				{
					this.TVehiculoRowDeleting(this, new masterDBACDataSet.TVehiculoRowChangeEvent((masterDBACDataSet.TVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTVehiculoRow(masterDBACDataSet.TVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVehiculoRowChangeEventHandler TVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVehiculoRowChangeEventHandler TVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVehiculoRowChangeEventHandler TVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVehiculoRowChangeEventHandler TVehiculoRowDeleting;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TvehiculoParqueoDataTable : TypedTableBase<masterDBACDataSet.TvehiculoParqueoRow>
		{
			private DataColumn columnidVehiculo;

			private DataColumn columnidParqueadero;

			private DataColumn columndiaSemana;

			private DataColumn columnObservacionesVP;

			private DataColumn columndia1;

			private DataColumn columndia2;

			private DataColumn columndia3;

			private DataColumn columndia4;

			private DataColumn columndia5;

			private DataColumn columndia6;

			private DataColumn columndia7;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnid;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia1Column
			{
				get
				{
					return this.columndia1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia2Column
			{
				get
				{
					return this.columndia2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia3Column
			{
				get
				{
					return this.columndia3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia4Column
			{
				get
				{
					return this.columndia4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia5Column
			{
				get
				{
					return this.columndia5;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia6Column
			{
				get
				{
					return this.columndia6;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dia7Column
			{
				get
				{
					return this.columndia7;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn diaSemanaColumn
			{
				get
				{
					return this.columndiaSemana;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idParqueaderoColumn
			{
				get
				{
					return this.columnidParqueadero;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVehiculoColumn
			{
				get
				{
					return this.columnidVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TvehiculoParqueoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TvehiculoParqueoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesVPColumn
			{
				get
				{
					return this.columnObservacionesVP;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TvehiculoParqueoDataTable()
			{
				base.TableName = "TvehiculoParqueo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TvehiculoParqueoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TvehiculoParqueoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTvehiculoParqueoRow(masterDBACDataSet.TvehiculoParqueoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TvehiculoParqueoRow AddTvehiculoParqueoRow(masterDBACDataSet.TVehiculoRow parentTVehiculoRowByFK_TvehiculoParqueo_TVehiculo, masterDBACDataSet.TParqueoRow parentTParqueoRowByFK_TvehiculoParqueo_Tparqueo, byte diaSemana, string ObservacionesVP, bool dia1, bool dia2, bool dia3, bool dia4, bool dia5, bool dia6, bool dia7, DateTime fechaUltimaGestion, int usuarioUltimaGestion)
			{
				masterDBACDataSet.TvehiculoParqueoRow tvehiculoParqueoRow = (masterDBACDataSet.TvehiculoParqueoRow)base.NewRow();
				object[] objArray = new object[] { null, null, diaSemana, ObservacionesVP, dia1, dia2, dia3, dia4, dia5, dia6, dia7, fechaUltimaGestion, usuarioUltimaGestion, null };
				object[] item = objArray;
				if (parentTVehiculoRowByFK_TvehiculoParqueo_TVehiculo != null)
				{
					item[0] = parentTVehiculoRowByFK_TvehiculoParqueo_TVehiculo[0];
				}
				if (parentTParqueoRowByFK_TvehiculoParqueo_Tparqueo != null)
				{
					item[1] = parentTParqueoRowByFK_TvehiculoParqueo_Tparqueo[0];
				}
				tvehiculoParqueoRow.ItemArray = item;
				base.Rows.Add(tvehiculoParqueoRow);
				return tvehiculoParqueoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TvehiculoParqueoDataTable tvehiculoParqueoDataTable = (masterDBACDataSet.TvehiculoParqueoDataTable)base.Clone();
				tvehiculoParqueoDataTable.InitVars();
				return tvehiculoParqueoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TvehiculoParqueoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TvehiculoParqueoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TvehiculoParqueoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidVehiculo = new DataColumn("idVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidVehiculo);
				this.columnidParqueadero = new DataColumn("idParqueadero", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParqueadero);
				this.columndiaSemana = new DataColumn("diaSemana", typeof(byte), null, MappingType.Element);
				base.Columns.Add(this.columndiaSemana);
				this.columnObservacionesVP = new DataColumn("ObservacionesVP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesVP);
				this.columndia1 = new DataColumn("dia1", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia1);
				this.columndia2 = new DataColumn("dia2", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia2);
				this.columndia3 = new DataColumn("dia3", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia3);
				this.columndia4 = new DataColumn("dia4", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia4);
				this.columndia5 = new DataColumn("dia5", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia5);
				this.columndia6 = new DataColumn("dia6", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia6);
				this.columndia7 = new DataColumn("dia7", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndia7);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnid };
				constraints.Add(new UniqueConstraint("Constraint2", dataColumnArray, false));
				this.columnObservacionesVP.MaxLength = 2147483647;
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = (long)-1;
				this.columnid.AutoIncrementStep = (long)-1;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidVehiculo = base.Columns["idVehiculo"];
				this.columnidParqueadero = base.Columns["idParqueadero"];
				this.columndiaSemana = base.Columns["diaSemana"];
				this.columnObservacionesVP = base.Columns["ObservacionesVP"];
				this.columndia1 = base.Columns["dia1"];
				this.columndia2 = base.Columns["dia2"];
				this.columndia3 = base.Columns["dia3"];
				this.columndia4 = base.Columns["dia4"];
				this.columndia5 = base.Columns["dia5"];
				this.columndia6 = base.Columns["dia6"];
				this.columndia7 = base.Columns["dia7"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnid = base.Columns["id"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TvehiculoParqueoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TvehiculoParqueoRow NewTvehiculoParqueoRow()
			{
				return (masterDBACDataSet.TvehiculoParqueoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TvehiculoParqueoRowChanged != null)
				{
					this.TvehiculoParqueoRowChanged(this, new masterDBACDataSet.TvehiculoParqueoRowChangeEvent((masterDBACDataSet.TvehiculoParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TvehiculoParqueoRowChanging != null)
				{
					this.TvehiculoParqueoRowChanging(this, new masterDBACDataSet.TvehiculoParqueoRowChangeEvent((masterDBACDataSet.TvehiculoParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TvehiculoParqueoRowDeleted != null)
				{
					this.TvehiculoParqueoRowDeleted(this, new masterDBACDataSet.TvehiculoParqueoRowChangeEvent((masterDBACDataSet.TvehiculoParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TvehiculoParqueoRowDeleting != null)
				{
					this.TvehiculoParqueoRowDeleting(this, new masterDBACDataSet.TvehiculoParqueoRowChangeEvent((masterDBACDataSet.TvehiculoParqueoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTvehiculoParqueoRow(masterDBACDataSet.TvehiculoParqueoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TvehiculoParqueoRowChangeEventHandler TvehiculoParqueoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TvehiculoParqueoRowChangeEventHandler TvehiculoParqueoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TvehiculoParqueoRowChangeEventHandler TvehiculoParqueoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TvehiculoParqueoRowChangeEventHandler TvehiculoParqueoRowDeleting;
		}

		public class TvehiculoParqueoRow : DataRow
		{
			private masterDBACDataSet.TvehiculoParqueoDataTable tableTvehiculoParqueo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia1
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia1Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia1' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia2
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia2Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia2' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia2Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia3
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia3Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia3' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia3Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia4
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia4Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia4' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia4Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia5
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia5Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia5' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia5Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia6
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia6Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia6' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia6Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool dia7
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTvehiculoParqueo.dia7Column];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'dia7' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.dia7Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte diaSemana
			{
				get
				{
					byte item;
					try
					{
						item = (byte)base[this.tableTvehiculoParqueo.diaSemanaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'diaSemana' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.diaSemanaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTvehiculoParqueo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.tableTvehiculoParqueo.idColumn];
				}
				set
				{
					base[this.tableTvehiculoParqueo.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idParqueadero
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTvehiculoParqueo.idParqueaderoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idParqueadero' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.idParqueaderoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idVehiculo
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTvehiculoParqueo.idVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idVehiculo' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.idVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesVP
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTvehiculoParqueo.ObservacionesVPColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesVP' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.ObservacionesVPColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TParqueoRow TParqueoRow
			{
				get
				{
					masterDBACDataSet.TParqueoRow parentRow = (masterDBACDataSet.TParqueoRow)base.GetParentRow(base.Table.ParentRelations["FK_TvehiculoParqueo_Tparqueo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TvehiculoParqueo_Tparqueo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow TVehiculoRow
			{
				get
				{
					masterDBACDataSet.TVehiculoRow parentRow = (masterDBACDataSet.TVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TvehiculoParqueo_TVehiculo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TvehiculoParqueo_TVehiculo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTvehiculoParqueo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TvehiculoParqueo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTvehiculoParqueo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TvehiculoParqueoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTvehiculoParqueo = (masterDBACDataSet.TvehiculoParqueoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia1Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia1Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia2Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia2Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia3Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia3Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia4Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia4Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia5Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia5Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia6Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia6Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isdia7Null()
			{
				return base.IsNull(this.tableTvehiculoParqueo.dia7Column);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdiaSemanaNull()
			{
				return base.IsNull(this.tableTvehiculoParqueo.diaSemanaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTvehiculoParqueo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidParqueaderoNull()
			{
				return base.IsNull(this.tableTvehiculoParqueo.idParqueaderoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidVehiculoNull()
			{
				return base.IsNull(this.tableTvehiculoParqueo.idVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesVPNull()
			{
				return base.IsNull(this.tableTvehiculoParqueo.ObservacionesVPColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTvehiculoParqueo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia1Null()
			{
				base[this.tableTvehiculoParqueo.dia1Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia2Null()
			{
				base[this.tableTvehiculoParqueo.dia2Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia3Null()
			{
				base[this.tableTvehiculoParqueo.dia3Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia4Null()
			{
				base[this.tableTvehiculoParqueo.dia4Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia5Null()
			{
				base[this.tableTvehiculoParqueo.dia5Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia6Null()
			{
				base[this.tableTvehiculoParqueo.dia6Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setdia7Null()
			{
				base[this.tableTvehiculoParqueo.dia7Column] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdiaSemanaNull()
			{
				base[this.tableTvehiculoParqueo.diaSemanaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTvehiculoParqueo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidParqueaderoNull()
			{
				base[this.tableTvehiculoParqueo.idParqueaderoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidVehiculoNull()
			{
				base[this.tableTvehiculoParqueo.idVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesVPNull()
			{
				base[this.tableTvehiculoParqueo.ObservacionesVPColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTvehiculoParqueo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TvehiculoParqueoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TvehiculoParqueoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TvehiculoParqueoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TvehiculoParqueoRowChangeEvent(masterDBACDataSet.TvehiculoParqueoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TvehiculoParqueoRowChangeEventHandler(object sender, masterDBACDataSet.TvehiculoParqueoRowChangeEvent e);

		public class TVehiculoRow : DataRow
		{
			private masterDBACDataSet.TVehiculoDataTable tableTVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CodigodeBarras
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVehiculo.CodigodeBarrasColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'CodigodeBarras' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.CodigodeBarrasColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string color
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVehiculo.colorColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'color' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.colorColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool estaOcupado
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTVehiculo.estaOcupadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'estaOcupado' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.estaOcupadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVehiculo.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltOcup
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVehiculo.fechaUltOcupColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltOcup' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.fechaUltOcupColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public short idModeloVehiculo
			{
				get
				{
					short item;
					try
					{
						item = (short)base[this.tableTVehiculo.idModeloVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idModeloVehiculo' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.idModeloVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idVehiculo
			{
				get
				{
					return (int)base[this.tableTVehiculo.idVehiculoColumn];
				}
				set
				{
					base[this.tableTVehiculo.idVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Placa
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVehiculo.PlacaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Placa' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.PlacaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TModeloVehiculoRow TModeloVehiculoRow
			{
				get
				{
					masterDBACDataSet.TModeloVehiculoRow parentRow = (masterDBACDataSet.TModeloVehiculoRow)base.GetParentRow(base.Table.ParentRelations["FK_TVehiculo_TModeloVehiculo"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVehiculo_TModeloVehiculo"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVehiculo.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVehiculo.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTVehiculo = (masterDBACDataSet.TVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoVehiculoRow[] GetTEmpleadoVehiculoRows()
			{
				masterDBACDataSet.TEmpleadoVehiculoRow[] tEmpleadoVehiculoRowArray;
				tEmpleadoVehiculoRowArray = (base.Table.ChildRelations["FK_TEmpleadoVehiculo_TVehiculo"] != null ? (masterDBACDataSet.TEmpleadoVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TEmpleadoVehiculo_TVehiculo"]) : new masterDBACDataSet.TEmpleadoVehiculoRow[0]);
				return tEmpleadoVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculo1Row[] GetTRegistroVehiculo1Rows()
			{
				masterDBACDataSet.TRegistroVehiculo1Row[] tRegistroVehiculo1RowArray;
				tRegistroVehiculo1RowArray = (base.Table.ChildRelations["FK_TRegistroVehiculo_TVehiculo1"] != null ? (masterDBACDataSet.TRegistroVehiculo1Row[])base.GetChildRows(base.Table.ChildRelations["FK_TRegistroVehiculo_TVehiculo1"]) : new masterDBACDataSet.TRegistroVehiculo1Row[0]);
				return tRegistroVehiculo1RowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TRegistroVehiculoRow[] GetTRegistroVehiculoRows()
			{
				masterDBACDataSet.TRegistroVehiculoRow[] tRegistroVehiculoRowArray;
				tRegistroVehiculoRowArray = (base.Table.ChildRelations["FK_TRegistroVehiculo_TVehiculo"] != null ? (masterDBACDataSet.TRegistroVehiculoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TRegistroVehiculo_TVehiculo"]) : new masterDBACDataSet.TRegistroVehiculoRow[0]);
				return tRegistroVehiculoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TvehiculoParqueoRow[] GetTvehiculoParqueoRows()
			{
				masterDBACDataSet.TvehiculoParqueoRow[] tvehiculoParqueoRowArray;
				tvehiculoParqueoRowArray = (base.Table.ChildRelations["FK_TvehiculoParqueo_TVehiculo"] != null ? (masterDBACDataSet.TvehiculoParqueoRow[])base.GetChildRows(base.Table.ChildRelations["FK_TvehiculoParqueo_TVehiculo"]) : new masterDBACDataSet.TvehiculoParqueoRow[0]);
				return tvehiculoParqueoRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCodigodeBarrasNull()
			{
				return base.IsNull(this.tableTVehiculo.CodigodeBarrasColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IscolorNull()
			{
				return base.IsNull(this.tableTVehiculo.colorColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsestaOcupadoNull()
			{
				return base.IsNull(this.tableTVehiculo.estaOcupadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTVehiculo.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltOcupNull()
			{
				return base.IsNull(this.tableTVehiculo.fechaUltOcupColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidModeloVehiculoNull()
			{
				return base.IsNull(this.tableTVehiculo.idModeloVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPlacaNull()
			{
				return base.IsNull(this.tableTVehiculo.PlacaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTVehiculo.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCodigodeBarrasNull()
			{
				base[this.tableTVehiculo.CodigodeBarrasColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetcolorNull()
			{
				base[this.tableTVehiculo.colorColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetestaOcupadoNull()
			{
				base[this.tableTVehiculo.estaOcupadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTVehiculo.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltOcupNull()
			{
				base[this.tableTVehiculo.fechaUltOcupColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidModeloVehiculoNull()
			{
				base[this.tableTVehiculo.idModeloVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPlacaNull()
			{
				base[this.tableTVehiculo.PlacaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTVehiculo.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVehiculoRowChangeEvent(masterDBACDataSet.TVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.TVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TVisitanteDataTable : TypedTableBase<masterDBACDataSet.TVisitanteRow>
		{
			private DataColumn columnidVisitante;

			private DataColumn columnnombreVisitante;

			private DataColumn columnidTipoIdentificacion;

			private DataColumn columnidentificacionVisitante;

			private DataColumn columnhuella;

			private DataColumn columnfoto;

			private DataColumn columnidEmpresaVisitante;

			private DataColumn columnobservacionesVisitante;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnempresa;

			private DataColumn columndireccion;

			private DataColumn columntelefonos;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn direccionColumn
			{
				get
				{
					return this.columndireccion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn empresaColumn
			{
				get
				{
					return this.columnempresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fotoColumn
			{
				get
				{
					return this.columnfoto;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn huellaColumn
			{
				get
				{
					return this.columnhuella;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpresaVisitanteColumn
			{
				get
				{
					return this.columnidEmpresaVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn identificacionVisitanteColumn
			{
				get
				{
					return this.columnidentificacionVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTipoIdentificacionColumn
			{
				get
				{
					return this.columnidTipoIdentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitanteColumn
			{
				get
				{
					return this.columnidVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TVisitanteRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nombreVisitanteColumn
			{
				get
				{
					return this.columnnombreVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn observacionesVisitanteColumn
			{
				get
				{
					return this.columnobservacionesVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn telefonosColumn
			{
				get
				{
					return this.columntelefonos;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitanteDataTable()
			{
				base.TableName = "TVisitante";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitanteDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TVisitanteDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTVisitanteRow(masterDBACDataSet.TVisitanteRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow AddTVisitanteRow(string nombreVisitante, masterDBACDataSet.TTipoIdentificacionRow parentTTipoIdentificacionRowByFK_TVisitante_TTipoIdentificacion, string identificacionVisitante, string huella, byte[] foto, int idEmpresaVisitante, string observacionesVisitante, DateTime fechaUltimaGestion, int usuarioUltimaGestion, string empresa, string direccion, string telefonos)
			{
				masterDBACDataSet.TVisitanteRow tVisitanteRow = (masterDBACDataSet.TVisitanteRow)base.NewRow();
				object[] objArray = new object[] { null, nombreVisitante, null, identificacionVisitante, huella, foto, idEmpresaVisitante, observacionesVisitante, fechaUltimaGestion, usuarioUltimaGestion, empresa, direccion, telefonos };
				object[] item = objArray;
				if (parentTTipoIdentificacionRowByFK_TVisitante_TTipoIdentificacion != null)
				{
					item[2] = parentTTipoIdentificacionRowByFK_TVisitante_TTipoIdentificacion[0];
				}
				tVisitanteRow.ItemArray = item;
				base.Rows.Add(tVisitanteRow);
				return tVisitanteRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TVisitanteDataTable tVisitanteDataTable = (masterDBACDataSet.TVisitanteDataTable)base.Clone();
				tVisitanteDataTable.InitVars();
				return tVisitanteDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TVisitanteDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow FindByidVisitante(decimal idVisitante)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idVisitante };
				return (masterDBACDataSet.TVisitanteRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TVisitanteRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TVisitanteDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidVisitante = new DataColumn("idVisitante", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitante);
				this.columnnombreVisitante = new DataColumn("nombreVisitante", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnombreVisitante);
				this.columnidTipoIdentificacion = new DataColumn("idTipoIdentificacion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTipoIdentificacion);
				this.columnidentificacionVisitante = new DataColumn("identificacionVisitante", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnidentificacionVisitante);
				this.columnhuella = new DataColumn("huella", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhuella);
				this.columnfoto = new DataColumn("foto", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnfoto);
				this.columnidEmpresaVisitante = new DataColumn("idEmpresaVisitante", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpresaVisitante);
				this.columnobservacionesVisitante = new DataColumn("observacionesVisitante", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnobservacionesVisitante);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnempresa = new DataColumn("empresa", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnempresa);
				this.columndireccion = new DataColumn("direccion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndireccion);
				this.columntelefonos = new DataColumn("telefonos", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntelefonos);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidVisitante };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidVisitante.AutoIncrement = true;
				this.columnidVisitante.AutoIncrementSeed = (long)-1;
				this.columnidVisitante.AutoIncrementStep = (long)-1;
				this.columnidVisitante.AllowDBNull = false;
				this.columnidVisitante.ReadOnly = true;
				this.columnidVisitante.Unique = true;
				this.columnnombreVisitante.MaxLength = 70;
				this.columnidentificacionVisitante.MaxLength = 25;
				this.columnhuella.MaxLength = 2147483647;
				this.columnobservacionesVisitante.MaxLength = 2147483647;
				this.columnempresa.MaxLength = 70;
				this.columndireccion.MaxLength = 100;
				this.columntelefonos.MaxLength = 100;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidVisitante = base.Columns["idVisitante"];
				this.columnnombreVisitante = base.Columns["nombreVisitante"];
				this.columnidTipoIdentificacion = base.Columns["idTipoIdentificacion"];
				this.columnidentificacionVisitante = base.Columns["identificacionVisitante"];
				this.columnhuella = base.Columns["huella"];
				this.columnfoto = base.Columns["foto"];
				this.columnidEmpresaVisitante = base.Columns["idEmpresaVisitante"];
				this.columnobservacionesVisitante = base.Columns["observacionesVisitante"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnempresa = base.Columns["empresa"];
				this.columndireccion = base.Columns["direccion"];
				this.columntelefonos = base.Columns["telefonos"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TVisitanteRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow NewTVisitanteRow()
			{
				return (masterDBACDataSet.TVisitanteRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TVisitanteRowChanged != null)
				{
					this.TVisitanteRowChanged(this, new masterDBACDataSet.TVisitanteRowChangeEvent((masterDBACDataSet.TVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TVisitanteRowChanging != null)
				{
					this.TVisitanteRowChanging(this, new masterDBACDataSet.TVisitanteRowChangeEvent((masterDBACDataSet.TVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TVisitanteRowDeleted != null)
				{
					this.TVisitanteRowDeleted(this, new masterDBACDataSet.TVisitanteRowChangeEvent((masterDBACDataSet.TVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TVisitanteRowDeleting != null)
				{
					this.TVisitanteRowDeleting(this, new masterDBACDataSet.TVisitanteRowChangeEvent((masterDBACDataSet.TVisitanteRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTVisitanteRow(masterDBACDataSet.TVisitanteRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteRowChangeEventHandler TVisitanteRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteRowChangeEventHandler TVisitanteRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteRowChangeEventHandler TVisitanteRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteRowChangeEventHandler TVisitanteRowDeleting;
		}

		public class TVisitanteRow : DataRow
		{
			private masterDBACDataSet.TVisitanteDataTable tableTVisitante;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string direccion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.direccionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'direccion' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.direccionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string empresa
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.empresaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'empresa' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.empresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitante.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] foto
			{
				get
				{
					byte[] item;
					try
					{
						item = (byte[])base[this.tableTVisitante.fotoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'foto' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.fotoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string huella
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.huellaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'huella' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.huellaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpresaVisitante
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitante.idEmpresaVisitanteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpresaVisitante' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.idEmpresaVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string identificacionVisitante
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.identificacionVisitanteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'identificacionVisitante' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.identificacionVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTipoIdentificacion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitante.idTipoIdentificacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTipoIdentificacion' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.idTipoIdentificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitante
			{
				get
				{
					return (decimal)base[this.tableTVisitante.idVisitanteColumn];
				}
				set
				{
					base[this.tableTVisitante.idVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nombreVisitante
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.nombreVisitanteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'nombreVisitante' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.nombreVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string observacionesVisitante
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.observacionesVisitanteColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'observacionesVisitante' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.observacionesVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string telefonos
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitante.telefonosColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'telefonos' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.telefonosColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TTipoIdentificacionRow TTipoIdentificacionRow
			{
				get
				{
					masterDBACDataSet.TTipoIdentificacionRow parentRow = (masterDBACDataSet.TTipoIdentificacionRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitante_TTipoIdentificacion"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitante_TTipoIdentificacion"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitante.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TVisitante' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitante.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitanteRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTVisitante = (masterDBACDataSet.TVisitanteDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[] GetTVisitanteVisitaProgramadaLogRows()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[] tVisitanteVisitaProgramadaLogRowArray;
				tVisitanteVisitaProgramadaLogRowArray = (base.Table.ChildRelations["FK_TVisitanteVisitaProgramadaLog_TVisitante"] != null ? (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitanteVisitaProgramadaLog_TVisitante"]) : new masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[0]);
				return tVisitanteVisitaProgramadaLogRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow[] GetTVisitanteVisitaProgramadaRows()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaRow[] tVisitanteVisitaProgramadaRowArray;
				tVisitanteVisitaProgramadaRowArray = (base.Table.ChildRelations["FK_TVisitanteVisitaProgramada_TVisitante"] != null ? (masterDBACDataSet.TVisitanteVisitaProgramadaRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitanteVisitaProgramada_TVisitante"]) : new masterDBACDataSet.TVisitanteVisitaProgramadaRow[0]);
				return tVisitanteVisitaProgramadaRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdireccionNull()
			{
				return base.IsNull(this.tableTVisitante.direccionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsempresaNull()
			{
				return base.IsNull(this.tableTVisitante.empresaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitante.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfotoNull()
			{
				return base.IsNull(this.tableTVisitante.fotoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IshuellaNull()
			{
				return base.IsNull(this.tableTVisitante.huellaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpresaVisitanteNull()
			{
				return base.IsNull(this.tableTVisitante.idEmpresaVisitanteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidentificacionVisitanteNull()
			{
				return base.IsNull(this.tableTVisitante.identificacionVisitanteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTipoIdentificacionNull()
			{
				return base.IsNull(this.tableTVisitante.idTipoIdentificacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnombreVisitanteNull()
			{
				return base.IsNull(this.tableTVisitante.nombreVisitanteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsobservacionesVisitanteNull()
			{
				return base.IsNull(this.tableTVisitante.observacionesVisitanteColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstelefonosNull()
			{
				return base.IsNull(this.tableTVisitante.telefonosColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitante.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdireccionNull()
			{
				base[this.tableTVisitante.direccionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetempresaNull()
			{
				base[this.tableTVisitante.empresaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTVisitante.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfotoNull()
			{
				base[this.tableTVisitante.fotoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SethuellaNull()
			{
				base[this.tableTVisitante.huellaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpresaVisitanteNull()
			{
				base[this.tableTVisitante.idEmpresaVisitanteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidentificacionVisitanteNull()
			{
				base[this.tableTVisitante.identificacionVisitanteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTipoIdentificacionNull()
			{
				base[this.tableTVisitante.idTipoIdentificacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnombreVisitanteNull()
			{
				base[this.tableTVisitante.nombreVisitanteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetobservacionesVisitanteNull()
			{
				base[this.tableTVisitante.observacionesVisitanteColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettelefonosNull()
			{
				base[this.tableTVisitante.telefonosColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTVisitante.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TVisitanteRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TVisitanteRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitanteRowChangeEvent(masterDBACDataSet.TVisitanteRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TVisitanteRowChangeEventHandler(object sender, masterDBACDataSet.TVisitanteRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TVisitanteVisitaProgramadaDataTable : TypedTableBase<masterDBACDataSet.TVisitanteVisitaProgramadaRow>
		{
			private DataColumn columnidVisitante;

			private DataColumn columnidVisitaProgramada;

			private DataColumn columnidEmpleadoAutorizaEntrada;

			private DataColumn columnfechaLlegada;

			private DataColumn columnfechaSalida;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnvisitacumplida;

			private DataColumn columntarjeta;

			private DataColumn columnidTarjeta;

			private DataColumn columnObservacionesVisita;

			private DataColumn columnidTabla;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaLlegadaColumn
			{
				get
				{
					return this.columnfechaLlegada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaSalidaColumn
			{
				get
				{
					return this.columnfechaSalida;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoAutorizaEntradaColumn
			{
				get
				{
					return this.columnidEmpleadoAutorizaEntrada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTablaColumn
			{
				get
				{
					return this.columnidTabla;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTarjetaColumn
			{
				get
				{
					return this.columnidTarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitanteColumn
			{
				get
				{
					return this.columnidVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitaProgramadaColumn
			{
				get
				{
					return this.columnidVisitaProgramada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TVisitanteVisitaProgramadaRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesVisitaColumn
			{
				get
				{
					return this.columnObservacionesVisita;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tarjetaColumn
			{
				get
				{
					return this.columntarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn visitacumplidaColumn
			{
				get
				{
					return this.columnvisitacumplida;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitanteVisitaProgramadaDataTable()
			{
				base.TableName = "TVisitanteVisitaProgramada";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitanteVisitaProgramadaDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TVisitanteVisitaProgramadaDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTVisitanteVisitaProgramadaRow(masterDBACDataSet.TVisitanteVisitaProgramadaRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow AddTVisitanteVisitaProgramadaRow(masterDBACDataSet.TVisitanteRow parentTVisitanteRowByFK_TVisitanteVisitaProgramada_TVisitante, masterDBACDataSet.TVisitaProgramadaRow parentTVisitaProgramadaRowByFK_TVisitanteVisitaProgramada_TVisitaProgramada, masterDBACDataSet.TEmpleadoRow parentTEmpleadoRowByFK_TVisitanteVisitaProgramada_TEmpleado, DateTime fechaLlegada, DateTime fechaSalida, DateTime fechaUltimaGestion, int usuarioUltimaGestion, bool visitacumplida, string tarjeta, int idTarjeta, string ObservacionesVisita)
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaRow tVisitanteVisitaProgramadaRow = (masterDBACDataSet.TVisitanteVisitaProgramadaRow)base.NewRow();
				object[] objArray = new object[] { null, null, null, fechaLlegada, fechaSalida, fechaUltimaGestion, usuarioUltimaGestion, visitacumplida, tarjeta, idTarjeta, ObservacionesVisita, null };
				object[] item = objArray;
				if (parentTVisitanteRowByFK_TVisitanteVisitaProgramada_TVisitante != null)
				{
					item[0] = parentTVisitanteRowByFK_TVisitanteVisitaProgramada_TVisitante[0];
				}
				if (parentTVisitaProgramadaRowByFK_TVisitanteVisitaProgramada_TVisitaProgramada != null)
				{
					item[1] = parentTVisitaProgramadaRowByFK_TVisitanteVisitaProgramada_TVisitaProgramada[0];
				}
				if (parentTEmpleadoRowByFK_TVisitanteVisitaProgramada_TEmpleado != null)
				{
					item[2] = parentTEmpleadoRowByFK_TVisitanteVisitaProgramada_TEmpleado[0];
				}
				tVisitanteVisitaProgramadaRow.ItemArray = item;
				base.Rows.Add(tVisitanteVisitaProgramadaRow);
				return tVisitanteVisitaProgramadaRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaDataTable tVisitanteVisitaProgramadaDataTable = (masterDBACDataSet.TVisitanteVisitaProgramadaDataTable)base.Clone();
				tVisitanteVisitaProgramadaDataTable.InitVars();
				return tVisitanteVisitaProgramadaDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TVisitanteVisitaProgramadaDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow FindByidVisitanteidVisitaProgramada(decimal idVisitante, decimal idVisitaProgramada)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idVisitante, idVisitaProgramada };
				return (masterDBACDataSet.TVisitanteVisitaProgramadaRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TVisitanteVisitaProgramadaRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TVisitanteVisitaProgramadaDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidVisitante = new DataColumn("idVisitante", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitante);
				this.columnidVisitaProgramada = new DataColumn("idVisitaProgramada", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitaProgramada);
				this.columnidEmpleadoAutorizaEntrada = new DataColumn("idEmpleadoAutorizaEntrada", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleadoAutorizaEntrada);
				this.columnfechaLlegada = new DataColumn("fechaLlegada", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaLlegada);
				this.columnfechaSalida = new DataColumn("fechaSalida", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaSalida);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnvisitacumplida = new DataColumn("visitacumplida", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnvisitacumplida);
				this.columntarjeta = new DataColumn("tarjeta", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntarjeta);
				this.columnidTarjeta = new DataColumn("idTarjeta", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTarjeta);
				this.columnObservacionesVisita = new DataColumn("ObservacionesVisita", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesVisita);
				this.columnidTabla = new DataColumn("idTabla", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidTabla);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidVisitante, this.columnidVisitaProgramada };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidVisitante.AllowDBNull = false;
				this.columnidVisitaProgramada.AllowDBNull = false;
				this.columntarjeta.MaxLength = 50;
				this.columnObservacionesVisita.MaxLength = 2147483647;
				this.columnidTabla.AutoIncrement = true;
				this.columnidTabla.AutoIncrementSeed = (long)-1;
				this.columnidTabla.AutoIncrementStep = (long)-1;
				this.columnidTabla.AllowDBNull = false;
				this.columnidTabla.ReadOnly = true;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidVisitante = base.Columns["idVisitante"];
				this.columnidVisitaProgramada = base.Columns["idVisitaProgramada"];
				this.columnidEmpleadoAutorizaEntrada = base.Columns["idEmpleadoAutorizaEntrada"];
				this.columnfechaLlegada = base.Columns["fechaLlegada"];
				this.columnfechaSalida = base.Columns["fechaSalida"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnvisitacumplida = base.Columns["visitacumplida"];
				this.columntarjeta = base.Columns["tarjeta"];
				this.columnidTarjeta = base.Columns["idTarjeta"];
				this.columnObservacionesVisita = base.Columns["ObservacionesVisita"];
				this.columnidTabla = base.Columns["idTabla"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TVisitanteVisitaProgramadaRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow NewTVisitanteVisitaProgramadaRow()
			{
				return (masterDBACDataSet.TVisitanteVisitaProgramadaRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TVisitanteVisitaProgramadaRowChanged != null)
				{
					this.TVisitanteVisitaProgramadaRowChanged(this, new masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TVisitanteVisitaProgramadaRowChanging != null)
				{
					this.TVisitanteVisitaProgramadaRowChanging(this, new masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TVisitanteVisitaProgramadaRowDeleted != null)
				{
					this.TVisitanteVisitaProgramadaRowDeleted(this, new masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TVisitanteVisitaProgramadaRowDeleting != null)
				{
					this.TVisitanteVisitaProgramadaRowDeleting(this, new masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTVisitanteVisitaProgramadaRow(masterDBACDataSet.TVisitanteVisitaProgramadaRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEventHandler TVisitanteVisitaProgramadaRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEventHandler TVisitanteVisitaProgramadaRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEventHandler TVisitanteVisitaProgramadaRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEventHandler TVisitanteVisitaProgramadaRowDeleting;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TVisitanteVisitaProgramadaLogDataTable : TypedTableBase<masterDBACDataSet.TVisitanteVisitaProgramadaLogRow>
		{
			private DataColumn columnidTabla;

			private DataColumn columnidVisitante;

			private DataColumn columnidVisitaProgramada;

			private DataColumn columnidEmpleadoAutorizaEntrada;

			private DataColumn columnfechaRegistro;

			private DataColumn columnfechaLlegada;

			private DataColumn columnfechaSalida;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnvisitacumplida;

			private DataColumn columntarjeta;

			private DataColumn columnidTarjeta;

			private DataColumn columnObservacionesVisita;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaLlegadaColumn
			{
				get
				{
					return this.columnfechaLlegada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaRegistroColumn
			{
				get
				{
					return this.columnfechaRegistro;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaSalidaColumn
			{
				get
				{
					return this.columnfechaSalida;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoAutorizaEntradaColumn
			{
				get
				{
					return this.columnidEmpleadoAutorizaEntrada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTablaColumn
			{
				get
				{
					return this.columnidTabla;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTarjetaColumn
			{
				get
				{
					return this.columnidTarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitanteColumn
			{
				get
				{
					return this.columnidVisitante;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitaProgramadaColumn
			{
				get
				{
					return this.columnidVisitaProgramada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesVisitaColumn
			{
				get
				{
					return this.columnObservacionesVisita;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tarjetaColumn
			{
				get
				{
					return this.columntarjeta;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn visitacumplidaColumn
			{
				get
				{
					return this.columnvisitacumplida;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitanteVisitaProgramadaLogDataTable()
			{
				base.TableName = "TVisitanteVisitaProgramadaLog";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitanteVisitaProgramadaLogDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TVisitanteVisitaProgramadaLogDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTVisitanteVisitaProgramadaLogRow(masterDBACDataSet.TVisitanteVisitaProgramadaLogRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow AddTVisitanteVisitaProgramadaLogRow(masterDBACDataSet.TVisitanteRow parentTVisitanteRowByFK_TVisitanteVisitaProgramadaLog_TVisitante, masterDBACDataSet.TVisitaProgramadaRow parentTVisitaProgramadaRowByFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada, masterDBACDataSet.TEmpleadoRow parentTEmpleadoRowByFK_TVisitanteVisitaProgramadaLog_TEmpleado, DateTime fechaRegistro, DateTime fechaLlegada, DateTime fechaSalida, DateTime fechaUltimaGestion, int usuarioUltimaGestion, bool visitacumplida, string tarjeta, int idTarjeta, string ObservacionesVisita)
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaLogRow tVisitanteVisitaProgramadaLogRow = (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)base.NewRow();
				object[] objArray = new object[] { null, null, null, null, fechaRegistro, fechaLlegada, fechaSalida, fechaUltimaGestion, usuarioUltimaGestion, visitacumplida, tarjeta, idTarjeta, ObservacionesVisita };
				object[] item = objArray;
				if (parentTVisitanteRowByFK_TVisitanteVisitaProgramadaLog_TVisitante != null)
				{
					item[1] = parentTVisitanteRowByFK_TVisitanteVisitaProgramadaLog_TVisitante[0];
				}
				if (parentTVisitaProgramadaRowByFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada != null)
				{
					item[2] = parentTVisitaProgramadaRowByFK_TVisitanteVisitaProgramadaLog_TVisitaProgramada[0];
				}
				if (parentTEmpleadoRowByFK_TVisitanteVisitaProgramadaLog_TEmpleado != null)
				{
					item[3] = parentTEmpleadoRowByFK_TVisitanteVisitaProgramadaLog_TEmpleado[0];
				}
				tVisitanteVisitaProgramadaLogRow.ItemArray = item;
				base.Rows.Add(tVisitanteVisitaProgramadaLogRow);
				return tVisitanteVisitaProgramadaLogRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable tVisitanteVisitaProgramadaLogDataTable = (masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable)base.Clone();
				tVisitanteVisitaProgramadaLogDataTable.InitVars();
				return tVisitanteVisitaProgramadaLogDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow FindByidTabla(decimal idTabla)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idTabla };
				return (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TVisitanteVisitaProgramadaLogRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TVisitanteVisitaProgramadaLogDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidTabla = new DataColumn("idTabla", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidTabla);
				this.columnidVisitante = new DataColumn("idVisitante", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitante);
				this.columnidVisitaProgramada = new DataColumn("idVisitaProgramada", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitaProgramada);
				this.columnidEmpleadoAutorizaEntrada = new DataColumn("idEmpleadoAutorizaEntrada", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleadoAutorizaEntrada);
				this.columnfechaRegistro = new DataColumn("fechaRegistro", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaRegistro);
				this.columnfechaLlegada = new DataColumn("fechaLlegada", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaLlegada);
				this.columnfechaSalida = new DataColumn("fechaSalida", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaSalida);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnvisitacumplida = new DataColumn("visitacumplida", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnvisitacumplida);
				this.columntarjeta = new DataColumn("tarjeta", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntarjeta);
				this.columnidTarjeta = new DataColumn("idTarjeta", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTarjeta);
				this.columnObservacionesVisita = new DataColumn("ObservacionesVisita", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesVisita);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidTabla };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidTabla.AutoIncrement = true;
				this.columnidTabla.AutoIncrementSeed = (long)-1;
				this.columnidTabla.AutoIncrementStep = (long)-1;
				this.columnidTabla.AllowDBNull = false;
				this.columnidTabla.ReadOnly = true;
				this.columnidTabla.Unique = true;
				this.columnidVisitante.AllowDBNull = false;
				this.columnidVisitaProgramada.AllowDBNull = false;
				this.columntarjeta.MaxLength = 50;
				this.columnObservacionesVisita.MaxLength = 2147483647;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidTabla = base.Columns["idTabla"];
				this.columnidVisitante = base.Columns["idVisitante"];
				this.columnidVisitaProgramada = base.Columns["idVisitaProgramada"];
				this.columnidEmpleadoAutorizaEntrada = base.Columns["idEmpleadoAutorizaEntrada"];
				this.columnfechaRegistro = base.Columns["fechaRegistro"];
				this.columnfechaLlegada = base.Columns["fechaLlegada"];
				this.columnfechaSalida = base.Columns["fechaSalida"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnvisitacumplida = base.Columns["visitacumplida"];
				this.columntarjeta = base.Columns["tarjeta"];
				this.columnidTarjeta = base.Columns["idTarjeta"];
				this.columnObservacionesVisita = base.Columns["ObservacionesVisita"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TVisitanteVisitaProgramadaLogRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow NewTVisitanteVisitaProgramadaLogRow()
			{
				return (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TVisitanteVisitaProgramadaLogRowChanged != null)
				{
					this.TVisitanteVisitaProgramadaLogRowChanged(this, new masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TVisitanteVisitaProgramadaLogRowChanging != null)
				{
					this.TVisitanteVisitaProgramadaLogRowChanging(this, new masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TVisitanteVisitaProgramadaLogRowDeleted != null)
				{
					this.TVisitanteVisitaProgramadaLogRowDeleted(this, new masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TVisitanteVisitaProgramadaLogRowDeleting != null)
				{
					this.TVisitanteVisitaProgramadaLogRowDeleting(this, new masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEvent((masterDBACDataSet.TVisitanteVisitaProgramadaLogRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTVisitanteVisitaProgramadaLogRow(masterDBACDataSet.TVisitanteVisitaProgramadaLogRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEventHandler TVisitanteVisitaProgramadaLogRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEventHandler TVisitanteVisitaProgramadaLogRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEventHandler TVisitanteVisitaProgramadaLogRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEventHandler TVisitanteVisitaProgramadaLogRowDeleting;
		}

		public class TVisitanteVisitaProgramadaLogRow : DataRow
		{
			private masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable tableTVisitanteVisitaProgramadaLog;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaLlegada
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramadaLog.fechaLlegadaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaLlegada' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.fechaLlegadaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaRegistro
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramadaLog.fechaRegistroColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaRegistro' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.fechaRegistroColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaSalida
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramadaLog.fechaSalidaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaSalida' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.fechaSalidaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramadaLog.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleadoAutorizaEntrada
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitanteVisitaProgramadaLog.idEmpleadoAutorizaEntradaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpleadoAutorizaEntrada' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.idEmpleadoAutorizaEntradaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idTabla
			{
				get
				{
					return (decimal)base[this.tableTVisitanteVisitaProgramadaLog.idTablaColumn];
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.idTablaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTarjeta
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitanteVisitaProgramadaLog.idTarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTarjeta' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.idTarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitante
			{
				get
				{
					return (decimal)base[this.tableTVisitanteVisitaProgramadaLog.idVisitanteColumn];
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.idVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitaProgramada
			{
				get
				{
					return (decimal)base[this.tableTVisitanteVisitaProgramadaLog.idVisitaProgramadaColumn];
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.idVisitaProgramadaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesVisita
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitanteVisitaProgramadaLog.ObservacionesVisitaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesVisita' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.ObservacionesVisitaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string tarjeta
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitanteVisitaProgramadaLog.tarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'tarjeta' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.tarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow TEmpleadoRow
			{
				get
				{
					masterDBACDataSet.TEmpleadoRow parentRow = (masterDBACDataSet.TEmpleadoRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitanteVisitaProgramadaLog_TEmpleado"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitanteVisitaProgramadaLog_TEmpleado"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow TVisitanteRow
			{
				get
				{
					masterDBACDataSet.TVisitanteRow parentRow = (masterDBACDataSet.TVisitanteRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitanteVisitaProgramadaLog_TVisitante"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitanteVisitaProgramadaLog_TVisitante"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow TVisitaProgramadaRow
			{
				get
				{
					masterDBACDataSet.TVisitaProgramadaRow parentRow = (masterDBACDataSet.TVisitaProgramadaRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitanteVisitaProgramadaLog.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool visitacumplida
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTVisitanteVisitaProgramadaLog.visitacumplidaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'visitacumplida' in table 'TVisitanteVisitaProgramadaLog' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramadaLog.visitacumplidaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitanteVisitaProgramadaLogRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTVisitanteVisitaProgramadaLog = (masterDBACDataSet.TVisitanteVisitaProgramadaLogDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaLlegadaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.fechaLlegadaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaRegistroNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.fechaRegistroColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaSalidaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.fechaSalidaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpleadoAutorizaEntradaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.idEmpleadoAutorizaEntradaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTarjetaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.idTarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesVisitaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.ObservacionesVisitaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstarjetaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.tarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsvisitacumplidaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramadaLog.visitacumplidaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaLlegadaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.fechaLlegadaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaRegistroNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.fechaRegistroColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaSalidaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.fechaSalidaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpleadoAutorizaEntradaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.idEmpleadoAutorizaEntradaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTarjetaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.idTarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesVisitaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.ObservacionesVisitaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettarjetaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.tarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.usuarioUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetvisitacumplidaNull()
			{
				base[this.tableTVisitanteVisitaProgramadaLog.visitacumplidaColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TVisitanteVisitaProgramadaLogRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TVisitanteVisitaProgramadaLogRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitanteVisitaProgramadaLogRowChangeEvent(masterDBACDataSet.TVisitanteVisitaProgramadaLogRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TVisitanteVisitaProgramadaLogRowChangeEventHandler(object sender, masterDBACDataSet.TVisitanteVisitaProgramadaLogRowChangeEvent e);

		public class TVisitanteVisitaProgramadaRow : DataRow
		{
			private masterDBACDataSet.TVisitanteVisitaProgramadaDataTable tableTVisitanteVisitaProgramada;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaLlegada
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramada.fechaLlegadaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaLlegada' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.fechaLlegadaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaSalida
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramada.fechaSalidaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaSalida' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.fechaSalidaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitanteVisitaProgramada.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleadoAutorizaEntrada
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitanteVisitaProgramada.idEmpleadoAutorizaEntradaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpleadoAutorizaEntrada' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.idEmpleadoAutorizaEntradaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idTabla
			{
				get
				{
					return (decimal)base[this.tableTVisitanteVisitaProgramada.idTablaColumn];
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.idTablaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTarjeta
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitanteVisitaProgramada.idTarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idTarjeta' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.idTarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitante
			{
				get
				{
					return (decimal)base[this.tableTVisitanteVisitaProgramada.idVisitanteColumn];
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.idVisitanteColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitaProgramada
			{
				get
				{
					return (decimal)base[this.tableTVisitanteVisitaProgramada.idVisitaProgramadaColumn];
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.idVisitaProgramadaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesVisita
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitanteVisitaProgramada.ObservacionesVisitaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesVisita' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.ObservacionesVisitaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string tarjeta
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitanteVisitaProgramada.tarjetaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'tarjeta' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.tarjetaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TEmpleadoRow TEmpleadoRow
			{
				get
				{
					masterDBACDataSet.TEmpleadoRow parentRow = (masterDBACDataSet.TEmpleadoRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitanteVisitaProgramada_TEmpleado"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitanteVisitaProgramada_TEmpleado"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteRow TVisitanteRow
			{
				get
				{
					masterDBACDataSet.TVisitanteRow parentRow = (masterDBACDataSet.TVisitanteRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitanteVisitaProgramada_TVisitante"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitanteVisitaProgramada_TVisitante"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow TVisitaProgramadaRow
			{
				get
				{
					masterDBACDataSet.TVisitaProgramadaRow parentRow = (masterDBACDataSet.TVisitaProgramadaRow)base.GetParentRow(base.Table.ParentRelations["FK_TVisitanteVisitaProgramada_TVisitaProgramada"]);
					return parentRow;
				}
				set
				{
					base.SetParentRow(value, base.Table.ParentRelations["FK_TVisitanteVisitaProgramada_TVisitaProgramada"]);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitanteVisitaProgramada.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool visitacumplida
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableTVisitanteVisitaProgramada.visitacumplidaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'visitacumplida' in table 'TVisitanteVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitanteVisitaProgramada.visitacumplidaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitanteVisitaProgramadaRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTVisitanteVisitaProgramada = (masterDBACDataSet.TVisitanteVisitaProgramadaDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaLlegadaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.fechaLlegadaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaSalidaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.fechaSalidaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpleadoAutorizaEntradaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.idEmpleadoAutorizaEntradaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidTarjetaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.idTarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesVisitaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.ObservacionesVisitaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstarjetaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.tarjetaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsvisitacumplidaNull()
			{
				return base.IsNull(this.tableTVisitanteVisitaProgramada.visitacumplidaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaLlegadaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.fechaLlegadaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaSalidaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.fechaSalidaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTVisitanteVisitaProgramada.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpleadoAutorizaEntradaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.idEmpleadoAutorizaEntradaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTarjetaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.idTarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesVisitaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.ObservacionesVisitaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettarjetaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.tarjetaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTVisitanteVisitaProgramada.usuarioUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetvisitacumplidaNull()
			{
				base[this.tableTVisitanteVisitaProgramada.visitacumplidaColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TVisitanteVisitaProgramadaRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TVisitanteVisitaProgramadaRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitanteVisitaProgramadaRowChangeEvent(masterDBACDataSet.TVisitanteVisitaProgramadaRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TVisitanteVisitaProgramadaRowChangeEventHandler(object sender, masterDBACDataSet.TVisitanteVisitaProgramadaRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class TVisitaProgramadaDataTable : TypedTableBase<masterDBACDataSet.TVisitaProgramadaRow>
		{
			private DataColumn columnidVisitaProgramada;

			private DataColumn columnDescripcionVisita;

			private DataColumn columnfechaInicio;

			private DataColumn columnfechafin;

			private DataColumn columnidEmpresa;

			private DataColumn columnidEmpleado;

			private DataColumn columnObservacionesVisita;

			private DataColumn columnidEstadoVisita;

			private DataColumn columnfechadeIngreso;

			private DataColumn columnfechaUltimaGestion;

			private DataColumn columnusuarioUltimaGestion;

			private DataColumn columnIdDivisionEmpresa;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DescripcionVisitaColumn
			{
				get
				{
					return this.columnDescripcionVisita;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechadeIngresoColumn
			{
				get
				{
					return this.columnfechadeIngreso;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechafinColumn
			{
				get
				{
					return this.columnfechafin;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaInicioColumn
			{
				get
				{
					return this.columnfechaInicio;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fechaUltimaGestionColumn
			{
				get
				{
					return this.columnfechaUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdDivisionEmpresaColumn
			{
				get
				{
					return this.columnIdDivisionEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoColumn
			{
				get
				{
					return this.columnidEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpresaColumn
			{
				get
				{
					return this.columnidEmpresa;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEstadoVisitaColumn
			{
				get
				{
					return this.columnidEstadoVisita;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVisitaProgramadaColumn
			{
				get
				{
					return this.columnidVisitaProgramada;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.TVisitaProgramadaRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObservacionesVisitaColumn
			{
				get
				{
					return this.columnObservacionesVisita;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usuarioUltimaGestionColumn
			{
				get
				{
					return this.columnusuarioUltimaGestion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitaProgramadaDataTable()
			{
				base.TableName = "TVisitaProgramada";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitaProgramadaDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected TVisitaProgramadaDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddTVisitaProgramadaRow(masterDBACDataSet.TVisitaProgramadaRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow AddTVisitaProgramadaRow(string DescripcionVisita, DateTime fechaInicio, DateTime fechafin, int idEmpresa, int idEmpleado, string ObservacionesVisita, int idEstadoVisita, DateTime fechadeIngreso, DateTime fechaUltimaGestion, int usuarioUltimaGestion, int IdDivisionEmpresa)
			{
				masterDBACDataSet.TVisitaProgramadaRow tVisitaProgramadaRow = (masterDBACDataSet.TVisitaProgramadaRow)base.NewRow();
				object[] descripcionVisita = new object[] { null, DescripcionVisita, fechaInicio, fechafin, idEmpresa, idEmpleado, ObservacionesVisita, idEstadoVisita, fechadeIngreso, fechaUltimaGestion, usuarioUltimaGestion, IdDivisionEmpresa };
				tVisitaProgramadaRow.ItemArray = descripcionVisita;
				base.Rows.Add(tVisitaProgramadaRow);
				return tVisitaProgramadaRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.TVisitaProgramadaDataTable tVisitaProgramadaDataTable = (masterDBACDataSet.TVisitaProgramadaDataTable)base.Clone();
				tVisitaProgramadaDataTable.InitVars();
				return tVisitaProgramadaDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.TVisitaProgramadaDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow FindByidVisitaProgramada(decimal idVisitaProgramada)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idVisitaProgramada };
				return (masterDBACDataSet.TVisitaProgramadaRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.TVisitaProgramadaRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "TVisitaProgramadaDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidVisitaProgramada = new DataColumn("idVisitaProgramada", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnidVisitaProgramada);
				this.columnDescripcionVisita = new DataColumn("DescripcionVisita", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDescripcionVisita);
				this.columnfechaInicio = new DataColumn("fechaInicio", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaInicio);
				this.columnfechafin = new DataColumn("fechafin", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechafin);
				this.columnidEmpresa = new DataColumn("idEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpresa);
				this.columnidEmpleado = new DataColumn("idEmpleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleado);
				this.columnObservacionesVisita = new DataColumn("ObservacionesVisita", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObservacionesVisita);
				this.columnidEstadoVisita = new DataColumn("idEstadoVisita", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEstadoVisita);
				this.columnfechadeIngreso = new DataColumn("fechadeIngreso", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechadeIngreso);
				this.columnfechaUltimaGestion = new DataColumn("fechaUltimaGestion", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnfechaUltimaGestion);
				this.columnusuarioUltimaGestion = new DataColumn("usuarioUltimaGestion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnusuarioUltimaGestion);
				this.columnIdDivisionEmpresa = new DataColumn("IdDivisionEmpresa", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdDivisionEmpresa);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidVisitaProgramada };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidVisitaProgramada.AutoIncrement = true;
				this.columnidVisitaProgramada.AutoIncrementSeed = (long)-1;
				this.columnidVisitaProgramada.AutoIncrementStep = (long)-1;
				this.columnidVisitaProgramada.AllowDBNull = false;
				this.columnidVisitaProgramada.ReadOnly = true;
				this.columnidVisitaProgramada.Unique = true;
				this.columnDescripcionVisita.MaxLength = 2147483647;
				this.columnObservacionesVisita.MaxLength = 2147483647;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidVisitaProgramada = base.Columns["idVisitaProgramada"];
				this.columnDescripcionVisita = base.Columns["DescripcionVisita"];
				this.columnfechaInicio = base.Columns["fechaInicio"];
				this.columnfechafin = base.Columns["fechafin"];
				this.columnidEmpresa = base.Columns["idEmpresa"];
				this.columnidEmpleado = base.Columns["idEmpleado"];
				this.columnObservacionesVisita = base.Columns["ObservacionesVisita"];
				this.columnidEstadoVisita = base.Columns["idEstadoVisita"];
				this.columnfechadeIngreso = base.Columns["fechadeIngreso"];
				this.columnfechaUltimaGestion = base.Columns["fechaUltimaGestion"];
				this.columnusuarioUltimaGestion = base.Columns["usuarioUltimaGestion"];
				this.columnIdDivisionEmpresa = base.Columns["IdDivisionEmpresa"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.TVisitaProgramadaRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow NewTVisitaProgramadaRow()
			{
				return (masterDBACDataSet.TVisitaProgramadaRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.TVisitaProgramadaRowChanged != null)
				{
					this.TVisitaProgramadaRowChanged(this, new masterDBACDataSet.TVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.TVisitaProgramadaRowChanging != null)
				{
					this.TVisitaProgramadaRowChanging(this, new masterDBACDataSet.TVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.TVisitaProgramadaRowDeleted != null)
				{
					this.TVisitaProgramadaRowDeleted(this, new masterDBACDataSet.TVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.TVisitaProgramadaRowDeleting != null)
				{
					this.TVisitaProgramadaRowDeleting(this, new masterDBACDataSet.TVisitaProgramadaRowChangeEvent((masterDBACDataSet.TVisitaProgramadaRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveTVisitaProgramadaRow(masterDBACDataSet.TVisitaProgramadaRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitaProgramadaRowChangeEventHandler TVisitaProgramadaRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitaProgramadaRowChangeEventHandler TVisitaProgramadaRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitaProgramadaRowChangeEventHandler TVisitaProgramadaRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.TVisitaProgramadaRowChangeEventHandler TVisitaProgramadaRowDeleting;
		}

		public class TVisitaProgramadaRow : DataRow
		{
			private masterDBACDataSet.TVisitaProgramadaDataTable tableTVisitaProgramada;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string DescripcionVisita
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitaProgramada.DescripcionVisitaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'DescripcionVisita' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.DescripcionVisitaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechadeIngreso
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitaProgramada.fechadeIngresoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechadeIngreso' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.fechadeIngresoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechafin
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitaProgramada.fechafinColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechafin' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.fechafinColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaInicio
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitaProgramada.fechaInicioColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaInicio' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.fechaInicioColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime fechaUltimaGestion
			{
				get
				{
					DateTime item;
					try
					{
						item = (DateTime)base[this.tableTVisitaProgramada.fechaUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'fechaUltimaGestion' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.fechaUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int IdDivisionEmpresa
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitaProgramada.IdDivisionEmpresaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'IdDivisionEmpresa' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.IdDivisionEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleado
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitaProgramada.idEmpleadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpleado' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.idEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpresa
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitaProgramada.idEmpresaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEmpresa' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.idEmpresaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEstadoVisita
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitaProgramada.idEstadoVisitaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'idEstadoVisita' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.idEstadoVisitaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal idVisitaProgramada
			{
				get
				{
					return (decimal)base[this.tableTVisitaProgramada.idVisitaProgramadaColumn];
				}
				set
				{
					base[this.tableTVisitaProgramada.idVisitaProgramadaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObservacionesVisita
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableTVisitaProgramada.ObservacionesVisitaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'ObservacionesVisita' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.ObservacionesVisitaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int usuarioUltimaGestion
			{
				get
				{
					int item;
					try
					{
						item = (int)base[this.tableTVisitaProgramada.usuarioUltimaGestionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'usuarioUltimaGestion' in table 'TVisitaProgramada' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableTVisitaProgramada.usuarioUltimaGestionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal TVisitaProgramadaRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTVisitaProgramada = (masterDBACDataSet.TVisitaProgramadaDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[] GetTVisitanteVisitaProgramadaLogRows()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[] tVisitanteVisitaProgramadaLogRowArray;
				tVisitanteVisitaProgramadaLogRowArray = (base.Table.ChildRelations["FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada"] != null ? (masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitanteVisitaProgramadaLog_TVisitaProgramada"]) : new masterDBACDataSet.TVisitanteVisitaProgramadaLogRow[0]);
				return tVisitanteVisitaProgramadaLogRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitanteVisitaProgramadaRow[] GetTVisitanteVisitaProgramadaRows()
			{
				masterDBACDataSet.TVisitanteVisitaProgramadaRow[] tVisitanteVisitaProgramadaRowArray;
				tVisitanteVisitaProgramadaRowArray = (base.Table.ChildRelations["FK_TVisitanteVisitaProgramada_TVisitaProgramada"] != null ? (masterDBACDataSet.TVisitanteVisitaProgramadaRow[])base.GetChildRows(base.Table.ChildRelations["FK_TVisitanteVisitaProgramada_TVisitaProgramada"]) : new masterDBACDataSet.TVisitanteVisitaProgramadaRow[0]);
				return tVisitanteVisitaProgramadaRowArray;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDescripcionVisitaNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.DescripcionVisitaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechadeIngresoNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.fechadeIngresoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechafinNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.fechafinColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaInicioNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.fechaInicioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfechaUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.fechaUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIdDivisionEmpresaNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.IdDivisionEmpresaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpleadoNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.idEmpleadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEmpresaNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.idEmpresaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEstadoVisitaNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.idEstadoVisitaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObservacionesVisitaNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.ObservacionesVisitaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsusuarioUltimaGestionNull()
			{
				return base.IsNull(this.tableTVisitaProgramada.usuarioUltimaGestionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDescripcionVisitaNull()
			{
				base[this.tableTVisitaProgramada.DescripcionVisitaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechadeIngresoNull()
			{
				base[this.tableTVisitaProgramada.fechadeIngresoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechafinNull()
			{
				base[this.tableTVisitaProgramada.fechafinColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaInicioNull()
			{
				base[this.tableTVisitaProgramada.fechaInicioColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfechaUltimaGestionNull()
			{
				base[this.tableTVisitaProgramada.fechaUltimaGestionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdDivisionEmpresaNull()
			{
				base[this.tableTVisitaProgramada.IdDivisionEmpresaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpleadoNull()
			{
				base[this.tableTVisitaProgramada.idEmpleadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEmpresaNull()
			{
				base[this.tableTVisitaProgramada.idEmpresaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEstadoVisitaNull()
			{
				base[this.tableTVisitaProgramada.idEstadoVisitaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObservacionesVisitaNull()
			{
				base[this.tableTVisitaProgramada.ObservacionesVisitaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetusuarioUltimaGestionNull()
			{
				base[this.tableTVisitaProgramada.usuarioUltimaGestionColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class TVisitaProgramadaRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.TVisitaProgramadaRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.TVisitaProgramadaRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public TVisitaProgramadaRowChangeEvent(masterDBACDataSet.TVisitaProgramadaRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void TVisitaProgramadaRowChangeEventHandler(object sender, masterDBACDataSet.TVisitaProgramadaRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class viEmpleadoDataTable : TypedTableBase<masterDBACDataSet.viEmpleadoRow>
		{
			private DataColumn columnidEmpleado;

			private DataColumn columnnombre;

			private DataColumn columndescripcionIdentificacion;

			private DataColumn columnidentificacion;

			private DataColumn columnfoto;

			private DataColumn columnRazonSocial;

			private DataColumn columnNombreDivision;

			private DataColumn columnNombreCargo;

			private DataColumn columnNombreEstado;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn descripcionIdentificacionColumn
			{
				get
				{
					return this.columndescripcionIdentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn fotoColumn
			{
				get
				{
					return this.columnfoto;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEmpleadoColumn
			{
				get
				{
					return this.columnidEmpleado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn identificacionColumn
			{
				get
				{
					return this.columnidentificacion;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viEmpleadoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.viEmpleadoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreCargoColumn
			{
				get
				{
					return this.columnNombreCargo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nombreColumn
			{
				get
				{
					return this.columnnombre;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreDivisionColumn
			{
				get
				{
					return this.columnNombreDivision;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreEstadoColumn
			{
				get
				{
					return this.columnNombreEstado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RazonSocialColumn
			{
				get
				{
					return this.columnRazonSocial;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public viEmpleadoDataTable()
			{
				base.TableName = "viEmpleado";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal viEmpleadoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected viEmpleadoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddviEmpleadoRow(masterDBACDataSet.viEmpleadoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viEmpleadoRow AddviEmpleadoRow(int idEmpleado, string nombre, string descripcionIdentificacion, string identificacion, byte[] foto, string RazonSocial, string NombreDivision, string NombreCargo, string NombreEstado)
			{
				masterDBACDataSet.viEmpleadoRow _viEmpleadoRow = (masterDBACDataSet.viEmpleadoRow)base.NewRow();
				object[] objArray = new object[] { idEmpleado, nombre, descripcionIdentificacion, identificacion, foto, RazonSocial, NombreDivision, NombreCargo, NombreEstado };
				_viEmpleadoRow.ItemArray = objArray;
				base.Rows.Add(_viEmpleadoRow);
				return _viEmpleadoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.viEmpleadoDataTable _viEmpleadoDataTable = (masterDBACDataSet.viEmpleadoDataTable)base.Clone();
				_viEmpleadoDataTable.InitVars();
				return _viEmpleadoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.viEmpleadoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viEmpleadoRow FindByidEmpleado(int idEmpleado)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idEmpleado };
				return (masterDBACDataSet.viEmpleadoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.viEmpleadoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "viEmpleadoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidEmpleado = new DataColumn("idEmpleado", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEmpleado);
				this.columnnombre = new DataColumn("nombre", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnombre);
				this.columndescripcionIdentificacion = new DataColumn("descripcionIdentificacion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columndescripcionIdentificacion);
				this.columnidentificacion = new DataColumn("identificacion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnidentificacion);
				this.columnfoto = new DataColumn("foto", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnfoto);
				this.columnRazonSocial = new DataColumn("RazonSocial", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRazonSocial);
				this.columnNombreDivision = new DataColumn("NombreDivision", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreDivision);
				this.columnNombreCargo = new DataColumn("NombreCargo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreCargo);
				this.columnNombreEstado = new DataColumn("NombreEstado", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreEstado);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidEmpleado };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidEmpleado.AllowDBNull = false;
				this.columnidEmpleado.Unique = true;
				this.columnnombre.AllowDBNull = false;
				this.columnnombre.MaxLength = 70;
				this.columndescripcionIdentificacion.MaxLength = 50;
				this.columnidentificacion.MaxLength = 25;
				this.columnRazonSocial.MaxLength = 50;
				this.columnNombreDivision.MaxLength = 100;
				this.columnNombreCargo.MaxLength = 50;
				this.columnNombreEstado.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidEmpleado = base.Columns["idEmpleado"];
				this.columnnombre = base.Columns["nombre"];
				this.columndescripcionIdentificacion = base.Columns["descripcionIdentificacion"];
				this.columnidentificacion = base.Columns["identificacion"];
				this.columnfoto = base.Columns["foto"];
				this.columnRazonSocial = base.Columns["RazonSocial"];
				this.columnNombreDivision = base.Columns["NombreDivision"];
				this.columnNombreCargo = base.Columns["NombreCargo"];
				this.columnNombreEstado = base.Columns["NombreEstado"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.viEmpleadoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viEmpleadoRow NewviEmpleadoRow()
			{
				return (masterDBACDataSet.viEmpleadoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.viEmpleadoRowChanged != null)
				{
					this.viEmpleadoRowChanged(this, new masterDBACDataSet.viEmpleadoRowChangeEvent((masterDBACDataSet.viEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.viEmpleadoRowChanging != null)
				{
					this.viEmpleadoRowChanging(this, new masterDBACDataSet.viEmpleadoRowChangeEvent((masterDBACDataSet.viEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.viEmpleadoRowDeleted != null)
				{
					this.viEmpleadoRowDeleted(this, new masterDBACDataSet.viEmpleadoRowChangeEvent((masterDBACDataSet.viEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.viEmpleadoRowDeleting != null)
				{
					this.viEmpleadoRowDeleting(this, new masterDBACDataSet.viEmpleadoRowChangeEvent((masterDBACDataSet.viEmpleadoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveviEmpleadoRow(masterDBACDataSet.viEmpleadoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viEmpleadoRowChangeEventHandler viEmpleadoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viEmpleadoRowChangeEventHandler viEmpleadoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viEmpleadoRowChangeEventHandler viEmpleadoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viEmpleadoRowChangeEventHandler viEmpleadoRowDeleting;
		}

		public class viEmpleadoRow : DataRow
		{
			private masterDBACDataSet.viEmpleadoDataTable tableviEmpleado;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string descripcionIdentificacion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviEmpleado.descripcionIdentificacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'descripcionIdentificacion' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.descripcionIdentificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public byte[] foto
			{
				get
				{
					byte[] item;
					try
					{
						item = (byte[])base[this.tableviEmpleado.fotoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'foto' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.fotoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEmpleado
			{
				get
				{
					return (int)base[this.tableviEmpleado.idEmpleadoColumn];
				}
				set
				{
					base[this.tableviEmpleado.idEmpleadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string identificacion
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviEmpleado.identificacionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'identificacion' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.identificacionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nombre
			{
				get
				{
					return (string)base[this.tableviEmpleado.nombreColumn];
				}
				set
				{
					base[this.tableviEmpleado.nombreColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreCargo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviEmpleado.NombreCargoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreCargo' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.NombreCargoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreDivision
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviEmpleado.NombreDivisionColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreDivision' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.NombreDivisionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreEstado
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviEmpleado.NombreEstadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreEstado' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.NombreEstadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string RazonSocial
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviEmpleado.RazonSocialColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'RazonSocial' in table 'viEmpleado' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviEmpleado.RazonSocialColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal viEmpleadoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableviEmpleado = (masterDBACDataSet.viEmpleadoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdescripcionIdentificacionNull()
			{
				return base.IsNull(this.tableviEmpleado.descripcionIdentificacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsfotoNull()
			{
				return base.IsNull(this.tableviEmpleado.fotoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidentificacionNull()
			{
				return base.IsNull(this.tableviEmpleado.identificacionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreCargoNull()
			{
				return base.IsNull(this.tableviEmpleado.NombreCargoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreDivisionNull()
			{
				return base.IsNull(this.tableviEmpleado.NombreDivisionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreEstadoNull()
			{
				return base.IsNull(this.tableviEmpleado.NombreEstadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsRazonSocialNull()
			{
				return base.IsNull(this.tableviEmpleado.RazonSocialColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdescripcionIdentificacionNull()
			{
				base[this.tableviEmpleado.descripcionIdentificacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetfotoNull()
			{
				base[this.tableviEmpleado.fotoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidentificacionNull()
			{
				base[this.tableviEmpleado.identificacionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreCargoNull()
			{
				base[this.tableviEmpleado.NombreCargoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreDivisionNull()
			{
				base[this.tableviEmpleado.NombreDivisionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreEstadoNull()
			{
				base[this.tableviEmpleado.NombreEstadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRazonSocialNull()
			{
				base[this.tableviEmpleado.RazonSocialColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class viEmpleadoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.viEmpleadoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viEmpleadoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public viEmpleadoRowChangeEvent(masterDBACDataSet.viEmpleadoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void viEmpleadoRowChangeEventHandler(object sender, masterDBACDataSet.viEmpleadoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class viParqueoVehiculoDataTable : TypedTableBase<masterDBACDataSet.viParqueoVehiculoRow>
		{
			private DataColumn columnPlaca;

			private DataColumn columnModelo;

			private DataColumn columnParqueadero;

			private DataColumn columnLunes;

			private DataColumn columnMartes;

			private DataColumn columnMiercoles;

			private DataColumn columnJueves;

			private DataColumn columnViernes;

			private DataColumn columnSábado;

			private DataColumn columnDomingo;

			private DataColumn columnidVehiculo;

			private DataColumn columnidParqueadero;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DomingoColumn
			{
				get
				{
					return this.columnDomingo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idParqueaderoColumn
			{
				get
				{
					return this.columnidParqueadero;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVehiculoColumn
			{
				get
				{
					return this.columnidVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viParqueoVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.viParqueoVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn JuevesColumn
			{
				get
				{
					return this.columnJueves;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn LunesColumn
			{
				get
				{
					return this.columnLunes;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MartesColumn
			{
				get
				{
					return this.columnMartes;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MiercolesColumn
			{
				get
				{
					return this.columnMiercoles;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ModeloColumn
			{
				get
				{
					return this.columnModelo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParqueaderoColumn
			{
				get
				{
					return this.columnParqueadero;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PlacaColumn
			{
				get
				{
					return this.columnPlaca;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SábadoColumn
			{
				get
				{
					return this.columnSábado;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ViernesColumn
			{
				get
				{
					return this.columnViernes;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public viParqueoVehiculoDataTable()
			{
				base.TableName = "viParqueoVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal viParqueoVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected viParqueoVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddviParqueoVehiculoRow(masterDBACDataSet.viParqueoVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viParqueoVehiculoRow AddviParqueoVehiculoRow(string Placa, string Modelo, string Parqueadero, bool Lunes, bool Martes, bool Miercoles, bool Jueves, bool Viernes, bool Sábado, bool Domingo, int idVehiculo, int idParqueadero)
			{
				masterDBACDataSet.viParqueoVehiculoRow _viParqueoVehiculoRow = (masterDBACDataSet.viParqueoVehiculoRow)base.NewRow();
				object[] placa = new object[] { Placa, Modelo, Parqueadero, Lunes, Martes, Miercoles, Jueves, Viernes, Sábado, Domingo, idVehiculo, idParqueadero };
				_viParqueoVehiculoRow.ItemArray = placa;
				base.Rows.Add(_viParqueoVehiculoRow);
				return _viParqueoVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.viParqueoVehiculoDataTable _viParqueoVehiculoDataTable = (masterDBACDataSet.viParqueoVehiculoDataTable)base.Clone();
				_viParqueoVehiculoDataTable.InitVars();
				return _viParqueoVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.viParqueoVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.viParqueoVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "viParqueoVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnPlaca = new DataColumn("Placa", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPlaca);
				this.columnModelo = new DataColumn("Modelo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnModelo);
				this.columnParqueadero = new DataColumn("Parqueadero", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParqueadero);
				this.columnLunes = new DataColumn("Lunes", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnLunes);
				this.columnMartes = new DataColumn("Martes", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnMartes);
				this.columnMiercoles = new DataColumn("Miercoles", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnMiercoles);
				this.columnJueves = new DataColumn("Jueves", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnJueves);
				this.columnViernes = new DataColumn("Viernes", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnViernes);
				this.columnSábado = new DataColumn("Sábado", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnSábado);
				this.columnDomingo = new DataColumn("Domingo", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDomingo);
				this.columnidVehiculo = new DataColumn("idVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidVehiculo);
				this.columnidParqueadero = new DataColumn("idParqueadero", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParqueadero);
				this.columnPlaca.MaxLength = 8;
				this.columnModelo.MaxLength = 50;
				this.columnParqueadero.MaxLength = 30;
				this.columnidVehiculo.AllowDBNull = false;
				this.columnidParqueadero.AllowDBNull = false;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnPlaca = base.Columns["Placa"];
				this.columnModelo = base.Columns["Modelo"];
				this.columnParqueadero = base.Columns["Parqueadero"];
				this.columnLunes = base.Columns["Lunes"];
				this.columnMartes = base.Columns["Martes"];
				this.columnMiercoles = base.Columns["Miercoles"];
				this.columnJueves = base.Columns["Jueves"];
				this.columnViernes = base.Columns["Viernes"];
				this.columnSábado = base.Columns["Sábado"];
				this.columnDomingo = base.Columns["Domingo"];
				this.columnidVehiculo = base.Columns["idVehiculo"];
				this.columnidParqueadero = base.Columns["idParqueadero"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.viParqueoVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viParqueoVehiculoRow NewviParqueoVehiculoRow()
			{
				return (masterDBACDataSet.viParqueoVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.viParqueoVehiculoRowChanged != null)
				{
					this.viParqueoVehiculoRowChanged(this, new masterDBACDataSet.viParqueoVehiculoRowChangeEvent((masterDBACDataSet.viParqueoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.viParqueoVehiculoRowChanging != null)
				{
					this.viParqueoVehiculoRowChanging(this, new masterDBACDataSet.viParqueoVehiculoRowChangeEvent((masterDBACDataSet.viParqueoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.viParqueoVehiculoRowDeleted != null)
				{
					this.viParqueoVehiculoRowDeleted(this, new masterDBACDataSet.viParqueoVehiculoRowChangeEvent((masterDBACDataSet.viParqueoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.viParqueoVehiculoRowDeleting != null)
				{
					this.viParqueoVehiculoRowDeleting(this, new masterDBACDataSet.viParqueoVehiculoRowChangeEvent((masterDBACDataSet.viParqueoVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveviParqueoVehiculoRow(masterDBACDataSet.viParqueoVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viParqueoVehiculoRowChangeEventHandler viParqueoVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viParqueoVehiculoRowChangeEventHandler viParqueoVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viParqueoVehiculoRowChangeEventHandler viParqueoVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viParqueoVehiculoRowChangeEventHandler viParqueoVehiculoRowDeleting;
		}

		public class viParqueoVehiculoRow : DataRow
		{
			private masterDBACDataSet.viParqueoVehiculoDataTable tableviParqueoVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Domingo
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.DomingoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Domingo' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.DomingoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idParqueadero
			{
				get
				{
					return (int)base[this.tableviParqueoVehiculo.idParqueaderoColumn];
				}
				set
				{
					base[this.tableviParqueoVehiculo.idParqueaderoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idVehiculo
			{
				get
				{
					return (int)base[this.tableviParqueoVehiculo.idVehiculoColumn];
				}
				set
				{
					base[this.tableviParqueoVehiculo.idVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Jueves
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.JuevesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Jueves' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.JuevesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Lunes
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.LunesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Lunes' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.LunesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Martes
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.MartesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Martes' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.MartesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Miercoles
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.MiercolesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Miercoles' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.MiercolesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Modelo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviParqueoVehiculo.ModeloColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Modelo' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.ModeloColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Parqueadero
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviParqueoVehiculo.ParqueaderoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Parqueadero' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.ParqueaderoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Placa
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviParqueoVehiculo.PlacaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Placa' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.PlacaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Sábado
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.SábadoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Sábado' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.SábadoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Viernes
			{
				get
				{
					bool item;
					try
					{
						item = (bool)base[this.tableviParqueoVehiculo.ViernesColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Viernes' in table 'viParqueoVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviParqueoVehiculo.ViernesColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal viParqueoVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableviParqueoVehiculo = (masterDBACDataSet.viParqueoVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDomingoNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.DomingoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsJuevesNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.JuevesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsLunesNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.LunesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMartesNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.MartesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsMiercolesNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.MiercolesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsModeloNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.ModeloColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsParqueaderoNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.ParqueaderoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPlacaNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.PlacaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSábadoNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.SábadoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsViernesNull()
			{
				return base.IsNull(this.tableviParqueoVehiculo.ViernesColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDomingoNull()
			{
				base[this.tableviParqueoVehiculo.DomingoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetJuevesNull()
			{
				base[this.tableviParqueoVehiculo.JuevesColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetLunesNull()
			{
				base[this.tableviParqueoVehiculo.LunesColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMartesNull()
			{
				base[this.tableviParqueoVehiculo.MartesColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetMiercolesNull()
			{
				base[this.tableviParqueoVehiculo.MiercolesColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetModeloNull()
			{
				base[this.tableviParqueoVehiculo.ModeloColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetParqueaderoNull()
			{
				base[this.tableviParqueoVehiculo.ParqueaderoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPlacaNull()
			{
				base[this.tableviParqueoVehiculo.PlacaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSábadoNull()
			{
				base[this.tableviParqueoVehiculo.SábadoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetViernesNull()
			{
				base[this.tableviParqueoVehiculo.ViernesColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class viParqueoVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.viParqueoVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viParqueoVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public viParqueoVehiculoRowChangeEvent(masterDBACDataSet.viParqueoVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void viParqueoVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.viParqueoVehiculoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class viVehiculoDataTable : TypedTableBase<masterDBACDataSet.viVehiculoRow>
		{
			private DataColumn columnidVehiculo;

			private DataColumn columnPlaca;

			private DataColumn columnCodigodeBarras;

			private DataColumn columnNombreModelo;

			private DataColumn columnNombreMarcaVehiculo;

			private DataColumn columncolor;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CodigodeBarrasColumn
			{
				get
				{
					return this.columnCodigodeBarras;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn colorColumn
			{
				get
				{
					return this.columncolor;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idVehiculoColumn
			{
				get
				{
					return this.columnidVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viVehiculoRow this[int index]
			{
				get
				{
					return (masterDBACDataSet.viVehiculoRow)base.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreMarcaVehiculoColumn
			{
				get
				{
					return this.columnNombreMarcaVehiculo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NombreModeloColumn
			{
				get
				{
					return this.columnNombreModelo;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PlacaColumn
			{
				get
				{
					return this.columnPlaca;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public viVehiculoDataTable()
			{
				base.TableName = "viVehiculo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal viVehiculoDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected viVehiculoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddviVehiculoRow(masterDBACDataSet.viVehiculoRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viVehiculoRow AddviVehiculoRow(int idVehiculo, string Placa, string CodigodeBarras, string NombreModelo, string NombreMarcaVehiculo, string color)
			{
				masterDBACDataSet.viVehiculoRow _viVehiculoRow = (masterDBACDataSet.viVehiculoRow)base.NewRow();
				object[] objArray = new object[] { idVehiculo, Placa, CodigodeBarras, NombreModelo, NombreMarcaVehiculo, color };
				_viVehiculoRow.ItemArray = objArray;
				base.Rows.Add(_viVehiculoRow);
				return _viVehiculoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				masterDBACDataSet.viVehiculoDataTable _viVehiculoDataTable = (masterDBACDataSet.viVehiculoDataTable)base.Clone();
				_viVehiculoDataTable.InitVars();
				return _viVehiculoDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new masterDBACDataSet.viVehiculoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viVehiculoRow FindByidVehiculo(int idVehiculo)
			{
				DataRowCollection rows = base.Rows;
				object[] objArray = new object[] { idVehiculo };
				return (masterDBACDataSet.viVehiculoRow)rows.Find(objArray);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(masterDBACDataSet.viVehiculoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType;
				XmlSchemaComplexType xmlSchemaComplexType1 = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				masterDBACDataSet _masterDBACDataSet = new masterDBACDataSet();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema",
					MinOccurs = new decimal(0),
					MaxOccurs = new decimal(-1, -1, -1, false, 0),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
					MinOccurs = new decimal(1),
					ProcessContents = XmlSchemaContentProcessing.Lax
				};
				xmlSchemaSequence.Items.Add(xmlSchemaAny1);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = _masterDBACDataSet.Namespace
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "viVehiculoDataTable"
				};
				xmlSchemaComplexType1.Attributes.Add(xmlSchemaAttribute1);
				xmlSchemaComplexType1.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = _masterDBACDataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream1 = new MemoryStream();
					try
					{
						XmlSchema current = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							current = (XmlSchema)enumerator.Current;
							memoryStream1.SetLength((long)0);
							current.Write(memoryStream1);
							if (memoryStream.Length == memoryStream1.Length)
							{
								memoryStream.Position = (long)0;
								memoryStream1.Position = (long)0;
								while (true)
								{
									if ((memoryStream.Position == memoryStream.Length ? true : memoryStream.ReadByte() != memoryStream1.ReadByte()))
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									xmlSchemaComplexType = xmlSchemaComplexType1;
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream1 != null)
						{
							memoryStream1.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				xmlSchemaComplexType = xmlSchemaComplexType1;
				return xmlSchemaComplexType;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnidVehiculo = new DataColumn("idVehiculo", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidVehiculo);
				this.columnPlaca = new DataColumn("Placa", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPlaca);
				this.columnCodigodeBarras = new DataColumn("CodigodeBarras", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCodigodeBarras);
				this.columnNombreModelo = new DataColumn("NombreModelo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreModelo);
				this.columnNombreMarcaVehiculo = new DataColumn("NombreMarcaVehiculo", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNombreMarcaVehiculo);
				this.columncolor = new DataColumn("color", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncolor);
				ConstraintCollection constraints = base.Constraints;
				DataColumn[] dataColumnArray = new DataColumn[] { this.columnidVehiculo };
				constraints.Add(new UniqueConstraint("Constraint1", dataColumnArray, true));
				this.columnidVehiculo.AllowDBNull = false;
				this.columnidVehiculo.Unique = true;
				this.columnPlaca.MaxLength = 8;
				this.columnCodigodeBarras.MaxLength = 50;
				this.columnNombreModelo.MaxLength = 50;
				this.columnNombreMarcaVehiculo.MaxLength = 50;
				this.columncolor.MaxLength = 30;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnidVehiculo = base.Columns["idVehiculo"];
				this.columnPlaca = base.Columns["Placa"];
				this.columnCodigodeBarras = base.Columns["CodigodeBarras"];
				this.columnNombreModelo = base.Columns["NombreModelo"];
				this.columnNombreMarcaVehiculo = base.Columns["NombreMarcaVehiculo"];
				this.columncolor = base.Columns["color"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new masterDBACDataSet.viVehiculoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viVehiculoRow NewviVehiculoRow()
			{
				return (masterDBACDataSet.viVehiculoRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.viVehiculoRowChanged != null)
				{
					this.viVehiculoRowChanged(this, new masterDBACDataSet.viVehiculoRowChangeEvent((masterDBACDataSet.viVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.viVehiculoRowChanging != null)
				{
					this.viVehiculoRowChanging(this, new masterDBACDataSet.viVehiculoRowChangeEvent((masterDBACDataSet.viVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.viVehiculoRowDeleted != null)
				{
					this.viVehiculoRowDeleted(this, new masterDBACDataSet.viVehiculoRowChangeEvent((masterDBACDataSet.viVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.viVehiculoRowDeleting != null)
				{
					this.viVehiculoRowDeleting(this, new masterDBACDataSet.viVehiculoRowChangeEvent((masterDBACDataSet.viVehiculoRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveviVehiculoRow(masterDBACDataSet.viVehiculoRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viVehiculoRowChangeEventHandler viVehiculoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viVehiculoRowChangeEventHandler viVehiculoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viVehiculoRowChangeEventHandler viVehiculoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event masterDBACDataSet.viVehiculoRowChangeEventHandler viVehiculoRowDeleting;
		}

		public class viVehiculoRow : DataRow
		{
			private masterDBACDataSet.viVehiculoDataTable tableviVehiculo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CodigodeBarras
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviVehiculo.CodigodeBarrasColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'CodigodeBarras' in table 'viVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviVehiculo.CodigodeBarrasColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string color
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviVehiculo.colorColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'color' in table 'viVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviVehiculo.colorColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idVehiculo
			{
				get
				{
					return (int)base[this.tableviVehiculo.idVehiculoColumn];
				}
				set
				{
					base[this.tableviVehiculo.idVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreMarcaVehiculo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviVehiculo.NombreMarcaVehiculoColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreMarcaVehiculo' in table 'viVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviVehiculo.NombreMarcaVehiculoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string NombreModelo
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviVehiculo.NombreModeloColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'NombreModelo' in table 'viVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviVehiculo.NombreModeloColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Placa
			{
				get
				{
					string item;
					try
					{
						item = (string)base[this.tableviVehiculo.PlacaColumn];
					}
					catch (InvalidCastException invalidCastException)
					{
						throw new StrongTypingException("The value for column 'Placa' in table 'viVehiculo' is DBNull.", invalidCastException);
					}
					return item;
				}
				set
				{
					base[this.tableviVehiculo.PlacaColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal viVehiculoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableviVehiculo = (masterDBACDataSet.viVehiculoDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCodigodeBarrasNull()
			{
				return base.IsNull(this.tableviVehiculo.CodigodeBarrasColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IscolorNull()
			{
				return base.IsNull(this.tableviVehiculo.colorColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreMarcaVehiculoNull()
			{
				return base.IsNull(this.tableviVehiculo.NombreMarcaVehiculoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNombreModeloNull()
			{
				return base.IsNull(this.tableviVehiculo.NombreModeloColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPlacaNull()
			{
				return base.IsNull(this.tableviVehiculo.PlacaColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCodigodeBarrasNull()
			{
				base[this.tableviVehiculo.CodigodeBarrasColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetcolorNull()
			{
				base[this.tableviVehiculo.colorColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreMarcaVehiculoNull()
			{
				base[this.tableviVehiculo.NombreMarcaVehiculoColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNombreModeloNull()
			{
				base[this.tableviVehiculo.NombreModeloColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPlacaNull()
			{
				base[this.tableviVehiculo.PlacaColumn] = Convert.DBNull;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class viVehiculoRowChangeEvent : EventArgs
		{
			private masterDBACDataSet.viVehiculoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public masterDBACDataSet.viVehiculoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public viVehiculoRowChangeEvent(masterDBACDataSet.viVehiculoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void viVehiculoRowChangeEventHandler(object sender, masterDBACDataSet.viVehiculoRowChangeEvent e);
	}
}