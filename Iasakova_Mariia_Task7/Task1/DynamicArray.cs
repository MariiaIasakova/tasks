using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray : IDynamicArray
    {
        private Object[] objectArray;
        private int size, capacity;
        private const int MaxArrayLength = 0X7FEFFFFF;

        public DynamicArray()
        {
            objectArray = new Object[8];
            Capacity = 8;
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("capacity", "Argument must be non negative number");
            }
            else if (capacity == 0)
            {
                objectArray = EmptyArray<Object>.Value;
            }
            else
            {
                objectArray = new Object[capacity];
                Capacity = capacity;
            }
        }

        public DynamicArray(object[] obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("object[]", "Argument cannot be empty"));
            }
            int count = obj.Length;
            if (count == 0)
            {
                objectArray = EmptyArray<Object>.Value;
            }
            else
            {
                objectArray = new Object[count];
                AddRange(obj);
            }
        }

        public object this[int index]
        {
            get
            {
                TestLength(index);
                return objectArray[index];
            }
            set
            {
                TestLength(index);
                objectArray[index] = value;
            }
        }

        public int Length => size;

        public int Capacity
        {
            set
            {
                if (value < size)
                {
                    throw new ArgumentOutOfRangeException("value", "Argument out of range - small capacity");
                }
                if (value != objectArray.Length)
                {
                    if (value > 0)
                    {
                        Object[] newItems = new Object[value];
                        if (size > 0)
                        {
                            Array.Copy(objectArray, 0, newItems, 0, size);
                        }
                        objectArray = newItems;
                    }
                    else
                    {
                        objectArray = EmptyArray<Object>.Value;
                    }
                }
            }
        }

        public void Add(object value)
        {
            if (size == objectArray.Length)
            {
                EnsureCapacity(size + 1);
            }
            objectArray[size] = value;
            size++;
        }

        public void AddRange(Object[] value)
        {
            InsertRange(size, value);
        }

        private void InsertRange(int index, Object[] value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("object[]", "Argument cannot be null"));
            }
            TestLength(index);
            int count = value.Length;
            EnsureCapacity(size + count);
            if (index < size)
            {
                Array.Copy(objectArray, index, objectArray, index + count, size - index);
            }
            Object[] itemsToInsert = new Object[count];
            value.CopyTo(itemsToInsert, 0);
            itemsToInsert.CopyTo(objectArray, index);
            size += count;
        }

        private void EnsureCapacity(int min)
        {
            if (objectArray.Length < min)
            {
                int newCapacity = objectArray.Length * 2;

                if ((uint)newCapacity > MaxArrayLength)
                {
                    capacity = MaxArrayLength;
                }
                if (newCapacity < min) newCapacity = min;
                capacity = newCapacity;
            }
        }

        public void Insert(int index, object value)
        {
            TestLength(index);
            if (index < size)
            {
                Array.Copy(objectArray, index, objectArray, index + 1, size - index);
            }
            objectArray[index] = value;
            size++;
        }

        public bool Remove(object value)
        {
            int index = Array.IndexOf((Array)objectArray, value, 0, size); ;
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RemoveAt(int index)
        {
            TestLength(index);
            size--;
            if (index < size)
            {
                Array.Copy(objectArray, index + 1, objectArray, index, size - index);
            }
            objectArray[size] = null;

        }

        private void TestLength(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("index", "Argument out of range");
            }

        }
    }
}
