using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Account
    {
        public string number;
        public string name;
        public double balance;


        public void Deposite(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            balance = balance -  amount;
        }

        public string GetReport()
        {
            string msg = name + " your account number " + number + " its balance is "+ balance;
            return msg;

        }






    }
}
