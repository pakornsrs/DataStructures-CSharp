using Data_Structures.StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.BinarySearchTree
{
    public class BinarySearchTreeForNum
    {
        public BinarySearchTreeForNum()
        {
            this.root = null;
            this.count = 0;
        }
        public Node? Root => root;
        public int Count => count;
        private Node? root { get; set; }
        private int count { get; set; }

        //To add value to BST
        public bool Add(decimal value)
        {
            var newNode = new Node(value);

            if(root == null)
            {
                Console.WriteLine($"Log : {value} is added as new root.");
                root = newNode;
                count++;
                return true;
            }
            else
            {
                var currentNode = root;

                while (true)
                {
                    if (currentNode.Value == newNode.Value)
                    {
                        Console.WriteLine("Value is already exist !");
                        return false;
                    }
                    else if(currentNode.Value < newNode.Value)
                    {
                        if(currentNode.RightNode == null)
                        {
                            Console.WriteLine($"Log : {value} is added at the right node of {currentNode.Value}");
                            currentNode.RightNode = newNode;
                            count++;
                            return true;
                        }
                        else
                        {
                            currentNode = currentNode.RightNode;
                        }
                    }
                    else
                    {
                        if (currentNode.LeftNode == null)
                        {
                            Console.WriteLine($"Log : {value} is added at the left node of {currentNode.Value}");
                            currentNode.LeftNode = newNode;
                            count++;
                            return true;
                        }
                        else
                        {
                            currentNode = currentNode.LeftNode;
                        }
                    }
                }
            }

        }

        // To find specific value in BST
        public bool Contain(decimal value)
        {
            if (root == null) return false;

            bool IsContain = false;
            var currentNode = root;

            while(currentNode != null && IsContain == false)
            {
                if(currentNode.Value == value)
                {
                    IsContain = true;
                }
                else if(currentNode.Value < value)
                {
                    currentNode = currentNode.RightNode;
                }
                else
                {
                    currentNode = currentNode.LeftNode;
                }
            }

            return IsContain;
        }


        // Breadth first search (BFS-Algorithm)
        public decimal[] BreadthFirstSearch()
        {
            if (root == null) return new decimal[count];
            
            var queue = new Data_Structures.StackAndQueue.Queue<Node>();
            var data = new decimal[count];

            var currentNode = root;
            var index = 0;

            queue.AddToQueue(currentNode);

            while(queue.Count != 0)
            {
                currentNode = queue.RemoveFromQueue().Value;
                data[index] = currentNode.Value;

                if(currentNode.LeftNode != null) queue.AddToQueue(currentNode.LeftNode);
                if(currentNode.RightNode != null) queue.AddToQueue(currentNode.RightNode);

                index++;
            }

            return data;
        }

        // Pre Order Depth First 
        public decimal[] PreOrderDepthFirstSearch()
        {
            var data = new List<decimal>();
            if(root == null) return data.ToArray();

            data = PreOrderDFSHelper(data, root);

            return data.ToArray();
        }

        public List<decimal> PreOrderDFSHelper(List<decimal> data,Node node)
        {
            data.Add(node.Value);
            if(node.LeftNode != null) PreOrderDFSHelper(data,node.LeftNode);
            if (node.RightNode != null) PreOrderDFSHelper(data, node.RightNode);

            return data;
        }

        //Post order Depth First
        public decimal[] PostOrderDepthFirstSearch()
        {
            var data = new List<decimal>();
            if (root == null) return data.ToArray();

            data = PostOrderDFSHelper(data, root);

            return data.ToArray();
        }
        public List<decimal> PostOrderDFSHelper(List<decimal> data, Node node)
        {
            if (node.LeftNode != null) PostOrderDFSHelper(data, node.LeftNode);
            if (node.RightNode != null) PostOrderDFSHelper(data, node.RightNode);

            data.Add(node.Value);

            return data;
        }

        //In order Depth First
        public decimal[] InOrderDepthFirstSearch()
        {
            var data = new List<decimal>();
            if (root == null) return data.ToArray();

            data = InOrderDFSHelper(data, root);

            return data.ToArray();
        }

        public List<decimal> InOrderDFSHelper(List<decimal> data, Node node)
        {
            if (node.LeftNode != null) InOrderDFSHelper(data, node.LeftNode);
            data.Add(node.Value);
            if (node.RightNode != null) InOrderDFSHelper(data, node.RightNode);

            return data;
        }


        public class Node
        {
            public Node(decimal value)
            {
                this.Value = value;
                this.LeftNode = null;
                this.RightNode = null;
            }

            public decimal Value { get; set; }
            public Node? LeftNode { get; set; }
            public Node? RightNode { get; set; }
        }
    }
}
