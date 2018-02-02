using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛабРаб1
{
    public partial class Frm_Task4 : Form
    {
        int i, j, n, m;
        double sum;

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Close();
        }

        public Frm_Task4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(textBox1.Text); //количество строк
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m = Convert.ToInt32(textBox2.Text); //количество столбцов            
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                textBox2.Clear();
            }
}

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Start.Enabled = false;
            Random rand = new Random();
            double[,] a = new double[n, m];
            Dgrv1.Rows.Clear();
            Dgrv1.RowCount = n;
            Dgrv1.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(-10, 10);
                    Dgrv1.Columns[j].Width = 35;
                    Dgrv1.Rows[i].Cells[j].Value = (a[i, j]).ToString();
                }
            }
            n = n + 1;
            double[,] b = new double[n, m];
            Dgrv2.Rows.Clear();
            Dgrv2.RowCount = n;
            Dgrv2.ColumnCount = m;
           
            for (j = 0; j < m; j++)
            {
                sum = 0;
                for (i = 0; i < n; i++)
                {
                    if (i != n - 1)
                    {
                        b[i, j] = a[i, j];
                        sum = sum + b[i, j];
                    }
                    else
                    {
                        b[i, j] = sum;
                    }
                    Dgrv2.Columns[j].Width = 35;
                    Dgrv2.Rows[i].Cells[j].Value = (b[i, j]).ToString();
                }
            }


        }
    }
}

            