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
	public partial class Lab12 : Form
	{
		Random random = new Random();
		public Lab12()
		{
			InitializeComponent();
		}

		public class Team
		{
			public string Name { get; set; }
			public int Wins { get; set; } = 0;
			public int Goals { get; set; } = 0;
			public double Lambda { get; set; }

			public Team(string name, double l)
			{
				Name = name;
				Lambda = l;
			}
		}
		ICollection<Team> Teams = new List<Team>
		{
			new Team("Спартак", 3),
			new Team("Томь", 5),
			new Team("Химки", 1),
			new Team("ЦСКА", 4),
			new Team("Зенит", 2),
			new Team("Динамо", 3),
			new Team("Локомотив", 4),
		};

		public class Game
		{
			public Team Team1 { get; set; }
			public Team Team2 { get; set; }
			public Game(Team t1, Team t2)
			{
				Team1 = t1;
				Team2 = t2;
			}
		}
		ICollection<Game> Games = new List<Game>();
		int CurrenGame = 0;

		public int Factorial(int n)
		{
			int result = 1;
			for (int i = 2; i <= n; i++)
				result *= i;
			return result;
		}

		public void Display()
		{
			resultList.Items.Clear();
			ICollection<Team> teams = Teams.OrderByDescending(x => x.Goals).OrderByDescending(x => x.Wins).ToList();
			foreach (Team t in teams)
			{
				string[] Item = new string[3];
				Item[0] = t.Name;
				Item[1] = t.Wins.ToString();
				Item[2] = t.Goals.ToString();
				ListViewItem lvi = new ListViewItem(t.Name);
				lvi.SubItems.Add(t.Wins.ToString());
				lvi.SubItems.Add(t.Goals.ToString());
				resultList.Items.Add(lvi);
			}

		}

		private void Lab12_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < Teams.Count - 1; i++)
			{
				for (int j = i + 1; j < Teams.Count; j++)
				{
					Games.Add(new Game(Teams.ElementAt(i), Teams.ElementAt(j)));
				}
			}
			Display();
		}

		public void Play()
		{
			double A = random.NextDouble();
			double a = A;
			int goals = 0;
			while (true)
			{
				a -= Math.Pow(Games.ElementAt(CurrenGame).Team1.Lambda, goals)
					* Math.Exp(-Games.ElementAt(CurrenGame).Team1.Lambda)
					/ Factorial(goals);
				if (a < 0)
				{
					Games.ElementAt(CurrenGame).Team1.Goals += goals;
					break;
				}
				goals++;
			}
			A = random.NextDouble();
			a = A;
			goals = 0;
			while (true)
			{
				a -= Math.Pow(Games.ElementAt(CurrenGame).Team2.Lambda, goals)
					* Math.Exp(-Games.ElementAt(CurrenGame).Team2.Lambda)
					/ Factorial(goals);
				if (a < 0)
				{
					Games.ElementAt(CurrenGame).Team2.Goals += goals;
					break;
				}
				goals++;
			}
			if (Games.ElementAt(CurrenGame).Team1.Goals > Games.ElementAt(CurrenGame).Team2.Goals)
			{
				Games.ElementAt(CurrenGame).Team1.Wins++;
			}
			else if (Games.ElementAt(CurrenGame).Team1.Goals < Games.ElementAt(CurrenGame).Team2.Goals)
			{
				Games.ElementAt(CurrenGame).Team2.Wins++;
			}
			CurrenGame++;
			Display();
		}

		private void resultBtn_Click(object sender, EventArgs e)
		{
			if (CurrenGame < Games.Count )
			{
				Play();
			}
			else
			{
				resultBtn.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			resultBtn.Enabled = false;
			allResultBtn.Enabled = false;
			while (CurrenGame < Games.Count)
			{
				Play();
			}
		}
	}
}
