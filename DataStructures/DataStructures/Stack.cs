namespace DataStructures.DataStructures;

public class StackNode
{
    public int Data { get; set; }
    public StackNode Next { get; set; }

    public StackNode(int data)
    {
        Data = data;
        Next = null;
    }
}

public class Stack
{
    private StackNode top;

    // Pushes an item onto the stack
    public void Push(int data)
    {
        var newNode = new StackNode(data);
        newNode.Next = top;
        top = newNode;
    }

    // Pops the top item from the stack
    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        int data = top.Data;
        top = top.Next;
        return data;
    }

    // Peeks at the top item of the stack without removing it
    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty.");

        return top.Data;
    }

    // Checks if the stack is empty
    public bool IsEmpty()
    {
        return top == null;
    }
}