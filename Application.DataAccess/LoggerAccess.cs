using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;

namespace Application.DataAccess
{
    public class LoggerAccess
    {
        SqlConnection Conn;
        SqlCommand Cmd;

        public LoggerAccess()
        {
            Conn = new SqlConnection("Data Source=IN-8QVTJM3;Initial Catalog=UCompany;Integrated Security=SSPI");
        }

        public void AddLog(Logger log)
        {
            try
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = $"Insert into logger (ControllerName,ActionName,ExceptionDetails) values ('{log.ControllerName}', '{log.ActionName}', '{log.ExceptionDetails}')";
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
        }

        public IEnumerable<Logger> GetLoggers()
        {
            List<Logger> loggers = new List<Logger>();
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
                Cmd.CommandText = "Select * from logger";
                // 5. Execute the Command
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 6. Get Result by reading data from Reader object and put it in List<Department>
                // 6.a. Using While loop to start reading records from Reader from first record and so till end
                while (Reader.Read())
                {
                    // 6.b. Put each Row Value into the Department object 
                    loggers.Add(new Logger()
                    {
                        LogID = Convert.ToInt32(Reader["LogID"]),
                        ActionName = Reader["ActionName"].ToString(),
                        ControllerName = Reader["ControllerName"].ToString(),
                        LogDate = Reader["LogDate"].ToString(),
                        ExceptionDetails = Reader["ExceptionDetails"].ToString()
                    });
                }
                // 6.c. Close the Reader so that tthe Cursor will be closed
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return loggers;
        }
    }
}
