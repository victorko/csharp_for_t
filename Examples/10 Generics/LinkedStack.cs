using System;

namespace Examples.Generics
{
    public class LinkedStack<T> : IStack<T>
    {
        private class Node
        {
            public T Data;
            public Node Link;
        }

        private Node top;

        public bool IsEmpty
        {
            get { return this.top == null; }
        }

        public void Push(T item)
        {
            var node = new Node
            {
                Data = item,
                Link = this.top
            };
            this.top = node;
        }

        public T Pop()
        {
            if (this.IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            var node = this.top;
            this.top = node.Link;
            return node.Data;
        }
    }
}
