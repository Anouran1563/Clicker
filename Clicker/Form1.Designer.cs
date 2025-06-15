namespace Clicker
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
            btnAdd = new Button();
            label1 = new Label();
            btnSell = new Button();
            label2 = new Label();
            lblCount = new Label();
            lblCash = new Label();
            btnShop = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(309, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 58);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "charge";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnChg_ClickEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 278);
            label1.Name = "label1";
            label1.Size = new Size(181, 17);
            label1.TabIndex = 1;
            label1.Text = "Click Charge to start charging";
            // 
            // btnSell
            // 
            btnSell.Location = new Point(632, 145);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(156, 58);
            btnSell.TabIndex = 2;
            btnSell.Text = "sell";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSl_ClickEvent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(632, 206);
            label2.Name = "label2";
            label2.Size = new Size(151, 17);
            label2.TabIndex = 3;
            label2.Text = "Click sell to sell your fuel";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(12, 51);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(24, 30);
            lblCount.TabIndex = 4;
            lblCount.Text = "0";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCash.Location = new Point(12, 98);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(24, 30);
            lblCash.TabIndex = 5;
            lblCash.Text = "0";
            // 
            // btnShop
            // 
            btnShop.Location = new Point(12, 257);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(156, 58);
            btnShop.TabIndex = 6;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_ClickEvent;
            // 
            // button1
            // 
            button1.Location = new Point(12, 145);
            button1.Name = "button1";
            button1.Size = new Size(156, 58);
            button1.TabIndex = 6;
            button1.Text = "Statistics";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnShop_ClickEvent;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(497, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnShop);
            Controls.Add(lblCash);
            Controls.Add(lblCount);
            Controls.Add(label2);
            Controls.Add(btnSell);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Button btnSell;
        private Label label2;
        private Label lblCount;
        private Label lblCash;
        private Button btnShop;
        private Button button1;
        private TextBox textBox1;
    }
}
