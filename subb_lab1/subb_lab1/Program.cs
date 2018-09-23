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
            
        }

        public static void ParseFile()
        {
            StreamReader sr = new StreamReader("input.txt");

            string input = sr.ReadLine();

            while (input != "")
            {
                string[] inputArr = input.Split(' ');

                if (inputArr[0] == "const")
                {

                }
            }
        }

        private static Identifier CreateConst(string input)
        {
            Const newConst = new Const();

            string[] inputArr = input.Split(' ');

            bool knownType = false;

            switch (inputArr[1])
            {
                case "int":
                    newConst.IdentType = Identifier.IdentTypes.int_type;
                    knownType = true;
                    break;

                case "float":
                    newConst.IdentType = Identifier.IdentTypes.float_type;
                    knownType = true;
                    break;

                case "bool":
                    newConst.IdentType = Identifier.IdentTypes.bool_type;
                    knownType = true;
                    break;

                case "char":
                    newConst.IdentType = Identifier.IdentTypes.char_type;
                    knownType = true;
                    break;

                case "string":
                    newConst.IdentType = Identifier.IdentTypes.string_type;
                    knownType = true;
                    break;
            }

            if (!knownType)
                newConst.IdentType = Identifier.IdentTypes.class_type;

            newConst.Name = inputArr[2];

            if (inputArr[3] != "" && inputArr[3] == "=")
                newConst.Value = inputArr[4];

            return newConst;
        }
    }
}
