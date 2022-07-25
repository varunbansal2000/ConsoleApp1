using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
using System.Data.SqlClient;
namespace Application.DataAccess
{
    public class EmployeeDataAccess : IDataAccess<Employee, int>
    {
        SqlConnection Conn;
        SqlCommand Cmd;

        public EmployeeDataAccess()
        {
            Conn = new SqlConnection("Data Source=IN-8QVTJM3;Initial Catalog=UCompany;Integrated Security=SSPI");
        }
        Employee IDataAccess<Employee, int>.Craete(Employee entity)
        {
            Employee employee = new Employee();
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Insert into Employee Values({entity.EmpNo}, '{entity.EmpName}', '{entity.Designation}', {entity.Salary},{entity.DeptNo})";
                Cmd.ExecuteNonQuery();
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

        Employee IDataAccess<Employee, int>.Delete(int id)
        {
            Employee emp = null;
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Delete from Employee where empNo={id}";
                int result = Cmd.ExecuteNonQuery();
                Conn.Close();
                if (result != 0)
                {
                    // create an empty Department object 
                    emp = new Employee();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return emp;
        }

        IEnumerable<Employee> IDataAccess<Employee, int>.Get()
        {
            List<Employee> employees= new List<Employee>();
            try
            {
                // 1. Connecto to Database by opening it
                Conn.Open();
                // 2. Create Command Object
                Cmd = new SqlCommand();
                // 2.a. Pass the Connection top Command so that Command Know to which Database
                // the query will be fired
                Cmd.Connection = Conn;
                // 3. Set the Command Type
                Cmd.CommandType = System.Data.CommandType.Text;
                // 4. Set the Command Text
                Cmd.CommandText = "Select * from Employee";
                // 5. Execute the Command
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 6. Get Result by reading data from Reader object and put it in List<Department>
                // 6.a. Using While loop to start reading records from Reader from first record and so till end
                while (Reader.Read())
                {
                    // 6.b. Put each Row Value into the Department object 
                    employees.Add(new Employee()
                    {
                        EmpNo = Convert.ToInt32(Reader["EmpNo"]),
                        DeptNo = Convert.ToInt32(Reader["DeptNo"]),
                        EmpName = Reader["empName"].ToString(),
                        Designation = Reader["Designation"].ToString(),
                        Salary = Convert.ToInt32(Reader["Salary"])
                    });
                }
                // 6.c. Close the Reader so that tthe Cursor will be closed
                Reader.Close();


            }
            catch (Exception ex)
            {
                // 7. Throw exception, so that the caller app will kno about the error
                throw ex;
            }
            finally
            {
                // 8. If the try failed then catch will be executed which will throw the error
                // so Close the Connection, please do not keep it open
                Conn.Close();
            }
            return employees;
        }

        Employee IDataAccess<Employee, int>.Get(int id)
        {
            Employee employee = null;
            try
            {
                // 1. Connecto to Database by opening it
                Conn.Open();
                // 2. Create Command Object
                Cmd = new SqlCommand();
                // 2.a. Pass the Connection top Command so that Command Know to which Database
                // the query will be fired
                Cmd.Connection = Conn;
                // 3. Set the Command Type
                Cmd.CommandType = System.Data.CommandType.Text;
                // 4. Set the Command Text
                Cmd.CommandText = $"Select * from Employee where empNo = {id}";
                // 5. Execute the Command
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 6. Get Result by reading data from Reader object and put it in List<Department>
                // 6.a. Using While loop to start reading records from Reader from first record and so till end
                while (Reader.Read())
                {
                    employee = new Employee()
                    {
                        DeptNo = Convert.ToInt32(Reader["DeptNo"]),
                        EmpName = Reader["empName"].ToString(),
                        Designation = Reader["Designation"].ToString(),
                        Salary = Convert.ToInt32(Reader["salary"]),
                        EmpNo = Convert.ToInt32(Reader["empNo"])
                    };
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { Conn.Close(); }
            return employee;
        }

        Employee IDataAccess<Employee, int>.Update(int id, Employee entity)
        {
            Employee employee = new Employee();
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"update Employee set empNo = {entity.EmpNo}, empName = '{entity.EmpName}', designation =  '{entity.Designation}', salary  = {entity.Salary},deptNo = {entity.DeptNo} where empNo = {id}";
                Cmd.ExecuteNonQuery();
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
}
