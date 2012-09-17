using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using TVGuide.Model;
using System.Text.RegularExpressions;

namespace TVGuide
{
    public partial class MainForm : Form
    {
        private const String allUrl = @"http://www.tvsou.com/all.asp";
        private int currentKind = 0;
        private int currentChannel = 0;
        private int currentTV = 0;
        //private List<List<List<TV>>> data = null;
        private List<Dictionary<String,List<TV>>> data=null;
        public MainForm()
        {
            data = new List<Dictionary<String, List<TV>>>();
            InitializeComponent();
            initTVs();
        }

        void initTVs()
        {
            String temp = getHtml(allUrl);
            String kindP = @"listmenu""[\s\S]*?border2";
            MatchCollection matches = Regex.Matches(temp, kindP);
            Dictionary<String, List<TV>> l = null;
            List<TV> ll = null;
            foreach (Match m in matches)
            {
                l = new Dictionary<String, List<TV>>();
                String channelP = @"graytxt[\s\S]*?class=""dot""";
                MatchCollection ms = Regex.Matches(m.Value, channelP);
                foreach (Match mm in ms)
                {
                    ll = new List<TV>();
                    TV TVItem = null;
                    String TVP = @"td[\s\S]*?href=""([\s\S]*?)"">([\s\S]*?)<";
                    MatchCollection mss = Regex.Matches(mm.Value, TVP);
                    foreach (Match mmm in mss)
                    {
                        TVItem = new TV();
                        TVItem.Url = mmm.Groups[1].Value;
                        TVItem.Name = mmm.Groups[2].Value;
                        ll.Add(TVItem);
                    }
                    Match m1 = Regex.Match(mm.Value, @"nbsp;([\s\S]*?)<");
                    l.Add(m1.Groups[1].Value,ll);
                }
                //Match m2 = Regex.Match(m.Value, @"strong>([\s\S]*?)<span");
                data.Add(l);
            }
        }

        private String getHtml(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 10 * 1000;
            request.Method = "GET";
            request.UserAgent = "Mozilla/4.0";

            String temp = null;
            using (Stream rs = request.GetResponse().GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(rs, Encoding.GetEncoding("GB2312")))
                {
                    temp = sr.ReadToEnd();
                }
            }
            return temp;
        }

        private void ToolStripMenuItemCCTV_Click(object sender, EventArgs e)
        {
            currentKind = 0;
            updateKind();
        }

        private void updateKind()
        {
            Dictionary<String, List<TV>> list = data[currentKind];
            listBox1.Items.Clear();
            foreach (KeyValuePair<String,List<TV>> item in list)
            {
                listBox1.Items.Add(item.Key);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedItem.ToString());
            List<TV> list = data[currentKind][listBox1.SelectedItem.ToString()];
            listBox2.Items.Clear();
            foreach (TV tv in list)
            {
                listBox2.Items.Add(tv.Name);
            }
        }
    }
}
