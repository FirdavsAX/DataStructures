
namespace DataStructures.DataStructures;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }

}
public class BinaryTree
{
    public TreeNode Root;
    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int node)
    {
        Root = InsertRecursive(Root, node);
    }

    private TreeNode InsertRecursive(TreeNode root, int node)
    {
        if (root == null)
        {
            root = new TreeNode(node);
            return root;
        }

        if (root.Value > node)
        {
            root.Left = InsertRecursive(root.Left, node);
        }
        else if(root.Value < node) 
        {
            root.Right = InsertRecursive(root.Right, node);
        }

        return root;
    }

    public void InOrderDisplay(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        InOrderDisplay(node.Left);
        Console.WriteLine(node.Value);
        InOrderDisplay(node.Right);
    }

}
