using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson30._10._21_onlylab
{
    class Program
    {
        public enum TypeAcc
        {
            currentAccount = 1,
            savingAccount
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 9.1");

            Random rnd = new Random();
            List<int> randomList = new List<int>();

            Console.WriteLine("Создание аккаунтов.");

            Console.Write("Введите баланс 1-ого аккаунта: ");
            double.TryParse(Console.ReadLine(), out double balance1);
            Account Acc1 = new Account(balance1);

            Console.Write("Введите баланс 2-ого аккаунта: ");
            double.TryParse(Console.ReadLine(), out double balance2);
            Account Acc2 = new Account(balance2);

            Console.Write("Выберите тип транзакции: \n1-->2\n2-->1\n");
            byte.TryParse(Console.ReadLine(), out byte choice);
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Введите сумму транзакции: ");
                        double.TryParse(Console.ReadLine(), out double transfer);
                        Acc1.GeneralTransfer(Acc2, transfer);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Введите сумму транзакции: ");
                        double.TryParse(Console.ReadLine(), out double transfer);
                        Acc2.GeneralTransfer(Acc1, transfer);
                        break;
                    }
            }

            Console.ReadKey();

        }
    }
}

