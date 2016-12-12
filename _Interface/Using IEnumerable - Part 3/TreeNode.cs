using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEnumerable___Part_3
{
    public class TreeNode : IEnumerable<TreeNode>
    {
        // The data contained in this node.
        public string Data { get; set; }

        // The node's child nodes.
        public List<TreeNode> Children = new List<TreeNode>();

        // Constructor.
        public TreeNode(string data)
        {
            Data = data;
        }

        // Return an enumerator for the tree rooted at this node.
        public IEnumerator<TreeNode> GetEnumerator()
        {
            yield return this;
            foreach (TreeNode child in Children)
            {
                foreach (TreeNode node in child)
                    yield return node;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
