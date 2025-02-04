using System;
using BankLibrary;

namespace ATM_consol
{
    public class Program
    {
        const string id = "ia9234";

        public static void printText(string t)
        {
            Console.WriteLine(t);
        }

        static void Main(string[] args)
        {
            Money money = new Money();            
            AutomatedTellerMachine atm = new AutomatedTellerMachine();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int t = atm.FindATM(id);
            if(t==-1)
            {
                Console.WriteLine("Помилка!");
                Console.WriteLine("На жаль цей банкомат більше не обслуговується нашим банком.");
                return;
            }
            Console.WriteLine($"{atm.FindName(t)}, {atm.FindStreet(t)}\n");
            money.RegisterHandler( new Money.AccountStateHandler(printText));
            Console.Write("Введіть номер карти: ");
            string card = Console.ReadLine();
            int atempt = 1;
            while(money.LogInCard(card)==-1)
            {
                Console.WriteLine("Помилка!");
                if (atempt==3)
                {
                    Console.WriteLine("Кількість спроб закінчились.");
                    return;
                }
                Console.Write("Введіть номер карти: ");
                card = Console.ReadLine();
                atempt++;
            }
            int i = money.LogInCard(card);
            Console.Write("Введіть пінкод: ");
            string pin = Console.ReadLine();
            atempt = 1;
            while (!money.LogInPin(i, pin))
            {
                Console.WriteLine("Помилка!");
                if (atempt == 3)
                {
                    Console.WriteLine("Кількість спроб закінчились.");
                    return;
                }
                Console.Write("Введіть пінкод: ");
                pin = Console.ReadLine();
                atempt++;
            }
            bool temp = false;
            do 
            {
                Console.Write("Оберіть дію: 1 - Перегляд балансу; 2 - Зняття грошей; 3 - Зарахування коштів на карту; 4 - Перерахування коштів іншій людині;\n\t-> ");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            money.ShowMoney(i);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nВведіть суму: ");
                            int cash = int.Parse(Console.ReadLine());
                            money.TakeMoney(i, cash, t);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("\nВведіть суму: ");
                            int cash = int.Parse(Console.ReadLine());
                            money.GiveMoney(i, cash, t);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("\nВведіть номер карти для перерахування: ");
                            string cardSend = Console.ReadLine();
                            while (money.LogInCard(cardSend) == -1 || cardSend == money.getCard(i))
                            {
                                Console.WriteLine("Помилка!");
                                Console.Write("Введіть номер карти для перерахування: ");
                                cardSend = Console.ReadLine();
                            }
                            int j = money.LogInCard(cardSend);
                            Console.Write($"Суму буде перерахованно для {money.getName(j)}.\n\t1 - Продовжити;  2(або інша будь-яка цифра) - Ні\n\t->");
                            int ans = int.Parse(Console.ReadLine());
                            if (ans != 1) break;
                            Console.Write("\nВведіть суму: ");
                            int cash = int.Parse(Console.ReadLine());
                            money.SendMoney(i, cash, j);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такої дії не існує.");
                            break;
                        }
                }
                Console.Write("Чи бажаєте ви продовжити?\n\t1 - Так; 2(або інша будь-яка цифра) - Ні\n\t->");
                int answer = int.Parse(Console.ReadLine());
                temp = answer == 1 ? true : false;
            } while(temp);
            Console.WriteLine("До побачення!");
        }
    }
}
