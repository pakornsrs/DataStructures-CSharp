using Data_Structures.BinarySearchTree;
using Data_Structures.DataStructure;
using Data_Structures.PriorityQueue;
using Data_Structures.StackAndQueue;

namespace Data_Structures
{
    internal class DataStructurePlayGround
    {
        static void Main(string[] args)
        {
            //SinglyLinkedListTest();
            //DoubleLinkedListTest();
            //StackTest();
            //QueueTest();
            //BinarySearchTreeTest();
            //BinaryHeapTest();

            PriolityQueueTest();
        }

        private static void SinglyLinkedListTest()
        {
            var LinkedList = new SinglyLinkedList<String>();

            // Wright test case here

        }

        private static void DoubleLinkedListTest()
        {
            var LinkedList = new DoubleLinkedList<String>();

            // Wright test method here

            #region Test of Push() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Push() method\n");

            LinkedList.Push("Red");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute 3 Push() method\n");

            LinkedList.Push("Blue");
            LinkedList.Push("Green");
            LinkedList.Push("Yellow");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

            #region Test of Pop() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Pop() method\n");

            LinkedList.Pop();

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute 2 Pop() method\n");

            LinkedList.Pop();
            LinkedList.Pop();

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Pop() method\n");

            LinkedList.Pop();

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

            #region Test of Shift() method
            Console.WriteLine("Implement new Linked list value\n");

            LinkedList = new DoubleLinkedList<String>();
            LinkedList.Push("Gold");
            LinkedList.Push("Silver");
            LinkedList.Push("Crystal");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Shift() method\n");

            LinkedList.Shift();

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Shift() method\n");

            LinkedList.Shift();

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Shift() method\n");

            LinkedList.Shift();

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\n\n********** Next Section **********\n");
            #endregion

            #region Test of UnShift() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute UnShift(\"Emerald\") method\n");

            LinkedList.UnShift("Emerald");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute UnShift(\"Ruby\") method\n");

            LinkedList.UnShift("Ruby");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute UnShift(\"Sapphire\") method\n");

            LinkedList.UnShift("Sapphire");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

            #region Test of Get() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Get() method for index 1\n");

            var node = LinkedList.Get(1);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute Get() method for index 0\n");

            node = LinkedList.Get(0);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute Get() method for index 99\n");

            node = LinkedList.Get(99);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute 2 Push() method\n");

            LinkedList.Push("Omega Ruby");
            LinkedList.Push("Alpha Sapphire");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Get() method for index 1\n");

            node = LinkedList.Get(1);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute Get() method for index 3\n");

            node = LinkedList.Get(3);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

            #region Test of Set() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Set() method for index 0\n");

            LinkedList.Set(0, "I love Pokemon");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Set() method for index 3\n");

            LinkedList.Set(3, "Nintendo Switch");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

            #region Test of Insert() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Insert() method for index 3\n");

            LinkedList.Insert(3, "Heart Gold");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Insert() method for index 1\n");

            LinkedList.Insert(1, "Yellow");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Insert() method for last index\n");

            LinkedList.Insert(LinkedList.Length - 1, "Very nuch ^_^");

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

            #region Test of Remove() method

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nExecute Remove() method for index 5\n");

            LinkedList.Remove(5);

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nCheck connection at same index of removal\n");

            node = LinkedList.Get(5);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute Remove() method for index 1\n");

            LinkedList.Remove(1);

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nCheck connection at same index of removal\n");

            node = LinkedList.Get(1);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute Remove() method for first index\n");

            LinkedList.Remove(0);

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nCheck connection at same index of removal\n");

            node = LinkedList.Get(0);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\nExecute Remove() method for last index\n");

            LinkedList.Remove(LinkedList.Length - 1);

            Console.WriteLine("Node count is " + LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            Console.WriteLine("\nCheck connection at same index of removal\n");

            node = LinkedList.Get(LinkedList.Length - 1);
            Console.WriteLine(LinkedList.DisplayNodeDetail(node));

            Console.WriteLine("\n\n********** Next Section **********\n");

            #endregion

        }

        private static void StackTest()
        {
            var myStack = new Data_Structures.StackAndQueue.Stack<string>();

            myStack.AddToStack("First");

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());

            myStack.AddToStack("Second");

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());

            myStack.AddToStack("Third");
            myStack.AddToStack("Fourth");

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());

            Console.WriteLine("\n\nStart remove from stack\n\n");

            myStack.RemoveFromStack();

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());

            myStack.RemoveFromStack();

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());

            myStack.RemoveFromStack();

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());

            myStack.RemoveFromStack();

            Console.WriteLine("Stack count is " + myStack.Count);
            Console.WriteLine(myStack.DisplayStackValue());
        }

        private static void QueueTest()
        {
            var myQueue = new Data_Structures.StackAndQueue.Queue<string>();

            myQueue.AddToQueue("First");

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());

            myQueue.AddToQueue("Second");

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());

            myQueue.AddToQueue("Third");
            myQueue.AddToQueue("Fourth");

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());

            Console.WriteLine("\n\nStart remove from queue\n\n");

            myQueue.RemoveFromQueue();

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());

            myQueue.RemoveFromQueue();

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());

            myQueue.RemoveFromQueue();

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());

            myQueue.RemoveFromQueue();

            Console.WriteLine("Queue count is " + myQueue.Count);
            Console.WriteLine(myQueue.DisplayQueueValue());
        }

        private static void BinarySearchTreeTest()
        {
            var newBST = new BinarySearchTreeForNum();

            newBST.Add(22);
            newBST.Add(80);
            newBST.Add(40);
            newBST.Add(16);
            newBST.Add(99);
            newBST.Add(3);
            newBST.Add(15);
            newBST.Add(-15);
            newBST.Add(11);
            newBST.Add(23);
            newBST.Add(65);

            Console.WriteLine(newBST.Contain(20));

            Console.WriteLine("\nTest Breadth first search algoritjm\n");
            var result = newBST.BreadthFirstSearch();
            Console.WriteLine("[{0}]", string.Join(", ", result));

            Console.WriteLine("\nTest PreOrder Depth First Search\n");
            var preOrderDFS = newBST.PreOrderDepthFirstSearch();
            Console.WriteLine("[{0}]", string.Join(", ", preOrderDFS));

            Console.WriteLine("\nTest PostOrder Depth First Search\n");
            var postOrderDFS = newBST.PostOrderDepthFirstSearch();
            Console.WriteLine("[{0}]", string.Join(", ", postOrderDFS));

            Console.WriteLine("\nTest InOrder Depth First Search\n");
            var InOrderDFS = newBST.InOrderDepthFirstSearch();
            Console.WriteLine("[{0}]", string.Join(", ", InOrderDFS));
        }

        private static void BinaryHeapTest()
        {
            var newHeap = new BinaryHeap();

            Console.WriteLine("\ntest Insert to binary heap !\n");

            newHeap.PrintList();
            newHeap.Insert(15);
            newHeap.PrintList();
            newHeap.Insert(10);
            newHeap.PrintList();
            newHeap.Insert(30);
            newHeap.PrintList();
            newHeap.Insert(22);
            newHeap.PrintList();
            newHeap.Insert(28);
            newHeap.PrintList();
            newHeap.Insert(8);
            newHeap.PrintList();
            newHeap.Insert(25);
            newHeap.PrintList();
            newHeap.Insert(35);
            newHeap.PrintList();
            newHeap.Insert(40);
            newHeap.PrintList();
            newHeap.Insert(12);
            newHeap.PrintList();
            newHeap.Insert(19);
            newHeap.PrintList();
            newHeap.Insert(13);
            newHeap.PrintList();

            Console.WriteLine("\ntest ExtractMax from binary heap !\n");

            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();
            newHeap.ExtractMax();
            newHeap.PrintList();

            //newHeap.Insert(10);
            //newHeap.PrintList();
            //newHeap.Insert(12);
            //newHeap.PrintList();
            //newHeap.Insert(8);
            //newHeap.PrintList();

            //newHeap.ExtractMax();
            //newHeap.PrintList();

        }

        private static void PriolityQueueTest()
        {
            var newQueue = new PriolityQueues();

            Console.WriteLine("\ntest Insert to Priority Queue !\n");

            newQueue.Insert(15, 5);
            newQueue.PrintList();
            newQueue.Insert(18, 2);
            newQueue.PrintList();
            newQueue.Insert(25, 5);
            newQueue.PrintList();
            newQueue.Insert(12, 1);
            newQueue.PrintList();
            newQueue.Insert(25, 4);
            newQueue.PrintList();
            newQueue.Insert(45, 5);
            newQueue.PrintList();
            newQueue.Insert(1, 6);
            newQueue.PrintList();
            newQueue.Insert(3, 6);
            newQueue.PrintList();

            Console.WriteLine("\ntest DeQueue from Priority Queue !\n");

            newQueue.DeQueue();
            newQueue.PrintList();
            newQueue.DeQueue();
            newQueue.PrintList();
            newQueue.DeQueue();
            newQueue.PrintList();
            newQueue.DeQueue();
            newQueue.PrintList();
            newQueue.DeQueue();
            newQueue.PrintList();
            newQueue.DeQueue();
            newQueue.PrintList();
            newQueue.DeQueue();
            newQueue.PrintList();
        }
    }
}