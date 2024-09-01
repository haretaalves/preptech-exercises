namespace LinkedListsExercises
{
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

    class SingleLinkedList
    {
        public Node head;

        public SingleLinkedList()
        {
            head = null;
        }

        public void PrintList()
        {
            Node temp = this.head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void InsertBegin(int item)
        {
            Node newNode = new Node(item);

            if (this.head == null)
            {
                this.head = newNode;
                return;
            }

            newNode.next = this.head;
            this.head = newNode;
        }

        public void InsertEnd(int item)
        {
            Node newNode = new Node(item);

            if (this.head == null)
            {
                this.head = newNode;
            }

            var prev = this.head;
            while (prev.next != null)
            {
                prev = prev.next;
            }

            prev.next = newNode;

        }

        public void InsertAfterPosition(int item, int pos)
        {
            Node newNode = new Node(item);

            var current = this.head;

            for (int i = 0; i < pos; i++)
            {
                if (current == null)
                    return;

                current = current.next;
            }

            newNode.next = current.next;
            current.next = newNode;
        }

        public void RemoveBegin()
        {
            if (this.head == null)
                return;

            this.head = this.head.next;

        }

        public void RemoveEnd()
        {
            if (this.head == null)
                return;

            if (this.head.next == null)
            {
                this.head = null;
                return;
            }

            Node secondLast = this.head;
            while (secondLast.next.next != null)
            {
                secondLast = secondLast.next;
            }

            secondLast.next = null;
        }

        public void RemoveAtPosition(int pos)
        {
            if (this.head == null)
                return;

            Node temp = this.head;
            Node prev = null;

            if (pos == 0)
            {
                this.head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < pos; i++)
            {
                prev = temp;
                temp = temp.next;
            }

            prev.next = temp.next;
        }

        public void Find(int item)
        {
            Node node = this.head;

            while (node != null && node.data != item)
            {
                node = node.next;
            }

            if (node == null)
            {
                Console.WriteLine($"Element not found: {item}");
            }
            else
            {
                Console.WriteLine($"Element found: {node.data}");
            }

        }

        public void Revert()
        {
            Node previous = null;
            Node current = this.head;
            Node next;
            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            this.head = previous;
        }
    }
}