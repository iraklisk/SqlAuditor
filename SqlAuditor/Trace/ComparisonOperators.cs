using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Trace
{
    [Serializable]
    public static class ComparisonOperators
    {
        public const int Equal = 0;
        public const int NotEqual = 1;
        public const int GreaterThan = 2;
        public const int LessThan = 3;
        public const int GreaterThanOrEqual = 4;
        public const int LessThanOrEqual = 5;
        public const int Like = 6;
        public const int NotLike = 7;
    }
}
