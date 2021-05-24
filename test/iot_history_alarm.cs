using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientApp
{
    public class iot_history_alarm
    {
        public string id { get; set; }
        public string alarmRuleId { get; set; }
        public DateTime beginTime { get; set; }
        public DateTime endTime { get; set; }
        public decimal ruleValue { get; set; }
        public decimal firstValue { get; set; }
        public  int alarmType { get; set; }
        public string meterCode { get; set; }
        public string projectId { get; set; }
        public DateTime acquisitionTime { get; set; }
        public decimal alarmValue { get; set; }
        public int createUser { get; set; }
        public DateTime createTime { get; set; }
        public int updateUser { get; set; }
        public DateTime updateTime { get; set; }
        public DateTime inputTime { get; set; }
        public int reasonTag { get; set; }
        public int makeUp { get; set; }
    }
}
