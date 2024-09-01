namespace QueueExercises
{
    class QueueLinkedList
    {
        Node front;
        Node rear;
        public QueueLinkedList()
        {
            front = null;
            rear = null;
        }

        public bool IsEmpty() => front == null ? true : false;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                front = rear = newNode;
                return;
            }

            rear.next = newNode;
            rear = newNode;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Queue is empty");
            }

            var temp = front;

            front = temp.next;
            return temp.data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The Queue is empty");
            else
                return front.data;
        }

        public void Print()
        {
            if (IsEmpty())
                return;

            Node temp = this.front;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }

    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}