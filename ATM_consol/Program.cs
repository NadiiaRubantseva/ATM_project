﻿using System;
using BankLibrary;

namespace ATM_consol
{
    public class Program
    {
        const string ATM_ID = "ia9234";
        const int MAX_LOGIN_ATTEMPTS = 3;

        public static void PrintText(string text)
        {
            Console.WriteLine(text);
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // A generic method for handling retries during input
        public static string GetValidInputWithRetries(string prompt, Func<string, bool> validateInput)
        {
            int attemptCount = 0;
            string input;
            do
            {
                input = GetInput(prompt);
                if (!validateInput(input))
                {
                    Console.WriteLine("Error!");
                    if (++attemptCount == MAX_LOGIN_ATTEMPTS)
                    {
                        Console.WriteLine("Max attempts reached.");
                        return null;
                    }
                }
                else
                {
                    break;
                }
            } while (true);

            return input;
        }

        static void Main(string[] args)
        {
            Money money = null;
            AutomatedTellerMachine atm = null;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int atmIndex = atm.FindATM(ATM_ID);
            if (atmIndex == -1)
            {
                Console.WriteLine("Error: ATM not found.");
                return;
            }

            Console.WriteLine($"{atm.FindName(atmIndex)}, {atm.FindStreet(atmIndex)}\n");

            money.RegisterHandler(new Money.AccountStateHandler(PrintText));

            // Using the generic method to get valid card input
            string card = GetValidInputWithRetries("Enter card number: ", cardInput =>
            {
                return money.LogInCard(cardInput) != -1;
            });
            if (card == null) return; // Max attempts reached

            int cardIndex = money.LogInCard(card);

            // Using the generic method to get valid PIN input
            string pin = GetValidInputWithRetries("Enter PIN: ", pinInput =>
            {
                return money.LogInPin(cardIndex, pinInput);
            });
            if (pin == null) return; // Max attempts reached

            bool continueTransaction = true;
            do
            {
                Console.Write("Choose an action: 1 - View balance; 2 - Withdraw money; 3 - Deposit money; 4 - Transfer money.\n-> ");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        money.ShowMoney(cardIndex);
                        break;
                    case 2:
                        int amount = int.Parse(Console.ReadLine());
                        money.TakeMoney(cardIndex, amount, atmIndex);
                        break;
                    case 3:
                        amount = int.Parse(Console.ReadLine());
                        money.GiveMoney(cardIndex, amount, atmIndex);
                        break;
                    case 4:
                        string transferCard = GetValidInputWithRetries("Enter card number for transfer: ", transferCardInput =>
                        {
                            return transferCardInput != money.getCard(cardIndex) && money.LogInCard(transferCardInput) != -1;
                        });
                        if (transferCard == null) break; // Max attempts reached

                        int transferIndex = money.LogInCard(transferCard);
                        Console.Write($"Transfer money to {money.getName(transferIndex)}.\n\t1 - Continue;  2 - Cancel\n\t-> ");
                        int confirmation = int.Parse(Console.ReadLine());
                        if (confirmation != 1) break;

                        amount = int.Parse(Console.ReadLine());
                        money.SendMoney(cardIndex, amount, transferIndex);
                        break;
                    default:
                        Console.WriteLine("Invalid action.");
                        break;
                }

                Console.Write("Do you want to continue?\n\t1 - Yes; 2 - No\n\t-> ");
                continueTransaction = Console.ReadLine() == "1";

            } while (continueTransaction);

            Console.WriteLine("Goodbye!");
        }
    }
}
