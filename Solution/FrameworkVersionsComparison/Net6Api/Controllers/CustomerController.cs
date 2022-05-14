using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Net6Api.Data;

namespace Net6Api.Controllers
{
    [Route("/customer")]
    public class CustomerController : Controller
    {
        private readonly AdventureWorks _dbContext;
        public CustomerController(AdventureWorks dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("orders/count")]
        public async Task<IActionResult> GetOrdersCount()
        {
            var ordersCount = await _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .CountAsync();
            return Ok(ordersCount);
        }

        [HttpGet("orders")]
        public async Task<IActionResult> GetOrders(int pageNumber = 1, int pageSize = 100)
        {
            var orders = await _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Include(x => x.SalesOrderDetails)
                .OrderBy(x => x.SalesOrderID)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return Ok(orders);
        }

        [HttpGet("products/count")]
        public async Task<IActionResult> GetProductsCount()
        {
            var productsCount = await _dbContext.Products.AsQueryable().AsNoTracking()
                .CountAsync();
            return Ok(productsCount);
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts(int pageNumber = 1, int pageSize = 100)
        {
            var products = await _dbContext.Products.AsQueryable().AsNoTracking()
                .OrderBy(x => x.ProductID)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return Ok(products);
        }
    }
}
