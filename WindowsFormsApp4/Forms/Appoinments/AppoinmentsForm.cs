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

namespace WindowsFormsApp4.Forms.Appoinments
{
    public partial class AppoinmentsForm : Form
    {
        int selectedAppointmentID = 0;
        public AppoinmentsForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTreatment_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          if (cmbPatient.SelectedItem == null || cmbDoctor.SelectedItem == null)
            {
                MessageBox.Show("اختر المريض والطبيب أولا.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patientPair = (KeyValuePair<int, string>)cmbPatient.SelectedItem;
            var doctorPair = (KeyValuePair<int, string>)cmbDoctor.SelectedItem;

            DateTime date = dtpDate.Value.Date;
            string time = dtpTime.Value.ToString("HH:mm");
            string notes = txtTreatment.Text.Trim(); // نستخدم حقل Treatment لكتابة الملاحظة/العلاج

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, Notes) " +
                    "VALUES (@pid, @did, @date, @time, @notes)", con);

                cmd.Parameters.AddWithValue("@pid", patientPair.Key);
                cmd.Parameters.AddWithValue("@did", doctorPair.Key);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@notes", notes);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAppointments();
            MessageBox.Show("تمت إضافة الموعد بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {

         
            if (selectedAppointmentID == 0)
            {
                MessageBox.Show("اختر موعدًا من الجدول للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPatient.SelectedItem == null || cmbDoctor.SelectedItem == null)
            {
                MessageBox.Show("اختر المريض والطبيب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patientPair = (KeyValuePair<int, string>)cmbPatient.SelectedItem;
            var doctorPair = (KeyValuePair<int, string>)cmbDoctor.SelectedItem;

            DateTime date = dtpDate.Value.Date;
            string time = dtpTime.Value.ToString("HH:mm");
            string notes = txtTreatment.Text.Trim();

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Appointments SET PatientID=@pid, DoctorID=@did, AppointmentDate=@date, AppointmentTime=@time, Notes=@notes " +
                    "WHERE AppointmentID=@id", con);

                cmd.Parameters.AddWithValue("@pid", patientPair.Key);
                cmd.Parameters.AddWithValue("@did", doctorPair.Key);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@notes", notes);
                cmd.Parameters.AddWithValue("@id", selectedAppointmentID);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAppointments();
            MessageBox.Show("تم تحديث الموعد.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (selectedAppointmentID == 0)
            {
                MessageBox.Show("اختر موعدًا من الجدول للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dr = MessageBox.Show("هل أنت متأكد من حذف هذا الموعد؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@id", con);
                cmd.Parameters.AddWithValue("@id", selectedAppointmentID);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAppointments();
            MessageBox.Show("تم حذف الموعد.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }
        

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

            cmbPatient.SelectedItem = FindComboItemByValue(cmbPatient, row.Cells[0].Value?.ToString());
            cmbDoctor.SelectedItem = FindComboItemByValue(cmbDoctor, row.Cells[1].Value?.ToString());

            DateTime parsedDate;
            if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out parsedDate))
                dtpDate.Value = parsedDate;
            else
                dtpDate.Value = DateTime.Today;

            // وقت
            DateTime parsedTime;
            if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out parsedTime))
                dtpTime.Value = parsedTime;
            else
                dtpTime.Value = DateTime.Now;

            txtTreatment.Text = row.Cells[4].Value?.ToString() ?? "";

            // احصل على AppointmentID من Tag
            if (row.Tag != null)
                selectedAppointmentID = Convert.ToInt32(row.Tag);
            else
                selectedAppointmentID = 0;
        }

   
        private object FindComboItemByValue(ComboBox combo, string displayValue)
        {
            if (displayValue == null) return null;
            for (int i = 0; i < combo.Items.Count; i++)
            {
                var kv = (KeyValuePair<int, string>)combo.Items[i];
                if (kv.Value == displayValue) return combo.Items[i];
            }
            return null;
        }


        

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAppointments(txtSearch.Text.Trim());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        
            SearchAppointments(txtSearch.Text.Trim());
        }

       

        private void SearchAppointments(string keyword)
        {
            using (SqlConnection con = DB.GetConnection())
            {
                string sql = @"
                    SELECT a.AppointmentID, p.FullName AS PatientName, d.FullName AS DoctorName,
                           a.AppointmentDate, a.AppointmentTime, a.Notes
                    FROM Appointments a
                    LEFT JOIN Patients p ON a.PatientID = p.PatientID
                    LEFT JOIN Doctors d ON a.DoctorID = d.DoctorID
                    WHERE p.FullName LIKE @k OR d.FullName LIKE @k OR CONVERT(varchar, a.AppointmentDate, 23) LIKE @k
                    ORDER BY a.AppointmentDate DESC, a.AppointmentTime DESC";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dgvDoctors.Rows.Clear();
                while (dr.Read())
                {
                    int rowIndex = dgvDoctors.Rows.Add(
                        dr["PatientName"]?.ToString() ?? "",
                        dr["DoctorName"]?.ToString() ?? "",
                        Convert.ToDateTime(dr["AppointmentDate"]).ToString("yyyy-MM-dd"),
                        dr["AppointmentTime"]?.ToString() ?? "",
                        dr["Notes"]?.ToString() ?? "",
                        ""
                    );

                    dgvDoctors.Rows[rowIndex].Tag = Convert.ToInt32(dr["AppointmentID"]);
                }

                dr.Close();
            }
        }  
         

        

        private void AppoinmentsForm_Load(object sender, EventArgs e)
        {


            LoadPatients();
            LoadDoctors();
            LoadAppointments();
        
    }

        private void LoadDoctors()
        {
            cmbDoctor.Items.Clear();
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT DoctorID, FullName FROM Doctors ORDER BY FullName", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbDoctor.Items.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["DoctorID"]), dr["FullName"].ToString()));
                }
                dr.Close();
            }

            cmbDoctor.DisplayMember = "Value";
            cmbDoctor.ValueMember = "Key";
        }

        private void LoadPatients()
        {
            cmbPatient.Items.Clear();
            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT PatientID, FullName FROM Patients ORDER BY FullName", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    cmbPatient.Items.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["PatientID"]), dr["FullName"].ToString()));
                }
                dr.Close();
            }

           
            cmbPatient.DisplayMember = "Value";
            cmbPatient.ValueMember = "Key";
        }

        private void LoadAppointments()
        {
            using (SqlConnection con = DB.GetConnection())
            {
                // نعمل join لجلب أسماء المريض والدكتور
                string sql = @"
                    SELECT a.AppointmentID, p.FullName AS PatientName, d.FullName AS DoctorName,
                           a.AppointmentDate, a.AppointmentTime, a.Notes
                    FROM Appointments a
                    LEFT JOIN Patients p ON a.PatientID = p.PatientID
                    LEFT JOIN Doctors d ON a.DoctorID = d.DoctorID
                    ORDER BY a.AppointmentDate DESC, a.AppointmentTime DESC";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                dgvDoctors.Rows.Clear();
                while (dr.Read())
                {
                    int rowIndex = dgvDoctors.Rows.Add(
                        dr["PatientName"]?.ToString() ?? "",
                        dr["DoctorName"]?.ToString() ?? "",
                        Convert.ToDateTime(dr["AppointmentDate"]).ToString("yyyy-MM-dd"),
                        dr["AppointmentTime"]?.ToString() ?? "",
                        dr["Notes"]?.ToString() ?? "",
                        "" 
                    );

                    
                    dgvDoctors.Rows[rowIndex].Tag = Convert.ToInt32(dr["AppointmentID"]);
                }

                dr.Close();
            }
        }
        private void ClearInputs()
        {
            cmbPatient.SelectedItem = null;
            cmbDoctor.SelectedItem = null;
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now;
            txtTreatment.Clear();
            selectedAppointmentID = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form d = new DashboardForm();
            d.ShowDialog();
            this.Close();
        }

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;

            else this.WindowState = FormWindowState.Normal;
        }
    }

}



