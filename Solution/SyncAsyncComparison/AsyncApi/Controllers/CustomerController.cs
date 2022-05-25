using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reusables.Data;

namespace AsyncApi.Controllers
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
            return Ok(order);
        }
    }
}
