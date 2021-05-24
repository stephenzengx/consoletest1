using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    public class iot_history_data
    {
        public string id { get; set; }
        public string projectId { get; set; }
        public int meterKind { get; set; }
        public string meterCode { get; set; }
        public string meterVarId { get; set; }
        public string inputTime { get; set; }
        public string acquisitionTime { get; set; }
        public decimal dataValue { get; set; }
        public decimal addValue { get; set; }       
        public int type { get; set; }
        public string name { get; set; }
        public int createUser { get; set; }
        public string createTime { get; set; }
        public int makeUp { get; set; }
    }
}
