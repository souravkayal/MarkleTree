using System.Security.Cryptography;
using System.Text;

namespace Markel.Tree
{
    public class TreeNode
    {
        public string Hash { get; set; }
        private TreeNode Left { set; get; }
        private TreeNode Right { get; set; }

        public TreeNode(string hash)
        {
            Hash = hash;
        }

        public TreeNode(TreeNode left, TreeNode right)
        {
            Left = left;
            Right = right;
            Hash = GetNodeHash();
        }

        public string GetNodeHash()
        {
            using (var sha1 = SHA1.Create())
            {
                return Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(Left?.Hash + Right?.Hash)));
            }
        }

    }
}
