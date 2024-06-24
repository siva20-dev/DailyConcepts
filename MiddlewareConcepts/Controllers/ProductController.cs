﻿using Day25Concepts.Models;
using Day25Concepts.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day25Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductRepository _productRepository1;

        public ProductController(IProductRepository productRepository, IProductRepository productRepository1)
        {
            _productRepository = productRepository;
            _productRepository1 = productRepository1;
        }
        
        [HttpPost("")]
        public IActionResult AddProduct([FromBody]ProductModel product) 
        {
            _productRepository.AddProduct(product);

            var products = _productRepository1.GetAllProducts();

            return Ok(products);
        }

        [HttpGet("")]
        public IActionResult GetName()
        {
            var name = _productRepository.GetName();

            return Ok(name);
        }
    }
}
