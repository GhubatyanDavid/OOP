using System;

namespace AccountLogIn
{
    internal class Program 
    {
        static private Accounts Handler(string name)
        {
            Console.WriteLine("Sorry This Names Blocked!!!");
            string adminMail =name + "This member is blocked!!";
            return null;
        }
        static private Accounts Handler1(string name)
        {
            Console.WriteLine($"Wecome {name} :)");
            return null;
        }
        static void Main(string[] args)
        {
            Account account = new Account();
            
            Console.WriteLine("Please Write your name!");
            string name = Console.ReadLine();
            if(name == "Jack" || name == "Steven" || name == "Metyu")
            {
                account.Login += Handler(name);
            }
            else
            {
                account.Login += Handler1(name);
            }
            //account.Login += 
            /*Գրեք ծրագիր առցանց հաճախումների համար: Պայմանները հետևյալն են.
            Օգտատերը տալիս է իր անունը որպես մուտքագրում, այնուհետև հավելվածը ցույց է տալիս հաղորդագրություն «Բարի գալուստ իրենց անունը»:
            Ջեքին, Սթիվենին և Մեթյուին արգելված են կազմակերպության համար: Այսպիսով, երբ ցանկացած օգտատեր մուտքագրում է Ջեք, Սթիվեն և Մեթյու
                որպես օգտվողի անուն, հավելվածը բարձրացնում է իրադարձություն և հրդեհի ահազանգ, ինչպես նաև էլփոստ է ուղարկում ադմինիստրացիային:*/
        }
    }
}
