using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpDash
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Extends the native Replace function with a Comparator
        /// </summary>
        /// <param name="source"></param>
        /// <param name="oldString"></param>
        /// <param name="newString"></param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public static string Replace(this string source, string oldString, string newString, StringComparison comp)
        {
            int index = source.IndexOf(oldString, comp);
            if (index < 0) return source;
            
            source = source.Remove(index, oldString.Length);
            source = source.Insert(index, newString);

            return source;
        }


    }
}
