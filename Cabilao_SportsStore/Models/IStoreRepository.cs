namespace Cabilao_SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
