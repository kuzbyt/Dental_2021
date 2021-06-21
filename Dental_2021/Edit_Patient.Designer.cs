namespace Dental_2021
{
	partial class Edit_Patient
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
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.baza_0DataSet = new Dental_2021.baza_0DataSet();
			this.категоріїПацієнтівBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.категорії_пацієнтівTableAdapter = new Dental_2021.baza_0DataSetTableAdapters.Категорії_пацієнтівTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїПацієнтівBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(446, 79);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(184, 22);
			this.textBox5.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(384, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 41;
			this.label6.Text = "Адреса";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(446, 34);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(74, 22);
			this.textBox4.TabIndex = 40;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(330, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 16);
			this.label5.TabIndex = 39;
			this.label5.Text = "Рік народження";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.категоріїПацієнтівBindingSource;
			this.comboBox1.DisplayMember = "Назва";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(446, 140);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 38;
			this.comboBox1.ValueMember = "Код категорії";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(308, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "Категорія пацієнта";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(105, 138);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 22);
			this.textBox3.TabIndex = 36;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(361, 214);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 39);
			this.button2.TabIndex = 35;
			this.button2.Text = "Вихід";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(174, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 39);
			this.button1.TabIndex = 34;
			this.button1.Text = "Зберегти";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(105, 88);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 22);
			this.textBox2.TabIndex = 33;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(105, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 22);
			this.textBox1.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(29, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "Прізвище";
			// 
			// baza_0DataSet
			// 
			this.baza_0DataSet.DataSetName = "baza_0DataSet";
			this.baza_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(573, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 43;
			this.label2.Text = "label2";
			// 
			// Edit_Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 287);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Edit_Patient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редагування пацієнта";
			this.Load += new System.EventHandler(this.Edit_Patient_Load);
			((System.ComponentModel.ISupportInitialize)(this.baza_0DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.категоріїПацієнтівBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private baza_0DataSet baza_0DataSet;
		private System.Windows.Forms.BindingSource категоріїПацієнтівBindingSource;
		private baza_0DataSetTableAdapters.Категорії_пацієнтівTableAdapter категорії_пацієнтівTableAdapter;
		public System.Windows.Forms.Label label2;
	}
}