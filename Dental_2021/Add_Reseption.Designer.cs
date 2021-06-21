namespace Dental_2021
{
	partial class Add_Reception
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.пацієнтиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baza_0DataSet = new Dental_2021.baza_0DataSet();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.пацієнтиTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ПацієнтиTableAdapter();
			this.зверненняBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.зверненняTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ЗверненняTableAdapter();
			this.лікаріBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.лікаріTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ЛікаріTableAdapter();
			this.діагнозиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.діагнозиTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ДіагнозиTableAdapter();
			this.зверненняBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.пацієнтиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.зверненняBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.лікаріBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.діагнозиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.зверненняBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(245, 140);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 39);
			this.button2.TabIndex = 19;
			this.button2.Text = "Вихід";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(82, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 39);
			this.button1.TabIndex = 18;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(101, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Дата";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(79, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Пацієнт";
			// 
			// пацієнтиBindingSource
			// 
			this.пацієнтиBindingSource.DataMember = "Пацієнти";
			this.пацієнтиBindingSource.DataSource = this.baza_0DataSet;
			// 
			// baza_0DataSet
			// 
			this.baza_0DataSet.DataSetName = "baza_0DataSet";
			this.baza_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(147, 77);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
			this.dateTimePicker1.TabIndex = 29;
			// 
			// пацієнтиTableAdapter
			// 
			this.пацієнтиTableAdapter.ClearBeforeFill = true;
			// 
			// зверненняBindingSource
			// 
			this.зверненняBindingSource.DataMember = "Звернення";
			this.зверненняBindingSource.DataSource = this.baza_0DataSet;
			// 
			// зверненняTableAdapter
			// 
			this.зверненняTableAdapter.ClearBeforeFill = true;
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
			// зверненняBindingSource1
			// 
			this.зверненняBindingSource1.DataMember = "Звернення";
			this.зверненняBindingSource1.DataSource = this.baza_0DataSet;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(145, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 22);
			this.textBox1.TabIndex = 31;
			// 
			// Add_Reception
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 204);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Add_Reception";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Прийом";
			this.Load += new System.EventHandler(this.Add_Reception_Load);
			((System.ComponentModel.ISupportInitialize)(this.пацієнтиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.зверненняBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.лікаріBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.діагнозиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.зверненняBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private baza_0DataSet baza_0DataSet;
		private System.Windows.Forms.BindingSource пацієнтиBindingSource;
		private baza_0DataSetTableAdapters.ПацієнтиTableAdapter пацієнтиTableAdapter;
		private System.Windows.Forms.BindingSource зверненняBindingSource;
		private baza_0DataSetTableAdapters.ЗверненняTableAdapter зверненняTableAdapter;
		private System.Windows.Forms.BindingSource лікаріBindingSource;
		private baza_0DataSetTableAdapters.ЛікаріTableAdapter лікаріTableAdapter;
		private System.Windows.Forms.BindingSource діагнозиBindingSource;
		private baza_0DataSetTableAdapters.ДіагнозиTableAdapter діагнозиTableAdapter;
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.BindingSource зверненняBindingSource1;
		public System.Windows.Forms.TextBox textBox1;
	}
}