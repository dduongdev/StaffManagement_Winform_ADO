using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StaffManagement_WF_ADO.Utils;

namespace StaffManagement_WF_ADO.DAO
{
    public class DepartmentDAO
    {
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        public DataTable getAll()
        {
            try
            {
                cmd = new SqlCommand(Constants.DEPARTMENT_QUERY_GET_ALL, DBConnect.GetConnection());
                reader = cmd.ExecuteReader();
                DataTable res = new DataTable();
                res.Load(reader);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while retrieving departments.", ex);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (reader != null)
                {
                    reader.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }
    }
}
