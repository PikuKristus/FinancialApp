using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FinancialApp
{
    public partial class SecondCustomControl : UserControl
    {
        public SecondCustomControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/gFE-xJr6hIY");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/zO0aBlI9UL8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtu.be/kSTHRvr0qOU");




        }
    }
}
