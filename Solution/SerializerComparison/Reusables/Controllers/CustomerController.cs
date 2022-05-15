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

        [HttpGet("orders/count")]
        public async Task<IActionResult> GetOrdersCount()
        {
            var ordersCount = await _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .CountAsync();
            return Ok(ordersCount);
        }

        [HttpGet("orders/ids")]
        public async Task<IActionResult> GetOrderIds()
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

            // hack to make code with source generators work without cyclic references, as code generators does not support it for now
            for (int j = 0; j < order.SalesOrderDetails.Count; j++)
            {
                var orderDetailsItem = order.SalesOrderDetails[j];
                orderDetailsItem.SalesOrderHeader = null;
            }
            return Ok(order);
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

            // hack to make code with source generators work without cyclic references, as code generators does not support it for now
            for (int i = 0; i < orders.Count; i++)
            {
                var order = orders[i];
                for (int j = 0; j < order.SalesOrderDetails.Count; j++)
                {
                    var orderDetailsItem = order.SalesOrderDetails[j];
                    orderDetailsItem.SalesOrderHeader = null;
                }
            }
            return Ok(orders);
        }
    }
}
