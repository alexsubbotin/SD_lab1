using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    public class Const: Identifier
    {
        public object Value { get; set; } 

        public Const(string name, IdentTypes identType, object value) :base(name, IdentUses.CONSTS, identType)
        {
            Value = value;
        }

        public Const():base()
        {
            Value = null;
        }
    }
}
