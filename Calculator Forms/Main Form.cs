using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Will only display the AdvancedCalculator 
            AdvancedCalculator calc = new AdvancedCalculator();
            VersionLabel.Text = $"Current Version: {calc.FindCurrentVersion()}";
        }

        #region Init of Components
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShowEvaluationBox = new System.Windows.Forms.RichTextBox();
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
            this.ButtonPower = new System.Windows.Forms.Button();
            this.ButtonValueEquals = new System.Windows.Forms.Button();
            this.ButtonValueMultiply = new System.Windows.Forms.Button();
            this.ButtonValueSubtract = new System.Windows.Forms.Button();
            this.ButtonValueAdd = new System.Windows.Forms.Button();
            this.ButtonValueDeletePrevious = new System.Windows.Forms.Button();
            this.ButtonValueDeleteAll = new System.Windows.Forms.Button();
            this.ButtonValueRandom = new System.Windows.Forms.Button();
            this.ButtonValueSqrt = new System.Windows.Forms.Button();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowEvaluationBox
            // 
            this.ShowEvaluationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowEvaluationBox.Location = new System.Drawing.Point(12, 12);
            this.ShowEvaluationBox.Name = "ShowEvaluationBox";
            this.ShowEvaluationBox.ReadOnly = true;
            this.ShowEvaluationBox.Size = new System.Drawing.Size(316, 79);
            this.ShowEvaluationBox.TabIndex = 0;
            this.ShowEvaluationBox.Text = "";
            this.ShowEvaluationBox.TextChanged += new System.EventHandler(this.ShowEvaluationBox_TextChanged);
            // 
            // ButtonValue1
            // 
            this.ButtonValue1.Location = new System.Drawing.Point(12, 126);
            this.ButtonValue1.Name = "ButtonValue1";
            this.ButtonValue1.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue1.TabIndex = 1;
            this.ButtonValue1.Text = "1";
            this.ButtonValue1.UseVisualStyleBackColor = true;
            this.ButtonValue1.Click += new System.EventHandler(this.ButtonValue1_Click);
            // 
            // ButtonValue2
            // 
            this.ButtonValue2.Location = new System.Drawing.Point(93, 126);
            this.ButtonValue2.Name = "ButtonValue2";
            this.ButtonValue2.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue2.TabIndex = 2;
            this.ButtonValue2.Text = "2";
            this.ButtonValue2.UseVisualStyleBackColor = true;
            this.ButtonValue2.Click += new System.EventHandler(this.ButtonValue2_Click);
            // 
            // ButtonValue3
            // 
            this.ButtonValue3.Location = new System.Drawing.Point(174, 126);
            this.ButtonValue3.Name = "ButtonValue3";
            this.ButtonValue3.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue3.TabIndex = 3;
            this.ButtonValue3.Text = "3";
            this.ButtonValue3.UseVisualStyleBackColor = true;
            this.ButtonValue3.Click += new System.EventHandler(this.ButtonValue3_Click);
            // 
            // ButtonValueDivide
            // 
            this.ButtonValueDivide.Location = new System.Drawing.Point(255, 126);
            this.ButtonValueDivide.Name = "ButtonValueDivide";
            this.ButtonValueDivide.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueDivide.TabIndex = 4;
            this.ButtonValueDivide.Text = "/";
            this.ButtonValueDivide.UseVisualStyleBackColor = true;
            this.ButtonValueDivide.Click += new System.EventHandler(this.ButtonValueDivide_Click);
            // 
            // ButtonValue4
            // 
            this.ButtonValue4.Location = new System.Drawing.Point(12, 155);
            this.ButtonValue4.Name = "ButtonValue4";
            this.ButtonValue4.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue4.TabIndex = 5;
            this.ButtonValue4.Text = "4";
            this.ButtonValue4.UseVisualStyleBackColor = true;
            this.ButtonValue4.Click += new System.EventHandler(this.ButtonValue4_Click);
            // 
            // ButtonValue5
            // 
            this.ButtonValue5.Location = new System.Drawing.Point(93, 155);
            this.ButtonValue5.Name = "ButtonValue5";
            this.ButtonValue5.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue5.TabIndex = 6;
            this.ButtonValue5.Text = "5";
            this.ButtonValue5.UseVisualStyleBackColor = true;
            this.ButtonValue5.Click += new System.EventHandler(this.ButtonValue5_Click);
            // 
            // ButtonValue6
            // 
            this.ButtonValue6.Location = new System.Drawing.Point(174, 155);
            this.ButtonValue6.Name = "ButtonValue6";
            this.ButtonValue6.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue6.TabIndex = 7;
            this.ButtonValue6.Text = "6";
            this.ButtonValue6.UseVisualStyleBackColor = true;
            this.ButtonValue6.Click += new System.EventHandler(this.ButtonValue6_Click);
            // 
            // ButtonValue7
            // 
            this.ButtonValue7.Location = new System.Drawing.Point(12, 184);
            this.ButtonValue7.Name = "ButtonValue7";
            this.ButtonValue7.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue7.TabIndex = 8;
            this.ButtonValue7.Text = "7";
            this.ButtonValue7.UseVisualStyleBackColor = true;
            this.ButtonValue7.Click += new System.EventHandler(this.ButtonValue7_Click);
            // 
            // ButtonValue8
            // 
            this.ButtonValue8.Location = new System.Drawing.Point(93, 184);
            this.ButtonValue8.Name = "ButtonValue8";
            this.ButtonValue8.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue8.TabIndex = 9;
            this.ButtonValue8.Text = "8";
            this.ButtonValue8.UseVisualStyleBackColor = true;
            this.ButtonValue8.Click += new System.EventHandler(this.ButtonValue8_Click);
            // 
            // ButtonValue9
            // 
            this.ButtonValue9.Location = new System.Drawing.Point(174, 184);
            this.ButtonValue9.Name = "ButtonValue9";
            this.ButtonValue9.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue9.TabIndex = 10;
            this.ButtonValue9.Text = "9";
            this.ButtonValue9.UseVisualStyleBackColor = true;
            this.ButtonValue9.Click += new System.EventHandler(this.ButtonValue9_Click);
            // 
            // ButtonValue0
            // 
            this.ButtonValue0.Location = new System.Drawing.Point(12, 215);
            this.ButtonValue0.Name = "ButtonValue0";
            this.ButtonValue0.Size = new System.Drawing.Size(75, 23);
            this.ButtonValue0.TabIndex = 11;
            this.ButtonValue0.Text = "0";
            this.ButtonValue0.UseVisualStyleBackColor = true;
            this.ButtonValue0.Click += new System.EventHandler(this.ButtonValue0_Click);
            // 
            // ButtonPower
            // 
            this.ButtonPower.Location = new System.Drawing.Point(93, 97);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(75, 23);
            this.ButtonPower.TabIndex = 12;
            this.ButtonPower.Text = "x^y";
            this.ButtonPower.UseVisualStyleBackColor = true;
            this.ButtonPower.Click += new System.EventHandler(this.ButtonValueComma_Click);
            // 
            // ButtonValueEquals
            // 
            this.ButtonValueEquals.Location = new System.Drawing.Point(174, 215);
            this.ButtonValueEquals.Name = "ButtonValueEquals";
            this.ButtonValueEquals.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueEquals.TabIndex = 13;
            this.ButtonValueEquals.Text = "=";
            this.ButtonValueEquals.UseVisualStyleBackColor = true;
            this.ButtonValueEquals.Click += new System.EventHandler(this.ButtonValueEquals_Click);
            // 
            // ButtonValueMultiply
            // 
            this.ButtonValueMultiply.Location = new System.Drawing.Point(255, 155);
            this.ButtonValueMultiply.Name = "ButtonValueMultiply";
            this.ButtonValueMultiply.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueMultiply.TabIndex = 14;
            this.ButtonValueMultiply.Text = "*";
            this.ButtonValueMultiply.UseVisualStyleBackColor = true;
            this.ButtonValueMultiply.Click += new System.EventHandler(this.ButtonValueMultiply_Click);
            // 
            // ButtonValueSubtract
            // 
            this.ButtonValueSubtract.Location = new System.Drawing.Point(255, 186);
            this.ButtonValueSubtract.Name = "ButtonValueSubtract";
            this.ButtonValueSubtract.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueSubtract.TabIndex = 15;
            this.ButtonValueSubtract.Text = "-";
            this.ButtonValueSubtract.UseVisualStyleBackColor = true;
            this.ButtonValueSubtract.Click += new System.EventHandler(this.ButtonValueSubtract_Click);
            // 
            // ButtonValueAdd
            // 
            this.ButtonValueAdd.Location = new System.Drawing.Point(255, 215);
            this.ButtonValueAdd.Name = "ButtonValueAdd";
            this.ButtonValueAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueAdd.TabIndex = 16;
            this.ButtonValueAdd.Text = "+";
            this.ButtonValueAdd.UseVisualStyleBackColor = true;
            this.ButtonValueAdd.Click += new System.EventHandler(this.ButtonValueAdd_Click);
            // 
            // ButtonValueDeletePrevious
            // 
            this.ButtonValueDeletePrevious.Location = new System.Drawing.Point(12, 97);
            this.ButtonValueDeletePrevious.Name = "ButtonValueDeletePrevious";
            this.ButtonValueDeletePrevious.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueDeletePrevious.TabIndex = 17;
            this.ButtonValueDeletePrevious.Text = "<--";
            this.ButtonValueDeletePrevious.UseVisualStyleBackColor = true;
            this.ButtonValueDeletePrevious.Click += new System.EventHandler(this.ButtonValueDeletePrevious_Click);
            // 
            // ButtonValueDeleteAll
            // 
            this.ButtonValueDeleteAll.Location = new System.Drawing.Point(255, 97);
            this.ButtonValueDeleteAll.Name = "ButtonValueDeleteAll";
            this.ButtonValueDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueDeleteAll.TabIndex = 18;
            this.ButtonValueDeleteAll.Text = "Clear";
            this.ButtonValueDeleteAll.UseVisualStyleBackColor = true;
            this.ButtonValueDeleteAll.Click += new System.EventHandler(this.ButtonValueDeleteAll_Click);
            // 
            // ButtonValueRandom
            // 
            this.ButtonValueRandom.Location = new System.Drawing.Point(93, 215);
            this.ButtonValueRandom.Name = "ButtonValueRandom";
            this.ButtonValueRandom.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueRandom.TabIndex = 20;
            this.ButtonValueRandom.Text = "Random";
            this.ToolTips.SetToolTip(this.ButtonValueRandom, "Syntax: {First Number}random{Second Number}");
            this.ButtonValueRandom.UseVisualStyleBackColor = true;
            this.ButtonValueRandom.Click += new System.EventHandler(this.ButtonValueRandom_Click);
            // 
            // ButtonValueSqrt
            // 
            this.ButtonValueSqrt.Location = new System.Drawing.Point(174, 97);
            this.ButtonValueSqrt.Name = "ButtonValueSqrt";
            this.ButtonValueSqrt.Size = new System.Drawing.Size(75, 23);
            this.ButtonValueSqrt.TabIndex = 23;
            this.ButtonValueSqrt.Text = "Sqrt";
            this.ButtonValueSqrt.UseVisualStyleBackColor = true;
            this.ButtonValueSqrt.Click += new System.EventHandler(this.ButtonValueSqrt_Click);
            // 
            // ToolTips
            // 
            this.ToolTips.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(9, 242);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(106, 13);
            this.VersionLabel.TabIndex = 25;
            this.VersionLabel.Text = "No Version Detected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 265);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ButtonValueSqrt);
            this.Controls.Add(this.ButtonValueRandom);
            this.Controls.Add(this.ButtonValueDeleteAll);
            this.Controls.Add(this.ButtonValueDeletePrevious);
            this.Controls.Add(this.ButtonValueAdd);
            this.Controls.Add(this.ButtonValueSubtract);
            this.Controls.Add(this.ButtonValueMultiply);
            this.Controls.Add(this.ButtonValueEquals);
            this.Controls.Add(this.ButtonPower);
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
            this.Controls.Add(this.ShowEvaluationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // Can be made more generic and set to either calculator and return the length of the string and let Main handle the determination
        static bool DetermineIfTooLong(string equation)
        {
            // characters to seperate with the numerics
            string[] operatorseperator = { "+", "-", "*", "/", "sqrt", "random" };

            // gets all of the numbers in the equation
            string[] numerics = equation.Split(operatorseperator, StringSplitOptions.None);

            if (numerics.Count() <= 2)
            {
                return false;
            }

            return true;
        }

        // Evaluates the equation. As of right now it is only able to take 2 numbers
        private string Evaluate(string equation)
        {

            // characters to seperate with the numerics
            string[] operatorseperator = {"+", "-", "*", "/", "sqrt", "random", "^"};

            // Gets all of the operators in the equation
            string[] operators = Regex.Split(equation, "[0-9]");
            operators = operators.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            // gets all of the numbers in the equation
            string[] numerics = equation.Split(operatorseperator, StringSplitOptions.None);
            numerics = numerics.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            // to prevent a FormatException when an operator is set as the first character, for further functionality add another method for calculating with negative numerals
            if (!equation.StartsWith("-") || !equation.StartsWith("+") || !equation.StartsWith("/") ||
                !equation.StartsWith("*") || !equation.StartsWith("random") || !equation.StartsWith("^"))
            {
                AdvancedCalculator calc = new AdvancedCalculator();

                // Checks whether there are operators present
                if (operators.Length != 0)
                {
                    // Checks whether there are 1 or 2 numbers
                    if (numerics.Length <= 2 && numerics.Length != 0)
                    {
                        // Assigns the numbers needed to calculate 
                        calc.AssignFirstNumber(Convert.ToDouble(numerics[0]));

                        // Checks if there are 2 numbers
                        if (numerics.Length == 2)
                            calc.AssignSecondNumber(Convert.ToDouble(numerics[1]));

                        switch (operators[0])
                        {
                            case "+":
                                return
                                    calc.Addition()
                                        .ToString(CultureInfo.CurrentCulture);
                            case "-":
                                return
                                    calc.Subtract()
                                        .ToString(CultureInfo.CurrentCulture);
                            case "/":
                                return
                                    calc.Divide()
                                        .ToString(CultureInfo.CurrentCulture);
                            case "*":
                                return
                                    calc.Multiply()
                                        .ToString(CultureInfo.CurrentCulture);
                            case "sqrt":
                                return
                                    calc.SquareRoot()
                                        .ToString(CultureInfo.CurrentCulture);
                            case "random":
                                return
                                    calc.Random()
                                        .ToString(CultureInfo.CurrentCulture);
                            case "^":
                                return
                                    calc.Power()
                                        .ToString(CultureInfo.CurrentCulture);

                            default:
                                return "Error in Calculation Please try again.";
                        }
                    }
                    else
                    {
                        return "Error in format";
                    }
                }
            }
            return "Unknown error occured";
        }

        #region Winforms tools
        private void ButtonValue1_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("1");
        }

        private void ButtonValue2_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("2");
        }

        private void ButtonValue3_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("3");
        }

        private void ButtonValue4_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("4");
        }

        private void ButtonValue5_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("5");
        }

        private void ButtonValue6_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("6");
        }

        private void ButtonValue7_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("7");
        }

        private void ButtonValue8_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("8");
        }

        private void ButtonValue9_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("9");
        }

        private void ButtonValue0_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("0");
        }

        private void ButtonValueComma_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("^");
        }

        private void ButtonValueEquals_Click(object sender, EventArgs e)
        {
            var result = Evaluate(ShowEvaluationBox.Text);
            ShowEvaluationBox.Text = result;
        }

        private void ButtonValueDivide_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("/");
        }

        private void ButtonValueMultiply_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("*");
        }

        private void ButtonValueSubtract_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("-");
        }

        private void ButtonValueAdd_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("+");
        }

        private void ButtonValueDeleteAll_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.Clear();
        }

        private void ButtonValueDeletePrevious_Click(object sender, EventArgs e)
        {
            int textlength = ShowEvaluationBox.TextLength;

            if (textlength > 0)
                ShowEvaluationBox.Text = ShowEvaluationBox.Text.Remove(textlength-1, 1);
        }

        private void ButtonValueRandom_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("random");
        }

        private void ButtonValueSqrt_Click(object sender, EventArgs e)
        {
            ShowEvaluationBox.AppendText("sqrt");
        }

        private void ShowEvaluationBox_TextChanged(object sender, EventArgs e)
        {
            bool ifTooLong = DetermineIfTooLong(ShowEvaluationBox.Text);
            if (ifTooLong)
            {
                ShowEvaluationBox.Undo();
                ShowEvaluationBox.ClearUndo();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        #endregion
    }
}
