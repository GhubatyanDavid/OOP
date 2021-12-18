using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpEnum
{ }
    struct MyStruct
    {      
    }
    class Bonus
    {
        MyStruct myStruct;
        public void AskForBonus(EmpTypeEnum e)
        {
            MyStruct my;
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }
}
