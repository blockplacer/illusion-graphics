/*
 * Created by SharpDevelop.
 * User: casper
 * Date: 17.09.2020
 * Time: 03:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IllusionGraphics
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int zcoord = 0;
		int zcoord2 = 0;
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
		
		void PictureBox1Paint(object sender, PaintEventArgs e)
		{
			for (int i = 0; i < 90-zcoord; i++) {
				Pen testpen = new Pen(Color.Blue);
				e.Graphics.DrawRectangle(testpen,80-i-20+zcoord2,80,2,10+i);
				e.Graphics.DrawRectangle(testpen,120+i-20-zcoord2,80,2,10+i);
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			pictureBox1.Invalidate();
		}
		int test7 = 0;
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.W){
				test7++;
				zcoord--;
				if(test7==10){
					
					zcoord2--;
					test7=0;
				}
				
				//Console.WriteLine(zcoord.ToString());
			}
if(e.KeyCode == Keys.S){
			test7++;
				zcoord++;
				if(test7==10){
					
					zcoord2++;
					test7=0;
				}
				
			}
		}
	}
}
