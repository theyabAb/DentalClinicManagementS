using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Database;
using WindowsFormsApp4.Forms.Dashboard;

namespace WindowsFormsApp4.Forms.Doctors
{
    public partial class DoctorsForm : Form
    {
        int selectedDoctorID = 0;
        public DoctorsForm()
        {
            InitializeComponent();
        }



        private void panelLeft_doctor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if (selectedDoctorID == 0)
            {
                MessageBox.Show("اختر دكتور أولاً من الجدول!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // تأكيد الحذف مع إظهار ID (أو يمكنك إضافة اسم الدكتور)
            var confirm = MessageBox.Show("هل تريد حذف هذا الدكتور؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = DB.GetConnection())
                {
                    con.Open();

                    // فحص ارتباط الدكتور بمواعيد
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Appointments WHERE DoctorID = @id", con))
                    {
                        checkCmd.Parameters.Add("@id", SqlDbType.Int).Value = selectedDoctorID;
                        int related = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (related > 0)
                        {
                            MessageBox.Show("لا يمكن حذف الدكتور لأنه مرتبط بمواعيد. يرجى حذف أو نقل المواعيد أولاً.", "تعذر الحذف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // تنفيذ الحذف
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Doctors WHERE DoctorID = @id", con))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = selectedDoctorID;
                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            MessageBox.Show("لم يتم العثور على الدكتور للحذف.", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                // تحديث الواجهة وإعادة تعيين الحالة
                LoadDoctors();
                selectedDoctorID = 0;
                MessageBox.Show("تم حذف الدكتور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // هنا يمكن تسجيل الخطأ في لوج بدلاً من عرض الرسالة فقط
            }
        }
          

       
        
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
       
            if (selectedDoctorID == 0)
            {
                MessageBox.Show("اختر دكتور أولاً من الجدول!", "تنبيه");
                return;
            }

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Doctors SET FullName=@n, Specialty=@s, Phone=@p, Gender=@g, Address=@a WHERE DoctorID=@id", con);

                cmd.Parameters.AddWithValue("@n", txtDoctorName.Text);
                cmd.Parameters.AddWithValue("@s", txtSpecialization.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@g", cmbGenderd.Text);
                cmd.Parameters.AddWithValue("@a", txtAddres.Text);
                cmd.Parameters.AddWithValue("@id", selectedDoctorID);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadDoctors();
            MessageBox.Show("تم تعديل بيانات الدكتور!");
            ClearInputs();







        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        
            if (txtDoctorName.Text == "" || txtSpecialization.Text == "" || txtPhone.Text == "" || cmbGenderd.Text == "")
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول!", "تنبيه");
                return;
            }

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Doctors (FullName, Specialty, Phone, Gender, Address, CreatedAt) VALUES (@n,@s,@p,@g,@a,GETDATE())", con);

                cmd.Parameters.AddWithValue("@n", txtDoctorName.Text);
                cmd.Parameters.AddWithValue("@s", txtSpecialization.Text);
                cmd.Parameters.AddWithValue("@p", txtPhone.Text);
                cmd.Parameters.AddWithValue("@g", cmbGenderd.Text);
                cmd.Parameters.AddWithValue("@a", txtAddres.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadDoctors();
            MessageBox.Show("تمت إضافة الدكتور بنجاح!");
            ClearInputs();


        }


        

        private void txtAddres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenderd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSpecialization_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void lastname_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
          
            LoadDoctors();
        }
        

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDoctors(txtSearch.Text.Trim());
        }

        private void SearchDoctors(string keyword)
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Doctors WHERE " +
                    "FullName LIKE @k OR " +
                    "Specialty LIKE @k OR " +
                    "Phone LIKE @k OR " +
                    "Gender LIKE @k OR " +
                    "Address LIKE @k", con);

                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dgvDoctors.Rows.Clear();
                while (dr.Read())
                {
                    dgvDoctors.Rows.Add(
                        dr["FullName"].ToString(),
                        dr["Specialty"].ToString(),
                        dr["Phone"].ToString(),
                        dr["Gender"].ToString(),
                        dr["Address"].ToString()
                    );
                }
                dr.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
          
       
            SearchDoctors(txtSearch.Text.Trim());
       
        }
        

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

                txtDoctorName.Text = row.Cells[0].Value.ToString();
                txtSpecialization.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                cmbGenderd.Text = row.Cells[3].Value.ToString();
                txtAddres.Text = row.Cells[4].Value.ToString();

                selectedDoctorID = GetDoctorID(row.Cells[0].Value.ToString());
            }
        }

        private int GetDoctorID(string Fullname)
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT DoctorID FROM Doctors WHERE FullName=@n", con);
                cmd.Parameters.AddWithValue("@n", Fullname);
                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }


                  
        private void panelRigth_Paint(object sender, PaintEventArgs e)
        {

        }

        


        private void LoadDoctors()
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Doctors", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dgvDoctors.Rows.Clear();
                while (dr.Read())
                {
                    dgvDoctors.Rows.Add(
                        dr["FullName"].ToString(),
                        dr["Specialty"].ToString(),
                        dr["Phone"].ToString(),
                        dr["Gender"].ToString(),
                        dr["Address"].ToString()
                    );
                }
                dr.Close();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form d = new DashboardForm();
            d.ShowDialog();
            this.Close();
        }
        private void ClearInputs()
        {
            txtDoctorName.Clear();
            txtSpecialization.Clear();
            txtPhone.Clear();
            txtAddres.Clear();
            cmbGenderd.SelectedIndex = -1;
            selectedDoctorID = 0;
        }

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;

            else this.WindowState = FormWindowState.Normal;
        }
    }
}
