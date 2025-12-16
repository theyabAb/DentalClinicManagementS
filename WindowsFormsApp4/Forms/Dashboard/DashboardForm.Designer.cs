namespace WindowsFormsApp4.Forms.Dashboard
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.z = new System.Windows.Forms.Panel();
            this.panelchart = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.Flpstats = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardappointment = new System.Windows.Forms.Panel();
            this.lblappointments = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardincome = new System.Windows.Forms.Panel();
            this.lblincomevalue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardTopdoctor = new System.Windows.Forms.Panel();
            this.lblTopDoctorValue = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pbpatientsIcon = new System.Windows.Forms.PictureBox();
            this.paneltoper = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btb = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.labeldatetime = new System.Windows.Forms.Label();
            this.panelsider = new System.Windows.Forms.Panel();
            this.btn_Treatments = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_doctor = new System.Windows.Forms.Button();
            this.btn_Invoices = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.plblogo = new System.Windows.Forms.PictureBox();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btn_Appointements = new System.Windows.Forms.Button();
            this.z.SuspendLayout();
            this.panelchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Flpstats.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cardappointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cardincome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.cardTopdoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpatientsIcon)).BeginInit();
            this.paneltoper.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelsider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.SystemColors.HighlightText;
            this.z.Controls.Add(this.panelchart);
            this.z.Controls.Add(this.label2);
            this.z.Controls.Add(this.Flpstats);
            this.z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.z.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.ForeColor = System.Drawing.SystemColors.GrayText;
            this.z.Location = new System.Drawing.Point(198, 100);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(1124, 553);
            this.z.TabIndex = 61;
            // 
            // panelchart
            // 
            this.panelchart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelchart.Controls.Add(this.chart1);
            this.panelchart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelchart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchart.Location = new System.Drawing.Point(0, 140);
            this.panelchart.Margin = new System.Windows.Forms.Padding(10);
            this.panelchart.Name = "panelchart";
            this.panelchart.Size = new System.Drawing.Size(1124, 413);
            this.panelchart.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.RosyBrown;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1124, 413);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "appointments  per week";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "appointments per week";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(151, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 5;
            // 
            // Flpstats
            // 
            this.Flpstats.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Flpstats.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Business_Technology_Background_Banner_Design__Wallpaper__Psd__Slogan_Background_Image_And_Wallpaper_for_Free_Download;
            this.Flpstats.Controls.Add(this.panel1);
            this.Flpstats.Controls.Add(this.cardappointment);
            this.Flpstats.Controls.Add(this.cardincome);
            this.Flpstats.Controls.Add(this.cardTopdoctor);
            this.Flpstats.Dock = System.Windows.Forms.DockStyle.Top;
            this.Flpstats.Location = new System.Drawing.Point(0, 0);
            this.Flpstats.Name = "Flpstats";
            this.Flpstats.Padding = new System.Windows.Forms.Padding(10);
            this.Flpstats.Size = new System.Drawing.Size(1124, 140);
            this.Flpstats.TabIndex = 0;
            this.Flpstats.WrapContents = false;
            this.Flpstats.Paint += new System.Windows.Forms.PaintEventHandler(this.Flpstats_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 110);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "patints TOday";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources._858199e7_30b8_4a2f_a681_52b47d5587de;
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cardappointment
            // 
            this.cardappointment.BackColor = System.Drawing.SystemColors.Info;
            this.cardappointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardappointment.Controls.Add(this.lblappointments);
            this.cardappointment.Controls.Add(this.label5);
            this.cardappointment.Controls.Add(this.pictureBox2);
            this.cardappointment.Location = new System.Drawing.Point(300, 20);
            this.cardappointment.Margin = new System.Windows.Forms.Padding(10);
            this.cardappointment.Name = "cardappointment";
            this.cardappointment.Size = new System.Drawing.Size(260, 110);
            this.cardappointment.TabIndex = 2;
            this.cardappointment.Paint += new System.Windows.Forms.PaintEventHandler(this.cardappointment_Paint);
            // 
            // lblappointments
            // 
            this.lblappointments.AutoSize = true;
            this.lblappointments.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblappointments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblappointments.Location = new System.Drawing.Point(79, 46);
            this.lblappointments.Name = "lblappointments";
            this.lblappointments.Size = new System.Drawing.Size(0, 21);
            this.lblappointments.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "appointments Today";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::WindowsFormsApp4.Properties.Resources._8630f4c8_392b_49fd_9036_c86545aa483e;
            this.pictureBox2.Location = new System.Drawing.Point(15, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // cardincome
            // 
            this.cardincome.BackColor = System.Drawing.SystemColors.Info;
            this.cardincome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardincome.Controls.Add(this.lblincomevalue);
            this.cardincome.Controls.Add(this.label7);
            this.cardincome.Controls.Add(this.pictureBox3);
            this.cardincome.Location = new System.Drawing.Point(580, 20);
            this.cardincome.Margin = new System.Windows.Forms.Padding(10);
            this.cardincome.Name = "cardincome";
            this.cardincome.Size = new System.Drawing.Size(260, 110);
            this.cardincome.TabIndex = 3;
            this.cardincome.Paint += new System.Windows.Forms.PaintEventHandler(this.cardincome_Paint);
            // 
            // lblincomevalue
            // 
            this.lblincomevalue.AutoSize = true;
            this.lblincomevalue.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblincomevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblincomevalue.Location = new System.Drawing.Point(79, 46);
            this.lblincomevalue.Name = "lblincomevalue";
            this.lblincomevalue.Size = new System.Drawing.Size(0, 21);
            this.lblincomevalue.TabIndex = 6;
            this.lblincomevalue.Click += new System.EventHandler(this.lblincomevalue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "incom Today";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox3.Image = global::WindowsFormsApp4.Properties.Resources.usd_crypto_cryptocurrency_cryptocurrencies_cash_money_bank_payment_95707__1_;
            this.pictureBox3.Location = new System.Drawing.Point(15, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // cardTopdoctor
            // 
            this.cardTopdoctor.BackColor = System.Drawing.SystemColors.Info;
            this.cardTopdoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTopdoctor.Controls.Add(this.lblTopDoctorValue);
            this.cardTopdoctor.Controls.Add(this.lbl);
            this.cardTopdoctor.Controls.Add(this.pbpatientsIcon);
            this.cardTopdoctor.Location = new System.Drawing.Point(860, 20);
            this.cardTopdoctor.Margin = new System.Windows.Forms.Padding(10);
            this.cardTopdoctor.Name = "cardTopdoctor";
            this.cardTopdoctor.Size = new System.Drawing.Size(260, 110);
            this.cardTopdoctor.TabIndex = 0;
            this.cardTopdoctor.Paint += new System.Windows.Forms.PaintEventHandler(this.cardTopdoctor_Paint);
            // 
            // lblTopDoctorValue
            // 
            this.lblTopDoctorValue.AutoSize = true;
            this.lblTopDoctorValue.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTopDoctorValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTopDoctorValue.Location = new System.Drawing.Point(79, 46);
            this.lblTopDoctorValue.Name = "lblTopDoctorValue";
            this.lblTopDoctorValue.Size = new System.Drawing.Size(0, 21);
            this.lblTopDoctorValue.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(65, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(107, 21);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "TOP Doctor";
            // 
            // pbpatientsIcon
            // 
            this.pbpatientsIcon.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbpatientsIcon.Image = global::WindowsFormsApp4.Properties.Resources.OIF;
            this.pbpatientsIcon.Location = new System.Drawing.Point(15, 30);
            this.pbpatientsIcon.Name = "pbpatientsIcon";
            this.pbpatientsIcon.Size = new System.Drawing.Size(40, 40);
            this.pbpatientsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbpatientsIcon.TabIndex = 2;
            this.pbpatientsIcon.TabStop = false;
            // 
            // paneltoper
            // 
            this.paneltoper.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paneltoper.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Stock_Photos___Royalty_Free_Images___Adobe_Stock1;
            this.paneltoper.Controls.Add(this.panel2);
            this.paneltoper.Controls.Add(this.labeldatetime);
            this.paneltoper.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltoper.Location = new System.Drawing.Point(198, 0);
            this.paneltoper.Name = "paneltoper";
            this.paneltoper.Size = new System.Drawing.Size(1124, 100);
            this.paneltoper.TabIndex = 60;
            this.paneltoper.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltoper_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._0bb87d92_4971_4d57_9d5a_2b0e6761725b;
            this.panel2.Controls.Add(this.btb);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 30);
            this.panel2.TabIndex = 63;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btb
            // 
            this.btb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btb.BackColor = System.Drawing.Color.Transparent;
            this.btb.ForeColor = System.Drawing.Color.Transparent;
            this.btb.Location = new System.Drawing.Point(1035, 2);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(30, 25);
            this.btb.TabIndex = 19;
            this.btb.UseVisualStyleBackColor = false;
            this.btb.Click += new System.EventHandler(this.btb_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Location = new System.Drawing.Point(1082, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // labeldatetime
            // 
            this.labeldatetime.AutoSize = true;
            this.labeldatetime.BackColor = System.Drawing.Color.Transparent;
            this.labeldatetime.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatetime.Location = new System.Drawing.Point(364, 29);
            this.labeldatetime.Name = "labeldatetime";
            this.labeldatetime.Size = new System.Drawing.Size(548, 36);
            this.labeldatetime.TabIndex = 62;
            this.labeldatetime.Text = "Welcome to Dental Clinic Dashbord";
            this.labeldatetime.Click += new System.EventHandler(this.labeldatetime_Click);
            // 
            // panelsider
            // 
            this.panelsider.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelsider.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Business_Technology_Background_Banner_Design__Wallpaper__Psd__Slogan_Background_Image_And_Wallpaper_for_Free_Download;
            this.panelsider.Controls.Add(this.btn_Treatments);
            this.panelsider.Controls.Add(this.btn_Dashboard);
            this.panelsider.Controls.Add(this.btn_doctor);
            this.panelsider.Controls.Add(this.btn_Invoices);
            this.panelsider.Controls.Add(this.btn_Backup);
            this.panelsider.Controls.Add(this.btn_Logout);
            this.panelsider.Controls.Add(this.plblogo);
            this.panelsider.Controls.Add(this.btnPatient);
            this.panelsider.Controls.Add(this.btn_Appointements);
            this.panelsider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsider.Location = new System.Drawing.Point(0, 0);
            this.panelsider.Name = "panelsider";
            this.panelsider.Size = new System.Drawing.Size(198, 653);
            this.panelsider.TabIndex = 0;
            // 
            // btn_Treatments
            // 
            this.btn_Treatments.BackColor = System.Drawing.Color.Transparent;
            this.btn_Treatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Treatments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Treatments.Location = new System.Drawing.Point(29, 293);
            this.btn_Treatments.Name = "btn_Treatments";
            this.btn_Treatments.Size = new System.Drawing.Size(117, 44);
            this.btn_Treatments.TabIndex = 4;
            this.btn_Treatments.Text = "Treatments";
            this.btn_Treatments.UseVisualStyleBackColor = false;
            this.btn_Treatments.Click += new System.EventHandler(this.btn_Treatments_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Dashboard.Location = new System.Drawing.Point(30, 397);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(114, 45);
            this.btn_Dashboard.TabIndex = 6;
            this.btn_Dashboard.Text = "DASHBORAD";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_doctor
            // 
            this.btn_doctor.BackColor = System.Drawing.Color.Transparent;
            this.btn_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctor.Location = new System.Drawing.Point(30, 344);
            this.btn_doctor.Name = "btn_doctor";
            this.btn_doctor.Size = new System.Drawing.Size(114, 39);
            this.btn_doctor.TabIndex = 3;
            this.btn_doctor.Text = "DOCTOR";
            this.btn_doctor.UseVisualStyleBackColor = false;
            this.btn_doctor.Click += new System.EventHandler(this.btn_doctor_Click);
            // 
            // btn_Invoices
            // 
            this.btn_Invoices.BackColor = System.Drawing.Color.Transparent;
            this.btn_Invoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Invoices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Invoices.Location = new System.Drawing.Point(30, 459);
            this.btn_Invoices.Name = "btn_Invoices";
            this.btn_Invoices.Size = new System.Drawing.Size(114, 39);
            this.btn_Invoices.TabIndex = 7;
            this.btn_Invoices.Text = "INVOICES";
            this.btn_Invoices.UseVisualStyleBackColor = false;
            this.btn_Invoices.Click += new System.EventHandler(this.btn_Invoices_Click);
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Backup.Location = new System.Drawing.Point(30, 519);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(114, 42);
            this.btn_Backup.TabIndex = 8;
            this.btn_Backup.Text = "BACKUP";
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Logout.Location = new System.Drawing.Point(33, 577);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(111, 45);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // plblogo
            // 
            this.plblogo.BackColor = System.Drawing.SystemColors.GrayText;
            this.plblogo.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.OIP;
            this.plblogo.Location = new System.Drawing.Point(-15, 0);
            this.plblogo.Name = "plblogo";
            this.plblogo.Size = new System.Drawing.Size(215, 191);
            this.plblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plblogo.TabIndex = 1;
            this.plblogo.TabStop = false;
            this.plblogo.Click += new System.EventHandler(this.plblogo_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.Location = new System.Drawing.Point(30, 198);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(111, 41);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btn_Appointements
            // 
            this.btn_Appointements.BackColor = System.Drawing.Color.Transparent;
            this.btn_Appointements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Appointements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Appointements.Location = new System.Drawing.Point(30, 248);
            this.btn_Appointements.Name = "btn_Appointements";
            this.btn_Appointements.Size = new System.Drawing.Size(114, 37);
            this.btn_Appointements.TabIndex = 5;
            this.btn_Appointements.Text = "APPOINTEMENT";
            this.btn_Appointements.UseVisualStyleBackColor = false;
            this.btn_Appointements.Click += new System.EventHandler(this.btn_Appointements_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 653);
            this.Controls.Add(this.z);
            this.Controls.Add(this.paneltoper);
            this.Controls.Add(this.panelsider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.z.ResumeLayout(false);
            this.z.PerformLayout();
            this.panelchart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Flpstats.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cardappointment.ResumeLayout(false);
            this.cardappointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cardincome.ResumeLayout(false);
            this.cardincome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.cardTopdoctor.ResumeLayout(false);
            this.cardTopdoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpatientsIcon)).EndInit();
            this.paneltoper.ResumeLayout(false);
            this.paneltoper.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelsider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plblogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsider;
        private System.Windows.Forms.PictureBox plblogo;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btn_doctor;
        private System.Windows.Forms.Button btn_Treatments;
        private System.Windows.Forms.Button btn_Appointements;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Invoices;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel paneltoper;
        private System.Windows.Forms.Label labeldatetime;
        private System.Windows.Forms.Panel z;
        private System.Windows.Forms.FlowLayoutPanel Flpstats;
        private System.Windows.Forms.Panel cardTopdoctor;
        private System.Windows.Forms.PictureBox pbpatientsIcon;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopDoctorValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel cardappointment;
        private System.Windows.Forms.Label lblappointments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel cardincome;
        private System.Windows.Forms.Label lblincomevalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btb;
        private System.Windows.Forms.Button btn_Close;
    }
}