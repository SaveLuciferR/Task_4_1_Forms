using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_1_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double res(double x, int n)
		{
			double result;

			if (n == 0) result = 1;
			else if (n < 0) result = 1 / res(x, Math.Abs(n));
			else result = x * res(x, n - 1);

			return result;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				double x = Convert.ToDouble(textBox1.Text);
				int n = Convert.ToInt32(textBox2.Text);

				textBox3.Text = String.Format("Число {0} в степени {1} = {2}", x, n, res(x, n));
			}
			catch
			{
				textBox3.Text = "Введите корректные значения";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}
	}
}
