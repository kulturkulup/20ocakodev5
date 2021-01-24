using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<intKey, stringValue>
    {
        int[] keyArray;
        int[] tempKeyArray;
        string[] valueArray;
        string[] tempValueArray;

        public MyDictionary()
        {
            keyArray = new int[0];
            valueArray = new string[0];
        }

        public void Add(int key, string value)
        {
            tempKeyArray = keyArray;
            tempValueArray = valueArray;

            keyArray = new int[keyArray.Length + 1];
            valueArray = new string[valueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
            }
            keyArray[keyArray.Length - 1] = key;

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                valueArray[i] = tempValueArray[i];
            }
            valueArray[valueArray.Length - 1] = value;
        }

        public int[] Items1
        {
            get { return keyArray; }
        }

        public string[] Items2
        {
            get { return valueArray; }
        }
    }
}
