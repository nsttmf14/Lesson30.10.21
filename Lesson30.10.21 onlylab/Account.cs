using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson30._10._21_onlylab
{
    class Account
    {
        public TypeAcc accountType;
        public double balance;

        public enum TypeAcc
        {
            currentAccount = 1,
            savingAccount
        }

        private Queue<BankTransaction> transactions; //Объявление очереди
        public Account(double balance)
        {
            this.balance = balance;
            this.accountType = accountType;
        }
        public bool Transfers(double sum)
        {
            if (sum <= balance)
            {
                balance -= sum;
                transactions.Enqueue(new BankTransaction(-sum));
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddBalance(double sum)
        {
            if (sum > 0)
            {
                balance += sum;
                transactions.Enqueue(new BankTransaction(sum));
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool GeneralTransfer(Account recipient, double sum)
        {
            if (Transfers(sum)) //Если трансфер состоялся
            {
                recipient.AddBalance(sum); //получение транзакции получателем
                return true;
            }
            else //Если сумма трансфера больше баланса аккаунта отправителя
            {
                return false;
            }
        }
        public void Dispose(string file)
        {
            StreamWriter sw = new StreamWriter(file);
            sw.Write(string.Join("\n", transactions));
            sw.Close();
            GC.SuppressFinalize(sw);
        }
    }
}
