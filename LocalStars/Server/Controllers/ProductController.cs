﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Providers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Server.Controllers.Models;
using System.Threading;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly BuyerProvider _buyerProvider;
        private readonly ProductProvider _productProvider;
        private readonly SellerProvider _sellerProvider;
        private readonly DataContext _context;
        private readonly UserProvider _userProvider;

        public ProductController(BuyerProvider buyerProvider,ProductProvider productProvider, SellerProvider sellerProvider, DataContext context, UserProvider userProvider)
        {
            _buyerProvider = buyerProvider;
            _productProvider = productProvider;
            _sellerProvider = sellerProvider;
            _userProvider = userProvider;
            _context = context;
        }

        [HttpGet]
        [Route("title")]
        public IEnumerable<Product> GetProducts([FromQuery] string searchVal, [FromQuery] bool fullMatch = false)
        {
            return _productProvider.GetByTitle(searchVal, fullMatch, StringComparison.OrdinalIgnoreCase);
        }

        [HttpPost]
        [Route("ids")]
        public IEnumerable<Product> GetProducts([FromBody] Guid[] ids)
        {
            return _productProvider.GetById(ids);
        }

        [HttpPost]
        [Route("sellerId")]
        public IEnumerable<ProductsForSeller> GetBySeller([FromBody] IEnumerable<Guid> ids)
        {
            var sellers = _sellerProvider.GetById(ids).ToList();
            return _productProvider.GetBySeller(sellers);
        }

        [HttpGet]
        [Route("{id}")]
        public Product Get([FromRoute] Guid id)
        {
            return _productProvider.GetById(new[] { id }).Single();
        }

        // Needs to be replaced with location based search
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productProvider
                .Get()
                .ToArray();
        }


        [HttpDelete]
        public void RemoveById([FromBody] IEnumerable<Guid> ids)
        {
            _productProvider.RemoveById(ids);
        }

        [HttpPost]
        [Route("insert")]
        public void Insert([FromBody] ProductData productdata)
        {

            Seller sellerId = _userProvider.GetUser(Guid.Parse(Request.HttpContext.User.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value)).AssociatedSeller;
            Product product = new Product(productdata.Title, productdata.Category, productdata.Price, sellerId ,productdata.Description, Guid.NewGuid());
            _productProvider.Insert(product);

        }

        [HttpPut]
        public void Update([FromBody] Product product)
        {
            _productProvider.Update(product);
        }
    }
}
