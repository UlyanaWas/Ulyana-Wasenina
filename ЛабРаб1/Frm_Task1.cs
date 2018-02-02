using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ЛабРаб1
{
    public partial class Frm_Task1 : Form
    {
        double x, c, d;
        int m, n, i, j;
        
        
        private void Menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Close();
        }

        public Frm_Task1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(TextBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                TextBox1.Clear();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            m = Convert.ToInt32(TextBox2.Text);
            n = m; 
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            int k = 0;
            //Btn_Start.Enabled = false;
            Random rand = new Random();//создание рандома
            double[] a = new double[m]; //создание массива a[i]
            double[] b = new double[n];
            for (i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-100, 100); //задание массива а
                for (j = k; j == i; j++)
                {
                    b[j] = a[i];
                }
                k++;
            }
            Dgrv1.Rows.Clear();
            Dgrv1.RowCount = 1;
            Dgrv1.ColumnCount = a.Length;
            Dgrv2.Rows.Clear();
            Dgrv2.RowCount = 1;
            Dgrv2.ColumnCount = b.Length;
            k = 0;
            StreamWriter fs = new StreamWriter("input1.txt");
            for (i = 0; i < a.Length; i++)
            {
                Dgrv1.Columns[i].Name = (i + 1).ToString();
                Dgrv1.Columns[i].Width = 35;
                Dgrv1.Rows[0].Cells[i].Value = (a[i]).ToString();
                fs.WriteLine(a[i]);
                for (j = k; j == i; j++)
                {
                    Dgrv2.Columns[j].Name = (j + 1).ToString();
                    Dgrv2.Columns[j].Width = 35;
                    Dgrv2.Rows[0].Cells[j].Value = (b[j]).ToString();
                }
                k++;
            } //вывод массивов

            fs.Close();
            Array.Reverse(b);
            c = 200;
            for (j=0; c==200&&j<n; j++)
            {
                if ((Math.Abs(b[j]) <= x) && (b[j]<=0))
                {
                    c = Math.Abs(b[j]);
                    d = b[1];
                    b[j] = d;
                    b[1] = c;
                }
            }
            Array.Reverse(b);

            for (j=0; j<b.Length;j++)
            {
                Dgrv2.Columns[j].Name = (j + 1).ToString();
                Dgrv2.Columns[j].Width = 35;
                Dgrv2.Rows[0].Cells[j].Value = (b[j]).ToString();
            }
           
        }
    }
}
