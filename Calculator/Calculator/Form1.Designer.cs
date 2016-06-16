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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.zeroButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.decimalDutton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eigthButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.SquerButton = new System.Windows.Forms.Button();
            this.divadeButton = new System.Windows.Forms.Button();
            this.xButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.addisionButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.currentOperationLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(15, 41);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(215, 26);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(15, 295);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(105, 50);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.Number);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(15, 240);
            this.oneButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(50, 50);
            this.oneButton.TabIndex = 2;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.Number);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(70, 240);
            this.twoButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(50, 50);
            this.twoButton.TabIndex = 3;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.Number);
            // 
            // decimalDutton
            // 
            this.decimalDutton.Location = new System.Drawing.Point(125, 295);
            this.decimalDutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.decimalDutton.Name = "decimalDutton";
            this.decimalDutton.Size = new System.Drawing.Size(50, 50);
            this.decimalDutton.TabIndex = 4;
            this.decimalDutton.Text = ",";
            this.decimalDutton.UseVisualStyleBackColor = true;
            this.decimalDutton.Click += new System.EventHandler(this.Number);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(125, 240);
            this.threeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(50, 50);
            this.threeButton.TabIndex = 5;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.Number);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(15, 185);
            this.fourButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(50, 50);
            this.fourButton.TabIndex = 6;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.Number);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(70, 185);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(50, 50);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.Number);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(125, 185);
            this.sixButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(50, 50);
            this.sixButton.TabIndex = 8;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.Number);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(15, 130);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(50, 50);
            this.sevenButton.TabIndex = 9;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.Number);
            // 
            // eigthButton
            // 
            this.eigthButton.Location = new System.Drawing.Point(70, 130);
            this.eigthButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.eigthButton.Name = "eigthButton";
            this.eigthButton.Size = new System.Drawing.Size(50, 50);
            this.eigthButton.TabIndex = 11;
            this.eigthButton.Text = "8";
            this.eigthButton.UseVisualStyleBackColor = true;
            this.eigthButton.Click += new System.EventHandler(this.Number);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(125, 130);
            this.nineButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(50, 50);
            this.nineButton.TabIndex = 12;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.Number);
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(70, 75);
            this.cButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(50, 50);
            this.cButton.TabIndex = 13;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // SquerButton
            // 
            this.SquerButton.Location = new System.Drawing.Point(125, 75);
            this.SquerButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SquerButton.Name = "SquerButton";
            this.SquerButton.Size = new System.Drawing.Size(50, 50);
            this.SquerButton.TabIndex = 14;
            this.SquerButton.Text = "√";
            this.SquerButton.UseVisualStyleBackColor = true;
            this.SquerButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // divadeButton
            // 
            this.divadeButton.Location = new System.Drawing.Point(180, 75);
            this.divadeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.divadeButton.Name = "divadeButton";
            this.divadeButton.Size = new System.Drawing.Size(50, 50);
            this.divadeButton.TabIndex = 15;
            this.divadeButton.Text = "/";
            this.divadeButton.UseVisualStyleBackColor = true;
            this.divadeButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // xButton
            // 
            this.xButton.Location = new System.Drawing.Point(180, 130);
            this.xButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(50, 50);
            this.xButton.TabIndex = 16;
            this.xButton.Text = "x";
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(180, 185);
            this.subtractionButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(50, 50);
            this.subtractionButton.TabIndex = 17;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // addisionButton
            // 
            this.addisionButton.Location = new System.Drawing.Point(180, 240);
            this.addisionButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addisionButton.Name = "addisionButton";
            this.addisionButton.Size = new System.Drawing.Size(50, 50);
            this.addisionButton.TabIndex = 18;
            this.addisionButton.Text = "+";
            this.addisionButton.UseVisualStyleBackColor = true;
            this.addisionButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(180, 295);
            this.EqualButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(50, 50);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.Equal_Click);
            // 
            // ceButton
            // 
            this.ceButton.Location = new System.Drawing.Point(15, 75);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(50, 50);
            this.ceButton.TabIndex = 20;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // currentOperationLable
            // 
            this.currentOperationLable.AutoSize = true;
            this.currentOperationLable.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.currentOperationLable.Location = new System.Drawing.Point(173, 17);
            this.currentOperationLable.Name = "currentOperationLable";
            this.currentOperationLable.Size = new System.Drawing.Size(0, 20);
            this.currentOperationLable.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 356);
            this.Controls.Add(this.currentOperationLable);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.addisionButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.divadeButton);
            this.Controls.Add(this.SquerButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eigthButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.decimalDutton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.resultTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button decimalDutton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eigthButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button SquerButton;
        private System.Windows.Forms.Button divadeButton;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button addisionButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Label currentOperationLable;
    }
}

