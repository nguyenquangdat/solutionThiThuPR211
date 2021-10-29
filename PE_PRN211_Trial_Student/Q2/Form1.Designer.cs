
namespace Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.nupSalary = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdFeMale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(31, 30);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(417, 335);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.mtbPhone);
            this.groupBox1.Controls.Add(this.nupSalary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdFeMale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(490, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(116, 203);
            this.mtbPhone.Mask = "000-0000-000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(142, 23);
            this.mtbPhone.TabIndex = 5;
            // 
            // nupSalary
            // 
            this.nupSalary.Location = new System.Drawing.Point(116, 160);
            this.nupSalary.Name = "nupSalary";
            this.nupSalary.Size = new System.Drawing.Size(120, 23);
            this.nupSalary.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdFeMale
            // 
            this.rdFeMale.AutoSize = true;
            this.rdFeMale.Location = new System.Drawing.Point(236, 115);
            this.rdFeMale.Name = "rdFeMale";
            this.rdFeMale.Size = new System.Drawing.Size(63, 19);
            this.rdFeMale.TabIndex = 2;
            this.rdFeMale.TabStop = true;
            this.rdFeMale.Text = "Female";
            this.rdFeMale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(116, 115);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(51, 19);
            this.rdMale.TabIndex = 2;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployeeName";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(116, 61);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(195, 23);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.NumericUpDown nupSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdFeMale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
    }
}

