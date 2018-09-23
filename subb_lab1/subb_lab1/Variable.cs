using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    class Variable:Identifier
    {
        public Variable(string name, IdentUses identUse, IdentTypes identType) : base(name, IdentUses.VARS, identType) { }

        public Variable() : base() { }
    }
}
