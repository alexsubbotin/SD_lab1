using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    public class Method: Identifier
    {
        public ParamList ParamList { get; set; }

        public Method(string name, IdentTypes identType, ParamList paramList):
            base(name, IdentUses.METHODS, identType)
        {
            ParamList = paramList;
        }

        public Method() : base()
        {
            ParamList = null;
        }
    }
}
