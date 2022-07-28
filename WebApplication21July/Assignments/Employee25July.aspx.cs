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
    public partial class Employee25July : System.Web.UI.Page
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
            //DropDownDepartment.Items.FindByText("Select").Selected = true;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxEmpNo.Text == String.Empty)
                {
                    ValiddeptNo.Validate();
                    return;
                }
                int id = Convert.ToInt32(TextBoxEmpNo.Text);
                if (id < 1)
                {
                    RangeVaildatorDeptNo.Validate();
                    return;
                }
                employeeDataAcecss.Delete(id);
                lblstatus.Text = "Deleted Successfully!!";
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
            Loader();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                Employee employee = new Employee();
                employee.EmpNo = Convert.ToInt32(TextBoxEmpNo.Text);
                employee.EmpName = TextEmpName.Text;
                employee.DeptNo = Convert.ToInt32(DropDownDepartment.SelectedItem.Value);
                employee.Designation = TextDesignation.Text;
                employee.Salary = Convert.ToInt32(TextSalary.Text);

                Employee emp = employeeDataAcecss.Get(employee.EmpNo);
                if (emp != null)
                {
                    employeeDataAcecss.Update(employee.EmpNo, employee);
                    lblstatus.Text = "Update Successfully!!";
                }
                else
                {
                    employeeDataAcecss.Craete(employee);
                    lblstatus.Text = "Added Successfully!!";
                }
                    Loader();

                TextEmpName.Text = String.Empty;
                TextBoxEmpNo.Text = String.Empty;
                TextDesignation.Text = String.Empty;
                TextSalary.Text = String.Empty;
                DropDownDepartment.SelectedIndex = 0;
                //DropDownDepartment.Items.FindByText("Select").Selected = true;
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            TextEmpName.Text = String.Empty;
            TextBoxEmpNo.Text = String.Empty;
            TextDesignation.Text = String.Empty;
            TextSalary.Text = String.Empty;
            DropDownDepartment.SelectedIndex = 0;
            //DropDownDepartment.Items.FindByText("Select").Selected = true;
        }

        private void Loader()
        {
            try
            {


                gvDept.DataSource = employeeDataAcecss.Get();
                gvDept.DataBind();
            }
            catch(Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void TextBoxEmpNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxEmpNo.Text == String.Empty)
                {
                    ValiddeptNo.Validate();
                    return;
                }
                int id = Convert.ToInt32(TextBoxEmpNo.Text);
                if (id < 1)
                {
                    RangeVaildatorDeptNo.Validate();
                    return;
                }
                Employee dept = employeeDataAcecss.Get(id);
                if (dept != null)
                {
                    TextEmpName.Text = dept.EmpName;
                    TextDesignation.Text = dept.Designation;
                    TextSalary.Text = dept.Salary.ToString();

                    int deptId = dept.DeptNo;
                    DropDownDepartment.ClearSelection();
                    DropDownDepartment.Items.FindByValue(deptId.ToString()).Selected = true;
                    btnSave.Text = "Update";
                }
                else
                {

                    TextEmpName.Text = String.Empty;
                    //TextBoxEmpNo.Text = String.Empty;
                    TextDesignation.Text = String.Empty;
                    TextSalary.Text = String.Empty;
                    DropDownDepartment.SelectedIndex = 0;
                    btnSave.Text = "Save";
                }
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }
    }
}