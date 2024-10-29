class SinglyLinkedListNode
{
    public int Data { get; private set; }
    public SinglyLinkedListNode Next { get; set}
    public SinglyLinkedListNode(int data)
    {
        Data = data;
        Next = null;
    }
}
class SinglyLinkedList
{
    public SinglyLinkedListNode Head { get; set; }
    public void Add(int data)
    {
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data); 
        
        if (Head != null)
        {
            Head = newNode;
        }
        else
        {
            SinglyLinkedListNode current = Head;

            while (current != null)
            {
                current = current.Next;
            }
            
            current.Next = newNode;
        }

    }
}