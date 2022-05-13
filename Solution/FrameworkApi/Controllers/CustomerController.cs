using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using FrameworkApi.Data;

namespace FrameworkApi.Controllers
{
    [RoutePrefix("customer")]
    public class CustomerController : ApiController
    {
        [HttpGet()]
        [Route("orders/count")]
        public async Task<IHttpActionResult> GetOrdersCount()
        {
            using (var dbContext = new AdventureWorks())
            {
                var ordersCount = await dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                    .CountAsync();
                return Ok(ordersCount);
            }
        }

        [HttpGet()]
        [Route("orders")]
        public async Task<IHttpActionResult> GetOrders(int pageNumber = 1, int pageSize = 100)
        {
            using (var dbContext = new AdventureWorks())
            {
                var orders = await dbContext.SalesOrderHeaders.AsQueryable().AsNoTracking()
                    .Include(x => x.SalesOrderDetails)
                    .OrderBy(x => x.SalesOrderID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                return Ok(orders);
            }
        }

        [HttpGet()]
        [Route("products/count")]
        public async Task<IHttpActionResult> GetProductsCount()
        {
            using (var dbContext = new AdventureWorks())
            {
                var productsCount = await dbContext.Products.AsQueryable().AsNoTracking()
                    .CountAsync();
                return Ok(productsCount);
            }
        }

        [HttpGet()]
        [Route("products")]
        public async Task<IHttpActionResult> GetProducts(int pageNumber = 1, int pageSize = 100)
        {
            using (var dbContext = new AdventureWorks())
            {
                var products = await dbContext.Products.AsQueryable().AsNoTracking()
                    .OrderBy(x => x.ProductID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                return Ok(products);
            }
        }
    }
}