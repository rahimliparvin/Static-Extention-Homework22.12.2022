using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework22._12._2022
{
    public static class Extentionpow

    {
        public static int GetProd( this int num , int pow)
        {
            num = 5;
            pow = 3;
            var result = Math.Pow(num, pow);
            return (int)result;
        }
    }
}
