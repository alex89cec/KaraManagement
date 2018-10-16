using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KaraApi.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KaraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly KaraDbContext _context;

        public StudentsController(KaraDbContext context)
        {
            _context = context;

            if (_context.StudentsList.Count() == 0)
            {
                _context.StudentsList.Add(new Student { Name = "Alex" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAll()
        {
            return _context.StudentsList.ToList();
        }

        [HttpGet("{id}", Name = "GetTodxo")]
        public ActionResult<Student> GetById(long id)
        {
            var item = _context.StudentsList.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
