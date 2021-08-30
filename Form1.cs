using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Ahmet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}
		void mesajGoster(string mesaj)
		{
			label1.Text = mesaj;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			mesajGoster("merhaba");
			//label1.Text = "Merhaba";
			////label1.Visible = true;

		}
	}
}
