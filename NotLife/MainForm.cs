/*
By InnieSharp(ix4/i#)
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NotLife
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int item;
		//0 - EMPTY
		//1 - Blue
		//2 - Red
		
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
			if(listBox1.SelectedIndex != -1)
			{
				if(listBox1.SelectedItem == "Empty")
					item = 0;
				else if(listBox1.SelectedItem == "Blue")
					item = 1;
				else if(listBox1.SelectedItem == "Red")
					item = 2;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			item = 0;
		}
		void Panel86Click(object sender, EventArgs e)
		{
			Panel p = sender as Panel;
			if(item == 1)
			{
				p.BackColor = Color.Blue;
				p.Tag = "blue";
			}
			else if(item == 2)
			{
				p.BackColor = Color.Red;
				p.Tag = "red";
			}
			else
			{
				p.BackColor = Color.White;
				p.Tag = "empty";
			}
		}
		void Panel139Paint(object sender, PaintEventArgs e)
		{
			//oops
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			Random r1 = new Random();
			int ch = r1.Next(0, 4);
			if(ch == 0 || ch == 1)
			{
				BlueInit();
			}
			else
			{
				RedInit();
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
		}
		void Button3Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
		}
		
		void BlueInit()
		{
			Random r = new Random();
			int startIndex = 0;
			while(true)
			{
				startIndex = r.Next(0, panel85.Controls.Count);
				Control x = panel85.Controls[startIndex];
				if(x.Tag != "blue")
				{
					x.BackColor = Color.Blue;
					x.Tag = "blue";
					break;
				}
			}
		}
		void RedInit()
		{
			Random r2 = new Random();
			int startIndex = 0;
			while(true)
			{
				startIndex = r2.Next(0, panel85.Controls.Count);
				Control x = panel85.Controls[startIndex];
				if(x.Tag != "red")
				{
					x.BackColor = Color.Red;
					x.Tag = "red";
					break;
				}
			}
		}
	}
}