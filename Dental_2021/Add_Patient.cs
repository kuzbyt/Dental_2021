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
	public partial class Add_Patient : Form
	{
		public Add_Patient()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Add_Patient_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Категорії_пацієнтів". При необходимости она может быть перемещена или удалена.
			this.категорії_пацієнтівTableAdapter.Fill(this.baza_0DataSet.Категорії_пацієнтів);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Звернення". При необходимости она может быть перемещена или удалена.
			this.зверненняTableAdapter.Fill(this.baza_0DataSet.Звернення);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Пацієнти". При необходимости она может быть перемещена или удалена.
			this.пацієнтиTableAdapter.Fill(this.baza_0DataSet.Пацієнти);

		}
	}
}
