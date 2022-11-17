using System;
using System.Collections.Generic;

//размер списка динамически изменяется
//обертка над массивом, лист динамический    

namespace HW3
{

    class Program
    {
        static void Main()
        {
            List<string> listNames = new List<string>();

            listNames.Add("Viktor");
            listNames.Add("Nikolai");
            listNames.Add("Bogdan");

            string[] namesArray = { "Kolya", "Svyatoslav", "Alina" };
            listNames.AddRange(namesArray); //добавление элементов массива в список

            foreach (string listName in listNames)
            {
                Console.WriteLine(listName);
            }
            
            listNames.Insert(1, "Maxim"); //добавление элемента

            Console.WriteLine("\nДобавление элемента в список:");

            foreach (string listName in listNames)
            {
                Console.WriteLine(listName);
            }

            listNames.Sort(); //сортировка

            Console.WriteLine("\nСортировка элементов списка по алфавиту:");

            foreach (string listName in listNames)
            {
                Console.WriteLine(listName);
            }


            listNames.RemoveAt(0); //удаление элемента

            Console.WriteLine("\nУдаление элемента списка:");

            foreach (string listName in listNames)
            {
                Console.WriteLine(listName);
            }

            Console.WriteLine("\nПоиск элемента массива по индексу:");

            Console.WriteLine(listNames[0]); //поиск элемента массива по индексу

            Console.ReadLine();
        }
    }
}