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
	public partial class Add_Doctor : Form
	{
		public Add_Doctor()
		{
			InitializeComponent();
		}

		private void Add_Doctor_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Лікарі". При необходимости она может быть перемещена или удалена.
			this.лікаріTableAdapter.Fill(this.baza_0DataSet.Лікарі);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Категорії_спеціальностей". При необходимости она может быть перемещена или удалена.
			this.категорії_спеціальностейTableAdapter.Fill(this.baza_0DataSet.Категорії_спеціальностей);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
			this.спеціальностіTableAdapter.Fill(this.baza_0DataSet.Спеціальності);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
