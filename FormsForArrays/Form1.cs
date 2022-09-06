using System;
using System.Windows.Forms;
using static MyLib.LibClass;// Подключение пространства имен из библиотеки классов.

namespace FormsForArrays
{
    public partial class Form1 : Form
    {
        int n;// количество колонок таблицы
        // инициализация генератора случайных чисел
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)// событие загрузки формы
        {
            n = Convert.ToInt32(NumericUpDown.Value);// размер таблицы берём из поля с переключателем n = 1
            DataGridView1.RowCount = 1; 
            DataGridView1.ColumnCount = n;// устанавливаем количество колонок

            DataGridView1.ReadOnly = true;// Только чтение для строки с преобразованным массивом
            for (int i = 0; i < n; i++)
            {
                // строка заголовков столбцов
                DataGridView1.Columns[i].Name = Convert.ToString(i);
                DataGridView1.Rows[0].Cells[i].Value = Convert.ToString(Convert.ToDouble(rand.Next(-50, 51)) + Math.Round(rand.NextDouble(), 2));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string res = ""; //переменная для строки для вывода результата
            Array arr = getArrayFromData(DataGridView1.Rows[0]); //заполнение массива данными из компонента таблицы 

            if (RadioButton3.Checked) //выбор метода 1
            {
                //присваивание заголовка и результата вычислений результирующей строке
                res = "Количество отрицательных элементов массива равно= " + Convert.ToString(countNeg(arr)); 
            }
            else if (RadioButton4.Checked) //выбор метода 2 jghygjhgh


            {
                //присваивание заголовка и результата вычислений результирующей строке
                res = "Сумма модулей элементов массива, расположенных\nпосле минимального по модулю элемента= " + Convert.ToString(sumAbsAfterMinAbs(arr));
            }
            else if (RadioButton5.Checked) //выбор метода 3
            {
                Array resLst = sortSqrAndPos(arr); //создание массива с отсортированными элементами

                for (int i = 0; i < n; i++) //вывод отсортированного массива в компонент таблицы
                {
                    DataGridView1.RowCount = 2; DataGridView1.ColumnCount = n; // строка заголовков столбцов

                    DataGridView1.Columns[i].Name = Convert.ToString(i);
                    DataGridView1.Rows[1].Cells[i].Value = Convert.ToString(resLst.GetValue(i));
                }
                res = "Массив отсортирован: aaaaaaaaaa";
            }
            else //если пользователь не выбрал метод вычислений
            {
                res = "Выберите действие: ";
            }

            Label1.Text = res; //вывод результирующей строки в компонент интерфейса   
        }
        private Array getArrayFromData(DataGridViewRow Row)
        {
            Array arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr.SetValue(Convert.ToDouble(Row.Cells[i].Value), i);
            }
            return arr;
        }
    private void RadioButton1_CheckedChanged(object sender, EventArgs e)// Ввод вручную.
        {
            DataGridView1.ReadOnly = false; // ввод в таблицу разрешен

            for (int i = 0; i < n; i++)
            {
                // строка заголовков столбцов
                DataGridView1.Columns[i].Name = Convert.ToString(i);
                DataGridView1.Rows[0].Cells[i].Value = Convert.ToString(0);
            }
        }

    private void RadioButton2_CheckedChanged(object sender, EventArgs e) // Заполнение случайными значениями.
        {
            DataGridView1.ReadOnly = true; // ввод в таблицу разрешен

            for (int i = 0; i < n; i++)
            {
                // строка заголовков столбцов
                DataGridView1.Columns[i].Name = Convert.ToString(i);
                DataGridView1.Rows[0].Cells[i].Value = Convert.ToString(Convert.ToDouble(rand.Next(-50, 51)) + Math.Round(rand.NextDouble(), 2));
            }
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(NumericUpDown.Value);
            DataGridView1.RowCount = 1; DataGridView1.ColumnCount = n;

            if (RadioButton2.Checked == false)
            {
                for (int i = 0; i < n; i++)
                {
                    // строка заголовков столбцов
                    DataGridView1.Columns[i].Name = Convert.ToString(i);
                    DataGridView1.Rows[0].Cells[i].Value = Convert.ToString(0);
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    // строка заголовков столбцов
                    DataGridView1.Columns[i].Name = Convert.ToString(i);
                    DataGridView1.Rows[0].Cells[i].Value = Convert.ToString(Convert.ToDouble(rand.Next(-50, 51)) + Math.Round(rand.NextDouble(), 2));
                }
            }
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = DataGridView1.EditingControl.Text;

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) // цифры разрешены
                return;
            if (e.KeyChar == '-' && text.Length == 0) // минус разрешён
                return;
            if (e.KeyChar == '.') e.KeyChar = ','; // точку меняем на запятую
            if (e.KeyChar == ',')
            {
                if ((text.IndexOf(',') != -1) || (text.Length == 0))
                    e.KeyChar = '\0';//запятая только одна и не в начале строки
                return;
            }
            if (e.KeyChar == (char)Keys.Back) // при нажатии BackSpace
                return;
            if (e.KeyChar == (char)Keys.Tab) // при нажатии Tab
                return;
            e.KeyChar = '\0'; // остальные символы запрещены (игнорировать)
        }
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(DataGridView1_KeyPress);
        }
    }
}
