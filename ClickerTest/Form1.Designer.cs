namespace ClickerTest
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
            this.buttonBuyExtractor = new System.Windows.Forms.Button();
            this.buttonBuyClicker = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuyExtractor
            // 
            this.buttonBuyExtractor.Location = new System.Drawing.Point(28, 63);
            this.buttonBuyExtractor.Name = "buttonBuyExtractor";
            this.buttonBuyExtractor.Size = new System.Drawing.Size(113, 37);
            this.buttonBuyExtractor.TabIndex = 0;
            this.buttonBuyExtractor.Text = "Buy Extractor";
            this.buttonBuyExtractor.UseVisualStyleBackColor = true;
            this.buttonBuyExtractor.Click += new System.EventHandler(this.buttonBuyExtractor_Click);
            // 
            // buttonBuyClicker
            // 
            this.buttonBuyClicker.Location = new System.Drawing.Point(28, 225);
            this.buttonBuyClicker.Name = "buttonBuyClicker";
            this.buttonBuyClicker.Size = new System.Drawing.Size(113, 36);
            this.buttonBuyClicker.TabIndex = 1;
            this.buttonBuyClicker.Text = "Buy Clicker";
            this.buttonBuyClicker.UseVisualStyleBackColor = true;
            this.buttonBuyClicker.Click += new System.EventHandler(this.buttonBuyClicker_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(25, 35);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(47, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score: 0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.Location = new System.Drawing.Point(28, 106);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(75, 23);
            this.buttonAddScore.TabIndex = 3;
            this.buttonAddScore.Text = "Add 100";
            this.buttonAddScore.UseVisualStyleBackColor = true;
            this.buttonAddScore.Visible = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonBuyClicker);
            this.Controls.Add(this.buttonBuyExtractor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyExtractor;
        private System.Windows.Forms.Button buttonBuyClicker;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonAddScore;
    }
}

