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
	public partial class Add_Reception : Form
	{
		public Add_Reception()
		{
			InitializeComponent();
		}

		private void Add_Reception_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Діагнози". При необходимости она может быть перемещена или удалена.
			this.діагнозиTableAdapter.Fill(this.baza_0DataSet.Діагнози);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Лікарі". При необходимости она может быть перемещена или удалена.
			this.лікаріTableAdapter.Fill(this.baza_0DataSet.Лікарі);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Звернення". При необходимости она может быть перемещена или удалена.
			this.зверненняTableAdapter.Fill(this.baza_0DataSet.Звернення);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Пацієнти". При необходимости она может быть перемещена или удалена.
			this.пацієнтиTableAdapter.Fill(this.baza_0DataSet.Пацієнти);

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
