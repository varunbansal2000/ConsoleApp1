using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.DataAccess;
using Application.Entities;

namespace WebApplication21July.Assignments
{
    public partial class Search25July : System.Web.UI.Page
    {
        IDataAccess<Department, int> departmentDataAcecss;
        IDataAccess<Employee, int> employeeDataAcecss;
        protected void Page_Load(object sender, EventArgs e)
        {
            departmentDataAcecss = new DepartmentDataAccess();
            employeeDataAcecss = new EmployeeDataAccess();

            if (!IsPostBack)
            {
                List<Department> departmentList = (List<Department>)departmentDataAcecss.Get();
                DropDownDepartment.Items.Add("Select");
                DropDownDepartment.Items.FindByText("Select").Attributes.Add("disabled", "disabled");
                DropDownDepartment.Items.FindByText("Select").Selected = true;
                foreach (var d in departmentList)
                {
                    DropDownDepartment.Items.Add(d.DeptName);
                    DropDownDepartment.Items.FindByText(d.DeptName).Value = d.DeptNo.ToString();
                }
                Loader();
            }
        }

        private void Loader()
        {
            try
            {


                gvDept.DataSource = employeeDataAcecss.Get();
                gvDept.DataBind();
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void DropDownDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DropDownDepartment.SelectedItem.Value);
            List<Employee> employees = (List<Employee>)employeeDataAcecss.Get();
            List<Employee> filtered = new List<Employee>();
            foreach(var e2 in employees)
            {
                if(e2.DeptNo == id)
                {
                    filtered.Add(e2);
                }
            }
            gvDept.DataSource = filtered;
            gvDept.DataBind();
        }
    }
}