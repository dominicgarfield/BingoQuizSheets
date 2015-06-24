namespace BanwellQuizBingo
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
            this.generateSheets = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.print = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sheetsToPrint = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetsToPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // generateSheets
            // 
            this.generateSheets.Location = new System.Drawing.Point(197, 121);
            this.generateSheets.Name = "generateSheets";
            this.generateSheets.Size = new System.Drawing.Size(158, 53);
            this.generateSheets.TabIndex = 0;
            this.generateSheets.Text = "Generate Bingo Sheet";
            this.generateSheets.UseVisualStyleBackColor = true;
            this.generateSheets.Click += new System.EventHandler(this.generateSheets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(197, 82);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(158, 23);
            this.print.TabIndex = 1;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // sheetsToPrint
            // 
            this.sheetsToPrint.Location = new System.Drawing.Point(311, 49);
            this.sheetsToPrint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sheetsToPrint.Name = "sheetsToPrint";
            this.sheetsToPrint.Size = new System.Drawing.Size(41, 20);
            this.sheetsToPrint.TabIndex = 3;
            this.sheetsToPrint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sheetsToPrint.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of sheets:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sheetsToPrint);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generateSheets);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetsToPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateSheets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown sheetsToPrint;
        private System.Windows.Forms.Label label1;
    }
}

