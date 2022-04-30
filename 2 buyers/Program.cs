using System;
using System.Collections.Generic;

namespace _2_buyers
{//Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими
 //  продукции.Из коллекции можно получать категории товаров, которые купил покупатель или по
 //категории определить покупателей.

    //нужна коллекция с двумя параметрами (предположительно, оба- string) с возможностью добавлять пары значений, 
    // а потом находить второе значение по первому и наоборот
   
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, string>();

            dict["Vasya"] = "Categ1"; //первые 2-е пары задаем сразу
            dict["Petya"] = "Categ2";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("введите имя ");
                string name = Console.ReadLine();
                Console.Write("введите категорию товара ");
                string categ = Console.ReadLine();

                dict.Add(name, categ);
            }
            
            foreach (KeyValuePair<string, string> i in dict) //вывод всего, что есть
            {
                Console.WriteLine("{0} = {1}", i.Key, i.Value);
            }

            Console.WriteLine(new string('-', 25));

            //foreach (var value in dict.Values)
            //{
            //    Console.WriteLine(value);
            //}
            Console.WriteLine("Введите имя покупателя для поиска");
            string name1 = Console.ReadLine();
            if (dict.ContainsKey(name1))                        // если есть такой ключ,
            Console.WriteLine("{0} = {1}", name1, dict[name1]); // то выводим по нему ключ + значение

            Console.WriteLine("Введите название категории товаров для поиска");
            string categ1 = Console.ReadLine();
            if (dict.ContainsValue(categ1))                     // если есть такое значение
                foreach (var item in dict)                      // то ищем ключ и выводим ключ + значение
                {
                    if (item.Value == categ1)
                        Console.WriteLine("{0} = {1}", item.Key, categ1); ;
                }

            Console.ReadKey();
        }
    }
}
