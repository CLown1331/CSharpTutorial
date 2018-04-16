/*
 * Created by SharpDevelop.
 * User: Araf Al-Jami
 * Date: 4/16/2018
 * Time: 3:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TimerTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int timeLeft;
		
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
		void Button1Click(object sender, EventArgs e)
		{
			//MessageBox.Show( numericUpDown1.Value + " second(s)", "koto", MessageBoxButtons.OK, MessageBoxIcon.Information );
			timeLeft = (int)numericUpDown1.Value;
			label2.Text = "Time Left: " + timeLeft + " second(s)";
		}
		void Button2Click(object sender, EventArgs e)
		{
			timer1.Start();
		}
		void Button4Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if( timeLeft > 0 ) {
				timeLeft--;
				label2.Text = "Time Left: " + timeLeft + " second(s)";
			}
			else {
				timer1.Stop();
				label2.Text = "Times Up!";
			}
		}

	}
}
