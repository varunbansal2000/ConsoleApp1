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
    public partial class Department25July : System.Web.UI.Page
    {
        IDataAccess<Department,int> departmentDataAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            departmentDataAccess = new DepartmentDataAccess();
            if(!IsPostBack)
            {
                Loader();
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int deptNo2 = Convert.ToInt32(deptNo.Text);
                Department newD = new Department
                {
                    DeptNo = deptNo2,
                    DeptName = Convert.ToString(deptName.Text),
                    Location = location.Text,
                    Capacity = Convert.ToInt32(capacity.Text)
                };
                Department exist = departmentDataAccess.Get(deptNo2);
                if (exist != null)
                {
                    departmentDataAccess.Update(deptNo2, newD);
                    lblstatus.Text = "Update Successfully!!";

                }

                else
                {
                    departmentDataAccess.Craete(newD);
                    lblstatus.Text = "Added Successfully!!";
                }
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }

            deptNo.Text = String.Empty;
            deptName.Text = String.Empty;
            location.Text = String.Empty;
            capacity.Text = String.Empty;
            Loader();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            deptNo.Text = String.Empty;
            deptName.Text = String.Empty;
            location.Text = String.Empty;
            capacity.Text = String.Empty;
            
        }

        protected void deptNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (deptNo.Text == String.Empty)
                {
                    ValiddeptNo.Validate();
                    return;
                }
                int id = Convert.ToInt32(deptNo.Text);
                if (id < 1)
                {
                    RangeVaildatorDeptNo.Validate();
                    return;
                }
                Department dept = departmentDataAccess.Get(id);
                if (dept != null)
                {
                    deptName.Text = dept.DeptName;
                    location.Text = dept.Location;
                    capacity.Text = dept.Capacity.ToString();

                    btnSave.Text = "Update";
                }
                else
                {
                    deptName.Text = String.Empty;
                    location.Text = String.Empty;
                    capacity.Text = String.Empty;

                    btnSave.Text = "Save";
                }
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        private void Loader()
        {
            try
            {
                gvDept.DataSource = departmentDataAccess.Get();
                gvDept.DataBind();
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptNo.Text == String.Empty)
                {
                    ValiddeptNo.Validate();
                    return;
                }
                int id = Convert.ToInt32(deptNo.Text);
                if (id < 1)
                {
                    RangeVaildatorDeptNo.Validate();
                    return;
                }
                departmentDataAccess.Delete(id);
                lblstatus.Text = "Deleted Successfully!!";
            }
            catch(Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
            Loader();
            
        }
    }
}