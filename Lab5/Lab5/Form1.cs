using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *  * I, Michael Mena, 000817498 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
 * 
 * Date: 12/10/2020
 * 
 * This is a program that simulates a faucet filling a bucket with variable water speed and water color
 */ 
namespace Lab5
{
    
    public partial class Form1 : Form
    {
        int x1=4; //Sets the initial width of the line (used when drawing the water)

        int x2;
        
        int y;
        
        bool timeStart = false;

        public Color waterColor = Color.Aqua; // Sets the initial color of the water
        
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * This method draws the bucket which is then used to hold the water
         */
        private void bucket_Paint(object sender, PaintEventArgs e)
        {
            y = bucket.Height;
            Graphics g1 = bucket.CreateGraphics();
            Pen p = new Pen(Color.Gray, 5);
            g1.DrawLine(p, 0, 0, 0, bucket.Height);//left side of bucket
            g1.DrawLine(p, bucket.Width, 0, bucket.Width, y); //Right side of the bucket
            g1.DrawLine(p, 0, y, bucket.Width, y); // Bottom of the bucket
            y -= 5;// Sets the universal y axis to ABOVE the bottom of the bucket


        }

        /*
         * This method controls the speed of the water filling the bucket
         */
        private void waterSpeed_Scroll(object sender, EventArgs e)
        {
            if (timeStart == false)
            {
                timeStart = true;
                timer1.Enabled = true;
            }
            
                double speed = waterSpeed.Value;
                timer1.Interval = (int)speed;
            
        }


        /*
         * This method handles length of ticks and thus the speed of water filling the bucket
         */
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = bucket.CreateGraphics();
            Pen p = new Pen(waterColor, 2);

            x2 = 255;
            if (timer1.Interval == 1000)
            {
                p.Color = Color.Black;
                g.DrawLine(p, 25, 0, 25, y+1);
                p.Color = waterColor;
                
                
            }
            else if (y < 25)
            {
                timer1.Interval = 1000;
            }
            else
            {
                p.Color = waterColor;
                g.DrawLine(p, 25, 0, 25, y);
                g.DrawLine(p, x1, y, x2, y);
                y -= 2;
                
            }
            g.Dispose();

            
            

        }
        

        

        
        /*
         * This method handles the changing of colors for the water
         */
        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                waterColor = colorDialog1.Color;
                
            }
            

        }

        /*
         * This method closes the form
         */
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        
    }
}
