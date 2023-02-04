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
        }
        public Node? Root => root;
        private Node? root { get; set; }

        //To add value to BST
        public bool Add(decimal value)
        {
            var newNode = new Node(value);

            if(root == null)
            {
                Console.WriteLine($"Log : {value} is added as new root.");
                root = newNode;
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
