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

        public Tree()
        {
            Identifier = null;
            Left = null;
            Right = null;
        }

        public static void AddTree(ref Tree root, Identifier identifier)
        {
            if (root == null)
            {
                root = new Tree(identifier);
                return;
            }

            if (identifier.Hash < root.Identifier.Hash)
            {
                Tree buf = root.Left;
                AddTree(ref buf, identifier);
            }
            else
            {
                Tree buf = root.Right;
                AddTree(ref buf, identifier);
            }
        }
    }
}
