using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BankLibrary
{
    public class Account : Bank
    {
        private string[,] clients = {
            {"4915789632510423", "1234", "Alexandro M.", "15000", "alexandro.m@example.com"},
            {"5738261907451938", "5678", "Olga P.", "3500", "olga.p@example.com"},
            {"6874923851675823", "1111", "Eugene K.", "8000", "eugene.k@example.com"},
            {"3582175963471023", "3333", "Maria S.", "2000", "maria.s@example.com"},
            {"4927365820198765", "7890", "John D.", "12000", "john.doe@example.com"}
        };

        public string getCard(int i)
        {
            return clients[i, 0];
        }

        public string getPin(int i)
        {
            return clients[i, 1];
        }

        public string getName(int i)
        {
            return clients[i, 2];
        }

        public string getMoney(int i)
        {
            return clients[i, 3];
        }

        public void setMoney(int i, string cash)
        {
            clients[i, 3] = cash;
        }
    }
}
