using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVGuide.Model
{
    class TVItem
    {
        private DateTime time;
        private String title;
        private String detail;

        public bool IsPassed
        {
            get
            {
                if (time < DateTime.Now)
                {
                    return true;
                }
                return false;
            }

        }

        public System.String Detail
        {
            get
            {
                if (detail == null)
                {
                    return "暂无";
                }
                return detail;
            }
            set { detail = value; }
        }
        public System.String Title
        {
            get { return title; }
            set { title = value; }
        }
        public System.DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
