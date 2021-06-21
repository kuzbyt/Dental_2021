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
	public partial class Edit_Patient : Form
	{
		public Edit_Patient()
		{
			InitializeComponent();
		}

		private void Edit_Patient_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Категорії_пацієнтів". При необходимости она может быть перемещена или удалена.
			this.категорії_пацієнтівTableAdapter.Fill(this.baza_0DataSet.Категорії_пацієнтів);
			comboBox1.SelectedIndex = Convert.ToInt32(label2.Text) - 1;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
