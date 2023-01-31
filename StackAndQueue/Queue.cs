using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.StackAndQueue
{
    public class Queue<T>
    {
        public Queue()
        {
            first = null;
            last = null;
            count = 0;
        }

        // public variable
        public QueueData? First => first;
        public QueueData? Last => last;
        public int Count => count;

        // Private variable
        private QueueData? first;
        private QueueData? last;
        private int count;

        public bool AddToQueue(T value)
        {
            var queueValue = new QueueData(value);

            if (count == 0)
            {
                first = queueValue;
                last = queueValue;

                count++;
            }
            else
            {
                last.Next = queueValue;
                last = queueValue;

                count++;
            }

            return true;
        }
        public bool RemoveFromQueue()
        {
            if (count == 0) return false;

            if (count == 1)
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

        public string DisplayQueueValue()
        {

            if (count == 0) return "Queue is Empty";

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
        public class QueueData
        {
            public QueueData(T Value)
            {
                this.Value = Value;
                this.Next = null;
            }
            public T Value { get; set; }
            public QueueData? Next { get; set; }
        }
    }
}
