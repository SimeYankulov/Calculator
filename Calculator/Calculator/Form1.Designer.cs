namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Seven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.ClearEverything = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.buttonMP = new System.Windows.Forms.Button();
            this.buttonMM = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.MemoryStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(12, 157);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(54, 50);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEight.Location = new System.Drawing.Point(72, 157);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(53, 50);
            this.buttonEight.TabIndex = 0;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNine.Location = new System.Drawing.Point(131, 157);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(60, 50);
            this.buttonNine.TabIndex = 0;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Gray;
            this.buttonDivide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.Location = new System.Drawing.Point(197, 157);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(54, 50);
            this.buttonDivide.TabIndex = 0;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // ClearEverything
            // 
            this.ClearEverything.BackColor = System.Drawing.Color.OrangeRed;
            this.ClearEverything.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearEverything.Location = new System.Drawing.Point(131, 101);
            this.ClearEverything.Name = "ClearEverything";
            this.ClearEverything.Size = new System.Drawing.Size(60, 50);
            this.ClearEverything.TabIndex = 0;
            this.ClearEverything.Text = "CE";
            this.ClearEverything.UseVisualStyleBackColor = false;
            this.ClearEverything.Click += new System.EventHandler(this.ClearEverything_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(72, 101);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(53, 50);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.Gray;
            this.buttonProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProduct.Location = new System.Drawing.Point(197, 213);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(54, 50);
            this.buttonProduct.TabIndex = 0;
            this.buttonProduct.Text = "x";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSix.Location = new System.Drawing.Point(131, 213);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(60, 50);
            this.buttonSix.TabIndex = 0;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFive.Location = new System.Drawing.Point(72, 213);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(53, 50);
            this.buttonFive.TabIndex = 0;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFour.Location = new System.Drawing.Point(12, 213);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(54, 50);
            this.buttonFour.TabIndex = 0;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTwo.Location = new System.Drawing.Point(72, 269);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(53, 50);
            this.buttonTwo.TabIndex = 0;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Gray;
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(197, 269);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(54, 50);
            this.buttonMinus.TabIndex = 0;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonThree.Location = new System.Drawing.Point(131, 269);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(60, 50);
            this.buttonThree.TabIndex = 0;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOne.Location = new System.Drawing.Point(12, 269);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(54, 50);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Gray;
            this.buttonEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEqual.Location = new System.Drawing.Point(134, 325);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(57, 50);
            this.buttonEqual.TabIndex = 0;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.Gray;
            this.buttonSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSum.Location = new System.Drawing.Point(197, 325);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(54, 50);
            this.buttonSum.TabIndex = 0;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.Location = new System.Drawing.Point(12, 325);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(54, 50);
            this.button18.TabIndex = 0;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZero.Location = new System.Drawing.Point(72, 325);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(53, 50);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.button20_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(239, 27);
            this.Display.TabIndex = 1;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMP
            // 
            this.buttonMP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMP.Location = new System.Drawing.Point(12, 45);
            this.buttonMP.Name = "buttonMP";
            this.buttonMP.Size = new System.Drawing.Size(54, 50);
            this.buttonMP.TabIndex = 0;
            this.buttonMP.Text = "M+";
            this.buttonMP.UseVisualStyleBackColor = true;
            this.buttonMP.Click += new System.EventHandler(this.buttonMP_Click);
            // 
            // buttonMM
            // 
            this.buttonMM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMM.Location = new System.Drawing.Point(72, 45);
            this.buttonMM.Name = "buttonMM";
            this.buttonMM.Size = new System.Drawing.Size(53, 50);
            this.buttonMM.TabIndex = 0;
            this.buttonMM.Text = "M-";
            this.buttonMM.UseVisualStyleBackColor = true;
            this.buttonMM.Click += new System.EventHandler(this.buttonMM_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Enabled = false;
            this.buttonMR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMR.Location = new System.Drawing.Point(131, 45);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(60, 50);
            this.buttonMR.TabIndex = 0;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Enabled = false;
            this.buttonMC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMC.Location = new System.Drawing.Point(197, 45);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(54, 50);
            this.buttonMC.TabIndex = 0;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.BackColor = System.Drawing.Color.Gray;
            this.buttonSQRT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSQRT.Location = new System.Drawing.Point(197, 101);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(54, 50);
            this.buttonSQRT.TabIndex = 0;
            this.buttonSQRT.Text = "√ ";
            this.buttonSQRT.UseVisualStyleBackColor = false;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonSQRT_Click);
            // 
            // MemoryStore
            // 
            this.MemoryStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryStore.Location = new System.Drawing.Point(12, 101);
            this.MemoryStore.Name = "MemoryStore";
            this.MemoryStore.Size = new System.Drawing.Size(54, 50);
            this.MemoryStore.TabIndex = 0;
            this.MemoryStore.Text = "MS";
            this.MemoryStore.UseVisualStyleBackColor = true;
            this.MemoryStore.Click += new System.EventHandler(this.MemoryStore_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 386);
            this.Controls.Add(this.MemoryStore);
            this.Controls.Add(this.buttonSQRT);
            this.Controls.Add(this.buttonMC);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonMM);
            this.Controls.Add(this.buttonMP);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.ClearEverything);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.Seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button ClearEverything;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button buttonMP;
        private System.Windows.Forms.Button buttonMM;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Button MemoryStore;
    }
}

