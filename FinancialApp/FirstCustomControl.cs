using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialApp
{
    public partial class FirstCustomControl : UserControl
    {
        string Username;
        double Salary;

        public FirstCustomControl()
        {
            InitializeComponent();
        }

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Username = textBox1.Text;
        }

        public string GetUsername()
        {
            return Username;
        }

        public double GetSalary()
        {
            return Salary;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Salary = Convert.ToDouble(textBox2.Text);
        }
    }
}
