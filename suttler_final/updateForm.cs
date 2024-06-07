using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace last_final
{
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            string userIn = textBox1.Text;

            string newname = name.Text;



            string Query = "UPDATE Player SET name = '" + newname + "' WHERE stdId = '" + userIn + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Player Name Updated Successfully");


        }

        private void search_Click(object sender, EventArgs e)
        {

        }

      

        private void update3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            string userIn = textBox1.Text;

            string newemail = email.Text;

            string Query = "UPDATE Player SET email = '" + newemail + "' WHERE stdId = '" + userIn + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Player Email Updated Successfully");
        }

       

        private void update2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            string userIn = textBox1.Text;

            string newtelephone = telephone.Text;

            string Query = "UPDATE Player SET telephone = '" + newtelephone + "' WHERE stdId = '" + userIn + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Player Contact Number Updated Successfully");
        }

        private void update3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            string userIn = textBox1.Text;

            string newemail = email.Text;

            string Query = "UPDATE Player SET email = '" + newemail + "' WHERE stdId = '" + userIn + "' ";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Player Email Updated Successfully");
        }
    }
}
