namespace Dental_2021
{
	partial class Add_Patient
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.baza_0DataSet = new Dental_2021.baza_0DataSet();
			this.пацієнтиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.пацієнтиTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ПацієнтиTableAdapter();
			this.пацієнтиЗверненняBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.зверненняTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ЗверненняTableAdapter();
			this.категоріїПацієнтівBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.категорії_пацієнтівTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.Категорії_пацієнтівTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.пацієнтиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.пацієнтиЗверненняBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїПацієнтівBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.категоріїПацієнтівBindingSource;
			this.comboBox1.DisplayMember = "Назва";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(467, 126);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 26;
			this.comboBox1.ValueMember = "Код категорії";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(329, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 16);
			this.label4.TabIndex = 25;
			this.label4.Text = "Категорія пацієнта";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(126, 124);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 22);
			this.textBox3.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(35, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 16);
			this.label3.TabIndex = 23;
			this.label3.Text = "По батькові";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(382, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 39);
			this.button2.TabIndex = 22;
			this.button2.Text = "Вихід";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(195, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 39);
			this.button1.TabIndex = 21;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(126, 74);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 22);
			this.textBox2.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(126, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 22);
			this.textBox1.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(90, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Ім\'я";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(50, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "Прізвище";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(467, 20);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(74, 22);
			this.textBox4.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(351, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Рік народження";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(467, 65);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(184, 22);
			this.textBox5.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(405, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 29;
			this.label6.Text = "Адреса";
			// 
			// baza_0DataSet
			// 
			this.baza_0DataSet.DataSetName = "baza_0DataSet";
			this.baza_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// пацієнтиBindingSource
			// 
			this.пацієнтиBindingSource.DataMember = "Пацієнти";
			this.пацієнтиBindingSource.DataSource = this.baza_0DataSet;
			// 
			// пацієнтиTableAdapter
			// 
			this.пацієнтиTableAdapter.ClearBeforeFill = true;
			// 
			// пацієнтиЗверненняBindingSource
			// 
			this.пацієнтиЗверненняBindingSource.DataMember = "ПацієнтиЗвернення";
			this.пацієнтиЗверненняBindingSource.DataSource = this.пацієнтиBindingSource;
			// 
			// зверненняTableAdapter
			// 
			this.зверненняTableAdapter.ClearBeforeFill = true;
			// 
			// категоріїПацієнтівBindingSource
			// 
			this.категоріїПацієнтівBindingSource.DataMember = "Категорії пацієнтів";
			this.категоріїПацієнтівBindingSource.DataSource = this.baza_0DataSet;
			// 
			// категорії_пацієнтівTableAdapter
			// 
			this.категорії_пацієнтівTableAdapter.ClearBeforeFill = true;
			// 
			// Add_Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 266);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Add_Patient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Додавання нового пацієнта";
			this.Load += new System.EventHandler(this.Add_Patient_Load);
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.пацієнтиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.пацієнтиЗверненняBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїПацієнтівBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private baza_0DataSet baza_0DataSet;
		private System.Windows.Forms.BindingSource пацієнтиBindingSource;
		private baza_0DataSetTableAdapters.ПацієнтиTableAdapter пацієнтиTableAdapter;
		private System.Windows.Forms.BindingSource пацієнтиЗверненняBindingSource;
		private baza_0DataSetTableAdapters.ЗверненняTableAdapter зверненняTableAdapter;
		private System.Windows.Forms.BindingSource категоріїПацієнтівBindingSource;
		private baza_0DataSetTableAdapters.Категорії_пацієнтівTableAdapter категорії_пацієнтівTableAdapter;
	}
}