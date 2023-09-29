using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNTextPatch.Shared.Scripts.Artemis {
    internal class LuaBoolean : ILuaNode {
        public LuaBoolean(bool value) {
            Value = value;
        }

        public bool Value {
            get;
            set;
        }

        public override string ToString() {
            return Value.ToString().ToLower();
        }

        public void ToString(StringBuilder result, int indentLevel) {
            result.Append(ToString());
        }
    }
}
