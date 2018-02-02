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
    public partial class Frm_Task5 : Form
    {
        int n, m, i, j;
        int c = 0;
        public Frm_Task5()
        {
            InitializeComponent();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu.Show();
            Close();
        }

        private void Frm_Task5_Load(object sender, EventArgs e)
        {

        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(TxtBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                TxtBox1.Clear();
            }
        }

        private void TxtBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m = Convert.ToInt32(TxtBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка! Введите корректное значение!");
                TxtBox2.Clear();
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
                    a[i, j] = rand.Next(-100, 100);
                    Dgrv1.Columns[j].Width = 35;
                    Dgrv1.Rows[i].Cells[j].Value = (a[i, j]).ToString();
                    if (a[i, j] < 0) c++;
                }
            }
            Count.Text = c.ToString();
        }
    }
}
