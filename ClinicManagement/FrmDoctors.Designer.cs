namespace ClinicManagement
{
    partial class FrmDoctors
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
<<<<<<< HEAD
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnEdite = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.FirstName,
            this.LastName,
            this.Specialty,
            this.MedicalCode,
            this.ID});
            this.dgvDoctors.Location = new System.Drawing.Point(70, 63);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(575, 128);
            this.dgvDoctors.TabIndex = 0;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام خانوادگی";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Visible = false;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            this.LastName.Width = 125;
            // 
            // Specialty
            // 
            this.Specialty.DataPropertyName = "Specialty";
            this.Specialty.HeaderText = "متخصص";
            this.Specialty.MinimumWidth = 6;
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            this.Specialty.Width = 125;
            // 
            // MedicalCode
            // 
            this.MedicalCode.DataPropertyName = "MedicalCode";
            this.MedicalCode.HeaderText = "کد نظام پزشکی";
            this.MedicalCode.MinimumWidth = 6;
            this.MedicalCode.Name = "MedicalCode";
            this.MedicalCode.ReadOnly = true;
            this.MedicalCode.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "آیدی";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Location = new System.Drawing.Point(70, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 45);
            this.btnAdd.TabIndex = 1;
=======
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.medicalCouncilNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicalCouncilNumber,
            this.name,
            this.family,
            this.specialties,
            this.DeleteBtn,
            this.EditBtn});
            this.dgvDoctor.Location = new System.Drawing.Point(11, 68);
            this.dgvDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDoctor.RowHeadersWidth = 51;
            this.dgvDoctor.RowTemplate.Height = 24;
            this.dgvDoctor.Size = new System.Drawing.Size(704, 296);
            this.dgvDoctor.TabIndex = 4;
            this.dgvDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctor_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(11, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 5;
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
<<<<<<< HEAD
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemove.Location = new System.Drawing.Point(148, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(57, 45);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(247, 26);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(161, 22);
            this.txtDelete.TabIndex = 3;
            this.txtDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEdite
            // 
            this.btnEdite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdite.Location = new System.Drawing.Point(568, 15);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(93, 42);
            this.btnEdite.TabIndex = 4;
            this.btnEdite.Text = "ویرایش";
            this.btnEdite.UseVisualStyleBackColor = true;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(677, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 22);
            this.txtId.TabIndex = 5;
            // 
            // FrmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 503);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEdite);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDoctors);
            this.Name = "FrmDoctors";
            this.Text = "FrmDoctors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
            // medicalCouncilNumber
            // 
            this.medicalCouncilNumber.DataPropertyName = "medicalCouncilNumber";
            this.medicalCouncilNumber.FillWeight = 150F;
            this.medicalCouncilNumber.HeaderText = "شماره نظام پزشکی";
            this.medicalCouncilNumber.Name = "medicalCouncilNumber";
            this.medicalCouncilNumber.ReadOnly = true;
            this.medicalCouncilNumber.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "FirstName";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // family
            // 
            this.family.DataPropertyName = "LastName";
            this.family.HeaderText = "نام خانوادگی";
            this.family.Name = "family";
            this.family.ReadOnly = true;
            // 
            // specialties
            // 
            this.specialties.DataPropertyName = "FullSpecialties";
            this.specialties.HeaderText = "تخصص ها";
            this.specialties.Name = "specialties";
            this.specialties.ReadOnly = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.HeaderText = "حذف";
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ReadOnly = true;
            // 
            // EditBtn
            // 
            this.EditBtn.HeaderText = "ویرایش";
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ReadOnly = true;
            // 
            // FrmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 375);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmDoctors";
            this.Text = "FrmDoctors";
            this.Load += new System.EventHandler(this.FrmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnEdite;
        private System.Windows.Forms.TextBox txtId;
=======
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalCouncilNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialties;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
        private System.Windows.Forms.DataGridViewButtonColumn EditBtn;
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
    }
}