using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private int N; //
		private int I; //ініціалізація
		private int T; //
		private int Ti;//
		private void button1_Click(object sender, EventArgs e)
		{
			N = 100;
			I = 1;
			T = 0;
			Ti = 0;

			I = Convert.ToInt32(textBox1.Text);
			T = Convert.ToInt32(textBox2.Text);
			 
			for (int i = 1; i <= I; i++) //цикл знаходження часу і-того покупця
			{
				Ti = Ti + T; 
				}
			label3.Text = Convert.ToString(Ti);
			}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
