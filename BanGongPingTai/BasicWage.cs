using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanGongPingTai
{
    public class BasicWage
    {
        public int BasicID { get; set; }
        public int TeacherID { get; set; }
        public string WageType { get; set; }
        public double WageStandard { get; set; }
        public int WageNum { get; set; }
        public double WageAmount { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string Operator { get; set; }
        public BasicWage() { }
    }
}
