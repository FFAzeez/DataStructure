using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTaskDataStructure
{
    public class LinkedListNew<T>
    {
        private int size;
        public Node<T> HeadNode;

        public LinkedListNew()
        {
            HeadNode=null;
            size=0;
        }
        public int Size()
        {
            return size;
        }
        /// <summary>
        /// The method to add data to the linkedlist.
        /// </summary>
        /// <param name="data"></param>
        public int Add(T data)
        {
           Node<T> valueNode = new Node<T>(data);
            if (HeadNode == null)
                HeadNode = valueNode;
            else
            {
                Node<T> newNode = HeadNode;
                while (newNode.Next != null)
                {
                    newNode = newNode.Next;
                }
                newNode.Next = valueNode;
            }
            size++;
            return size;
        }
        /// <summary>
        /// The method to remove and return true or false if the data is in the linkedlist.
        /// </summary>
        public bool Remove(T item)
        {
            if(HeadNode == null)
                return false;
            if (HeadNode.Data.Equals(item))
            {
                HeadNode = HeadNode.Next;
                return true;
            }
            Node<T> present = HeadNode;
            while (present.Next != null)
            {
                if (present.Next.Data.Equals(item))
                {
                    present.Next = present.Next.Next;
                    return true;
                }
                present = present.Next;
            }
            return false;
        }
        /// <summary>
        /// The method to check if the data is in the linkedlist.
        /// </summary>
        /// <param name="data"></param>
        public bool Check(T item)
        {
            Node<T> current = HeadNode;
            if(current==null)
                return false;
            if (current.Data.Equals(item))
                return true;

            while (current.Next != null)
            {
                current = current.Next;
                if(current.Data.Equals(item))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// The method to check if the data is in the linkedlist.
        /// </summary>
        /// <param name="data"></param>
        public int Index(T item)
        {
            Node<T> current = HeadNode;
            for (int i = 0; i < size; i++)
            {
                if (current.Data.Equals(item))
                {
                    return i;
                }
                current = current.Next;
                if (current==null)
                    return -1;
            }
            return -1;
        }
        public void Print()
        {
            Node<T> present = HeadNode;
            while (present != null)
            {
                Console.WriteLine(present.Data);
                present = present.Next;
            }

        }

    }
}
