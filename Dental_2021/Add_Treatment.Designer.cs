namespace Dental_2021
{
	partial class Add_Treatment
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
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.діагнозиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.baza_0DataSet = new Dental_2021.baza_0DataSet();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.лікаріBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.лікаріBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.лікаріTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ЛікаріTableAdapter();
			this.діагнозиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.діагнозиTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ДіагнозиTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.діагнозиBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.лікаріBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.лікаріBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.діагнозиBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(53, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 16);
			this.label4.TabIndex = 34;
			this.label4.Text = "Номер звернення";
			// 
			// comboBox4
			// 
			this.comboBox4.DataSource = this.діагнозиBindingSource1;
			this.comboBox4.DisplayMember = "Найменування діагнозу";
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(188, 121);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(184, 21);
			this.comboBox4.TabIndex = 43;
			this.comboBox4.ValueMember = "Код діагнозу";
			// 
			// діагнозиBindingSource1
			// 
			this.діагнозиBindingSource1.DataMember = "Діагнози";
			this.діагнозиBindingSource1.DataSource = this.baza_0DataSet;
			// 
			// baza_0DataSet
			// 
			this.baza_0DataSet.DataSetName = "baza_0DataSet";
			this.baza_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(124, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 16);
			this.label6.TabIndex = 42;
			this.label6.Text = "Діагноз";
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.лікаріBindingSource1;
			this.comboBox3.DisplayMember = "Прізвище";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(188, 73);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(184, 21);
			this.comboBox3.TabIndex = 41;
			this.comboBox3.ValueMember = "Код лікаря";
			// 
			// лікаріBindingSource1
			// 
			this.лікаріBindingSource1.DataMember = "Лікарі";
			this.лікаріBindingSource1.DataSource = this.baza_0DataSet;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(124, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 40;
			this.label5.Text = "Лікар";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(188, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 22);
			this.textBox1.TabIndex = 39;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(140, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 16);
			this.label3.TabIndex = 38;
			this.label3.Text = "Сума";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(294, 231);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 39);
			this.button2.TabIndex = 45;
			this.button2.Text = "Вихід";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(157, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 39);
			this.button1.TabIndex = 44;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(188, 176);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 22);
			this.textBox2.TabIndex = 46;
			// 
			// лікаріBindingSource
			// 
			this.лікаріBindingSource.DataMember = "Лікарі";
			this.лікаріBindingSource.DataSource = this.baza_0DataSet;
			// 
			// лікаріTableAdapter
			// 
			this.лікаріTableAdapter.ClearBeforeFill = true;
			// 
			// діагнозиBindingSource
			// 
			this.діагнозиBindingSource.DataMember = "Діагнози";
			this.діагнозиBindingSource.DataSource = this.baza_0DataSet;
			// 
			// діагнозиTableAdapter
			// 
			this.діагнозиTableAdapter.ClearBeforeFill = true;
			// 
			// Add_Treatment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 302);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Name = "Add_Treatment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Додавання інформації про лікування";
			this.Load += new System.EventHandler(this.Add_Treatment_Load);
			((System.ComponentModel.ISupportInitialize)(this.діагнозиBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.лікаріBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.лікаріBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.діагнозиBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox2;
		private baza_0DataSet baza_0DataSet;
		private System.Windows.Forms.BindingSource лікаріBindingSource;
		private baza_0DataSetTableAdapters.ЛікаріTableAdapter лікаріTableAdapter;
		private System.Windows.Forms.BindingSource діагнозиBindingSource;
		private baza_0DataSetTableAdapters.ДіагнозиTableAdapter діагнозиTableAdapter;
		private System.Windows.Forms.BindingSource діагнозиBindingSource1;
		private System.Windows.Forms.BindingSource лікаріBindingSource1;
	}
}