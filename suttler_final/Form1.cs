using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            //userControl11.Hide();
            //userControl21.Show();
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.Show();
        }

        private void shuttler_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
