using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Regular
{
    public static class RegularExtends
    {
        public static string Match(this string source,string expression)
        {
            var regex = new Regex(expression);
            var match = regex.Match(source);
            return match.Value;
        }

        public static IList<string> Matches(this string source, string expression)
        {
            var regex = new Regex(expression);
            var matches = regex.Matches(source);
            var list = new List<string>();
            foreach (Match item in matches)
                list.Add(item.Value);
            return list;
        }
    }
}
