using DataStructures.DataStructures;
using DataStructures.Helpers;

namespace DataStructures.Samples;

public class TreeSample
{
    public static void CheckBinaryTreeOrderDisplays()
    {
        var tree = new BinaryTree();
        int[] elements = new int[]
        {
           15, 10, 20, 8, 12, 17, 25, 6, 11, 13
        };

        foreach (int element in elements)
        {
            tree.Insert(element);
        }

        TreeDisplayer.PrettyPrint(tree);

        Console.WriteLine("\nIn-order display of tree:");
        tree.InOrderDisplay(tree.Root);

        Console.WriteLine("\nPre-order display of tree:");
        tree.PreOrder(tree.Root);

        Console.WriteLine("\nPost-order display of tree:");
        tree.PostOrder(tree.Root);

    }

}
