namespace WindowsFormsApp4.Forms.Patients
{
    partial class PatientsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            this.PanelRight_patint = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btb = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addressd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelLeft_patinet = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.PanelRight_patint.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.PanelLeft_patinet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelRight_patint
            // 
            this.PanelRight_patint.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelRight_patint.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.تنزيل__1_;
            this.PanelRight_patint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelRight_patint.Controls.Add(this.panel1);
            this.PanelRight_patint.Controls.Add(this.dgvPatients);
            this.PanelRight_patint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRight_patint.Location = new System.Drawing.Point(380, 0);
            this.PanelRight_patint.Name = "PanelRight_patint";
            this.PanelRight_patint.Size = new System.Drawing.Size(800, 711);
            this.PanelRight_patint.TabIndex = 4;
            this.PanelRight_patint.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRight_patint_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._0bb87d92_4971_4d57_9d5a_2b0e6761725b;
            this.panel1.Controls.Add(this.btb);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 19;
            // 
            // btb
            // 
            this.btb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btb.BackColor = System.Drawing.Color.Transparent;
            this.btb.ForeColor = System.Drawing.Color.Transparent;
            this.btb.Location = new System.Drawing.Point(724, 3);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(25, 25);
            this.btb.TabIndex = 19;
            this.btb.UseVisualStyleBackColor = false;
            this.btb.Click += new System.EventHandler(this.btb_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(767, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Back.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.IMG_٢٠٢٥١١٣٠_١٧٥٠١٧_٠٥٥١٤٨_2_;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back.Location = new System.Drawing.Point(678, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(30, 30);
            this.btn_Back.TabIndex = 17;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastNam,
            this.Age,
            this.Gender,
            this.Phone,
            this.Addressd});
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPatients.Location = new System.Drawing.Point(0, 467);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 26;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(800, 244);
            this.dgvPatients.TabIndex = 18;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Firstnem";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastNam
            // 
            this.LastNam.HeaderText = "LASTNAME";
            this.LastNam.MinimumWidth = 6;
            this.LastNam.Name = "LastNam";
            this.LastNam.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "AGE";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "GENDER";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "PHONNUMBER";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Addressd
            // 
            this.Addressd.HeaderText = "ADDRESS";
            this.Addressd.MinimumWidth = 6;
            this.Addressd.Name = "Addressd";
            this.Addressd.ReadOnly = true;
            // 
            // PanelLeft_patinet
            // 
            this.PanelLeft_patinet.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._0bb87d92_4971_4d57_9d5a_2b0e6761725b;
            this.PanelLeft_patinet.Controls.Add(this.label1);
            this.PanelLeft_patinet.Controls.Add(this.btnSearch);
            this.PanelLeft_patinet.Controls.Add(this.txtSearch);
            this.PanelLeft_patinet.Controls.Add(this.lblSearch);
            this.PanelLeft_patinet.Controls.Add(this.btnUpdate);
            this.PanelLeft_patinet.Controls.Add(this.btnDelete);
            this.PanelLeft_patinet.Controls.Add(this.btnAdd);
            this.PanelLeft_patinet.Controls.Add(this.txtAddress);
            this.PanelLeft_patinet.Controls.Add(this.label5);
            this.PanelLeft_patinet.Controls.Add(this.textPhone);
            this.PanelLeft_patinet.Controls.Add(this.label4);
            this.PanelLeft_patinet.Controls.Add(this.cmbGender);
            this.PanelLeft_patinet.Controls.Add(this.label3);
            this.PanelLeft_patinet.Controls.Add(this.nudAge);
            this.PanelLeft_patinet.Controls.Add(this.txtLastName);
            this.PanelLeft_patinet.Controls.Add(this.lastname);
            this.PanelLeft_patinet.Controls.Add(this.label2);
            this.PanelLeft_patinet.Controls.Add(this.txtFirstName);
            this.PanelLeft_patinet.Controls.Add(this.lblFirst);
            this.PanelLeft_patinet.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_patinet.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft_patinet.Name = "PanelLeft_patinet";
            this.PanelLeft_patinet.Size = new System.Drawing.Size(380, 711);
            this.PanelLeft_patinet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "patients Management";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::WindowsFormsApp4.Properties.Resources.search__5_;
            this.btnSearch.Location = new System.Drawing.Point(321, 621);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(89, 621);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(5, 624);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(78, 21);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Searche";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUpdate.Location = new System.Drawing.Point(120, 521);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "   Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(235, 521);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(10, 521);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 407);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 70);
            this.txtAddress.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(12, 337);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(300, 26);
            this.textPhone.TabIndex = 10;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone nmber";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(12, 267);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 26);
            this.cmbGender.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(12, 197);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 26);
            this.nudAge.TabIndex = 6;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.ValueChanged += new System.EventHandler(this.nudAge_ValueChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(12, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(12, 107);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(93, 21);
            this.lastname.TabIndex = 4;
            this.lastname.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 67);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(12, 42);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(95, 21);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Fristname";
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1180, 711);
            this.Controls.Add(this.PanelRight_patint);
            this.Controls.Add(this.PanelLeft_patinet);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(16, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load_1);
            this.PanelRight_patint.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.PanelLeft_patinet.ResumeLayout(false);
            this.PanelLeft_patinet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLeft_patinet;
        private System.Windows.Forms.Panel PanelRight_patint;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addressd;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btb;
    }
}