using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTaskDataStructure
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T item)
        {
            Data = item;
            Next = null;
        }
    }
}
