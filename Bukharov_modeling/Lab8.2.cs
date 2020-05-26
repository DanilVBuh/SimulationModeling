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
	public partial class Lab82 : Form
	{
		Random random = new Random();
		public Lab82()
		{
			InitializeComponent();
		}

		public class Event
		{
			public double p { get; set; }
			public Color c { get; set; }

			public Event(double p, Color c)
			{
				this.p = p;
				this.c = c;
			}
		}

		ICollection<Event> P = new List<Event> { 
			new Event(0.15, Color.Red),
			new Event(0.2, Color.Blue),
			new Event(0.3, Color.Green),
			new Event(0.05, Color.Pink),
			new Event(0.2, Color.Yellow),
			new Event(0.1, Color.Cyan),
		};

		private void answerBtn_Click(object sender, EventArgs e)
		{
			double A = random.NextDouble();
			double a = A;
			foreach(Event ev in P)
			{
				a -= ev.p;
				if (a < 0)
				{
					this.BackColor = ev.c;
					answerLabel.Text = ev.c.Name;
					break;
				}
			}
		}
	}
}
