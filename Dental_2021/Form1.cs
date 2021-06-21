using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Dental_2021
{

	public partial class Form1 : Form
	{
		public int index_s;
		public int index_c;
		public int index_p;
		
		//public string CmdText = "SELECT Лікарі.[Код лікаря], Лікарі.Прізвище, Лікарі.[Ім'я], Лікарі.[По батькові], Спеціальності.Спеціальність, [Категорії спеціальностей].Назва FROM Спеціальності INNER JOIN([Категорії спеціальностей] INNER JOIN Лікарі ON [Категорії спеціальностей].[Код категорії] = Лікарі.Категорія) ON Спеціальності.[Код спеціальності] = Лікарі.Спеціальність";
		//public string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\kims\\Desktop\\Стомат\\Dental_2021\\Dental_2021\\baza_0.accdb";

		public Form1()
		{
			InitializeComponent();
			/*OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
			// створення об'єкту типу DataSet
			DataSet ds = new DataSet();
			// заповнення таблиці "Лікарі"
			dataAdapter.Fill(ds, "[Лікарі]");
			dataGridView1.DataSource = ds.Tables[0].DefaultView;*/

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet5.Пацієнти". При необходимости она может быть перемещена или удалена.
			this.пацієнтиTableAdapter2.Fill(this.baza_0DataSet5.Пацієнти);
						
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet2.Звернення". При необходимости она может быть перемещена или удалена.
			this.зверненняTableAdapter1.Fill(this.baza_0DataSet2.Звернення);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet1.Пацієнти". При необходимости она может быть перемещена или удалена.
			//	this.пацієнтиTableAdapter1.Fill(this.baza_0DataSet1.Пацієнти);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Діагнози". При необходимости она может быть перемещена или удалена.
			this.діагнозиTableAdapter.Fill(this.baza_0DataSet.Діагнози);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Лікування". При необходимости она может быть перемещена или удалена.
			this.лікуванняTableAdapter.Fill(this.baza_0DataSet.Лікування);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Звернення". При необходимости она может быть перемещена или удалена.
			this.зверненняTableAdapter.Fill(this.baza_0DataSet.Звернення);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Категорії_спеціальностей". При необходимости она может быть перемещена или удалена.
			this.категорії_спеціальностейTableAdapter.Fill(this.baza_0DataSet.Категорії_спеціальностей);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Категорії_пацієнтів". При необходимости она может быть перемещена или удалена.
			this.категорії_пацієнтівTableAdapter.Fill(this.baza_0DataSet.Категорії_пацієнтів);
			
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
			this.спеціальностіTableAdapter.Fill(this.baza_0DataSet.Спеціальності);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Пацієнти". При необходимости она может быть перемещена или удалена.
			this.пацієнтиTableAdapter.Fill(this.baza_0DataSet.Пацієнти);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "baza_0DataSet.Лікарі". При необходимости она может быть перемещена или удалена.
			this.лікаріTableAdapter.Fill(this.baza_0DataSet.Лікарі);
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Новий спеціаліст
			Add_Doctor f = new Add_Doctor();

			if (f.ShowDialog() == DialogResult.OK) // 
			{
				// 
				string prizv, names, bat;
				int	spec,categor;

				prizv = f.textBox1.Text;
				names = f.textBox2.Text;
				bat = f.textBox3.Text;
				spec = f.comboBox1.SelectedIndex+1;
				categor = f.comboBox2.SelectedIndex+1;
				// 
				this.лікаріTableAdapter.Insert(prizv, names,bat,spec,categor); // 
				this.лікаріTableAdapter.Fill(this.baza_0DataSet.Лікарі);

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//Видалення
			Del_Doctor fr = new Del_Doctor();
			int index = this.dataGridView1.CurrentRow.Index;
			int int32 = Convert.ToInt32(this.dataGridView1[0, index].Value);
			string Doctor_prizv = Convert.ToString(this.dataGridView1[1, index].Value);
			string Doctor_names = Convert.ToString(this.dataGridView1[2, index].Value);
			string Doctor_bat = Convert.ToString(this.dataGridView1[3, index].Value);
			string Doctor_spec = Convert.ToString(this.dataGridView1[4, index].Value);
			string Doctor_categor = Convert.ToString(this.dataGridView1[5, index].Value);

			fr.label2.Text = Doctor_prizv + "   " + Doctor_names+" "+ Doctor_bat;
			if (fr.ShowDialog() != DialogResult.OK)
				return;
			this.лікаріTableAdapter.Delete(int32, Doctor_prizv, Doctor_names, Doctor_bat, Convert.ToInt32(Doctor_spec), Convert.ToInt32(Doctor_categor));
			this.лікаріTableAdapter.Fill(this.baza_0DataSet.Лікарі);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Редагування
		
			Edit_Doctor fr = new Edit_Doctor();
			
			if (this.dataGridView1.RowCount <= 1)
				return;
			int index = this.dataGridView1.CurrentRow.Index;
			if (index == this.dataGridView1.RowCount - 1)
				return;
			//отримати дані рядка
			int Doctor_id = (int)this.dataGridView1.Rows[index].Cells[0].Value;
			string Doctor_prizv = (string)this.dataGridView1.Rows[index].Cells[1].Value;
			string Doctor_names = (string)this.dataGridView1.Rows[index].Cells[2].Value;
			string Doctor_bat = (string)this.dataGridView1.Rows[index].Cells[3].Value;
			int Doctor_spec =(int)this.dataGridView1.Rows[index].Cells[4].Value;
			int Doctor_categor = (int)this.dataGridView1.Rows[index].Cells[5].Value;

			
			//заповнити поля на формі
			fr.textBox1.Text = Doctor_prizv;
			fr.textBox2.Text = Doctor_names;
			fr.textBox3.Text = Doctor_bat;
			fr.label6.Text = Doctor_spec.ToString();
			fr.label7.Text = Doctor_categor.ToString();

			if (fr.ShowDialog() != DialogResult.OK)
				return;

			index_s = fr.comboBox1.SelectedIndex;
			index_c = fr.comboBox2.SelectedIndex;
			fr.comboBox1.SelectedIndex =index_s;
			fr.comboBox2.SelectedIndex = index_c;
				
			this.лікаріTableAdapter.Update(fr.textBox1.Text, fr.textBox2.Text,fr.textBox3.Text,fr.comboBox1.SelectedIndex+1, fr.comboBox2.SelectedIndex+1, Doctor_id, Doctor_prizv, Doctor_names,Doctor_bat, Doctor_spec, Doctor_categor);
			this.лікаріTableAdapter.Fill(this.baza_0DataSet.Лікарі);//*/
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			//Вихід
			Application.Exit();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			//Додавання нового пацієнта
			Add_Patient f = new Add_Patient();

			if (f.ShowDialog() == DialogResult.OK) // 
			{
				// 
				string prizv, names, bat, adresa ;
				int rik, categor;

				prizv = f.textBox1.Text;
				names = f.textBox2.Text;
				bat = f.textBox3.Text;
				rik = Convert.ToInt32(f.textBox4.Text);
				adresa = f.textBox5.Text;
				categor = f.comboBox1.SelectedIndex + 1;
				// 
				this.пацієнтиTableAdapter.Insert(prizv, names, bat, rik, adresa, categor); // 
				this.пацієнтиTableAdapter.Fill(this.baza_0DataSet.Пацієнти);

			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			//Видалення пацієнта
			
			Del_Patient fr = new Del_Patient();
			int index = this.dataGridView2.CurrentRow.Index;
			
			int int32 = Convert.ToInt32(this.dataGridView2[0, index].Value);
			string Patient_prizv = Convert.ToString(this.dataGridView2[1, index].Value);
			string Patient_names = Convert.ToString(this.dataGridView2[2, index].Value);
			string Patient_bat = Convert.ToString(this.dataGridView2[3, index].Value);
			int Patient_rik = Convert.ToInt32(this.dataGridView2[4, index].Value);
			string Patient_adresa = Convert.ToString(this.dataGridView2[5, index].Value);
			string Patient_categor = Convert.ToString(this.dataGridView2[6, index].Value);

			fr.label2.Text = Patient_prizv + "   " + Patient_names + " " + Patient_bat;
			if (fr.ShowDialog() != DialogResult.OK)
				return;

			this.пацієнтиTableAdapter.Delete(int32, Patient_prizv, Patient_names, Patient_bat, Patient_rik, Patient_adresa,Convert.ToInt32(Patient_categor));
			this.пацієнтиTableAdapter.Fill(this.baza_0DataSet.Пацієнти);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			//Редагувати пацієнта
			Edit_Patient fr = new Edit_Patient();

			if (this.dataGridView2.RowCount <= 1)
				return;
			int index = this.dataGridView2.CurrentRow.Index;
			if (index == this.dataGridView2.RowCount - 1)
				return;
			//отримати дані рядка
			int Patient_id = (int)this.dataGridView2.Rows[index].Cells[0].Value;
			string Patient_prizv = (string)this.dataGridView2.Rows[index].Cells[1].Value;
			string Patient_names = (string)this.dataGridView2.Rows[index].Cells[2].Value;
			string Patient_bat = (string)this.dataGridView2.Rows[index].Cells[3].Value;
			int Patient_rik = Convert.ToInt32(this.dataGridView2[4, index].Value);
			string Patient_adresa = Convert.ToString(this.dataGridView2[5, index].Value);
			string Patient_categor = Convert.ToString(this.dataGridView2[6, index].Value);

			//заповнити поля на формі
			fr.textBox1.Text = Patient_prizv;
			fr.textBox2.Text = Patient_names;
			fr.textBox3.Text =Patient_bat;
			fr.textBox4.Text = Patient_rik.ToString();
			fr.textBox5.Text = Patient_adresa;

			fr.label2.Text = Patient_categor.ToString();
			
			if (fr.ShowDialog() != DialogResult.OK)
				return;

			index_p= fr.comboBox1.SelectedIndex;
			fr.comboBox1.SelectedIndex = index_p;
			
			this.пацієнтиTableAdapter.Update(fr.textBox1.Text, fr.textBox2.Text, fr.textBox3.Text,Convert.ToInt32(fr.textBox4.Text), fr.textBox5.Text, fr.comboBox1.SelectedIndex + 1, Patient_id, Patient_prizv, Patient_names, Patient_bat, Patient_rik, Patient_adresa,Convert.ToInt32(Patient_categor));
			this.пацієнтиTableAdapter.Fill(this.baza_0DataSet.Пацієнти);

		}

		private void button7_Click(object sender, EventArgs e)
		{
			//Новий прийом пацієнта
			int index;
			int id_prizv;
			string prizv;
			Add_Reception f = new Add_Reception();
			DateTime data,t;
			
			index = dataGridView3.CurrentRow.Index; // 
			id_prizv = (int)dataGridView3.Rows[index].Cells[0].Value;
			prizv = (string)dataGridView3.Rows[index].Cells[1].Value;
			f.textBox1.Text = prizv;
			
			if (f.ShowDialog() == DialogResult.OK) // 
			{
				t = f.dateTimePicker1.Value;
				data = new DateTime(t.Year, t.Month, t.Day);
				
				// Вставка інформації про прийом
				this.зверненняTableAdapter.Insert(id_prizv, data); // 
				this.зверненняTableAdapter.Fill(this.baza_0DataSet.Звернення);

			}
		
		}

		private void button11_Click(object sender, EventArgs e)
		{
			//Додати дані про прийом
			
			int index;
			int id_zvern;
			double suma;
			int index_doctor;
			int index_diagnoz;
			Add_Treatment f = new Add_Treatment();
			
			index = dataGridView4.CurrentRow.Index; // 
			id_zvern = (int)dataGridView4.Rows[index].Cells[0].Value;
			f.textBox1.Text = id_zvern.ToString(); 

			if (f.ShowDialog() == DialogResult.OK) // 
			{
				//index_doctor = f.comboBox4.SelectedIndex;
				//fr.comboBox1.SelectedIndex = index_p;
				index_doctor= f.comboBox3.SelectedIndex+2;
				index_diagnoz = f.comboBox4.SelectedIndex+1;
				suma =Convert.ToDouble(f.textBox2.Text);
				// Вставка інформації про прийом
				this.лікуванняTableAdapter.Insert(id_zvern,index_doctor, index_diagnoz, Convert.ToDecimal(suma)); // 
				this.лікуванняTableAdapter.Fill(this.baza_0DataSet.Лікування);

			}
		}
	}
}
