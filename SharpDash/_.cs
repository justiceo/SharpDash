using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDash
{
    public static class _
    {
        /**
         * Utility methods
         */
        public static string Replace(string source, string oldString, string newString, StringComparison comp)
        {
            return source.Replace(oldString, newString, comp);
        }
    }
}
