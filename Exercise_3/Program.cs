using System;


namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringString();
            IntString();
            Console.ReadKey();
        }

        private static void StringString()
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("яблоко", "apple");
            dictionary.Add("стол", "table");
            dictionary.Add("стул", "chair");
            dictionary.Add("окно", "window");
            dictionary.Add("машина", "car");
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine($"Всего пар - {dictionary.Counter}");
        }

        private static void IntString()
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "apple");
            dictionary.Add(2, "table");
            dictionary.Add(3, "chair");
            dictionary.Add(4, "window");
            dictionary.Add(5, "car");
            for (int i = 1; i < dictionary.Counter; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.WriteLine($"Всего пар - {dictionary.Counter}");
        }
    }
}
