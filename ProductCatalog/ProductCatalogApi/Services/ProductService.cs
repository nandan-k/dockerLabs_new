using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


using System.Linq;
using ProductCatalogApi.Data;
using ProductCatalogApi.Interfaces;

namespace ProductCatalogApi.Services
{
    public class ProductService  : IProductService
    {

         private List<ProductCatalogApi.Models.Product> _products;
    private readonly ProductCatalogContext _context;

    public ProductService(IConfiguration config, ProductCatalogContext context) {
        _context = context;
      
    }

    public List<ProductCatalogApi.Models.Product> GetProducts() {
       
    _products = _context.Products.ToList();
      return _products;
    }
    }
}