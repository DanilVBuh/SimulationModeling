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
	public partial class Lab11 : Form
	{
		Random random = new Random();
		ICollection<Event> Probs = new List<Event>();
		double AverageReal;
		double VarianceReal;
		public Lab11()
		{
			InitializeComponent();
		}

		public class Event
		{

			public double p { get; set; }
			public double f { get; set; }
			public int m { get; set; }
			public double n { get; set; } = 0;

			public Event(double p, int m)
			{
				this.p = p;
				this.m = m;
			}

		}
		public void Restart()
		{
			Probs = new List<Event>();
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			Restart();
			prob5.Value = 1 - (prob1.Value + prob2.Value + prob3.Value + prob4.Value);
			Probs.Add(new Event((double)prob1.Value, 1));
			Probs.Add(new Event((double)prob2.Value, 2));
			Probs.Add(new Event((double)prob3.Value, 3));
			Probs.Add(new Event((double)prob4.Value, 4));
			Probs.Add(new Event((double)prob5.Value, 5));
			Form form10 = new ChartForm(10, Probs);
			form10.Show();
			Form form100 = new ChartForm(100, Probs);
			form100.Show();
			Form form1000 = new ChartForm(1000, Probs);
			form1000.Show();
			Form form10000 = new ChartForm(10000, Probs);
			form10000.Show();
			foreach (Event ev in Probs)
			{				
				AverageReal += ev.p * ev.m;
			}
			foreach (Event ev in Probs)
			{
				VarianceReal += ev.p * ev.m * ev.m;
			}
			VarianceReal -= AverageReal * AverageReal;
			averageValue.Text = AverageReal.ToString("F6");
			varianceValue.Text = VarianceReal.ToString("F6");
		}
	}
}
