using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.API.Services;
using ToDoList.API.Models   ;

namespace ToDoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
      
        private readonly ILogger<ProductController> _logger;
        private IProductService _ProductService;
        public ProductController(ILogger<ProductController> logger,IProductService productService)
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
