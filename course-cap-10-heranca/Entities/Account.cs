using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_cap_10_heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // Titular da conta
        public double Balance  { get; protected set; } // Saldo da conta

        // Constutor padrão
        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Método para sacar
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
