namespace ClinicManagement
{
    partial class FrmPatients
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
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.NationalCode,
            this.LastName,
            this.FullName,
            this.MobileNumber,
            this.ColEdit,
            this.ColDelete});
            this.dgvPatient.Location = new System.Drawing.Point(12, 73);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersWidth = 51;
            this.dgvPatient.RowTemplate.Height = 24;
            this.dgvPatient.Size = new System.Drawing.Size(776, 364);
            this.dgvPatient.TabIndex = 0;
            this.dgvPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellContentClick);
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
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "کدملی";
            this.NationalCode.MinimumWidth = 6;
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            this.NationalCode.Width = 125;
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
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام و خان";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // MobileNumber
            // 
            this.MobileNumber.DataPropertyName = "MobileNumber";
            this.MobileNumber.HeaderText = "شماره موبایل";
            this.MobileNumber.MinimumWidth = 6;
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.ReadOnly = true;
            this.MobileNumber.Width = 125;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "ویرایش";
            this.ColEdit.MinimumWidth = 6;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Width = 125;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "حذف";
            this.ColDelete.MinimumWidth = 6;
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.ReadOnly = true;
            this.ColDelete.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPatient);
            this.Name = "FrmPatients";
            this.Text = "FrmPatient";
            this.Load += new System.EventHandler(this.FrmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.DataGridView dgvPatient;
    }
}