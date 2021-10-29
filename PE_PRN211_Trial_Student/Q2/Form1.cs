using Q2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int EmID;
        private void button3_Click(object sender, EventArgs e)
        {
            PE_PRN_Sum21Context pe = new PE_PRN_Sum21Context();
            var em = pe.Employees.Where(x => x.EmployeeId == EmID).FirstOrDefault();
            pe.Employees.Remove(em);
            pe.SaveChanges();
            load();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       public void load()
        {
            PE_PRN_Sum21Context pe = new PE_PRN_Sum21Context();
            var employees = pe.Employees.ToList();
            txtEmployeeName.DataBindings.Clear();
            nupSalary.DataBindings.Clear();
            mtbPhone.DataBindings.Clear();
            if (rdMale.Checked)
            {
                rdMale.Checked = true;
            }
           
            txtEmployeeName.DataBindings.Add("Text", employees, "EmployeeName");
            nupSalary.DataBindings.Add("Text", employees, "Salary");
            mtbPhone.DataBindings.Add("Text", employees, "Phone");
            rdFeMale.Checked = true;
            rdMale.Checked = true;
            dgvEmployee.DataSource = employees;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PE_PRN_Sum21Context pe = new PE_PRN_Sum21Context();
            Employee em = new Employee();
            em.EmployeeName = txtEmployeeName.Text;
            string gender = rdMale.Checked ? "Male" : "Female";
            if (gender.Equals("Male"))
            {
                em.Male = true;
            }
            else
            {
                em.Male = false;
            }
            em.Salary = float.Parse(nupSalary.Value.ToString());
            em.Phone = mtbPhone.Text;
            pe.Employees.Add(em);
            pe.SaveChanges();
            load();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmID = int.Parse(dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PE_PRN_Sum21Context pe = new PE_PRN_Sum21Context();
            var em = pe.Employees.Where(x => x.EmployeeId == EmID).FirstOrDefault();
            em.EmployeeName = txtEmployeeName.Text;
            string gender = rdMale.Checked ? "Male" : "Female";
            if (gender.Equals("Male"))
            {
                em.Male = true;
            }
            else
            {
                em.Male = false;
            }
            em.Salary = float.Parse(nupSalary.Value.ToString());
            em.Phone = mtbPhone.Text;
           // pe.Employees.Add(em);
            pe.SaveChanges();
            load();
        }
    }
}
