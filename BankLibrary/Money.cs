using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BankLibrary
{
    public class Money:Account
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;

        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }

        private Account person = new Account();

        public int LogInCard(string card)
        {
            for (int i = 0; i < 5; i++)
            {
                if (card == getCard(i))
                {
                    return i;
                }
            }
            if (_del != null)
                _del("Такого клієнта не існує");
            return -1;
        }

        public bool LogInPin(int i, string pin)
        {
            if (pin == getPin(i))
            {
                if (_del != null)
                    _del("Вітаємо!");
                return true;
            }
            if (_del != null)
                _del("Неправильний пароль");
            return false;
        }

        public void ShowMoney(int i)
        {
            if (_del != null)
                _del($"На вашому рахунку: {getMoney(i)} гривень");
        }

        public void TakeMoney(int i, int cash, int atm)
        {
            int amount = int.Parse(getMoney(i));
            if (amount < cash)
            {
                if (_del != null)
                    _del("На вашому рахунку недостатньо коштів.");
            }
            if(cash> int.Parse(ATM[atm,3]))
            {
                if (_del != null)
                    _del("На жаль, у банкоматі недостатньо коштів.");
            }
            else
            {
                amount -= cash;
                setMoney(i, amount.ToString());
                ATM[atm, 3] = (int.Parse(ATM[atm, 3]) - cash).ToString();
                if (_del != null)
                    _del($"З вашого рахунку було знято {cash} гривень.");
            }
        }

        public void GiveMoney(int i, int cash, int atm)
        {
            int amount = int.Parse(getMoney(i));
            amount += cash;
            ATM[atm, 3] = (int.Parse(ATM[atm, 3]) + cash).ToString();
            setMoney(i, amount.ToString());
            if (_del != null)
                _del($"На ваш рахунок було зараховано {cash} гривень.");
        }

        public void SendMoney(int i, int cash, int j)
        {
            int amount = int.Parse(getMoney(i));
            if (amount < cash)
            {
                if (_del != null)
                    _del("На вашому рахунку недостатньо коштів.");
            }
            else
            {
                amount -= cash;
                setMoney(i, amount.ToString());
                int temp = int.Parse(getMoney(j)) + cash;
                setMoney(j, temp.ToString());
                if (_del != null)
                    _del($"З вашого рахунку було перераховано {cash} гривень для {getName(j)}.");                
            }
        }
    }
}
