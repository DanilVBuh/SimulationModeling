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
    public partial class Lab18 : Form
    {
        Random random = new Random();
        int n = 10;
        int x = 0;
        int y = 0;
        double la = 1;
        double ls = 2;
        double t = 0;
        double ta;
        List<double> ts;

        public class queue
        {
            public int count { get; set; }
            public double t { get; set; }
            public double lambda { get; set; }
            public Random random { get; set; } = new Random();
            public queue(double lambda)
            {
                this.lambda = lambda;
            }
            public void getNextEvent()
            {

            }
            public double RV()
            {
                double a = random.NextDouble();
                return -1 * Math.Log(a) / lambda;
            }
        }

        public Lab18()
        {
            ts = new List<double>(n);
            InitializeComponent();
        }

        private void Lab18_Load(object sender, EventArgs e)
        {

        }
    }
}
