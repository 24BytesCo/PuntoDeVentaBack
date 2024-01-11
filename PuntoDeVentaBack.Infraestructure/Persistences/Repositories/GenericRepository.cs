using PuntoDeVentaBack.Infraestructure.Commons.Bases;
using PuntoDeVentaBack.Infraestructure.Helpers;
using PuntoDeVentaBack.Infraestructure.Persistences.Interfaces;
using System.Linq.Dynamic.Core;

namespace PuntoDeVentaBack.Infraestructure.Persistences.Repositories
{
    // Clase que implementa un repositorio genérico para operaciones CRUD
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // Método para ordenar una consulta IQueryable basada en los parámetros de paginación y orden proporcionados
        protected IQueryable<TDTO> Ordering<TDTO>(BasePaginationRequest request, IQueryable<TDTO> queryable, bool pagination = false) where TDTO : class
        {
            // Ordena la consulta en función de la dirección de orden proporcionada en la solicitud (ascendente o descendente)
            IQueryable<TDTO> queryDto = request.Order == "desc" ? queryable.OrderBy($"{request.Sort} descending") :
                queryable.OrderBy($"{request.Sort} ascending");

            // Aplicar paginación si está habilitada en los parámetros
            if (pagination)
            {
                queryDto = queryDto.Paginate(request);
            }

            // Devolver la consulta IQueryable resultante
            return queryDto;
        }
    }
}

