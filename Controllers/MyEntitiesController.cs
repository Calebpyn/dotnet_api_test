using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyEntityController : ControllerBase
    {
        private readonly MyDbContext _context;

        public MyEntityController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/task
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskEntity>>> GetProducts()
        {
            return await _context.TaskEntities.ToListAsync();  // Use TaskEntities here
        }
    }
}
