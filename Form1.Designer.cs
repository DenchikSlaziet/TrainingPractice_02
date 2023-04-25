namespace TrainingPractice_02
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton210 = new System.Windows.Forms.RadioButton();
            this.radioButton82 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton110 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTrue = new System.Windows.Forms.Label();
            this.labelFalse = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton116 = new System.Windows.Forms.RadioButton();
            this.radioButton216 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton216);
            this.panel2.Controls.Add(this.radioButton22);
            this.panel2.Controls.Add(this.radioButton210);
            this.panel2.Controls.Add(this.radioButton82);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(426, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 187);
            this.panel2.TabIndex = 1;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(18, 61);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(40, 28);
            this.radioButton22.TabIndex = 5;
            this.radioButton22.TabStop = true;
            this.radioButton22.Text = "2";
            this.radioButton22.UseVisualStyleBackColor = true;
            this.radioButton22.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton22.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton210
            // 
            this.radioButton210.AutoSize = true;
            this.radioButton210.Location = new System.Drawing.Point(18, 27);
            this.radioButton210.Name = "radioButton210";
            this.radioButton210.Size = new System.Drawing.Size(52, 28);
            this.radioButton210.TabIndex = 3;
            this.radioButton210.TabStop = true;
            this.radioButton210.Text = "10";
            this.radioButton210.UseVisualStyleBackColor = true;
            this.radioButton210.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton210.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // radioButton82
            // 
            this.radioButton82.AutoSize = true;
            this.radioButton82.Location = new System.Drawing.Point(18, 95);
            this.radioButton82.Name = "radioButton82";
            this.radioButton82.Size = new System.Drawing.Size(40, 28);
            this.radioButton82.TabIndex = 4;
            this.radioButton82.TabStop = true;
            this.radioButton82.Text = "8";
            this.radioButton82.UseVisualStyleBackColor = true;
            this.radioButton82.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton82.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(426, 43);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 33);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(831, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(13, 95);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(40, 28);
            this.radioButton18.TabIndex = 2;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "8";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton18.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton110
            // 
            this.radioButton110.AutoSize = true;
            this.radioButton110.Location = new System.Drawing.Point(13, 61);
            this.radioButton110.Name = "radioButton110";
            this.radioButton110.Size = new System.Drawing.Size(52, 28);
            this.radioButton110.TabIndex = 1;
            this.radioButton110.TabStop = true;
            this.radioButton110.Text = "10";
            this.radioButton110.UseVisualStyleBackColor = true;
            this.radioButton110.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton110.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(13, 27);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(40, 28);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "2";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton12.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton116);
            this.panel1.Controls.Add(this.radioButton12);
            this.panel1.Controls.Add(this.radioButton18);
            this.panel1.Controls.Add(this.radioButton110);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 187);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(855, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Правильно:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(828, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Неправильно:";
            // 
            // labelTrue
            // 
            this.labelTrue.AutoSize = true;
            this.labelTrue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrue.Location = new System.Drawing.Point(985, 172);
            this.labelTrue.Name = "labelTrue";
            this.labelTrue.Size = new System.Drawing.Size(22, 24);
            this.labelTrue.TabIndex = 8;
            this.labelTrue.Text = "0";
            // 
            // labelFalse
            // 
            this.labelFalse.AutoSize = true;
            this.labelFalse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFalse.Location = new System.Drawing.Point(985, 225);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(22, 24);
            this.labelFalse.TabIndex = 9;
            this.labelFalse.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(831, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Узнать ответ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton116
            // 
            this.radioButton116.AutoSize = true;
            this.radioButton116.Location = new System.Drawing.Point(13, 129);
            this.radioButton116.Name = "radioButton116";
            this.radioButton116.Size = new System.Drawing.Size(52, 28);
            this.radioButton116.TabIndex = 3;
            this.radioButton116.TabStop = true;
            this.radioButton116.Text = "16";
            this.radioButton116.UseVisualStyleBackColor = true;
            this.radioButton116.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton116.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton216
            // 
            this.radioButton216.AutoSize = true;
            this.radioButton216.Location = new System.Drawing.Point(18, 129);
            this.radioButton216.Name = "radioButton216";
            this.radioButton216.Size = new System.Drawing.Size(52, 28);
            this.radioButton216.TabIndex = 4;
            this.radioButton216.TabStop = true;
            this.radioButton216.Text = "16";
            this.radioButton216.UseVisualStyleBackColor = true;
            this.radioButton216.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton216.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите число для перевода";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(421, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Введите ваш ответ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 297);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelFalse);
            this.Controls.Add(this.labelTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1127, 336);
            this.MinimumSize = new System.Drawing.Size(1127, 336);
            this.Name = "Form1";
            this.Text = " Главная";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton210;
        private System.Windows.Forms.RadioButton radioButton82;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton110;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTrue;
        private System.Windows.Forms.Label labelFalse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton116;
        private System.Windows.Forms.RadioButton radioButton216;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

