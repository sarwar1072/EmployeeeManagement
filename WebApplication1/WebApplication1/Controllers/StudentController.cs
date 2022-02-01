using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        EmployeeContext _employeeContext;
        public StudentController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public IActionResult Index()
        {
           var studentList=_employeeContext.employee.ToList();
            return View(studentList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.employee.Add(employee);
                _employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id==null || id < 0)
            {
                return BadRequest();
            }
            var editList = _employeeContext.employee.FirstOrDefault(x => x.Id == id);
            if (editList == null)
            {
                return NotFound();
            }
            return View(editList);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (!ModelState.IsValid)
                return View(employee);
            _employeeContext.employee.Update(employee);
            _employeeContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id < 0)
            {
                return BadRequest();
            }
            var delete = _employeeContext.employee.FirstOrDefault(x => x.Id == id);
            if (delete == null)
            {
                return NotFound();

            }

            _employeeContext.Remove(delete);
            _employeeContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
