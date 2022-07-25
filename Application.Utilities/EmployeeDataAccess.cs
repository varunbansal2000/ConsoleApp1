using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application2.Entities;
using System.Data;
using System.Data.SqlClient;
using Application2.Utilities;

public class EmployeeDataAccess : IDataAccess<Employee, int>
{
    SqlConnection Conn;
    SqlDataAdapter EmpDept;
    DataSet Ds;
    public EmployeeDataAccess()
    {
        Conn = new SqlConnection("Data Source=IN-8QVTJM3;Initial Catalog=UCompany;Integrated Security=SSPI");

        Ds = new DataSet();
        EmpDept = new SqlDataAdapter("Select * from Employee", Conn);
        EmpDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        FillData();
    }
    private void FillData()
    {
        // Fill Data into the DataSet
        EmpDept.Fill(Ds, "Employee");
        //AdEmp.Fill(Ds, "Employee");
        // See Schema and Data from DataSet in Xml
        //Console.WriteLine($"Schema = {Ds.GetXmlSchema()}");
        //Console.WriteLine($"Original Data = {Ds.GetXml()}");
    }
    Employee IDataAccess<Employee, int>.Craete(Employee entity)
    {
        Employee employee = new Employee();
        try
        {
            Conn.Open();
            // 1. Create a New Row Object based in Table in the DataSet
            DataRow DrNew = Ds.Tables["Employee"].NewRow();
            // 2. Specify the Column Values

            DrNew["EmpNo"] = entity.EmpNo;
            DrNew["EmpName"] = entity.EmpName;
            DrNew["Salary"] = entity.Salary;
            DrNew["Designation"] = entity.Designation;
            DrNew["DeptNo"] = entity.DeptNo;
            // 3. Add this Record in Department Table of DataSet
            Ds.Tables["Employee"].Rows.Add(DrNew);
            // 4. Create a Command Builder
            SqlCommandBuilder builder = new SqlCommandBuilder(EmpDept);
            // 5. Update DataBase
            EmpDept.Update(Ds, "Employee");


            //Cmd = new SqlCommand();
            //Cmd.Connection = Conn;
            //Cmd.CommandType = System.Data.CommandType.Text;
            //Cmd.CommandText = $"Insert into Department Values({entity.DeptNo}, '{entity.DeptName}', '{entity.Location}', {entity.Capacity})";
            //Cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Conn.Close();
        }
        return employee;
    }

   

    IEnumerable<Employee> IDataAccess<Employee, int>.Get()
    {
        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < Ds.Tables["Employee"].Rows.Count; i++)
        {
            int id = Convert.ToInt32(Ds.Tables["Employee"].Rows[i]["EmpNo"]);
            Employee d = new Employee();
            DataTable dt = Ds.Tables["Employee"];
            d.EmpNo = Convert.ToInt32(dt.Rows.Find(id)["EmpNo"]);
            d.EmpName = dt.Rows.Find(id)["EmpName"].ToString();
            d.Designation = dt.Rows.Find(id)["Designation"].ToString();
            d.Salary = Convert.ToInt32(dt.Rows.Find(id)["Salary"]);
            d.DeptNo= Convert.ToInt32(dt.Rows.Find(id)["DeptNo"]);
            employees.Add(d);
        }

        return employees;
    }

    Employee IDataAccess<Employee, int>.Get(int id)
    {
        Employee d = new Employee();
        DataTable dt = Ds.Tables["Employee"];
        d.EmpNo = Convert.ToInt32(dt.Rows.Find(id)["EmpNo"]);
        d.EmpName = dt.Rows.Find(id)["EmpName"].ToString();
        d.Designation = dt.Rows.Find(id)["Designation"].ToString();
        d.Salary = Convert.ToInt32(dt.Rows.Find(id)["Salary"]);
        d.DeptNo = Convert.ToInt32(dt.Rows.Find(id)["DeptNo"]);
        return d;
    }

    Employee IDataAccess<Employee, int>.Update(int id, Employee entity)
    {
        DataRow DrFind = Ds.Tables["Employee"].Rows.Find(id);
        DrFind["DeptName"] = entity.EmpName;
        DrFind["Designation"] = entity.Designation;
        DrFind["Salary"] = entity.Salary;
        DrFind["DeptNo"] = entity.DeptNo;
        SqlCommandBuilder builder = new SqlCommandBuilder(EmpDept);
        // 4. Update DataBase
        EmpDept.Update(Ds, "Department");

        Employee d = new Employee();
        DataTable dt = Ds.Tables["Employee"];
        d.EmpNo = Convert.ToInt32(dt.Rows.Find(id)["EmpNo"]);
        d.EmpName = dt.Rows.Find(id)["EmpName"].ToString();
        d.Designation = dt.Rows.Find(id)["Designation"].ToString();
        d.Salary = Convert.ToInt32(dt.Rows.Find(id)["Salary"]);
        d.DeptNo = Convert.ToInt32(dt.Rows.Find(id)["DeptNo"]);
        return d;
    }

    Employee IDataAccess<Employee, int>.Delete(int id)
    {
        Employee employee= null;
        try
        {
            Conn.Open();

            // 1. Find Record based on the Primary Key
            DataRow DrFind = Ds.Tables["Employee"].Rows.Find(id);
            // 2. Delete means Row will be marked for Deletion
            DrFind.Delete();
            //Console.WriteLine($"Data After Delete from the DataSet = {Ds.GetXml()}");

            // 3. Create a Command Builder
            SqlCommandBuilder builder = new SqlCommandBuilder(EmpDept);
            // 4. Update DataBase
            EmpDept.Update(Ds, "Employee");



            //Cmd = new SqlCommand();
            //Cmd.Connection = Conn;
            //Cmd.CommandType = System.Data.CommandType.Text;
            //Cmd.CommandText = $"Delete from Department where DeptNo={id}";
            //int result = Cmd.ExecuteNonQuery();
            //Conn.Close();
            //if (result != 0)
            //{
            //    // create an empty Department object 
            //    department = new Department();
            //}
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Conn.Close();
        }
        return employee;
    }
}
