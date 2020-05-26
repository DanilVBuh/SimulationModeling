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
	public partial class Lab9 : Form
	{
		Random random = new Random();
		ICollection<Event> Probs = new List<Event>();
		public Lab9()
		{
			InitializeComponent();
		}

		public class Event
		{

			public double p { get; set; }
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
			chart10.Series[0].Points.Clear();
			chart100.Series[0].Points.Clear();
			chart1000.Series[0].Points.Clear();
			chart10000.Series[0].Points.Clear();
		}
		public void Reload()
		{
			foreach (Event e in Probs)
				e.n = 0;
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
			for (int i = 0; i < 10; i++)
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
				chart10.Series[0].Points.AddXY(ev.m, ev.n / 10);
				chart10.Series[1].Points.AddXY(ev.m, ev.p);
			}
			Reload();
			for (int i = 0; i < 100; i++)
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
				chart100.Series[0].Points.AddXY(ev.m, ev.n / 100);
				chart100.Series[1].Points.AddXY(ev.m, ev.p);
			}
			Reload();
			for (int i = 0; i < 1000; i++)
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
				chart1000.Series[0].Points.AddXY(ev.m, ev.n / 1000);
				chart1000.Series[1].Points.AddXY(ev.m, ev.p);
			}
			Reload();
			for (int i = 0; i < 10000; i++)
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
				chart10000.Series[0].Points.AddXY(ev.m, ev.n / 10000);
				chart10000.Series[1].Points.AddXY(ev.m, ev.p);
			}
			Reload();
		}
	}
}
