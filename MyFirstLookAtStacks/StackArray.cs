using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLookAtStacks
{
    class StackArray<T> : IEnumerable<T>
    {
        private int _size = 0;
		private T[] _items = new T[0];

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Push(T item)
        {
            if (_size == _items.Length)
            {
                int newLength = _size == 0 ? 4 : _size * 2 ;

				T[] temp = new T[newLength];
                _items.CopyTo(temp, 0);

                _items = temp;
            }

            _items[_size] = item;
            _size++;
        }

		public T Peek()
        {
            IsStackEmpty();

            return _items[_size - 1];
        }

		private void IsStackEmpty()
        {
            if (_size == 0)
            {
                throw new Exception("Stack is empty");
            }
        }

		public T Pop() 
        {
            IsStackEmpty();
            _size--;
            return _items[_size];
        }

        public void Clear()
        {
            _size = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _size -1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
