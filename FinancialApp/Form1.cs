using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstCustomControl ControlObject = new FirstCustomControl();
            this.Hide();
            ControlObject.Show();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FirstCustomControl ControlObject = new FirstCustomControl();
            label2.Text = ControlObject.GetUsername();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }
        private void panel3_Paint(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            secondCustomControl1.BringToFront();
        }
    }
}
