namespace TransferMobileAPP
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
            this.kgBox = new System.Windows.Forms.TextBox();
            this.poundsBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.actualCalculation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kgBox
            // 
            this.kgBox.Location = new System.Drawing.Point(256, 141);
            this.kgBox.Name = "kgBox";
            this.kgBox.Size = new System.Drawing.Size(239, 23);
            this.kgBox.TabIndex = 0;
            this.kgBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // poundsBox
            // 
            this.poundsBox.Location = new System.Drawing.Point(256, 209);
            this.poundsBox.Name = "poundsBox";
            this.poundsBox.Size = new System.Drawing.Size(239, 23);
            this.poundsBox.TabIndex = 1;
            this.poundsBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter KG: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Pounds: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(325, 268);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 46);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "CALCULATE";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // actualCalculation
            // 
            this.actualCalculation.AutoSize = true;
            this.actualCalculation.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actualCalculation.Location = new System.Drawing.Point(325, 348);
            this.actualCalculation.Name = "actualCalculation";
            this.actualCalculation.Size = new System.Drawing.Size(94, 40);
            this.actualCalculation.TabIndex = 5;
            this.actualCalculation.Text = "label3";
            this.actualCalculation.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 594);
            this.Controls.Add(this.actualCalculation);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poundsBox);
            this.Controls.Add(this.kgBox);
            this.Name = "Form1";
            this.Text = "DosageCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kgBox;
        private TextBox poundsBox;
        private Label label1;
        private Label label2;
        private Button CalculateButton;
        private Label actualCalculation;
    }
}