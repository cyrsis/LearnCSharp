using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEnumerable___Part_1
{
    public class TreeNodeEnumerator : IEnumerator<TreeNode>
    {
        // The tree's pre-order traversal.
        private List<TreeNode> Traversal;

        // The index of the current node in the enumeration.
        private int CurrentIndex = -1;

        // Create an enumerator.
        public TreeNodeEnumerator(TreeNode root)
        {
            // Get the tree's pre-order traversal.
            Traversal = root.PreorderTraversal();
            CurrentIndex = -1;
        }

        public TreeNode Current
        {
            get
            {
                return Traversal[CurrentIndex];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            Traversal = null;
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return (CurrentIndex < Traversal.Count);
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }
    }
}
