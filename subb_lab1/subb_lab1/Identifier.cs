using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subb_lab1
{
    public abstract class Identifier
    {
        public enum IdentTypes { int_type, float_type, bool_type, char_type, string_type, class_type };
        public enum IdentUses { CLASSES, CONSTS, VARS, METHODS }

        protected string name;
        protected int hash;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                hash = name.Length;
            }
        }
        public int Hash
        {
            get
            {
                return hash;
            }
            set { }
        }
        public IdentUses IdentUse { get; set; }
        public IdentTypes IdentType { get; set; }

        public Identifier(string name, IdentUses identUse, IdentTypes identType)
        {
            Name = name;
            IdentUse = identUse;
            IdentType = identType;
        }

        public Identifier()
        {
            Name = "";
        }
    }
}