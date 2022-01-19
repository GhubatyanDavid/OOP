using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Manager
    {
        private Account _account;
        public Account Account
        {
            get { return _account; }
            set { _account = value; }
        }
        public void Handler( string message)
        {
            Console.WriteLine(message);
        }
        public Manager(Account account)
        {
            _account = account;
        }
    }
}
