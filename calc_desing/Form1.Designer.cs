using System;
using System.Windows.Forms;

namespace DesignCalc
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.FirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.LabelFirstNumber = new System.Windows.Forms.Label();
            this.btn_math = new System.Windows.Forms.Button();
            this.OperationComboBox = new System.Windows.Forms.ComboBox();
            this.LabelMathOperator = new System.Windows.Forms.Label();
            this.LabelSecondNumber = new System.Windows.Forms.Label();
            this.SecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumberTextBox
            // 
            this.FirstNumberTextBox.AllowDrop = true;
            resources.ApplyResources(this.FirstNumberTextBox, "FirstNumberTextBox");
            this.FirstNumberTextBox.Name = "FirstNumberTextBox";
            // 
            // LabelFirstNumber
            // 
            this.LabelFirstNumber.BackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.LabelFirstNumber, "LabelFirstNumber");
            this.LabelFirstNumber.Name = "LabelFirstNumber";
            // 
            // btn_math
            // 
            resources.ApplyResources(this.btn_math, "btn_math");
            this.btn_math.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_math.Name = "btn_math";
            this.btn_math.UseVisualStyleBackColor = true;
            this.btn_math.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OperationComboBox
            // 
            this.OperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.OperationComboBox, "OperationComboBox");
            this.OperationComboBox.FormattingEnabled = true;
            this.OperationComboBox.Items.AddRange(new object[] {
            resources.GetString("OperationComboBox.Items"),
            resources.GetString("OperationComboBox.Items1"),
            resources.GetString("OperationComboBox.Items2"),
            resources.GetString("OperationComboBox.Items3")});
            this.OperationComboBox.Name = "OperationComboBox";
            // 
            // LabelMathOperator
            // 
            this.LabelMathOperator.BackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.LabelMathOperator, "LabelMathOperator");
            this.LabelMathOperator.Name = "LabelMathOperator";
            // 
            // LabelSecondNumber
            // 
            this.LabelSecondNumber.BackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.LabelSecondNumber, "LabelSecondNumber");
            this.LabelSecondNumber.Name = "LabelSecondNumber";
            // 
            // SecondNumberTextBox
            // 
            this.SecondNumberTextBox.AllowDrop = true;
            resources.ApplyResources(this.SecondNumberTextBox, "SecondNumberTextBox");
            this.SecondNumberTextBox.Name = "SecondNumberTextBox";
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.SlateBlue;
            resources.ApplyResources(this.ResultLabel, "ResultLabel");
            this.ResultLabel.Name = "ResultLabel";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculatorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.LabelSecondNumber);
            this.Controls.Add(this.SecondNumberTextBox);
            this.Controls.Add(this.LabelMathOperator);
            this.Controls.Add(this.OperationComboBox);
            this.Controls.Add(this.btn_math);
            this.Controls.Add(this.LabelFirstNumber);
            this.Controls.Add(this.FirstNumberTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CalculatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumberTextBox;
        private System.Windows.Forms.Label LabelFirstNumber;
        private System.Windows.Forms.Button btn_math;
        private System.Windows.Forms.Label LabelMathOperator;
        private System.Windows.Forms.Label LabelSecondNumber;
        private System.Windows.Forms.TextBox SecondNumberTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ComboBox OperationComboBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

