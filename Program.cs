using System;

namespace WeekTwoTaskDataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Welcome to data organization, structuring and accessing ***************");
            Console.WriteLine();
            LinkedListNew<string> listNew = new LinkedListNew<string>();
            TheStack<string> stack = new TheStack<string>();
            TheQueue<string> queue = new TheQueue<string>();
            LinkedListNew<int> listNewInt = new LinkedListNew<int>();
            TheStack<int> stackInt = new TheStack<int>();
            TheQueue<int> queueInt = new TheQueue<int>();
            listNew.Add("");
            listNew.Add("");

        }
    }
}
