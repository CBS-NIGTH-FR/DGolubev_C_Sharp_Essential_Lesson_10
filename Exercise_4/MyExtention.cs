using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    static class MyExtention
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] ts = new T[list.Counter];
            for (int i = 0; i < ts.Length; i++)
            {
                ts[i] = list[i];
            }
            return ts;
        }
    }
}
