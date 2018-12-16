using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigKeyComparer
{
    public class ConfigCompareResult
    {
        public string Name { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public Helpers.ResultType Status { get; set; }
    }
}
