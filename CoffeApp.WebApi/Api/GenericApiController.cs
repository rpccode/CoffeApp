using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeApp.WebApi.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericApiController<T> : ControllerBase where T:BaseDTO
    {
        readonly IGenericRepository<T> repository;
        public GenericApiController(IGenericRepository<T> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<T>> Get()
        {
            try
            {
                return Ok(repository.Read);
            }
            catch (Exception)
            {

                return BadRequest(repository.Error);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<T> Get(string id)
        {
            try
            {
                return Ok(repository.SearchById(id));
            }
            catch (Exception)
            {
                return BadRequest(repository.Error);
                
            }
        }
        [HttpPost]
        public ActionResult<T> Post([FromBody] T value)
        {
            try
            {
                return Ok(repository.Create(value));
            }
            catch (Exception)
            {

                return BadRequest(repository.Error);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            try
            {
                return Ok(repository.Delete(id));
            }
            catch (Exception)
            {

                return BadRequest(repository.Error);
            }
        }
        [HttpPut]
        public ActionResult<T> Put([FromBody] T value)
        {
            try
            {
                return Ok(repository.Update(value));
            }
            catch (Exception)
            {

                return BadRequest(repository.Error);
            }
        } 
    }
}
