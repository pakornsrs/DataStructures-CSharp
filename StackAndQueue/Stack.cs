using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data_Structures.StackAndQueue
{
    public class Stack<T>
    {
        public Stack()
        {
            first = null;
            last = null;
            count = 0;
        }

        // public variable
        public StackData First => first;
        public StackData Last => last;
        public int Count => count;

        // Private variable
        private StackData first;
        private StackData last;
        private int count;

        public bool AddToStack(T value)
        {
            var stackValue = new StackData(value);

            if(count == 0)
            {
                first = stackValue;
                last = stackValue;

                count++;
            }
            else
            {
                stackValue.Next = first;
                first = stackValue;

                count++;
            }

            return true;
        }
        public bool RemoveFromStack()
        {
            if(count == 0) return false;

            if(count == 1)
            {
                first = null;
                last = null;

                count--;
            }
            else
            {
                var temp = first.Next;
                first = temp;

                count--;
            }

            return true;
        }

        public string DisplayStackValue()
        {

            if (count == 0) return "Stack is Empty";

            var result = "";
            try
            {
                var current = first;

                while (current != null)
                {
                    if (string.IsNullOrEmpty(result))
                    {
                        result = result + current.Value.ToString();
                    }
                    else
                    {
                        result = result + " -> " + current.Value.ToString();
                    }

                    current = current.Next;
                }

                return result;
            }
            catch
            {
                result = "The value cannot display in string";
                return result;
            }
        }
        public class StackData
        {
            public StackData(T Value)
            {
                this.Value = Value;
                this.Next = null;
            }
            public T Value { get; set; }
            public StackData? Next { get; set; } 
        }
    }
}
