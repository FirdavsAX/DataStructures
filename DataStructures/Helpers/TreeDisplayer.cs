using DataStructures.DataStructures;
using System.Security;

namespace DataStructures.Helpers;

public static class TreeDisplayer
{
    #region Non-recursive Dispalying tree with order
    public static void InOrder(TreeNode node)
    {
        if(node == null) return;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = node;

        while (current != null || stack.Count > 0)
        {
            while(current != null)
            {
                stack.Push(current);
                current = current.Left;
            }
            current = stack.Pop();
            Console.Write(current.Value + " ");
            current = current.Right;
        }
    }
    public void PreOrder(TreeNode root)
    {
        if (root == null) return;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            Console.Write(node.Value + " ");

            if (node.Right != null) stack.Push(node.Right);
            if (node.Left != null) stack.Push(node.Left);
        }
    }

    // Have a did not saw
    public void PostOrder(TreeNode root)
    {
        if (root == null) return;

        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();

        stack1.Push(root);

        while (stack1.Count > 0)
        {
            TreeNode node = stack1.Pop();
            stack2.Push(node);

            if (node.Left != null) stack1.Push(node.Left);
            if (node.Right != null) stack1.Push(node.Right);
        }

        while (stack2.Count > 0)
        {
            TreeNode node = stack2.Pop();
            Console.Write(node.Value + " ");
        }
    }

    #endregion

    #region Recursive Display with Order
    public static void InOrderDisplay(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        InOrderDisplay(node.Left);
        Console.Write(node.Value + " ");
        InOrderDisplay(node.Right);
    }

    public static void PostOrderRec(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        PostOrderRec(node.Left);
        PostOrderRec(node.Right);
        Console.Write(node.Value + " ");
    }

    public static void PreOrderRec(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write(node.Value + " ");
        PreOrderRec(node.Left);
        PreOrderRec(node.Right);
    }
    #endregion

    #region Pretty Print Tree
    public static void PrettyPrint(BinaryTree tree)
    {
        if (tree.Root == null) return;
        int maxLevel = MaxLevel(tree.Root);
        PrettyPrintRec(new List<TreeNode> { tree.Root }, 1, maxLevel);
    }

    private static void PrettyPrintRec(List<TreeNode> nodes, int level, int maxLevel)
    {
        if (nodes.Count == 0 || AllElementsNull(nodes)) return;

        int floor = maxLevel - level;
        int edgeLines = (int)Math.Pow(2, (Math.Max(floor - 1, 0)));
        int firstSpaces = (int)Math.Pow(2, (floor)) - 1;
        int betweenSpaces = (int)Math.Pow(2, (floor + 1)) - 1;

        PrintWhitespaces(firstSpaces);

        List<TreeNode> newNodes = new List<TreeNode>();
        foreach (var node in nodes)
        {
            if (node != null)
            {
                Console.Write(node.Value);
                newNodes.Add(node.Left);
                newNodes.Add(node.Right);
            }
            else
            {
                newNodes.Add(null);
                newNodes.Add(null);
                Console.Write(" ");
            }
            PrintWhitespaces(betweenSpaces);
        }
        Console.WriteLine();

        for (int i = 1; i <= edgeLines; i++)
        {
            for (int j = 0; j < nodes.Count; j++)
            {
                PrintWhitespaces(firstSpaces - i);
                if (nodes[j] == null)
                {
                    PrintWhitespaces(edgeLines + edgeLines + i + 1);
                    continue;
                }

                if (nodes[j].Left != null)
                    Console.Write("/");
                else
                    PrintWhitespaces(1);

                PrintWhitespaces(i + i - 1);

                if (nodes[j].Right != null)
                    Console.Write("\\");
                else
                    PrintWhitespaces(1);

                PrintWhitespaces(edgeLines + edgeLines - i);
            }
            Console.WriteLine();
        }

        PrettyPrintRec(newNodes, level + 1, maxLevel);
    }

    private static void PrintWhitespaces(int count)
    {
        for (int i = 0; i < count; i++)
            Console.Write(" ");
    }

    private static bool AllElementsNull(List<TreeNode> list)
    {
        foreach (var node in list)
            if (node != null) return false;
        return true;
    }

    private static int MaxLevel(TreeNode node)
    {
        if (node == null) return 0;
        return Math.Max(MaxLevel(node.Left), MaxLevel(node.Right)) + 1;
    }
    #endregion 
}

