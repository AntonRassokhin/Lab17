using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<string> bankAccount1 = new BankAccount<string>(12345, "Jon", "firstnumber");
            bankAccount1.Output();

            BankAccount<int> bankAccount2 = new BankAccount<int>(56789, "Von", 6666);
            bankAccount2.Output();

            BankAccount<bool> bankAccount3 = new BankAccount<bool>(0, "Son", false);
            bankAccount3.Output();

            Console.ReadKey();

        }
    }

    class BankAccount<T>
    {
        private int BalanceAcc { get; set; }
        private string OwnerAcc { get; set; }
        private T NumberAcc { get; set; }

        public BankAccount(int balanceAcc, string ownerAcc, T numberAcc)
        {
            BalanceAcc = balanceAcc;
            OwnerAcc = ownerAcc;
            NumberAcc = numberAcc;
        }

        public void Output()
        {
            Console.WriteLine("Баланс: {0}, Имя: {1}, Номер: {2}", BalanceAcc, OwnerAcc, NumberAcc);
        }

    }
}
