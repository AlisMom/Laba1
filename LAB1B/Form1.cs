using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0;
            Random a = new Random();

            if (radioButton1.Checked)
            {
                    try
                    {
                        x = Convert.ToDouble(textBox1.Text);
                    }
                    catch
                    {
                    MessageBox.Show("Неверные формат числа       ");
                    textBox1.Clear();
                    textBox1.Focus();
                    }
                }

            if (radioButton2.Checked)
            {
                x = a.Next(4, 1000);
                label2.Text = "x = " + x.ToString("F3");
             }

            if ((x > -3) && (x <= 3))   //ОДЗ
            {
                MessageBox.Show("Число x должно принадлежать диапазону (-беск;-3]и(3;+беск)");
            }

            // первый результат
            double z1 = (Math.Pow(x, 2) + (2 * x) - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / (Math.Pow(x, 2) - (2 * x) - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
                // второй результат
                double z2 = Math.Sqrt(x + 3) / Math.Sqrt(x - 3);
                // вывод ответа
                label2.Text = "x = " + x.ToString("F3") + "\nz1 = " + z1.ToString("F3") + "\nz2 = " + z2.ToString("F3");
            
        }
        // смена цвета фона надписи при наведении мыши на метку
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        // возвращение цвета фона метки после при покидания метки мышью
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //блокировка кнопки на случай, если поля пустые или содержат лишь '-' и/или ','
                if (textBox1.Text == "" || textBox1.Text == "-" || textBox1.Text == ","
                    || textBox1.Text == "-," || textBox1.Text == " ")
                    button1.Enabled = false;
                else button1.Enabled = true;
            }
        }

        // разрешение на ввод минуса (в начале числа), цифр 0-9, запятой и кнопки Backspace
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // запрет на ввод символов перед минусом
            if ((sender as TextBox).Text.IndexOf('-') != -1 && (sender as
                TextBox).SelectionStart == 0)
            { e.KeyChar = '\0'; return; }

            //разрешение ввода цифр
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;

            //разрешение ввода запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') == -1) return;

            //разрешение кнопки Backspace
            if (e.KeyChar == (char)Keys.Back) return;

            //разрешение ввода минуса в начале числа
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') == -1 &&
                (sender as TextBox).SelectionStart == 0) return;

            //запрет вввода других символов
            e.KeyChar = '\0';

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            button1.Enabled = true;
            textBox1.Focus();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Если в поле texBox1 нет данных, сделать кнопку button1 недоступной
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = true;
        }
    }

}
