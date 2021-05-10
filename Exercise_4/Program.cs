using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadList();
            Console.ReadKey();
        }
        private static void ReadList()
        {
            MyList<int> list = new MyList<int>();
            int[] data = new int[list.Counter];
            list.Add(24);
            list.Add(36);
            list.Add(48);
            list.Add(52);
            list.Add(93);
            list.Add(17);
            list.Add(81);
            data =  MyExtention.GetArray(list);
            
            for (int i = 0; i <data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine($"Всего записей - {list.Counter}");
        }
    }
}
