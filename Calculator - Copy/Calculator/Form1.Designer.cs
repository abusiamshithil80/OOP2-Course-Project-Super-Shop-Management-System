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
            this.PanBack = new System.Windows.Forms.Panel();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnParcent = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.PanBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanBack
            // 
            this.PanBack.BackColor = System.Drawing.Color.Snow;
            this.PanBack.Controls.Add(this.btnAddition);
            this.PanBack.Controls.Add(this.btn0);
            this.PanBack.Controls.Add(this.btn00);
            this.PanBack.Controls.Add(this.btnpoint);
            this.PanBack.Controls.Add(this.btnEqual);
            this.PanBack.Controls.Add(this.btn8);
            this.PanBack.Controls.Add(this.btn4);
            this.PanBack.Controls.Add(this.btn5);
            this.PanBack.Controls.Add(this.btn2);
            this.PanBack.Controls.Add(this.btn1);
            this.PanBack.Controls.Add(this.btn3);
            this.PanBack.Controls.Add(this.btnSubstraction);
            this.PanBack.Controls.Add(this.btn6);
            this.PanBack.Controls.Add(this.btnMultiply);
            this.PanBack.Controls.Add(this.btn9);
            this.PanBack.Controls.Add(this.btn7);
            this.PanBack.Controls.Add(this.btnDivide);
            this.PanBack.Controls.Add(this.btnParcent);
            this.PanBack.Controls.Add(this.btnAC);
            this.PanBack.Controls.Add(this.txtDisplay);
            this.PanBack.Location = new System.Drawing.Point(12, 12);
            this.PanBack.Name = "PanBack";
            this.PanBack.Size = new System.Drawing.Size(306, 460);
            this.PanBack.TabIndex = 0;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddition.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddition.Location = new System.Drawing.Point(227, 313);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(65, 50);
            this.btnAddition.TabIndex = 19;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn0.Location = new System.Drawing.Point(14, 380);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(65, 50);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.DimGray;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn00.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn00.Location = new System.Drawing.Point(85, 380);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(65, 50);
            this.btn00.TabIndex = 17;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.DimGray;
            this.btnpoint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnpoint.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnpoint.Location = new System.Drawing.Point(156, 380);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(65, 50);
            this.btnpoint.TabIndex = 16;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.DimGray;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEqual.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEqual.Location = new System.Drawing.Point(227, 380);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(65, 50);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn8.Location = new System.Drawing.Point(85, 176);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 50);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn4.Location = new System.Drawing.Point(14, 244);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 50);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn5.Location = new System.Drawing.Point(85, 244);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 50);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn2.Location = new System.Drawing.Point(85, 313);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 50);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn1.Location = new System.Drawing.Point(14, 313);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 50);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn3.Location = new System.Drawing.Point(156, 313);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 50);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.Color.DimGray;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubstraction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstraction.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSubstraction.Location = new System.Drawing.Point(227, 244);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(65, 50);
            this.btnSubstraction.TabIndex = 8;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn6.Location = new System.Drawing.Point(156, 244);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 50);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.DimGray;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMultiply.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiply.Location = new System.Drawing.Point(227, 176);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(65, 50);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn9.Location = new System.Drawing.Point(156, 176);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 50);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn7.Location = new System.Drawing.Point(14, 176);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 50);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DimGray;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDivide.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDivide.Location = new System.Drawing.Point(224, 103);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(65, 50);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnParcent
            // 
            this.btnParcent.BackColor = System.Drawing.Color.Gray;
            this.btnParcent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnParcent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcent.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnParcent.Location = new System.Drawing.Point(133, 103);
            this.btnParcent.Name = "btnParcent";
            this.btnParcent.Size = new System.Drawing.Size(65, 50);
            this.btnParcent.TabIndex = 2;
            this.btnParcent.Text = "%";
            this.btnParcent.UseVisualStyleBackColor = false;
            this.btnParcent.Click += new System.EventHandler(this.btnParcent_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.IndianRed;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAC.Location = new System.Drawing.Point(14, 103);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(100, 50);
            this.btnAC.TabIndex = 1;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDisplay.Location = new System.Drawing.Point(14, 28);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(275, 40);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 485);
            this.Controls.Add(this.PanBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBack;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnParcent;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btnEqual;
    }
}

