using System;
using System.Threading;
using System.Windows.Forms;

namespace TODO1
{
    public partial class Form1 : Form
    {
        Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private bool a;
        public void Key()
        {
            a = true;
            double bekle = 1000 *Convert.ToDouble(numericUpDown2.Text);
            while (a)
            {
                Thread.Sleep((int)bekle);
                SendKeys.SendWait(textBox1.Text+"{Enter}");
            }
                          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(Key));
            thread.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = false;
            //thread.Abort();
        }
    }
}
