using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace subb_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = ParseFile();

            ShowTree(tree, 0);

            Console.ReadLine();
        }

        public static Tree ParseFile()
        {
            Tree tree = new Tree();

            StreamReader sr = new StreamReader("input.txt");

            string input = sr.ReadLine();

            while (input != "")
            {
                string[] inputArr = input.Split(' ');

                if (inputArr[0] == "const")
                {
                    if (tree.Identifier.Name == "")
                        tree = new Tree(CreateConst(input));
                    else
                        Tree.AddTree(ref tree, CreateConst(input));
                }

                if (inputArr[0] == "class")
                {
                    if (tree.Identifier.Name == "")
                        tree = new Tree(CreateClass(input));
                    else
                        Tree.AddTree(ref tree, CreateClass(input));
                }

                if(input.IndexOf('(') != -1 && input.IndexOf(')') != -1)
                {
                    if (tree.Identifier.Name == "")
                        tree = new Tree(CreateMethod(input));
                    else
                        Tree.AddTree(ref tree, CreateMethod(input));
                }
                else
                {
                    if (tree.Identifier.Name == "")
                        tree = new Tree(CreateVariable(input));
                    else
                        Tree.AddTree(ref tree, CreateVariable(input));
                }

                input = sr.ReadLine();
            }

            return tree;
        }

        private static Identifier CreateConst(string input)
        {
            Const newConst = new Const();

            string[] inputArr = input.Split(' ');

            newConst.IdentType = GetType(inputArr[1]);

            newConst.IdentUse = Identifier.IdentUses.CONSTS;

            newConst.Name = inputArr[2];

            if (inputArr[3] != "" && inputArr[3] == "=")
                newConst.Value = inputArr[4];

            return newConst;
        }

        private static Identifier CreateClass(string input)
        {
            Class newClass = new Class();

            newClass.IdentUse = Identifier.IdentUses.CLASSES;

            string[] inputArr = input.Split(' ');

            newClass.Name = inputArr[1];

            return newClass;
        }

        private static Identifier CreateVariable(string input)
        {
            Variable newVariable = new Variable();

            string[] inputArr = input.Split(' ');

            newVariable.IdentUse = Identifier.IdentUses.VARS;

            newVariable.IdentType = GetType(inputArr[0]);

            newVariable.Name = inputArr[1];

            if (inputArr[2] != "" && inputArr[2] == "=")
                newVariable.Value = inputArr[3];

            return newVariable;
        }

        private static Identifier CreateMethod(string input)
        {
            Method newMethod = new Method();

            string[] inputArr = input.Split(' ');

            newMethod.IdentUse = Identifier.IdentUses.METHODS;

            newMethod.IdentType = GetType(inputArr[0]);

            newMethod.Name = inputArr[1].Substring(0, inputArr[1].IndexOf('('));

            newMethod.ParamList = GetParams(input.Substring(input.IndexOf('(') + 1, input.Length - input.IndexOf('(') - 3));

            return newMethod;
        }

        private static ParamList GetParams(string param)
        {
            string[] paramArr = param.Split(',');

            ParamList paramList = new ParamList();

            for(int i = 0; i < paramArr.Length; i++)
            {
                string[] oneParam = paramArr[i].Split(' ');

                if(oneParam[0] == "ref")
                {
                    if (i == 0)
                        paramList = new ParamList(paramArr[1], GetType(paramArr[2]), ParamList.ParamTypes.LINK);
                    else
                        paramList.AddParam(paramArr[1], GetType(paramArr[2]), ParamList.ParamTypes.LINK);
                }

                if (oneParam[0] == "out")
                {
                    if (i == 0)
                        paramList = new ParamList(paramArr[1], GetType(paramArr[2]), ParamList.ParamTypes.OUT);
                    else
                        paramList.AddParam(paramArr[1], GetType(paramArr[2]), ParamList.ParamTypes.OUT);
                }
                else
                {
                    if (i == 0)
                        paramList = new ParamList(paramArr[0], GetType(paramArr[1]), ParamList.ParamTypes.VALUE);
                    else
                        paramList.AddParam(paramArr[0], GetType(paramArr[1]), ParamList.ParamTypes.VALUE);
                }
            }

            return paramList;
        }

        private static Identifier.IdentTypes GetType(string type)
        {
            switch (type)
            {
                case "int":
                    return Identifier.IdentTypes.int_type;

                case "float":
                    return Identifier.IdentTypes.float_type;

                case "bool":
                    return Identifier.IdentTypes.bool_type;

                case "char":
                    return Identifier.IdentTypes.char_type;

                case "string":
                    return Identifier.IdentTypes.string_type;
            }

            return Identifier.IdentTypes.class_type;
        }

        static void ShowTree(Tree p, int l) // Печать дерева
        {
            if (p != null)
            {
                ShowTree(p.Left, l + 3);
                for (int i = 0; i < l; i++)
                    Console.Write(" ");
                Console.WriteLine(p.Identifier.Name + " " + p.Identifier.Hash + " " + p.Identifier.IdentType + " " + p.Identifier.IdentUse);
                ShowTree(p.Right, l + 3);

            }
        }
    }
}
