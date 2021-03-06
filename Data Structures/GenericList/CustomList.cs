﻿using System;

namespace GenericList
{
    class CustomList<T> : ICustomList<T>
    {
        private T[] listBase;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public CustomList()
        {
            Count = 0;
        }

        public CustomList(params T[] listBase)
        {
            this.listBase = listBase;
            Count = listBase.Length;
        }

        public CustomList(int size)
        {
            listBase = new T[size];
            Capacity = size;
        }

        public void Add(T data)
        {
            if (Count == 0)
            {
                Count++;
                listBase = new T[Count];
                listBase[Count - 1] = data;
                return;
            }

            Count++;
            T[] temp = new T[Count];
            listBase.CopyTo(temp, 0);
            listBase = new T[temp.Length];
            temp.CopyTo(listBase, 0);
            listBase[Count - 1] = data;
        }

        public void Clear()
        {
            Count = 0;
            listBase = null;
        }

        public int IndexOf(T data)
        {
            Contains(data, out int index);
            return index;
        }

        public void RemoveAtIndex(int index)
        {
            throw new NotImplementedException();
        }

        public T ElementAt(int index)
        {
            return listBase[index];
        }

        public bool Contains(T data)
        {
            for (int i = 0; i < listBase.Length; i++)
            {
                if (listBase[i].Equals(data))
                {
                    return true;
                }
            }

            return false;
        }
        
        private bool Contains(T data, out int index)
        {
            for (int i = 0; i < listBase.Length; i++)
            {
                if (listBase[i].Equals(data))
                {
                    index = i;
                    return true;
                }
            }

            index = -1;
            return false;
        }
    }
}
