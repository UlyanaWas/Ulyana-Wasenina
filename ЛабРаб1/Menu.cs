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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_task1_Click(object sender, EventArgs e)
        {
            Frm_Task1 newForm = new Frm_Task1();
            newForm.Show();
        }

        private void Btn_task2_Click(object sender, EventArgs e)
        {
            Frm_Task2 newForm = new Frm_Task2();
            newForm.Show();
        }

        private void Btn_task3_Click(object sender, EventArgs e)
        {
            Frm_Task3 newForm = new Frm_Task3();
            newForm.Show();
        }

        private void Btn_task4_Click(object sender, EventArgs e)
        {
            Frm_Task4 newForm = new Frm_Task4();
            newForm.Show();
        }

        private void Btn_task5_Click(object sender, EventArgs e)
        {
            Frm_Task5 newForm = new Frm_Task5();
            newForm.Show();
        }
    }
}
