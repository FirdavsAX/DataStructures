namespace DataStructures.DataStructures;

public class QueueNode
{
    public int Data { get; set; }
    public QueueNode Next { get; set; }

    public QueueNode(int data)
    {
        Data = data;
        Next = null;
    }
}

public class Queue
{
    private QueueNode front;
    private QueueNode rear;

    // Enqueues an item to the end of the queue
    public void Enqueue(int data)
    {
        var newNode = new QueueNode(data);
        if (rear != null)
        {
            rear.Next = newNode;
        }
        rear = newNode;

        if (front == null)
        {
            front = rear;
        }
    }

    // Dequeues an item from the front of the queue
    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty.");

        int data = front.Data;
        front = front.Next;

        if (front == null)
            rear = null;

        return data;
    }

    // Peeks at the front item of the queue without removing it
    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty.");

        return front.Data;
    }

    // Checks if the queue is empty
    public bool IsEmpty()
    {
        return front == null;
    }
}
