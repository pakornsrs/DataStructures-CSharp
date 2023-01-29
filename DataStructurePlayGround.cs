using Data_Structures.DataStructure;

namespace Data_Structures
{
    internal class DataStructurePlayGround
    {
        static void Main(string[] args)
        {
            SinglyLinkedListTest();
        }

        private static void SinglyLinkedListTest()
        {
            var LinkedList = new SinglyLinkedList<String>();

            LinkedList.Push("Mike");
            LinkedList.Push("Love");
            LinkedList.Push("Ton");

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            LinkedList.Insert(2, "And");

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            LinkedList.Insert(2, "Earth");

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            LinkedList.Remove(3);

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            LinkedList.Remove(3);

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            LinkedList.Insert(2, "And");

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());

            LinkedList.Insert(2, "Ton");

            Console.WriteLine(LinkedList.Length);
            Console.WriteLine(LinkedList.DisplayLinkedListValue());
            Console.WriteLine("Head is " + LinkedList.Head.Value);
            Console.WriteLine("Tail is " + LinkedList.Tail.Value);

            Console.WriteLine("\nall Reverse\n");

            LinkedList.Reverse();

            Console.WriteLine(LinkedList.DisplayLinkedListValue());
            Console.WriteLine("Head is " + LinkedList.Head.Value);
            Console.WriteLine("Tail is " + LinkedList.Tail.Value);

        }
    }
}