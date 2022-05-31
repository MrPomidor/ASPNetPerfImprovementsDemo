using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reusables.Data;

namespace SyncApiMoreThreads.Controllers
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
        public IActionResult GetOrdersCount()
        {
            var ordersCount = _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Count();
            return Ok(ordersCount);
        }

        [HttpGet("orders")]
        public IActionResult GetOrders(int pageNumber = 1, int pageSize = 100)
        {
            var orders = _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Include(x => x.SalesOrderDetails)
                .OrderBy(x => x.SalesOrderID)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return Ok(orders);
        }

        [HttpGet("orders/ids")]
        public IActionResult GetOrderIds()
        {
            var orderIds = _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Select(x => x.SalesOrderID).ToArray();
            return Ok(orderIds);
        }

        [HttpGet("orders/{id:int}")]
        public IActionResult GetOrder([FromRoute] int id)
        {
            var order = _dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                .Include(x => x.SalesOrderDetails)
                .FirstOrDefault(x => x.SalesOrderID == id);
            return Ok(order);
        }
    }
}
