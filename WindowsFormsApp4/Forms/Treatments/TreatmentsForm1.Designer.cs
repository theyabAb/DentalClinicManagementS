namespace WindowsFormsApp4.Forms.Treatments
{
    partial class TreatmentsForm1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btb = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dgvTreatment = new System.Windows.Forms.DataGridView();
            this.colTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtTDesc = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.nudTCost = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTDesc = new System.Windows.Forms.Label();
            this.lblTCost = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTCost)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._1f682bca_30b0_4ff0_a1be_8790733a5c8c;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgvTreatment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(355, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 653);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._7a30d4d9_bcf5_4100_af0f_7678a9ba75d9;
            this.panel3.Controls.Add(this.btb);
            this.panel3.Controls.Add(this.btn_Back);
            this.panel3.Controls.Add(this.btn_Close);
            this.panel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 37);
            this.panel3.TabIndex = 30;
            // 
            // btb
            // 
            this.btb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btb.BackColor = System.Drawing.Color.Transparent;
            this.btb.ForeColor = System.Drawing.Color.Transparent;
            this.btb.Location = new System.Drawing.Point(757, 6);
            this.btb.Name = "btb";
            this.btb.Size = new System.Drawing.Size(25, 25);
            this.btb.TabIndex = 31;
            this.btb.UseVisualStyleBackColor = false;
            this.btb.Click += new System.EventHandler(this.btb_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.IMG_٢٠٢٥١١٣٠_١٧٥٠١٧_٠٥٥١٤٨_2_;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(710, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(30, 30);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.close;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(797, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 31;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dgvTreatment
            // 
            this.dgvTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatment.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTreatment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTID,
            this.colTName,
            this.colTCost,
            this.colTDesc});
            this.dgvTreatment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTreatment.EnableHeadersVisualStyles = false;
            this.dgvTreatment.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTreatment.Location = new System.Drawing.Point(0, 409);
            this.dgvTreatment.Name = "dgvTreatment";
            this.dgvTreatment.ReadOnly = true;
            this.dgvTreatment.RowHeadersVisible = false;
            this.dgvTreatment.RowHeadersWidth = 51;
            this.dgvTreatment.RowTemplate.Height = 26;
            this.dgvTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatment.Size = new System.Drawing.Size(827, 244);
            this.dgvTreatment.TabIndex = 29;
            this.dgvTreatment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreatment_CellContentClick);
            // 
            // colTID
            // 
            this.colTID.HeaderText = "ID";
            this.colTID.MinimumWidth = 6;
            this.colTID.Name = "colTID";
            this.colTID.ReadOnly = true;
            // 
            // colTName
            // 
            this.colTName.HeaderText = "treatment";
            this.colTName.MinimumWidth = 6;
            this.colTName.Name = "colTName";
            this.colTName.ReadOnly = true;
            // 
            // colTCost
            // 
            this.colTCost.HeaderText = "Cost";
            this.colTCost.MinimumWidth = 6;
            this.colTCost.Name = "colTCost";
            this.colTCost.ReadOnly = true;
            // 
            // colTDesc
            // 
            this.colTDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTDesc.HeaderText = "Descriptoin";
            this.colTDesc.MinimumWidth = 6;
            this.colTDesc.Name = "colTDesc";
            this.colTDesc.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Happy_tooth_character_signing_good_with_his_hand_with_transparent_background___Premium_AI_generated_PSD;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTID);
            this.panel1.Controls.Add(this.lblTName);
            this.panel1.Controls.Add(this.txtTName);
            this.panel1.Controls.Add(this.txtTDesc);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.nudTCost);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblTDesc);
            this.panel1.Controls.Add(this.lblTCost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 653);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 40);
            this.label1.TabIndex = 31;
            this.label1.Text = "Treatments Part";
            // 
            // txtTID
            // 
            this.txtTID.Location = new System.Drawing.Point(0, 390);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(111, 24);
            this.txtTID.TabIndex = 5;
            this.txtTID.Visible = false;
            this.txtTID.TextChanged += new System.EventHandler(this.txtTID_TextChanged);
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(12, 70);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(72, 17);
            this.lblTName.TabIndex = 1;
            this.lblTName.Text = "Treatment";
            this.lblTName.Click += new System.EventHandler(this.lblTName_Click);
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(14, 106);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(280, 24);
            this.txtTName.TabIndex = 2;
            this.txtTName.Text = "Enter  Treatment";
            this.txtTName.TextChanged += new System.EventHandler(this.txtTName_TextChanged);
            // 
            // txtTDesc
            // 
            this.txtTDesc.Location = new System.Drawing.Point(0, 263);
            this.txtTDesc.Multiline = true;
            this.txtTDesc.Name = "txtTDesc";
            this.txtTDesc.Size = new System.Drawing.Size(280, 90);
            this.txtTDesc.TabIndex = 4;
            this.txtTDesc.Text = "Description";
            this.txtTDesc.TextChanged += new System.EventHandler(this.txtTDesc_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.search__6_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(318, 578);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nudTCost
            // 
            this.nudTCost.DecimalPlaces = 2;
            this.nudTCost.Location = new System.Drawing.Point(14, 182);
            this.nudTCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTCost.Name = "nudTCost";
            this.nudTCost.Size = new System.Drawing.Size(120, 24);
            this.nudTCost.TabIndex = 3;
            this.nudTCost.ValueChanged += new System.EventHandler(this.nudTCost_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 578);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 24);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(111, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 41);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(2, 581);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(78, 21);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Searche";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(226, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 41);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(1, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 41);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTDesc
            // 
            this.lblTDesc.AutoSize = true;
            this.lblTDesc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDesc.Location = new System.Drawing.Point(11, 220);
            this.lblTDesc.Name = "lblTDesc";
            this.lblTDesc.Size = new System.Drawing.Size(94, 21);
            this.lblTDesc.TabIndex = 3;
            this.lblTDesc.Text = "Description";
            this.lblTDesc.Click += new System.EventHandler(this.lblTDesc_Click);
            // 
            // lblTCost
            // 
            this.lblTCost.AutoSize = true;
            this.lblTCost.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCost.Location = new System.Drawing.Point(11, 145);
            this.lblTCost.Name = "lblTCost";
            this.lblTCost.Size = new System.Drawing.Size(43, 21);
            this.lblTCost.TabIndex = 2;
            this.lblTCost.Text = "Cost";
            this.lblTCost.Click += new System.EventHandler(this.lblTCost_Click);
            // 
            // TreatmentsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreatmentsForm1";
            this.Text = "TreatmentsForm1";
            this.Load += new System.EventHandler(this.TreatmentsForm1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.NumericUpDown nudTCost;
        private System.Windows.Forms.Label lblTCost;
        private System.Windows.Forms.Label lblTDesc;
        private System.Windows.Forms.TextBox txtTDesc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTreatment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTDesc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btb;
        private System.Windows.Forms.TextBox txtTID;
    }
}