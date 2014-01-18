using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Final
{
    class Show
    {
        private static int accNo;
        public int AccNo
        {
            set
            {
                accNo = value;
            }
            get
            {
                return accNo;
            }
        }
    }
}
