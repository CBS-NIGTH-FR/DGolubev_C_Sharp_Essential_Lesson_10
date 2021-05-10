using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class MyList<T>
    {
        public int Counter { get; private set; }
        List<T> Data;
        public MyList()
        {
            Data = new List<T>();
        }
        public void Add(T data)
        {
            Data.Add(data);
            Counter++;
        }
        public T this[int index]
        {
            get
            {
                return Data[index];
            }
        }
    }
}
