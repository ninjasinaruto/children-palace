using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanGongPingTai
{
    public class CourseWage
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public string CourseType { get; set; }
        public int CourseNum { get; set; }
        public double StandardPrice { get; set; }
        public double ActualPrice { get; set; }
        public double CourseAmount { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string Operator { get; set; }
        public CourseWage() { }
    }
}
