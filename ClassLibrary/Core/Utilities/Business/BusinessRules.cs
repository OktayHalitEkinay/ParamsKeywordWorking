using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.Utilities.Business
{
    public static class BusinessRules
    {
        public static bool Run(params bool[] logics)
        {
            foreach (var logic in logics)
            {
                if (logic==true)
                {
                    return logic;
                }
            }
            return false;
        }
    }
}
