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
    public partial class Scoreboard : Form
    {
        string winner;
        bool thirdSet;
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void btnScrL_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();
                SqlDataAdapter adap;
                string cmdst = "select name from Player where stdId ='" + txtPnL.Text + "'";
                adap = new SqlDataAdapter(cmdst, con);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                lblPnameL.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please Enter a valid Student Id");
            }

            con.Close();

            lblPnameL.Visible = true;
        }

        private void btnScrR_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                SqlDataAdapter adap;
                con.Open();

                string cmdst = "select name from Player where stdId ='" + txtPnR.Text + "'";
                adap = new SqlDataAdapter(cmdst, con);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                lblPnameR.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please Enter a valid Student Id");
            }

            con.Close();

            lblPnameR.Visible = true;
        }

        private void lblDecL_Click(object sender, EventArgs e)
        {
            score scr = new ScoreDec();
            scr.scr(lblSL);
            //int iCount = Convert.ToInt32(lblSL.Text);
            //if (iCount > 0)
            //{
            //    for (iCount = Convert.ToInt32(lblSL.Text); iCount >= 0;)
            //    {

            //        iCount--;
            //        lblSL.Text = iCount.ToString();
            //        break;

            //    }
            //}
        }

        private void btnInl_Click(object sender, EventArgs e)
        {
            score scr = new ScoreInc();
            scr.scr(lblSL);

            //int iCount = Convert.ToInt32(lblSL.Text);
            //if (iCount < 30)
            //{
            //    for (iCount = Convert.ToInt32(lblSL.Text); iCount <= 30;)
            //    {

            //        iCount++;
            //        lblSL.Text = iCount.ToString();
            //        break;

            //    }
            //}
        }

        private void btnClrL_Click(object sender, EventArgs e)
        {
            //lblWon.Visible = false;
            lblSL.Text = "0";
            //lblSetL.Text = "0";
        }

        private void lblDecR_Click(object sender, EventArgs e)
        {
            score scr = new ScoreDec();
            scr.scr(lblSR);
            //int iCount = Convert.ToInt32(lblSR.Text);
            //if (iCount > 0)
            //{
            //    for (iCount = Convert.ToInt32(lblSR.Text); iCount >= 0;)
            //    {

            //        iCount--;
            //        lblSR.Text = iCount.ToString();
            //        break;

            //    }
            //}
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            score scr = new ScoreInc();
            scr.scr(lblSR);
            //int iCount = Convert.ToInt32(lblSR.Text);
            //if (iCount < 30)
            //{
            //    for (iCount = Convert.ToInt32(lblSR.Text); iCount <= 30;)
            //    {

            //        iCount++;
            //        lblSR.Text = iCount.ToString();
            //        break;

            //    }
            //}
        }

        private void btnClR_Click(object sender, EventArgs e)
        {
            //lblWon.Visible = false;
            lblSR.Text = "0";
            //lblSetR.Text = "0";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //lblWon.Visible = false;
            //set1.Visible = false;
            //set2.Visible = false;
            //set3.Visible = false;
            //lblSR.Text = "0";
            //lblSetR.Text = "0";
            //lblSL.Text = "0";
            //lblSetL.Text = "0";
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Paagoorz\Shuttler\playerdb.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into match values('" + setName.Text + "', '" + s1lbl3.Text + "', '" + s2lbl3.Text + "', '" + s3lbl3.Text + "', '" + s1lbl4.Text + "', '" + s2lbl4.Text + "', '" + s3lbl4.Text + "', '" + txtPnL.Text + "', '" + txtPnR.Text + "', '" + lblIndex.Text + "')";
            //cmd.CommandText = "insert into match(p1s1, p1s2, p1s3, p2s1, p2s2, p2s3, player1, player2, win) values('" + s1lbl3.Text + "', '" + s2lbl3.Text + "', '" + s3lbl3.Text + "', '" + s1lbl4.Text + "', '" + s2lbl4.Text + "', '" + s3lbl4.Text + "', '" + txtPnL.Text + "', '" + txtPnR.Text + "', '" + lblIndex.Text + "')";
            cmd.ExecuteNonQuery();

            //-----------------------------------------

            //-----------------------------------------

            con.Close();

            MessageBox.Show("Data Successfully Added");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(lblSL.Text);
            int sr = Convert.ToInt32(lblSR.Text);
            int setL = Convert.ToInt32(lblSetL.Text);
            int setR = Convert.ToInt32(lblSetR.Text);
            int count = 0;

            if ((sl >= 21) || (sr >= 21))
            {

                if (sr < sl)
                {
                    for (setL = Convert.ToInt32(lblSetL.Text); setL < 2;)
                    {

                        setL++;
                        lblSetL.Text = setL.ToString();
                        break;

                    }
                }


                if (sl < sr)
                {
                    for (setR = Convert.ToInt32(lblSetR.Text); setR < 2;)
                    {

                        setR++;
                        lblSetR.Text = setR.ToString();
                        break;

                    }
                }

                if (set1.Visible == true)
                {

                    count = 2;

                }
                else
                {
                    if ((setL == 1) || (setR == 1))
                    {
                        count = 1;
                        if (count == 1)
                        {
                            set1.Visible = true;
                            // set1.Text = setName.Text;
                            s1lbl1.Text = lblPnameL.Text;
                            s1lbl2.Text = lblPnameR.Text;
                            s1lbl3.Text = lblSL.Text;
                            s1lbl4.Text = lblSR.Text;
                        }
                    }
                }

                if (set2.Visible == true)
                {
                    if (thirdSet == true)
                    {
                        set3.Visible = true;
                        // set3.Text = setName.Text;
                        s3lbl1.Text = lblPnameL.Text;
                        s3lbl2.Text = lblPnameR.Text;
                        s3lbl3.Text = lblSL.Text;
                        s3lbl4.Text = lblSR.Text;
                    }
                    //else
                    //{

                    //}

                    //count = 3;
                    //if (count == 3)
                    //{
                    //    set3.Visible = true;
                    //   // set3.Text = setName.Text;
                    //    s3lbl1.Text = txtPnL.Text;
                    //    s3lbl2.Text = txtPnR.Text;
                    //    s3lbl3.Text = lblSL.Text;
                    //    s3lbl4.Text = lblSR.Text;
                    //}

                }
                else
                {
                    if ((setL == 2) || ((setL == 1) && (setR == 1)))
                    {
                        count = 2;
                        //lblWon.Visible = true;
                        //lblWon.Text = "WINNER : " + txtPnL.Text;
                        if (count == 2)
                        {
                            set2.Visible = true;
                            //set2.Text = setName.Text;
                            s2lbl1.Text = lblPnameL.Text;
                            s2lbl2.Text = lblPnameR.Text;
                            s2lbl3.Text = lblSL.Text;
                            s2lbl4.Text = lblSR.Text;
                        }
                    }
                    if ((setR == 2) || ((setL == 1) && (setR == 1)))
                    {
                        count = 2;
                        //lblWon.Visible = true;
                        //lblWon.Text = "WINNER : " + txtPnR.Text;
                        if (count == 2)
                        {
                            set2.Visible = true;
                            //set2.Text = setName.Text;
                            s2lbl1.Text = lblPnameL.Text;
                            s2lbl2.Text = lblPnameR.Text;
                            s2lbl3.Text = lblSL.Text;
                            s2lbl4.Text = lblSR.Text;
                        }
                    }
                    if ((setL == 1) && (setR == 1)) { thirdSet = true; }

                }


                if (setL == 2)
                {
                    winner = lblPnameL.Text;
                    lblWon.Visible = true;
                    lblWon.Text = "WINNER : " + winner;
                    lblIndex.Text = txtPnL.Text;
                }
                if (setR == 2)
                {
                    winner = lblPnameR.Text;
                    lblWon.Visible = true;
                    lblWon.Text = "WINNER : " + winner;
                    lblIndex.Text = txtPnR.Text;
                }
                //---------------------------------

            }
        }
    }
}
