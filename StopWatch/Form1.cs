using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private int elapsedTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 346);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "나만의 스톱워치";
            this.ResumeLayout(false);
        }

        private void 리셋ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStart.Text = "스톱";
            }
            else
            { 
                timer1.Enabled = true;
                btnStart.Text = "시작";
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.elapsedTime++;
            this.lblStatus.Text = this.elapsedTime + "초 경과";
            this.tbStatus.Text = this.elapsedTime + "초 경과";
            this.toolStripProgressBar1.Value = this.elapsedTime;
            if(this.toolStripProgressBar1.Maximum == toolStripProgressBar1.Value)
            {
                timer1.Enabled = false;
            }
        }
    }
}
