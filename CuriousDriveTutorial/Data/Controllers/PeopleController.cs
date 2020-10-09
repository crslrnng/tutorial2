using CuriousDriveTutorial.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CuriousDriveTutorial.Data.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        //dependancy injection for applicationdbcontext
        private readonly ApplicationDBContext context1;
        public PeopleController(ApplicationDBContext context) { this.context1 = context; }

        //get action method
        [HttpGet]
        public async Task<IActionResult> Get() => (IActionResult)await context1.People.ToListAsync();

        //get action id
        [HttpGet("{id}", Name = "GetPerson")]
        public async Task<ActionResult<Person>> Get(int id) => await context1.People.FirstOrDefaultAsync(x => x.ID == id);

        //create
        [HttpPost]
        public async Task<IActionResult> Post(Person person)
        {
            context1.Add(person);
            await context1.SaveChangesAsync();
            return Ok(person.ID);
        }

        //update
        [HttpPut]
        public async Task<IActionResult> Put(Person person)
        {
            context1.Entry(person).State = EntityState.Modified;
            await context1.SaveChangesAsync();
            return NoContent();
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            context1.Remove(new Person { ID = id });
            await context1.SaveChangesAsync();
            return NoContent();
        }
    }
}
