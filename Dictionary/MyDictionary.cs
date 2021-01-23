using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T, X>
    {
        T[] items;
        T[] tempItems;
        X[] valueItems;
        X[] tempValue;

        public MyDictionary()
        {
            items = new T[0];
            valueItems = new X[0];
        }

        public void Add(T item, X value)
        {
            tempItems = items;
            tempValue = valueItems;
            items = new T[items.Length + 1];
            valueItems = new X[valueItems.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
                tempValue[i] = valueItems[i];
            }
            items[items.Length - 1] = item;
            valueItems[valueItems.Length - 1] = value;

        }
        public T GetT(X value)
        {
            int index = Array.IndexOf(valueItems, value);
            return items[index];
        }
        public X GetX(T item)
        {
            int index = Array.IndexOf(items, item);
            return valueItems[index];
        }
        public int Length()
        {
            return items.Length;
        }
    }
}