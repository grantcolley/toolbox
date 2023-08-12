namespace Toolbox.DataStructures
{
    public class Queue<T>
    {
        private readonly Stack<T> _input = new();
        private readonly Stack<T> _output = new();

        public void Enqueue(T t)
        {
            // Push t onto the input stack
            
            _input.Push(t);
        }

        public T Dequeue()
        {
            if (_output.Count == 0)
            {
                // Only if the output stack is empty 
                // and the input stack has items,
                // then transfer the contents of the 
                // input stack to the output stack.

                while (_input.Count != 0)
                {
                    _output.Push(_input.Pop());
                }
            }

            // Items are popped off the output stack
            // in the order they were originally 
            // pushed onto the input stack.

            // InvalidOperationException is 
            // thrown if the queue is empty.

            return _output.Pop();
        }

        public T Peek() 
        {
            // Returns the object at the top of the 
            // output stack without removing it.

            // InvalidOperationException is 
            // thrown if the queue is empty.

            return _input.Peek();
        }
    }
}
