namespace calculator_win
{
    partial class CalculatorForm
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_clear_current = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_zore = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Show_Op = new System.Windows.Forms.Label();
            this.btn_lt = new System.Windows.Forms.Button();
            this.btn_gt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_seven
            // 
            this.btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seven.Location = new System.Drawing.Point(12, 158);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(56, 50);
            this.btn_seven.TabIndex = 0;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eight.Location = new System.Drawing.Point(74, 158);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(56, 50);
            this.btn_eight.TabIndex = 1;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(198, 158);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(56, 50);
            this.btn_division.TabIndex = 2;
            this.btn_division.Text = "÷";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nine.Location = new System.Drawing.Point(136, 158);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(56, 50);
            this.btn_nine.TabIndex = 3;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_clear_current
            // 
            this.btn_clear_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_current.Location = new System.Drawing.Point(136, 102);
            this.btn_clear_current.Name = "btn_clear_current";
            this.btn_clear_current.Size = new System.Drawing.Size(56, 50);
            this.btn_clear_current.TabIndex = 4;
            this.btn_clear_current.Text = "Del";
            this.btn_clear_current.UseVisualStyleBackColor = true;
            this.btn_clear_current.Click += new System.EventHandler(this.btn_clear_current_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(198, 102);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(56, 50);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_six
            // 
            this.btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_six.Location = new System.Drawing.Point(136, 214);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(56, 50);
            this.btn_six.TabIndex = 8;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mult.Location = new System.Drawing.Point(198, 214);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(56, 50);
            this.btn_mult.TabIndex = 7;
            this.btn_mult.Text = "×";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_five
            // 
            this.btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_five.Location = new System.Drawing.Point(74, 214);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(56, 50);
            this.btn_five.TabIndex = 6;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_four
            // 
            this.btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_four.Location = new System.Drawing.Point(12, 214);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(56, 50);
            this.btn_four.TabIndex = 5;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_three
            // 
            this.btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_three.Location = new System.Drawing.Point(136, 270);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(56, 50);
            this.btn_three.TabIndex = 13;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(198, 270);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(56, 50);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_two
            // 
            this.btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_two.Location = new System.Drawing.Point(74, 270);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(56, 50);
            this.btn_two.TabIndex = 11;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_one
            // 
            this.btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_one.Location = new System.Drawing.Point(13, 270);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(56, 50);
            this.btn_one.TabIndex = 10;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_zore
            // 
            this.btn_zore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zore.Location = new System.Drawing.Point(12, 326);
            this.btn_zore.Name = "btn_zore";
            this.btn_zore.Size = new System.Drawing.Size(56, 50);
            this.btn_zore.TabIndex = 15;
            this.btn_zore.Text = "0";
            this.btn_zore.UseVisualStyleBackColor = true;
            this.btn_zore.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(198, 326);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 50);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_equal.Location = new System.Drawing.Point(136, 326);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(56, 50);
            this.btn_equal.TabIndex = 19;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.Location = new System.Drawing.Point(74, 326);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(56, 50);
            this.btn_dot.TabIndex = 18;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_NumAndDot_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(12, 31);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(249, 35);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_Show_Op
            // 
            this.label_Show_Op.AutoSize = true;
            this.label_Show_Op.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Show_Op.Location = new System.Drawing.Point(13, 13);
            this.label_Show_Op.Name = "label_Show_Op";
            this.label_Show_Op.Size = new System.Drawing.Size(0, 15);
            this.label_Show_Op.TabIndex = 21;
            // 
            // btn_lt
            // 
            this.btn_lt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lt.Location = new System.Drawing.Point(13, 102);
            this.btn_lt.Name = "btn_lt";
            this.btn_lt.Size = new System.Drawing.Size(56, 50);
            this.btn_lt.TabIndex = 22;
            this.btn_lt.Text = "(";
            this.btn_lt.UseVisualStyleBackColor = true;
            // 
            // btn_gt
            // 
            this.btn_gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gt.Location = new System.Drawing.Point(75, 102);
            this.btn_gt.Name = "btn_gt";
            this.btn_gt.Size = new System.Drawing.Size(56, 50);
            this.btn_gt.TabIndex = 23;
            this.btn_gt.Text = ")";
            this.btn_gt.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 399);
            this.Controls.Add(this.btn_gt);
            this.Controls.Add(this.btn_lt);
            this.Controls.Add(this.label_Show_Op);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_zore);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_clear_current);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_lt;
        private System.Windows.Forms.Button btn_gt;


        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_clear_current;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_zore;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Show_Op;
    }

        
    }
