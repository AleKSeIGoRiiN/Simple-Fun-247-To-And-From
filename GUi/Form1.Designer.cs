﻿namespace GUi
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edStart = new System.Windows.Forms.NumericUpDown();
            this.edEnd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.edTime = new System.Windows.Forms.NumericUpDown();
            this.sul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите координату начала пути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите координату конца пути";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Решение";
            // 
            // edStart
            // 
            this.edStart.Location = new System.Drawing.Point(261, 101);
            this.edStart.Name = "edStart";
            this.edStart.Size = new System.Drawing.Size(120, 22);
            this.edStart.TabIndex = 4;
            // 
            // edEnd
            // 
            this.edEnd.Location = new System.Drawing.Point(261, 187);
            this.edEnd.Name = "edEnd";
            this.edEnd.Size = new System.Drawing.Size(120, 22);
            this.edEnd.TabIndex = 5;
            this.edEnd.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите время пути";
            // 
            // edTime
            // 
            this.edTime.Location = new System.Drawing.Point(261, 268);
            this.edTime.Name = "edTime";
            this.edTime.Size = new System.Drawing.Size(120, 22);
            this.edTime.TabIndex = 8;
            this.edTime.UseWaitCursor = true;
            // 
            // sul
            // 
            this.sul.AutoSize = true;
            this.sul.Location = new System.Drawing.Point(606, 213);
            this.sul.Name = "sul";
            this.sul.Size = new System.Drawing.Size(0, 16);
            this.sul.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sul);
            this.Controls.Add(this.edTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edEnd);
            this.Controls.Add(this.edStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edStart;
        private System.Windows.Forms.NumericUpDown edEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edTime;
        private System.Windows.Forms.Label sul;
    }
}
