using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace TimeClock
{

    public partial class Form1 : Form
    {
        private bool alreadyClockedIn = false;
        private const string Path = @"c:\\users\\uzezi\\Desktop\\log.txt";
        private static Timer timer;
        private static Stopwatch stopwatch = new Stopwatch();
        private Label mStaticLabel;
        private System.Windows.Forms.Timer t = null;

        public Form1()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_tick);
            t.Enabled = true;
            //RefreshDateTime();
        }

        private void t_tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("F");
        }

        private void RefreshDateTime()
        {
            DateLabel.Text = DateTime.Now.ToString("G");
        }

        private void ClockIn_Click(object sender, EventArgs e)
        {
            if (alreadyClockedIn == true)
            {
                MessageBox.Show(@"You are already Clocked In!");
            }
            else
            {
                using (var writer = new StreamWriter(Path))
                {
                    writer.Write(DateLabel.Text + "     ");
                }
                MessageBox.Show(@"You have successfully clocked in!");
                alreadyClockedIn = true;
            }
            
        }

        private void ClockOutButton_Click(object sender, EventArgs e)
        {
            if (alreadyClockedIn != true)
            {
                MessageBox.Show(@"You must be clocked in!");
            }
            else
            {
                using (var writer = new StreamWriter(Path, true))
                {
                    writer.Write(DateLabel.Text);
                }
                MessageBox.Show(@"You have successfully clocked out!");
                alreadyClockedIn = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer(1000);


            timer.Elapsed += new ElapsedEventHandler(RunEvent);
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void RunEvent(object sender, EventArgs e)
        {
            var ui = new Thread(new ThreadStart(updateUI));
        }

        private void updateUI()
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
