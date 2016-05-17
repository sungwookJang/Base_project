using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmNumLib
{
    public class ConfirmNum
    {
        public static string AuthNum
        {
            get
            {
                Random rand = new Random();
                string auth_num = string.Format("{0}{1}{2}{3}{4}", rand.Next(9), rand.Next(9), rand.Next(9), rand.Next(9), rand.Next(9));
                return auth_num;
            }
        }
    }
}
