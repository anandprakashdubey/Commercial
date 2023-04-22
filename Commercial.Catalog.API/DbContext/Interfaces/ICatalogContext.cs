using Commercial.Catalog.API.Entities;
using MongoDB.Driver;

namespace Commercial.Catalog.API.DbContext.Interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
