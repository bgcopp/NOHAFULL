using System;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace BGCOP.CAVTOP.BUSINESSLAYER
{
	public class TareasInner
	{
		public TareasInner()
		{
		}

		public void AgregarTarea(int CodeInner, string codigoTarea, string codigoBarras)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TInnerAccion tInnerAccion = new TInnerAccion()
				{
					CodeInner = new int?(CodeInner),
					CodigoAccion = codigoTarea,
					Cumplido = new int?(0),
					fecha = new DateTime?(DateTime.Now)
				};
				masterDBACEntity.AddToTInnerAccion(tInnerAccion);
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

		public void CumplirTarea(TInnerAccion tmp)
		{
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TInnerAccion nullable = (
					from a in masterDBACEntity.TInnerAccion
					where a.id == tmp.id
					select a).FirstOrDefault<TInnerAccion>();
				nullable.Cumplido = new int?(1);
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

		public TInnerAccion ObtenerUltimaTarea(int CodeInner)
		{
			TInnerAccion tInnerAccion;
			masterDBACEntities masterDBACEntity = new masterDBACEntities();
			try
			{
				TInnerAccion tInnerAccion1 = (
					from a in masterDBACEntity.TInnerAccion
					where a.CodeInner == (int?)CodeInner && a.Cumplido == (int?)0
					orderby a.fecha descending
					select a).FirstOrDefault<TInnerAccion>();
				tInnerAccion = tInnerAccion1;
			}
			finally
			{
				if (masterDBACEntity != null)
				{
					((IDisposable)masterDBACEntity).Dispose();
				}
			}
			return tInnerAccion;
		}
	}
}