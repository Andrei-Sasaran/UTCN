namespace SSR_Laborator2_Exercitiul3
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
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.binaryOperatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_Equals = new System.Windows.Forms.Label();
            this.label_toChange = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_X
            // 
            this.tb_X.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_X.Location = new System.Drawing.Point(83, 246);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(67, 27);
            this.tb_X.TabIndex = 0;
            // 
            // tb_Y
            // 
            this.tb_Y.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Y.Location = new System.Drawing.Point(195, 246);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(67, 27);
            this.tb_Y.TabIndex = 1;
            // 
            // tb_Result
            // 
            this.tb_Result.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Result.Location = new System.Drawing.Point(306, 246);
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.Size = new System.Drawing.Size(67, 27);
            this.tb_Result.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryOperatorsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(490, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // binaryOperatorsToolStripMenuItem
            // 
            this.binaryOperatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionToolStripMenuItem,
            this.subtractionToolStripMenuItem,
            this.multiplicationToolStripMenuItem,
            this.devisionToolStripMenuItem});
            this.binaryOperatorsToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryOperatorsToolStripMenuItem.Name = "binaryOperatorsToolStripMenuItem";
            this.binaryOperatorsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.binaryOperatorsToolStripMenuItem.Text = "Binary Operators";
            // 
            // additionToolStripMenuItem
            // 
            this.additionToolStripMenuItem.Name = "additionToolStripMenuItem";
            this.additionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.additionToolStripMenuItem.Text = "Addition";
            this.additionToolStripMenuItem.Click += new System.EventHandler(this.additionToolStripMenuItem_Click);
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.subtractionToolStripMenuItem_Click);
            // 
            // multiplicationToolStripMenuItem
            // 
            this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.multiplicationToolStripMenuItem.Text = "Multiplication";
            this.multiplicationToolStripMenuItem.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // devisionToolStripMenuItem
            // 
            this.devisionToolStripMenuItem.Name = "devisionToolStripMenuItem";
            this.devisionToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.devisionToolStripMenuItem.Text = "Devision";
            this.devisionToolStripMenuItem.Click += new System.EventHandler(this.devisionToolStripMenuItem_Click);
            // 
            // l_Equals
            // 
            this.l_Equals.AutoSize = true;
            this.l_Equals.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Equals.Location = new System.Drawing.Point(277, 249);
            this.l_Equals.Name = "l_Equals";
            this.l_Equals.Size = new System.Drawing.Size(22, 20);
            this.l_Equals.TabIndex = 5;
            this.l_Equals.Text = "=";
            // 
            // label_toChange
            // 
            this.label_toChange.AutoSize = true;
            this.label_toChange.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toChange.Location = new System.Drawing.Point(165, 249);
            this.label_toChange.Name = "label_toChange";
            this.label_toChange.Size = new System.Drawing.Size(22, 20);
            this.label_toChange.TabIndex = 6;
            this.label_toChange.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.label_toChange);
            this.Controls.Add(this.l_Equals);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.tb_Y);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem binaryOperatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devisionToolStripMenuItem;
        private System.Windows.Forms.Label l_Equals;
        private System.Windows.Forms.Label label_toChange;
    }
}

