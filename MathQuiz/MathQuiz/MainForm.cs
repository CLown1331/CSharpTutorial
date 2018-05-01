/*
 * Created by SharpDevelop.
 * User: Araf Al-Jami
 * Date: 5/1/2018
 * Time: 5:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MathQuiz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int ans1 = 0;
		int ans2 = 0;
		int ans3 = 0;
		int timeLeft = 0;
		int score = 0;
		Random random;
		
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
			Check();
			Reset();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			if( timeLeft == 0 ) {
				MessageBox.Show( "Times up" );
				Check();
				Reset();
			}
			else {
				timeLeft--;
				label4.Text = "Time Left: " + timeLeft + " second(s)";
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			random = new Random();
			Reset();
		}
		void Reset() 
		{
			textBox1.ResetText();
			textBox2.ResetText();
			textBox3.ResetText();
			
			timeLeft = 15;
			label4.Text = "Time Left: " + timeLeft + " second(s)";
			label5.Text = "Score: " + score;
			
			int a, b, op;
			
			a = random.Next() % 10;
			b = random.Next() % 10;
			op = random.Next() % 3;
			if( op == 0 ) {
				ans1 = a + b;
				label1.Text = a + " + " + b + " = ";
			}
			else if( op == 1 ) {
				ans1 = a - b;
				label1.Text = a + " - " + b + " = ";
			}
			else {
				ans1 = a * b;
				label1.Text = a + " * " + b + " = ";
			}
			
			a = random.Next() % 10;
			b = random.Next() % 10;
			op = random.Next() % 3;
			if( op == 0 ) {
				ans2 = a + b;
				label2.Text = a + " + " + b + " = ";
			}
			else if( op == 1 ) {
				ans2 = a - b;
				label2.Text = a + " - " + b + " = ";
			}
			else {
				ans2 = a * b;
				label2.Text = a + " * " + b + " = ";
			}
			
			a = random.Next() % 10;
			b = random.Next() % 10;
			op = random.Next() % 3;
			if( op == 0 ) {
				ans3 = a + b;
				label3.Text = a + " + " + b + " = ";
			}
			else if( op == 1 ) {
				ans3 = a - b;
				label3.Text = a + " - " + b + " = ";
			}
			else {
				ans3 = a * b;
				label3.Text = a + " * " + b + " = ";
			}
		}
		void Check()
		{
			if( textBox1.Text != "" ){
				score += ( Int32.Parse(textBox1.Text) == ans1 ) ? 1 : 0;
			}
			if( textBox2.Text != "" ){
				score += ( Int32.Parse(textBox2.Text) == ans2 ) ? 1 : 0;
			}
			if( textBox3.Text != "" ){
				score += ( Int32.Parse(textBox3.Text) == ans3 ) ? 1 : 0;
			}
		}
	}
}
