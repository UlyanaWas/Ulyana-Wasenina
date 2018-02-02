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
    public partial class Frm_Task3 : Form
    {
        int i, j, m, n;
        int k = 1;
        public Frm_Task3()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(textBox1.Text);
                m = n;
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                textBox1.Clear();
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Start.Enabled = false;
            double[,] a = new double[n, m]; //создание массива a[i,j]

            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (j = 0; j < m; j++)
                    {
                        a[i, j] = k;
                        k++;
                    }
                }
                else
                {
                    for (j = m - 1; j >= 0; j--)
                    {
                        a[i, j] = k;
                        k++;
                    }
                }
            }

            Dgrv1.Rows.Clear();
            Dgrv1.RowCount = n;
            Dgrv1.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                {
                    for (j = 0; j < m; j++)
                    {
                        Dgrv1.Columns[j].Width = 35;
                        Dgrv1.Rows[i].Cells[j].Value = (a[j, i]).ToString();
                    }
                }
            }
        }
    }
}
