namespace PolymorphismApp
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
            this.fileBox = new System.Windows.Forms.TextBox();
            this.cowVaccBox = new System.Windows.Forms.TextBox();
            this.jCowVaccBox = new System.Windows.Forms.TextBox();
            this.goatMilkPriceBox = new System.Windows.Forms.TextBox();
            this.cowMilkPriceBox = new System.Windows.Forms.TextBox();
            this.fileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goatVaccBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profitButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.objectButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(12, 42);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(141, 20);
            this.fileBox.TabIndex = 0;
            // 
            // cowVaccBox
            // 
            this.cowVaccBox.Location = new System.Drawing.Point(159, 146);
            this.cowVaccBox.Name = "cowVaccBox";
            this.cowVaccBox.Size = new System.Drawing.Size(100, 20);
            this.cowVaccBox.TabIndex = 3;
            this.cowVaccBox.Text = "0";
            // 
            // jCowVaccBox
            // 
            this.jCowVaccBox.Location = new System.Drawing.Point(159, 172);
            this.jCowVaccBox.Name = "jCowVaccBox";
            this.jCowVaccBox.Size = new System.Drawing.Size(100, 20);
            this.jCowVaccBox.TabIndex = 4;
            this.jCowVaccBox.Text = "0";
            // 
            // goatMilkPriceBox
            // 
            this.goatMilkPriceBox.Location = new System.Drawing.Point(159, 120);
            this.goatMilkPriceBox.Name = "goatMilkPriceBox";
            this.goatMilkPriceBox.Size = new System.Drawing.Size(100, 20);
            this.goatMilkPriceBox.TabIndex = 2;
            this.goatMilkPriceBox.Text = "0";
            // 
            // cowMilkPriceBox
            // 
            this.cowMilkPriceBox.Location = new System.Drawing.Point(159, 94);
            this.cowMilkPriceBox.Name = "cowMilkPriceBox";
            this.cowMilkPriceBox.Size = new System.Drawing.Size(100, 20);
            this.cowMilkPriceBox.TabIndex = 1;
            this.cowMilkPriceBox.Text = "0";
            // 
            // fileButton
            // 
            this.fileButton.Location = new System.Drawing.Point(12, 66);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(75, 23);
            this.fileButton.TabIndex = 5;
            this.fileButton.Text = "Open File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter file path";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupValuesToolStripMenuItem,
            this.createObjectsToolStripMenuItem,
            this.calculateProfitToolStripMenuItem,
            this.runToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // setupValuesToolStripMenuItem
            // 
            this.setupValuesToolStripMenuItem.Name = "setupValuesToolStripMenuItem";
            this.setupValuesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.setupValuesToolStripMenuItem.Text = "Setup values";
            this.setupValuesToolStripMenuItem.Click += new System.EventHandler(this.setupValuesToolStripMenuItem_Click);
            // 
            // createObjectsToolStripMenuItem
            // 
            this.createObjectsToolStripMenuItem.Name = "createObjectsToolStripMenuItem";
            this.createObjectsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.createObjectsToolStripMenuItem.Text = "Create objects";
            this.createObjectsToolStripMenuItem.Click += new System.EventHandler(this.createObjectsToolStripMenuItem_Click);
            // 
            // calculateProfitToolStripMenuItem
            // 
            this.calculateProfitToolStripMenuItem.Name = "calculateProfitToolStripMenuItem";
            this.calculateProfitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.calculateProfitToolStripMenuItem.Text = "Calculate profit";
            this.calculateProfitToolStripMenuItem.Click += new System.EventHandler(this.calculateProfitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.runToolStripMenuItem.Text = "Run full query";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cow milk price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Goat milk price:";
            // 
            // goatVaccBox
            // 
            this.goatVaccBox.Location = new System.Drawing.Point(159, 198);
            this.goatVaccBox.Name = "goatVaccBox";
            this.goatVaccBox.Size = new System.Drawing.Size(100, 20);
            this.goatVaccBox.TabIndex = 5;
            this.goatVaccBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cow vaccination cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jersey cow vaccination cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Goat vaccination cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total profit:";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Location = new System.Drawing.Point(175, 280);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(13, 13);
            this.profitLabel.TabIndex = 15;
            this.profitLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "$";
            // 
            // profitButton
            // 
            this.profitButton.Location = new System.Drawing.Point(159, 254);
            this.profitButton.Name = "profitButton";
            this.profitButton.Size = new System.Drawing.Size(100, 23);
            this.profitButton.TabIndex = 17;
            this.profitButton.Text = "Calculate profit";
            this.profitButton.UseVisualStyleBackColor = true;
            this.profitButton.Click += new System.EventHandler(this.runQuery_Click);
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(159, 225);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(100, 23);
            this.priceButton.TabIndex = 18;
            this.priceButton.Text = "Setup prices";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // objectButton
            // 
            this.objectButton.Location = new System.Drawing.Point(159, 42);
            this.objectButton.Name = "objectButton";
            this.objectButton.Size = new System.Drawing.Size(100, 20);
            this.objectButton.TabIndex = 19;
            this.objectButton.Text = "Create objects";
            this.objectButton.UseVisualStyleBackColor = true;
            this.objectButton.Click += new System.EventHandler(this.objectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 299);
            this.Controls.Add(this.objectButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.profitButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goatVaccBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileButton);
            this.Controls.Add(this.cowMilkPriceBox);
            this.Controls.Add(this.goatMilkPriceBox);
            this.Controls.Add(this.jCowVaccBox);
            this.Controls.Add(this.cowVaccBox);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Polymorphism application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.TextBox cowVaccBox;
        private System.Windows.Forms.TextBox jCowVaccBox;
        public System.Windows.Forms.TextBox goatMilkPriceBox;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goatVaccBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox cowMilkPriceBox;
        private System.Windows.Forms.Button profitButton;
        public System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.ToolStripMenuItem calculateProfitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createObjectsToolStripMenuItem;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button objectButton;
    }
}

