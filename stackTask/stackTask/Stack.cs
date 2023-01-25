using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackTask
{
    public class MyStack<T>
    {
        private List<T> list;
        public MyStack()
        {
            list = new List<T>();
        }
        public MyStack(List<T> list)
        {
            this.list = list;
        }
        public void Push(T value)
        {
            list.Add(value);
        }
        public T? Pop()
        {
            if (list.Count > 0)
            {
                var returnedVal = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return returnedVal;
            }
            return default(T);
        }
        public void Print()
        {
            foreach (T value in list)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public T Peak()
        {
            if (list.Count > 0)
            {
                return list[list.Count - 1];
            }
            return default(T);
        }
        public void Clear()
        {
            list.Clear();
        }
    }
}
