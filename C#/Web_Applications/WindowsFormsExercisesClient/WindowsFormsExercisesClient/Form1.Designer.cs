namespace WindowsFormsExercisesClient
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
            this.components = new System.ComponentModel.Container();
            this.listBox_5Elements = new System.Windows.Forms.ListBox();
            this.label_TempC = new System.Windows.Forms.Label();
            this.label_TempF = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.textBox_Celsius = new System.Windows.Forms.TextBox();
            this.textBox_Fahrenheit = new System.Windows.Forms.TextBox();
            this.textBox_ResultTemperature = new System.Windows.Forms.TextBox();
            this.button_PrintList = new System.Windows.Forms.Button();
            this.button_ConvertTemp = new System.Windows.Forms.Button();
            this.label_DateDesign = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Euro = new System.Windows.Forms.Label();
            this.label_Ron = new System.Windows.Forms.Label();
            this.label_ResultMoney = new System.Windows.Forms.Label();
            this.textBox_Euro = new System.Windows.Forms.TextBox();
            this.textBox_Ron = new System.Windows.Forms.TextBox();
            this.textBox_ResultMoney = new System.Windows.Forms.TextBox();
            this.button_ConvertMoney = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox_5Elements
            // 
            this.listBox_5Elements.FormattingEnabled = true;
            this.listBox_5Elements.Location = new System.Drawing.Point(22, 23);
            this.listBox_5Elements.Name = "listBox_5Elements";
            this.listBox_5Elements.Size = new System.Drawing.Size(171, 95);
            this.listBox_5Elements.TabIndex = 0;
            // 
            // label_TempC
            // 
            this.label_TempC.AutoSize = true;
            this.label_TempC.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TempC.Location = new System.Drawing.Point(300, 23);
            this.label_TempC.Name = "label_TempC";
            this.label_TempC.Size = new System.Drawing.Size(57, 16);
            this.label_TempC.TabIndex = 1;
            this.label_TempC.Text = "Temp C";
            // 
            // label_TempF
            // 
            this.label_TempF.AutoSize = true;
            this.label_TempF.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TempF.Location = new System.Drawing.Point(300, 63);
            this.label_TempF.Name = "label_TempF";
            this.label_TempF.Size = new System.Drawing.Size(56, 16);
            this.label_TempF.TabIndex = 2;
            this.label_TempF.Text = "Temp F";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.Location = new System.Drawing.Point(300, 102);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(47, 16);
            this.label_Result.TabIndex = 3;
            this.label_Result.Text = "Result";
            // 
            // textBox_Celsius
            // 
            this.textBox_Celsius.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Celsius.Location = new System.Drawing.Point(363, 23);
            this.textBox_Celsius.Name = "textBox_Celsius";
            this.textBox_Celsius.Size = new System.Drawing.Size(128, 23);
            this.textBox_Celsius.TabIndex = 4;
            this.textBox_Celsius.TextChanged += new System.EventHandler(this.textBox_Celsius_TextChanged);
            // 
            // textBox_Fahrenheit
            // 
            this.textBox_Fahrenheit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Fahrenheit.Location = new System.Drawing.Point(362, 63);
            this.textBox_Fahrenheit.Name = "textBox_Fahrenheit";
            this.textBox_Fahrenheit.Size = new System.Drawing.Size(128, 23);
            this.textBox_Fahrenheit.TabIndex = 5;
            this.textBox_Fahrenheit.TextChanged += new System.EventHandler(this.textBox_Fahrenheit_TextChanged);
            // 
            // textBox_ResultTemperature
            // 
            this.textBox_ResultTemperature.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ResultTemperature.Location = new System.Drawing.Point(363, 102);
            this.textBox_ResultTemperature.Name = "textBox_ResultTemperature";
            this.textBox_ResultTemperature.ReadOnly = true;
            this.textBox_ResultTemperature.Size = new System.Drawing.Size(128, 23);
            this.textBox_ResultTemperature.TabIndex = 6;
            // 
            // button_PrintList
            // 
            this.button_PrintList.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintList.Location = new System.Drawing.Point(63, 133);
            this.button_PrintList.Name = "button_PrintList";
            this.button_PrintList.Size = new System.Drawing.Size(74, 36);
            this.button_PrintList.TabIndex = 7;
            this.button_PrintList.Text = "Print List";
            this.button_PrintList.UseVisualStyleBackColor = true;
            this.button_PrintList.Click += new System.EventHandler(this.button_PrintList_Click);
            // 
            // button_ConvertTemp
            // 
            this.button_ConvertTemp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConvertTemp.Location = new System.Drawing.Point(386, 133);
            this.button_ConvertTemp.Name = "button_ConvertTemp";
            this.button_ConvertTemp.Size = new System.Drawing.Size(74, 36);
            this.button_ConvertTemp.TabIndex = 8;
            this.button_ConvertTemp.Text = "Convert";
            this.button_ConvertTemp.UseVisualStyleBackColor = true;
            this.button_ConvertTemp.Click += new System.EventHandler(this.button_ConvertTemp_Click);
            // 
            // label_DateDesign
            // 
            this.label_DateDesign.AutoSize = true;
            this.label_DateDesign.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateDesign.Location = new System.Drawing.Point(19, 201);
            this.label_DateDesign.Name = "label_DateDesign";
            this.label_DateDesign.Size = new System.Drawing.Size(38, 16);
            this.label_DateDesign.TabIndex = 9;
            this.label_DateDesign.Text = "Date";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Enabled = false;
            this.label_Date.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(60, 242);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(0, 16);
            this.label_Date.TabIndex = 10;
            // 
            // label_Euro
            // 
            this.label_Euro.AutoSize = true;
            this.label_Euro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Euro.Location = new System.Drawing.Point(300, 201);
            this.label_Euro.Name = "label_Euro";
            this.label_Euro.Size = new System.Drawing.Size(36, 16);
            this.label_Euro.TabIndex = 11;
            this.label_Euro.Text = "Euro";
            // 
            // label_Ron
            // 
            this.label_Ron.AutoSize = true;
            this.label_Ron.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ron.Location = new System.Drawing.Point(300, 242);
            this.label_Ron.Name = "label_Ron";
            this.label_Ron.Size = new System.Drawing.Size(31, 16);
            this.label_Ron.TabIndex = 12;
            this.label_Ron.Text = "Ron";
            // 
            // label_ResultMoney
            // 
            this.label_ResultMoney.AutoSize = true;
            this.label_ResultMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultMoney.Location = new System.Drawing.Point(300, 281);
            this.label_ResultMoney.Name = "label_ResultMoney";
            this.label_ResultMoney.Size = new System.Drawing.Size(47, 16);
            this.label_ResultMoney.TabIndex = 13;
            this.label_ResultMoney.Text = "Result";
            // 
            // textBox_Euro
            // 
            this.textBox_Euro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Euro.Location = new System.Drawing.Point(362, 194);
            this.textBox_Euro.Name = "textBox_Euro";
            this.textBox_Euro.Size = new System.Drawing.Size(128, 23);
            this.textBox_Euro.TabIndex = 14;
            this.textBox_Euro.TextChanged += new System.EventHandler(this.textBox_Euro_TextChanged);
            // 
            // textBox_Ron
            // 
            this.textBox_Ron.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ron.Location = new System.Drawing.Point(362, 235);
            this.textBox_Ron.Name = "textBox_Ron";
            this.textBox_Ron.Size = new System.Drawing.Size(128, 23);
            this.textBox_Ron.TabIndex = 15;
            this.textBox_Ron.TextChanged += new System.EventHandler(this.textBox_Ron_TextChanged);
            // 
            // textBox_ResultMoney
            // 
            this.textBox_ResultMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ResultMoney.Location = new System.Drawing.Point(363, 278);
            this.textBox_ResultMoney.Name = "textBox_ResultMoney";
            this.textBox_ResultMoney.ReadOnly = true;
            this.textBox_ResultMoney.Size = new System.Drawing.Size(128, 23);
            this.textBox_ResultMoney.TabIndex = 16;
            // 
            // button_ConvertMoney
            // 
            this.button_ConvertMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConvertMoney.Location = new System.Drawing.Point(386, 307);
            this.button_ConvertMoney.Name = "button_ConvertMoney";
            this.button_ConvertMoney.Size = new System.Drawing.Size(74, 36);
            this.button_ConvertMoney.TabIndex = 17;
            this.button_ConvertMoney.Text = "Convert";
            this.button_ConvertMoney.UseVisualStyleBackColor = true;
            this.button_ConvertMoney.Click += new System.EventHandler(this.button_ConvertMoney_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(22, 301);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(74, 36);
            this.button_Exit.TabIndex = 18;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 349);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ConvertMoney);
            this.Controls.Add(this.textBox_ResultMoney);
            this.Controls.Add(this.textBox_Ron);
            this.Controls.Add(this.textBox_Euro);
            this.Controls.Add(this.label_ResultMoney);
            this.Controls.Add(this.label_Ron);
            this.Controls.Add(this.label_Euro);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_DateDesign);
            this.Controls.Add(this.button_ConvertTemp);
            this.Controls.Add(this.button_PrintList);
            this.Controls.Add(this.textBox_ResultTemperature);
            this.Controls.Add(this.textBox_Fahrenheit);
            this.Controls.Add(this.textBox_Celsius);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_TempF);
            this.Controls.Add(this.label_TempC);
            this.Controls.Add(this.listBox_5Elements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_5Elements;
        private System.Windows.Forms.Label label_TempC;
        private System.Windows.Forms.Label label_TempF;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.TextBox textBox_Celsius;
        private System.Windows.Forms.TextBox textBox_Fahrenheit;
        private System.Windows.Forms.TextBox textBox_ResultTemperature;
        private System.Windows.Forms.Button button_PrintList;
        private System.Windows.Forms.Button button_ConvertTemp;
        private System.Windows.Forms.Label label_DateDesign;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Euro;
        private System.Windows.Forms.Label label_Ron;
        private System.Windows.Forms.Label label_ResultMoney;
        private System.Windows.Forms.TextBox textBox_Euro;
        private System.Windows.Forms.TextBox textBox_Ron;
        private System.Windows.Forms.TextBox textBox_ResultMoney;
        private System.Windows.Forms.Button button_ConvertMoney;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Timer timer1;
    }
}

