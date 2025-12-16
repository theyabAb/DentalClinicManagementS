namespace WindowsFormsApp4.Forms.Doctors
{
    partial class DoctorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRigth = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeft_doctor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenderd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.btb = new System.Windows.Forms.Button();
            this.panelRigth.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.panelLeft_doctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRigth
            // 
            this.panelRigth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRigth.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._7a30d4d9_bcf5_4100_af0f_7678a9ba75d9;
            this.panelRigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRigth.Controls.Add(this.panel1);
            this.panelRigth.Controls.Add(this.dgvDoctors);
            this.panelRigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRigth.Location = new System.Drawing.Point(358, 0);
            this.panelRigth.Name = "panelRigth";
            this.panelRigth.Size = new System.Drawing.Size(993, 735);
            this.panelRigth.TabIndex = 1;
            this.panelRigth.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRigth_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._0bb87d92_4971_4d57_9d5a_2b0e6761725b;
            this.panel1.Controls.Add(this.btb);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 27);
            this.panel1.TabIndex = 24;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.IMG_٢٠٢٥١١٣٠_١٧٥٠١٧_٠٥٥١٤٨;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(882, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(25, 25);
            this.btn_Back.TabIndex = 25;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "HELLOW EVERY ONE IN OUR DENTAL CLINIC ";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(968, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 23;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorName,
            this.Secialization,
            this.Phone,
            this.Gender,
            this.Address});
            this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDoctors.EnableHeadersVisualStyles = false;
            this.dgvDoctors.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDoctors.Location = new System.Drawing.Point(0, 491);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 26;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(993, 244);
            this.dgvDoctors.TabIndex = 21;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // DoctorName
            // 
            this.DoctorName.HeaderText = "DOCTORNAME";
            this.DoctorName.MinimumWidth = 6;
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // Secialization
            // 
            this.Secialization.HeaderText = "Specialization";
            this.Secialization.MinimumWidth = 6;
            this.Secialization.Name = "Secialization";
            this.Secialization.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // panelLeft_doctor
            // 
            this.panelLeft_doctor.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._7a30d4d9_bcf5_4100_af0f_7678a9ba75d9;
            this.panelLeft_doctor.Controls.Add(this.label2);
            this.panelLeft_doctor.Controls.Add(this.btnUpdate);
            this.panelLeft_doctor.Controls.Add(this.btnSearch);
            this.panelLeft_doctor.Controls.Add(this.btnDelete);
            this.panelLeft_doctor.Controls.Add(this.txtSearch);
            this.panelLeft_doctor.Controls.Add(this.lblSearch);
            this.panelLeft_doctor.Controls.Add(this.btnAdd);
            this.panelLeft_doctor.Controls.Add(this.txtAddres);
            this.panelLeft_doctor.Controls.Add(this.label5);
            this.panelLeft_doctor.Controls.Add(this.txtPhone);
            this.panelLeft_doctor.Controls.Add(this.label4);
            this.panelLeft_doctor.Controls.Add(this.cmbGenderd);
            this.panelLeft_doctor.Controls.Add(this.label3);
            this.panelLeft_doctor.Controls.Add(this.txtSpecialization);
            this.panelLeft_doctor.Controls.Add(this.lastname);
            this.panelLeft_doctor.Controls.Add(this.txtDoctorName);
            this.panelLeft_doctor.Controls.Add(this.lblFirst);
            this.panelLeft_doctor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_doctor.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_doctor.Name = "panelLeft_doctor";
            this.panelLeft_doctor.Padding = new System.Windows.Forms.Padding(20);
            this.panelLeft_doctor.Size = new System.Drawing.Size(358, 735);
            this.panelLeft_doctor.TabIndex = 0;
            this.panelLeft_doctor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_doctor_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 40);
            this.label2.TabIndex = 32;
            this.label2.Text = "Doctors Part";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(122, 550);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 40);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.search__5_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(321, 631);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(256, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(89, 636);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 26);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(5, 639);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(78, 21);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Searche";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(11, 550);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 40);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(33, 450);
            this.txtAddres.Multiline = true;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(300, 70);
            this.txtAddres.TabIndex = 28;
            this.txtAddres.TextChanged += new System.EventHandler(this.txtAddres_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(33, 298);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone nmber";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbGenderd
            // 
            this.cmbGenderd.FormattingEnabled = true;
            this.cmbGenderd.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGenderd.Location = new System.Drawing.Point(33, 352);
            this.cmbGenderd.Name = "cmbGenderd";
            this.cmbGenderd.Size = new System.Drawing.Size(300, 26);
            this.cmbGenderd.TabIndex = 24;
            this.cmbGenderd.SelectedIndexChanged += new System.EventHandler(this.cmbGenderd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(33, 217);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(300, 26);
            this.txtSpecialization.TabIndex = 21;
            this.txtSpecialization.TextChanged += new System.EventHandler(this.txtSpecialization_TextChanged);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(33, 192);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(129, 21);
            this.lastname.TabIndex = 20;
            this.lastname.Text = "Specialization";
            this.lastname.Click += new System.EventHandler(this.lastname_Click);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(33, 152);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(300, 26);
            this.txtDoctorName.TabIndex = 18;
            this.txtDoctorName.TextChanged += new System.EventHandler(this.txtDoctorName_TextChanged);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(33, 127);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(111, 21);
            this.lblFirst.TabIndex = 17;
            this.lblFirst.Text = "Doctr Nmae";
            this.lblFirst.Click += new System.EventHandler(this.lblFirst_Click);
            // 
            // btb
            // 
            this.btb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btb.BackColor = System.Drawing.Color.Transparent;
            this.btb.ForeColor = System.Drawing.Color.Transparent;
            this.btb.Location = new System.Drawing.Point(926, 0);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(25, 25);
            this.btb.TabIndex = 25;
            this.btb.UseVisualStyleBackColor = false;
            this.btb.Click += new System.EventHandler(this.btb_Click);
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 735);
            this.Controls.Add(this.panelRigth);
            this.Controls.Add(this.panelLeft_doctor);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsForm";
            this.Text = "DoctorsForm";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.panelRigth.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.panelLeft_doctor.ResumeLayout(false);
            this.panelLeft_doctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_doctor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGenderd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Panel panelRigth;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btb;
    }
}