﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class BBST
    {
        public int Count;
        public Node root;
        public BBST()
        {
            Count = 0;
            root = null;
        }
        private int Height(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = Height(current.left);
                int r = Height(current.right);
                int m = Math.Max(l, r);
                height = m + 1;
            }
            return height;
        }
        public int BalanceF(Node node)
        {
            int l = Height(node.left);
            int r = Height(node.right);
            int factor = l - r;
            return factor;
        }
        public Node Balance(Node node)
        {
            if (BalanceF(node) > 1)
            {
                if (BalanceF(node.left) > 0)
                    node = RotateLL(node);
                else RotateLR(node);
            }
            if (BalanceF(node) < -1)
            {
                if (BalanceF(node.right) > 0)
                    node = RotateRL(node);
                else RotateRR(node);
            }
            return node;
        }
        private Node RotateRR(Node node)
        {
            Node temp = node.right;
            node.right = temp.left;
            temp.left = node;
            return temp;
        }
        private Node RotateLL(Node node)
        {

            Node temp = node.left;
            node.left = temp.right;
            temp.right = node;
            return temp;


        }
        private Node RotateLR(Node node)
        {

            Node temp = node.left;
            node.left = RotateRR(temp);
            return RotateLL(node);


        }
        private Node RotateRL(Node node)
        {

            Node temp = node.right;
            node.right = RotateLL(temp);
            return RotateRR(node);


        }
        public int Size { get { return Count; } }
        public bool IsEmpty()
        {
            if (Count == 0) return true;
            else return false;
        }
        public bool IsFull()
        {
            bool result = false;
            Node tryy = new Node();
            if (tryy == null)
                return result = true;
            else
                return result;
        }
        public Node Add(ref Node root, int v)
        {

            if (root == null)
            {
                Count++;
                return root = new Node(v);
            }
            else if (v <= root.Data)
            {
                root.left = Add(ref root.left, v);
                root = Balance(root);
            }
            else if (v > root.Data)
            {
                root.right = Add(ref root.right, v);
                root = Balance(root);
            }
            return root;
        }
        public Node Delete(ref Node root,int v)
        {
            Node parent;
            if (root == null)
            {
                return null;
            }
            else if (v < root.Data)
            {
                root.left = Delete(ref root.left, v);
                if (BalanceF(root) == -2)
                {
                    if (BalanceF(root.right) <= 0)
                    {
                        root = RotateRR(root);
                    }
                    else
                    {
                        root = RotateRL(root);
                    }
                }
            }
            else if (v > root.Data)
            {
                root.right = Delete(ref root.right, v);
                if (BalanceF(root) == 2)
                {
                    if (BalanceF(root.left) >= 0)
                    {
                        root = RotateLL(root);
                    }
                    else
                    {
                        root = RotateLR(root);
                    }
                }
            }
            else
            {
                if (root.right != null)
                {
                    
                    parent = root.right;
                    while (parent.left != null)
                    {
                        parent = parent.left;
                    }
                    root.Data = parent.Data;
                    root.right = Delete(ref root.right, parent.Data);
                    if (BalanceF(root) == 2)
                    {
                        if (BalanceF(root.left) >= 0)
                        {
                            root = RotateLL(root);
                        }
                        else { root = RotateLR(root); }
                    }
                }
                else
                {   
                    return root.left;
                }
            }
            Count--;
            return root;
        }
        public BBST DeleteDup(ref Node root)
        {
            if (root != null)
            {
                Node temp = root;
                Node temp2 = root;
                while (temp != null)
                {
                    temp = Searchh(ref root.left, root.Data);
                    if (temp != null)
                        Delete(ref root, root.Data);
                }
                while (temp2 != null) 
                { 
                    temp2 = Searchh(ref root.right, root.Data);
                    if (temp2 != null)
                       Delete(ref root, root.Data);
                }
                DeleteDup(ref root.left);
                DeleteDup(ref root.right);
                return this;
            }
            else
            return null;
        }       
        
        public Node Search(ref Node root, int v)
        {
            if (root == null)
            {
                Console.WriteLine("There isn't such node in the tree.");
                return null;
            }
            if (v == root.Data)
                return root;
            if (v < root.Data)
            {
                return Search(ref root.left, v);
            }
            else return Search(ref root.right, v);
        }
        private Node Searchh(ref Node root, int v)
        {
            if (root == null)
            {
                return null;
            }
            if (v == root.Data)
                return root;
            if (v < root.Data)
            {
                return Searchh(ref root.left, v);
            }
            else return Searchh(ref root.right, v);
        }
        public void InOrderPrint(Node root)
        {
            if (root != null)
            {
                InOrderPrint(root.left);
                Console.Write(" "+root.Data);
                InOrderPrint(root.right);
            }
        }
        public void PreOrderPrint(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(" " + root.Data);
                PreOrderPrint(root.left);
                PreOrderPrint(root.right);
            }
        }
        public void PostOrderPrint(Node root)
        {
            if (root != null)
            {
                PostOrderPrint(root.left);
                PostOrderPrint(root.right);
                Console.WriteLine(" " + root.Data);
            }
        }
    }


}
