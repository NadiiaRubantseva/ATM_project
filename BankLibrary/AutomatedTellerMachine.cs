using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class AutomatedTellerMachine:Bank
    {
        public Bank bank = new Bank();
        public int FindATM(string id)
        {
            for (int i = 0; i < 6; i++)
            {
                if (ATM[i, 2] == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public string FindStreet(int i)
        {
            return ATM[i,1];
        }

        public string FindName(int i)
        {
            return ATM[i,0];
        }
    }
}
