using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    class Variable : Identifier
    {
        public object Value { get; set; }

        public Variable(string name, IdentUses identUse, IdentTypes identType, object value) : base(name, IdentUses.VARS, identType)
        {
            Value = value;
        }

        public Variable() : base()
        {
            Value = null;
        }
    }
}
