using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class DynamicArray<T> : IEnumerable<T> where T : new()
    {
        private T[] objectArray;
        private int size;
        private const int MaxArrayLength = 0X7FEFFFFF;

        public DynamicArray()
        {
            objectArray = new T[8];
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
                objectArray = new T[0];
            }
            else
            {
                objectArray = new T[capacity];
                Capacity = capacity;
            }
        }

        public DynamicArray(T[] obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("object[]", "Argument cannot be empty");
            }
            int count = obj.Length;
            if (count == 0)
            {
                objectArray = new T[0];
            }
            else
            {
                objectArray = new T[count];
                AddRange(obj);
            }
        }

        public DynamicArray(IEnumerable<T> coll)
        {
            if (coll == null)
            {
                throw new ArgumentNullException("coll", "Collection cannot be null");
            }
            objectArray = coll.ToArray();
            size = objectArray.Length;
        }

        public T this[int index]
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
            get => objectArray.Length;
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
                        T[] newItems = new T[value];
                        if (size > 0)
                        {
                            Array.Copy(objectArray, 0, newItems, 0, size);
                        }
                        objectArray = newItems;
                    }
                    else
                    {
                        objectArray = new T[0];
                    }
                }
            }
        }

        public void Add(T value)
        {
            if (size == objectArray.Length)
            {
                EnsureCapacity(size + 1);
            }
            objectArray[size] = value;
            size++;
        }

        public void AddRange(T[] value)
        {
            InsertRange(size, value);
        }

        private void InsertRange(int index, T[] value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("object[]", "Argument cannot be null");
            }
            TestLength(index);
            int count = value.Length;
            EnsureCapacity(size + count);
            if (index < size)
            {
                Array.Copy(objectArray, index, objectArray, index + count, size - index);
            }
            T[] itemsToInsert = new T[count];
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
                    Capacity = MaxArrayLength;
                }
                if (newCapacity < min) newCapacity = min;
                Capacity = newCapacity;
            }
        }

        public void Insert(int index, T value)
        {
            TestLength(index);
            if (index < size)
            {
                Array.Copy(objectArray, index, objectArray, index + 1, size - index);
            }
            objectArray[index] = value;
            size++;
        }

        public bool Remove(T value)
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
            objectArray[size] = default(T);

        }

        private void TestLength(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("index", "Argument out of range");
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return objectArray[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return objectArray[i];
            }
        }
    }
}
