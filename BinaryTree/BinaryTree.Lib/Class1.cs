using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///     constuctor: special methods; call method in a class
///                 creates instance of an object
///     properties: specia methods; getter & setter (doesn't need arguments)
///                 performs function within the library
/// </summary>

namespace BinaryTree.Lib
{
    public class Binary_Tree
    {
        BinaryTreeNode _Root;      // root position (the container)

        public Binary_Tree()
        {
            // default constructor: null
        }

        public Binary_Tree(int rootval)
        {
            // default constructor: with root value taken in
            _Root = new BinaryTreeNode(rootval);      // generates an root node with initial I/P integer stored
        }

        public void Append(int newvalue)       // It only adds value into the tree, so no input
        {
            if (_Root == null)      // base case
            {
                _Root = new BinaryTreeNode(newvalue);    // if empty, add a node
            }
            _Root.Add(newvalue);    // goes into the binarytreenode
        }



    }

    public class BinaryTreeNode
    {
        int _Value;     // head value
        BinaryTreeNode _LHS;    
        BinaryTreeNode _RHS;
        
        public BinaryTreeNode (int newvalue)
        {
            _Value = newvalue;          // initial value
        }

        public void Add (int newvalue)
        {
            // selection
            if (_LHS == null && newvalue < _Value)
            {
                _LHS = new BinaryTreeNode(newvalue);    // add a new left node (from null)
            }
            else if (_RHS == null && newvalue >= _Value)
            {
                _RHS = new BinaryTreeNode(newvalue);    // add a new right node (from null)
            }
        }
                
        public bool IsLeaf(BinaryTreeNode thenode)
        {
            return (_LHS == null && _RHS == null);
        }

        public bool IsOneSideStem(BinaryTreeNode thenode)
        {
            return (_LHS == null ^ _RHS == null);
        }
            return
    }

}
