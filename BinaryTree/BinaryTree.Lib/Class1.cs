using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///     constuctor: special methods; call method in a class
///                 creates instance of an object
///     properties: special methods; getter & setter (doesn't need arguments)
///                 performs function within the library
///                 
///     TASK:
///         Insert a new value
///         Check if a value is present
///         Depth of the tree 
///         Sum the tree 
///         Lowest common ancestor of two values
///         Delete a value 
///         Output in order, i.e. In-order traversal 
/// </summary>

namespace BinaryTree.Lib
{
    public class BinaryTree
    {
        private BinaryTreeNode root;      // root position (the container)
        public BinaryTreeNode Root
        {   get { return root; }   }

        public BinaryTree()
        {
            // default constructor: null
        }

        public BinaryTree(int rootval)
        {
            // default constructor: with root value taken in
            root = new BinaryTreeNode(rootval);      // generates an root node with initial I/P integer stored
        }

        internal void Append(int newvalue)
        {
            if (root == null)          // base case
                root = new BinaryTreeNode(newvalue);    // if empty, add a node
            root.Append(newvalue);     // passes into the binarytreenode class method
        }

        public void Remove(int existedvalue)
        {
            if (root == null)
                throw new ArgumentNullException();
            root.Remove(existedvalue, Root);    
            // it passed into the node class because user SHOULDN'T input the root node
        }

        internal bool IsRepeated(int newvalue)
        {
            return (newvalue == 1);
        }
    }

    public class BinaryTreeNode
    {
        private int value;              // head value
        internal int Value
        {   get { return value; }  }

        private BinaryTreeNode lhs;    
        internal BinaryTreeNode LHS     // keep lhs private, call LHS instead within the namespace
        {   get { return lhs; }
            set { lhs = value; }    }

        private BinaryTreeNode rhs;
        internal BinaryTreeNode RHS
        {   get { return rhs; }
            set { rhs = value; }    }
        
        public BinaryTreeNode (int newvalue)
        {   value = newvalue;      }    // value container


        public void Append (int newvalue)
        {
            // selection
            if (lhs == null && newvalue < value)
                lhs = new BinaryTreeNode(newvalue);    // add a new left node (from null)
            
            else if (rhs == null && newvalue >= value)
                rhs = new BinaryTreeNode(newvalue);    // add a new right node (from null)
            
            (newvalue >= value ? rhs : lhs).Append(newvalue);        // tertiary operator + recursion
            // Apply .Append on _LHS or _RHS via recursion
        }

        public void Remove (int disposedvalue, BinaryTreeNode ROOT)
        {
            BinaryTreeNode AncestorNode = ROOT;     // the ancestor of a root node is itself
            BinaryTreeNode CurrentNode = ROOT;
            
            while (CurrentNode != null && CurrentNode.Value != disposedvalue)
            {

                CurrentNode = (disposedvalue < value ? CurrentNode.lhs : CurrentNode.rhs);
                AncestorNode = CurrentNode;         // prepared for
            }


            return; // CurrentNode = null
        }

        internal bool IsLeaf(BinaryTreeNode thenode)
        {
            return (lhs == null && rhs == null);
        }

        internal bool IsOneSideStem(BinaryTreeNode thenode)
        {
            return (lhs == null ^ rhs == null);
        }

        internal bool IsRepeated(int newvalue)
        {
            if (lhs == null || rhs == null)
            {
                return false;
            }
        }
    }
}

