using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data_Structures.DataStructure
{
    public class SinglyLinkedList<T>
    {
        // Implement new linked-list
        public SinglyLinkedList()
        {
            _head = null;
            _tail = null;
            _length = 0;
        }

        // public params
        public int Length => _length;
        public SinglyLinkedListNode Head => _head;
        public SinglyLinkedListNode Tail => _tail;

        // private params
        private SinglyLinkedListNode? _head;
        private SinglyLinkedListNode? _tail;
        private int _length { get; set; }

        // To add a node as the new tail of linked-list
        public SinglyLinkedListNode Push(T value)
        {
            SinglyLinkedListNode NewNode = new SinglyLinkedListNode(value);

            if(_head == null)
            {
                _head = NewNode;
                _tail = _head;
            }
            else
            {
                _tail.Next = NewNode;
                _tail = NewNode;
            }

            _length++;
            return NewNode;
        }

        // To remove the last node
        public SinglyLinkedListNode Pop()
        {
            if (_head == null) return null;

            var current = _head;
            var newTail = current; // Only implement !

            while(current != null)
            {
                var temp = current;
                current = current.Next;

                if (current != null) newTail = temp;
            }

            _tail = newTail;
            _tail.Next = null;
            _length --;

            if(_length == 0)
            {
                _head = null;
                _tail = null;
            }

            return current;
        }

        // To remove the first node (head)
        public SinglyLinkedListNode Shift()
        {
            if (_head == null) return null;

            if(_length == 1)
            {
                _head = null;
                _tail = null;
                _length --;
            }
            else
            {
                var temp = _head;
                _head = temp.Next;
                _length --;
            }

            return _head;
        }

        // To add the new node to the first position (new head)
        public void UnShift(T value)
        {
            var newNode = new SinglyLinkedListNode(value);

            if (_head == null && _tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head = newNode;
            }

            _length ++;
        }

        // To get node of selected node by index
        public SinglyLinkedListNode Get(int index)
        {
            if (index < 0 || index >= _length || _head == null) return null;

            var count = 0;
            var current = _head;

            while(count < index)
            {
                var temp = current;
                current = temp.Next;
                count++;
            }

            return current;
        }

        // To set value to selected node
        public bool Set(int index, T value)
        {
            var node = Get(index);

            if(node != null)
            {
                node.Value = value;
                return true;
            }
            else
            {
                return false;
            }
        }

        // To insert value to selected position
        public bool Insert(int index, T value)
        {
            if(index < 0 || index > _length)
            {
                return false;
            }
            else if(index == 0)
            {
                UnShift(value);
            }
            else if(index == _length)
            {
                Push(value);
            }
            else
            {
                var count = 0;
                var current = _head;
                var prev = _head;

                while(count < index)
                {
                    var temp = current;
                    current = temp.Next;
                    prev = temp;

                    count++;
                }

                var insertNode = new SinglyLinkedListNode(value);
                insertNode.Next = current;
                prev.Next = insertNode;

                _length++;
            }

            return true;
        }

        // To insert remove the selected position
        public bool Remove(int index)
        {
            if (index < 0 || index > _length - 1)
            {
                return false;
            }
            else if(index == 0)
            {
                Shift();
                return true;
            }
            else if(index == _length - 1)
            {
                Pop();
                return true;
            }
            else
            {
                var prev = Get(index - 1);
                var remove = prev.Next;

                prev.Next = remove.Next;

                _length--;

                return true;
            }
        }

        // To reverst a linked list
        public bool Reverse()
        {
            var node = _head;
            _head = _tail;
            _tail = node;

            SinglyLinkedListNode prevNode = null;
            SinglyLinkedListNode nextNode = null;

            var count = 0;

            while(count < _length)
            {
                nextNode = node.Next;

                node.Next = prevNode;
                prevNode = node;
                node = nextNode;

                count++;
            }

            return true;
        }



        // To display selected linked-list node value in string
        public string DisplayNodeValue(SinglyLinkedListNode node)
        {
            var result = "";
            try
            {
                result = node.Value.ToString();
                return result;
            }
            catch
            {
                result = "The value cannot display in string";
                return result;
            }
        }

        // To display all of linked-list node value in string
        public string DisplayLinkedListValue()
        {
            var result = "";
            try
            {
                var current = _head;

                while(current != null)
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

       
        public class SinglyLinkedListNode
        {
            public SinglyLinkedListNode(T Value)
            {
                this.Value = Value;
                this.Next = null;
            }
            public T Value { get; set; }
            public SinglyLinkedListNode? Next { get; set; }
        }
    }

}
