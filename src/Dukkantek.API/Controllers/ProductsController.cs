
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Dukkantek.API.DTOs.Product;
using Dukkantek.Domain.Interfaces;
using Dukkantek.Domain.Models.Inventories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Dukkantek.API.Controllers
{

    [Route("api/[controller]")]
    public class ProductsController : MainController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper,
                                IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }


        [HttpGet]
        [Route("productStatus/{categoryId}")]
        public async Task<IActionResult> ProductStatus(int categoryId = 0)
        {
            var productStatus = await _productService.GetProductStatus(categoryId);


            if (!productStatus.Any()) return NotFound();

            return Ok(productStatus);

        }



        [HttpPut]
        [Route("ChangeStatus/{id}")]
        public async Task<IActionResult> ChangeStatus(int id, ChangeStatusDto changeStatusDto)
        {
            if (id != changeStatusDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var resultMessage = await _productService.ChangeStatus(_mapper.Map<Product>(changeStatusDto));

            return Ok(resultMessage);
        }

        [HttpPut]
        [Route("Sale/{id}")]
        public async Task<IActionResult> Sale(int id, SaleDto saleDto)
        {
            if (id != saleDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var resultMessage = await _productService.Sale(_mapper.Map<Product>(saleDto));
                             
            return Ok(resultMessage);
        }

    }

}
