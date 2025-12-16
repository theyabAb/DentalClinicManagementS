namespace WindowsFormsApp4.Forms.Invoices
{
    partial class InvoicesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtInvID = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dtbDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btb = new System.Windows.Forms.Button();
            this.btn_Closed = new System.Windows.Forms.Button();
            this.tbn_Back = new System.Windows.Forms.Button();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.colInvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 711);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 711);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.nudTotal);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.txtInvID);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Controls.Add(this.dtbDate);
            this.panel3.Controls.Add(this.btnDeleteInvoice);
            this.panel3.Controls.Add(this.lblPatient);
            this.panel3.Controls.Add(this.cmbPatient);
            this.panel3.Controls.Add(this.btnAddInvoice);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.cmbTreatment);
            this.panel3.Controls.Add(this.lblTreatment);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 711);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.checklist__1_;
            this.pictureBox1.Location = new System.Drawing.Point(58, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Location = new System.Drawing.Point(15, 474);
            this.nudTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(150, 26);
            this.nudTotal.TabIndex = 4;
            this.nudTotal.ValueChanged += new System.EventHandler(this.nudTotal_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(89, 661);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 26);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtInvID
            // 
            this.txtInvID.Location = new System.Drawing.Point(169, 217);
            this.txtInvID.Name = "txtInvID";
            this.txtInvID.Size = new System.Drawing.Size(100, 26);
            this.txtInvID.TabIndex = 25;
            this.txtInvID.Visible = false;
            this.txtInvID.TextChanged += new System.EventHandler(this.txtInvID_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(15, 665);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(78, 21);
            this.lblSearch.TabIndex = 30;
            this.lblSearch.Text = "Searche";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // dtbDate
            // 
            this.dtbDate.Location = new System.Drawing.Point(12, 404);
            this.dtbDate.Name = "dtbDate";
            this.dtbDate.Size = new System.Drawing.Size(260, 26);
            this.dtbDate.TabIndex = 3;
            this.dtbDate.ValueChanged += new System.EventHandler(this.dtbDate_ValueChanged);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteInvoice.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.delete;
            this.btnDeleteInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteInvoice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(15, 590);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(131, 40);
            this.btnDeleteInvoice.TabIndex = 24;
            this.btnDeleteInvoice.Text = "Delete";
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.Location = new System.Drawing.Point(11, 234);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(62, 21);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "patient";
            this.lblPatient.Click += new System.EventHandler(this.lblPatient_Click);
            // 
            // cmbPatient
            // 
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(12, 258);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(260, 26);
            this.cmbPatient.TabIndex = 2;
            this.cmbPatient.SelectedIndexChanged += new System.EventHandler(this.cmbPatient_SelectedIndexChanged);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddInvoice.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.plus;
            this.btnAddInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddInvoice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddInvoice.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddInvoice.Location = new System.Drawing.Point(15, 540);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(131, 40);
            this.btnAddInvoice.TabIndex = 23;
            this.btnAddInvoice.Text = "CreateInvoice";
            this.btnAddInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddInvoice.UseVisualStyleBackColor = false;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(15, 450);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 21);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 380);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(12, 335);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(260, 26);
            this.cmbTreatment.TabIndex = 3;
            this.cmbTreatment.SelectedIndexChanged += new System.EventHandler(this.cmbTreatment_SelectedIndexChanged);
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(11, 311);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(88, 21);
            this.lblTreatment.TabIndex = 2;
            this.lblTreatment.Text = "Treatment";
            this.lblTreatment.Click += new System.EventHandler(this.lblTreatment_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.search__5_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(278, 658);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._1f682bca_30b0_4ff0_a1be_8790733a5c8c;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.dgvInvoices);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(357, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 711);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._0bb87d92_4971_4d57_9d5a_2b0e6761725b;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btb);
            this.panel5.Controls.Add(this.btn_Closed);
            this.panel5.Controls.Add(this.tbn_Back);
            this.panel5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel5.Location = new System.Drawing.Point(3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(834, 26);
            this.panel5.TabIndex = 35;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btb
            // 
            this.btb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btb.BackColor = System.Drawing.Color.Transparent;
            this.btb.ForeColor = System.Drawing.Color.Transparent;
            this.btb.Location = new System.Drawing.Point(767, -1);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(25, 25);
            this.btb.TabIndex = 36;
            this.btb.UseVisualStyleBackColor = false;
            this.btb.Click += new System.EventHandler(this.btb_Click);
            // 
            // btn_Closed
            // 
            this.btn_Closed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Closed.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.close;
            this.btn_Closed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Closed.Location = new System.Drawing.Point(807, -1);
            this.btn_Closed.Name = "btn_Closed";
            this.btn_Closed.Size = new System.Drawing.Size(25, 25);
            this.btn_Closed.TabIndex = 34;
            this.btn_Closed.UseVisualStyleBackColor = true;
            this.btn_Closed.Click += new System.EventHandler(this.btn_Closed_Click);
            // 
            // tbn_Back
            // 
            this.tbn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbn_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbn_Back.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.IMG_٢٠٢٥١١٣٠_١٧٥٠١٧_٠٥٥١٤٨_2_;
            this.tbn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tbn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbn_Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbn_Back.Location = new System.Drawing.Point(728, -1);
            this.tbn_Back.Name = "tbn_Back";
            this.tbn_Back.Size = new System.Drawing.Size(25, 25);
            this.tbn_Back.TabIndex = 26;
            this.tbn_Back.UseVisualStyleBackColor = false;
            this.tbn_Back.Click += new System.EventHandler(this.tbn_Back_Click);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvID,
            this.colPatient,
            this.colTreatment,
            this.colDate,
            this.colTotal});
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInvoices.EnableHeadersVisualStyles = false;
            this.dgvInvoices.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvInvoices.Location = new System.Drawing.Point(0, 525);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.RowTemplate.Height = 26;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(840, 184);
            this.dgvInvoices.TabIndex = 33;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            // 
            // colInvID
            // 
            this.colInvID.HeaderText = "ID";
            this.colInvID.MinimumWidth = 6;
            this.colInvID.Name = "colInvID";
            this.colInvID.ReadOnly = true;
            // 
            // colPatient
            // 
            this.colPatient.HeaderText = "Patient";
            this.colPatient.MinimumWidth = 6;
            this.colPatient.Name = "colPatient";
            this.colPatient.ReadOnly = true;
            // 
            // colTreatment
            // 
            this.colTreatment.HeaderText = "Treatment";
            this.colTreatment.MinimumWidth = 6;
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 711);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoicesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbTreatment;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtbDate;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Button tbn_Back;
        private System.Windows.Forms.Button btn_Closed;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btb;
        private System.Windows.Forms.TextBox txtInvID;
    }
}