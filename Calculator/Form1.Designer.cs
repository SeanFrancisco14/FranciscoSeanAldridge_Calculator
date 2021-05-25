
namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.CE_Button = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.multiplicationSign = new System.Windows.Forms.Button();
            this.divisionSign = new System.Windows.Forms.Button();
            this.minusSign = new System.Windows.Forms.Button();
            this.equalsSign = new System.Windows.Forms.Button();
            this.plusSign = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.currentOperation_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(12, 75);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(59, 50);
            this.num7.TabIndex = 0;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.button_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(77, 75);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(59, 50);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.button_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(142, 75);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(59, 50);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.button_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 132);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(59, 50);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.button_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(77, 132);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(59, 50);
            this.num5.TabIndex = 4;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.button_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(142, 131);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(59, 50);
            this.num6.TabIndex = 5;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.button_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 188);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(59, 50);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(77, 188);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(59, 50);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.button_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(142, 189);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(59, 50);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.button_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(12, 244);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(124, 50);
            this.num0.TabIndex = 9;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.button_Click);
            // 
            // period
            // 
            this.period.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(142, 244);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(59, 50);
            this.period.TabIndex = 10;
            this.period.Text = ".";
            this.period.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.period.UseVisualStyleBackColor = true;
            this.period.Click += new System.EventHandler(this.button_Click);
            // 
            // CE_Button
            // 
            this.CE_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE_Button.Location = new System.Drawing.Point(207, 75);
            this.CE_Button.Name = "CE_Button";
            this.CE_Button.Size = new System.Drawing.Size(59, 50);
            this.CE_Button.TabIndex = 11;
            this.CE_Button.Text = "CE";
            this.CE_Button.UseVisualStyleBackColor = true;
            this.CE_Button.Click += new System.EventHandler(this.CEbtn_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearButton.ForeColor = System.Drawing.Color.Lime;
            this.clearButton.Location = new System.Drawing.Point(272, 75);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(59, 50);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // multiplicationSign
            // 
            this.multiplicationSign.Location = new System.Drawing.Point(207, 132);
            this.multiplicationSign.Name = "multiplicationSign";
            this.multiplicationSign.Size = new System.Drawing.Size(59, 50);
            this.multiplicationSign.TabIndex = 13;
            this.multiplicationSign.Text = "*";
            this.multiplicationSign.UseVisualStyleBackColor = true;
            this.multiplicationSign.Click += new System.EventHandler(this.operator_Click);
            // 
            // divisionSign
            // 
            this.divisionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionSign.Location = new System.Drawing.Point(272, 131);
            this.divisionSign.Name = "divisionSign";
            this.divisionSign.Size = new System.Drawing.Size(59, 50);
            this.divisionSign.TabIndex = 14;
            this.divisionSign.Text = "/";
            this.divisionSign.UseVisualStyleBackColor = true;
            this.divisionSign.Click += new System.EventHandler(this.operator_Click);
            // 
            // minusSign
            // 
            this.minusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusSign.Location = new System.Drawing.Point(207, 188);
            this.minusSign.Name = "minusSign";
            this.minusSign.Size = new System.Drawing.Size(59, 50);
            this.minusSign.TabIndex = 15;
            this.minusSign.Text = "-";
            this.minusSign.UseVisualStyleBackColor = true;
            this.minusSign.Click += new System.EventHandler(this.operator_Click);
            // 
            // equalsSign
            // 
            this.equalsSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsSign.Location = new System.Drawing.Point(272, 187);
            this.equalsSign.Name = "equalsSign";
            this.equalsSign.Size = new System.Drawing.Size(59, 108);
            this.equalsSign.TabIndex = 16;
            this.equalsSign.Text = "=";
            this.equalsSign.UseVisualStyleBackColor = true;
            this.equalsSign.Click += new System.EventHandler(this.equalsSign_Click);
            // 
            // plusSign
            // 
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(207, 243);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(59, 50);
            this.plusSign.TabIndex = 17;
            this.plusSign.Text = "+";
            this.plusSign.UseVisualStyleBackColor = true;
            this.plusSign.Click += new System.EventHandler(this.operator_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(12, 49);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(319, 20);
            this.textBox_Answer.TabIndex = 18;
            this.textBox_Answer.Text = "0";
            this.textBox_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentOperation_Label
            // 
            this.currentOperation_Label.AutoSize = true;
            this.currentOperation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOperation_Label.ForeColor = System.Drawing.Color.Aqua;
            this.currentOperation_Label.Location = new System.Drawing.Point(12, 9);
            this.currentOperation_Label.Name = "currentOperation_Label";
            this.currentOperation_Label.Size = new System.Drawing.Size(0, 24);
            this.currentOperation_Label.TabIndex = 19;
            this.currentOperation_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(338, 305);
            this.Controls.Add(this.currentOperation_Label);
            this.Controls.Add(this.textBox_Answer);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.equalsSign);
            this.Controls.Add(this.minusSign);
            this.Controls.Add(this.divisionSign);
            this.Controls.Add(this.multiplicationSign);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CE_Button);
            this.Controls.Add(this.period);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.Button CE_Button;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button multiplicationSign;
        private System.Windows.Forms.Button divisionSign;
        private System.Windows.Forms.Button minusSign;
        private System.Windows.Forms.Button equalsSign;
        private System.Windows.Forms.Button plusSign;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label currentOperation_Label;
    }
}

