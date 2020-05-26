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
	public partial class Lab13 : Form
	{
		public Lab13()
		{
			InitializeComponent();
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			Form form = new Geometry((double)probValue.Value);
			form.Show();
		}
	}
}
