using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator_Console_Application;
using System.Text.RegularExpressions;

namespace Calculator_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ShowEvaluation = new System.Windows.Forms.RichTextBox();
            this.ButtonValue1 = new System.Windows.Forms.Button();
            this.ButtonValue2 = new System.Windows.Forms.Button();
            this.ButtonValue3 = new System.Windows.Forms.Button();
            this.ButtonValueDivide = new System.Windows.Forms.Button();
            this.ButtonValue4 = new System.Windows.Forms.Button();
            this.ButtonValue5 = new System.Windows.Forms.Button();
            this.ButtonValue6 = new System.Windows.Forms.Button();
            this.ButtonValue7 = new System.Windows.Forms.Button();
            this.ButtonValue8 = new System.Windows.Forms.Button();
            this.ButtonValue9 = new System.Windows.Forms.Button();
            this.ButtonValue0 = new System.Windows.Forms.Button();
            this.ButtonValueComma = new System.Windows.Forms.Button();
            this.ButtonValueEquals = new System.Windows.Forms.Button();
            this.ButtonValueMultiply = new System.Windows.Forms.Button();
            this.ButtonValueSubtract = new System.Windows.Forms.Button();
            this.ButtonValueAdd = new System.Windows.Forms.Button();
            this.ButtonValueDeletePrevious = new System.Windows.Forms.Button();
            this.ButtonValueDeleteAll = new System.Windows.Forms.Button();
            this.PlaceHolderLabel = new System.Windows.Forms.Label();
            this.ButtonValueRandom = new System.Windows.Forms.Button();
            this.ButtonValueParanthesisStart = new System.Windows.Forms.Button();
            this.ButtonValueParanthesisEnd = new System.Windows.Forms.Button();
            this.ButtonValueSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowEvaluation
            // 
            this.ShowEvaluation.Location = new System.Drawing.Point(19, 38);
            this.ShowEvaluation.Name = "ShowEvaluation";
            this.ShowEvaluation.Size = new System.Drawing.Size(316, 79);
            this.ShowEvaluation.TabIndex = 0;
            this.ShowEvaluation.Text = "";
            // 
            // ButtonValue1
            // 
            this.ButtonValue1.Location = new System.Drawing.Point(17, 152);
            this.ButtonValue1.Name = "ButtonValue1";
            this.ButtonValue1.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue1.TabIndex = 1;
            this.ButtonValue1.Text = "1";
            this.ButtonValue1.UseVisualStyleBackColor = true;
            this.ButtonValue1.Click += new System.EventHandler(this.ButtonValue1_Click);
            // 
            // ButtonValue2
            // 
            this.ButtonValue2.Location = new System.Drawing.Point(98, 152);
            this.ButtonValue2.Name = "ButtonValue2";
            this.ButtonValue2.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue2.TabIndex = 2;
            this.ButtonValue2.Text = "2";
            this.ButtonValue2.UseVisualStyleBackColor = true;
            this.ButtonValue2.Click += new System.EventHandler(this.ButtonValue2_Click);
            // 
            // ButtonValue3
            // 
            this.ButtonValue3.Location = new System.Drawing.Point(179, 152);
            this.ButtonValue3.Name = "ButtonValue3";
            this.ButtonValue3.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue3.TabIndex = 3;
            this.ButtonValue3.Text = "3";
            this.ButtonValue3.UseVisualStyleBackColor = true;
            this.ButtonValue3.Click += new System.EventHandler(this.ButtonValue3_Click);
            // 
            // ButtonValueDivide
            // 
            this.ButtonValueDivide.Location = new System.Drawing.Point(260, 152);
            this.ButtonValueDivide.Name = "ButtonValueDivide";
            this.ButtonValueDivide.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueDivide.TabIndex = 4;
            this.ButtonValueDivide.Text = "/";
            this.ButtonValueDivide.UseVisualStyleBackColor = true;
            this.ButtonValueDivide.Click += new System.EventHandler(this.ButtonValueDivide_Click);
            // 
            // ButtonValue4
            // 
            this.ButtonValue4.Location = new System.Drawing.Point(17, 181);
            this.ButtonValue4.Name = "ButtonValue4";
            this.ButtonValue4.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue4.TabIndex = 5;
            this.ButtonValue4.Text = "4";
            this.ButtonValue4.UseVisualStyleBackColor = true;
            this.ButtonValue4.Click += new System.EventHandler(this.ButtonValue4_Click);
            // 
            // ButtonValue5
            // 
            this.ButtonValue5.Location = new System.Drawing.Point(98, 181);
            this.ButtonValue5.Name = "ButtonValue5";
            this.ButtonValue5.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue5.TabIndex = 6;
            this.ButtonValue5.Text = "5";
            this.ButtonValue5.UseVisualStyleBackColor = true;
            this.ButtonValue5.Click += new System.EventHandler(this.ButtonValue5_Click);
            // 
            // ButtonValue6
            // 
            this.ButtonValue6.Location = new System.Drawing.Point(179, 181);
            this.ButtonValue6.Name = "ButtonValue6";
            this.ButtonValue6.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue6.TabIndex = 7;
            this.ButtonValue6.Text = "6";
            this.ButtonValue6.UseVisualStyleBackColor = true;
            this.ButtonValue6.Click += new System.EventHandler(this.ButtonValue6_Click);
            // 
            // ButtonValue7
            // 
            this.ButtonValue7.Location = new System.Drawing.Point(17, 211);
            this.ButtonValue7.Name = "ButtonValue7";
            this.ButtonValue7.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue7.TabIndex = 8;
            this.ButtonValue7.Text = "7";
            this.ButtonValue7.UseVisualStyleBackColor = true;
            this.ButtonValue7.Click += new System.EventHandler(this.ButtonValue7_Click);
            // 
            // ButtonValue8
            // 
            this.ButtonValue8.Location = new System.Drawing.Point(99, 211);
            this.ButtonValue8.Name = "ButtonValue8";
            this.ButtonValue8.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue8.TabIndex = 9;
            this.ButtonValue8.Text = "8";
            this.ButtonValue8.UseVisualStyleBackColor = true;
            this.ButtonValue8.Click += new System.EventHandler(this.ButtonValue8_Click);
            // 
            // ButtonValue9
            // 
            this.ButtonValue9.Location = new System.Drawing.Point(181, 211);
            this.ButtonValue9.Name = "ButtonValue9";
            this.ButtonValue9.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue9.TabIndex = 10;
            this.ButtonValue9.Text = "9";
            this.ButtonValue9.UseVisualStyleBackColor = true;
            this.ButtonValue9.Click += new System.EventHandler(this.ButtonValue9_Click);
            // 
            // ButtonValue0
            // 
            this.ButtonValue0.Location = new System.Drawing.Point(17, 241);
            this.ButtonValue0.Name = "ButtonValue0";
            this.ButtonValue0.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue0.TabIndex = 11;
            this.ButtonValue0.Text = "0";
            this.ButtonValue0.UseVisualStyleBackColor = true;
            this.ButtonValue0.Click += new System.EventHandler(this.ButtonValue0_Click);
            // 
            // ButtonValueComma
            // 
            this.ButtonValueComma.Location = new System.Drawing.Point(99, 241);
            this.ButtonValueComma.Name = "ButtonValueComma";
            this.ButtonValueComma.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueComma.TabIndex = 12;
            this.ButtonValueComma.Text = ",";
            this.ButtonValueComma.UseVisualStyleBackColor = true;
            this.ButtonValueComma.Click += new System.EventHandler(this.ButtonValueComma_Click);
            // 
            // ButtonValueEquals
            // 
            this.ButtonValueEquals.Location = new System.Drawing.Point(181, 241);
            this.ButtonValueEquals.Name = "ButtonValueEquals";
            this.ButtonValueEquals.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueEquals.TabIndex = 13;
            this.ButtonValueEquals.Text = "=";
            this.ButtonValueEquals.UseVisualStyleBackColor = true;
            this.ButtonValueEquals.Click += new System.EventHandler(this.ButtonValueEquals_Click);
            // 
            // ButtonValueMultiply
            // 
            this.ButtonValueMultiply.Location = new System.Drawing.Point(260, 182);
            this.ButtonValueMultiply.Name = "ButtonValueMultiply";
            this.ButtonValueMultiply.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueMultiply.TabIndex = 14;
            this.ButtonValueMultiply.Text = "*";
            this.ButtonValueMultiply.UseVisualStyleBackColor = true;
            this.ButtonValueMultiply.Click += new System.EventHandler(this.ButtonValueMultiply_Click);
            // 
            // ButtonValueSubtract
            // 
            this.ButtonValueSubtract.Location = new System.Drawing.Point(260, 211);
            this.ButtonValueSubtract.Name = "ButtonValueSubtract";
            this.ButtonValueSubtract.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueSubtract.TabIndex = 15;
            this.ButtonValueSubtract.Text = "-";
            this.ButtonValueSubtract.UseVisualStyleBackColor = true;
            this.ButtonValueSubtract.Click += new System.EventHandler(this.ButtonValueSubtract_Click);
            // 
            // ButtonValueAdd
            // 
            this.ButtonValueAdd.Location = new System.Drawing.Point(260, 241);
            this.ButtonValueAdd.Name = "ButtonValueAdd";
            this.ButtonValueAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueAdd.TabIndex = 16;
            this.ButtonValueAdd.Text = "+";
            this.ButtonValueAdd.UseVisualStyleBackColor = true;
            this.ButtonValueAdd.Click += new System.EventHandler(this.ButtonValueAdd_Click);
            // 
            // ButtonValueDeletePrevious
            // 
            this.ButtonValueDeletePrevious.Location = new System.Drawing.Point(19, 123);
            this.ButtonValueDeletePrevious.Name = "ButtonValueDeletePrevious";
            this.ButtonValueDeletePrevious.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueDeletePrevious.TabIndex = 17;
            this.ButtonValueDeletePrevious.Text = "<--";
            this.ButtonValueDeletePrevious.UseVisualStyleBackColor = true;
            this.ButtonValueDeletePrevious.Click += new System.EventHandler(this.ButtonValueDeletePrevious_Click);
            // 
            // ButtonValueDeleteAll
            // 
            this.ButtonValueDeleteAll.Location = new System.Drawing.Point(260, 123);
            this.ButtonValueDeleteAll.Name = "ButtonValueDeleteAll";
            this.ButtonValueDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueDeleteAll.TabIndex = 18;
            this.ButtonValueDeleteAll.Text = "Clear";
            this.ButtonValueDeleteAll.UseVisualStyleBackColor = true;
            this.ButtonValueDeleteAll.Click += new System.EventHandler(this.ButtonValueDeleteAll_Click);
            // 
            // PlaceHolderLabel
            // 
            this.PlaceHolderLabel.AutoSize = true;
            this.PlaceHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.PlaceHolderLabel.Location = new System.Drawing.Point(96, 128);
            this.PlaceHolderLabel.Name = "PlaceHolderLabel";
            this.PlaceHolderLabel.Size = new System.Drawing.Size(163, 13);
            this.PlaceHolderLabel.TabIndex = 19;
            this.PlaceHolderLabel.Text = "Place Something here DateTime?";
            // 
            // ButtonValueRandom
            // 
            this.ButtonValueRandom.Location = new System.Drawing.Point(19, 270);
            this.ButtonValueRandom.Name = "ButtonValueRandom";
            this.ButtonValueRandom.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueRandom.TabIndex = 20;
            this.ButtonValueRandom.Text = "Random";
            this.ButtonValueRandom.UseVisualStyleBackColor = true;
            // 
            // ButtonValueParanthesisStart
            // 
            this.ButtonValueParanthesisStart.Location = new System.Drawing.Point(100, 270);
            this.ButtonValueParanthesisStart.Name = "ButtonValueParanthesisStart";
            this.ButtonValueParanthesisStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueParanthesisStart.TabIndex = 21;
            this.ButtonValueParanthesisStart.Text = "(";
            this.ButtonValueParanthesisStart.UseVisualStyleBackColor = true;
            // 
            // ButtonValueParanthesisEnd
            // 
            this.ButtonValueParanthesisEnd.Location = new System.Drawing.Point(179, 270);
            this.ButtonValueParanthesisEnd.Name = "ButtonValueParanthesisEnd";
            this.ButtonValueParanthesisEnd.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueParanthesisEnd.TabIndex = 22;
            this.ButtonValueParanthesisEnd.Text = ")";
            this.ButtonValueParanthesisEnd.UseVisualStyleBackColor = true;
            // 
            // ButtonValueSqrt
            // 
            this.ButtonValueSqrt.Location = new System.Drawing.Point(260, 270);
            this.ButtonValueSqrt.Name = "ButtonValueSqrt";
            this.ButtonValueSqrt.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueSqrt.TabIndex = 23;
            this.ButtonValueSqrt.Text = "Sqrt";
            this.ButtonValueSqrt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 419);
            this.Controls.Add(this.ButtonValueSqrt);
            this.Controls.Add(this.ButtonValueParanthesisEnd);
            this.Controls.Add(this.ButtonValueParanthesisStart);
            this.Controls.Add(this.ButtonValueRandom);
            this.Controls.Add(this.PlaceHolderLabel);
            this.Controls.Add(this.ButtonValueDeleteAll);
            this.Controls.Add(this.ButtonValueDeletePrevious);
            this.Controls.Add(this.ButtonValueAdd);
            this.Controls.Add(this.ButtonValueSubtract);
            this.Controls.Add(this.ButtonValueMultiply);
            this.Controls.Add(this.ButtonValueEquals);
            this.Controls.Add(this.ButtonValueComma);
            this.Controls.Add(this.ButtonValue0);
            this.Controls.Add(this.ButtonValue9);
            this.Controls.Add(this.ButtonValue8);
            this.Controls.Add(this.ButtonValue7);
            this.Controls.Add(this.ButtonValue6);
            this.Controls.Add(this.ButtonValue5);
            this.Controls.Add(this.ButtonValue4);
            this.Controls.Add(this.ButtonValueDivide);
            this.Controls.Add(this.ButtonValue3);
            this.Controls.Add(this.ButtonValue2);
            this.Controls.Add(this.ButtonValue1);
            this.Controls.Add(this.ShowEvaluation);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Evaluate(string equation)
        {
            
            // characters to seperate 
            string[] operatorseperator = {"+", "-", "*", "/", "sqrt", "random"};

            string[] operators = Regex.Split(equation, "[0-9]");

            string[] numerics = equation.Split(operatorseperator, StringSplitOptions.None);


        }

        private void ButtonValue1_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("1");
        }

        private void ButtonValue2_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("2");
        }

        private void ButtonValue3_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("3");
        }

        private void ButtonValue4_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("4");
        }

        private void ButtonValue5_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("5");
        }

        private void ButtonValue6_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("6");
        }

        private void ButtonValue7_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("7");
        }

        private void ButtonValue8_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("8");
        }

        private void ButtonValue9_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("9");
        }

        private void ButtonValue0_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("0");
        }

        private void ButtonValueComma_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText(".");
        }

        private void ButtonValueEquals_Click(object sender, EventArgs e)
        {
            Evaluate(ShowEvaluation.Text);
        }

        private void ButtonValueDivide_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("/");
        }

        private void ButtonValueMultiply_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("*");
        }

        private void ButtonValueSubtract_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("-");
        }

        private void ButtonValueAdd_Click(object sender, EventArgs e)
        {
            ShowEvaluation.AppendText("+");
        }

        private void ButtonValueDeleteAll_Click(object sender, EventArgs e)
        {
            ShowEvaluation.Clear();
        }

        private void ButtonValueDeletePrevious_Click(object sender, EventArgs e)
        {
            ShowEvaluation.Undo();
        }
    }
}
