namespace CryptoChecker
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
            tbBinance = new TextBox();
            tbBybit = new TextBox();
            tbKucoin = new TextBox();
            tbBitget = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // tbBinance
            // 
            tbBinance.Location = new Point(148, 50);
            tbBinance.Name = "tbBinance";
            tbBinance.ReadOnly = true;
            tbBinance.Size = new Size(125, 27);
            tbBinance.TabIndex = 0;
            // 
            // tbBybit
            // 
            tbBybit.Location = new Point(148, 83);
            tbBybit.Name = "tbBybit";
            tbBybit.ReadOnly = true;
            tbBybit.Size = new Size(125, 27);
            tbBybit.TabIndex = 1;
            // 
            // tbKucoin
            // 
            tbKucoin.Location = new Point(148, 116);
            tbKucoin.Name = "tbKucoin";
            tbKucoin.ReadOnly = true;
            tbKucoin.Size = new Size(125, 27);
            tbKucoin.TabIndex = 2;
            // 
            // tbBitget
            // 
            tbBitget.Location = new Point(148, 149);
            tbBitget.Name = "tbBitget";
            tbBitget.ReadOnly = true;
            tbBitget.Size = new Size(125, 27);
            tbBitget.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(83, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Binance";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(83, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "Bybit";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(83, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 27);
            textBox3.TabIndex = 6;
            textBox3.Text = "Kucoin";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(83, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(59, 27);
            textBox4.TabIndex = 7;
            textBox4.Text = "Bitget";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(83, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 261);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbBitget);
            Controls.Add(tbKucoin);
            Controls.Add(tbBybit);
            Controls.Add(tbBinance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBinance;
        private TextBox tbBybit;
        private TextBox tbKucoin;
        private TextBox tbBitget;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
    }
}
