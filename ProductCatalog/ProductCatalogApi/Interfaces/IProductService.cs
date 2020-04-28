using System.Linq;
using System.Collections.Generic;
using ProductCatalogApi.Data;

namespace ProductCatalogApi.Interfaces
{
    public interface IProductService
    {
    
        public List<ProductCatalogApi.Models.Product> GetProducts();
        
    }
}