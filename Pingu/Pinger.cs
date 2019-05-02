/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2019-05-01
 * Time: 15:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.NetworkInformation;

namespace Pingu
{
	/// <summary>
	/// Description of Pinger.
	/// </summary>
	public class Pinger: Ping
	{
		public PingerOptions Options = new PingerOptions();
		
		public Pinger(PingerOptions options = null) : base()
		{
			if(options == null) {
				options = new PingerOptions();
			}
			this.Options = options;	
		}
		
		public void SendAsync()
		{
			PingOptions options = new PingOptions(Options.TTL, Options.DontFragment);
			this.SendAsync(Options.Target, Options.Timeout, Options.generateBuffer(), options, null);
//			System.Threading.Thread.Sleep(Options.Delay);
		}
	}
}
