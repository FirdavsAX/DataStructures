namespace DataStructures.DataStructures;

public class SinglyLinkedListNode
{
    // Property to store the data of the node
    public int Data { get; private set; }

    // Property to point to the next node in the list
    public SinglyLinkedListNode Next { get; set; }

    // Constructor to initialize the node with data
    public SinglyLinkedListNode(int data)
    {
        Data = data;
        Next = null; // Initialize Next to null
    }
}

public class SinglyLinkedList
{
    // Property to store the head of the list
    public SinglyLinkedListNode Head { get; private set; }

    // Method to add a new node with given data to the end of the list
    public void Add(int data)
    {
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

        // If the list is empty, set the new node as the head
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            // Traverse to the end of the list
            SinglyLinkedListNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            // Link the new node at the end
            current.Next = newNode;
        }
    }

    // Method to remove a node with a specific value
    public void Remove(int value)
    {
        if (Head == null) return; // List is empty

        // If the head node is to be removed
        if (Head.Data == value)
        {
            Head = Head.Next;
            return;
        }

        // Traverse to find the node to remove
        SinglyLinkedListNode current = Head;
        while (current.Next != null && current.Next.Data != value)
        {
            current = current.Next;
        }

        // If the node was found, unlink it
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    // Method to search for a specific value in the list
    public bool Search(int value)
    {
        SinglyLinkedListNode current = Head;
        while (current != null)
        {
            if (current.Data == value)
            {
                return true; // Value found
            }
            current = current.Next;
        }
        return false; // Value not found
    }

    // Method to display all elements in the list
    public void Display()
    {
        SinglyLinkedListNode current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null"); // Indicate the end of the list
    }
}
