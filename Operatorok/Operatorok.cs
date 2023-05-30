using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
    internal class Operatorok
    {
        //  mod, div, @, /, +, -, *, 

        int bal;
        string Operator;
        int jobb;

        public Operatorok(int bal, string @operator, int jobb)
        {
            this.bal = bal;
            Operator = @operator;
            this.jobb = jobb;
        }

        public int Bal { get => bal;  }
        public string Operator1 { get => Operator; }
        public int Jobb { get => jobb;  }
    }
}
