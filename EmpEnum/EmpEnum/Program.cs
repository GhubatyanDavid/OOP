using System;

namespace EmpEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = Enum.GetValues(typeof(EmpTypeEnum));

            Bonus bonus = new Bonus();
            string name = Console.ReadLine();
            //bonus.AskForBonus(EmpTypeEnum.name);
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]==name)

            }
            EmpTypeEnum emp = EmpTypeEnum.Manager;

            //AskForBonus(emp);


        }
    }
}
