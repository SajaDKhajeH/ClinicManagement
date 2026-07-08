namespace ClinicManagement
{
    partial class Frmdoctors
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
            this.dgvDrs = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicallcouncil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldelet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.coledit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDrs
            // 
            this.dgvDrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.lastname,
            this.medicallcouncil,
            this.specialties,
            this.coldelet,
            this.coledit,
            this.ID});
            this.dgvDrs.Location = new System.Drawing.Point(21, 76);
            this.dgvDrs.Name = "dgvDrs";
            this.dgvDrs.RowHeadersWidth = 51;
            this.dgvDrs.RowTemplate.Height = 24;
            this.dgvDrs.Size = new System.Drawing.Size(905, 360);
            this.dgvDrs.TabIndex = 0;
            this.dgvDrs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrs_CellContentClick);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(21, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 42);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "LastName";
            this.lastname.HeaderText = "نام خانوادگی";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.Width = 125;
            // 
            // medicallcouncil
            // 
            this.medicallcouncil.DataPropertyName = "MedicalCouncil";
            this.medicallcouncil.HeaderText = "شماره نظام پزشکی";
            this.medicallcouncil.MinimumWidth = 6;
            this.medicallcouncil.Name = "medicallcouncil";
            this.medicallcouncil.Width = 125;
            // 
            // specialties
            // 
            this.specialties.DataPropertyName = "Specialties";
            this.specialties.HeaderText = "تخصص ها";
            this.specialties.MinimumWidth = 6;
            this.specialties.Name = "specialties";
            this.specialties.Width = 125;
            // 
            // coldelet
            // 
            this.coldelet.HeaderText = "حذف";
            this.coldelet.MinimumWidth = 6;
            this.coldelet.Name = "coldelet";
            this.coldelet.Width = 125;
            // 
            // coledit
            // 
            this.coledit.HeaderText = "ویرایش";
            this.coledit.MinimumWidth = 6;
            this.coledit.Name = "coledit";
            this.coledit.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Frmdoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 473);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvDrs);
            this.Name = "Frmdoctors";
            this.Text = "Frmdoctors";
            this.Load += new System.EventHandler(this.Frmdoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDrs;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicallcouncil;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialties;
        private System.Windows.Forms.DataGridViewButtonColumn coldelet;
        private System.Windows.Forms.DataGridViewButtonColumn coledit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}