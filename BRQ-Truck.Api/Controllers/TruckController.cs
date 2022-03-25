using BRQ_Truck.Domain;
using BRQ_Truck.Repository.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BRQ_Truck.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly ITruckRepository _repository;

        public TruckController(ITruckRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<TruckController>
        [HttpGet]
        public async Task<ActionResult<List<Truck>>> Get()
        {
            try
            {
                return Ok(await _repository.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET api/<TruckController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Truck>> Get(int id)
        {
            try
            {
                return Ok(await _repository.Get(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<TruckController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post([FromBody] Truck value)
        {
            try
            {
                var result = await _repository.Insert(value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<TruckController>/5
        [HttpPut]
        public async Task<ActionResult<bool>> Put([FromBody] Truck value)
        {
            try
            {
                var result = await _repository.Update(value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<TruckController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            try
            {
                await _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
