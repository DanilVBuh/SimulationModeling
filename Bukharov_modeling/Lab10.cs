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
	public partial class Lab10 : Form
	{
		Random random = new Random();
		public Lab10()
		{
			InitializeComponent();
		}

		public class Event
		{
			public double p { get; set; }
			public int n { get; set; }

			public Event(double p, int n)
			{
				this.p = p;
				this.n = n;
			}
		}

		ICollection<Event> Player = new List<Event> {
			new Event((double)1/6, 1),
			new Event((double)1/6, 2),
			new Event((double)1/6, 3),
			new Event((double)1/6, 4),
			new Event((double)1/6, 5),
			new Event((double)1/6, 6)
		};

		ICollection<Event> Cheater = new List<Event> {
			new Event(0.14, 1),
			new Event(0.15, 2),
			new Event(0.16, 3),
			new Event(0.17, 4),
			new Event(0.18, 5),
			new Event(0.20, 6)
		};

		private void playBtn_Click(object sender, EventArgs e)
		{
			int player = 0, cheater = 0;
			double A = random.NextDouble();
			double a = A;
			foreach (Event ev in Player)
			{
				a -= ev.p;
				if (a < 0)
				{
					player = ev.n;
					playerScore.Text = player.ToString();
					break;
				}
			}
			A = random.NextDouble();
			a = A;
			foreach (Event ev in Cheater)
			{
				a -= ev.p;
				if (a < 0)
				{
					cheater = ev.n;
					cheaterScore.Text = cheater.ToString();
					break;
				}
			}
			if (player > cheater)
			{
				result.Text = "You WIN";
			}
			else if(player < cheater)
			{
				result.Text = "You LOSE";
			}
			else
			{
				result.Text = "DRAW";
			}
		}
	}
}
