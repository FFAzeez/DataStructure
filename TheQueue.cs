using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTaskDataStructure
{
    public class TheQueue<T>
    {
        public int count;
        LinkedListNew<T> queue;
        public TheQueue()
        {
            queue = new LinkedListNew<T>();
            count = 0;
        }
        /// <summary>
        /// This method check if the Queue is empty or not.
        /// </summary>
        /// <returns>True of False</returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// The method to add data to the queue.
        /// </summary>
        /// <param name="data"></param>
        public void EnQueue(T data)
        {
            queue.Add(data);
            count++;
        }
        /// <summary>
        /// The method to remove data from queue.
        /// </summary>
        public T DeQueue()
        {
            if (queue.HeadNode == null)
                return default;
            T data = queue.HeadNode.Data;
            queue.Remove(data);
            count--;
            return data;
        }
        /// <summary>
        /// The method to count the data in the Queue.
        /// </summary>
        /// <returns name="data">count</returns>
        public int Size()
        {
            return count;
        }
        public void Print()
        {
            queue.Print();
        }
    }
}
