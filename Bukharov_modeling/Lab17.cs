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

        public int N = 1000;
        public double Average;
        public double AverageReal;
        public double DAv;
        public double Variance;
        public double VarianceReal;
        public double DVa;
        public double X2;
        public double X2Real = 19.7;
        public double a = 0.5;
        public double d = 1, min, max, l;
        public int n = 12, k;
        public int Index;
        public int m = 0;

        public ICollection<double> Results = new List<double>();
        public List<int> preRes = new List<int>();
        public List<int> Answers;

        double t01 = 0;
        double t1 = 0;
        double t02 = 0;
        double t2 = 0;
        double T = 50;
        double lambda1 = 0.5;
        double lambda2 = 1.5;
        public Lab17()
        {
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
                    //preRes.Add(t1);
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
                    //preRes.Add(t2);
                    t02 = t2;
                }
            }
        }

        public void Stat()
        {
            while (t1 <= T)
            {
                double a = random.NextDouble();

                a = random.NextDouble();
                t1 = t01 - Math.Log(a) / lambda1;
                if (t1 <= T)
                {
                    m++;
                    //preRes.Add(t1);
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
                    m++;
                    //preRes.Add(t2);
                    t02 = t2;
                }
            }
        }

        private void statBtn_Click(object sender, EventArgs e)
        {
            this.Average = 0;
            this.Variance = 0;
            this.AverageReal = 0;
            this.VarianceReal = 0;
            this.X2 = 0;
            this.Results.Clear();
            this.t1 = 0;
            this.t01 = 0;
            this.t2 = 0;
            this.t02 = 0;
            this.fun();
        }

        public void fun()
        {
            for (int i = 0; i < N; i++)
            {
                this.Stat();
                double C = m;
                Results.Add(C);
                Average += C;
                Variance += C * C;
                if (i == 0)
                    min = max = C;
                if (C < min)
                    min = C;
                if (C > max)
                    max = C;
                m = 0;
            }
            k = (int)Math.Ceiling(Math.Sqrt(N) / 4) + 1;
            l = (max - min) / k;
            Average /= N;
            Variance = Variance / N - Average * Average;
            Answers = new List<int>(new int[k + 1]);
            foreach (double c in Results)
            {
                double interval = (c - min) / l;
                Answers[(int)interval]++;
            }
            for (int j = 0; j < k; j++)
            {
                double f = (double)Answers[j] / N;
            }
            for (int j = 0; j < k; j++)
            {
                double mid = j * l + min + l / 2;
                double p = l * Math.Exp(-Math.Pow(mid - a, 2) / (2 * d)) / Math.Sqrt(d * 2 * Math.PI);

                X2 += Answers[j] * Answers[j] / (N * p);
            }
            X2 -= N;
            averageValue.Text = Average.ToString("F6");
            varianceValue.Text = Variance.ToString("F6");
            DVa = Math.Abs(d - Variance) / d * 100;
            DAv = Math.Abs(a - Average) / a * 100;
            averageError.Text = "(error = " + DAv.ToString("F4") + "%)";
            varianceError.Text = "(error = " + DVa.ToString("F4") + "%)";

            if (X2 > X2Real)
            {
                chi.Text = X2.ToString("F3") + " > " + X2Real.ToString("F3") + " is false";
            }
            else
            {
                chi.Text = X2.ToString("F3") + " <= " + X2Real.ToString("F3") + " is true";
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
