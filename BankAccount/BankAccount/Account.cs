using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public delegate void BankAccountHandler(string message);
    class Account
    {
        public event BankAccountHandler notify = null;
        private int _sum;
        private int _accountNumber;
        public Account(int sum, int accountNumber)
        {
            _sum = sum;
            _accountNumber = accountNumber;
        }
        public void AddMoney(int sum)
        {
            if (_accountNumber == 1111)
            {
                _sum += sum;
                notify.Invoke($"Director have {_sum}$");
            }
            else if (_accountNumber == 2222)
            {
                _sum += sum;
                notify.Invoke($"Manager have {_sum}$");
            }

        }
    }
}

