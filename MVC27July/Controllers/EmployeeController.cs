using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Entities;
using Application.DataAccess;

namespace MVC27July.Controllers
{
    public class EmployeeController : Controller
    {
        IDataAccess<Employee, int> dataAccess;

        //public EmployeeController()
        //{

        //}
        public EmployeeController(IDataAccess<Employee,int> d)
        {
            dataAccess = d;
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employees = dataAccess.Get();

            return View(employees);
        }

        public ActionResult Create()
        {
            var dept = new Employee();
            return View(dept);
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            dataAccess.Craete(emp);
            // Once the Save / Create is Succeful Redirect to Index Action
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            // Get the Dept that is to be edited based on the 'id'
            var dept = dataAccess.Get(id);
            // pass the dept to edit to View
            return View(dept);
        }

        [HttpPost]
        public ActionResult Edit(int id, Employee dept)
        {
            dataAccess.Update(id, dept);
            // redirect to Index
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Show Details View
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var dept = dataAccess.Get(id);
            return View(dept);
        }


        public ActionResult Delete(int id)
        {
            dataAccess.Delete(id);
            return RedirectToAction("Index");
        }

      
    }
}