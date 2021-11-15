namespace forms_calculator
{
    partial class Calculator
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
            this.Textbox_Screen = new System.Windows.Forms.TextBox();
            this.Button_AC = new System.Windows.Forms.Button();
            this.Button_Del = new System.Windows.Forms.Button();
            this.Button_Divide = new System.Windows.Forms.Button();
            this.Button_Multiply = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_Minus = new System.Windows.Forms.Button();
            this.Button_Plus = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_Point = new System.Windows.Forms.Button();
            this.Button_0 = new System.Windows.Forms.Button();
            this.Button_Equals = new System.Windows.Forms.Button();
            this.Textbox_Debug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Textbox_Screen
            // 
            this.Textbox_Screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_Screen.Location = new System.Drawing.Point(5, 12);
            this.Textbox_Screen.Name = "Textbox_Screen";
            this.Textbox_Screen.ReadOnly = true;
            this.Textbox_Screen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Textbox_Screen.Size = new System.Drawing.Size(219, 16);
            this.Textbox_Screen.TabIndex = 0;
            this.Textbox_Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button_AC
            // 
            this.Button_AC.Location = new System.Drawing.Point(5, 42);
            this.Button_AC.Name = "Button_AC";
            this.Button_AC.Size = new System.Drawing.Size(105, 50);
            this.Button_AC.TabIndex = 1;
            this.Button_AC.Text = "AC";
            this.Button_AC.UseVisualStyleBackColor = true;
            this.Button_AC.Click += new System.EventHandler(this.Button_AC_Click);
            // 
            // Button_Del
            // 
            this.Button_Del.Location = new System.Drawing.Point(118, 42);
            this.Button_Del.Name = "Button_Del";
            this.Button_Del.Size = new System.Drawing.Size(50, 50);
            this.Button_Del.TabIndex = 2;
            this.Button_Del.Text = "DEL";
            this.Button_Del.UseVisualStyleBackColor = true;
            this.Button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // Button_Divide
            // 
            this.Button_Divide.Location = new System.Drawing.Point(174, 42);
            this.Button_Divide.Name = "Button_Divide";
            this.Button_Divide.Size = new System.Drawing.Size(50, 50);
            this.Button_Divide.TabIndex = 3;
            this.Button_Divide.Text = "÷";
            this.Button_Divide.UseVisualStyleBackColor = true;
            this.Button_Divide.Click += new System.EventHandler(this.Button_Operator);
            // 
            // Button_Multiply
            // 
            this.Button_Multiply.Location = new System.Drawing.Point(174, 98);
            this.Button_Multiply.Name = "Button_Multiply";
            this.Button_Multiply.Size = new System.Drawing.Size(50, 50);
            this.Button_Multiply.TabIndex = 4;
            this.Button_Multiply.Text = "x";
            this.Button_Multiply.UseVisualStyleBackColor = true;
            this.Button_Multiply.Click += new System.EventHandler(this.Button_Operator);
            // 
            // Button_9
            // 
            this.Button_9.Location = new System.Drawing.Point(118, 98);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(50, 50);
            this.Button_9.TabIndex = 5;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = true;
            this.Button_9.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_8
            // 
            this.Button_8.Location = new System.Drawing.Point(60, 98);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(50, 50);
            this.Button_8.TabIndex = 6;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = true;
            this.Button_8.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_7
            // 
            this.Button_7.Location = new System.Drawing.Point(5, 98);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(50, 50);
            this.Button_7.TabIndex = 7;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = true;
            this.Button_7.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_4
            // 
            this.Button_4.Location = new System.Drawing.Point(5, 154);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(50, 50);
            this.Button_4.TabIndex = 8;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = true;
            this.Button_4.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_5
            // 
            this.Button_5.Location = new System.Drawing.Point(61, 154);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(50, 50);
            this.Button_5.TabIndex = 9;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = true;
            this.Button_5.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_6
            // 
            this.Button_6.Location = new System.Drawing.Point(118, 154);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(50, 50);
            this.Button_6.TabIndex = 10;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = true;
            this.Button_6.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_Minus
            // 
            this.Button_Minus.Location = new System.Drawing.Point(174, 154);
            this.Button_Minus.Name = "Button_Minus";
            this.Button_Minus.Size = new System.Drawing.Size(50, 50);
            this.Button_Minus.TabIndex = 11;
            this.Button_Minus.Text = "-";
            this.Button_Minus.UseVisualStyleBackColor = true;
            this.Button_Minus.Click += new System.EventHandler(this.Button_Operator);
            // 
            // Button_Plus
            // 
            this.Button_Plus.Location = new System.Drawing.Point(174, 210);
            this.Button_Plus.Name = "Button_Plus";
            this.Button_Plus.Size = new System.Drawing.Size(50, 50);
            this.Button_Plus.TabIndex = 12;
            this.Button_Plus.Text = "+";
            this.Button_Plus.UseVisualStyleBackColor = true;
            this.Button_Plus.Click += new System.EventHandler(this.Button_Operator);
            // 
            // Button_3
            // 
            this.Button_3.Location = new System.Drawing.Point(118, 210);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(50, 50);
            this.Button_3.TabIndex = 13;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = true;
            this.Button_3.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_2
            // 
            this.Button_2.Location = new System.Drawing.Point(60, 210);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(50, 50);
            this.Button_2.TabIndex = 14;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = true;
            this.Button_2.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_1
            // 
            this.Button_1.Location = new System.Drawing.Point(5, 210);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(50, 50);
            this.Button_1.TabIndex = 15;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_Point
            // 
            this.Button_Point.Location = new System.Drawing.Point(5, 266);
            this.Button_Point.Name = "Button_Point";
            this.Button_Point.Size = new System.Drawing.Size(50, 50);
            this.Button_Point.TabIndex = 16;
            this.Button_Point.Text = ".";
            this.Button_Point.UseVisualStyleBackColor = true;
            this.Button_Point.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_0
            // 
            this.Button_0.Location = new System.Drawing.Point(61, 266);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(50, 50);
            this.Button_0.TabIndex = 17;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = true;
            this.Button_0.Click += new System.EventHandler(this.Button_Number);
            // 
            // Button_Equals
            // 
            this.Button_Equals.Location = new System.Drawing.Point(118, 266);
            this.Button_Equals.Name = "Button_Equals";
            this.Button_Equals.Size = new System.Drawing.Size(106, 50);
            this.Button_Equals.TabIndex = 18;
            this.Button_Equals.Text = "=";
            this.Button_Equals.UseVisualStyleBackColor = true;
            // 
            // Textbox_Debug
            // 
            this.Textbox_Debug.Location = new System.Drawing.Point(5, 322);
            this.Textbox_Debug.Name = "Textbox_Debug";
            this.Textbox_Debug.Size = new System.Drawing.Size(219, 23);
            this.Textbox_Debug.TabIndex = 19;
            this.Textbox_Debug.Text = "Debug";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 391);
            this.Controls.Add(this.Textbox_Debug);
            this.Controls.Add(this.Button_Equals);
            this.Controls.Add(this.Button_0);
            this.Controls.Add(this.Button_Point);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.Button_3);
            this.Controls.Add(this.Button_Plus);
            this.Controls.Add(this.Button_Minus);
            this.Controls.Add(this.Button_6);
            this.Controls.Add(this.Button_5);
            this.Controls.Add(this.Button_4);
            this.Controls.Add(this.Button_7);
            this.Controls.Add(this.Button_8);
            this.Controls.Add(this.Button_9);
            this.Controls.Add(this.Button_Multiply);
            this.Controls.Add(this.Button_Divide);
            this.Controls.Add(this.Button_Del);
            this.Controls.Add(this.Button_AC);
            this.Controls.Add(this.Textbox_Screen);
            this.Name = "Calculator";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Textbox_Screen;
        private Button Button_AC;
        private Button Button_Del;
        private Button Button_Divide;
        private Button Button_Multiply;
        private Button Button_9;
        private Button Button_8;
        private Button Button_7;
        private Button Button_4;
        private Button Button_5;
        private Button Button_6;
        private Button Button_Minus;
        private Button Button_Plus;
        private Button Button_3;
        private Button Button_2;
        private Button Button_1;
        private Button Button_Point;
        private Button Button_0;
        private Button Button_Equals;
        private TextBox Textbox_Debug;
    }
}