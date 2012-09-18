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
using System.Threading;

namespace TVGuide
{
    public partial class MainForm : Form
    {
        private const String allUrl = @"http://www.tvsou.com/all.asp";
        private int currentKind = 0;
        private String currentChannel = null;
        private int currentTV = 0;
        private int currentWeek = 0;
        private List<TVItem>[] listItems = null;
        //private List<List<List<TV>>> data = null;
        private List<Dictionary<String, List<TV>>> data = null;
        public MainForm()
        {
            InitializeComponent();
        }

        void initTVs()
        {
            String temp = getHtml(allUrl);
            data = new List<Dictionary<String, List<TV>>>();
            String kindP = @"listmenu""[\s\S]*?border2";
            MatchCollection matches = Regex.Matches(temp, kindP);
            Dictionary<String, List<TV>> l = null;
            List<TV> ll = null;
            foreach (Match m in matches)
            {
                l = new Dictionary<String, List<TV>>();
                String channelP = @"graytxt""><img[\s\S]*?</table>";
                MatchCollection ms = Regex.Matches(m.Value, channelP);
                foreach (Match mm in ms)
                {
                    ll = new List<TV>();
                    TV tv = null;
                    String TVP = @"td[\s\S]*?href=""([\s\S]*?)"">([\s\S]*?)<";
                    MatchCollection mss = Regex.Matches(mm.Value, TVP);
                    foreach (Match mmm in mss)
                    {
                        tv = new TV();
                        tv.Url = striphtml(mmm.Groups[1].Value);
                        tv.Name = mmm.Groups[2].Value;
                        ll.Add(tv);
                    }
                    Match m1 = Regex.Match(mm.Value, @"nbsp;([\s\S]*?)<");
                    l.Add(m1.Groups[1].Value, ll);
                }
                data.Add(l);
            }
            this.BeginInvoke(new MethodInvoker(() =>
            {
                ToolStripKind_Click("央视", null);
                toolStripButtonUpdate.Enabled = true;
            }));
        }

        private String getHtml(String url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 20 * 1000;
            request.Method = "GET";
            request.KeepAlive = false;
            request.UserAgent = "MSIE 7.0; Windows NT 5.1";
            request.UseDefaultCredentials = true;
            String temp = null;
            try
            {
                using (Stream rs = request.GetResponse().GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(rs, Encoding.GetEncoding("GB2312")))
                    {
                        temp = sr.ReadToEnd();
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
            finally
            {
                request.Abort();
            }
            return temp;
        }

        private void ToolStripKind_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("请先点击“更新”获取频道列表", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            currentKind = kindToInt(sender.ToString());
            updateKind();
        }

        private int kindToInt(string p)
        {
            switch (p)
            {
                case "央视":
                    return 0;
                case "卫视":
                    return 1;
                case "地方台":
                    return 2;
            }
            return -1;
        }

        private void updateKind()
        {
            Dictionary<String, List<TV>> list = data[currentKind];
            listBox1.Items.Clear();
            foreach (KeyValuePair<String, List<TV>> item in list)
            {
                listBox1.Items.Add(item.Key);
            }
            for (int i = 2; i < 5; i++)
            {
                if ((i - 2) == currentKind)
                {
                    toolStrip2.Items[i].BackColor = Color.BlueViolet;
                }
                else
                {
                    toolStrip2.Items[i].BackColor = Color.LightBlue;
                }
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedItem.ToString());
            currentChannel = listBox1.SelectedItem.ToString();
            List<TV> list = data[currentKind][currentChannel];
            listBox2.Items.Clear();
            foreach (TV tv in list)
            {
                listBox2.Items.Add(tv.Name);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TV> list = data[currentKind][currentChannel];
            currentTV = listBox2.SelectedIndex;
            currentWeek = (int)DateTime.Now.DayOfWeek - 1;
            Thread t = new Thread(() =>
            {
                listItems = getTVItem(list[currentTV]);
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    updateListView();
                }));
            });
            t.IsBackground = true;
            t.Start();
        }

        private void updateListView()
        {
            listView1.Items.Clear();
            List<TVItem> list = listItems[currentWeek];
            ListViewItem lv = null;
            listView1.BeginUpdate();
            int i = 0;
            bool lastIsPassed = false;
            foreach (TVItem item in list)
            {
                lv = new ListViewItem(new string[] { item.Time.ToShortTimeString(), 
                    item.Title,item.Detail });
                if (item.IsPassed)
                {
                    lv.BackColor = Color.Gray;
                }
                if (lastIsPassed && !item.IsPassed)
                {
                    listView1.Items[i - 1].BackColor = Color.LightSeaGreen;
                }
                listView1.Items.Add(lv);
                lastIsPassed = item.IsPassed;
                i++;
            }
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.EndUpdate();
            for (int j = 0; j < 7; j++)
            {
                if (j == currentWeek)
                {
                    toolStrip1.Items[j].BackColor = Color.BlueViolet;
                }
                else
                {
                    toolStrip1.Items[j].BackColor = Color.Lavender;
                }
            }
        }

        List<TVItem>[] getTVItem(TV tv)
        {
            List<TVItem>[] week = new List<TVItem>[7];
            String[] weekUrl = tv.getWeekUrl();
            week[currentWeek] = parserTVItem(weekUrl[currentWeek]);
            return week;
        }

        List<TVItem> parserTVItem(String url)
        {
            List<TVItem> list = new List<TVItem>();
            TVItem item = null;
            String html = getHtml(url);
            String beginP = @"id='PMT[1|2]'[\s\S]*?";
            String timeP = @"(\d{2}:\d{2})</font>";
            String titleP = @"[\s\S]*?<div id='e2' >([\s\S]*?)</";
            String detailP = @"([\s\S]*?</div>)";
            String pattern = beginP + timeP + titleP + detailP;
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(html);
            foreach (Match m in matches)
            {
                item = new TVItem();
                item.Time = DateTime.Parse(m.Groups[1].Value);
                String t = m.Groups[2].Value;
                Match m1 = Regex.Match(t, @"([\s\S]+?)<a");
                if (m1.Success)
                {
                    t = m1.Groups[1].Value;
                }
                item.Title = striphtml(t);
                String d = m.Groups[3].Value;
                Match mm = Regex.Match(d, @"<div class='border1px'>([\s\S]*?)</div>");
                if (mm.Success)
                {
                    item.Detail = striphtml(mm.Groups[1].Value);
                }
                list.Add(item);
            }
            return list;
        }

        private string striphtml(string strhtml)
        {
            string stroutput = strhtml;
            Regex regex = new Regex(@"<[^>]+>|</[^>]+>|amp;|\r|\n| |　");
            stroutput = regex.Replace(stroutput, "");
            return stroutput;
        }

        private void ToolStripWeek_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("请先点击“更新”获取频道列表", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int i = weekToInt(sender.ToString());
            if (i == currentWeek)
            {
                return;
            }
            currentWeek = i;
            if (listItems[i] != null)
            {
                updateListView();
            }
            else
            {
                String url = data[currentKind][currentChannel][currentTV].getWeekUrl()[currentWeek];
                Thread t = new Thread(() =>
                {
                    listItems[currentWeek] = parserTVItem(url);
                    this.BeginInvoke(new MethodInvoker(() =>
                    {
                        updateListView();
                    }));
                });
                t.IsBackground = true;
                t.Start();
            }
            Console.WriteLine(i);
        }

        private int weekToInt(string s)
        {
            switch (s)
            {
                case "星期一":
                    return 0;
                case "星期二":
                    return 1;
                case "星期三":
                    return 2;
                case "星期四":
                    return 3;
                case "星期五":
                    return 4;
                case "星期六":
                    return 5;
                case "星期日":
                    return 6;
            }
            return 0;
        }

        private void ToolStripUpdate_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(initTVs));
            t.IsBackground = true;
            t.Start();
            toolStripButtonUpdate.Enabled = false;
            //initTVs();
            //MessageBox.Show("更新完成。");
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
