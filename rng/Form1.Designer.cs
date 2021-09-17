namespace rng
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
            this.label1 = new System.Windows.Forms.Label();
            this.fromText = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadCheat = new System.Windows.Forms.Button();
            this.cheatText = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.shownNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(146, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Generator";
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(282, 162);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(38, 20);
            this.fromText.TabIndex = 1;
            this.fromText.Text = "1";
            this.fromText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.From.Location = new System.Drawing.Point(208, 157);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(68, 25);
            this.From.TabIndex = 2;
            this.From.Text = "From:";
            this.From.Click += new System.EventHandler(this.From_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(376, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(427, 162);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(41, 20);
            this.toText.TabIndex = 4;
            this.toText.Text = "10";
            this.toText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(207, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your number is:";
            // 
            // loadCheat
            // 
            this.loadCheat.BackColor = System.Drawing.SystemColors.Control;
            this.loadCheat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadCheat.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.loadCheat.FlatAppearance.BorderSize = 0;
            this.loadCheat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.loadCheat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.loadCheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadCheat.ForeColor = System.Drawing.SystemColors.Control;
            this.loadCheat.Location = new System.Drawing.Point(588, 317);
            this.loadCheat.Name = "loadCheat";
            this.loadCheat.Size = new System.Drawing.Size(221, 141);
            this.loadCheat.TabIndex = 6;
            this.loadCheat.Text = "loadCheat";
            this.loadCheat.UseVisualStyleBackColor = false;
            this.loadCheat.Click += new System.EventHandler(this.loadCheat_Click);
            // 
            // cheatText
            // 
            this.cheatText.BackColor = System.Drawing.SystemColors.Control;
            this.cheatText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cheatText.Cursor = System.Windows.Forms.Cursors.Default;
            this.cheatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.cheatText.ForeColor = System.Drawing.SystemColors.Control;
            this.cheatText.Location = new System.Drawing.Point(-8, 307);
            this.cheatText.Name = "cheatText";
            this.cheatText.Size = new System.Drawing.Size(175, 151);
            this.cheatText.TabIndex = 7;
            this.cheatText.TabStop = false;
            this.cheatText.TextChanged += new System.EventHandler(this.cheatText_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(282, 210);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 35);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // shownNumber
            // 
            this.shownNumber.AutoSize = true;
            this.shownNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.shownNumber.Location = new System.Drawing.Point(421, 261);
            this.shownNumber.Name = "shownNumber";
            this.shownNumber.Size = new System.Drawing.Size(0, 31);
            this.shownNumber.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shownNumber);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cheatText);
            this.Controls.Add(this.loadCheat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.From);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cheatText;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label shownNumber;
        private System.Windows.Forms.Button loadCheat;
    }
}

