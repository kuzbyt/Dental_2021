namespace Dental_2021
{
	partial class Add_Doctor
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.спеціальностіBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baza0DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.baza_0DataSet = new Dental_2021.baza_0DataSet();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.категоріїСпеціальностейBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.спеціальностіTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.СпеціальностіTableAdapter();
			this.категоріїСпеціальностейBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.категорії_спеціальностейTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.Категорії_спеціальностейTableAdapter();
			this.категоріїСпкціальностейЛікаріBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.лікаріTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.ЛікаріTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baza0DataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїСпеціальностейBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїСпеціальностейBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїСпкціальностейЛікаріBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(384, 203);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 39);
			this.button2.TabIndex = 11;
			this.button2.Text = "Вихід";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(188, 203);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 39);
			this.button1.TabIndex = 10;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(119, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 22);
			this.textBox2.TabIndex = 9;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(119, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 22);
			this.textBox1.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(75, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Ім\'я";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(35, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Прізвище";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(119, 122);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 22);
			this.textBox3.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(20, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "По батькові";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(363, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Спеціальність";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(381, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Категорія";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.спеціальностіBindingSource;
			this.comboBox1.DisplayMember = "Спеціальність";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(468, 22);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 16;
			this.comboBox1.ValueMember = "Код спеціальності";
			// 
			// спеціальностіBindingSource
			// 
			this.спеціальностіBindingSource.DataMember = "Спеціальності";
			this.спеціальностіBindingSource.DataSource = this.baza0DataSetBindingSource;
			// 
			// baza0DataSetBindingSource
			// 
			this.baza0DataSetBindingSource.DataSource = this.baza_0DataSet;
			this.baza0DataSetBindingSource.Position = 0;
			// 
			// baza_0DataSet
			// 
			this.baza_0DataSet.DataSetName = "baza_0DataSet";
			this.baza_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.категоріїСпеціальностейBindingSource1;
			this.comboBox2.DisplayMember = "Назва";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(468, 71);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 17;
			this.comboBox2.ValueMember = "Код категорії";
			// 
			// категоріїСпеціальностейBindingSource1
			// 
			this.категоріїСпеціальностейBindingSource1.DataMember = "Категорії спеціальностей";
			this.категоріїСпеціальностейBindingSource1.DataSource = this.baza0DataSetBindingSource;
			// 
			// спеціальностіTableAdapter
			// 
			this.спеціальностіTableAdapter.ClearBeforeFill = true;
			// 
			// категоріїСпеціальностейBindingSource
			// 
			this.категоріїСпеціальностейBindingSource.DataMember = "Категорії спеціальностей";
			this.категоріїСпеціальностейBindingSource.DataSource = this.baza0DataSetBindingSource;
			// 
			// категорії_спеціальностейTableAdapter
			// 
			this.категорії_спеціальностейTableAdapter.ClearBeforeFill = true;
			// 
			// категоріїСпкціальностейЛікаріBindingSource
			// 
			this.категоріїСпкціальностейЛікаріBindingSource.DataMember = "Категорії спкціальностейЛікарі";
			this.категоріїСпкціальностейЛікаріBindingSource.DataSource = this.категоріїСпеціальностейBindingSource;
			// 
			// лікаріTableAdapter
			// 
			this.лікаріTableAdapter.ClearBeforeFill = true;
			// 
			// Add_Doctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 269);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
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
			this.Name = "Add_Doctor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Додавання нового лікаря";
			this.Load += new System.EventHandler(this.Add_Doctor_Load);
			((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baza0DataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїСпеціальностейBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїСпеціальностейBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїСпкціальностейЛікаріBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ComboBox comboBox1;
		public System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource baza0DataSetBindingSource;
		private baza_0DataSet baza_0DataSet;
		private System.Windows.Forms.BindingSource спеціальностіBindingSource;
		private baza_0DataSetTableAdapters.СпеціальностіTableAdapter спеціальностіTableAdapter;
		private System.Windows.Forms.BindingSource категоріїСпеціальностейBindingSource;
		private baza_0DataSetTableAdapters.Категорії_спеціальностейTableAdapter категорії_спеціальностейTableAdapter;
		private System.Windows.Forms.BindingSource категоріїСпкціальностейЛікаріBindingSource;
		private baza_0DataSetTableAdapters.ЛікаріTableAdapter лікаріTableAdapter;
		private System.Windows.Forms.BindingSource категоріїСпеціальностейBindingSource1;
	}
}