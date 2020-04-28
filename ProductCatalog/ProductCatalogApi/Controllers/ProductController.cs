using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductCatalogApi.Services;
using ProductCatalogApi.Models   ;

namespace ProductCatalogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
      
        private readonly ILogger<ProductController> _logger;
        private ProductService _ProductService;
        public ProductController(ILogger<ProductController> logger,ProductService productService)
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
