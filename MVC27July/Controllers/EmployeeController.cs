using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Entities;
using Application.DataAccess;

namespace MVC27July.Controllers
{
    //[HandleError(ExceptionType = typeof(Exception), View = "Error")]
    public class EmployeeController : Controller
    {
        IDataAccess<Employee, int> dataAccess;
        LoggerAccess loggerAccess;

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
            if (emp.EmpNo < 0)
            {
                throw new Exception("DeptNo cannot be 0 or negative");
            }

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

        

        protected override void OnException(ExceptionContext filterContext)
        {
            loggerAccess = new LoggerAccess();
            //base.OnException(filterContext);
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            Logger log = new Logger();
            log.ControllerName = filterContext.RouteData.Values["controller"].ToString();
            log.ActionName = filterContext.RouteData.Values["action"].ToString();
            log.ExceptionDetails = ex.Message;
            loggerAccess.AddLog(log);

            ViewResult result = this.View("Error", new HandleErrorInfo(ex, this.RouteData.Values["controller"].ToString(), this.RouteData.Values["action"].ToString()));
            

                filterContext.Result = result;

        }

        public ActionResult loggerDetails()
        {
            loggerAccess = new LoggerAccess();
            List<Logger> l = new List<Logger>();
            l = (List<Logger>)loggerAccess.GetLoggers();
            return View("LoggeDetails",l);
        }

    }
}