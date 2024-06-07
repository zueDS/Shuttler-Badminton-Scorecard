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
    public partial class AddPlayer : Form
    {
        //static string databaseName = "playerdb.mdf";

       // string connectionString = @"Data Source(localdb)\MSSQLLocalDB; AttachFilename=" + (Environment.CurrentDirectory) + @"\" + databaseName + "; Integrated Security=True;";
        public AddPlayer()
        {

            InitializeComponent();
        }

        private void getAllPlayerData()
        {
        }

        string gender;
        string pstyle;
       

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void lhand_CheckedChanged(object sender, EventArgs e)
        {
            pstyle = "Left Hander";
        }

        private void rhand_CheckedChanged(object sender, EventArgs e)
        {
            pstyle = "Right Hander";
        }
        public void save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //string sId = stdId.Text, sname = name.Text, sbirthday = this.dateTimePicker1.Text, sgender = gender, stelephone = telephone.Text, semail = email.Text, spstyle = pstyle;
                //cmd.CommandText = "insert into Player(stdId, name, birthday, gender,telephone, email, pstyle) values('" + sId + "', '" + sname + "', '" + sbirthday + "', '" + sgender + "', '" + stelephone + "', '" + semail + "', '" + spstyle + "')";
                cmd.CommandText = "insert into Player(stdId, name, birthday, gender,telephone, email, pstyle) values('" + stdId.Text + "', '" + name.Text + "', '" + this.dateTimePicker1.Text + "', '" + gender + "', '" + telephone.Text + "', '" + email.Text + "', '" + pstyle + "')";
                cmd.ExecuteNonQuery();
                //name.Text = "";

            }
            catch (SqlException)
            {
                Console.WriteLine("Error Generated! Please Check Again.");
            }
            //finally

            con.Close();
            MessageBox.Show("Data Successfully Added");
            this.Controls.Clear();
            this.InitializeComponent();

            //clearData objcl = new clearData();
            //objcl.clearForm();


        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
