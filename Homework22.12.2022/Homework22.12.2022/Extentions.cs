using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework22._12._2022
{
    public static class Extentions
    { 
        public static int GetFactorial(this int num)
        {
            var result = 1;

            for (int i = 1; i <= num; i++)
            {
                if (true)
                {
                    result = result * i;
                }
            }
              return result;
        }
    }
}

    