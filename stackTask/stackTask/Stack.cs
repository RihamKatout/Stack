using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackTask
{
    public class Stack<T>
    {
        private List<T> list;
        public Stack()
        {
            list = new List<T>();
        }
        public Stack(List<T> list)
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
    }
}
