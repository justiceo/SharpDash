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
            int index = source.IndexOf(oldString, comp);
            if (index < 0) return source;

            // Remove the old text
            source = source.Remove(index, oldString.Length);

            // Add the replacemenet text
            source = source.Insert(index, newString);

            return source;
        }
    }
}
