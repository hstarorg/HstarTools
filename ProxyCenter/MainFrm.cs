using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Parser.Html;
using ProxyCenter.Model;

namespace ProxyCenter
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private static object lockObj = new object();

        private static int counter = 0;

        private static readonly StringBuilder LogBuider = new StringBuilder();

        private static readonly List<ProxyIpEntity> IpList = new List<ProxyIpEntity>();


        private Task<string> DownPageAsync(string url)
        {
            WebClient client = new WebClient { Encoding = Encoding.UTF8 };
            return client.DownloadStringTaskAsync(url);
        }
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (Cb1.Checked)
            {
                this.PrintLog("开始下载西刺数据");
                string content = await this.DownPageAsync(Cb1.Tag.ToString());
                this.ParseXiciData(content);
            }
            if (Cb2.Checked)
            {
                this.PrintLog("开始下载中国IP数据");
                string content = await this.DownPageAsync(Cb2.Tag.ToString());
                this.ParseIpChinaData(content);
            }
            this.PrintLog("数据下载完成，开始验证...");
            this.ValidateIps();

        }

        private void ValidateIps()
        {
            IpList.ForEach(this.ValidateSingleIp);
        }

        private async void ValidateSingleIp(ProxyIpEntity proxyIp)
        {
            WebClient client = new WebClient { Proxy = new WebProxy(proxyIp.Ip, proxyIp.Port) };
            try
            {
                var content = await client.DownloadStringTaskAsync("http://www.baidu.com");
                proxyIp.Status= string.IsNullOrEmpty(content) ? "不可用" : "可用";
            }
            catch
            {
                proxyIp.Status = "不可用";
            }
            lock (lockObj)
            {
                counter++;
                if (counter > 10)
                {
                     this.PrintIp(IpList);
                }
                counter = 0;
            }
        }

        private void PrintIp(List<ProxyIpEntity> ipList)
        {
            LvIp.Items.Clear();
            LvIp.Items.AddRange(ipList.Select(x => new ListViewItem(new[] { x.Ip, x.Port.ToString(), x.Address, x.Status },-1)).ToArray());
        }

        private void PrintIp(ProxyIpEntity proxyIp)
        {
            IpList.Add(proxyIp);
            ListViewItem lvi = new ListViewItem(new[] { proxyIp.Ip, proxyIp.Port.ToString(), proxyIp.Address }, -1);
            LvIp.Items.Add(lvi);
        }

        private async void ParseXiciData(string content)
        {
            this.PrintLog("西刺数据下载完成，开始解析...");
            var doc = await new HtmlParser(content).ParseAsync();
            var trList = doc.QuerySelectorAll("#ip_list tr");
            foreach (var tr in trList)
            {
                if (tr.QuerySelectorAll("th").Length > 0 || tr.ClassList.Contains("subtitle"))
                {
                    continue;
                }
                var tdList = tr.QuerySelectorAll("td");
                this.PrintIp(new ProxyIpEntity
                {
                    Ip = tdList[1].InnerHtml,
                    Port = Convert.ToInt32(tdList[2].InnerHtml),
                    Address = tdList[3].InnerHtml
                });
            }
            this.PrintLog("西刺数据解析完成。");
        }

        private async void ParseIpChinaData(string content)
        {
            this.PrintLog("IP中国数据下载完成，开始解析...");
            var doc = await new HtmlParser(content).ParseAsync();
            var trList = doc.QuerySelectorAll(".sortable tbody tr");
            foreach (var tr in trList)
            {
                if (tr.QuerySelectorAll("th").Length > 0 || tr.ClassList.Contains("subtitle"))
                {
                    continue;
                }
                var tdList = tr.QuerySelectorAll("td");
                this.PrintIp(new ProxyIpEntity
                {
                    Ip = tdList[0].InnerHtml,
                    Port = Convert.ToInt32(tdList[1].InnerHtml),
                    Address = tdList[2].InnerHtml
                });
            }
            this.PrintLog("IP中国数据解析完成。");
        }

        private void PrintLog(string msg)
        {
            LogBuider.AppendFormat("{0:yyyy-MM-dd HH:mm:ss sss} {1}{2}", DateTime.Now, msg, Environment.NewLine);
            RtbLog.Text = LogBuider.ToString();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            foreach(var ip in IpList.Where(x=>x.Status.Equals("可用")))
            {
                builder.AppendFormat("{0}:{1} {2}{3}", ip.Ip, ip.Port, ip.Address,Environment.NewLine);
            }
            File.WriteAllText("D;/proxyIpList.txt",builder.ToString());
        }
    }
}
