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
            StreamReader sr = new StreamReader("input.txt");

            string input = sr.ReadLine();

            while(input != "")
            {
                string[] inputArr = input.Split(' ');

                if(inputArr[0] == "const")
                {

                }
            }
        }
    }
}
