using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanGongPingTai
{
    public class StudentAward
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public int TotalStudent { get; set; }
        public int ActualStudent { get; set; }
        public double StandardPrice { get; set; }
        public double ActualPrice { get; set; }
        public double Amount { get; set; }
        public DateTime CreateDate { get; set; }
        public string Operator { get; set; }
        public StudentAward() { }
    }
}
