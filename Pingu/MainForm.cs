/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2019-04-13
 * Time: 21:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Pingu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private System.Media.SoundPlayer NootNoot = new System.Media.SoundPlayer();
		private Pinger Pinger;
		private Thread Thread;
		private int NumOfRequests = 0;
		private long PingTimeoutSum = 0;
		private bool StopPinging = false;
		
		public MainForm()
		{
			InitializeComponent();
			
			Pinger = new Pinger();
			Pinger.PingCompleted += new PingCompletedEventHandler(ping_Complete);
			propertyGrid1.SelectedObject = Pinger.Options;
			
			NootNoot.SoundLocation = "data/NootNoot.wav";
			NootNoot.Load();
		}
		
		private void ToolStripButtonStartClick(object sender, EventArgs e)
		{
			StopPinging = false;
			this.Thread = new Thread(Pinger.SendAsync);
			this.Thread.Start();
//			Pinger.SendAsync();
		}
		
		private void ping_Complete(object sender, PingCompletedEventArgs e)
		{	
			if(e.Cancelled || StopPinging) {
				AddLog(Environment.NewLine+"----------------- *** CANCELED *** -----------------"+Environment.NewLine);
				return;
			}
			
			if(e.Error != null) {
				AddLog(e.Error.Message);
			} else {
				PingReply reply = e.Reply;
				long time = reply.RoundtripTime;
				NumOfRequests++;
				PingTimeoutSum += time;
				string message = String.Format("Reply from {0}: bytes={1} time={2} TTL={3}",
				                              Pinger.Options.Target,
				                              reply.Buffer.Length.ToString(),
				                              time.ToString(),
				                              reply.Options.Ttl.ToString());
				
				AddLog(message);
				if(time >= Pinger.Options.MaxPing) {
					NootNoot.Play();
				}
				
				if(int.Parse(toolStripMax.Text) < time) {
					toolStripMax.Text = time.ToString();
				}
				
				if(int.Parse(toolStripMin.Text) > time || toolStripMin.Text == "0") {
					toolStripMin.Text = time.ToString();
				}
				
				toolStripCurrent.Text = time.ToString();
				toolStripAvg.Text = (PingTimeoutSum/NumOfRequests).ToString();
			}
			
			System.Threading.Thread.Sleep(Pinger.Options.Delay);
			this.Thread.Join(Pinger.Options.Delay);
			this.Thread = new Thread(Pinger.SendAsync);
			this.Thread.Start();
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			StopPinging = true;
		}
		
		void ToolStripButtonClearClick(object sender, EventArgs e)
		{
//			htmlPanel1.Text = "";
			textBox1.Text = String.Empty;
			toolStripMax.Text = "0";
			toolStripMin.Text = "0";
			toolStripAvg.Text = "0";
		}
		
		delegate void AddLogCallback(string message);
		
		private void AddLog(string message)
		{
			if(this.textBox1.InvokeRequired)
			{
				AddLogCallback callback = new MainForm.AddLogCallback(AddLog);
				this.Invoke(callback, new object[] {message});
			}
			else
			{
				this.textBox1.Text += message + Environment.NewLine;
			}
		}
	}
}
