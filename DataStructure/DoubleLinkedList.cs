using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data_Structures.DataStructure
{
    public class DoubleLinkedList<T>
    {
        // Implement new linked-list
        public DoubleLinkedList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        // public params
        public int Length => _length;
        public DoubleLinkedListNode<T> Head => _head;
        public DoubleLinkedListNode<T> Tail => _tail;

        // private params
        private DoubleLinkedListNode<T>? _head;
        private DoubleLinkedListNode<T>? _tail;
        private int _length { get; set; }
    }

    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T Value)
        {
            this.Value = Value;
            this.Next = null;
        }
        public T Value { get; set; }
        public DoubleLinkedListNode<T>? Next { get; set; }
    }
}
