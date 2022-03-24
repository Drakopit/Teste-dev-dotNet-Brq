using BRQ_Truck.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BRQ_Truck.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly LocalDBContext _dBContext;

        public TruckController(LocalDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        // GET: api/<TruckController>
        [HttpGet]
        public ActionResult<List<Truck>> Get()
        {
            return Ok(_dBContext.Truck.ToList());
        }

        // GET api/<TruckController>/5
        [HttpGet("{id}")]
        public ActionResult<Truck> Get(int id)
        {
            return Ok(_dBContext.Truck.Where(t => t.Id == id).FirstOrDefault());
        }

        //// POST api/<TruckController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<TruckController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TruckController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
