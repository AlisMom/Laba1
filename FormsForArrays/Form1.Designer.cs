namespace FormsForArrays
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioButton5 = new System.Windows.Forms.RadioButton();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(998, 63);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(158, 71);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Вычислить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(250, 42);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(170, 105);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Ввод массива";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Checked = true;
            this.RadioButton2.Location = new System.Drawing.Point(9, 66);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(107, 24);
            this.RadioButton2.TabIndex = 0;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Случайно";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(10, 31);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(98, 24);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Вручную";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.RadioButton5);
            this.GroupBox2.Controls.Add(this.RadioButton4);
            this.GroupBox2.Controls.Add(this.RadioButton3);
            this.GroupBox2.Location = new System.Drawing.Point(434, 42);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(489, 146);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Действия";
            // 
            // RadioButton5
            // 
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.Location = new System.Drawing.Point(10, 102);
            this.RadioButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.Size = new System.Drawing.Size(458, 24);
            this.RadioButton5.TabIndex = 2;
            this.RadioButton5.TabStop = true;
            this.RadioButton5.Text = "Сортировка положительных квадратов отрицательных";
            this.RadioButton5.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Location = new System.Drawing.Point(10, 66);
            this.RadioButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(403, 24);
            this.RadioButton4.TabIndex = 1;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "Сумма модулей после минимального по модулю";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Checked = true;
            this.RadioButton3.Location = new System.Drawing.Point(10, 31);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(402, 24);
            this.RadioButton3.TabIndex = 0;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Количество отрицательных элементов массива";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.Location = new System.Drawing.Point(54, 72);
            this.NumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(180, 26);
            this.NumericUpDown.TabIndex = 3;
            this.NumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(440, 324);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(322, 20);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Выберете действие и нажмите на кнопку";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeight = 34;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(54, 213);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.Size = new System.Drawing.Size(1144, 84);
            this.DataGridView1.TabIndex = 5;
            this.DataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGridView1_EditingControlShowing);
            this.DataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGridView1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1251, 405);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.NumericUpDown);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Работа с одномерными массивами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton RadioButton5;
        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView DataGridView1;
    }
}

