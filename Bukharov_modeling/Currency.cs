using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
	public partial class Currency : Form
	{
		double Price;
		double Days;
		double Day;
		double Rubles;
		double Rub;
		double Eur;
		double EurAmount;
		bool paused = false;
		public const double dt = 0.001;
		const double k = 0.02;

		double mu = 1;
		double sigma = 1.2;
		double s = 0;
		double w = 0;
		Random random = new Random();
		public Currency()
		{
			InitializeComponent();
			timer1.Interval = (int)(50000 * dt);
			ExchangePanel.Visible = false;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			//Моделирование Геометрического броуновского движения
			w += Math.Sqrt(dt) * this.Norm();
			s = (Price * Math.Exp((mu - sigma * sigma / 2) * dt + sigma * w));
			Day++;
			Price = s;
			chart1.Series[0].Points.AddXY(Day, Price);
			TimeText.Text = Day.ToString();
			RubText.Text = Rub.ToString("F4");
			EurText.Text = Eur.ToString("F4");
			ActualPriceText.Text = Price.ToString("F4");
			if (Day >= Days)
			{
				timer1.Stop();
				PauseBtn.Visible = false;
				ExchangePanel.Visible = true;
			}
		}

		public double Norm()
        {
			double a1 = random.NextDouble();
			double a2 = random.NextDouble();
			return Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2);
		}

		private void SartBtn_Click(object sender, EventArgs e)
		{
			w = 0;
			ExchangePanel.Visible = false;
			PauseBtn.Visible = true;
			Day = 0;
			chart1.Series[0].Points.Clear();
			Price = (double)PriceText.Value;
			Days = (double)DaysText.Value;
			Rubles = (double)RublesText.Value;
			Rub = Rubles;
			Eur = 0;
			RubText.Text = Rub.ToString("F4");
			EurText.Text = Eur.ToString("F4");
			ActualPriceText.Text = Price.ToString("F4");
			TimeText.Text = Day.ToString();
			/*chart1.ChartAreas[0].AxisY.Maximum = Price * Math.Pow(1 + k * 0.5, Days);
			chart1.ChartAreas[0].AxisY.Minimum = Price * Math.Pow(1 - k * 0.5, Days);*/
			//chart1.ChartAreas[0].AxisY.Maximum = Price * 3;
			//chart1.ChartAreas[0].AxisY.Minimum = Price * 0;
			chart1.ChartAreas[0].AxisX.Maximum = Days;
			chart1.ChartAreas[0].AxisX.Minimum = 0;
			chart1.Series[0].Points.AddXY(Day, Price);
			timer1.Start();
		}

		private void PauseBtn_Click(object sender, EventArgs e)
		{
			if (paused)
			{
				ExchangePanel.Visible = false;
				timer1.Start();
				PauseBtn.Text = "Pause";
			}
			else
			{
				timer1.Stop();
				ExchangePanel.Visible = true;
				PauseBtn.Text = "Continue";
			}
			paused = !paused;
		}


		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void BuyBtn_Click(object sender, EventArgs e)
		{
			EurAmount = (double)EuroAmountText.Value;
			if (EurAmount * Price > Rub)
			{
				Eur += Rub / Price;
				Rub = 0;
			}
			else
			{
				Eur += EurAmount;
				Rub -= EurAmount * Price;
			}
			RubText.Text = Rub.ToString("F4");
			EurText.Text = Eur.ToString("F4");
		}

		private void SellBtn_Click(object sender, EventArgs e)
		{
			EurAmount = (double)EuroAmountText.Value;
			if (EurAmount > Eur)
			{
				Rub += Eur * Price;
				Eur = 0;
			}
			else
			{
				Eur -= EurAmount;
				Rub += EurAmount * Price;
			}
			RubText.Text = Rub.ToString("F4");
			EurText.Text = Eur.ToString("F4");
		}
	}
}
