using EF_CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EF_CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDbContext;

        public HomeController(StudentDbContext studentDbContext) 
        {
            this.studentDbContext = studentDbContext;
        }

        public IActionResult Index()
        {
            var stdData= studentDbContext.Students.ToList();
            return View(stdData);
        }

     

        
    }
}
