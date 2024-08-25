class LinkedListMainOperations
{
    public LinkedListMainOperations()
    { }
    public void Main()
    {
        var linkedList = new SingleLinkedList();

        //Testing insert operations
        linkedList.insertBegin(1);
        linkedList.insertBegin(2);
        linkedList.insertBegin(3);

        linkedList.insertEnd(4);

        linkedList.insertAfterPosition(5, 2);

        linkedList.printList();

        Console.WriteLine("-------");

        //Testing remove operations

        linkedList.removeBegin();
        linkedList.removeEnd();

        linkedList.printList();
        Console.WriteLine("-------");


        linkedList.insertEnd(6);
        linkedList.printList();
        Console.WriteLine("-------");

        linkedList.removeAtPosition(2);

        linkedList.printList();

        //Testing search operation
        linkedList.find(6);
        linkedList.find(8);

        //Testing revert operation
        linkedList.revert();
        Console.WriteLine($"Head of linked list reverted is: {linkedList.head.data}");
        
        linkedList.printList();
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

class SingleLinkedList
{
    public Node head;

    public SingleLinkedList()
    {
        head = null;
    }

    public void printList()
    {
        Node temp = this.head;

        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

    public void insertBegin(int item)
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

    public void insertEnd(int item)
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

    public void insertAfterPosition(int item, int pos)
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

    public void removeBegin()
    {
        if (this.head == null)
            return;

        this.head = this.head.next;

    }

    public void removeEnd()
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

    public void removeAtPosition(int pos)
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

    public void find(int item)
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

    public void revert()
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