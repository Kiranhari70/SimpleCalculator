namespace SimpleCalculator
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
            this.components = new System.ComponentModel.Container();
            this.Display = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(14, 15);
            this.Display.Margin = new System.Windows.Forms.Padding(6);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(350, 74);
            this.Display.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(32, 101);
            this.btn1.Margin = new System.Windows.Forms.Padding(6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 54);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(99, 101);
            this.btn2.Margin = new System.Windows.Forms.Padding(6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 54);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(166, 101);
            this.btn3.Margin = new System.Windows.Forms.Padding(6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 54);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(32, 167);
            this.btn4.Margin = new System.Windows.Forms.Padding(6);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 54);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(99, 167);
            this.btn5.Margin = new System.Windows.Forms.Padding(6);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 54);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(99, 299);
            this.btn0.Margin = new System.Windows.Forms.Padding(6);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 54);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(166, 233);
            this.btn9.Margin = new System.Windows.Forms.Padding(6);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 54);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(99, 233);
            this.btn8.Margin = new System.Windows.Forms.Padding(6);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 54);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(32, 233);
            this.btn7.Margin = new System.Windows.Forms.Padding(6);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 54);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(166, 167);
            this.btn6.Margin = new System.Windows.Forms.Padding(6);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 54);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(233, 233);
            this.btnClr.Margin = new System.Windows.Forms.Padding(6);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(132, 54);
            this.btnClr.TabIndex = 16;
            this.btnClr.Text = "CLEAR";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(242, 101);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(6);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 54);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultply
            // 
            this.btnMultply.Location = new System.Drawing.Point(310, 177);
            this.btnMultply.Margin = new System.Windows.Forms.Padding(6);
            this.btnMultply.Name = "btnMultply";
            this.btnMultply.Size = new System.Drawing.Size(55, 54);
            this.btnMultply.TabIndex = 14;
            this.btnMultply.Text = "*";
            this.btnMultply.UseVisualStyleBackColor = true;
            this.btnMultply.Click += new System.EventHandler(this.btnMultply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(242, 177);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(55, 54);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(309, 101);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(55, 54);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(183, 307);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(6);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(114, 38);
            this.btnEqual.TabIndex = 17;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 362);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
    }
}

