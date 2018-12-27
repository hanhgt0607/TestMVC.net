using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test5.Models;

namespace Test5.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class EmployeesController : Controller
    {
        private readonly Test5Context _context;

        public EmployeesController(Test5Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> getAllStudent()
        {
            return _context.Employee;
        }
    }
}
