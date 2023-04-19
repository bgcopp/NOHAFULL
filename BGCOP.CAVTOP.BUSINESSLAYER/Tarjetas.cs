using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class Tarjetas
	{
		public Tarjetas()
		{
		}

		public void asignartarjetaempleado(string tarjetaS, int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TTarjeta tTarjetum = (
					from a in masterDBACEntity.TTarjeta
					where a.numtarjeta == tarjetaS
					select a).FirstOrDefault<TTarjeta>();
				TEmpleado nullable = (
					from b in masterDBACEntity.TEmpleado
					where b.idEmpleado == id
					select b).FirstOrDefault<TEmpleado>();
				nullable.idTarjeta = new int?(tTarjetum.idTarjeta);
				masterDBACEntity.SaveChanges();
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
		}

		public void asignartarjetaempleado(int tarjetaI, int id)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TEmpleado nullable = (
					from b in masterDBACEntity.TEmpleado
					where b.idEmpleado == id
					select b).FirstOrDefault<TEmpleado>();
				nullable.idTarjeta = new int?(tarjetaI);
				masterDBACEntity.SaveChanges();
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
		}

		public void crearTarjeta(string cad)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TTarjeta tTarjetum = new TTarjeta()
				{
					numtarjeta = cad,
					activa = new bool?(true)
				};
				masterDBACEntity.AddToTTarjeta(tTarjetum);
				masterDBACEntity.SaveChanges();
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
		}

		public void limpiarTarjeta(string tarjetaS)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TTarjeta nullable = (
					from a in masterDBACEntity.TTarjeta
					where a.numtarjeta == tarjetaS
					select a).FirstOrDefault<TTarjeta>();
				if (nullable != null)
				{
					nullable.esvisitante = new bool?(false);
				}
				masterDBACEntity.SaveChanges();
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
		}

		public List<TTarjeta> ListarTodas()
		{
			List<TTarjeta> list;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				IQueryable<TTarjeta> tTarjeta = 
					from usr in masterDBACEntity.TTarjeta
					select usr;
				list = tTarjeta.ToList<TTarjeta>();
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return list;
		}

		public List<TTarjeta> ListarTodasActivas()
		{
			List<TTarjeta> list;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				IQueryable<TTarjeta> tTarjeta = 
					from usr in masterDBACEntity.TTarjeta
					where usr.esutilizada != (bool?)true
					select usr;
				list = tTarjeta.ToList<TTarjeta>();
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return list;
		}
	}
}