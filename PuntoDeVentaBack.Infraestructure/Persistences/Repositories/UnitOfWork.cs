using PuntoDeVentaBack.Infraestructure.Persistences.Interfaces;
using PuntoDeVentaBack.Infraestucture.Context;

namespace PuntoDeVentaBack.Infraestructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PosContext _context;

        public ICategoryRepository CategoryRepository { get; private set; }

        public UnitOfWork(PosContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(_context);
        }


        public void Dispose()
        {
            //Liberando espacios en memoria
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
