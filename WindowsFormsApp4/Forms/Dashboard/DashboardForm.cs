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
using WindowsFormsApp4.Forms.Appoinments;
using WindowsFormsApp4.Forms.Auth;
using WindowsFormsApp4.Forms.Backup;
using WindowsFormsApp4.Forms.Doctors;
using WindowsFormsApp4.Forms.Invoices;
using WindowsFormsApp4.Forms.Patients;
using WindowsFormsApp4.Forms.Treatments;

namespace WindowsFormsApp4.Forms.Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Form g = new PatientsForm();
            g.ShowDialog();
            this.Hide();
        }

        private void btn_Appointements_Click(object sender, EventArgs e)
        {
           Form ap = new AppoinmentsForm();
           ap.ShowDialog();
           // this.Close();
           this.Hide();

        }

        private void btn_Treatments_Click(object sender, EventArgs e)
        {
            Form Tr = new TreatmentsForm1();
            Tr.ShowDialog();
            this.Hide();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            Form D = new DoctorsForm();
            D.ShowDialog();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("You are already in the Dashboard!",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
           
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            Form Iv = new InvoicesForm();
            Iv.ShowDialog();
            this.Hide();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            Form Ba = new BackupForm();
            Ba.ShowDialog();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
        
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }
        

        private void Dental_clinic_Click(object sender, EventArgs e)
        {

        }

        private void plblogo_Click(object sender, EventArgs e)
        {

        }

        private void labelwelcam_Click(object sender, EventArgs e)
        {

        }

        private void paneltoper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labeldatetime_Click(object sender, EventArgs e)
        {

        }

        private void Flpstats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cardTopdoctor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardincome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardappointment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            labeldatetime.Text = "Welcome back!  " + DateTime.Now.ToString("yyyy-MM-dd  hh:mm tt");
           // labeldatetime.Text = DateTime.Now.ToString("yyyy-MM-dd  hh:mm tt");
        }

        private void LoadDashboardData()
        {
            using (SqlConnection con = DB.GetConnection())
            {
                con.Open();

                // عدد المرضى
                SqlCommand cmdPatients = new SqlCommand("SELECT COUNT(*) FROM Patients", con);
                label1.Text = cmdPatients.ExecuteScalar().ToString();

                // عدد المواعيد اليوم
                SqlCommand cmdApp = new SqlCommand(
                    "SELECT COUNT(*) FROM Appointments WHERE CONVERT(date, AppointmentDate) = CONVERT(date, GETDATE())", con);
                lblappointments.Text = cmdApp.ExecuteScalar().ToString();

                // الدخل اليوم
                SqlCommand cmdIncome = new SqlCommand(
                    "SELECT ISNULL(SUM(TotalAmount),0) FROM Bills WHERE CONVERT(date, BillDate) = CONVERT(date, GETDATE())", con);
                lblincomevalue.Text = cmdIncome.ExecuteScalar().ToString() + " $";

                // أفضل دكتور (أكثر مواعيد)
                SqlCommand cmdTopDoctor = new SqlCommand(
                    @"SELECT TOP 1 D.FullName
              FROM Doctors D
              JOIN Appointments A ON D.DoctorID = A.DoctorID
              GROUP BY D.FullName
              ORDER BY COUNT(A.AppointmentID) DESC", con);

                object result = cmdTopDoctor.ExecuteScalar();
                lblTopDoctorValue.Text = result != null ? result.ToString() : "No Data";

                LoadChart(con);
            }
        }

        private void LoadChart(SqlConnection con)
        {
            string query = @"
        SELECT DATENAME(weekday, AppointmentDate) AS DayName, COUNT(*) AS Total
        FROM Appointments
        GROUP BY DATENAME(weekday, AppointmentDate)
    ";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            chart1.Series["Series1"].Points.Clear();

            while (rd.Read())
            {
                chart1.Series["Series1"].Points.AddXY(rd["DayName"].ToString(), rd["Total"]);
            }

            rd.Close();
        }

        private void lblincomevalue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;

            else this.WindowState = FormWindowState.Normal;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
