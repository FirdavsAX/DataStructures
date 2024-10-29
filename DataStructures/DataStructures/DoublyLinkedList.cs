namespace DataStructures.DataStructures;

public class DoublyLinkedListNode
{
    public int Data { get; private set; }
    public DoublyLinkedListNode Next { get; set; }
    public DoublyLinkedListNode Previous { get; set; }

    public DoublyLinkedListNode(int data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

public class DoublyLinkedList
{
    public DoublyLinkedListNode Head { get; private set; }
    public DoublyLinkedListNode Tail { get; private set; }

    // Method to add a new node to the end of the list
    public void Add(int data)
    {
        var newNode = new DoublyLinkedListNode(data);

        if (Head == null)
        {
            Head = newNode; // If the list is empty, set Head to the new node
            Tail = newNode; // Tail is also the new node
        }
        else
        {
            Tail.Next = newNode; // Link the new node to the end of the list
            newNode.Previous = Tail; // Set the Previous pointer of the new node
            Tail = newNode; // Update the Tail to the new node
        }
    }

    // Method to print the list from Head to Tail
    public void PrintList()
    {
        var current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    // Method to print the list from Tail to Head
    public void PrintReverse()
    {
        var current = Tail;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Previous;
        }
        Console.WriteLine();
    }

    // Method to remove a node with a specific value
    public void Remove(int value)
    {
        var current = Head;

        while (current != null)
        {
            if (current.Data == value)
            {
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                if (current == Head) // If it's the head node
                {
                    Head = current.Next;
                }
                if (current == Tail) // If it's the tail node
                {
                    Tail = current.Previous;
                }
                return;
            }
            current = current.Next;
        }
    }
}