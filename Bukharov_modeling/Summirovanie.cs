using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bukharov_modeling
{
	public partial class Summirovanie : Form
	{
		public int N;
		public double Average;
		public double AverageReal;
		public double DAv;
		public double Variance;
		public double VarianceReal;
		public double DVa;
		public double X2;
		public double X2Real = 19.7;
		public double a;
		public double d, min, max, l;
		public int n = 12, k;
		public int Index;
		public long t1, t2;

		public ICollection<double> Results = new List<double>();
		public List<int> Answers;

		Random random = new Random();
		public Summirovanie(double a, double d, int n, int index)
		{
			this.Index = index;
			this.N = n;
			this.a = a;
			this.d = d;
			InitializeComponent();
			if (Index == 0)
			{
				this.Text = "Summirovanie";
			}
			else if (Index == 1)
			{
				this.Text = "Tochnoe summirovanie";
			}
			else
			{
				this.Text = "Box-Muller";
			}
		}

		private void Summirovanie_Load(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
		}

		public void Reload()
		{
			this.chart1.Series[0].Points.Clear();
			this.chart1.Series[1].Points.Clear();
			this.Average = 0;
			this.Variance = 0;
			this.AverageReal = 0;
			this.VarianceReal = 0;
			this.X2 = 0;
			this.Results.Clear();
		}

		public void Summir()
		{
			for (int i = 0; i < N; i++)
			{
				double sh = 0;
				for (int j = 0; j < n; j++)
				{
					sh += random.NextDouble();
				}
				double C = (sh - n * a) / (Math.Sqrt(d * n));
				Results.Add(C);
				Average += C;
				Variance += C * C;
				if (i == 0)
					min = max = C;
				if (C < min)
					min = C;
				if (C > max)
					max = C;
			}
		}

		public void TochnoeSummir()
		{
			Summir();
			ICollection<double> Results2 = new List<double>();
			for (int i = 0; i < N; i++)
			{
				Results2.Add(Results.ElementAt(i) + (Math.Pow(Results.ElementAt(i), 3) - 3 * Results.ElementAt(i)) / 240);
			}
			Results = Results2;
		}

		public void BM()
		{
			for (int i = 0; i < N; i++)
			{
				double a1 = random.NextDouble();
				double a2 = random.NextDouble();
				double C = Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2);
				Results.Add(C);
				Average += C;
				Variance += C * C;
				if (i == 0)
					min = max = C;
				if (C < min)
					min = C;
				if (C > max)
					max = C;
			}
		}

		public void Calculate()
		{
			t1 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			if (Index == 0)
			{
				Summir();
			}
			else if (Index == 1)
			{
				TochnoeSummir();
			}
			else
			{
				BM();
			}
			
			k = (int)Math.Ceiling(Math.Sqrt(N)/4) + 1;
			//k = 20;
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
				this.chart1.Series[0].Points.AddXY(j * l + min + l / 2, f);
				//this.chart1.Series[1].Points.AddXY(ev.m, ev.p);
			}
			for (int j = 0; j < k; j++)
			{
				double mid = j * l + min + l / 2;
				double p = l * Math.Exp(-Math.Pow(mid - a, 2) / (2 * d)) / Math.Sqrt(d * 2 * Math.PI);

				X2 += Answers[j] * Answers[j] / (N * p);

				chart1.Series[1].Points.AddXY(mid, (double)Answers[j] / N);
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
			t2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			timeValue.Text = (t2 - t1).ToString()+" ms";
		}

		private void reloadBtn_Click(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
		}
	}
}
