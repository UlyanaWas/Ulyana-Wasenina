namespace ЛабРаб1
{
    partial class Frm_Task5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Task5));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dgrv1 = new System.Windows.Forms.DataGridView();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти количество отрицательных элементов двумерного массива.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Count);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Dgrv1);
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.Controls.Add(this.TxtBox2);
            this.groupBox1.Controls.Add(this.TxtBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(353, 347);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(19, 21);
            this.Count.TabIndex = 7;
            this.Count.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество отрицательных элементов =";
            // 
            // Dgrv1
            // 
            this.Dgrv1.AllowUserToAddRows = false;
            this.Dgrv1.AllowUserToDeleteRows = false;
            this.Dgrv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrv1.Location = new System.Drawing.Point(15, 169);
            this.Dgrv1.Name = "Dgrv1";
            this.Dgrv1.ReadOnly = true;
            this.Dgrv1.Size = new System.Drawing.Size(423, 171);
            this.Dgrv1.TabIndex = 5;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Location = new System.Drawing.Point(154, 109);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(112, 38);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "Старт!";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(272, 62);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(100, 29);
            this.TxtBox2.TabIndex = 3;
            this.TxtBox2.TextChanged += new System.EventHandler(this.TxtBox2_TextChanged);
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(239, 21);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(100, 29);
            this.TxtBox1.TabIndex = 2;
            this.TxtBox1.TextChanged += new System.EventHandler(this.TxtBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите количество столбцов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите количество строк:";
            // 
            // Menu
            // 
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Location = new System.Drawing.Point(28, 468);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(177, 29);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Вернуться в меню";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Frm_Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 509);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Task5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 5";
            this.Load += new System.EventHandler(this.Frm_Task5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrv1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Menu;
    }
}