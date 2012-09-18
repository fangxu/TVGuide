using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TVGuide.Model
{
    class TV
    {
        private String name;
        private String url;


        public String[] getWeekUrl()
        {
            String[] list = new String[7];
            String TVChannel = url.Substring(0, url.LastIndexOf('/') + 1);
            for (int i = 1; i <= 7; i++)
            {
                list[i - 1] = TVChannel + "W" + i + ".htm";
            }
            return list;
        }
        public System.String Url
        {
            get { return url; }
            set { url = value; }
        }
        public System.String Name
        {
            get { return name; }
            set
            {
                Regex regex = new Regex(@"\r|\n| ");
                value = regex.Replace(value, "");
                name = value;
            }
        }

    }
}
