using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp4.Database;
using WindowsFormsApp4.Forms.Dashboard;
using System.Diagnostics.Eventing.Reader;
namespace WindowsFormsApp4.Forms.Patients
{
    public partial class PatientsForm : Form
    {
        int selectedPatientID = 0;
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT PatientID, FullName, Phone, Age, Gender, Address FROM Patients", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dgvPatients.Rows.Clear();
                while (dr.Read())
                {
                    dgvPatients.Rows.Add(
                        dr["FullName"].ToString(),
                        "", 
                        dr["Age"].ToString(),
                        dr["Gender"].ToString(),
                        dr["Phone"].ToString(),
                        dr["Address"].ToString()
                    );
                }
                dr.Close();
            }
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];

                txtFirstName.Text = row.Cells[0].Value.ToString().Split(' ')[0];
                txtLastName.Text = row.Cells[0].Value.ToString().Split(' ').Length > 1
                                   ? row.Cells[0].Value.ToString().Split(' ')[1]
                                   : "";

                nudAge.Value = Convert.ToDecimal(row.Cells[2].Value);
                cmbGender.Text = row.Cells[3].Value.ToString();
                textPhone.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();

                selectedPatientID = GetPatientIDFromName(row.Cells[0].Value.ToString());
            }
        

        }

        private int GetPatientIDFromName(string name)
        {
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT PatientID FROM Patients WHERE FullName = @n", con);
                cmd.Parameters.AddWithValue("@n", name);
                con.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }



        private void PanelRight_patint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                  string.IsNullOrWhiteSpace(textPhone.Text) ||
                  string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("يرجى تعبئة جميع الحقول!", "تنبيه");
                return;
            }

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Patients (FullName, Phone, Age, Gender, Address) VALUES (@n, @p, @a, @g, @ad)", con);

                string fullName = txtFirstName.Text + " " + txtLastName.Text;

                cmd.Parameters.AddWithValue("@n", fullName);
                cmd.Parameters.AddWithValue("@p", textPhone.Text);
                cmd.Parameters.AddWithValue("@a", nudAge.Value);
                cmd.Parameters.AddWithValue("@g", cmbGender.Text);
                cmd.Parameters.AddWithValue("@ad", txtAddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تم إظافة المريض ");
            LoadPatients();
            ClearInputs();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPatientID == 0)
            {
                MessageBox.Show("الرجاء اختيار المريض أولاً من الجدول.",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Patients SET FullName=@n, Phone=@p, Age=@a, Gender=@g, Address=@ad WHERE PatientID=@id", con);

                string fullName = txtFirstName.Text + " " + txtLastName.Text;

                cmd.Parameters.AddWithValue("@n", fullName);
                cmd.Parameters.AddWithValue("@p", textPhone.Text);
                cmd.Parameters.AddWithValue("@a", nudAge.Value);
                cmd.Parameters.AddWithValue("@g", cmbGender.Text);
                cmd.Parameters.AddWithValue("@ad", txtAddress.Text);
                cmd.Parameters.AddWithValue("@id", selectedPatientID);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("تم تحديث بيانات المريض بنجاح!",
                            "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LoadPatients();
            ClearInputs();

        }

        private void PatientsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
            if (selectedPatientID == 0)
            {
                MessageBox.Show("اختر المريض من الجدول أولاً!");
                return;
            }

            using (SqlConnection con = DB.GetConnection())
            {
                con.Open();

                //  1- فحص هل المريض مرتبط بمواعيد
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Appointments WHERE PatientID = @id", con);
                checkCmd.Parameters.AddWithValue("@id", selectedPatientID);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    //  إذا لديه مواعيد — يتم منع الحذف
                    MessageBox.Show("لا يمكن حذف المريض لأنه مرتبط بمواعيد. احذف المواعيد أولاً.");
                    return;
                }

                // 2- إذا لا يوجد مواعيد — احذف المريض
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Patients WHERE PatientID = @id", con);
                cmd.Parameters.AddWithValue("@id", selectedPatientID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("تم حذف المريض بنجاح ✔");
                LoadPatients();
            }
        
         
           


    }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT FullName, Phone, Age, Gender, Address FROM Patients WHERE FullName LIKE @s", con);

                cmd.Parameters.AddWithValue("@s", "%" + txtSearch.Text + "%");

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dgvPatients.Rows.Clear();
                while (dr.Read())
                {
                    dgvPatients.Rows.Add(
                        dr["FullName"].ToString(),
                        "",
                        dr["Age"].ToString(),
                        dr["Gender"].ToString(),
                        dr["Phone"].ToString(),
                        dr["Address"].ToString()
                    );
                }
                dr.Close();
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form d = new DashboardForm();
            d.ShowDialog();
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            
                this.WindowState=FormWindowState.Maximized;

                else this.WindowState=FormWindowState.Normal;   
            
        }

        private void ClearInputs()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            textPhone.Text = "";
            txtAddress.Text = "";
            cmbGender.SelectedIndex = -1;
            nudAge.Value = 1;
            selectedPatientID = 0;
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
