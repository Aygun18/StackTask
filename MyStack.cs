using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StackTask
{
	internal class MyStack<T>:IEnumerable
	{
		public T[] _arr;
		public int Count { get; set; }
		public int	Capacity { get; set; }

        public MyStack()
        {
			Capacity = 4;
			_arr = new T[Capacity];
			Count = 0;
        }
		public void Push(T item)
		{
			if (Count == _arr.Length)
			{
				Capacity *= 2;
				Array.Resize(ref _arr, Capacity);
			}

			_arr[Count] = item;
			Count++;
		}
		public T Pop()
		{
			if(Count==0)
			{
				throw new InvalidOperationException("Stack is empty");
			}
			var item = _arr[Count-1];
			Count--;
			return item;
		}
		public T Peek() 
		{
			if (Count == 0)
			{
				throw new InvalidOperationException("Stack is empty");
			}
			return _arr[Count-1];
		}
		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < Count; i++)
			{
				yield return _arr[i];
			}
		}
	}
}
