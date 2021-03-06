﻿using SortAlgorithms.Interfaces;
using SortAlgorithms.Auxiliaries;

namespace SortAlgorithms.Arrays
{
    abstract class AbstractArray : IAbstractArray
    {
        public int[] Array { get; protected set; }
        public string ArrayType { get; protected set; }
        public int Size { get; private set; }
        public AbstractArray(int newSize)
        {
            Size = newSize;
            SetArray();
        }

        public virtual void SetArray()
        {
            Array = ArrayGenerator.RandomArray(Size);
        }

        public int[] GetArray()
        {
            return Array;
        }

        public string GetArrayType()
        {
            return ArrayType;
        }
    }
}
