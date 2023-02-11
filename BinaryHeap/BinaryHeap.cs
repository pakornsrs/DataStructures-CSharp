using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class BinaryHeap
    {
        // Binary heap will be represented as List

        public BinaryHeap()
        {
            heapData = new List<decimal>();
            Size = 0;
        }

        public List<decimal> heapData {private get; set; }
        public List<decimal> HeapData => heapData;
        public int Size { get; set; }

        // To insert to binary heap

        public void Insert(decimal value)
        {
            heapData.Add(value);
            Size++;

            BubbleUp();

        }

        public void ExtractMax()
        {
            // Handle remove empty heap and special case
            if (Size == 0) return;

            // Swap max value and the last value in Heap
            HeapData[0] = HeapData[Size - 1];

            // Remove the lase valut
            HeapData.RemoveAt(Size - 1);
            Size--;

            var index = 0;

            while (true)
            {
                // Calculate left & right child index 
                var leftChildIndex = 2 * index + 1;
                var rightChildIndex = 2 * index + 2;

                // Set default swapped index
                var swapIndes = 0;

                // Compare to left child
                if (leftChildIndex <= Size - 1
                    && heapData[leftChildIndex] > heapData[index])
                {
                    swapIndes = leftChildIndex;
                }

                // Compare to right child
                // In case of non-set swap index or it've already set but right node is greater
                if (rightChildIndex <= Size - 1
                    && (swapIndes == 0 || heapData[rightChildIndex] > heapData[leftChildIndex]))
                {
                    swapIndes = rightChildIndex;
                }

                // in case of no swap then stop the loop
                if (swapIndes == 0) break;

                // Swapping 
                var temp = heapData[index];
                heapData[index] = heapData[swapIndes];
                heapData[swapIndes] = temp;

                index = swapIndes;

            }

        }

        private void BubbleUp()
        {
            var elementIndex = Size - 1;

            while (true)
            {
                var parentIndex = Convert.ToInt32(Math.Floor((decimal)(elementIndex - 1) / 2));

                parentIndex = parentIndex >= 0 ? parentIndex : 0;

                if (heapData[elementIndex] > heapData[parentIndex] && elementIndex != 0)
                {
                    var temp = heapData[elementIndex];
                    heapData[elementIndex] = heapData[parentIndex];
                    heapData[parentIndex] = temp;

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
            if (Size == 0)
            {
                Console.WriteLine("[ ]");
                return;
            }

            var count = 0;
            string output = "";

            foreach(var item in heapData)
            {
                if(count == 0)
                {
                    output = $"[ {item.ToString()}";
                }
                else
                {
                    output = $"{output}, {item.ToString()}";
                }

                count++;
            }

            output = $"{output} ]";

            Console.WriteLine(output);
        }

    }
}
