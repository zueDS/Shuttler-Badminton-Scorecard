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
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adap;

            try
            {
                con.Open();

                string userIn = searchBox.Text;


                rstdId.Text = userIn;


                //name
                string cmdst1 = "SELECT name FROM Player WHERE stdId = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst1, con);
                DataSet ds1 = new DataSet();
                adap.Fill(ds1);
                rname.Text = ds1.Tables[0].Rows[0][0].ToString();

                //age
                string cmdst2 = "SELECT FLOOR(DATEDIFF(DAY, (SELECT birthday FROM Player WHERE stdId = '" + userIn + "'), GETDATE()) / 365.25) FROM Player WHERE stdId = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst2, con);
                DataSet ds2 = new DataSet();
                adap.Fill(ds2);
                rage.Text = ds2.Tables[0].Rows[0][0].ToString();



                //telephone
                string cmdst3 = "SELECT telephone FROM Player WHERE stdId = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst3, con);
                DataSet ds3 = new DataSet();
                adap.Fill(ds3);
                rtelephone.Text = ds3.Tables[0].Rows[0][0].ToString();

                //playing style
                string cmdst4 = "SELECT pstyle FROM Player WHERE stdId = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst4, con);
                DataSet ds4 = new DataSet();
                adap.Fill(ds4);
                rpstyle.Text = ds4.Tables[0].Rows[0][0].ToString();

                
                //winning perc
                string cmdst52 = "SELECT COUNT(*) FROM match WHERE player1 = '" + userIn + "' OR player2 = '" + userIn + "'";
                string cmdst53 = "SELECT COUNT(*) FROM match WHERE win = '" + userIn + "'";

                adap = new SqlDataAdapter(cmdst52, con);
                DataSet ds52 = new DataSet();
                adap.Fill(ds52);

                adap = new SqlDataAdapter(cmdst53, con);
                DataSet ds53 = new DataSet();
                adap.Fill(ds53);

               
                string totalm = ds52.Tables[0].Rows[0][0].ToString();
                string winm = ds53.Tables[0].Rows[0][0].ToString();

                //double avg = (Double.Parse(winm) / Double.Parse(totalm)) * 100;
                double avg = Math.Round((Double.Parse(winm) / Double.Parse(totalm)) * 100,2);

                rwpercentage.Text = $"{avg}%";
                
                //Console.WriteLine(avg);



                //current rank
                //string cmdst6 = "SELECT crank FROM Player WHERE stdId = '" + userIn + "'";
                //adap = new SqlDataAdapter(cmdst6, con);
                //DataSet ds6 = new DataSet();
                //adap.Fill(ds6);
                //rcrank.Text = ds6.Tables[0].Rows[0][0].ToString();


                //gender
                string cmdst7 = "SELECT gender FROM Player WHERE stdId = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst7, con);
                DataSet ds7 = new DataSet();
                adap.Fill(ds7);
                rgender.Text = ds7.Tables[0].Rows[0][0].ToString();


                //email
                string cmdst8 = "SELECT email FROM Player WHERE stdId = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst8, con);
                DataSet ds8 = new DataSet();
                adap.Fill(ds8);
                remail.Text = ds8.Tables[0].Rows[0][0].ToString();


                //total matches
                string cmdst9 = "SELECT COUNT(*) FROM match WHERE player1 = '" + userIn + "' OR player2 = '" + userIn + "'";
                adap = new SqlDataAdapter(cmdst9, con);
                DataSet ds9 = new DataSet();
                adap.Fill(ds9);
                rtmatches.Text = ds9.Tables[0].Rows[0][0].ToString();


                //highest rank
                //string cmdst10 = "SELECT hrank FROM Player WHERE stdId = '" + userIn + "'";
                //adap = new SqlDataAdapter(cmdst10, con);
                //DataSet ds10 = new DataSet();
                //adap.Fill(ds10);
                //rhrank.Text = ds10.Tables[0].Rows[0][0].ToString();

                pictureBox1.Hide();
                panel1.Hide();
                //updateUC updateUC = new updateUC();
                //updateUC.Hide();
                
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please Enter a valid Student Id");
            }

            catch (SqlException)
            {
               //MessageBox.Show($"{ex}");
               MessageBox.Show("Error !");
            }



            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5) //change the number of images
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

       

        private void edit_Click(object sender, EventArgs e)
        {

            panel1.Show();
            pictureBox1.Hide();
            updateForm updateUC = new updateForm();
            updateUC.Show();
            updateUC.BringToFront();
            

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stdId_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click_1(object sender, EventArgs e)
        {

           
            pictureBox1.Hide();
            updateForm updateUC = new updateForm();
            updateUC.Show();
            updateUC.BringToFront();
            updateUC.Visible = true;
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();
                string userIn = searchBox.Text;
                string sql = "DELETE FROM Player WHERE stdId = '" + userIn + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Player Profile Deleted Successfully");
            }

            catch
            {
                MessageBox.Show("Error !");
            }
            con.Close();
            panel1.Show();
            pictureBox1.Show();
        }

        private void edit_Click_2(object sender, EventArgs e)
        {
            updateForm updateUC = new updateForm();
            updateUC.StartPosition = FormStartPosition.CenterScreen;
            updateUC.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }
    }
}
