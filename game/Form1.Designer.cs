namespace game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button3 = new Button();
            label11 = new Label();
            label12 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label13 = new Label();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            listBox1 = new ListBox();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label20 = new Label();
            label24 = new Label();
            button18 = new Button();
            button19 = new Button();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            button20 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(314, 193);
            button1.Name = "button1";
            button1.Size = new Size(138, 45);
            button1.TabIndex = 0;
            button1.Text = "Start game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(314, 193);
            button2.Name = "button2";
            button2.Size = new Size(138, 45);
            button2.TabIndex = 0;
            button2.Text = "Retry";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 45);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 27);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Visible = false;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 128);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            textBox2.Visible = false;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 22);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Player 1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Player 2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 177);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "❤Health:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 117);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "🛡️Armor:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 117);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(75, 20);
            label5.TabIndex = 2;
            label5.Text = "🛡️Armor:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 177);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 2;
            label6.Text = "❤Health:";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(14, 147);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 3;
            label7.Text = "0";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(14, 208);
            label8.Name = "label8";
            label8.Size = new Size(18, 20);
            label8.TabIndex = 3;
            label8.Text = "0";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(531, 147);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 3;
            label9.Text = "0";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(531, 208);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 3;
            label10.Text = "0";
            label10.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(314, 244);
            button3.Name = "button3";
            button3.Size = new Size(138, 45);
            button3.TabIndex = 1;
            button3.Text = "Change name";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(14, 61);
            label11.Name = "label11";
            label11.Size = new Size(121, 38);
            label11.TabIndex = 2;
            label11.Text = "Name 1";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(531, 61);
            label12.Name = "label12";
            label12.Size = new Size(121, 38);
            label12.TabIndex = 2;
            label12.Text = "Name 1";
            label12.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(693, 275);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 0;
            button4.TabStop = false;
            button4.Text = "Attack";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(12, 275);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 0;
            button5.TabStop = false;
            button5.Text = "Attack";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(170, 184);
            button6.Name = "button6";
            button6.Size = new Size(138, 45);
            button6.TabIndex = 0;
            button6.Text = "Fast (10)";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(458, 184);
            button7.Name = "button7";
            button7.Size = new Size(138, 45);
            button7.TabIndex = 2;
            button7.Text = "Long (1000)";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Orange;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(314, 183);
            button8.Name = "button8";
            button8.Size = new Size(138, 45);
            button8.TabIndex = 1;
            button8.Text = "Middle (100)";
            button8.UseVisualStyleBackColor = false;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Yellow;
            button9.ForeColor = Color.Black;
            button9.Location = new Point(314, 244);
            button9.Name = "button9";
            button9.Size = new Size(138, 45);
            button9.TabIndex = 2;
            button9.Text = "Сonfirm name";
            button9.UseVisualStyleBackColor = false;
            button9.Visible = false;
            button9.Click += button9_Click;
            // 
            // label13
            // 
            label13.AutoEllipsis = true;
            label13.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(174, 60);
            label13.Name = "label13";
            label13.Size = new Size(423, 120);
            label13.TabIndex = 2;
            label13.Text = "Welcome to PVP\r\nsrategy ⚔";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            button10.BackColor = Color.DodgerBlue;
            button10.ForeColor = Color.Black;
            button10.Location = new Point(93, 275);
            button10.Name = "button10";
            button10.Size = new Size(75, 30);
            button10.TabIndex = 0;
            button10.TabStop = false;
            button10.Text = "Defense";
            button10.UseVisualStyleBackColor = false;
            button10.Visible = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DodgerBlue;
            button11.ForeColor = Color.Black;
            button11.Location = new Point(612, 275);
            button11.Name = "button11";
            button11.Size = new Size(75, 30);
            button11.TabIndex = 0;
            button11.TabStop = false;
            button11.Text = "Defense";
            button11.UseVisualStyleBackColor = false;
            button11.Visible = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.LawnGreen;
            button12.ForeColor = Color.Black;
            button12.Location = new Point(531, 275);
            button12.Name = "button12";
            button12.Size = new Size(75, 30);
            button12.TabIndex = 0;
            button12.TabStop = false;
            button12.Text = "Heal";
            button12.UseVisualStyleBackColor = false;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.LawnGreen;
            button13.ForeColor = Color.Black;
            button13.Location = new Point(174, 275);
            button13.Name = "button13";
            button13.Size = new Size(75, 30);
            button13.TabIndex = 0;
            button13.TabStop = false;
            button13.Text = "Heal";
            button13.UseVisualStyleBackColor = false;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Crimson;
            button14.ForeColor = Color.Black;
            button14.Location = new Point(314, 295);
            button14.Name = "button14";
            button14.Size = new Size(138, 45);
            button14.TabIndex = 2;
            button14.Text = "Exit";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkGreen;
            label14.Location = new Point(174, 251);
            label14.Name = "label14";
            label14.Size = new Size(18, 20);
            label14.TabIndex = 3;
            label14.Text = "0";
            label14.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(531, 251);
            label15.Name = "label15";
            label15.Size = new Size(18, 20);
            label15.TabIndex = 3;
            label15.Text = "0";
            label15.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkBlue;
            label16.Location = new Point(95, 251);
            label16.Name = "label16";
            label16.Size = new Size(18, 20);
            label16.TabIndex = 3;
            label16.Text = "0";
            label16.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkBlue;
            label17.Location = new Point(612, 251);
            label17.Name = "label17";
            label17.Size = new Size(18, 20);
            label17.TabIndex = 3;
            label17.Text = "0";
            label17.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Crimson;
            label18.Location = new Point(693, 251);
            label18.Name = "label18";
            label18.Size = new Size(18, 20);
            label18.TabIndex = 3;
            label18.Text = "0";
            label18.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Crimson;
            label19.Location = new Point(12, 251);
            label19.Name = "label19";
            label19.Size = new Size(18, 20);
            label19.TabIndex = 3;
            label19.Text = "0";
            label19.Visible = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Black;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(255, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(270, 324);
            listBox1.TabIndex = 4;
            listBox1.Visible = false;
            // 
            // button15
            // 
            button15.BackColor = Color.Yellow;
            button15.ForeColor = Color.Black;
            button15.Location = new Point(314, 244);
            button15.Name = "button15";
            button15.Size = new Size(138, 45);
            button15.TabIndex = 1;
            button15.Text = "Change theme";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkTurquoise;
            button16.ForeColor = Color.Black;
            button16.Location = new Point(170, 183);
            button16.Name = "button16";
            button16.Size = new Size(138, 45);
            button16.TabIndex = 0;
            button16.Text = "Blue";
            button16.UseVisualStyleBackColor = false;
            button16.Visible = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.GreenYellow;
            button17.ForeColor = Color.Black;
            button17.Location = new Point(459, 183);
            button17.Name = "button17";
            button17.Size = new Size(138, 45);
            button17.TabIndex = 0;
            button17.Text = "Green";
            button17.UseVisualStyleBackColor = false;
            button17.Visible = false;
            button17.Click += button17_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label21.Location = new Point(531, 12);
            label21.Name = "label21";
            label21.Size = new Size(91, 38);
            label21.TabIndex = 2;
            label21.Text = "Wins:";
            label21.Visible = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label22.Location = new Point(109, 12);
            label22.Name = "label22";
            label22.Size = new Size(33, 38);
            label22.TabIndex = 2;
            label22.Text = "0";
            label22.Visible = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label23.Location = new Point(628, 12);
            label23.Name = "label23";
            label23.Size = new Size(33, 38);
            label23.TabIndex = 2;
            label23.Text = "0";
            label23.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label20.Location = new Point(12, 12);
            label20.Name = "label20";
            label20.Size = new Size(91, 38);
            label20.TabIndex = 2;
            label20.Text = "Wins:";
            label20.Visible = false;
            // 
            // label24
            // 
            label24.AutoEllipsis = true;
            label24.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label24.Location = new Point(170, 60);
            label24.Name = "label24";
            label24.Size = new Size(426, 120);
            label24.TabIndex = 2;
            label24.Text = "Player 1\r\nWins";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            label24.Visible = false;
            // 
            // button18
            // 
            button18.BackColor = Color.Yellow;
            button18.ForeColor = Color.Black;
            button18.Location = new Point(12, 310);
            button18.Name = "button18";
            button18.Size = new Size(237, 30);
            button18.TabIndex = 0;
            button18.TabStop = false;
            button18.Text = "Random";
            button18.UseVisualStyleBackColor = false;
            button18.Visible = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Yellow;
            button19.ForeColor = Color.Black;
            button19.Location = new Point(531, 310);
            button19.Name = "button19";
            button19.Size = new Size(237, 30);
            button19.TabIndex = 0;
            button19.TabStop = false;
            button19.Text = "Random";
            button19.UseVisualStyleBackColor = false;
            button19.Visible = false;
            button19.Click += button19_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.Red;
            label25.Location = new Point(531, 201);
            label25.Name = "label25";
            label25.Size = new Size(39, 28);
            label25.TabIndex = 2;
            label25.Text = "💦";
            label25.Visible = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.Yellow;
            label26.Location = new Point(14, 140);
            label26.Name = "label26";
            label26.Size = new Size(39, 28);
            label26.TabIndex = 2;
            label26.Text = "💥";
            label26.Visible = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = Color.Red;
            label27.Location = new Point(14, 201);
            label27.Name = "label27";
            label27.Size = new Size(39, 28);
            label27.TabIndex = 2;
            label27.Text = "💦";
            label27.Visible = false;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.Yellow;
            label28.Location = new Point(531, 140);
            label28.Name = "label28";
            label28.Size = new Size(39, 28);
            label28.TabIndex = 2;
            label28.Text = "💥";
            label28.Visible = false;
            // 
            // button20
            // 
            button20.BackColor = Color.SlateBlue;
            button20.ForeColor = Color.Black;
            button20.Location = new Point(749, 0);
            button20.Name = "button20";
            button20.Size = new Size(30, 30);
            button20.TabIndex = 0;
            button20.TabStop = false;
            button20.Text = "🔈";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(780, 352);
            Controls.Add(label28);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label5);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label12);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label25);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button20);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button4);
            Controls.Add(button13);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(button16);
            Controls.Add(button6);
            Controls.Add(button17);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(listBox1);
            Controls.Add(label24);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PVP strategy";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button3;
        private Label label11;
        private Label label12;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label13;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private ListBox listBox1;
        private Button button15;
        private Button button16;
        private Button button17;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label20;
        private Label label24;
        private Button button18;
        private Button button19;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Button button20;
    }
}