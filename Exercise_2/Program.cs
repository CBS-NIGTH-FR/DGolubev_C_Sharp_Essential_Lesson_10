using System;


namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntType();
            Console.WriteLine();
            StringType();
        }
        private static void IntType()
        {
            MyList<int> list = new MyList<int>();
            list.Add(24);
            list.Add(36);
            list.Add(48);
            list.Add(52);
            list.Add(93);
            list.Add(17);
            list.Add(81);
            for (int i = 0; i < list.Counter; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine($"Всего записей - {list.Counter}");
        }

        private static void StringType()
        {
            MyList<string> list = new MyList<string>();
            list.Add("Я ");
            list.Add("очень ");
            list.Add("люблю ");
            list.Add("свою ");
            list.Add("самую замечательную ");
            list.Add("жену!");
            for (int i = 0; i < list.Counter; i++)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine($"\nВсего записей - {list.Counter}");
            Console.ReadKey();
        }
    }
}
