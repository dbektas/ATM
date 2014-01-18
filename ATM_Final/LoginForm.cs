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
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace ATM_Final
{
    public partial class LoginForm : Form
    {
        //Global database connection
        GlobalDBConnection gdc = new GlobalDBConnection();
        Show show = new Show();

        public LoginForm()
        {
            InitializeComponent();
            txt_PIN.PasswordChar = '*';
            txt_PIN.MaxLength = 4;
            txt_CardID.MaxLength = 4;
        }

        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("ATM_Final");
            ResourceManager rm = new ResourceManager("ATM_Final.Lang.langres", a);

            lbl_SelectLang.Text = rm.GetString("selectlang", ci);
            lbl_CardID.Text = rm.GetString("cardid", ci);
            lbl_PIN.Text = rm.GetString("pin", ci);
            en_flag.Image = (Image)rm.GetObject("flag", ci);
            btn_Login.Text = rm.GetString("login", ci);
            btn_Exit.Text = rm.GetString("exit", ci);


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gdc.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                int account = int.Parse(txt_CardID.Text);
                int pin = int.Parse(txt_PIN.Text);
                int accountDB = 0;
                int pinDB = 0;
                string name = null;
                cmd.CommandText = "SELECT * FROM [Table] WHERE AccNo = '" + account + "'";
                readdata = cmd.ExecuteReader();
                while (readdata.Read())
                {
                    accountDB = int.Parse(readdata["AccNo"].ToString());
                    pinDB = int.Parse(readdata["PIN"].ToString());
                    name = readdata["Name"].ToString();
                }
                con.Close();
                con.Dispose();

                if ((account == accountDB) && (pin == pinDB))
                {
                    MessageBox.Show("Welcome: " + name);
                    show.AccNo = accountDB;

                    WelcomeForm Welcome = new WelcomeForm();
                    Welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cannot find an account! Please try again!");
                    txt_CardID.Clear();
                    txt_PIN.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_enflag_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            getRes(ci);
        }

        private void btn_bsflag_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("hr-HR");
            getRes(ci);
        }    
    }
}
