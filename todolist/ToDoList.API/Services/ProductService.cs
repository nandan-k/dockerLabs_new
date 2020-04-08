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
using ToDoList.API.Data;

namespace ToDoList.API.Services
{
    public class ProductService :IProductService
    {

         private List<ToDoList.API.Models.Product> _products;
    private readonly SampleContext _context;

    public ProductService(IConfiguration config, SampleContext context) {
        _context = context;
      
    }

    public List<ToDoList.API.Models.Product> GetProducts() {
       
    _products = _context.Products.ToList();
      return _products;
    }
    }
}