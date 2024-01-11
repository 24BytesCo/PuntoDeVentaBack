namespace PuntoDeVentaBack.Infraestructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaraci{on ma tricula de nustras interfaces a nivel de nuestro repositorio
        ICategoryRepository CategoryRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();

    }
}
