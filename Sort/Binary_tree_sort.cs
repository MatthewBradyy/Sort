using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Binary_tree_sort
    {
        public int[] numbers = new int[10];
        public int counter = 0;
        public List<node> tree = new List<node>();
        private static node root;
        private node focus;
        private node parent;
        public void build_tree()
        {
            root = null;
        }
        public void get_array(int num)
        {
            numbers[counter] = num;
            counter++;

        }
        public void sort()
        {
            foreach (int n in numbers)
            {
                add(n);
            }
            display(root);
            Console.ReadLine();
        }
        public void add(int value)
        {
            focus = root;
            node newnode = new node(value);
            bool added = false;
            //no root in the tree
            if (root == null)
            {
                root = newnode;
                tree.Add(root);
                return;
            }
            else
            {

                parent = null;
                while (!added)
                {
                    parent = focus;
                    if (value < focus.node_value)
                    {
                        focus = focus.leftleaf;
                        if (focus == null)
                        {
                            parent.leftleaf = newnode;
                            added = true;
                            tree.Add(parent.leftleaf);
                        }
                    }
                    else
                    {
                        focus = focus.rightleaf;
                        if (focus == null)
                        {
                            parent.rightleaf = newnode;
                            added = true;
                            tree.Add(parent.rightleaf);
                        }

                    }


                }

            }
        }
        public void display(node N)
        {
            if (N == null)
            {
                return;
            }
            display(N.leftleaf);
            Console.WriteLine(N.node_value);
            display(N.rightleaf);
        }
    }
}
