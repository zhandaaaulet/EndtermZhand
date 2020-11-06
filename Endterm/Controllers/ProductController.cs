using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Endterm.DTO;
using Endterm.Models;
using Endterm.Repositories.Implementations;
using Endterm.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endterm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPriceListRepository _priceListRepository;
        private readonly IProductRepository _productRepository;

        public ProductController(IPriceListRepository priceListRepository, IProductRepository productRepository)
        {
            _priceListRepository = priceListRepository;
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult SayHello()
        {
            return Ok("Hello!");
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddProduct(PriceListDTO p)
        {
            PriceList priceList = new PriceList(p);
            if(await _priceListRepository.AddProduct(priceList))
            {
                return Ok("A new product was added successfully");
            }
            return BadRequest("Product not added");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            return (IActionResult)await _productRepository.GetByIdAsync(id);
        }
    }
}
