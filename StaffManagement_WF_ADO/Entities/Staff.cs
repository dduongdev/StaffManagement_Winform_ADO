using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagement_WF_ADO.Entities
{
    public class Staff
    {
        private int _id;
        private string _name;
        private DateTime _birthdate;
        private bool _gender;
        private string _phonenumber;
        private double _coefSalary;
        private string _departmentId;
        private string _roleId;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Birthdate { get => _birthdate; set => _birthdate = value; }
        public bool Gender { get => _gender; set => _gender = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public double CoefSalary { get => _coefSalary; set => _coefSalary = value; }
        public string DepartmentId { get => _departmentId; set => _departmentId = value; }
        public string RoleId { get => _roleId; set => _roleId = value; }

        public Staff() { }

        public Staff(int id, string name, DateTime birthdate, bool gender, string phonenumber, 
            double coefSalary, string departmentId, string roleId)
        {
            this.Id = id;
            this.Name = name;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.Phonenumber = phonenumber;
            this.CoefSalary = coefSalary;
            this.DepartmentId = departmentId;
            this.RoleId = roleId;
        }
    }
}
