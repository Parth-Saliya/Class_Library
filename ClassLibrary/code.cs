using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public partial class code : Form
    {
        public code()
        {
            InitializeComponent();
        }

        public void mdp22(string a, string b, int pt)
        {
            try
            {
                string mn = this.GetType().FullName;
                char o = mn[2];
                if (o == 'p')
                {
                    o = '+';
                }
                if (o == 's')
                {
                    o = '-';
                }
                if (o == 'm')
                {
                    o = '*';
                }
                if (o == 'd')
                {
                    o = '/';
                }

                if (Convert.ToString(a) == null)
                {
                    a = "0";
                }
                if (Convert.ToString(b) == "")
                {
                    b = "0";
                }
                double aa = Convert.ToInt32(a);
                double bb = Convert.ToInt32(b);
                double cc;
                string mdp22out;
                cc = aa + 0 + bb;
                cc = Math.Round(cc, pt);
                mdp22out = cc.ToString();
                MessageBox.Show(mdp22out);
            }
            catch (Exception e)
            {

            }


        }

    }
}
