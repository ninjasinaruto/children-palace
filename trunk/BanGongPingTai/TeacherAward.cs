using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanGongPingTai
{
    public class TeacherAward
    {
        public int AwardID { get; set; }
        public int TeacherID { get; set; }
        public string AwardName { get; set; }
        public double StandardPrice { get; set; }
        public double ActualPrice { get; set; }
        public int AwardNum { get; set; }
        public double AwardAmount { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string Operator { get; set; }
        public TeacherAward() { }
    }
}
