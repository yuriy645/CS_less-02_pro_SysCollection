using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;

namespace _3_factory_account
{//Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и
 //  вещественные значения, по типу «счет предприятия – доступная сумма» соответственно.
    class Factory
    {
        public int AccountNum { get; set; }
        public double Sum { get; set; }
        public Factory(int accountNum, double sum)
        {
            AccountNum = accountNum;
            Sum = sum;
        }
    }
    class Program
    {
        static void Method1()
        {
            // Построить коллекцию 
            var factories = new List<Factory>
            {
                new Factory(4568, 73499.34),
                new Factory(454468, 6799.36),
                new Factory(33368, 6099.54),
                new Factory(67568, 89799.84),
            };
            var query = from f in factories
                            
                            //orderby f.Sum descending // ascending - по возрастанию | descending - по убыванию.
                        select new
                        {
                            AccountNum = f.AccountNum,
                            Sum = f.Sum,
                        };

            foreach (var item in query)
                Console.WriteLine("{0} - {1}", item.AccountNum, item.Sum);  // Тут не работало потому
            //что 2 раза написали операторскую скобку
            Console.WriteLine("--");
        }
            
        static void Method2()
        {
            var listDictionary = new ListDictionary();

            listDictionary[876543] = 3086.45;
            listDictionary[6764] = 474.6;
            listDictionary[3563] = 4466.77;

            foreach (DictionaryEntry entry in listDictionary)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            Console.WriteLine("--");

            Console.ReadKey();
        }
        static void Main()
        {
            Method1();
            Method2();
        }
    }
}
