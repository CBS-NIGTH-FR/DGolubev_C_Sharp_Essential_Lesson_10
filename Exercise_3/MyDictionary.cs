using System;
using System.Collections.Generic;


namespace Exercise_3
{
    class MyDictionary<TKey, TValue>
    {
        public int Counter { get; private set; }
        Dictionary<TKey, TValue> Data;

        public MyDictionary()
        {
            Data = new Dictionary<TKey, TValue>();
        }
        public void Add(TKey key, TValue value)
        {
            Data.Add(key, value);
            Counter++;
        }
        public TValue this[TKey key]
        {
            get
            {
                return Data[key];
            }
        }
    }
}
