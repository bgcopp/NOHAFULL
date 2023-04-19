using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Reportes
	{
		public Reportes()
		{
		}

		public List<reporteEmpleadoDTO> consultarReporteEmpleados(DateTime fecha1, DateTime fecha2, int idEmpresa, int idempleado)
		{
			List<reporteEmpleadoDTO> list;
			List<reporteEmpleadoDTO> reporteEmpleadoDTOs;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				if (idEmpresa == -999)
				{
					if (idempleado != -999)
					{
						list = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
							join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idEmpleado == idempleado
							orderby a.fechaMarcacion
							select new reporteEmpleadoDTO()
							{
								Empresa = c.RazonSocial,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion,
								Identificacion = b.identificacion,
								Nombre = b.nombre
							}).ToList<reporteEmpleadoDTO>();
						reporteEmpleadoDTOs = list;
					}
					else
					{
						list = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
							join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2)
							orderby a.fechaMarcacion
							select new reporteEmpleadoDTO()
							{
								Empresa = c.RazonSocial,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion,
								Identificacion = b.identificacion,
								Nombre = b.nombre
							}).ToList<reporteEmpleadoDTO>();
						reporteEmpleadoDTOs = list;
					}
				}
				else if (idempleado != -999)
				{
					list = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
						join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idEmpleado == idempleado
						orderby a.fechaMarcacion
						select new reporteEmpleadoDTO()
						{
							Empresa = c.RazonSocial,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion,
							Identificacion = b.identificacion,
							Nombre = b.nombre
						}).ToList<reporteEmpleadoDTO>();
					reporteEmpleadoDTOs = list;
				}
				else
				{
					list = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TEmpleado on a.idEmpleado equals (int?)b.idEmpleado
						join c in masterDBACEntity.TEmpresa on b.idEmpresa equals c.idEmpresa
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && c.idEmpresa == idEmpresa
						orderby a.fechaMarcacion
						select new reporteEmpleadoDTO()
						{
							Empresa = c.RazonSocial,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion,
							Identificacion = b.identificacion,
							Nombre = b.nombre
						}).ToList<reporteEmpleadoDTO>();
					reporteEmpleadoDTOs = list;
				}
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return reporteEmpleadoDTOs;
		}

		public List<reporteVehiculosDTO> consultarReporteVehiculos(DateTime fecha1, DateTime fecha2, int idVehiculo)
		{
			List<reporteVehiculosDTO> list;
			List<reporteVehiculosDTO> reporteVehiculosDTOs;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				if (idVehiculo != -999)
				{
          //list = (
          //	from a in masterDBACEntity.TRegistroVehiculo
          //	join b in masterDBACEntity.TVehiculo on a.idVehiculo equals (int?)b.idVehiculo
          //	join c in masterDBACEntity.TEmpleado on a.idempleado equals (int?)c.idEmpleado
          //	where b.idVehiculo == idVehiculo && (a.fechadeRegistro >= (DateTime?)fecha1) && (a.fechadeRegistro <= (DateTime?)fecha2)
          //	orderby a.fechadeRegistro
          //	select new reporteVehiculosDTO()
          //	{
          //		Conductor = c.nombre,
          //		Evento = a.mregistro,
          //		Fecha_Marcacion = (DateTime)a.fechadeRegistro,
          //		Placa = b.Placa
          //	}).ToList<reporteVehiculosDTO>();

          var sqlcad = @"select top 1000 c.nombre Conductor, a.mregistro Evento, a.fechadeRegistro Fecha_Marcacion, b.Placa Placa from TRegistroVehiculo a
												join TVehiculo b on a.idVehiculo = b.idVehiculo
												join TEmpleado c on a.idempleado = c.idEmpleado
												where b.idVehiculo=" + idVehiculo + @" and 
												a.fechadeRegistro between '" + fecha1.ToString("yyyy-MM-dd HH:mm:ss") + @"' and '" + fecha2.ToString("yyyy-MM-dd HH:mm:ss") + @"'
												order by a.fechadeRegistro desc";
          list = SqlTools.ExecSqlGetList<reporteVehiculosDTO>(sqlcad).ToList();

          reporteVehiculosDTOs = list;
				}
				else
				{
					//list = (
					//	from a in masterDBACEntity.TRegistroVehiculo
					//	join b in masterDBACEntity.TVehiculo on a.idVehiculo equals (int?)b.idVehiculo
					//	join c in masterDBACEntity.TEmpleado on a.idempleado equals (int?)c.idEmpleado
					//	where (a.fechadeRegistro >= (DateTime?)fecha1) && (a.fechadeRegistro <= (DateTime?)fecha2)
					//	orderby a.fechadeRegistro
					//	select new reporteVehiculosDTO()
					//	{
					//		Conductor = c.nombre,
					//		Evento = a.mregistro,
					//		Fecha_Marcacion = (DateTime)a.fechadeRegistro,
					//		Placa = b.Placa
					//	}).ToList<reporteVehiculosDTO>();
					var sqlcad = @"select top 1000 c.nombre Conductor, a.mregistro Evento, a.fechadeRegistro Fecha_Marcacion, b.Placa Placa from TRegistroVehiculo a
												join TVehiculo b on a.idVehiculo = b.idVehiculo
												join TEmpleado c on a.idempleado = c.idEmpleado
												where 
												a.fechadeRegistro between '" + fecha1.ToString("yyyy-MM-dd HH:mm:ss") + @"' and '" + fecha2.ToString("yyyy-MM-dd HH:mm:ss") + @"'
												order by a.fechadeRegistro desc";
					list = SqlTools.ExecSqlGetList<reporteVehiculosDTO>(sqlcad).ToList();
					reporteVehiculosDTOs = list;
				}
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return reporteVehiculosDTOs;
		}

		public List<reporteVisitanteDTO> consultarReporteVisitantes(DateTime fecha1, DateTime fecha2, int idEmpresaDestino, int idVisitante)
		{
			List<reporteVisitanteDTO> list;
			List<reporteVisitanteDTO> reporteVisitanteDTOs;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				if (idEmpresaDestino == -999)
				{
					if (idVisitante != -999)
					{
						list = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
							join c in masterDBACEntity.TVisitanteVisitaProgramadaLog on a.idVisitanteVistaP equals (decimal?)c.idVisitaProgramada
							join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
							join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
							join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idVisitante == (decimal)idVisitante
							orderby a.fechaMarcacion
							select new reporteVisitanteDTO()
							{
								idvisitante = (decimal)a.idVisitante,
								Identificacion = b.identificacionVisitante,
								Nombre_Visitante = b.nombreVisitante,
								Empresa_Destino = e.RazonSocial,
								Empleado_Destino = f.nombre,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion
							}).ToList<reporteVisitanteDTO>();
						reporteVisitanteDTOs = list;
					}
					else
					{
						list = (
							from a in masterDBACEntity.TMarcacion
							join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
							join c in masterDBACEntity.TVisitanteVisitaProgramada on a.idVisitanteVistaP equals (decimal?)c.idTabla
							join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
							join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
							join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
							where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2)
							orderby a.fechaMarcacion descending
							select new reporteVisitanteDTO()
							{
								idvisitante = (decimal)a.idVisitante,
								Identificacion = b.identificacionVisitante,
								Nombre_Visitante = b.nombreVisitante,
								Empresa_Destino = e.RazonSocial,
								Empleado_Destino = f.nombre,
								Fecha_Marcacion = (DateTime)a.fechaMarcacion
							}).ToList<reporteVisitanteDTO>();
						reporteVisitanteDTOs = list;
					}
				}
				else if (idVisitante != -999)
				{
					list = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
						join c in masterDBACEntity.TVisitanteVisitaProgramadaLog on a.idVisitanteVistaP equals (decimal?)c.idVisitaProgramada
						join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
						join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
						join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && b.idVisitante == (decimal)idVisitante
						orderby a.fechaMarcacion
						select new reporteVisitanteDTO()
						{
							idvisitante = (decimal)a.idVisitante,
							Identificacion = b.identificacionVisitante,
							Nombre_Visitante = b.nombreVisitante,
							Empresa_Destino = e.RazonSocial,
							Empleado_Destino = f.nombre,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion
						}).ToList<reporteVisitanteDTO>();
					reporteVisitanteDTOs = list;
				}
				else
				{
					list = (
						from a in masterDBACEntity.TMarcacion
						join b in masterDBACEntity.TVisitante on a.idVisitante equals (decimal?)b.idVisitante
						join c in masterDBACEntity.TVisitanteVisitaProgramadaLog on a.idVisitanteVistaP equals (decimal?)c.idVisitaProgramada
						join d in masterDBACEntity.TVisitaProgramada on c.idVisitaProgramada equals d.idVisitaProgramada
						join e in masterDBACEntity.TEmpresa on d.idEmpresa equals (int?)e.idEmpresa
						join f in masterDBACEntity.TEmpleado on d.idEmpleado equals (int?)f.idEmpleado
						where (a.fechaMarcacion >= (DateTime?)fecha1) && (a.fechaMarcacion <= (DateTime?)fecha2) && e.idEmpresa == idEmpresaDestino
						orderby a.fechaMarcacion
						select new reporteVisitanteDTO()
						{
							idvisitante = (decimal)a.idVisitante,
							Identificacion = b.identificacionVisitante,
							Nombre_Visitante = b.nombreVisitante,
							Empresa_Destino = e.RazonSocial,
							Empleado_Destino = f.nombre,
							Fecha_Marcacion = (DateTime)a.fechaMarcacion
						}).ToList<reporteVisitanteDTO>();
					reporteVisitanteDTOs = list;
				}
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return reporteVisitanteDTOs;
		}
	}

  public class SqlTools
  {

    public static string SQLExecute(string sQuery)
    {
      var cadCnx = System.Configuration.ConfigurationManager.ConnectionStrings["NOHA_ADO"].ToString();

      #region old_code
      using (var sqlConnection = new SqlConnection(cadCnx))
      {
        sqlConnection.Open();
        var dbCmd = new System.Data.SqlClient.SqlCommand(sQuery, sqlConnection);
        try
        {
          dbCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          Exception customException = new Exception();
          //if (ExceptionPolicy.HandleException(ex, "Business Layer Policy", customException))
          //{
          //    throw customException;
          //}
        }
        finally
        {
          sqlConnection.Close();
        }
      }
      #endregion

      return "";
    }

    public static DataTable AdoSqlGetDataTable(string sQuery, string alternativeCnx = "")
    {

      {
        SqlConnection sqlConnection;
        if (string.IsNullOrEmpty(alternativeCnx))
        {
          sqlConnection =
            new SqlConnection(
              System.Configuration.ConfigurationManager.ConnectionStrings["NOHA_ADO"].ToString());
        }
        else
        {
          sqlConnection =
            new SqlConnection(
              System.Configuration.ConfigurationManager.ConnectionStrings[alternativeCnx].ToString());
        }
        sQuery = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + sQuery;
        var DsResult = new DataSet();
        var Result = new DataTable();



        sqlConnection.Open();

        try
        {
          using (SqlDataAdapter dbAdapter = new SqlDataAdapter(sQuery, sqlConnection))
          {
            dbAdapter.Fill(DsResult, "Table");
            if (DsResult.Tables.Count > 0)
            {
              Result = DsResult.Tables[0];
            }
          }
        }
        catch (Exception ex)
        {
          //Exception customException = new Exception();
          //if (ExceptionPolicy.HandleException(ex, "Business Layer Policy", customException))
          //{
          //    throw customException;
          //}
          //MessageBox.Show(ex.Message);
        }
        finally
        {
          DsResult.Dispose();
          sqlConnection.Close();
          //dbCxn.Close();
        }

        return Result;
      }
    }

    public static IEnumerable<T> ExecSqlGetList<T>(string query, string alternativeCnx = "") where T : new()
    {
      //var cadCnx = System.Configuration.ConfigurationManager.ConnectionStrings["Terpel_TC_ProdADO"].ToString();
      //var empList = new List<T>();
      //query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + query;
      //using (var _db = new SqlConnection(cadCnx))
      //{
      //    empList = _db.Query<T>(query).ToList();
      //}

      //return empList;

      var obj = AdoSqlGetDataTable(query, alternativeCnx);
      var res = obj.ToList<T>();
      return res;


    }
  }

  public static class DataTableExtensions
  {



    private static Dictionary<Type, IList<PropertyInfo>> typeDictionary = new Dictionary<Type, IList<PropertyInfo>>();
    public static IList<PropertyInfo> GetPropertiesForType<T>()
    {
      var type = typeof(T);
      if (!typeDictionary.ContainsKey(typeof(T)))
      {
        typeDictionary.Add(type, type.GetProperties().ToList());
      }
      return typeDictionary[type];
    }

    //public static IList<T> ToList<T>(this DataTable table) where T : new()
    //{
    //  IList<PropertyInfo> properties = GetPropertiesForType<T>();
    //  IList<T> result = new List<T>();

    //  foreach (var row in table.Rows)
    //  {
    //    var item = CreateItemFromRow<T>((DataRow)row, properties);
    //    result.Add(item);
    //  }

    //  return result;
    //}

    private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
    {
      T item = new T();
      foreach (var property in properties)
      {
        property.SetValue(item, row[property.Name], null);
      }
      return item;
    }


    public static IList<T> ToList<T>(this DataTable table) where T : new()
    {

      string propName = string.Empty;
      List<T> entityList = new List<T>();

      foreach (DataRow dr in table.Rows)
      {
        // Create Instance of the Type T
        T entity = System.Activator.CreateInstance<T>();

        // Get all properties of the Type T
        System.Reflection.PropertyInfo[]
        entityProperties = typeof(T).GetProperties();

        // Loop through the properties defined in the 
        // entityList entity object and mapped the value
        foreach (System.Reflection.PropertyInfo item in
                entityProperties)
        {
          propName = string.Empty;
          if (propName.Equals(string.Empty))
            propName = item.Name;

          if (table.Columns.Contains(propName))
          {
            // Assign value to the property
            try
            {
              item.SetValue
              (
                  entity,
                  dr[propName].GetType().
                      Name.Equals(typeof(DBNull).Name)
                      ? null : dr[propName],
                  null
              );
            }
            catch (Exception)
            {

              throw;
            }

          }
        }


        entityList.Add(entity);
      }
      return entityList;
    }

  }
}