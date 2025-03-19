namespace GUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxSize = new TextBox();
            textBoxSeed = new TextBox();
            textBoxMaxWeight = new TextBox();
            buttonSolve = new Button();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of items:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Seed:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 97);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Max weight:";
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(144, 20);
            textBoxSize.Margin = new Padding(3, 4, 3, 4);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(114, 27);
            textBoxSize.TabIndex = 3;
            // 
            // textBoxSeed
            // 
            textBoxSeed.Location = new Point(144, 55);
            textBoxSeed.Margin = new Padding(3, 4, 3, 4);
            textBoxSeed.Name = "textBoxSeed";
            textBoxSeed.Size = new Size(114, 27);
            textBoxSeed.TabIndex = 4;
            // 
            // textBoxMaxWeight
            // 
            textBoxMaxWeight.Location = new Point(144, 94);
            textBoxMaxWeight.Margin = new Padding(3, 4, 3, 4);
            textBoxMaxWeight.Name = "textBoxMaxWeight";
            textBoxMaxWeight.Size = new Size(114, 27);
            textBoxMaxWeight.TabIndex = 5;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(14, 132);
            buttonSolve.Margin = new Padding(3, 4, 3, 4);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(213, 31);
            buttonSolve.TabIndex = 6;
            buttonSolve.Text = "Solve";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(14, 184);
            textBoxResult.Margin = new Padding(3, 4, 3, 4);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(244, 190);
            textBoxResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 387);
            Controls.Add(textBoxResult);
            Controls.Add(buttonSolve);
            Controls.Add(textBoxMaxWeight);
            Controls.Add(textBoxSeed);
            Controls.Add(textBoxSize);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Knapsack Problem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.TextBox textBoxMaxWeight;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
