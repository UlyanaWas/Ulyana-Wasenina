using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛабРаб1
{
    public partial class Frm_Task2 : Form
    {
        int i, j, m, n;
        double max = -200;
        public Frm_Task2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m = Convert.ToInt32(textBox1.Text);
                n = m;
                Btn_Start.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                textBox1.Clear();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Close();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Start.Enabled = false;
            StreamWriter fs = new StreamWriter("input2.txt");
            Random rand = new Random();//создание рандома
            double[] a = new double[m]; //создание массива a[i]
            for (i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-100, 100); //задание массива а
                fs.WriteLine(a[i]);
                if (a[i] > max)
                {
                    max = a[i];
                    j = i;

                }

            }

            label.Text = Convert.ToString(max);
                  
            Dgrv1.Rows.Clear();
            Dgrv1.RowCount = 1;
            Dgrv1.ColumnCount = a.Length;
            for (i = 0; i < a.Length; i++)
            {
                Dgrv1.Columns[i].Name = (i + 1).ToString();
                Dgrv1.Columns[i].Width = 35;
                Dgrv1.Rows[0].Cells[i].Value = (a[i]).ToString();
            }
            for (i = j; i < a.Length - 1; i++)
                a[i] = a[i + 1];
            Array.Resize(ref a, a.Length - 1);
            Dgrv2.Rows.Clear();
            Dgrv2.RowCount = 1;
            Dgrv2.ColumnCount = a.Length;
            for (i = 0; i < a.Length; i++)
            {
                Dgrv2.Columns[i].Name = (i + 1).ToString();
                Dgrv2.Columns[i].Width = 35;
                Dgrv2.Rows[0].Cells[i].Value = (a[i]).ToString();
            }
            fs.Close();

        }
    }
}
