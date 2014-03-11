namespace NumberBox
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBox1 = new NumberBox.NumericBox(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // numericBox1
            // 
            this.numericBox1.AllowControls = true;
            this.numericBox1.AllowDecimal = true;
            this.numericBox1.AllowLetters = true;
            this.numericBox1.AllowNumbers = true;
            this.numericBox1.AllowSpace = true;
            this.numericBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numericBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericBox1.ChangeColor = false;
            this.numericBox1.ChangeColorTo = System.Drawing.Color.AliceBlue;
            this.numericBox1.DefaultValue = 0;
            this.numericBox1.Location = new System.Drawing.Point(70, 167);
            this.numericBox1.Name = "numericBox1";
            this.numericBox1.Size = new System.Drawing.Size(100, 20);
            this.numericBox1.TabIndex = 3;
            this.numericBox1.TransparentBox = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numericBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private NumericBox numericBox1;



    }
}

