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
    public partial class MainATM : Form
    {
        Money money = new Money();
        AutomatedTellerMachine atm = new AutomatedTellerMachine();
        public int i;
        public int j;
        public int button = 0;
        public int atmNum;
        public int count = 0;

        public MainATM(int i, string id)
        {
            InitializeComponent();
            this.i = i;
            this.atmNum = atm.FindATM(id);
            if(atmNum == -1)
            {
                MessageBox.Show("На жаль цей банкомат більше не обслуговується нашим банком.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            money.RegisterHandler(new Money.AccountStateHandler(showMessage));
        }

        public void showMessage(string t)
        {
            MessageBox.Show(t, "Важливо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void hideOrShowButtons(bool temp)
        {
            buttonBack.Visible = temp;
            buttonContinue.Visible = temp;
            buttonGiveMoney.Visible = temp;
            buttonSendMoney.Visible = temp;
            buttonShowMoney.Visible = temp;
            buttonTakeMoney.Visible = temp;
            labelSendPerson.Visible = !temp;
            buttonYes.Visible = !temp;
            buttonNo.Visible = !temp;
        }
        public int checkString(string s)
        {
            int sum;
            bool res = int.TryParse(textBoxAmount.Text, out sum);
            if (!res||sum<=0)
            {                
                return 0;
            }
            return sum;
        }

        public void showTools(int t, Label l, TextBox b)
        {
            buttonContinue.Visible = true;
            buttonClose.Visible = false;
            l.Visible = true;
            b.Visible = true;
            button = t;
        }

        public void hideTools(Label l, TextBox b)
        {
            l.Visible = false;
            b.Visible = false;
            buttonContinue.Visible = false;
            buttonClose.Visible = true;
            b.Text = "";
        }

        public void cleanScren()
        {
            if (button == 3 && labelAmount.Visible)
            {
                hideTools(labelAmount, textBoxAmount);
            }
            else if (button == 3)
            {
                hideTools(labelCard, textBoxCard);
            }
            else if (button > 0)
            {
                hideTools(labelAmount, textBoxAmount);
            }
        }

        public bool checkAmountOfMoney()
        {
            if (String.IsNullOrEmpty(textBoxAmount.Text))
            {
                MessageBox.Show("Сума грошей не була введена!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (checkString(textBoxAmount.Text) == 0)
            {
                MessageBox.Show("Неправильно введена сума!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonShowMoney_Click(object sender, EventArgs e)
        {
            //labelMessage.Location = new Point(264, 271);
            cleanScren();
            money.ShowMoney(i);
        }

        private void buttonTakeMoney_Click(object sender, EventArgs e)
        {
            //labelMessage.Location = new Point(264, 271);
            cleanScren();
            showTools(1, labelAmount, textBoxAmount);
        }

        private void buttonGiveMoney_Click(object sender, EventArgs e)
        {
            //labelMessage.Location = new Point(264, 271);
            cleanScren();
            showTools(2, labelAmount, textBoxAmount);
        }

        private void buttonSendMoney_Click(object sender, EventArgs e)
        {
            //labelMessage.Location = new Point(252, 440);
            cleanScren();
            showTools(3, labelCard, textBoxCard);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(button==1 || button == 2)
            {
                if(checkAmountOfMoney())
                {
                    int sum = checkString(textBoxAmount.Text);
                    hideTools(labelAmount, textBoxAmount);
                    if(button==1)
                        money.TakeMoney(i, sum, atmNum);
                    else
                        money.GiveMoney(i, sum, atmNum);
                    button = 0;
                }
            }
            else if(button==3&&count==0)
            {
                if (String.IsNullOrEmpty(textBoxCard.Text))
                {
                    MessageBox.Show("Не було вказано номер карти!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxCard.Text == money.getCard(i))
                {
                    MessageBox.Show("Помилка введення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(money.LogInCard(textBoxCard.Text) != -1)
                {                    
                    j = money.LogInCard(textBoxCard.Text);
                    labelSendPerson.Text = $"Ви бажаєте перевести гроші для\n{money.getName(j)}?";
                    hideTools(labelCard, textBoxCard);
                    buttonClose.Visible = false;
                    hideOrShowButtons(false); 
                }
            }
            else
            {
                if (checkAmountOfMoney())
                {
                    money.SendMoney(i, checkString(textBoxAmount.Text), j);
                    hideTools(labelAmount, textBoxAmount);
                    button = 0;
                    count = 0;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(button == 0)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else if (button == 3 && labelAmount.Visible)
            {
                hideTools(labelAmount, textBoxAmount);
                showTools(3, labelCard, textBoxCard);
            }
            else if(button == 3)
            {
                hideTools(labelCard, textBoxCard);
            }
            else if(button>0)
            {
                hideTools(labelAmount, textBoxAmount);
            }
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            hideOrShowButtons(true);
            showTools(3, labelAmount, textBoxAmount);
            count++;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            hideOrShowButtons(true);
            showTools(3, labelCard, textBoxCard);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
