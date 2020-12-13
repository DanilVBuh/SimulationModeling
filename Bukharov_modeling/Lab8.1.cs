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
	public partial class Lab81 : Form
	{
		double p = 0.5;
		Random random = new Random();
		public Lab81()
		{
			InitializeComponent();
			this.Text = "?";
		}

		private void answerBtn_Click(object sender, EventArgs e)
		{
			double a = random.NextDouble();
			if (a < p) answerLabel.Text = "To be";
			else answerLabel.Text = "Not to be";
		}
	}
}
