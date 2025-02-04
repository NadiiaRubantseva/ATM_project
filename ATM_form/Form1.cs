using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;

namespace ATM_form
{
    public partial class Form1 : Form
    {
        Money money = new Money();
        public int i;
        public int attempt = 1;
        const string id = "ia9234";

        public void showError(string t)
        {
            labelError.Visible = true;
            labelError.Text = t;
        }
        public Form1()
        {
            InitializeComponent();
            money.RegisterHandler(new Money.AccountStateHandler(showError));
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (attempt == 3) this.Close();
            i = money.LogInCard(textBoxCard.Text);
            attempt++;
            if (i != -1)
            {
                labelPin.Visible = true;
                textBoxPin.Visible = true;
                buttonPin.Visible = true;
                attempt = 1;
                textBoxCard.Enabled = false;
                buttonCard.Enabled = false;
            }
        }

        private void buttonPin_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            if (attempt == 3) this.Close();
            if(money.LogInPin(i, textBoxPin.Text))
            {
                MainATM mainATM = new MainATM(i, id);
                this.Hide();
                mainATM.Show();
            }
            attempt++;
        }
    }
}
