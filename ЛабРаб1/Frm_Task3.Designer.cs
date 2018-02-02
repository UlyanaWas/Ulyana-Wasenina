namespace ЛабРаб1
{
    partial class Frm_Task3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Task3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Dgrv1 = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Получить квадратную матрицу порядка n, элементы которой являются числа 1, 2, 3, …" +
    " n*n, расположенные в ней по определённой схеме.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(108, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите число n: n=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Location = new System.Drawing.Point(188, 138);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(122, 35);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Старт!";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Dgrv1
            // 
            this.Dgrv1.AllowUserToAddRows = false;
            this.Dgrv1.AllowUserToDeleteRows = false;
            this.Dgrv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrv1.Location = new System.Drawing.Point(16, 201);
            this.Dgrv1.Name = "Dgrv1";
            this.Dgrv1.ReadOnly = true;
            this.Dgrv1.Size = new System.Drawing.Size(471, 254);
            this.Dgrv1.TabIndex = 4;
            // 
            // Menu
            // 
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Location = new System.Drawing.Point(16, 461);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(177, 36);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Вернуться в меню";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Frm_Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 509);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Dgrv1);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Task3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 3";
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.DataGridView Dgrv1;
        private System.Windows.Forms.Button Menu;
    }
}