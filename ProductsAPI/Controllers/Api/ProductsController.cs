using ProductsAPI.Data.Interfaces;
using ProductsAPI.Data.Repositories;
using ProductsAPI.Data.Services;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProductsAPI.Controllers.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        private IApiService _apiService;

        public ProductsController()
        {
            _apiService = new ApiService(new DataRepository());
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = _apiService.GetProducts();

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var result = _apiService.GetProductById(id.Value);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest();
            }

            var result = _apiService.GetProductsByName(name);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [Route("api/products/saleproducts")]
        [HttpGet]
        public IHttpActionResult GetSaleProducts()
        {
            var result = _apiService.GetSaleProducts();

            return Ok(result);
        }

        [Route("api/products/maleproducts")]
        [HttpGet]
        public IHttpActionResult GetMaleProducts()
        {
            var result = _apiService.GetMaleProducts();

            return Ok(result);
        }

        [Route("api/products/femaleproducts")]
        [HttpGet]
        public IHttpActionResult GetFemaleProducts()
        {
            var result = _apiService.GetFemaleProducts();

            return Ok(result);
        }
    }
}
