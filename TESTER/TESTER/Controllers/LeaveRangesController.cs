using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TESTER.Data;
using TESTER.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TESTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRangesController : ControllerBase
    {
        //CRUD  CREATE, RELOAD,  UPDATE,  DELETE

        
        // GET: api/<LeaveRangesController>
        [HttpGet]//OBTENER
        public IEnumerable<LeaveRanges> Get()
        {
            LeaveRangesData gestor = new LeaveRangesData();
            return gestor.GetListaAll();
        }

        // GET api/<LeaveRangesController>/5
        [HttpGet("{id}")]//OBTENER POR ID
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LeaveRangesController>
        [HttpPost]//CREAR
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LeaveRangesController>/5
        [HttpPut("{id}")]//ACTUALIZAR
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LeaveRangesController>/5
        [HttpDelete("{id}")]//ELIMINAR
        public void Delete(int id)
        {
        }
    }
}
