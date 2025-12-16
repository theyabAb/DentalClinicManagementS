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
using WindowsFormsApp4.Forms.Dashboard;

namespace WindowsFormsApp4.Forms.Treatments
{
    public partial class TreatmentsForm1 : Form
    {

        SqlConnection con = new SqlConnection(
           "Server=DESKTOP-VJI1C1U\\SQLEXPRESS;Database=ClinicDB;Integrated Security=True"
       );

        public TreatmentsForm1()
        {
            InitializeComponent();
        }

        private void TreatmentsForm1_Load(object sender, EventArgs e)
        {
            LoadTreatments();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTName_Click(object sender, EventArgs e)
        {

        }

        private void lblTCost_Click(object sender, EventArgs e)
        {

        }

        private void nudTCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtTID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        
            if (txtTName.Text == "" || txtTDesc.Text == "")
            {
                MessageBox.Show("يجب تعبئة البيانات كاملة");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Treatments (TreatmentName, Price, Description) VALUES (@n, @c, @d)", con);

            cmd.Parameters.AddWithValue("@n", txtTName.Text);
            cmd.Parameters.AddWithValue("@c", nudTCost.Value);
            cmd.Parameters.AddWithValue("@d", txtTDesc.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("تمت الإضافة بنجاح");
            LoadTreatments();
        }       


        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
            if (txtTID.Text == "")
            {
                MessageBox.Show("اختر العلاج أولاً من القائمة");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(
                "UPDATE Treatments SET TreatmentName=@n, Price=@c, Description=@d WHERE TreatmentID=@id", con);

            cmd.Parameters.AddWithValue("@id", txtTID.Text);
            cmd.Parameters.AddWithValue("@n", txtTName.Text);
            cmd.Parameters.AddWithValue("@c", nudTCost.Value);
            cmd.Parameters.AddWithValue("@d", txtTDesc.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("تم التعديل بنجاح");
            LoadTreatments();
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (txtTID.Text == "")
            {
                MessageBox.Show("اختر العلاج أولاً من الجدول");
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Treatments WHERE TreatmentID=@id", con);
            cmd.Parameters.AddWithValue("@id", txtTID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("تم الحذف بنجاح");
            LoadTreatments();
        }
        

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            dgvTreatment.Rows.Clear();

            con.Open();
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Treatments WHERE TreatmentName LIKE @s OR Description LIKE @s", con);
            cmd.Parameters.AddWithValue("@s", "%" + txtSearch.Text + "%");

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dgvTreatment.Rows.Add(
                    dr["TreatmentID"],
                    dr["TreatmentName"],
                    dr["Price"],
                    dr["Description"]
                );
            }
            con.Close();
        

        }

        private void dgvTreatment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0)
            {
                txtTID.Text = dgvTreatment.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTName.Text = dgvTreatment.Rows[e.RowIndex].Cells[1].Value.ToString();
                nudTCost.Value = Convert.ToDecimal(dgvTreatment.Rows[e.RowIndex].Cells[2].Value);
                txtTDesc.Text = dgvTreatment.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        void LoadTreatments()
        {
            dgvTreatment.Rows.Clear();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Treatments", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvTreatment.Rows.Add(
                    dr["TreatmentID"],
                    dr["TreatmentName"],
                    dr["Price"],
                    dr["Description"]
                );
            }

            con.Close();
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

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;

            else this.WindowState = FormWindowState.Normal;
        }
    }
}
