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
using System.IO;
using WindowsFormsApp4.Forms.Dashboard;

namespace WindowsFormsApp4.Forms.Backup
{
    public partial class BackupForm : Form
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=ClinicDB;Trusted_Connection=True;";
        private string backupFolder = @"D:\Backup\";
        public BackupForm()
        {
            InitializeComponent();
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
          
            lblLastBackup.Text = "Last Backup: لا يوجد";
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }
        }
        

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblLastBackup_Click(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\Backup";       
            ofd.Filter = "Backup Files (*.bak)|*.bak";  
            ofd.Title = "اختر ملف النسخة الاحتياطية";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;           
            }
        
           
        }

        

        private void btnRestore_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtPath.Text))
            {
                MessageBox.Show("اختر ملف النسخة الاحتياطية أولاً");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = $@"
            ALTER DATABASE ClinicDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

            RESTORE DATABASE ClinicDB 
            FROM DISK = '{txtPath.Text}' 
            WITH REPLACE;

            ALTER DATABASE ClinicDB SET MULTI_USER;
            ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        
        
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {

            try
            {
                string backupName = $"ClinicDB_{DateTime.Now:yyyyMMdd_HHmm}.bak";
                string fullPath = Path.Combine(backupFolder, backupName);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "BACKUP DATABASE ClinicDB TO DISK = @path";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@path", fullPath);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                lblLastBackup.Text = "Last Backup: " + DateTime.Now.ToString();
                txtPath.Text = fullPath;

                MessageBox.Show(" تم إنشاء النسخة الاحتياطية بنجاح في D:\\Backup\\");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
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

        private void btb_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)

                this.WindowState = FormWindowState.Maximized;

            else this.WindowState = FormWindowState.Normal;
        }
    }
}
