using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSMay10.Employee
{
    public partial class EmployeeManagerment : Form
    {
        public EmployeeManagerment()
        {
            InitializeComponent();
        }

        private void EmployeeManagerment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.qLNVDataSet.Employees);

        }

    }
}
