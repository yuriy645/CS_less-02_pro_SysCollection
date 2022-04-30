using System;
using System.Collections;

namespace _1_add
{//Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар
 //«ключ- значение» сначала в алфавитном порядке, а затем в обратном.
    class Program
    {

        static void Main()
        {
            var sort = new SortedList();

            sort["Lorem"] = "1st";
            sort["ipsum"] = "2nd";
            sort["dolor"] = "3rd";
            sort["sit"] = "4th";
            sort["amet"] = "5th";

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
