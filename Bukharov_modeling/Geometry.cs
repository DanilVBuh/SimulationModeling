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
	public partial class Geometry : Form
	{
		public int N = 0, amount = 100000;
		public double Average;
		public double AverageReal;
		public double DAv;
		public double Variance;
		public double VarianceReal;
		public double DVa;
		public double X2;
		public double X2Real = 15.507, p;
		Random random = new Random();

		List<int> score = new List<int>();
		public Geometry(double p)
		{
			this.p = p;
			InitializeComponent();
			this.Text = "Chart for " + N.ToString() + " experements";
			timer1.Interval = 1;
			score = new List<int>(new int[amount]);
		}

		public void Reload()
		{
			N = 0;
			score = new List<int>(new int[amount]);
			this.chart1.Series[0].Points.Clear();
			this.Average = 0;
			this.Variance = 0;
			this.AverageReal = 0;
			this.VarianceReal = 0;
			this.X2 = 0;
		}

		public void Calculate()
		{
			Average = 0;
			Variance = 0;
			X2 = 0;
			N++;
			//this.chart1.Series[0].Points.Clear();
			double a = random.NextDouble();
			int x = (int)(Math.Log(a) / Math.Log(1 - p));
			score[x]++;
			this.chart1.Series[0].Points.AddXY(x, score[x]);

			for (int i = 0; i < amount; i++)
			{
				Average += (double)score[i] / N * i;
				Variance += (double)score[i] / N * i * i;
			}
			double pp = 0;
			int nn = N;
			for (int i = 0; i < 7; i++)
			{
				X2 += score[i] * score[i] / (N * p * Math.Pow(1 - p, i));
				pp += Math.Pow(1 - p, i);
				nn -= score[i];
			}
			X2 += nn * nn / (N * (1 - pp));
			X2 -= N;
			Variance -= Average * Average;
			averageValue.Text = Average.ToString("F6");
			varianceValue.Text = Variance.ToString("F6");

			if (X2 > X2Real)
			{
				chi.Text = X2.ToString("F3") + " > " + X2Real.ToString("F3") + " is false";
			}
			else
			{
				chi.Text = X2.ToString("F3") + " <= " + X2Real.ToString("F3") + " is true";
			}
		}

		private void reloadBtn_Click(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
		}

		private void pauseBtn_Click(object sender, EventArgs e)
		{
			if (pauseBtn.Text == "Pause")
			{
				timer1.Stop();
				pauseBtn.Text = "Resume";
			}
			else
			{
				timer1.Start();
				pauseBtn.Text = "Pause";
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Calculate();
		}

		private void Geometry_Load(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
			timer1.Start();
		}
	}
}
