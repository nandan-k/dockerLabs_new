using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductCatalogApi.Services;
using ProductCatalogApi.Models   ;
using ProductCatalogApi.Interfaces;

namespace ProductCatalogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
      
        private readonly ILogger<ProductsController> _logger;
        private IProductService _ProductService;
        public ProductsController(ILogger<ProductsController> logger,IProductService productService)
        {
            _logger = logger;
            _ProductService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
           return _ProductService.GetProducts();
        }
    }
}
