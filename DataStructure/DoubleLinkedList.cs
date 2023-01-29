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
        public DoubleLinkedListNode Head => _head;
        public DoubleLinkedListNode Tail => _tail;

        // private params
        private DoubleLinkedListNode? _head;
        private DoubleLinkedListNode? _tail;
        private int _length { get; set; }

        // To push a node to Linked link
        public bool Push(T value)
        {
            if (_head == null)
            {
                var newNode = new DoubleLinkedListNode(value);
                _head = newNode;
                _tail = newNode;

                _length++;
            }
            else
            {
                var newNode = new DoubleLinkedListNode(value);

                newNode.Previous = _tail;
                _tail.Next = newNode;

                // Update tail
                _tail = newNode;

                _length++;
            }

            return true;
        }

        // To remove the lase node
        public bool Pop()
        {
            if (_head == null) return false;

            if(_length == 1)
            {
                _head = null;
                _tail = null;

                _length--;
                return true;
            }
            else
            {
                var newTail = _tail.Previous;
                newTail.Next = null;

                _tail = newTail;

                _length--;
                return true;
            }
        }

        // To remove the first (head) node
        public bool Shift()
        {
            if (_head == null) return false;

            if(_length == 1)
            {
                _head = null;
                _tail = null;

                _length--;
                return true;
            }
            else
            {
                var newHead = _head.Next;
                newHead.Previous = null;

                _head = newHead;
                _length--;
                return true;
            }
        }

        // To add value to the first (head) node 
        public bool UnShift(T value)
        {
            if(_head == null)
            {
                var node = new DoubleLinkedListNode(value);
                _head = node;
                _tail = node;

                _length++;
                return true;
            }
            else
            {
                var node = new DoubleLinkedListNode(value);

                node.Next = _head;
                _head.Previous = node;
                _head = node;

                _length++;
                return true;
            }
        }

        // To get a node by index
        public DoubleLinkedListNode Get(int index)
        {
            if (index < 0 || index >= _length) return null;

            var half = Math.Floor((decimal)_length / 2);

            if(index < half)
            {
                var current = _head;
                var count = 0;

                while(count < index)
                {
                    var temp = current;
                    current = temp.Next;

                    count++;
                }

                return current;
            }
            else
            {
                var current = _tail;
                var count = _length - 1;

                while (count > index)
                {
                    var temp = current;
                    current = temp.Previous;

                    count--;
                }

                return current;
            }
        }

        // To set value of selected node
        public bool Set(int index, T value)
        {
            var selectedNode = Get(index);

            if(selectedNode == null) return false;

            selectedNode.Value = value;
            return true;
        }

        // To add new node to linked list at selected position using index
        public bool Insert(int index, T value)
        {
            if(index < 0 || index > Length - 1) return false;

            if (index == 0)
            {
                UnShift(value);
                return true;
            }
            else if(index == _length - 1)
            {
                Push(value);
                return true;
            }
            else
            {
                var half = Math.Floor((decimal)_length / 2);

                if (index < half)
                {
                    var current = _head;
                    var prev = _head.Previous;
                    var count = 0;

                    while (count < index)
                    {
                        var temp = current;
                        current = temp.Next;
                        prev = current.Previous;

                        count++;
                    }

                    var newNode = new DoubleLinkedListNode(value);

                    prev.Next = newNode;
                    newNode.Previous = prev;
                    newNode.Next = current;
                    current.Previous = newNode;

                    _length++;
                    return true;
                }
                else
                {
                    var current = _tail;
                    var prev = _tail.Previous;
                    var count = _length - 1;

                    while (count > index)
                    {
                        var temp = current;
                        current = temp.Previous;
                        prev = current.Previous;

                        count--;
                    }

                    var newNode = new DoubleLinkedListNode(value);

                    prev.Next = newNode;
                    newNode.Previous = prev;
                    newNode.Next = current;
                    current.Previous = newNode;

                    _length++;
                    return true;
                }
            }
        }

        // To remove the selected node
        public bool Remove(int index)
        {
            if (index < 0 || index > Length - 1) return false;

            if (index == 0)
            {
                Shift();
                return true;
            }
            else if (index == _length - 1)
            {
                Pop();
                return true;
            }
            else
            {
                var selectedNode = Get(index);

                if (selectedNode == null) return false;

                var prevNode = selectedNode.Previous;
                var nextNode = selectedNode.Next;
                prevNode.Next = nextNode;
                nextNode.Previous = prevNode;

                _length--;
                return true;
            }
        }


        // To display selected linked-list node value in string
        public string DisplayNodeDetail(DoubleLinkedListNode node)
        {
            if (node == null) return "Node is Undefind or Null value";

            var result = "";
            try
            {
                var value = node.Value.ToString();
                var prev = node.Previous == null ? "Null" : node.Previous.Value.ToString();
                var next = node.Next == null ? "Null" : node.Next.Value.ToString();

                result = "Node value is " + value
                            + "\nPrevious Node value is " + prev
                            + "\nNext Node value is " + next;

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

            if (_length == 0) return "Linked list is Empty";

            var result = "";
            try
            {
                var current = _head;

                while (current != null)
                {
                    if (string.IsNullOrEmpty(result))
                    {
                        result = result + current.Value.ToString();
                    }
                    else
                    {
                        result = result + " <-> " + current.Value.ToString();
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


        // Double linked list node class
        public class DoubleLinkedListNode
        {
            public DoubleLinkedListNode(T Value)
            {
                this.Value = Value;
                this.Next = null;
                this.Previous = null;
            }
            public T Value { get; set; }
            public DoubleLinkedListNode? Next { get; set; }
            public DoubleLinkedListNode? Previous { get; set; }
        }
    }

}
