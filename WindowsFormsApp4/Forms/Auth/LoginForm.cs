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

namespace WindowsFormsApp4.Forms.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        
        }

          
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {

            if (Showpass.Checked)
            {
                // إظهار كلمة المرور
                password.UseSystemPasswordChar = false;

                // تغيير صورة العين إلى المفتوحة
                picShowpass.Image = Properties.Resources.eye;
            }
            else
            {
                // إخفاء كلمة المرور
                password.UseSystemPasswordChar = true;

                // تغيير صورة العين إلى العين المشطوبة
                picShowpass.Image = Properties.Resources.invisible;
            }
        }


       

        private void Login_Click_1(object sender, EventArgs e)
        {

            string user = userName.Text.Trim();
            string pass = password.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور",
                                "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = DB.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT UserID FROM Users WHERE Username=@u AND Password=@p", con);

                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // ✔ نجاح الدخول
                    DashboardForm main = new DashboardForm();
                    main.StartPosition = FormStartPosition.CenterScreen;
                    main.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" اسم المستخدم أو كلمة المرور غير صحيحة!",
                                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
       
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void LoginForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        
        }

        private void btb_Click(object sender, EventArgs e)
        {

        }
    }
    
}

