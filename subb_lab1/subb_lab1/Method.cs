using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    public class Method: Identifier
    {
        public ParamList paramList;

        public Method(string name, IdentTypes identType, ParamList paramList):
            base(name, IdentUses.METHODS, identType)
        {
            this.paramList = paramList;
        }
    }
}
