﻿namespace WindowsFormsGit
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
            this.kunderenko_KN31_5 = new System.Windows.Forms.Button();
            this.KN_11INT_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kunderenko_KN31_5
            // 
            this.kunderenko_KN31_5.Location = new System.Drawing.Point(441, 116);
            this.kunderenko_KN31_5.Name = "kunderenko_KN31_5";
            this.kunderenko_KN31_5.Size = new System.Drawing.Size(212, 63);
            this.kunderenko_KN31_5.TabIndex = 1;
            this.kunderenko_KN31_5.Text = "Кундеренко";
            this.kunderenko_KN31_5.UseVisualStyleBackColor = true;
            this.kunderenko_KN31_5.Click += new System.EventHandler(this.kunderenko_KN31_5_Click);
            // 
            // KN_11INT_3
            // 
            this.KN_11INT_3.Location = new System.Drawing.Point(441, 205);
            this.KN_11INT_3.Name = "KN_11INT_3";
            this.KN_11INT_3.Size = new System.Drawing.Size(212, 63);
            this.KN_11INT_3.TabIndex = 2;
            this.KN_11INT_3.Text = "Нечипорук";
            this.KN_11INT_3.UseVisualStyleBackColor = true;
            this.KN_11INT_3.Click += new System.EventHandler(this.KN_11INT_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.KN_11INT_3);
            this.Controls.Add(this.kunderenko_KN31_5);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kunderenko_KN31_5;
        private System.Windows.Forms.Button KN_11INT_3;
    }
}

