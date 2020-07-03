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
    public partial class Lab18 : Form
    {
        Random random = new Random();
        int n = 10;
        int x = 0;
        int y = 0;
        double la = 10;
        double ls = 1;
        public double t = 0;
        public queue q;
        public services s;

        public void Step()
        {
            service serv = s.min();
            if (serv.t == -1 || serv.t > q.t)
            {
                this.t = q.t;
                q.getNextEvent();
                if (s.busy() == n)
                {
                    q.add();
                }
                else
                {
                    s.setBusy(this.t);
                }
            }
            else
            {
                this.t = serv.t;
                if (q.count == 0)
                {
                    serv.t = -1;
                }
                else
                {
                    q.count--;
                    serv.setTime(this.t);
                }

            }
            this.chart1.Series[0].Points.Clear();
            this.chart2.Series[0].Points.Clear();
            this.chart1.Series[0].Points.AddXY(0, q.count);
            for (int i = 0; i < n; i++)
            {
                double ti = s[i].t - t;
                if (ti < 0) ti = 0;
                this.chart2.Series[0].Points.AddXY(i, ti);
            }

        }

        public class services : List<service>
        {
            double ls;
            int n;
            public Lab18 lab { get; set; }
            public services(int n, double ls, Lab18 lab) : base()
            {
                this.n = n;
                this.ls = ls;
                this.lab = lab;
                for (int i = 0; i < this.n; i++)
                {
                    this.Add(new service(this.ls, this.lab));
                }
            }
            public void setBusy(double T)
            {
                foreach (service s in this)
                {
                    if (s.t == -1)
                    {
                        s.setTime(T);
                        break;
                    }
                }
            }
            public service min()
            {
                service ms = this[0];
                foreach (service s in this)
                {
                    if ((s.t != -1) && ((s.t < ms.t) || (ms.t == -1)))
                    {
                        ms = s;
                    }
                }
                return ms;
            }

            public int busy()
            {
                int c = 0;
                foreach (service s in this)
                {
                    if (s.t != -1)
                        c++;
                }
                return c;
            }

        }
        public class service
        {
            public double t { get; set; }
            public double lambda { get; set; }
            public Random random { get; set; } = new Random();
            public Lab18 lab { get; set; }
            public service(double lambda, Lab18 lab)
            {
                this.lambda = lambda;
                this.lab = lab;
            }
            public void setTime(double T)
            {
                this.t = T + this.RV();
            }
            public double RV()
            {
                double a = rand();
                return -1 * Math.Log(lab.random.NextDouble()) / lambda;
            }
            public double rand()
            {
                return this.random.NextDouble();
            }

        }
        public class queue
        {
            public int count { get; set; }
            public double t { get; set; }
            public double lambda { get; set; }
            public Random random { get; set; } = new Random();
            public queue(double lambda)
            {
                this.lambda = lambda;
                this.t = -1;
            }
            public void getNextEvent()
            {
                this.t += this.RV();
            }
            public double RV()
            {
                double a = random.NextDouble();
                return -1 * Math.Log(a) / lambda;
            }
            public void add()
            {
                this.count++;
            }
        }

        public Lab18()
        {
            q = new queue(la);
            s = new services(n, ls, this);
            InitializeComponent();
            this.timer1.Interval = 100;
        }

        private void Lab18_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Step();
        }
    }
}
