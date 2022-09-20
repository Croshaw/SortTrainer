namespace SortTrainer
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
            this.RawArrayTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenBTN = new System.Windows.Forms.Button();
            this.SpentTimeTB = new System.Windows.Forms.TextBox();
            this.SortBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SortedArrayTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SortTypeCB = new System.Windows.Forms.ComboBox();
            this.SpentTimeLB = new System.Windows.Forms.Label();
            this.MemSizeLB = new System.Windows.Forms.Label();
            this.ComparisionCountTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SwapCountTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RawArrayTB
            // 
            this.RawArrayTB.Location = new System.Drawing.Point(12, 44);
            this.RawArrayTB.Name = "RawArrayTB";
            this.RawArrayTB.Size = new System.Drawing.Size(254, 86);
            this.RawArrayTB.TabIndex = 0;
            this.RawArrayTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный массив:";
            // 
            // GenBTN
            // 
            this.GenBTN.Location = new System.Drawing.Point(164, 18);
            this.GenBTN.Name = "GenBTN";
            this.GenBTN.Size = new System.Drawing.Size(102, 23);
            this.GenBTN.TabIndex = 2;
            this.GenBTN.Text = "Генерировать";
            this.GenBTN.UseVisualStyleBackColor = true;
            this.GenBTN.Click += new System.EventHandler(this.GenBTN_Click);
            // 
            // SpentTimeTB
            // 
            this.SpentTimeTB.Location = new System.Drawing.Point(305, 100);
            this.SpentTimeTB.Name = "SpentTimeTB";
            this.SpentTimeTB.ReadOnly = true;
            this.SpentTimeTB.Size = new System.Drawing.Size(121, 23);
            this.SpentTimeTB.TabIndex = 3;
            // 
            // SortBTN
            // 
            this.SortBTN.Location = new System.Drawing.Point(173, 141);
            this.SortBTN.Name = "SortBTN";
            this.SortBTN.Size = new System.Drawing.Size(93, 23);
            this.SortBTN.TabIndex = 7;
            this.SortBTN.Text = "Сортировать";
            this.SortBTN.UseVisualStyleBackColor = true;
            this.SortBTN.Click += new System.EventHandler(this.SortBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Отсортированный массив:";
            // 
            // SortedArrayTB
            // 
            this.SortedArrayTB.Location = new System.Drawing.Point(12, 163);
            this.SortedArrayTB.Name = "SortedArrayTB";
            this.SortedArrayTB.Size = new System.Drawing.Size(254, 86);
            this.SortedArrayTB.TabIndex = 5;
            this.SortedArrayTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Тип сортировки:";
            // 
            // SortTypeCB
            // 
            this.SortTypeCB.FormattingEnabled = true;
            this.SortTypeCB.Items.AddRange(new object[] {
            "Bubble Sort(Пузырьком)"});
            this.SortTypeCB.Location = new System.Drawing.Point(305, 34);
            this.SortTypeCB.Name = "SortTypeCB";
            this.SortTypeCB.Size = new System.Drawing.Size(121, 23);
            this.SortTypeCB.TabIndex = 9;
            // 
            // SpentTimeLB
            // 
            this.SpentTimeLB.AutoSize = true;
            this.SpentTimeLB.Location = new System.Drawing.Point(305, 82);
            this.SpentTimeLB.Name = "SpentTimeLB";
            this.SpentTimeLB.Size = new System.Drawing.Size(88, 15);
            this.SpentTimeLB.TabIndex = 11;
            this.SpentTimeLB.Text = "Затрач. время:";
            // 
            // MemSizeLB
            // 
            this.MemSizeLB.AutoSize = true;
            this.MemSizeLB.Location = new System.Drawing.Point(305, 145);
            this.MemSizeLB.Name = "MemSizeLB";
            this.MemSizeLB.Size = new System.Drawing.Size(116, 15);
            this.MemSizeLB.TabIndex = 13;
            this.MemSizeLB.Text = "Кол-во стравнений:";
            // 
            // ComparisionCountTB
            // 
            this.ComparisionCountTB.Location = new System.Drawing.Point(305, 163);
            this.ComparisionCountTB.Name = "ComparisionCountTB";
            this.ComparisionCountTB.ReadOnly = true;
            this.ComparisionCountTB.Size = new System.Drawing.Size(121, 23);
            this.ComparisionCountTB.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 104);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Кол-во перестановок:";
            // 
            // SwapCountTB
            // 
            this.SwapCountTB.Location = new System.Drawing.Point(305, 222);
            this.SwapCountTB.Name = "SwapCountTB";
            this.SwapCountTB.ReadOnly = true;
            this.SwapCountTB.Size = new System.Drawing.Size(121, 23);
            this.SwapCountTB.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SwapCountTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MemSizeLB);
            this.Controls.Add(this.ComparisionCountTB);
            this.Controls.Add(this.SpentTimeLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SortTypeCB);
            this.Controls.Add(this.SortBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortedArrayTB);
            this.Controls.Add(this.SpentTimeTB);
            this.Controls.Add(this.GenBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RawArrayTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RawArrayTB;
        private Label label1;
        private Button GenBTN;
        private TextBox SpentTimeTB;
        private Button SortBTN;
        private Label label2;
        private RichTextBox SortedArrayTB;
        private Label label4;
        private ComboBox SortTypeCB;
        private Label SpentTimeLB;
        private Label MemSizeLB;
        private TextBox ComparisionCountTB;
        private Panel panel1;
        private Label label5;
        private TextBox SwapCountTB;
    }
}