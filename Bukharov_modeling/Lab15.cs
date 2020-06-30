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
    public partial class Lab15 : Form
    {
        Random random = new Random();
        public double T = 0;
        public double nextT = 0;
        public double dt = 1;
        public int i0 = 0;
        public List<List<double>> q = new List<List<double>>
        {
            new List<double>{-0.4, 0.3, 0.1},
            new List<double>{0.4, -0.8, 0.4},
            new List<double>{0.1, 0.4, -0.5},
        };

        ICollection<Event> events = new List<Event>();
        public class Event
        {

            public double t { get; set; }
            public int m { get; set; }

            public Event(double t, int m)
            {
                this.t = t;
                this.m = m;
            }

        }
        public Lab15()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }
        public void Reload()
        {
            this.chart1.Series[0].Points.Clear();
            this.T = 0;
            this.nextT = 0;
            this.i0 = 0;
            this.events.Clear();
            timer1.Start();
        }

        public void Calculate()
        {
            double a = random.NextDouble();
            double t = Math.Log(a) / q[i0][i0];
            T += t;
            a = random.NextDouble();
            List<double> p = new List<double>();
            for (int j = 0; j < 3; j++)
            {
                if (i0 != j)
                {
                    p.Add(-1 * q[i0][j] / q[i0][i0]);
                }
                else
                {
                    p.Add(0);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                a -= p[i];
                if (a < 0)
                {

                    i0 = i;
                    break;
                }
            }
            while (T >= nextT & nextT <= 24)
            {
                this.chart1.Series[0].Points.AddXY(nextT, i0 + 1);
                nextT += dt;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void Lab15_Load(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (T > 24)
                timer1.Stop();
            this.Calculate();
        }
    }
}
