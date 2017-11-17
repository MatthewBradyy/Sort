using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class node
    {
        public int node_value;
        public node rightleaf;
        public node leftleaf;
        public node(int value)
        {
            node_value = value;
        }
    }
}
