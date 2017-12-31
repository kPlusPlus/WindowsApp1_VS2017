using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            DateTime dt1 = DateTime.Now,dt2;

            long i;
            double r = 0.0;
            for (i = 1; i <= 1000000000; i++)
            {
                r = r + 1.0 / (double)i;
            }

            textBox1.Text = "r1 " + r + Environment.NewLine;

            r = 0.0;
            for (i = 1000000000; i >= 1; i--)
            {
                r = r + 1.0 / (double)i;
            }

            textBox1.Text += "r2 " + r + Environment.NewLine;

            dt2 = DateTime.Now;

            textBox1.Text += "time 1 " + dt1 + Environment.NewLine;
            textBox1.Text += "time 2 " + dt2 + Environment.NewLine;
            TimeSpan duration = dt2 - dt1;  //TimeSpan.Parse( dt1.ToString() ) ;

            
            textBox1.Text += "razlika " + duration + Environment.NewLine;

        }
    }
}
