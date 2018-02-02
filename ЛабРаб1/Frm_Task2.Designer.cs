using System.Windows.Forms;

namespace ЛабРаб1
{
    partial class Frm_Task2
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Lbl_Max);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Dgrv1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(221, 211);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 21);
            this.label.TabIndex = 8;
            this.label.Text = "max";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Start.Enabled = false;
            this.Btn_Start.Location = new System.Drawing.Point(225, 64);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(99, 30);
            this.Btn_Start.TabIndex = 7;
            this.Btn_Start.Text = "Старт";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Dgrv2
            // 
            this.Dgrv2.AllowUserToAddRows = false;
            this.Dgrv2.AllowUserToDeleteRows = false;
            this.Dgrv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrv2.Location = new System.Drawing.Point(6, 293);
            this.Dgrv2.Name = "Dgrv2";
            this.Dgrv2.ReadOnly = true;
            this.Dgrv2.Size = new System.Drawing.Size(559, 76);
            this.Dgrv2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Новый массив:";
            // 
            // Lbl_Max
            // 
            this.Lbl_Max.AutoSize = true;
            this.Lbl_Max.Location = new System.Drawing.Point(230, 185);
            this.Lbl_Max.Name = "Lbl_Max";
            this.Lbl_Max.Size = new System.Drawing.Size(0, 21);
            this.Lbl_Max.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Максимальный элемент =";
            // 
            // Dgrv1
            // 
            this.Dgrv1.AllowUserToAddRows = false;
            this.Dgrv1.AllowUserToDeleteRows = false;
            this.Dgrv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgrv1.Location = new System.Drawing.Point(6, 115);
            this.Dgrv1.Name = "Dgrv1";
            this.Dgrv1.ReadOnly = true;
            this.Dgrv1.Size = new System.Drawing.Size(559, 80);
            this.Dgrv1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите длину массива";
            // 
            // Menu
            // 
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Location = new System.Drawing.Point(30, 459);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(168, 35);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Вернуться в меню";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Frm_Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 506);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Task2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgrv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgrv1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.DataGridView Dgrv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Menu;
        private Label Lbl_Max;
        private Label label;
    }
}