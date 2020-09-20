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
		int xcoord = 0;
		static Bitmap corridor = new Bitmap(400,400);
		Graphics corridor_g = Graphics.FromImage(corridor);
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
		{int corridor_color = 0;
			for (int i = 0; i < 90-zcoord; i++) {
				
				corridor_color++;
				if(corridor_color > 255){
					corridor_color=255;
				}
				//corridor_g.Clear(Color.White);
				Pen testpen = new Pen(Color.FromArgb(200,0,0,corridor_color));
				corridor_g.DrawRectangle(testpen,80-i-20+zcoord2,80,2,10+i);
				corridor_g.DrawRectangle(testpen,120+i-20-zcoord2,80,2,10+i);
				
			}			
			
			
			e.Graphics.DrawImage(corridor,xcoord,0,pictureBox1.Width,pictureBox1.Height);
		}
		//xcoord
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
			
			if(e.KeyCode == Keys.D){
				xcoord++;
			}
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
corridor_g.Clear(Color.Transparent);			
		}
	}
}
