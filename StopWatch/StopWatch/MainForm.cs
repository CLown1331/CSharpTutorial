/*
 * Created by SharpDevelop.
 * User: Araf Al-Jami
 * Date: 4/18/2018
 * Time: 5:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StopWatch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int timeElapsed = 0;
		bool runnning = false;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			timeElapsed = 0;
			label1.Text = "Time: 0 minute(s) : 0 second(s) : 0 centisecond(s)";
		}
		void Button1Click(object sender, EventArgs e)
		{
			runnning = !runnning;
			if( runnning ) {
				button1.Text = "Stop";
			}
			else {
				button1.Text = "Start";
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if( runnning ) {
				timeElapsed++;
				int centiSeconds = timeElapsed % 10;
				int seconds = timeElapsed / 10;
				int minutes = seconds / 60;
				seconds %= 60;
				label1.Text = String.Format( "Time: {0} minute(s) : {1} second(s) : {2} centisecond(s)", minutes, seconds, centiSeconds );
			}
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
	}
}
