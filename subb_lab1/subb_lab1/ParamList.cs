using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    public class ParamList
    {
        public enum ParamTypes { VALUE, LINK, OUT}

        public string Name { get; set; }
        public Identifier.IdentTypes ParamIdentType { get; set; }
        public ParamTypes ParamType { get; set; }
        public object Value { get; set; }

        public ParamList Next { get; set; }

        public ParamList(string name, Identifier.IdentTypes identType, ParamTypes paramType, object value)
        {
            Name = name;
            ParamIdentType = identType;
            ParamType = paramType;
            Value = value;
        }

        public void AddParam(string name, Identifier.IdentTypes identType, ParamTypes paramType, object value)
        {
            ParamList curr = this;

            while(curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = new ParamList(name, identType, paramType, value);
        }
    }
}
