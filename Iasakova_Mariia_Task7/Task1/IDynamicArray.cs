using System;

namespace Task1
{
    interface IDynamicArray
    {

        Object this[int index]
        {
            get;
            set;
        }
        void Add(Object value);
        void AddRange(Object[] value);
        void Insert(int index, Object value);
        bool Remove(Object value);
    }
}
