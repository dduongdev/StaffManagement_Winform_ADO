using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement_WF_ADO.Utils
{
    public class Constants
    {
        #region SQL commands for staff
        public static readonly string STAFF_QUERY_GET_ALL = @"SELECT * FROM DSNV";
        public static readonly string STAFF_QUERY_SAVE = @"INSERT INTO DSNV(HoTen, NgaySinh, GioiTinh, SoDT, HeSoLuong, MaPhong, MaChucVu)
                                                            VALUES (@pr1, @pr2, @pr3, @pr4, @pr5, @pr6, @pr7)";
        public static readonly string STAFF_QUERY_UPDATE = @"UPDATE DSNV
                                                            SET HoTen = @pr2, NgaySinh = @pr3, GioiTinh = @pr4, SoDT = @pr5, HeSoLuong = @pr6, MaPhong = @pr7, MaChucVu = @pr8
                                                            WHERE MaNV = @pr1";
        public static readonly string STAFF_QUERY_DELETE = @"DELETE FROM DSNV WHERE MaNV = @pr1";
        #endregion

        #region SQL commands for deparment
        public static readonly string DEPARTMENT_QUERY_GET_ALL = "SELECT * FROM DMPHONG";
        #endregion

        #region SQL commands for role
        public static readonly string ROLE_QUERY_GET_ALL = "SELECT * FROM CHUCVU";
        #endregion

        #region regex
        public static readonly string REGEX_PHONE = @"^0\d{9,10}$";
        #endregion
    }
}
