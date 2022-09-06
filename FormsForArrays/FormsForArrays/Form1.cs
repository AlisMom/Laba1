using System;
using System.Windows.Forms;

namespace FormsForArrays
{
    public partial class Form1 : Form
    {
        int n;// количество колонок таблицы
        // инициализация генератора случайных чисел
        Random rand = new Random();

        //подсчет количества отрицательных элементов массива
        private double countNeg(Array arr)
        {
            int res = 0;
            foreach(double i in arr)
            {
                if (i < 0)
                {
                    res++;
                }
            }
            return res;
        }
        //Вычисления суммы модулей элементов массива,
        //расположенных после последнего минимального по модулю элемента.
        private double sumAbsAfterMinAbs(Array arr)
        {
            double min = Convert.ToDouble(arr.GetValue(0));
            double sum = 0;
            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                double nowElement = Math.Abs(Convert.ToDouble(arr.GetValue(i)));
                if (nowElement <= min)
                {
                    min = nowElement;
                    minIndex = i;
                }
            }

            for (int i = minIndex + 1; i < arr.Length; i++)
            {
                sum = sum + Math.Abs(Convert.ToDouble(arr.GetValue(i)));
            }
            return sum;
        }
        //Замена всех отрицательных элементов массива
        //их квадратами и упорядочивание элементов массива по возрастанию.
        private Array sortSqrAndPos(Array arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                double nowElement = Convert.ToDouble(arr.GetValue(i));
                if (nowElement < 0)
                {
                    arr.SetValue(nowElement*nowElement, i);
                }
            }
            Array.Sort(arr);

            return arr;
        }
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
            string res = "";
            Array arr = getArrayFromData(DataGridView1.Rows[0]);         

            if (RadioButton3.Checked)
            {
                res = "Количество отрицательных элементов массива равно= " + Convert.ToString(countNeg(arr));
            }
            else if (RadioButton4.Checked)
            {
                res = "Сумма модулей элементов массива, расположенных\nпосле минимального по модулю элемента= " + Convert.ToString(sumAbsAfterMinAbs(arr));
            }
            else if (RadioButton5.Checked)
            {
                Array resLst = sortSqrAndPos(arr);
                for (int i = 0; i < n; i++)
                {
                    DataGridView1.RowCount = 2; DataGridView1.ColumnCount = n;
                    // строка заголовков столбцов
                    DataGridView1.Columns[i].Name = Convert.ToString(i);
                    DataGridView1.Rows[1].Cells[i].Value = Convert.ToString(resLst.GetValue(i));
                }
                res = "Массив отсортирован: ";
            }
            else
            {
                res = "Выберете действие: ";
            }

            Label1.Text = res;
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
    }
}
