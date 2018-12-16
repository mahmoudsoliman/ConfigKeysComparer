using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigKeyComparer
{
    public static class Helpers
    {
        public enum ResultType
        {
            DIFFERENT_VALUE = 1,
            NEW_ONLY,
            OLD_ONLY,
            DUPLICATE_OLD,
            DUPLICATE_NEW
        }
    }
}
