using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21CreateList
{
    internal class CustomList<TType>
    {
        private TType[] _items;
        private int _capacity;
        private long _lastIndex = 0;
        
        private void EnSureCapacity(uint additionalCapacity = 1)
        {
            if (_capacity + additionalCapacity < _items.Length) return;
            var newCapacity = GetNextSize((uint)_lastIndex + additionalCapacity);

        }
        private uint GetNextSize(uint desiredItemSize)
        {
            var newCapacity = desiredItemSize;
            do
            {
                newCapacity *= 2;
            } while (newCapacity < desiredItemSize);
            return newCapacity;
        }


        public void Add(TType item)
        {

        }

        public void AddRange(TType[] items)
        {
            
        }

        public bool Contains(TType item)
        {
            return false;
        }

        public void CopyTo(TType[] array)
        {

        }

        public int IndexOf(TType item)
        {
            return -1;
        }

        public void Insert(int index, TType item)
        {

        }

        public void InsertRange(int index, TType[] items)
        {

        }

        public void Remove(TType item)
        {
                
        }

        public void RemoveAt(int index)
        {

        }

        public TType[] ToArray()
        {
            TType[] array = new TType[1];
            return array;
        }
    }
}
