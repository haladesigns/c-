using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_csharp.ch3
{
    class bsortest
    {
        //public delegate bool isLargerThan(Object a, Object b);

        public static Func<Object, Object, bool> ilt_int = (a, b) => ((int)a > (int)b);
        public static Func<Object, Object, bool> ilt_string = (a, b) => ((char)a > (char)b);

    }
}
