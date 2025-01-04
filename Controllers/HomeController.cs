using EF_CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
      
        public async Task<IActionResult> Create(Student std)
        {
            

            if (ModelState.IsValid)
            {

                await studentDbContext.Students.AddAsync(std);
                await studentDbContext.SaveChangesAsync();
                TempData["Success"] = "Record Inserted";

                return RedirectToAction("Index","Home");
            }

           
            return View(std);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var student = await studentDbContext.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();  
            }
            return View(student);  
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id ,Student std)
        {
            if (id != std.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                 studentDbContext.Students.Update(std);
                await studentDbContext.SaveChangesAsync();
                TempData["Success"] = "Record Updated";

                return RedirectToAction("Index", "Home");
            }
           
            return View(std);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await studentDbContext.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

   
            studentDbContext.Students.Remove(student);
            await studentDbContext.SaveChangesAsync();
            TempData["Success"] = "Record Deleted";
            return RedirectToAction("Index", "Home");

        }

    }
}
