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
    }
}
