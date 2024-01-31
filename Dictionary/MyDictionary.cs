using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;    

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {

            TKey[] keyTemp = keys;
            TValue[] valueTemp = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < keyTemp.Length; i++)    
            {
                keys[i] = keyTemp[i];
                values[i] = valueTemp[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }


        public void ShowAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine($"{keys[i]} = {values[i]}");
            }
        }



       
    }
}
