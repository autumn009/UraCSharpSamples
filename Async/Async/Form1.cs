using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Async
{
    public delegate int InvokeDelegate(int count);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread sub;
        private void Form1_Load(object sender, EventArgs e)
        {
            sub = new Thread(timerProc);
            sub.Start();
        }
        private void timerProc()
        {
            int count = 0;
            for (; ; )
            {
                Thread.Sleep(500);
                var r = BeginInvoke(new InvokeDelegate(theproc), count);

                count = (int)EndInvoke(r);
                if (count >= 4) return;
            }
        }
        private int theproc(int count)
        {
            this.label1.Text = count.ToString();
            return count+1;
        }
    }
}
