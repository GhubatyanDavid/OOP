using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Используя Visual Studio, создайте проект по шаблону Console Application. 
            Создайте коллекцию MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении 
            возможность использования ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>. 
            Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод 
            добавления элемента, индексатор для получения значения элемента по указанному индексу и свойство 
            только для чтения для получения общего количества элементов. Реализуйте возможность перебора 
            элементов коллекции в цикле foreach.*/
            Element<string,string>[] elementsArray = new Element<string, string>[8];
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>(elementsArray);
            elementsArray[0] = new Element<string, string>("Book", "Girq");
            elementsArray[1] = new Element<string, string>("Dog", "Shun");
            elementsArray[2] = new Element<string, string>("Cat", "Katu");
            elementsArray[3] = new Element<string, string>("Rabbit", "Napastak");
            elementsArray[4] = new Element<string, string>("Car", "Meqena");
            elementsArray[5] = new Element<string, string>("Cat", "Katu");
            elementsArray[6] = new Element<string, string>("Woman", "Kin");
            elementsArray[7] = new Element<string, string>("Male", "Txamard");
            myDictionary.Add(elementsArray);

            foreach (Element<string,string> element in myDictionary)
            {
                Console.WriteLine("English: {0}  Armenian: {1} ", element.key,element.value);
            }

        }

    }
}

