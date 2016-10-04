using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartkey_Calculator
{
    public class CalculatorEngine
    {
        public static int Calculate(int key)
        {
            int licence = (83885991 ^ key) * 7 - 95899545;
            return licence;
        }
    }
}