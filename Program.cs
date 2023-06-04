using Markel.Tree;
using System.Security.Cryptography;
using System.Text;

namespace MarkleTree
{
    public class MarkleTree
    {
        public TreeNode Root { get; set; }
        public int Depth { get; set; } = 0;

        /// <summary>
        /// Constructor to take list of strings and build the tree
        /// </summary>
        /// <param name="values">List of items to be inserted in markle tree</param>
        public MarkleTree(List<string> values)
        {
            Root = GenerateMarkleTree(values);
        }

        /// <summary>
        /// Function to build markle tree using iterative process
        /// </summary>
        /// <param name="items">Tree would build with those items</param>
        /// <returns>Root node of tree </returns>
        /// <exception cref="ArgumentException">If there is no items in argument</exception>
        private TreeNode GenerateMarkleTree(List<String> items)
        {
            if (items.Count == 0) throw new ArgumentException("Markle tree cannot build with empty list");

            List<TreeNode> levels = new List<TreeNode>();

            foreach (var item in items)
            {
                var hash = GetHash(item);
                levels.Add(new TreeNode(hash));
            }

            while (levels.Count > 1)
            {
                Depth++;

                var parentNode = new List<TreeNode>();

                for (int i = 0; i < levels.Count; i+=2)
                {
                    var left = levels[i];

                    var right = (i + 1 < levels.Count) ? levels[i + 1] : left;

                    var parent = new TreeNode(left, right);

                    parentNode.Add(parent);
                }

                levels = parentNode;
            }

            return levels[0];
        }

        /// <summary>
        /// function to return hash of a string value
        /// </summary>
        /// <param name="value">Input string</param>
        /// <returns>Hash value of the input string </returns>
        private string GetHash(string value)
        {
            using (var sha1 = SHA1.Create())
            {
                 return Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(value)));
            }
        }
    }


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

            MarkleTree tree = new MarkleTree(items);

            Console.WriteLine($"Hash of the root node- {tree.Root.Hash}");

            Console.ReadLine();
        }
    }

}

