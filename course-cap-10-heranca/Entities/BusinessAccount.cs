using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_cap_10_heranca.Entities
{  // Herda atributos e métodos da classe account = conta
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanlimite) : base(number, holder, balance)
        {
            LoanLimit = loanlimite;
        }
        
        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;

            }
        }

        


    }
}
