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
	public partial class Lab14 : Form
	{
		public Lab14()
		{
			InitializeComponent();
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			Form summ = new Summirovanie((double)averageValue.Value, (double)varianceValue.Value, (int)numberValue.Value, 0);
			summ.Show();
			Form tsumm = new Summirovanie((double)averageValue.Value, (double)varianceValue.Value, (int)numberValue.Value, 1);
			tsumm.Show();
			Form bm = new Summirovanie((double)averageValue.Value, (double)varianceValue.Value, (int)numberValue.Value, 2);
			bm.Show();
		}
	}
}
