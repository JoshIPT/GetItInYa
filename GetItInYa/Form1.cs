using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Leoxia.Network;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net.Http;

namespace GetItInYa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logBox.Clear();
            listView1.Items.Clear();
            listView1.Refresh();
            engineWorker.RunWorkerAsync();
        }

        public void addLog(string str, bool newLine = true)
        {
            if (newLine) { engineWorker.ReportProgress(1, str + Environment.NewLine); }
            else { engineWorker.ReportProgress(1, str); }
        }
        private void engineWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var url = new Uri(textBox1.Text);
            addLog("Resolving " + url.Host + "... ", false);
            var dns = Dns.GetHostEntry(url.Host);
            List<string> ipList = new List<string>();
            foreach (IPAddress ip in dns.AddressList) { ipList.Add(ip.ToString()); }

            if (ipList.Count < 1)
            {
                addLog("FAILED TO RESOLVE");
            }
            else
            {
                var dnsresult = String.Join(", ", ipList.ToArray());
                addLog(dnsresult);
                addLog("Beginning ping... ", false);
                engineWorker.ReportProgress(2);
                Thread.Sleep(1000);
                while (pingWorker.IsBusy) { Thread.Sleep(1); }
                addLog("OK", true);
                addLog("Beginning trace...", false);
                engineWorker.ReportProgress(3);
                Thread.Sleep(1000);
                while (traceWorker.IsBusy) { Thread.Sleep(1); }
                addLog("OK");
                addLog("Starting download....", true);
                engineWorker.ReportProgress(4);
                Thread.Sleep(1000);
                while (httpWorker.IsBusy) { Thread.Sleep(1); }
            }

        }

        private void engineWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                var txt = (string)e.UserState;
                logBox.Text += txt;
            }
            if (e.ProgressPercentage == 2)
            {
                pingWorker.RunWorkerAsync();
            }
            if (e.ProgressPercentage == 3)
            {
                traceWorker.RunWorkerAsync();
            }
            if (e.ProgressPercentage == 4)
            {
                httpWorker.RunWorkerAsync();
            }
        }

        private void pingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping pinger = new Ping();
            PingOptions po = new PingOptions();
            po.DontFragment = true;
            var url = new Uri(textBox1.Text);

            byte[] buffer = new byte[1400];
            for (int i = 0; i < buffer.Length; i++) { buffer[i] = Byte.MinValue;  }

            // Ping 1
            PingReply reply = pinger.Send(url.Host, 3000, buffer, po);
            if (reply.Status == IPStatus.Success) { pingWorker.ReportProgress(1, reply.RoundtripTime.ToString() + "ms"); }
            else if (reply.Status == IPStatus.PacketTooBig) { pingWorker.ReportProgress(1, "Fragmented"); }
            else { pingWorker.ReportProgress(1, "No Reply"); }
            Thread.Sleep(1000);

            // Ping 2
            reply = pinger.Send(url.Host, 3000, buffer, po);
            if (reply.Status == IPStatus.Success) { pingWorker.ReportProgress(2, reply.RoundtripTime.ToString() + "ms"); }
            else if (reply.Status == IPStatus.PacketTooBig) { pingWorker.ReportProgress(2, "Fragmented"); }
            else { pingWorker.ReportProgress(2, "No Reply"); }
            Thread.Sleep(1000);

            // Ping 3
            reply = pinger.Send(url.Host, 3000, buffer, po);
            if (reply.Status == IPStatus.Success) { pingWorker.ReportProgress(3, reply.RoundtripTime.ToString() + "ms"); }
            else if (reply.Status == IPStatus.PacketTooBig) { pingWorker.ReportProgress(3, "Fragmented"); }
            else { pingWorker.ReportProgress(3, "No Reply"); }

            e.Result = true;
        }

        private void pingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                ping_last1.Text = (string)e.UserState;
            }
            if (e.ProgressPercentage == 2)
            {
                ping_last2.Text = (string)e.UserState;
            }
            if (e.ProgressPercentage == 3)
            {
                ping_last3.Text = (string)e.UserState;
            }
        }

        private void traceWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var url = new Uri(textBox1.Text);
            var tre = new TraceRoute();
            var tr = tre.GetTraceRoute(url.Host);
            traceWorker.ReportProgress(1, tr);

            var num = 0;
            foreach (IPAddress ip in tr)
            {
                Ping ping = new Ping();
                var p = ping.Send(ip, 3000);
                if (p.Status == IPStatus.Success) { traceWorker.ReportProgress(20 + num, p.RoundtripTime.ToString()); }
                else { traceWorker.ReportProgress(20 + num, "-"); }
                num++;
            }

            e.Result = true;
        }

        private void traceWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                var num = 0;
                listView1.BeginUpdate();
                foreach (IPAddress ip in (IEnumerable<IPAddress>)e.UserState)
                {
                    num++;
                    var itm = new ListViewItem(num.ToString());
                    var ipval = ip.ToString();
                    itm.SubItems.Add(ipval);
                    itm.SubItems.Add("");
                    listView1.Items.Add(itm);
                }
                listView1.EndUpdate();
            }
            else if (e.ProgressPercentage >= 20)
            {
                listView1.BeginUpdate();
                var id = e.ProgressPercentage - 20;
                var rt = (string)e.UserState;
                var ip = listView1.Items[id].SubItems[1].Text;
                var ipval = ip;
                try
                {
                    var dns = Dns.GetHostEntry(IPAddress.Parse(ip));
                    if (dns.HostName != ip) { ipval = dns.HostName + " (" + ip + ")"; }
                }
                catch (Exception ex)
                {
                }
                listView1.Items[id].SubItems[1].Text = ipval;
                listView1.Items[id].SubItems[2].Text = rt;
                listView1.EndUpdate();
                listView1.Refresh();
            }
        }

        private void pingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void httpWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient http = new WebClient();
            var data = http.DownloadString(textBox1.Text);
            httpWorker.ReportProgress(1, http.Headers);
            httpWorker.ReportProgress(2, http.ResponseHeaders);

            e.Result = true;
        }

        private void httpWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var headers = (WebHeaderCollection)e.UserState;
            foreach (string k in headers)
            {
                addLog(k + ": " + headers[k], true);
            }
        }
    }
}
