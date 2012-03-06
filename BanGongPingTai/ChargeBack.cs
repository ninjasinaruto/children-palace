using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanGongPingTai
{
    public class ChargeBack
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public string ChargeBackName { get; set; }
        public string ChargeBackType { get; set; }
        public double StandardPrice { get; set; }
        public int ChargeBackNum { get; set; }
        public double ChargeBackAmount { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string Operator { get; set; }
        public ChargeBack() { }
    }
}
