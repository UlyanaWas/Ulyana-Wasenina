namespace ЛабРаб1
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_task1 = new System.Windows.Forms.Button();
            this.Btn_task2 = new System.Windows.Forms.Button();
            this.Btn_task3 = new System.Windows.Forms.Button();
            this.Btn_task4 = new System.Windows.Forms.Button();
            this.Btn_task5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(287, 126);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №1\r\nВыполнила студентка гр. ПИпб-23\r\nВасенина Ульяна\r\nВариант" +
    " - 25\r\n\r\nВыберите задание:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_task1
            // 
            this.Btn_task1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_task1.Location = new System.Drawing.Point(44, 166);
            this.Btn_task1.Name = "Btn_task1";
            this.Btn_task1.Size = new System.Drawing.Size(283, 48);
            this.Btn_task1.TabIndex = 1;
            this.Btn_task1.Text = "Задание 1";
            this.Btn_task1.UseVisualStyleBackColor = true;
            this.Btn_task1.Click += new System.EventHandler(this.Btn_task1_Click);
            // 
            // Btn_task2
            // 
            this.Btn_task2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_task2.Location = new System.Drawing.Point(44, 220);
            this.Btn_task2.Name = "Btn_task2";
            this.Btn_task2.Size = new System.Drawing.Size(283, 48);
            this.Btn_task2.TabIndex = 1;
            this.Btn_task2.Text = "Задание 2";
            this.Btn_task2.UseVisualStyleBackColor = true;
            this.Btn_task2.Click += new System.EventHandler(this.Btn_task2_Click);
            // 
            // Btn_task3
            // 
            this.Btn_task3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_task3.Location = new System.Drawing.Point(44, 274);
            this.Btn_task3.Name = "Btn_task3";
            this.Btn_task3.Size = new System.Drawing.Size(283, 48);
            this.Btn_task3.TabIndex = 1;
            this.Btn_task3.Text = "Задание 3";
            this.Btn_task3.UseVisualStyleBackColor = true;
            this.Btn_task3.Click += new System.EventHandler(this.Btn_task3_Click);
            // 
            // Btn_task4
            // 
            this.Btn_task4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_task4.Location = new System.Drawing.Point(44, 328);
            this.Btn_task4.Name = "Btn_task4";
            this.Btn_task4.Size = new System.Drawing.Size(283, 48);
            this.Btn_task4.TabIndex = 1;
            this.Btn_task4.Text = "Задание 4";
            this.Btn_task4.UseVisualStyleBackColor = true;
            this.Btn_task4.Click += new System.EventHandler(this.Btn_task4_Click);
            // 
            // Btn_task5
            // 
            this.Btn_task5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_task5.Location = new System.Drawing.Point(44, 382);
            this.Btn_task5.Name = "Btn_task5";
            this.Btn_task5.Size = new System.Drawing.Size(283, 48);
            this.Btn_task5.TabIndex = 1;
            this.Btn_task5.Text = "Задание 5";
            this.Btn_task5.UseVisualStyleBackColor = true;
            this.Btn_task5.Click += new System.EventHandler(this.Btn_task5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(360, 445);
            this.Controls.Add(this.Btn_task5);
            this.Controls.Add(this.Btn_task4);
            this.Controls.Add(this.Btn_task3);
            this.Controls.Add(this.Btn_task2);
            this.Controls.Add(this.Btn_task1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_task1;
        private System.Windows.Forms.Button Btn_task2;
        private System.Windows.Forms.Button Btn_task3;
        private System.Windows.Forms.Button Btn_task4;
        private System.Windows.Forms.Button Btn_task5;
    }
}

