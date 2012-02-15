using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaoNianGong
{
    public class DayOfWeek
    {
        private static readonly string[] DAY_OF_WEEK_MATCH
            = new[] { "无效", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日" };

        public static readonly DayOfWeek[] DAY_OF_WEEK_LIST
            = new DayOfWeek[] { new DayOfWeek(1), new DayOfWeek(2), new DayOfWeek(3), 
                new DayOfWeek(4), new DayOfWeek(5), new DayOfWeek(6), new DayOfWeek(7)};

        private int _value;

        public static string GetName(int value)
        {
            if (value < 1 || value > 7)
            {
                throw new ArgumentOutOfRangeException("星期值无效，必须是 1 ~ 7 的数字");
            }
            return DAY_OF_WEEK_MATCH[value];
        }

        public DayOfWeek(int value)
        {
            this.Value = value;
        }

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                this.Name = GetName(value);
                this._value = value;
            }
        }

        public string Name
        {
            get;
            private set;
        }
    }
}
