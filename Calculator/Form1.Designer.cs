
namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculator = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.difference = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-36, -83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, -56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Calculator
            // 
            this.Calculator.AllowDrop = true;
            this.Calculator.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(238, 18);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(271, 74);
            this.Calculator.TabIndex = 2;
            this.Calculator.Text = "Calculator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 23);
            this.textBox2.TabIndex = 4;
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value1.Location = new System.Drawing.Point(238, 140);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(61, 26);
            this.value1.TabIndex = 5;
            this.value1.Text = "Value 1";
            // 
            // value2
            // 
            this.value2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value2.Location = new System.Drawing.Point(238, 189);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(61, 26);
            this.value2.TabIndex = 6;
            this.value2.Text = "Value 2";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(214, 249);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(42, 38);
            this.sum.TabIndex = 7;
            this.sum.Text = "+";
            this.sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(342, 249);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(42, 38);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "*";
            this.multiply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difference.Location = new System.Drawing.Point(279, 249);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(42, 38);
            this.difference.TabIndex = 9;
            this.difference.Text = "-";
            this.difference.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.difference.UseVisualStyleBackColor = true;
            this.difference.Click += new System.EventHandler(this.difference_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.Location = new System.Drawing.Point(407, 249);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(42, 38);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(448, 164);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(132, 24);
            this.resultBox.TabIndex = 11;
            this.resultBox.Text = "0.0";
            // 
            // mode
            // 
            this.mode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mode.Location = new System.Drawing.Point(467, 249);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(42, 38);
            this.mode.TabIndex = 12;
            this.mode.Text = "%";
            this.mode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mode.UseVisualStyleBackColor = true;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(402, 313);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 38);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pow
            // 
            this.pow.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pow.Location = new System.Drawing.Point(214, 313);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(79, 38);
            this.pow.TabIndex = 14;
            this.pow.Text = "x^2";
            this.pow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "";
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(311, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 38);
            this.button2.TabIndex = 15;
            this.button2.Text = "x^3";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "x^3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Calculator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button difference;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.Button mode;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button button2;
    }
}

