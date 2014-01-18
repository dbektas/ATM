using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace ATM_Final
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("ATM_Final");
            ResourceManager rm = new ResourceManager("ATM_Final.Lang.langres", a);

            btn_QuickMoney.Text = rm.GetString("quickmoney", ci);
            btn_Withdraw.Text = rm.GetString("withdraw", ci);
            btn_AccountInfo.Text = rm.GetString("accountinfo", ci);
            btn_ChangePIN.Text = rm.GetString("changepin", ci);
            en_flag.Image = (Image)rm.GetObject("flag", ci);
            btn_Exit.Text = rm.GetString("exit1", ci);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_QuickMoney_Click(object sender, EventArgs e)
        {
            QuickMoneyForm QuickMoney = new QuickMoneyForm();
            QuickMoney.Show();

            this.Hide();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm Withdraw = new WithdrawForm();
            Withdraw.Show();

            this.Hide();
        }

        private void btn_AccountInfo_Click(object sender, EventArgs e)
        {
            AccountInfoForm AccountInfo = new AccountInfoForm();
            AccountInfo.Show();

            this.Hide();
        }

        private void btn_ChangePIN_Click(object sender, EventArgs e)
        {
            ChangePINForm ChangePIN = new ChangePINForm();
            ChangePIN.Show();

            this.Hide();
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
