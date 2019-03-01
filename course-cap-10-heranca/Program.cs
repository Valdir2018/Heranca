using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course_cap_10_heranca.Entities;

namespace course_cap_10_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1610, " Valdir Silva", 100.0, 200.0);
            Console.WriteLine(account.Balance);

           // account.Balance = 200; // error não pode alterar o valor diretamente
            Console.ReadKey();

        }
    }
}
