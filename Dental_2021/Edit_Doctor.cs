using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dental_2021
{
	
	public partial class Edit_Doctor : Form
	{
		public Edit_Doctor()
		{
			InitializeComponent();
		}

		private void Edit_Doctor_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Категорії_спеціальностей". При необходимости она может быть перемещена или удалена.
			this.категорії_спеціальностейTableAdapter.Fill(this.baza_0DataSet.Категорії_спеціальностей);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
			this.спеціальностіTableAdapter.Fill(this.baza_0DataSet.Спеціальності);
			//Показати вибране значення в comboBox
			comboBox1.SelectedIndex = Convert.ToInt32(label6.Text)-1;
			comboBox2.SelectedIndex = Convert.ToInt32(label7.Text) - 1;
		}
			

		

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//вибір
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
