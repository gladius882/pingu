/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2019-04-15
 * Time: 17:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Design;
using System.Net;
using System.ComponentModel;

namespace Pingu
{
	/// <summary>
	/// Description of Pinger.
	/// </summary>
	public class PingerOptions
	{
		[Category("Basic")]
		[Description("Target")]
		[DisplayName("Target")]
		public string Target {get; set;}
		
		[Category("Basic")]
		[Description("Delay in milliseconds after each request")]
		[DisplayName("Delay")]
		public int Delay {get; set;}
		
		[Category("Pingu")]
		[Description("Make Pingu sound when ping will increase above this value (milliseconds)")]
		[DisplayName("Max ping")]
		public int MaxPing {get; set;}
		
		[Category("Pingu")]
		[Description("Show reply in log control")]
		[DisplayName("Logging")]
		public bool Logging {get; set;}
		
		[Category("ping.exe")]
		[Description("Ping the specified host until stopped.")]
		[DisplayName("-t")]
		public bool Infinite {get; set;}
		
		[Category("ping.exe")]
		[Description("Resolve addresses to hostnames.")]
		[DisplayName("-a")]
		public bool Resolve {get; set;}
		
		[Category("ping.exe")]
		[Description("Number of echo requests to send.")]
		[DisplayName("-n")]
		public int RequestsCount {get; set;}
		
		[Category("ping.exe")]
		[Description("Send buffer size.")]
		[DisplayName("-l")]
		public int BufferSize {get; set;}
		
		[Category("ping.exe")]
		[Description("Set Don't Fragment flag in packet (IPv4-only).")]
		[DisplayName("-f")]
		public bool DontFragment {get; set;}
		
		[Category("ping.exe")]
		[Description("Time To Live.")]
		[DisplayName("-i")]
		public int TTL {get; set;}
		
		[Category("ping.exe")]
		[Description("Record route for count hops (IPv4-only).")]
		[DisplayName("-r")]
		public int HopsCount {get; set;}
		
		[Category("ping.exe")]
		[Description("Timestamp for count hops (IPv4-only).")]
		[DisplayName("-s")]
		public int HopsTimestamp {get; set;}
		
		[EditorAttribute(typeof(System.Windows.Forms.Design.FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("ping.exe")]
		[Description("Loose source route along host-list (IPv4-only).")]
		[DisplayName("-j")]
		public string LooseSource {get; set;}
		
		[EditorAttribute(typeof(System.Windows.Forms.Design.FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("ping.exe")]
		[Description("Strict source route along host-list (IPv4-only).")]
		[DisplayName("-k")]
		public string StrictSource {get; set;}
		
		[Category("ping.exe")]
		[Description("Timeout in milliseconds to wait for each reply.")]
		[DisplayName("-w")]
		public int Timeout {get; set;}
		
		[Category("ping.exe")]
		[Description("Use routing header to test reverse route also (IPv6-only).")]
		[DisplayName("-R")]
		public bool ReverseRoute {get; set;}
		
		[Category("ping.exe")]
		[Description("Source address to use")]
		[DisplayName("-S")]
		public string SourceAddress {get; set;}
		
		[Category("ping.exe")]
		[Description("Force using IPv4.")]
		[DisplayName("-4")]
		public bool ForceIPv4 {get; set;}
		
		[Category("ping.exe")]
		[Description("Force using IPv6.")]
		[DisplayName("-6")]
		public bool ForceIPv6 {get; set;}
		
		public PingerOptions()
		{
			Target = "google.com";
			Delay = 1000;
			MaxPing = 100;
			Logging = true;
			Infinite = false;
			Resolve = false;
			RequestsCount = 4;
			BufferSize = 32;
			DontFragment = false;
			TTL = 128;
			HopsCount = 1;
			HopsTimestamp = 1;
			LooseSource = String.Empty;
			StrictSource = String.Empty;
			Timeout = 4000;
			ReverseRoute = false;
			SourceAddress = String.Empty;
			ForceIPv4 = true;
			ForceIPv6 = false;
		}
		
		public byte[] generateBuffer()
		{
			string data = "";
			for(int i=0; i<BufferSize; i++) {
				data += "a";
			}
			
			return System.Text.Encoding.ASCII.GetBytes(data);
		}
	}
}
