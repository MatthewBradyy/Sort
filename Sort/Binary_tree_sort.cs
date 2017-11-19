using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Binary_tree_sort
    {
        public List<int> numbers = new List<int>();       
        private static node root;
        private node focus;
        private node parent;
        public void build_tree()
        {
            root = null;
        }
        public int[] get_array(int[] list)
        {
            sort(list);
            return numbers.ToArray();
        }
        public void sort(int[] list)
        {
            foreach (int n in list)
            {
                add(n);
            }
            buildlist(root);

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
                        }
                    }
                    else
                    {
                        focus = focus.rightleaf;
                        if (focus == null)
                        {
                            parent.rightleaf = newnode;
                            added = true;                          
                        }

                    }


                }

            }
        }
        public void buildlist(node N)
        {
            if (N == null)
            {
                return;
            }
            buildlist(N.leftleaf);
            numbers.Add(N.node_value);
            buildlist(N.rightleaf);
        }
    }
}
