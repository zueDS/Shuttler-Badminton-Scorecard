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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 3) //change the number of images
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            ReadForm readForm = new ReadForm();
            readForm.StartPosition = FormStartPosition.CenterScreen;
            readForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (count < 3) //change the number of images
            {
                pictureBox1.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void player_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer();
            addPlayer.StartPosition = FormStartPosition.CenterScreen;
            addPlayer.ShowDialog();
        }

        private void scoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.StartPosition = FormStartPosition.CenterScreen;
            scoreboard.ShowDialog();
            
        }
    }
}
