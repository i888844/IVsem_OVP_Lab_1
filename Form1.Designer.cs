namespace Lab._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstA = new System.Windows.Forms.TextBox();
            this.textBoxSecondA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSecondB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.labelInputComplexNumber = new System.Windows.Forms.Label();
            this.labelInputComplexNumberValue = new System.Windows.Forms.Label();
            this.labelOperationValue = new System.Windows.Forms.Label();
            this.labelResultValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Комплексное число 1: Z =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Комплексное число 2: Z =";
            // 
            // textBoxFirstA
            // 
            this.textBoxFirstA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstA.Location = new System.Drawing.Point(322, 45);
            this.textBoxFirstA.Name = "textBoxFirstA";
            this.textBoxFirstA.Size = new System.Drawing.Size(62, 35);
            this.textBoxFirstA.TabIndex = 2;
            this.textBoxFirstA.Text = "a";
            this.textBoxFirstA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFirstA.Click += new System.EventHandler(this.textBoxFirstA_Click);
            // 
            // textBoxSecondA
            // 
            this.textBoxSecondA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondA.Location = new System.Drawing.Point(322, 87);
            this.textBoxSecondA.Name = "textBoxSecondA";
            this.textBoxSecondA.Size = new System.Drawing.Size(62, 35);
            this.textBoxSecondA.TabIndex = 3;
            this.textBoxSecondA.Text = "a";
            this.textBoxSecondA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecondA.Click += new System.EventHandler(this.textBoxSecondA_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(293, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Сложение",
            "Вычитание",
            "Умножение",
            "Деление"});
            this.comboBox1.Location = new System.Drawing.Point(17, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 37);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Комплексное число Z = a + bi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(390, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "+";
            // 
            // textBoxFirstB
            // 
            this.textBoxFirstB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstB.Location = new System.Drawing.Point(420, 45);
            this.textBoxFirstB.Name = "textBoxFirstB";
            this.textBoxFirstB.Size = new System.Drawing.Size(62, 35);
            this.textBoxFirstB.TabIndex = 8;
            this.textBoxFirstB.Text = "b";
            this.textBoxFirstB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFirstB.Click += new System.EventHandler(this.textBoxFirstB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(491, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(390, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "+";
            // 
            // textBoxSecondB
            // 
            this.textBoxSecondB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondB.Location = new System.Drawing.Point(420, 86);
            this.textBoxSecondB.Name = "textBoxSecondB";
            this.textBoxSecondB.Size = new System.Drawing.Size(62, 35);
            this.textBoxSecondB.TabIndex = 11;
            this.textBoxSecondB.Text = "b";
            this.textBoxSecondB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecondB.Click += new System.EventHandler(this.textBoxSecondB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(491, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(727, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(495, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Получить комплексное число по индексу";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBox2.Location = new System.Drawing.Point(732, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(263, 37);
            this.comboBox2.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1001, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 706);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(138, 29);
            this.labelResult.TabIndex = 16;
            this.labelResult.Text = "Результат:";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperation.Location = new System.Drawing.Point(12, 677);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(138, 29);
            this.labelOperation.TabIndex = 17;
            this.labelOperation.Text = "Операция:";
            // 
            // labelInputComplexNumber
            // 
            this.labelInputComplexNumber.AutoSize = true;
            this.labelInputComplexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputComplexNumber.Location = new System.Drawing.Point(12, 648);
            this.labelInputComplexNumber.Name = "labelInputComplexNumber";
            this.labelInputComplexNumber.Size = new System.Drawing.Size(256, 29);
            this.labelInputComplexNumber.TabIndex = 18;
            this.labelInputComplexNumber.Text = "Комплексные числа:";
            // 
            // labelInputComplexNumberValue
            // 
            this.labelInputComplexNumberValue.AutoSize = true;
            this.labelInputComplexNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputComplexNumberValue.Location = new System.Drawing.Point(269, 648);
            this.labelInputComplexNumberValue.Name = "labelInputComplexNumberValue";
            this.labelInputComplexNumberValue.Size = new System.Drawing.Size(152, 29);
            this.labelInputComplexNumberValue.TabIndex = 20;
            this.labelInputComplexNumberValue.Text = "отсутствуют";
            // 
            // labelOperationValue
            // 
            this.labelOperationValue.AutoSize = true;
            this.labelOperationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperationValue.Location = new System.Drawing.Point(156, 677);
            this.labelOperationValue.Name = "labelOperationValue";
            this.labelOperationValue.Size = new System.Drawing.Size(148, 29);
            this.labelOperationValue.TabIndex = 22;
            this.labelOperationValue.Text = "отсутствует";
            // 
            // labelResultValue
            // 
            this.labelResultValue.AutoSize = true;
            this.labelResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultValue.Location = new System.Drawing.Point(156, 706);
            this.labelResultValue.Name = "labelResultValue";
            this.labelResultValue.Size = new System.Drawing.Size(148, 29);
            this.labelResultValue.TabIndex = 23;
            this.labelResultValue.Text = "отсутствует";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(674, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelResultValue);
            this.Controls.Add(this.labelOperationValue);
            this.Controls.Add(this.labelInputComplexNumberValue);
            this.Controls.Add(this.labelInputComplexNumber);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSecondB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFirstB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSecondA);
            this.Controls.Add(this.textBoxFirstA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ИС-22а Иванов В. Р. - лабораторная работа №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstA;
        private System.Windows.Forms.TextBox textBoxSecondA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSecondB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Label labelInputComplexNumber;
        private System.Windows.Forms.Label labelInputComplexNumberValue;
        private System.Windows.Forms.Label labelOperationValue;
        private System.Windows.Forms.Label labelResultValue;
        private System.Windows.Forms.Label label9;
    }
}

