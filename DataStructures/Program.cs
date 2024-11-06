using DataStructures.DataStructures;
using DataStructures.Samples;

TreeSample.CheckBinaryTreeOrderDisplays();

static void TestStackAndQueue()
{
    // Test Stack
    Console.WriteLine("Testing Stack:");
    Stack stack = new Stack();
    stack.Push(10);
    stack.Push(20);
    stack.Push(30);
    Console.WriteLine($"Top item: {stack.Peek()}"); // Expected output: 30

    while (!stack.IsEmpty())
    {
        Console.WriteLine($"Popped item: {stack.Pop()}");
    }

    // Test Queue
    Console.WriteLine("\nTesting Queue:");
    Queue queue = new Queue();
    queue.Enqueue(10);
    queue.Enqueue(20);
    queue.Enqueue(30);
    Console.WriteLine($"Front item: {queue.Peek()}"); // Expected output: 10

    while (!queue.IsEmpty())
    {
        Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
    }
}
static void TestSinglyLinkedList()
{
    // Create a new instance of the SinglyLinkedList
    SinglyLinkedList list = new SinglyLinkedList();

    // Adding elements to the list
    Console.WriteLine("Adding elements to the list:");
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.Display(); // Expected output: 10 -> 20 -> 30 -> null

    // Searching for elements
    Console.WriteLine("Searching for elements:");
    Console.WriteLine($"Searching for 20: {list.Search(20)}"); // Expected output: true
    Console.WriteLine($"Searching for 40: {list.Search(40)}"); // Expected output: false

    // Removing an element
    Console.WriteLine("Removing an element:");
    list.Remove(20);
    list.Display(); // Expected output: 10 -> 30 -> null

    // Attempting to remove a non-existent element
    Console.WriteLine("Attempting to remove a non-existent element (40):");
    list.Remove(40);
    list.Display(); // Expected output: 10 -> 30 -> null

    // Removing the head element
    Console.WriteLine("Removing the head element (10):");
    list.Remove(10);
    list.Display(); // Expected output: 30 -> null

    // Removing the last element
    Console.WriteLine("Removing the last element (30):");
    list.Remove(30);
    list.Display(); // Expected output: null
}
static void TestDoublyLinkedList()
{
    // Create a new instance of the DoublyLinkedList
    DoublyLinkedList list = new DoublyLinkedList();

    // Adding elements to the list
    Console.WriteLine("Adding elements to the list:");
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.PrintList(); // Expected output: 10 20 30 

    // Print the list in reverse
    Console.WriteLine("Printing the list in reverse:");
    list.PrintReverse(); // Expected output: 30 20 10 

    // Removing an element
    Console.WriteLine("Removing an element (20):");
    list.Remove(20);
    list.PrintList(); // Expected output: 10 30 

    // Attempting to remove a non-existent element
    Console.WriteLine("Attempting to remove a non-existent element (40):");
    list.Remove(40);
    list.PrintList(); // Expected output: 10 30 

    // Removing the head element
    Console.WriteLine("Removing the head element (10):");
    list.Remove(10);
    list.PrintList(); // Expected output: 30 

    // Removing the last element
    Console.WriteLine("Removing the last element (30):");
    list.Remove(30);
    list.PrintList(); // Expected output: (empty list)
}