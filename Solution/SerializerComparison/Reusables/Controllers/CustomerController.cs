using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reusables.Data;

namespace Reusables.Controllers
{
    [Route("/customer")]
    public class CustomerController : Controller
    {
        private readonly AdventureWorks _dbContext;
        public CustomerController(AdventureWorks dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("orders/ids")]
        public async Task<IActionResult> GetOrdersCount()
        {
            var orderIds = await _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Select(x => x.SalesOrderID).ToArrayAsync();
            return Ok(orderIds);
        }

        [HttpGet("orders/{id:int}")]
        public async Task<IActionResult> GetOrder([FromRoute] int id)
        {
            var order = await _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Include(x => x.SalesOrderDetails)
                .FirstOrDefaultAsync(x => x.SalesOrderID == id);
            return Ok(order);
        }

        [HttpGet("products/ids")]
        public async Task<IActionResult> GetProductsCount()
        {
            var productIds = await _dbContext.Products.AsQueryable().AsNoTracking()
                .Select(x => x.ProductID).ToArrayAsync();
            return Ok(productIds);
        }

        [HttpGet("products/{id:int}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            var product = await _dbContext.Products.AsQueryable().AsNoTracking()
                .FirstOrDefaultAsync(x => x.ProductID == id);
            return Ok(product);
        }
    }
}
