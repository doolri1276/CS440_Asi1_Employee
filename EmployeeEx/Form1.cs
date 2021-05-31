using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputePay_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.HoursWorked = int.Parse(txtHourseWorked.Text);
            employee.PayRate = double.Parse(txtPayRate.Text);
            MessageBox.Show("Pay : " + employee.ComputePayAndOverTimePay());
        }
    }
}
