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
    public partial class ChangePINForm : Form
    {
        GlobalDBConnection gdc = new GlobalDBConnection();
        Show show = new Show();

        public ChangePINForm()
        {
            InitializeComponent();
            txt_OldPIN.MaxLength = 4;
            txt_OldPIN.PasswordChar = '*';
            txt_NewPIN.MaxLength = 4;
            txt_NewPIN.PasswordChar = '*';     
        }

        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("ATM_Final");
            ResourceManager rm = new ResourceManager("ATM_Final.Lang.langres", a);

            lbl_OldPIN.Text = rm.GetString("oldpin", ci);
            lbl_NewPIN.Text = rm.GetString("newpin", ci);
            btn_Back.Text = rm.GetString("back", ci);
            btn_Exit.Text = rm.GetString("exit", ci);
            btn_Confirm.Text = rm.GetString("confirm", ci);
            en_flag.Image = (Image)rm.GetObject("flag", ci);
        }

        private void ChangePINForm_Load(object sender, EventArgs e)
        {

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

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(gdc.Con);
            SqlCommand cmd = new SqlCommand("Command String", con);
            SqlDataReader readdata;

            try
            {
                con.Open();
                int oldpin = int.Parse(txt_OldPIN.Text);
                int pinDB = 0;
                int newpin = int.Parse(txt_NewPIN.Text);
                int newpinDB = 0;
                cmd.CommandText = "SELECT * FROM [Table] WHERE AccNo = '" + show.AccNo + "'";
                readdata = cmd.ExecuteReader();

                while (readdata.Read())
                {
                    pinDB = int.Parse(readdata["PIN"].ToString());
                    newpinDB = int.Parse(readdata["PIN"].ToString());
                }
                con.Close();

                con = new SqlConnection(gdc.Con);
                SqlCommand cmda = new SqlCommand("Command String", con);
                con.Open();

                if (txt_NewPIN.Text.Length > 3 && txt_OldPIN.Text.Length > 3) 
                {
                    if (oldpin == pinDB)
                    {
                        newpinDB = newpin;
                        cmda.CommandText = "UPDATE [Table] SET PIN = '" + newpin + "' WHERE AccNo = '" + show.AccNo + "'";
                        cmda.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                        MessageBox.Show("You have successfully changed your PIN!");

                        WelcomeForm previousForm = new WelcomeForm();
                        previousForm.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Your Old PIN doesn't match!");
                        txt_OldPIN.Clear();
                        con.Close();
                        con.Dispose();
                    }
                }

                else
                    {
                        MessageBox.Show("Your Old & New PIN need to be 4 integers in length!");
                        txt_NewPIN.Clear();
                        con.Close();
                        con.Dispose();
                    }
            }

            catch (Exception ex)
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
