
namespace StaffManagement_WF_ADO
{
    partial class StaffManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grStaffInfo = new System.Windows.Forms.GroupBox();
            this.grFunctions = new System.Windows.Forms.GroupBox();
            this.grStaffs = new System.Windows.Forms.GroupBox();
            this.btnSaveStaffInfo = new System.Windows.Forms.Button();
            this.btnUpdateStaffInfo = new System.Windows.Forms.Button();
            this.btnDeleteStaffInfo = new System.Windows.Forms.Button();
            this.btnRefreshForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.txtStaffCoefSalary = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbStaffRole = new System.Windows.Forms.ComboBox();
            this.dgvStaffs = new System.Windows.Forms.DataGridView();
            this.dtpStaffBirthdate = new System.Windows.Forms.DateTimePicker();
            this.grStaffInfo.SuspendLayout();
            this.grFunctions.SuspendLayout();
            this.grStaffs.SuspendLayout();
            this.pnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // grStaffInfo
            // 
            this.grStaffInfo.Controls.Add(this.dtpStaffBirthdate);
            this.grStaffInfo.Controls.Add(this.cmbStaffRole);
            this.grStaffInfo.Controls.Add(this.cmbDepartment);
            this.grStaffInfo.Controls.Add(this.txtStaffCoefSalary);
            this.grStaffInfo.Controls.Add(this.txtStaffPhone);
            this.grStaffInfo.Controls.Add(this.txtStaffName);
            this.grStaffInfo.Controls.Add(this.txtStaffId);
            this.grStaffInfo.Controls.Add(this.pnlGender);
            this.grStaffInfo.Controls.Add(this.label4);
            this.grStaffInfo.Controls.Add(this.label5);
            this.grStaffInfo.Controls.Add(this.label6);
            this.grStaffInfo.Controls.Add(this.label7);
            this.grStaffInfo.Controls.Add(this.label8);
            this.grStaffInfo.Controls.Add(this.label3);
            this.grStaffInfo.Controls.Add(this.label2);
            this.grStaffInfo.Controls.Add(this.label1);
            this.grStaffInfo.Location = new System.Drawing.Point(12, 12);
            this.grStaffInfo.Name = "grStaffInfo";
            this.grStaffInfo.Size = new System.Drawing.Size(569, 170);
            this.grStaffInfo.TabIndex = 0;
            this.grStaffInfo.TabStop = false;
            this.grStaffInfo.Text = "Thông tin nhân viên";
            // 
            // grFunctions
            // 
            this.grFunctions.Controls.Add(this.btnRefreshForm);
            this.grFunctions.Controls.Add(this.btnDeleteStaffInfo);
            this.grFunctions.Controls.Add(this.btnUpdateStaffInfo);
            this.grFunctions.Controls.Add(this.btnSaveStaffInfo);
            this.grFunctions.Location = new System.Drawing.Point(587, 13);
            this.grFunctions.Name = "grFunctions";
            this.grFunctions.Size = new System.Drawing.Size(134, 169);
            this.grFunctions.TabIndex = 1;
            this.grFunctions.TabStop = false;
            this.grFunctions.Text = "Chức năng";
            // 
            // grStaffs
            // 
            this.grStaffs.Controls.Add(this.dgvStaffs);
            this.grStaffs.Location = new System.Drawing.Point(12, 188);
            this.grStaffs.Name = "grStaffs";
            this.grStaffs.Size = new System.Drawing.Size(709, 189);
            this.grStaffs.TabIndex = 2;
            this.grStaffs.TabStop = false;
            this.grStaffs.Text = "Danh sách nhân viên";
            // 
            // btnSaveStaffInfo
            // 
            this.btnSaveStaffInfo.Location = new System.Drawing.Point(6, 25);
            this.btnSaveStaffInfo.Name = "btnSaveStaffInfo";
            this.btnSaveStaffInfo.Size = new System.Drawing.Size(122, 30);
            this.btnSaveStaffInfo.TabIndex = 0;
            this.btnSaveStaffInfo.Text = "Thêm";
            this.btnSaveStaffInfo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStaffInfo
            // 
            this.btnUpdateStaffInfo.Location = new System.Drawing.Point(6, 61);
            this.btnUpdateStaffInfo.Name = "btnUpdateStaffInfo";
            this.btnUpdateStaffInfo.Size = new System.Drawing.Size(122, 30);
            this.btnUpdateStaffInfo.TabIndex = 1;
            this.btnUpdateStaffInfo.Text = "Sửa";
            this.btnUpdateStaffInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaffInfo
            // 
            this.btnDeleteStaffInfo.Location = new System.Drawing.Point(6, 97);
            this.btnDeleteStaffInfo.Name = "btnDeleteStaffInfo";
            this.btnDeleteStaffInfo.Size = new System.Drawing.Size(122, 30);
            this.btnDeleteStaffInfo.TabIndex = 2;
            this.btnDeleteStaffInfo.Text = "Xoá";
            this.btnDeleteStaffInfo.UseVisualStyleBackColor = true;
            // 
            // btnRefreshForm
            // 
            this.btnRefreshForm.Location = new System.Drawing.Point(6, 133);
            this.btnRefreshForm.Name = "btnRefreshForm";
            this.btnRefreshForm.Size = new System.Drawing.Size(122, 30);
            this.btnRefreshForm.TabIndex = 3;
            this.btnRefreshForm.Text = "Làm mới";
            this.btnRefreshForm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(297, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chức vụ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(297, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phòng ban";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(297, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hệ số lương";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(297, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số ĐT";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdFemale);
            this.pnlGender.Controls.Add(this.rdMale);
            this.pnlGender.Location = new System.Drawing.Point(120, 134);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(160, 30);
            this.pnlGender.TabIndex = 9;
            // 
            // rdMale
            // 
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(18, 3);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(64, 24);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.Location = new System.Drawing.Point(88, 3);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(64, 24);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Enabled = false;
            this.txtStaffId.Location = new System.Drawing.Point(120, 32);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(160, 26);
            this.txtStaffId.TabIndex = 10;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(120, 66);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(160, 26);
            this.txtStaffName.TabIndex = 11;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(400, 32);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(160, 26);
            this.txtStaffPhone.TabIndex = 13;
            // 
            // txtStaffCoefSalary
            // 
            this.txtStaffCoefSalary.Location = new System.Drawing.Point(400, 66);
            this.txtStaffCoefSalary.Name = "txtStaffCoefSalary";
            this.txtStaffCoefSalary.Size = new System.Drawing.Size(160, 26);
            this.txtStaffCoefSalary.TabIndex = 14;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(400, 100);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(160, 26);
            this.cmbDepartment.TabIndex = 15;
            // 
            // cmbStaffRole
            // 
            this.cmbStaffRole.FormattingEnabled = true;
            this.cmbStaffRole.Location = new System.Drawing.Point(400, 134);
            this.cmbStaffRole.Name = "cmbStaffRole";
            this.cmbStaffRole.Size = new System.Drawing.Size(160, 26);
            this.cmbStaffRole.TabIndex = 16;
            // 
            // dgvStaffs
            // 
            this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffs.Location = new System.Drawing.Point(6, 25);
            this.dgvStaffs.Name = "dgvStaffs";
            this.dgvStaffs.Size = new System.Drawing.Size(697, 158);
            this.dgvStaffs.TabIndex = 0;
            // 
            // dtpStaffBirthdate
            // 
            this.dtpStaffBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStaffBirthdate.Location = new System.Drawing.Point(120, 100);
            this.dtpStaffBirthdate.Name = "dtpStaffBirthdate";
            this.dtpStaffBirthdate.Size = new System.Drawing.Size(160, 26);
            this.dtpStaffBirthdate.TabIndex = 17;
            // 
            // StaffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 389);
            this.Controls.Add(this.grStaffs);
            this.Controls.Add(this.grFunctions);
            this.Controls.Add(this.grStaffInfo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffManagementForm";
            this.Text = "Quản lý nhân viên";
            this.grStaffInfo.ResumeLayout(false);
            this.grStaffInfo.PerformLayout();
            this.grFunctions.ResumeLayout(false);
            this.grStaffs.ResumeLayout(false);
            this.pnlGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grStaffInfo;
        private System.Windows.Forms.ComboBox cmbStaffRole;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtStaffCoefSalary;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grFunctions;
        private System.Windows.Forms.Button btnRefreshForm;
        private System.Windows.Forms.Button btnDeleteStaffInfo;
        private System.Windows.Forms.Button btnUpdateStaffInfo;
        private System.Windows.Forms.Button btnSaveStaffInfo;
        private System.Windows.Forms.GroupBox grStaffs;
        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.DateTimePicker dtpStaffBirthdate;
    }
}

