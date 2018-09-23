using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    class Class:Identifier
    {
        public Class(string name) : base(name, IdentUses.CLASSES, IdentTypes.class_type) { }

        public Class() : base() { }
    }
}
