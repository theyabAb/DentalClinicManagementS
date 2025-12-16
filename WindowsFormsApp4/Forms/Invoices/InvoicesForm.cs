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


namespace WindowsFormsApp4.Forms.Invoices
{
    public partial class InvoicesForm : Form
    {

        SqlConnection con = new SqlConnection(
            "Server=DESKTOP-VJI1C1U\\SQLEXPRESS;Database=ClinicDB;Integrated Security=True"
        );
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || cmbTreatment.SelectedValue == null)
            {
                MessageBox.Show("Please select patient and treatment.");
                return;
            }

            using (SqlConnection con = new SqlConnection(
                "Server=DESKTOP-VJI1C1U\\SQLEXPRESS;Database=ClinicDB;Integrated Security=True"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Bills (PatientID, TreatmentID, BillDate, TotalAmount)
            VALUES (@p, @t, @d, @total)", con);

                cmd.Parameters.AddWithValue("@p", cmbPatient.SelectedValue);
                cmd.Parameters.AddWithValue("@t", cmbTreatment.SelectedValue);
                cmd.Parameters.AddWithValue("@d", dtbDate.Value);
                cmd.Parameters.AddWithValue("@total", nudTotal.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Invoice added successfully!");
            }

            LoadInvoices();
        }


        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInvID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTreatment_Click(object sender, EventArgs e)
        {

        }

        private void lblPatient_Click(object sender, EventArgs e)
        {

        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void dtbDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
         
            if (txtInvID.Text == "")
            {
                MessageBox.Show("Select an invoice from the table first!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Bills WHERE BillID=@id",
                    con
                );

                cmd.Parameters.AddWithValue("@id", txtInvID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Invoice deleted!");

                LoadInvoices();
            }
            finally
            {
                con.Close();
            }
        }
        

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex < 0) return;

            txtInvID.Text = dgvInvoices.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           dgvInvoices.Rows.Clear();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT Bills.BillID, 
                             Patients.FullName AS Patient, 
                             Treatments.TreatmentName AS Treatment,
                             Bills.BillDate, 
                             Bills.TotalAmount
                      FROM Bills
                      JOIN Patients ON Bills.PatientID = Patients.PatientID
                      JOIN Treatments ON Bills.TreatmentID = Treatments.TreatmentID
                      WHERE Patients.FullName LIKE @s
                         OR Treatments.TreatmentName LIKE @s
                         OR Bills.BillID LIKE @s",
                    con
                );

                cmd.Parameters.AddWithValue("@s", "%" + txtSearch.Text + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvInvoices.Rows.Add(
                        dr["BillID"],
                        dr["Patient"],
                        dr["Treatment"],
                        Convert.ToDateTime(dr["BillDate"]).ToString("yyyy-MM-dd"),
                        dr["TotalAmount"]
                    );
                }
            }
            finally
            {
                con.Close();
            }
        }
        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPatients()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT PatientID, FullName FROM Patients", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "FullName";
                cmbPatient.ValueMember = "PatientID";
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadTreatments()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TreatmentID, TreatmentName FROM Treatments", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTreatment.DataSource = dt;
                cmbTreatment.DisplayMember = "TreatmentName";
                cmbTreatment.ValueMember = "TreatmentID";
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadInvoices()
        {
            dgvInvoices.Rows.Clear();

            using (SqlConnection con = new SqlConnection(
                "Server=DESKTOP-VJI1C1U\\SQLEXPRESS;Database=ClinicDB;Integrated Security=True"))
            {
                con.Open();

                string query = @"
            SELECT Bills.BillID,
                   Patients.FullName AS Patient,
                   Treatments.TreatmentName AS Treatment,
                   Bills.BillDate,
                   Bills.TotalAmount
            FROM Bills
            JOIN Patients ON Bills.PatientID = Patients.PatientID
            JOIN Treatments ON Bills.TreatmentID = Treatments.TreatmentID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        dgvInvoices.Rows.Add(
                            dr["BillID"],
                            dr["Patient"],
                            dr["Treatment"],
                            Convert.ToDateTime(dr["BillDate"]).ToShortDateString(),
                            dr["TotalAmount"]
                        );
                    }
                }
            }
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadTreatments();
            LoadInvoices();
        }

        private void tbn_Back_Click(object sender, EventArgs e)
        {
            Form d = new DashboardForm();
            d.ShowDialog();
            this.Close();
        }

        private void btn_Closed_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;

            else this.WindowState = FormWindowState.Normal;

        }
    }
}
