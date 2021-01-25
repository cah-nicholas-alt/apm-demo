using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EcommerceApi.Data;
using EcommerceApi.Models;
using Elastic.Apm;
using Elastic.Apm.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace EcommerceApi.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly EcommerceDbContext _ecommerceDbContext;
        private readonly IConnectionMultiplexer _redisConnection;
        private readonly HttpClient _httpClient;

        public ProductsController(EcommerceDbContext ecommerceDbContext, IConnectionMultiplexer redisConnection, HttpClient httpClient)
        {
            _ecommerceDbContext = ecommerceDbContext;
            _redisConnection = redisConnection;
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            List<Product> products;
            if (await _redisConnection.GetDatabase().KeyExistsAsync("product-cache"))
            {
                string productCache = await _redisConnection.GetDatabase().StringGetAsync("product-cache");
                products = JsonConvert.DeserializeObject<List<Product>>(productCache);
            }
            else
            {
                products = await _ecommerceDbContext.Products.ToListAsync();
                await _redisConnection.GetDatabase().StringSetAsync("product-cache", JsonConvert.SerializeObject(products), TimeSpan.FromSeconds(30));
            }

            _httpClient.BaseAddress = new Uri("http://www.google.com/helloworld?msg=helloWorld");
            await _httpClient.GetAsync("");
            
            await _httpClient.GetAsync("http://localhost:5001/api/fulfillment/1/status");
            
            return Ok(products);
        }
    }
}
