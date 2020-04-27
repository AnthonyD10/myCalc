namespace MyCalc
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
            this.components = new System.ComponentModel.Container();
            this.digit1 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.Entry = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.Location = new System.Drawing.Point(78, 292);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(60, 40);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.digit1_Click);
            // 
            // digit2
            // 
            this.digit2.Location = new System.Drawing.Point(144, 292);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(60, 40);
            this.digit2.TabIndex = 1;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.digit2_Click);
            // 
            // digit3
            // 
            this.digit3.Location = new System.Drawing.Point(210, 292);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(60, 40);
            this.digit3.TabIndex = 2;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.digit3_Click);
            // 
            // digit4
            // 
            this.digit4.Location = new System.Drawing.Point(78, 246);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(60, 40);
            this.digit4.TabIndex = 3;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.digit4_Click);
            // 
            // digit5
            // 
            this.digit5.Location = new System.Drawing.Point(144, 246);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(60, 40);
            this.digit5.TabIndex = 4;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.digit5_Click);
            // 
            // digit6
            // 
            this.digit6.Location = new System.Drawing.Point(210, 246);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(60, 40);
            this.digit6.TabIndex = 5;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.digit6_Click);
            // 
            // digit7
            // 
            this.digit7.Location = new System.Drawing.Point(78, 200);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(60, 40);
            this.digit7.TabIndex = 6;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.digit7_Click);
            // 
            // digit8
            // 
            this.digit8.Location = new System.Drawing.Point(144, 200);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(60, 40);
            this.digit8.TabIndex = 7;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.digit8_Click);
            // 
            // digit9
            // 
            this.digit9.Location = new System.Drawing.Point(210, 200);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(60, 40);
            this.digit9.TabIndex = 8;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.digit9_Click);
            // 
            // digit0
            // 
            this.digit0.Location = new System.Drawing.Point(144, 338);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(60, 40);
            this.digit0.TabIndex = 9;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.digit0_Click);
            // 
            // backspace
            // 
            this.backspace.Location = new System.Drawing.Point(210, 154);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(60, 40);
            this.backspace.TabIndex = 10;
            this.backspace.Text = "backspace";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // Entry
            // 
            this.Entry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Entry.Location = new System.Drawing.Point(12, 33);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(324, 20);
            this.Entry.TabIndex = 12;
            this.Entry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(276, 292);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 40);
            this.add.TabIndex = 13;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(276, 200);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(60, 40);
            this.mult.TabIndex = 14;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(276, 246);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 40);
            this.sub.TabIndex = 15;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(276, 154);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(60, 40);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(276, 338);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(60, 40);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(144, 154);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 40);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.TextBox Entry;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Clear;
    }
}

