using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffManagement_WF_ADO.DAO;
using StaffManagement_WF_ADO.Entities;
using StaffManagement_WF_ADO.Utils;

namespace StaffManagement_WF_ADO
{
    public partial class StaffManagementForm : Form
    {
        private readonly StaffDAO staffDAO = new StaffDAO();
        private readonly DepartmentDAO departmentDAO = new DepartmentDAO();
        private readonly RoleDAO roleDAO = new RoleDAO();

        public StaffManagementForm()
        {
            InitializeComponent();
            this.Load += StaffManagementForm_Load;
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            btnRefreshForm.Click += BtnRefreshForm_Click;
            btnSaveStaffInfo.Click += BtnSaveStaffInfo_Click;
            btnUpdateStaffInfo.Click += BtnUpdateStaffInfo_Click;
            dgvStaffs.SelectionChanged += DgvStaffs_SelectionChanged;
            btnDeleteStaffInfo.Click += BtnDeleteStaffInfo_Click;

            loadStaffs();
            loadDepartments();
            loadRoles();
        }

        private void BtnDeleteStaffInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffId.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xoá.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (staffDAO.delete(int.Parse(txtStaffId.Text)))
                {
                    MessageBox.Show("Xoá nhân viên thành công!", "Quản lý nhân viên");
                }
                else
                {
                    MessageBox.Show("Xoá nhân viên không thành công!", "Quản lý nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý nhân viên");
            }
        }

        private void DgvStaffs_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvStaffs.CurrentCell != null)
            {
                DataGridViewRow currentRow = dgvStaffs.CurrentRow;
                txtStaffId.Text = currentRow.Cells[0].Value.ToString();
                txtStaffName.Text = currentRow.Cells[1].Value.ToString();
                dtpStaffBirthdate.Text = currentRow.Cells[2].Value.ToString();
                if (currentRow.Cells[3].Value.ToString() == "True")
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                txtStaffPhone.Text = currentRow.Cells[4].Value.ToString();
                txtStaffCoefSalary.Text = currentRow.Cells[5].Value.ToString();
                cmbDepartment.SelectedValue = currentRow.Cells[6].Value.ToString();
                cmbStaffRole.SelectedValue = currentRow.Cells[7].Value.ToString();
            }
        }

        private void BtnUpdateStaffInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffId.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Validator.IsPhone(txtStaffPhone.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Validator.IsNumeric(txtStaffCoefSalary.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số lương là giá trị số.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (staffDAO.updateInfo(initStaff()))
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Quản lý nhân viên");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên không thành công!", "Quản lý nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý nhân viên");
            }
        }

        private void BtnSaveStaffInfo_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPhone(txtStaffPhone.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Validator.IsNumeric(txtStaffCoefSalary.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số lương là giá trị số.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng ban.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(cmbStaffRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.", "Quản lý nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (staffDAO.save(initStaff()))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Quản lý nhân viên");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!", "Quản lý nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản lý nhân viên");
            }
        }

        private void BtnRefreshForm_Click(object sender, EventArgs e)
        {
            loadStaffs();

            dgvStaffs.CurrentCell = null;

            txtStaffId.Clear();
            txtStaffName.Clear();
            dtpStaffBirthdate.Value = DateTime.Now;
            rdMale.Checked = true;
            txtStaffPhone.Clear();
            txtStaffCoefSalary.Clear();
            txtStaffId.Focus();
        }

        #region Load data functions
        private void loadStaffs()
        {
            try
            {
                dgvStaffs.DataSource = staffDAO.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDepartments()
        {
            try
            {
                cmbDepartment.DataSource = departmentDAO.getAll();
                cmbDepartment.DisplayMember = "TenPhong";
                cmbDepartment.ValueMember = "MaPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadRoles()
        {
            try
            {
                cmbStaffRole.DataSource = roleDAO.getAll();
                cmbStaffRole.DisplayMember = "TenChucVu";
                cmbStaffRole.ValueMember = "MaChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region function
        private Staff initStaff()
        {
            Staff staff = new Staff();
            staff.Id = int.Parse(string.IsNullOrEmpty(txtStaffId.Text) ? "0" : txtStaffId.Text);
            staff.Name = txtStaffName.Text;
            staff.Birthdate = dtpStaffBirthdate.Value;
            staff.Gender = rdMale.Checked == true;
            staff.Phonenumber = txtStaffPhone.Text;

            string coefSalaryInput = txtStaffCoefSalary.Text.Replace('.', ',');
            double coefSalary = double.Parse(coefSalaryInput);
            staff.CoefSalary = Math.Round(coefSalary, 2);
            staff.DepartmentId = cmbDepartment.SelectedValue.ToString();
            staff.RoleId = cmbStaffRole.SelectedValue.ToString();

            return staff;
        }
        #endregion
    }
}
