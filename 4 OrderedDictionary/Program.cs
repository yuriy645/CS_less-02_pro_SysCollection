using System;
using System.Collections;
using System.Collections.Specialized;

namespace _4_OrderedDictionary
{//Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений
 //   ключей.
	class Program
	{
		static void Main()
		{
			var emailLookup = new OrderedDictionary
			{
			 {"sbishop@contoso.com", "Bishop, Scott"},
			 {"chess@contoso.com", "Hell, Christian"},
			 {"djump@contoso.com", "Jump, Dan"},
			 {"карлсон", "карлсон"},
			 {"живёт на крыше", "живёт на крыше"},

			};

			
			foreach (DictionaryEntry entry in emailLookup)
			{
				string keyI = (string)entry.Key;
				string valueI = (string)entry.Value;
				if (keyI == valueI)
				   Console.WriteLine($"{keyI} - {valueI} / ключ равен значению");
				else
					Console.WriteLine($"{keyI} - {valueI} / ключ НЕ равен значению");
			}

			// Delay
			Console.ReadKey();
		}
	}
}
