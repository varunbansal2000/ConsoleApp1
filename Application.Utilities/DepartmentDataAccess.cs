using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application2.Entities;
using System.Data.SqlClient;
using System.Data;
namespace Application2.Utilities
{
    public class DepartmentDataAccess : IDataAccess<Department, int>
    {
        SqlConnection Conn;
        SqlDataAdapter AdDept;
        DataSet Ds;
        public DepartmentDataAccess()
        {
            Conn = new SqlConnection("Data Source=IN-8QVTJM3;Initial Catalog=UCompany;Integrated Security=SSPI");

            Ds = new DataSet();
            AdDept = new SqlDataAdapter("Select * from Department", Conn);
            AdDept.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            FillData();
        }
        private void FillData()
        {
            // Fill Data into the DataSet
            AdDept.Fill(Ds, "Department");
            //AdEmp.Fill(Ds, "Employee");
            // See Schema and Data from DataSet in Xml
            //Console.WriteLine($"Schema = {Ds.GetXmlSchema()}");
            //Console.WriteLine($"Original Data = {Ds.GetXml()}");
        }

        Department IDataAccess<Department, int>.Craete(Department entity)
        {
            Department department = new Department();
            try
            {
                Conn.Open();
                // 1. Create a New Row Object based in Table in the DataSet
                DataRow DrNew = Ds.Tables["Department"].NewRow();
                // 2. Specify the Column Values

                DrNew["DeptNo"] = entity.DeptNo;
                DrNew["DeptName"] = entity.DeptName;
                DrNew["Location"] = entity.Location;
                DrNew["Capacity"] = entity.Capacity;
                // 3. Add this Record in Department Table of DataSet
                Ds.Tables["Department"].Rows.Add(DrNew);
                // 4. Create a Command Builder
                SqlCommandBuilder builder = new SqlCommandBuilder(AdDept);
                // 5. Update DataBase
                AdDept.Update(Ds, "Department");


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
            return department;
        }

        Department IDataAccess<Department, int>.Delete(int id)
        {
            Department department = null;
            try
            {
                Conn.Open();

                // 1. Find Record based on the Primary Key
                DataRow DrFind = Ds.Tables["Department"].Rows.Find(id);
                // 2. Delete means Row will be marked for Deletion
                DrFind.Delete();
                //Console.WriteLine($"Data After Delete from the DataSet = {Ds.GetXml()}");

                // 3. Create a Command Builder
                SqlCommandBuilder builder = new SqlCommandBuilder(AdDept);
                // 4. Update DataBase
                AdDept.Update(Ds, "Department");



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
            return department;
        }

        IEnumerable<Department> IDataAccess<Department, int>.Get()
        {
            List<Department> departments = new List<Department>();
            for (int i= 0;i< Ds.Tables["Department"].Rows.Count;i++)
            {
                int id = Convert.ToInt32(Ds.Tables["Department"].Rows[i]["DeptNo"]);
                Department d = new Department();
                DataTable dt = Ds.Tables["Department"];
                d.DeptNo = Convert.ToInt32(dt.Rows.Find(id)["DeptNo"]);
                d.DeptName = dt.Rows.Find(id)["DeptName"].ToString();
                d.Location = dt.Rows.Find(id)["location"].ToString();
                d.Capacity = Convert.ToInt32(dt.Rows.Find(id)["capacity"]);
                departments.Add(d);
            }
 
            return departments;
        }

        Department IDataAccess<Department, int>.Get(int id)
        {
            Department d = new Department();
            DataTable dt = Ds.Tables["Department"];
            d.DeptNo = Convert.ToInt32(dt.Rows.Find(id)["DeptNo"]);
            d.DeptName = dt.Rows.Find(id)["DeptName"].ToString();
            d.Location = dt.Rows.Find(id)["location"].ToString();
            d.Capacity = Convert.ToInt32(dt.Rows.Find(id)["capacity"]);
            return d;
        }

        Department IDataAccess<Department, int>.Update(int id, Department entity)
        {
            DataRow DrFind = Ds.Tables["Department"].Rows.Find(id);
            DrFind["DeptName"] = entity.DeptName;
            DrFind["Location"] = entity.Location;
            DrFind["Capacity"] = entity.Capacity;
            SqlCommandBuilder builder = new SqlCommandBuilder(AdDept);
            // 4. Update DataBase
            AdDept.Update(Ds, "Department");

            Department d = new Department();
            DataTable dt = Ds.Tables["Department"];
            d.DeptNo = Convert.ToInt32(dt.Rows.Find(id)["DeptNo"]);
            d.DeptName = dt.Rows.Find(id)["DeptName"].ToString();
            d.Location = dt.Rows.Find(id)["location"].ToString();
            d.Capacity = Convert.ToInt32(dt.Rows.Find(id)["capacity"]);
            return d;
        }
    }
}
