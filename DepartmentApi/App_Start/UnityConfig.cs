using System.Web.Http;
using Unity;
using Unity.WebApi;
using Application.DataAccess;
using Application.Entities;

namespace DepartmentApi
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

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}