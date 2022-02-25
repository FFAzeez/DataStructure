using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoTaskDataStructure
{
    public class TheStack<T>
    {
        private int count;
        LinkedListNew<T> stack;
        public TheStack()
        {
            stack = new LinkedListNew<T>();
            count = 0;
        }
        /// <summary>
        /// This method check if the stack is empty or not.
        /// </summary>
        /// <returns>True of False</returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// The method to add data to the stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            stack.Add(data);
            count++;
        }
        /// <summary>
        /// The method to remove and return data from stack.
        /// </summary>
        public T Pop()
        {
            if (stack.HeadNode == null)
                return default;
            T data = stack.HeadNode.Data;
            stack.Remove(data);
            count--;
            return data;
        }
        /// <summary>
        /// The method to return top element in a stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (stack.HeadNode == null)
                return default;
            return stack.HeadNode.Data;
        }
        /// <summary>
        /// The method to count the data in the stack
        /// </summary>
        /// <returns name="data">count</returns>
        public int Size()
        {
            return count;
        }
        public void Print()
        {
            stack.Print();
        }
    }
}
