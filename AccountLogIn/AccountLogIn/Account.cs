using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLogIn
{
    public delegate void Accounts();
    class Account
    {
        public event Accounts Login = null;
        public void InvokeEvent()
        {
            Login.Invoke();
        }
    }

}
