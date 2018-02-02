namespace ЛабРаб1
{
    partial class Frm_Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Task1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgrv1 = new System.Windows.Forms.DataGridView();
            this.TextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Dgrv2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти последний отрицательный элемент одномерного массива, модуль которого не пре" +
    "вышает заданной величины, заменить его модулем и поставить его перед последним э" +
    "лементом массива.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(132, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите величину x=";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(318, 34);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 29);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Location = new System.Drawing.Point(222, 118);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(112, 31);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Старт!";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(114, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите длину массива";
            // 
            // Dgrv1
            // 
            this.Dgrv1.AllowUserToAddRows = false;
            this.Dgrv1.AllowUserToDeleteRows = false;
            this.Dgrv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrv1.Location = new System.Drawing.Point(0, 166);
            this.Dgrv1.Name = "Dgrv1";
            this.Dgrv1.ReadOnly = true;
            this.Dgrv1.Size = new System.Drawing.Size(568, 71);
            this.Dgrv1.TabIndex = 4;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(318, 73);
            this.TextBox2.Mask = "00";
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 29);
            this.TextBox2.TabIndex = 1;
            this.TextBox2.ValidatingType = typeof(int);
            this.TextBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Dgrv2
            // 
            this.Dgrv2.AllowUserToAddRows = false;
            this.Dgrv2.AllowUserToDeleteRows = false;
            this.Dgrv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrv2.Location = new System.Drawing.Point(0, 296);
            this.Dgrv2.Name = "Dgrv2";
            this.Dgrv2.ReadOnly = true;
            this.Dgrv2.Size = new System.Drawing.Size(568, 68);
            this.Dgrv2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Новый массив:";
            // 
            // Menu
            // 
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Location = new System.Drawing.Point(12, 512);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(171, 30);
            this.Menu.TabIndex = 9;
            this.Menu.Text = "Вернуться в меню";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.Dgrv2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(this.Dgrv1);
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 370);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Frm_Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Task1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgrv1;
        private System.Windows.Forms.MaskedTextBox TextBox2;
        private System.Windows.Forms.DataGridView Dgrv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}