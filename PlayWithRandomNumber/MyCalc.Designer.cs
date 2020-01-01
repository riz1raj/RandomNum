namespace WindowsFormsApplication3
{
    partial class MyCalc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.no2 = new System.Windows.Forms.Button();
            this.no9 = new System.Windows.Forms.Button();
            this.no8 = new System.Windows.Forms.Button();
            this.no7 = new System.Windows.Forms.Button();
            this.no4 = new System.Windows.Forms.Button();
            this.no5 = new System.Windows.Forms.Button();
            this.no0 = new System.Windows.Forms.Button();
            this.no3 = new System.Windows.Forms.Button();
            this.no1 = new System.Windows.Forms.Button();
            this.no6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 511);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.calc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dot);
            this.panel2.Controls.Add(this.equal);
            this.panel2.Controls.Add(this.mul);
            this.panel2.Controls.Add(this.div);
            this.panel2.Controls.Add(this.plus);
            this.panel2.Controls.Add(this.minus);
            this.panel2.Controls.Add(this.no2);
            this.panel2.Controls.Add(this.no9);
            this.panel2.Controls.Add(this.no8);
            this.panel2.Controls.Add(this.no7);
            this.panel2.Controls.Add(this.no4);
            this.panel2.Controls.Add(this.no5);
            this.panel2.Controls.Add(this.no0);
            this.panel2.Controls.Add(this.no3);
            this.panel2.Controls.Add(this.no1);
            this.panel2.Controls.Add(this.no6);
            this.panel2.ForeColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(20, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 476);
            this.panel2.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button12.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Maroon;
            this.button12.Location = new System.Drawing.Point(672, 418);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 43);
            this.button12.TabIndex = 81;
            this.button12.Text = "Back";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Yellow;
            this.button19.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(800, 418);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 45);
            this.button19.TabIndex = 80;
            this.button19.Text = "Exit";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Button19_Click);
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.Black;
            this.calc.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.ForeColor = System.Drawing.Color.Red;
            this.calc.Location = new System.Drawing.Point(59, 208);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(388, 38);
            this.calc.TabIndex = 77;
            this.calc.Text = "Clear";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(56, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Calculate :";
            // 
            // numbox
            // 
            this.numbox.Location = new System.Drawing.Point(210, 127);
            this.numbox.Name = "numbox";
            this.numbox.Size = new System.Drawing.Size(237, 20);
            this.numbox.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 64;
            this.label1.Text = "Simple Calculator";
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.Black;
            this.dot.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.ForeColor = System.Drawing.Color.Red;
            this.dot.Location = new System.Drawing.Point(628, 344);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(69, 50);
            this.dot.TabIndex = 63;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Snow;
            this.equal.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.Color.Red;
            this.equal.Location = new System.Drawing.Point(733, 344);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(69, 50);
            this.equal.TabIndex = 62;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.Lavender;
            this.mul.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.ForeColor = System.Drawing.Color.Red;
            this.mul.Location = new System.Drawing.Point(819, 274);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(69, 50);
            this.mul.TabIndex = 61;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.Lavender;
            this.div.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.Color.Red;
            this.div.Location = new System.Drawing.Point(819, 344);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(69, 50);
            this.div.TabIndex = 60;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.Div_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Lavender;
            this.plus.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.Red;
            this.plus.Location = new System.Drawing.Point(819, 127);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(69, 50);
            this.plus.TabIndex = 57;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Lavender;
            this.minus.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.Color.Red;
            this.minus.Location = new System.Drawing.Point(819, 200);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(69, 50);
            this.minus.TabIndex = 56;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // no2
            // 
            this.no2.BackColor = System.Drawing.Color.Black;
            this.no2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no2.ForeColor = System.Drawing.Color.Red;
            this.no2.Location = new System.Drawing.Point(628, 274);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(69, 50);
            this.no2.TabIndex = 55;
            this.no2.Text = "2";
            this.no2.UseVisualStyleBackColor = false;
            this.no2.Click += new System.EventHandler(this.No2_Click);
            // 
            // no9
            // 
            this.no9.BackColor = System.Drawing.Color.Black;
            this.no9.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no9.ForeColor = System.Drawing.Color.Red;
            this.no9.Location = new System.Drawing.Point(733, 127);
            this.no9.Name = "no9";
            this.no9.Size = new System.Drawing.Size(69, 50);
            this.no9.TabIndex = 54;
            this.no9.Text = "9";
            this.no9.UseVisualStyleBackColor = false;
            this.no9.Click += new System.EventHandler(this.No9_Click);
            // 
            // no8
            // 
            this.no8.BackColor = System.Drawing.Color.Black;
            this.no8.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no8.ForeColor = System.Drawing.Color.Red;
            this.no8.Location = new System.Drawing.Point(628, 127);
            this.no8.Name = "no8";
            this.no8.Size = new System.Drawing.Size(69, 50);
            this.no8.TabIndex = 53;
            this.no8.Text = "8";
            this.no8.UseVisualStyleBackColor = false;
            this.no8.Click += new System.EventHandler(this.No8_Click);
            // 
            // no7
            // 
            this.no7.BackColor = System.Drawing.Color.Black;
            this.no7.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no7.ForeColor = System.Drawing.Color.Red;
            this.no7.Location = new System.Drawing.Point(526, 127);
            this.no7.Name = "no7";
            this.no7.Size = new System.Drawing.Size(69, 50);
            this.no7.TabIndex = 52;
            this.no7.Text = "7";
            this.no7.UseVisualStyleBackColor = false;
            this.no7.Click += new System.EventHandler(this.No7_Click);
            // 
            // no4
            // 
            this.no4.BackColor = System.Drawing.Color.Black;
            this.no4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no4.ForeColor = System.Drawing.Color.Red;
            this.no4.Location = new System.Drawing.Point(529, 200);
            this.no4.Name = "no4";
            this.no4.Size = new System.Drawing.Size(69, 50);
            this.no4.TabIndex = 51;
            this.no4.Text = "4";
            this.no4.UseVisualStyleBackColor = false;
            this.no4.Click += new System.EventHandler(this.No4_Click);
            // 
            // no5
            // 
            this.no5.BackColor = System.Drawing.Color.Black;
            this.no5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no5.ForeColor = System.Drawing.Color.Red;
            this.no5.Location = new System.Drawing.Point(628, 200);
            this.no5.Name = "no5";
            this.no5.Size = new System.Drawing.Size(69, 50);
            this.no5.TabIndex = 50;
            this.no5.Text = "5";
            this.no5.UseVisualStyleBackColor = false;
            this.no5.Click += new System.EventHandler(this.No5_Click);
            // 
            // no0
            // 
            this.no0.BackColor = System.Drawing.Color.Black;
            this.no0.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no0.ForeColor = System.Drawing.Color.Red;
            this.no0.Location = new System.Drawing.Point(529, 344);
            this.no0.Name = "no0";
            this.no0.Size = new System.Drawing.Size(69, 50);
            this.no0.TabIndex = 49;
            this.no0.Text = "0";
            this.no0.UseVisualStyleBackColor = false;
            this.no0.Click += new System.EventHandler(this.No0_Click);
            // 
            // no3
            // 
            this.no3.BackColor = System.Drawing.Color.Black;
            this.no3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no3.ForeColor = System.Drawing.Color.Red;
            this.no3.Location = new System.Drawing.Point(733, 274);
            this.no3.Name = "no3";
            this.no3.Size = new System.Drawing.Size(69, 50);
            this.no3.TabIndex = 48;
            this.no3.Text = "3";
            this.no3.UseVisualStyleBackColor = false;
            this.no3.Click += new System.EventHandler(this.No3_Click);
            // 
            // no1
            // 
            this.no1.BackColor = System.Drawing.Color.Black;
            this.no1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no1.ForeColor = System.Drawing.Color.Red;
            this.no1.Location = new System.Drawing.Point(526, 274);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(72, 50);
            this.no1.TabIndex = 47;
            this.no1.Text = "1";
            this.no1.UseVisualStyleBackColor = false;
            this.no1.Click += new System.EventHandler(this.No1_Click);
            // 
            // no6
            // 
            this.no6.BackColor = System.Drawing.Color.Black;
            this.no6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no6.ForeColor = System.Drawing.Color.Red;
            this.no6.Location = new System.Drawing.Point(733, 200);
            this.no6.Name = "no6";
            this.no6.Size = new System.Drawing.Size(69, 50);
            this.no6.TabIndex = 46;
            this.no6.Text = "6";
            this.no6.UseVisualStyleBackColor = false;
            this.no6.Click += new System.EventHandler(this.Button4_Click);
            // 
            // MyCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.Controls.Add(this.panel1);
            this.Name = "MyCalc";
            this.Text = "MyCalc";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button no2;
        private System.Windows.Forms.Button no9;
        private System.Windows.Forms.Button no8;
        private System.Windows.Forms.Button no7;
        private System.Windows.Forms.Button no4;
        private System.Windows.Forms.Button no5;
        private System.Windows.Forms.Button no0;
        private System.Windows.Forms.Button no3;
        private System.Windows.Forms.Button no1;
        private System.Windows.Forms.Button no6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button12;
    }
}