using Merkle.Tree.Implementation;

namespace Merkle
{
    public class Program
    {
        public static void Main(String[]args)
        {
            var items = new List<string> 
            {
                "item-1",
                "item-2",
                "item-3",
                "item-4"
            };

            MerkleTree tree = new MerkleTree(items);

            Console.WriteLine($"Hash of the root node- {tree.Root.Hash}");

            Console.ReadLine();
        }
    }

}

