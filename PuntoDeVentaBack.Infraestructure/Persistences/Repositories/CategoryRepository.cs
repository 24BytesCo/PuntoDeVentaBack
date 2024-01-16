using PuntoDeVentaBack.Domain.Entities;
using PuntoDeVentaBack.Infraestructure.Commons.Bases.Request;
using PuntoDeVentaBack.Infraestructure.Commons.Bases.Response;
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

        public Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters)
        {
            throw new NotImplementedException();
        }

        public Task<BaseEntityResponse<Category>> ListSelectCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> CategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterCategory(Category category)
        {
            throw new NotImplementedException();
        }


        public Task<bool> EditCategory(Category category)
        {
            throw new NotImplementedException();
        }


        public Task<bool> RemoveCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
