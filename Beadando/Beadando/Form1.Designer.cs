namespace Beadando
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
            this.szabalyokDataGridView = new System.Windows.Forms.DataGridView();
            this.inputTxtBx = new System.Windows.Forms.TextBox();
            this.pathTxtBx = new System.Windows.Forms.TextBox();
            this.convertedInputTxtBx = new System.Windows.Forms.TextBox();
            this.inputOKBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stepsTxtBx = new System.Windows.Forms.RichTextBox();
            this.warningLbl = new System.Windows.Forms.Label();
            this.standardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.szabalyokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // szabalyokDataGridView
            // 
            this.szabalyokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.szabalyokDataGridView.Location = new System.Drawing.Point(12, 140);
            this.szabalyokDataGridView.Name = "szabalyokDataGridView";
            this.szabalyokDataGridView.Size = new System.Drawing.Size(751, 454);
            this.szabalyokDataGridView.TabIndex = 0;
            // 
            // inputTxtBx
            // 
            this.inputTxtBx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputTxtBx.Location = new System.Drawing.Point(129, 35);
            this.inputTxtBx.Name = "inputTxtBx";
            this.inputTxtBx.Size = new System.Drawing.Size(535, 20);
            this.inputTxtBx.TabIndex = 1;
            // 
            // pathTxtBx
            // 
            this.pathTxtBx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pathTxtBx.Location = new System.Drawing.Point(129, 87);
            this.pathTxtBx.Name = "pathTxtBx";
            this.pathTxtBx.Size = new System.Drawing.Size(535, 20);
            this.pathTxtBx.TabIndex = 2;
            // 
            // convertedInputTxtBx
            // 
            this.convertedInputTxtBx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.convertedInputTxtBx.Location = new System.Drawing.Point(129, 61);
            this.convertedInputTxtBx.Name = "convertedInputTxtBx";
            this.convertedInputTxtBx.Size = new System.Drawing.Size(535, 20);
            this.convertedInputTxtBx.TabIndex = 3;
            // 
            // inputOKBtn
            // 
            this.inputOKBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputOKBtn.Location = new System.Drawing.Point(688, 33);
            this.inputOKBtn.Name = "inputOKBtn";
            this.inputOKBtn.Size = new System.Drawing.Size(75, 23);
            this.inputOKBtn.TabIndex = 4;
            this.inputOKBtn.Text = "OK";
            this.inputOKBtn.UseVisualStyleBackColor = true;
            this.inputOKBtn.Click += new System.EventHandler(this.inputOKBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Standardised input";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path";
            // 
            // solveBtn
            // 
            this.solveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.solveBtn.Location = new System.Drawing.Point(867, 30);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 8;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.browseBtn.Location = new System.Drawing.Point(688, 90);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // stepsTxtBx
            // 
            this.stepsTxtBx.Location = new System.Drawing.Point(769, 140);
            this.stepsTxtBx.Name = "stepsTxtBx";
            this.stepsTxtBx.Size = new System.Drawing.Size(270, 454);
            this.stepsTxtBx.TabIndex = 10;
            this.stepsTxtBx.Text = "";
            // 
            // warningLbl
            // 
            this.warningLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warningLbl.AutoSize = true;
            this.warningLbl.Location = new System.Drawing.Point(788, 90);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(35, 13);
            this.warningLbl.TabIndex = 11;
            this.warningLbl.Text = "label4";
            // 
            // standardBtn
            // 
            this.standardBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.standardBtn.Location = new System.Drawing.Point(688, 62);
            this.standardBtn.Name = "standardBtn";
            this.standardBtn.Size = new System.Drawing.Size(75, 23);
            this.standardBtn.TabIndex = 12;
            this.standardBtn.Text = "OK";
            this.standardBtn.UseVisualStyleBackColor = true;
            this.standardBtn.Click += new System.EventHandler(this.standardBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 606);
            this.Controls.Add(this.standardBtn);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.stepsTxtBx);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputOKBtn);
            this.Controls.Add(this.convertedInputTxtBx);
            this.Controls.Add(this.pathTxtBx);
            this.Controls.Add(this.inputTxtBx);
            this.Controls.Add(this.szabalyokDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.szabalyokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView szabalyokDataGridView;
        private System.Windows.Forms.TextBox inputTxtBx;
        private System.Windows.Forms.TextBox pathTxtBx;
        private System.Windows.Forms.TextBox convertedInputTxtBx;
        private System.Windows.Forms.Button inputOKBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox stepsTxtBx;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.Button standardBtn;
    }
}

