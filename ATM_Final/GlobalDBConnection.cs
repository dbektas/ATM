using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Final
{
    class GlobalDBConnection
    {
        //Connection to database
        private string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Accounts.mdf;Integrated Security=True;";
        /*User Instance = True;*/

        public string Con
        {
            get
            {
                return con;
            }
        }

    }
}
