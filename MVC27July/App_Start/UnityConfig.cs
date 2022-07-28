using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Application.DataAccess;
using Application.Entities;

namespace MVC27July
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDataAccess<Department, int>, DepartmentDataAccess>();
            container.RegisterType<IDataAccess<Employee, int>, EmployeeDataAccess>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}