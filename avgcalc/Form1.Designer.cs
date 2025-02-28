namespace avgcalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox = new TextBox();
            timesList = new ListBox();
            label2 = new Label();
            label3 = new Label();
            submitBtn = new Button();
            calcBtn = new Button();
            clrList = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "Insert your times below:";
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 32);
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Insert times:";
            textBox.Size = new Size(218, 27);
            textBox.TabIndex = 1;
            textBox.KeyDown += textBox_KeyDown;
            // 
            // timesList
            // 
            timesList.FormattingEnabled = true;
            timesList.Location = new Point(248, 9);
            timesList.Name = "timesList";
            timesList.Size = new Size(150, 144);
            timesList.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "IMPORTANT:";
            // 
            // label3
            // 
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(218, 167);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(248, 159);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(150, 29);
            submitBtn.TabIndex = 5;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // calcBtn
            // 
            calcBtn.Location = new Point(248, 229);
            calcBtn.Name = "calcBtn";
            calcBtn.Size = new Size(150, 29);
            calcBtn.TabIndex = 6;
            calcBtn.Text = "Calculate Average";
            calcBtn.UseVisualStyleBackColor = true;
            calcBtn.Click += calcBtn_Click;
            // 
            // clrList
            // 
            clrList.Location = new Point(248, 194);
            clrList.Name = "clrList";
            clrList.Size = new Size(150, 29);
            clrList.TabIndex = 7;
            clrList.Text = "Clear List";
            clrList.UseVisualStyleBackColor = true;
            clrList.Click += clrList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 283);
            Controls.Add(clrList);
            Controls.Add(calcBtn);
            Controls.Add(submitBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(timesList);
            Controls.Add(textBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ao5 Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private ListBox timesList;
        private Label label2;
        private Label label3;
        private Button submitBtn;
        private Button calcBtn;
        private Button clrList;
    }
}
