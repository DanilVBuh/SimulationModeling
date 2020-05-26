using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bukharov_modeling.Lab11;

namespace Bukharov_modeling
{
	public partial class ChartForm : Form
	{
		public int N;
		public double Average;
		public double AverageReal;
		public double DAv;
		public double Variance;
		public double VarianceReal;
		public double DVa;
		public double X2;
		public double X2Real = 11.07;
		Random random = new Random();
		ICollection<Event> Probs = new List<Event>();
		public ChartForm(int n, ICollection<Event> probs)
		{
			this.N = n;
			this.Probs = probs;
			InitializeComponent();
			this.Text = "Chart for " + N.ToString() + " experements";
			timer1.Interval = 100;
		}

		public void Reload()
		{
			this.chart1.Series[0].Points.Clear();
			this.Average = 0;
			this.Variance = 0;
			this.AverageReal = 0;
			this.VarianceReal = 0;
			this.X2 = 0;
			foreach (Event e in Probs)
			{
				e.n = 0;
				e.f = 0;
			}
		}

		public void Calculate()
		{
			for (int i = 0; i < N; i++)
			{
				double A = random.NextDouble();
				double a = A;
				foreach (Event ev in Probs)
				{
					a -= ev.p;
					if (a < 0)
					{
						ev.n++;
						break;
					}
				}
			}
			foreach (Event ev in Probs)
			{
				ev.f = ev.n / N;
				Average += ev.f * ev.m;
				AverageReal += ev.p * ev.m;
				this.chart1.Series[0].Points.AddXY(ev.m, ev.f);
				this.chart1.Series[1].Points.AddXY(ev.m, ev.p);
			}
			foreach (Event ev in Probs)
			{
				X2 += ev.n * ev.n / N / ev.p;
				Variance += ev.f * ev.m * ev.m;
				VarianceReal += ev.p * ev.m * ev.m;
			}
			X2 -= N;
			Variance -= Average * Average;
			VarianceReal -= AverageReal * AverageReal;
			averageValue.Text = Average.ToString("F6");
			varianceValue.Text = Variance.ToString("F6");
			DVa = Math.Abs(VarianceReal - Variance) / VarianceReal * 100;
			DAv = Math.Abs(AverageReal - Average) / AverageReal * 100;
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

		private void ChartForm_Load(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
		}

		private void reloadBtn_Click(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Reload();
			this.Calculate();
		}

		private void playBtn_Click(object sender, EventArgs e)
		{
			if (playBtn.Text == "Play")
			{
				playBtn.Text = "Pause";
				timer1.Start();
			}
			else
			{
				playBtn.Text = "Play";
				timer1.Stop();
			}
		}
	}
}
