using System;
using System.Data.SqlClient;
using System.Data;
using StaffManagement_WF_ADO.Utils;
using StaffManagement_WF_ADO.Entities;

namespace StaffManagement_WF_ADO.DAO
{
    public class StaffDAO
    {
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        public DataTable getAll()
        {
            try
            {
                cmd = new SqlCommand(Constants.STAFF_QUERY_GET_ALL, DBConnect.GetConnection());
                reader = cmd.ExecuteReader();
                DataTable res = new DataTable();
                res.Load(reader);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while retrieving staffs.", ex);
            }
            finally
            {
                if(cmd != null)
                {
                    cmd.Dispose();
                }

                if(reader != null)
                {
                    reader.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool save(Staff staff)
        {
            try
            {
                cmd = new SqlCommand(Constants.STAFF_QUERY_SAVE, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", staff.Name);
                cmd.Parameters.AddWithValue("@pr2", staff.Birthdate);
                cmd.Parameters.AddWithValue("@pr3", staff.Gender);
                cmd.Parameters.AddWithValue("@pr4", staff.Phonenumber);
                cmd.Parameters.AddWithValue("@pr5", staff.CoefSalary);
                cmd.Parameters.AddWithValue("@pr6", staff.DepartmentId);
                cmd.Parameters.AddWithValue("@pr7", staff.RoleId);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw new Exception("An error occured while saving staff.", ex);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool updateInfo(Staff staff)
        {
            try
            {
                cmd = new SqlCommand(Constants.STAFF_QUERY_UPDATE, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", staff.Id);
                cmd.Parameters.AddWithValue("@pr2", staff.Name);
                cmd.Parameters.AddWithValue("@pr3", staff.Birthdate);
                cmd.Parameters.AddWithValue("@pr4", staff.Gender);
                cmd.Parameters.AddWithValue("@pr5", staff.Phonenumber);
                cmd.Parameters.AddWithValue("@pr6", staff.CoefSalary);
                cmd.Parameters.AddWithValue("@pr7", staff.DepartmentId);
                cmd.Parameters.AddWithValue("@pr8", staff.RoleId);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while updating staff.", ex);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool delete(int staffId)
        {
            try
            {
                cmd = new SqlCommand(Constants.STAFF_QUERY_DELETE, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", staffId);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while deleting staff.", ex);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }
    }
}
