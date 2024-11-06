using DataStructures.DataStructures;

namespace DataStructures.Samples;

public class TreeSample
{
    public static void CheckBinaryTreeOrderDisplays()
    {
        var tree = new BinaryTree();
        int[] elements = new int[]
        {
           50, 30, 70, 20, 40, 60, 80, 10, 25, 35, 45, 55, 65, 75, 85,
           5, 15, 23, 28, 33, 38, 43, 48, 53, 58, 63, 68, 73, 78, 83, 88,
           3, 8, 13, 18, 27, 37, 47, 57
        };

        foreach (int element in elements)
        {
            tree.Insert(element);
        }

        PrettyPrint(tree);

        Console.WriteLine("In order displaying of tree");
        tree.InOrderDisplay(tree.Root);
    }



    public static void PrettyPrint(BinaryTree tree)
    {
        int maxLevel = GetMaxLevel(tree.Root);
        PrettyPrintRecursive(new List<TreeNode> { tree.Root }, 1, maxLevel);
    }

    private static void PrettyPrintRecursive(List<TreeNode> nodes, int level, int maxLevel)
    {
        if (nodes.Count == 0 || IsAllElementsNull(nodes))
        {
            return;
        }

        int floor = maxLevel - level;
        int edgeLines = (int)Math.Pow(2, Math.Max(floor - 1, 0));
        int firstSpaces = (int)Math.Pow(2, floor) - 1;
        int betweenSpaces = (int)Math.Pow(2, floor + 1) - 1;

        PrintWhitespaces(firstSpaces);

        List<TreeNode> newNodes = new List<TreeNode>();
        foreach (TreeNode node in nodes)
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
                {
                    Console.Write("/");
                }
                else
                {
                    PrintWhitespaces(1);
                }

                PrintWhitespaces(i + i - 1);

                if (nodes[j].Right != null)
                {
                    Console.Write("\\");
                }
                else
                {
                    PrintWhitespaces(1);
                }

                PrintWhitespaces(edgeLines + edgeLines - i);
            }

            Console.WriteLine();
        }

        PrettyPrintRecursive(newNodes, level + 1, maxLevel);
    }

    private static void PrintWhitespaces(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(" ");
        }
    }

    private static int GetMaxLevel(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        return Math.Max(GetMaxLevel(node.Left), GetMaxLevel(node.Right)) + 1;
    }

    private static bool IsAllElementsNull(List<TreeNode> list)
    {
        foreach (var node in list)
        {
            if (node != null)
            {
                return false;
            }
        }
        return true;
    }

}
