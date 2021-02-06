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
    internal class BinaryTree
    {
        BinaryTreeNode _Root;      // root position (the container)

        internal BinaryTree()
        {
            // default constructor: null
        }

        internal BinaryTree(int rootval)
        {
            // default constructor: with root value taken in
            _Root = new BinaryTreeNode(rootval);      // generates an root node with initial I/P integer stored
        }

        internal void Append(int newvalue)
        {
            if (_Root == null)          // base case
                _Root = new BinaryTreeNode(newvalue);    // if empty, add a node
            _Root.Append(newvalue);     // passes into the binarytreenode class method
        }

        internal void Remove(int existedvalue)
        {
            if (_Root == null)
                throw new ArgumentNullException();
            _Root.Remove(existedvalue);
        }

        internal bool IsRepeated(int newvalue)
        {

        }

    }

    internal class BinaryTreeNode
    {
        int _Value;     // head value
        BinaryTreeNode _LHS;    
        BinaryTreeNode _RHS;
        
        internal BinaryTreeNode (int newvalue)
        {
            _Value = newvalue;          // initial value
        }

        internal void Append (int newvalue)
        {
            // selection
            if (_LHS == null && newvalue < _Value)
                _LHS = new BinaryTreeNode(newvalue);    // add a new left node (from null)
            
            else if (_RHS == null && newvalue >= _Value)
                _RHS = new BinaryTreeNode(newvalue);    // add a new right node (from null)
            
            (newvalue >= _Value ? _RHS : _LHS).Append(newvalue);        // tertiary operator + recursion
            // Apply .Append on _LHS or _RHS via recursion
        }

        internal void Remove (int existedvalue)
        {
            // selection
            if (_LHS == null && existedvalue < _Value)
                _LHS = _LHS._LHS;

            else if (_RHS == null && existedvalue >= _Value)
                _RHS = _RHS._RHS;

            (existedvalue >= _Value ? _RHS : _LHS).Remove(existedvalue);        // tertiary operator + recursion
            // Apply .Append on _LHS or _RHS via recursion
        }

        internal bool IsLeaf(BinaryTreeNode thenode)
        {
            return (_LHS == null && _RHS == null);
        }

        internal bool IsOneSideStem(BinaryTreeNode thenode)
        {
            return (_LHS == null ^ _RHS == null);
        }

        internal bool IsRepeated(int newvalue)
        {
            if (_LHS == null || _RHS == null)
            {
                return false;
            }
        }
    }

}

