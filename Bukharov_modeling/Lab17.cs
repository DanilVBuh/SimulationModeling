using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bukharov_modeling
{
    public partial class Lab17 : Form
    {
        Random random = new Random();

        double t01 = 0;
        double t1 = 0;
        double t02 = 0;
        double t2 = 0;
        double t0 = 0;
        double t = 0;
        double T = 50;
        double lambda1 = 0.5;
        double lambda2 = 1.5;
        double lambda;
        public Lab17()
        {
            lambda = lambda1 + lambda2;
            InitializeComponent();
            timer1.Interval = 100;
        }
        public void Reload()
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.t1 = 0;
            this.t01 = 0;
            this.t2 = 0;
            this.t02 = 0;
            this.t = 0;
            this.t0 = 0;
            timer1.Start();
            this.Calculate();
        }
        public void Calculate()
        {
            while (t1 <= T)
            {
                double a = random.NextDouble();

                a = random.NextDouble();
                t1 = t01 - Math.Log(a) / lambda1;
                if (t1 <= T)
                {
                    this.chart1.Series[0].Points.AddXY(t1, 3);
                    this.chart1.Series[2].Points.AddXY(t1, 1);
                    t01 = t1;
                }
            }
            while (t2 <= T)
            {
                double a = random.NextDouble();

                a = random.NextDouble();
                t2 = t02 - Math.Log(a) / lambda1;
                if (t2 <= T)
                {
                    this.chart1.Series[1].Points.AddXY(t2, 2);
                    this.chart1.Series[2].Points.AddXY(t2, 1);
                    t02 = t2;
                }
            }
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Lab17_Load(object sender, EventArgs e)
        {
            this.Reload();
        }
    }
}
