using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {

        public void mdp22(string a,string b,int pt)
        {
            try
            {
                string mn = this.GetType().FullName;
                char o = mn[2];
                if(o == 'p')
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
                cc = aa +0+ bb;
                cc = Math.Round(cc, pt);
                mdp22out = cc.ToString();
            }
            catch(Exception e)
            {

            }
            

        }


        public void cal(char op, int no, double a, double b, int pt)
        {
            string calOut;
            if (no == 2)
            {
                try
                {
                    if (Convert.ToString(a) == null)
                    {
                        a = 0;
                    }
                    if (Convert.ToString(b) == "")
                    {
                        b = 0;
                    }
                    double c;
                    switch (op)
                    {

                        case '+':
                            c = a + b;
                            calOut = c.ToString();
                            c = Math.Round(c, pt);

                            break;
                        case '-':
                            c = a - b;
                            calOut = c.ToString();
                            c = Math.Round(c, pt);
                            break;
                        case '*':
                            c = a * b;
                            calOut = c.ToString();
                            c = Math.Round(c, pt);
                            break;
                        case '/':
                            c = a / b;
                            c = Math.Round(c, pt);
                            calOut = c.ToString();

                            break;
                    }

                }
                catch (Exception e)
                {

                }
            }

        }

    }
}
