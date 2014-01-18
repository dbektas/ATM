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
    public partial class AccountInfoForm : Form
    {
        GlobalDBConnection gdc = new GlobalDBConnection();
        Show show = new Show();

        public AccountInfoForm()
        {
            InitializeComponent();
        }

        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("ATM_Final");
            ResourceManager rm = new ResourceManager("ATM_Final.Lang.langres", a);

            lbl_FirstAndLastName.Text = rm.GetString("flname", ci);
            lbl_Balance.Text = rm.GetString("balance", ci);
            btn_Back.Text = rm.GetString("back", ci);
            btn_Exit.Text = rm.GetString("exit", ci);
            en_flag.Image = (Image)rm.GetObject("flag", ci);
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gdc.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM [Table] WHERE AccNo = '" + show.AccNo + "'";
                readdata = cmd.ExecuteReader();
                string balanceDB = null;
                string nameDB = null;

                while (readdata.Read())
                {
                    balanceDB = readdata["Balance"].ToString();
                    nameDB = readdata["Name"].ToString();
                }
                con.Close();
                con.Dispose();
                lbl_CurrentBalance.Text += " " + balanceDB.ToString() + " " + "KM";
                lbl_FLName.Text += " " + nameDB.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            WelcomeForm previousForm = new WelcomeForm();
            previousForm.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
