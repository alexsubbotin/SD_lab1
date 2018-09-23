using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    class Tree
    {
        public Identifier Identifier { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public Tree(Identifier identifier)
        {
            Identifier = identifier;
            Left = null;
            Right = null;
        }

        public static void AddTree(ref Tree root, Identifier identifier)
        {
            if (root == null)
            {
                root.Identifier = identifier;
                return;
            }

            if (identifier.Hash < root.Identifier.Hash)
            {
                root = root.Left;
                AddTree(ref root, identifier);
            }
            else
            {
                root = root.Right;
                AddTree(ref root, identifier);
            }
        }
    }
}
