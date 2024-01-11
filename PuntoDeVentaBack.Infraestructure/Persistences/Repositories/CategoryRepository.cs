using PuntoDeVentaBack.Domain.Entities;
using PuntoDeVentaBack.Infraestructure.Persistences.Interfaces;
using PuntoDeVentaBack.Infraestucture.Context;

namespace PuntoDeVentaBack.Infraestructure.Persistences.Repositories
{
    public class CategoryRepository: GenericRepository<Category>, ICategoryRepository
    {
        private readonly PosContext _context;

        public CategoryRepository(PosContext context)
        {
            _context = context;
        }
    }
}
