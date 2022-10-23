using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD02
{
    public static class Tools
    {

        public static object GetIndexOfElementInArray<T>(T[] myArray, T v)
        {
            return Array.IndexOf(myArray, v);
        }
    }
}
