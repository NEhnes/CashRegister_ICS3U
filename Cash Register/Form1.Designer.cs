namespace Cash_Register
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
            this.daggerText = new System.Windows.Forms.Label();
            this.kukriText = new System.Windows.Forms.Label();
            this.scytheText = new System.Windows.Forms.Label();
            this.daggerInput = new System.Windows.Forms.TextBox();
            this.kukriInput = new System.Windows.Forms.TextBox();
            this.scytheInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalsBox = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeBox = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptBox = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.discountButton = new System.Windows.Forms.Button();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.discountIndicator = new System.Windows.Forms.Label();
            this.printerHole = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.historyPasswordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scytheImage = new System.Windows.Forms.Label();
            this.daggerImage = new System.Windows.Forms.Label();
            this.kukriImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daggerText
            // 
            this.daggerText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daggerText.Location = new System.Drawing.Point(3, 21);
            this.daggerText.Name = "daggerText";
            this.daggerText.Size = new System.Drawing.Size(142, 23);
            this.daggerText.TabIndex = 0;
            this.daggerText.Text = "$ 49.99 - Dagger";
            // 
            // kukriText
            // 
            this.kukriText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kukriText.Location = new System.Drawing.Point(19, 76);
            this.kukriText.Name = "kukriText";
            this.kukriText.Size = new System.Drawing.Size(122, 23);
            this.kukriText.TabIndex = 1;
            this.kukriText.Text = "$79.99 - Kukri";
            // 
            // scytheText
            // 
            this.scytheText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scytheText.Location = new System.Drawing.Point(1, 124);
            this.scytheText.Name = "scytheText";
            this.scytheText.Size = new System.Drawing.Size(138, 23);
            this.scytheText.TabIndex = 2;
            this.scytheText.Text = "$109.99 - Scythe";
            // 
            // daggerInput
            // 
            this.daggerInput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daggerInput.Location = new System.Drawing.Point(131, 24);
            this.daggerInput.Name = "daggerInput";
            this.daggerInput.Size = new System.Drawing.Size(100, 22);
            this.daggerInput.TabIndex = 3;
            // 
            // kukriInput
            // 
            this.kukriInput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kukriInput.Location = new System.Drawing.Point(131, 75);
            this.kukriInput.Name = "kukriInput";
            this.kukriInput.Size = new System.Drawing.Size(100, 22);
            this.kukriInput.TabIndex = 4;
            // 
            // scytheInput
            // 
            this.scytheInput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scytheInput.Location = new System.Drawing.Point(131, 124);
            this.scytheInput.Name = "scytheInput";
            this.scytheInput.Size = new System.Drawing.Size(100, 22);
            this.scytheInput.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(29, 203);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(202, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalsBox
            // 
            this.totalsBox.BackColor = System.Drawing.Color.IndianRed;
            this.totalsBox.Location = new System.Drawing.Point(29, 248);
            this.totalsBox.Name = "totalsBox";
            this.totalsBox.Size = new System.Drawing.Size(202, 73);
            this.totalsBox.TabIndex = 7;
            this.totalsBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(26, 329);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(106, 13);
            this.tenderedText.TabIndex = 8;
            this.tenderedText.Text = "Amount Tendered: ";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(131, 324);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(29, 363);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(103, 31);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Change";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeBox
            // 
            this.changeBox.BackColor = System.Drawing.Color.IndianRed;
            this.changeBox.Location = new System.Drawing.Point(138, 364);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(93, 28);
            this.changeBox.TabIndex = 12;
            this.changeBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(29, 413);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(202, 34);
            this.receiptButton.TabIndex = 13;
            this.receiptButton.Text = "Receipt";
            this.receiptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptBox
            // 
            this.receiptBox.BackColor = System.Drawing.Color.White;
            this.receiptBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBox.Location = new System.Drawing.Point(266, 361);
            this.receiptBox.Name = "receiptBox";
            this.receiptBox.Size = new System.Drawing.Size(196, 20);
            this.receiptBox.TabIndex = 14;
            this.receiptBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(269, 400);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 49);
            this.newOrderButton.TabIndex = 15;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // discountButton
            // 
            this.discountButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountButton.Location = new System.Drawing.Point(32, 168);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(202, 23);
            this.discountButton.TabIndex = 18;
            this.discountButton.Text = "Discount Code?";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // discountBox
            // 
            this.discountBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBox.Location = new System.Drawing.Point(32, 169);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(160, 22);
            this.discountBox.TabIndex = 19;
            this.discountBox.TextChanged += new System.EventHandler(this.discountBox_TextChanged);
            // 
            // discountIndicator
            // 
            this.discountIndicator.BackColor = System.Drawing.Color.Red;
            this.discountIndicator.Location = new System.Drawing.Point(211, 169);
            this.discountIndicator.Name = "discountIndicator";
            this.discountIndicator.Size = new System.Drawing.Size(20, 20);
            this.discountIndicator.TabIndex = 20;
            // 
            // printerHole
            // 
            this.printerHole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.printerHole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printerHole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printerHole.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.printerHole.Location = new System.Drawing.Point(256, 369);
            this.printerHole.Name = "printerHole";
            this.printerHole.Size = new System.Drawing.Size(216, 23);
            this.printerHole.TabIndex = 21;
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(337, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(133, 23);
            this.historyButton.TabIndex = 22;
            this.historyButton.Text = "Order History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // historyPasswordInput
            // 
            this.historyPasswordInput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyPasswordInput.Location = new System.Drawing.Point(344, 13);
            this.historyPasswordInput.Name = "historyPasswordInput";
            this.historyPasswordInput.Size = new System.Drawing.Size(120, 22);
            this.historyPasswordInput.TabIndex = 23;
            this.historyPasswordInput.Text = "INPUT PASSWORD";
            this.historyPasswordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.historyPasswordInput.Visible = false;
            this.historyPasswordInput.TextChanged += new System.EventHandler(this.historyPasswordInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // scytheImage
            // 
            this.scytheImage.BackColor = System.Drawing.Color.Silver;
            this.scytheImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scytheImage.Image = global::Cash_Register.Properties.Resources.scythe;
            this.scytheImage.Location = new System.Drawing.Point(237, 109);
            this.scytheImage.Name = "scytheImage";
            this.scytheImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scytheImage.Size = new System.Drawing.Size(50, 50);
            this.scytheImage.TabIndex = 27;
            // 
            // daggerImage
            // 
            this.daggerImage.BackColor = System.Drawing.Color.Silver;
            this.daggerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daggerImage.Image = global::Cash_Register.Properties.Resources.daggerCashRegister_resized;
            this.daggerImage.Location = new System.Drawing.Point(237, 9);
            this.daggerImage.Name = "daggerImage";
            this.daggerImage.Size = new System.Drawing.Size(50, 50);
            this.daggerImage.TabIndex = 25;
            // 
            // kukriImage
            // 
            this.kukriImage.BackColor = System.Drawing.Color.Silver;
            this.kukriImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kukriImage.Image = global::Cash_Register.Properties.Resources.Kukri_Knives;
            this.kukriImage.Location = new System.Drawing.Point(237, 59);
            this.kukriImage.Name = "kukriImage";
            this.kukriImage.Size = new System.Drawing.Size(50, 50);
            this.kukriImage.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.receiptBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historyPasswordInput);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.totalsBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.scytheInput);
            this.Controls.Add(this.kukriInput);
            this.Controls.Add(this.daggerInput);
            this.Controls.Add(this.printerHole);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.discountIndicator);
            this.Controls.Add(this.daggerText);
            this.Controls.Add(this.kukriText);
            this.Controls.Add(this.scytheText);
            this.Controls.Add(this.daggerImage);
            this.Controls.Add(this.kukriImage);
            this.Controls.Add(this.scytheImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C-SHARP BLADES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daggerText;
        private System.Windows.Forms.Label kukriText;
        private System.Windows.Forms.Label scytheText;
        private System.Windows.Forms.TextBox daggerInput;
        private System.Windows.Forms.TextBox kukriInput;
        private System.Windows.Forms.TextBox scytheInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalsBox;
        private System.Windows.Forms.Label tenderedText;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeBox;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptBox;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.Label discountIndicator;
        private System.Windows.Forms.Label printerHole;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.TextBox historyPasswordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daggerImage;
        private System.Windows.Forms.Label kukriImage;
        private System.Windows.Forms.Label scytheImage;
    }
}

