using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLookAtStacks
{
    public class Stack<T>: IEnumerable<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        public int Count
        {
            get
            {
                return _list.Count();
            }
        }
        private T Peek()
        {
            IsStackEmpty();
            return _list.First();
        }

        private void IsStackEmpty()
        {
            if (_list.Count == 0)
            {
                throw new Exception("Your Stack Is Empty");
            }
        }

        private T Pop()
        {
            IsStackEmpty();

            T topMostItem = _list.First();
            _list.RemoveFirst();

            return topMostItem;
        }

        private void Push(T item)
        {
            _list.AddFirst(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_list).GetEnumerator();
        }
    }


}
