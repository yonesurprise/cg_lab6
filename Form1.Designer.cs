﻿namespace Comp_Graph6
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createCubeButton = new System.Windows.Forms.Button();
            this.createTetrButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.createOktaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.projBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.rotateOX = new System.Windows.Forms.RadioButton();
            this.rotateOY = new System.Windows.Forms.RadioButton();
            this.rotateOZ = new System.Windows.Forms.RadioButton();
            this.rotateAngle = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rotateBtn = new System.Windows.Forms.Button();
            this.rZ1 = new System.Windows.Forms.TextBox();
            this.rY1 = new System.Windows.Forms.TextBox();
            this.rX1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rZ2 = new System.Windows.Forms.TextBox();
            this.rY2 = new System.Windows.Forms.TextBox();
            this.rX2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rotateOwn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // createCubeButton
            // 
            this.createCubeButton.Location = new System.Drawing.Point(622, 49);
            this.createCubeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createCubeButton.Name = "createCubeButton";
            this.createCubeButton.Size = new System.Drawing.Size(156, 37);
            this.createCubeButton.TabIndex = 1;
            this.createCubeButton.Text = "Куб";
            this.createCubeButton.UseVisualStyleBackColor = true;
            this.createCubeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTetrButton
            // 
            this.createTetrButton.Location = new System.Drawing.Point(622, 7);
            this.createTetrButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createTetrButton.Name = "createTetrButton";
            this.createTetrButton.Size = new System.Drawing.Size(157, 37);
            this.createTetrButton.TabIndex = 2;
            this.createTetrButton.Text = "Тетраэдр";
            this.createTetrButton.UseVisualStyleBackColor = true;
            this.createTetrButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 518);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // createOktaButton
            // 
            this.createOktaButton.Location = new System.Drawing.Point(620, 89);
            this.createOktaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createOktaButton.Name = "createOktaButton";
            this.createOktaButton.Size = new System.Drawing.Size(156, 37);
            this.createOktaButton.TabIndex = 4;
            this.createOktaButton.Text = "Октаэдр";
            this.createOktaButton.UseVisualStyleBackColor = true;
            this.createOktaButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(635, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(686, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(744, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(619, 305);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(669, 305);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(724, 305);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 484);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Относительно центра (%)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(620, 500);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "100";
            // 
            // projBox
            // 
            this.projBox.FormattingEnabled = true;
            this.projBox.Items.AddRange(new object[] {
            "Перспективная",
            "Изометрическая"});
            this.projBox.Location = new System.Drawing.Point(620, 150);
            this.projBox.Name = "projBox";
            this.projBox.Size = new System.Drawing.Size(154, 21);
            this.projBox.TabIndex = 21;
            this.projBox.SelectedIndexChanged += new System.EventHandler(this.projBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Проекция";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(622, 182);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 22);
            this.button5.TabIndex = 25;
            this.button5.Text = "Смещение по оси";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(622, 221);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 22);
            this.button6.TabIndex = 26;
            this.button6.Text = "Масштаб (%)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(622, 256);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 22);
            this.button7.TabIndex = 27;
            this.button7.Text = "Поворот(градусы)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(622, 345);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 22);
            this.button8.TabIndex = 28;
            this.button8.Text = "Отражение по Oxy";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(622, 380);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 22);
            this.button9.TabIndex = 29;
            this.button9.Text = "Отражение по Oyz";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(622, 414);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 22);
            this.button10.TabIndex = 30;
            this.button10.Text = "Отражение по Oxz";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(622, 456);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(150, 22);
            this.button11.TabIndex = 31;
            this.button11.Text = "Масштабирование";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // rotateOX
            // 
            this.rotateOX.AutoSize = true;
            this.rotateOX.Location = new System.Drawing.Point(818, 12);
            this.rotateOX.Name = "rotateOX";
            this.rotateOX.Size = new System.Drawing.Size(32, 17);
            this.rotateOX.TabIndex = 23;
            this.rotateOX.TabStop = true;
            this.rotateOX.Text = "X";
            this.rotateOX.UseVisualStyleBackColor = true;
            this.rotateOX.Click += new System.EventHandler(this.rotateOX_Click);
            // 
            // rotateOY
            // 
            this.rotateOY.AutoSize = true;
            this.rotateOY.Location = new System.Drawing.Point(818, 36);
            this.rotateOY.Name = "rotateOY";
            this.rotateOY.Size = new System.Drawing.Size(32, 17);
            this.rotateOY.TabIndex = 25;
            this.rotateOY.TabStop = true;
            this.rotateOY.Text = "Y";
            this.rotateOY.UseVisualStyleBackColor = true;
            this.rotateOY.Click += new System.EventHandler(this.rotateOY_Click);
            // 
            // rotateOZ
            // 
            this.rotateOZ.AutoSize = true;
            this.rotateOZ.Location = new System.Drawing.Point(818, 60);
            this.rotateOZ.Name = "rotateOZ";
            this.rotateOZ.Size = new System.Drawing.Size(32, 17);
            this.rotateOZ.TabIndex = 26;
            this.rotateOZ.TabStop = true;
            this.rotateOZ.Text = "Z";
            this.rotateOZ.UseVisualStyleBackColor = true;
            this.rotateOZ.Click += new System.EventHandler(this.rotateOZ_Click);
            // 
            // rotateAngle
            // 
            this.rotateAngle.Location = new System.Drawing.Point(818, 113);
            this.rotateAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotateAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotateAngle.Name = "rotateAngle";
            this.rotateAngle.Size = new System.Drawing.Size(92, 20);
            this.rotateAngle.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(816, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Выберите угол вращения";
            // 
            // rotateBtn
            // 
            this.rotateBtn.Location = new System.Drawing.Point(821, 256);
            this.rotateBtn.Name = "rotateBtn";
            this.rotateBtn.Size = new System.Drawing.Size(156, 23);
            this.rotateBtn.TabIndex = 30;
            this.rotateBtn.Text = "Выполнить вращение";
            this.rotateBtn.UseVisualStyleBackColor = true;
            this.rotateBtn.Click += new System.EventHandler(this.rotateBtn_Click);
            // 
            // rZ1
            // 
            this.rZ1.Location = new System.Drawing.Point(841, 221);
            this.rZ1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rZ1.Name = "rZ1";
            this.rZ1.Size = new System.Drawing.Size(47, 20);
            this.rZ1.TabIndex = 36;
            this.rZ1.Text = "0";
            // 
            // rY1
            // 
            this.rY1.Location = new System.Drawing.Point(841, 196);
            this.rY1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rY1.Name = "rY1";
            this.rY1.Size = new System.Drawing.Size(47, 20);
            this.rY1.TabIndex = 35;
            this.rY1.Text = "0";
            this.rY1.TextChanged += new System.EventHandler(this.rY1_TextChanged);
            // 
            // rX1
            // 
            this.rX1.Location = new System.Drawing.Point(841, 173);
            this.rX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rX1.Name = "rX1";
            this.rX1.Size = new System.Drawing.Size(47, 20);
            this.rX1.TabIndex = 34;
            this.rX1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(815, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "z1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(816, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "y1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(815, 173);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "x1";
            // 
            // rZ2
            // 
            this.rZ2.Location = new System.Drawing.Point(930, 224);
            this.rZ2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rZ2.Name = "rZ2";
            this.rZ2.Size = new System.Drawing.Size(47, 20);
            this.rZ2.TabIndex = 42;
            this.rZ2.Text = "0";
            // 
            // rY2
            // 
            this.rY2.Location = new System.Drawing.Point(930, 198);
            this.rY2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rY2.Name = "rY2";
            this.rY2.Size = new System.Drawing.Size(47, 20);
            this.rY2.TabIndex = 41;
            this.rY2.Text = "0";
            // 
            // rX2
            // 
            this.rX2.Location = new System.Drawing.Point(930, 170);
            this.rX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rX2.Name = "rX2";
            this.rX2.Size = new System.Drawing.Size(47, 20);
            this.rX2.TabIndex = 40;
            this.rX2.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(907, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "z2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(907, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "y2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(906, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "x2";
            // 
            // rotateOwn
            // 
            this.rotateOwn.AutoSize = true;
            this.rotateOwn.Location = new System.Drawing.Point(859, 36);
            this.rotateOwn.Name = "rotateOwn";
            this.rotateOwn.Size = new System.Drawing.Size(120, 17);
            this.rotateOwn.TabIndex = 43;
            this.rotateOwn.TabStop = true;
            this.rotateOwn.Text = "Произвольная ось";
            this.rotateOwn.UseVisualStyleBackColor = true;
            this.rotateOwn.CheckedChanged += new System.EventHandler(this.rotateOwn_CheckedChanged);
            this.rotateOwn.Click += new System.EventHandler(this.rotateOwn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(612, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 10);
            this.button1.TabIndex = 44;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(612, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 10);
            this.button2.TabIndex = 45;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(784, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 546);
            this.button4.TabIndex = 46;
            this.button4.TabStop = false;
            this.button4.Text = "button4";
            this.button4.UseMnemonic = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 566);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rotateOwn);
            this.Controls.Add(this.rZ2);
            this.Controls.Add(this.rY2);
            this.Controls.Add(this.rX2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rZ1);
            this.Controls.Add(this.rY1);
            this.Controls.Add(this.rX1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rotateBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rotateAngle);
            this.Controls.Add(this.rotateOZ);
            this.Controls.Add(this.rotateOY);
            this.Controls.Add(this.rotateOX);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.projBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createOktaButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createTetrButton);
            this.Controls.Add(this.createCubeButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №6. Аффинные преобразования в пространстве. Проецирование";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createCubeButton;
        private System.Windows.Forms.Button createTetrButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button createOktaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox projBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.RadioButton rotateOX;
        private System.Windows.Forms.RadioButton rotateOY;
        private System.Windows.Forms.RadioButton rotateOZ;
        private System.Windows.Forms.NumericUpDown rotateAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button rotateBtn;
        private System.Windows.Forms.TextBox rZ1;
        private System.Windows.Forms.TextBox rY1;
        private System.Windows.Forms.TextBox rX1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rZ2;
        private System.Windows.Forms.TextBox rY2;
        private System.Windows.Forms.TextBox rX2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rotateOwn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

