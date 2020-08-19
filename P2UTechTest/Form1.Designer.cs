namespace P2UTechTest
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
            this.inputCurrencyCB = new System.Windows.Forms.ComboBox();
            this.TitleL = new System.Windows.Forms.Label();
            this.iWouldLikeL = new System.Windows.Forms.Label();
            this.inputAmountTB = new System.Windows.Forms.TextBox();
            this.intoL = new System.Windows.Forms.Label();
            this.outputCurrencyCB = new System.Windows.Forms.ComboBox();
            this.resultL = new System.Windows.Forms.Label();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrencyL1 = new System.Windows.Forms.Label();
            this.currencyL2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputCurrencyCB
            // 
            this.inputCurrencyCB.FormattingEnabled = true;
            this.inputCurrencyCB.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "AUD",
            "EUR"});
            this.inputCurrencyCB.Location = new System.Drawing.Point(17, 61);
            this.inputCurrencyCB.Name = "inputCurrencyCB";
            this.inputCurrencyCB.Size = new System.Drawing.Size(67, 21);
            this.inputCurrencyCB.TabIndex = 0;
            this.inputCurrencyCB.Text = "GBP";
            this.inputCurrencyCB.SelectedIndexChanged += new System.EventHandler(this.inputCurrencyCB_SelectedIndexChanged);
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.Location = new System.Drawing.Point(12, 9);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(178, 25);
            this.TitleL.TabIndex = 1;
            this.TitleL.Text = "Currency converter\r\n";
            // 
            // iWouldLikeL
            // 
            this.iWouldLikeL.AutoSize = true;
            this.iWouldLikeL.Location = new System.Drawing.Point(14, 45);
            this.iWouldLikeL.Name = "iWouldLikeL";
            this.iWouldLikeL.Size = new System.Drawing.Size(114, 13);
            this.iWouldLikeL.TabIndex = 2;
            this.iWouldLikeL.Text = "I would like to convert:\r\n";
            // 
            // inputAmountTB
            // 
            this.inputAmountTB.Location = new System.Drawing.Point(103, 62);
            this.inputAmountTB.Name = "inputAmountTB";
            this.inputAmountTB.Size = new System.Drawing.Size(87, 20);
            this.inputAmountTB.TabIndex = 3;
            this.inputAmountTB.Text = "57";
            this.inputAmountTB.TextChanged += new System.EventHandler(this.inputAmountTB_TextChanged);
            // 
            // intoL
            // 
            this.intoL.AutoSize = true;
            this.intoL.Location = new System.Drawing.Point(14, 85);
            this.intoL.Name = "intoL";
            this.intoL.Size = new System.Drawing.Size(28, 13);
            this.intoL.TabIndex = 5;
            this.intoL.Text = "Into:";
            // 
            // outputCurrencyCB
            // 
            this.outputCurrencyCB.FormattingEnabled = true;
            this.outputCurrencyCB.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "AUD",
            "EUR"});
            this.outputCurrencyCB.Location = new System.Drawing.Point(17, 101);
            this.outputCurrencyCB.Name = "outputCurrencyCB";
            this.outputCurrencyCB.Size = new System.Drawing.Size(67, 21);
            this.outputCurrencyCB.TabIndex = 4;
            this.outputCurrencyCB.Text = "AUD";
            // 
            // resultL
            // 
            this.resultL.AutoSize = true;
            this.resultL.Location = new System.Drawing.Point(14, 130);
            this.resultL.Name = "resultL";
            this.resultL.Size = new System.Drawing.Size(40, 13);
            this.resultL.TabIndex = 6;
            this.resultL.Text = "Result:";
            // 
            // resultTB
            // 
            this.resultTB.Location = new System.Drawing.Point(27, 146);
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.Size = new System.Drawing.Size(163, 20);
            this.resultTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convert!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyL1
            // 
            this.CurrencyL1.AutoSize = true;
            this.CurrencyL1.Location = new System.Drawing.Point(90, 64);
            this.CurrencyL1.Name = "CurrencyL1";
            this.CurrencyL1.Size = new System.Drawing.Size(13, 13);
            this.CurrencyL1.TabIndex = 9;
            this.CurrencyL1.Text = "£";
            // 
            // currencyL2
            // 
            this.currencyL2.AutoSize = true;
            this.currencyL2.Location = new System.Drawing.Point(14, 149);
            this.currencyL2.Name = "currencyL2";
            this.currencyL2.Size = new System.Drawing.Size(13, 13);
            this.currencyL2.TabIndex = 10;
            this.currencyL2.Text = "£";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 184);
            this.Controls.Add(this.currencyL2);
            this.Controls.Add(this.CurrencyL1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.resultL);
            this.Controls.Add(this.intoL);
            this.Controls.Add(this.outputCurrencyCB);
            this.Controls.Add(this.inputAmountTB);
            this.Controls.Add(this.iWouldLikeL);
            this.Controls.Add(this.TitleL);
            this.Controls.Add(this.inputCurrencyCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputCurrencyCB;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.Label iWouldLikeL;
        private System.Windows.Forms.TextBox inputAmountTB;
        private System.Windows.Forms.Label intoL;
        private System.Windows.Forms.ComboBox outputCurrencyCB;
        private System.Windows.Forms.Label resultL;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CurrencyL1;
        private System.Windows.Forms.Label currencyL2;
    }
}

