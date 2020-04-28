using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    class vars
    {
        public static char currentOperator = constants.NO_OPERATOR,
            lastOperation = constants.NO_OPERATION;
        public static double first = 0, second = 0, ans = 0;
    }
}
