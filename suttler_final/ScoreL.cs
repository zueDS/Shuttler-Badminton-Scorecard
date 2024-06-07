using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_final
{
    public class ScoreInc : score
    {
        override public void scr(Label x)
        {
            int iCount = Convert.ToInt32(x.Text);
            if (iCount < 30)
            {
                for (iCount = Convert.ToInt32(x.Text); iCount <= 30;)
                {

                    iCount++;
                    x.Text = iCount.ToString();
                    break;

                }
            }
        }

    }
    public class ScoreDec : score
    {
        override public void scr(Label x)
        {
            int iCount = Convert.ToInt32(x.Text);
            if (iCount > 0)
            {
                for (iCount = Convert.ToInt32(x.Text); iCount >= 0;)
                {

                    iCount--;
                    x.Text = iCount.ToString();
                    break;

                }
            }
        }
    }
}
