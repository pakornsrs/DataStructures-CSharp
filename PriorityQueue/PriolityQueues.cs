using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.PriorityQueue
{
    public class PriolityQueues
    {
        public PriolityQueues()
        {
            priorityQueueData = new List<Node>();
            QueueSize = 0;
        }

        private List<Node> priorityQueueData { get; set; }
        private List<Node> PriorityQueueData => priorityQueueData;
        public int QueueSize { get; set; }

        // Insert into priority queue

        public void Insert(int value, int priority)
        {
            var node = new Node(value, priority);

            if(QueueSize == 0)
            {
                priorityQueueData.Add(node);
                QueueSize++;
            }
            else
            {
                priorityQueueData.Add(node);
                QueueSize++;

                BubbleUp();
            }
        }

        public void DeQueue()
        {
            // Handle remove empty heap and special case
            if (QueueSize == 0) return;

            // Swap max value and the last value in Heap
            priorityQueueData[0] = priorityQueueData[QueueSize - 1];

            // Remove the lase valut
            priorityQueueData.RemoveAt(QueueSize - 1);
            QueueSize--;

            var index = 0;

            while (true)
            {
                // Calculate left & right child index 
                var leftChildIndex = 2 * index + 1;
                var rightChildIndex = 2 * index + 2;

                // Set default swapped index
                var swapIndes = 0;

                // Compare to left child
                if (leftChildIndex <= QueueSize - 1
                    && priorityQueueData[leftChildIndex].Priority > priorityQueueData[index].Priority)
                {
                    swapIndes = leftChildIndex;
                }
                else if(leftChildIndex <= QueueSize - 1
                    && priorityQueueData[leftChildIndex].Priority == priorityQueueData[index].Priority
                    && priorityQueueData[leftChildIndex].Value > priorityQueueData[index].Value)
                {
                    swapIndes = leftChildIndex;
                }

                // Compare to right child
                // In case of non-set swap index or it've already set but right node is greater
                if (rightChildIndex <= QueueSize - 1
                    && (swapIndes == 0 || priorityQueueData[rightChildIndex].Priority > priorityQueueData[leftChildIndex].Priority))
                {
                    swapIndes = rightChildIndex;
                }
                else if(rightChildIndex <= QueueSize - 1
                    && (swapIndes == 0 || priorityQueueData[rightChildIndex].Priority == priorityQueueData[leftChildIndex].Priority)
                    && (swapIndes == 0 || priorityQueueData[rightChildIndex].Value > priorityQueueData[leftChildIndex].Value))
                {
                    swapIndes = leftChildIndex;
                }

                // in case of no swap then stop the loop
                if (swapIndes == 0) break;

                // Swapping 
                var temp = priorityQueueData[index];
                priorityQueueData[index] = priorityQueueData[swapIndes];
                priorityQueueData[swapIndes] = temp;

                index = swapIndes;

            }

        }


        private void BubbleUp()
        {
            var elementIndex = QueueSize - 1;

            while (true)
            {
                var parentIndex = Convert.ToInt32(Math.Floor((decimal)(elementIndex - 1) / 2));

                parentIndex = parentIndex >= 0 ? parentIndex : 0;

                if (elementIndex != 0 
                    && priorityQueueData[elementIndex].Priority > priorityQueueData[parentIndex].Priority)
                {
                    var temp = priorityQueueData[elementIndex];
                    priorityQueueData[elementIndex] = priorityQueueData[parentIndex];
                    priorityQueueData[parentIndex] = temp;

                    // Update elementIndex
                    elementIndex = parentIndex;
                }
                else if(elementIndex != 0 
                    && priorityQueueData[elementIndex].Priority == priorityQueueData[parentIndex].Priority
                    && priorityQueueData[elementIndex].Value > priorityQueueData[parentIndex].Value)
                {

                    var temp = priorityQueueData[elementIndex];
                    priorityQueueData[elementIndex] = priorityQueueData[parentIndex];
                    priorityQueueData[parentIndex] = temp;

                    // Update elementIndex
                    elementIndex = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }
        

        public void PrintList()
        {
            if (QueueSize == 0)
            {
                Console.WriteLine("[ ]");
                return;
            }

            var count = 0;
            string output = "";

            foreach (var item in priorityQueueData)
            {
                if (count == 0)
                {
                    var element = item.Value.ToString() + $"({item.Priority.ToString()})";
                    output = $"[ {element}";
                }
                else
                {
                    var element = item.Value.ToString() + $"({item.Priority.ToString()})";
                    output = $"{output}, {element}";
                }

                count++;
            }

            output = $"{output} ]";

            Console.WriteLine(output);
        }

        public class Node
        {
            public Node(int value, int priolity)
            {
                this.Value = value;
                this.Priority = priolity;
            }
            public int Value { get; set; }
            public int Priority { get; set; }
        }
    }
}
