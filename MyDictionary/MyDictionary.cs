using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <Tkey,Tvalue>
    {
        Tkey[] keys,tempKeys;
        Tvalue[] values,tempValues,emptyArray;
        
        public MyDictionary()
        {
            emptyArray = new Tvalue[1];
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            bool noException = true;

            // same key adding control
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    Console.WriteLine("001 There is same key in the dictionary!\nPlease try to add another key.");
                    noException = false;
                }
            }

            // key, value pair both were added
            if (noException)
            {
                tempKeys = keys;
                tempValues = values;
                keys = new Tkey[keys.Length + 1];
                values = new Tvalue[values.Length + 1];
                for (int idx = 0; idx < tempKeys.Length || idx < tempValues.Length; idx++)
                {
                    keys[idx] = tempKeys[idx];
                    values[idx] = tempValues[idx];
                }
                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }  
        }
        // There is overloading on GetKeys method.

        // return keys to Tkey array argument option
        public void GetKeys(out Tkey[] keyArray)
        {
           keyArray = new Tkey[keys.Length];
           for (int i = 0; i < keyArray.Length; i++)
            {
             keyArray[i] = keys[i];
            } 
        }
        // given 0 argument to function option
        public void GetKeys()
        {
            foreach (Tkey item in keys)
            {
                Console.WriteLine(item);
            }
        }
        public Tvalue GetValueByKey(Tkey key)
        {  
            for (int idx = 0; idx < keys.Length; idx++)
            {
                if (keys[idx].Equals(key))
                {
                    return values[idx];
                }
                else if(idx == keys.Length-1)
                {
                    Console.WriteLine("002 key cannot found in the dictionary!");
                }
            }
            return emptyArray[0];

        }  
    }
}
