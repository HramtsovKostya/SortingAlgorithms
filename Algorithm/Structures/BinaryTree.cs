using Algorithm.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Structures
{
    /// <summary>
    /// Сортировка двоичным деревом поиска.
    /// </summary>
    /// <typeparam name="T"> Тип принимаемых данных. </typeparam>
    public class BinaryTree<T> : SortBase<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public BinaryTree() { }

        public BinaryTree(IEnumerable<T> items)
        {
            var list = items.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                var node = new Node<T>(item, i);
                
                Items.Add(item);                
                Add(node);
            }
        }

        public void Add(Node<T> node)
        {
            if (Root == null) Root = node;            
            else Add(Root, node);

            Count++;
        }

        private void Add(Node<T> node, Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null) node.Left = newNode;
                else Add(node.Left, newNode);
            }
            else
            {
                if (node.Right == null) node.Right = newNode;
                else  Add(node.Right, newNode);
            }
        }

        protected override void MakeSort()
        {
            var result = InOrder(Root).Select(i => i.Data).ToList();

            for (int i = 0; i < result.Count; i++)
                Set(result[i], i);
        }

        private List<Node<T>> InOrder(Node<T> node)
        {
            var list = new List<Node<T>>();

            if (node.Left != null)
                list.AddRange(InOrder(node.Left));
            
            list.Add(node);

            if (node.Right != null)
                list.AddRange(InOrder(node.Right));

            return list;
        }            

        public override string ToString()
        {
            return "Сортировка деревом";
        }        
    } 
}