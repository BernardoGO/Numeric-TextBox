namespace MyTextBoxTeste
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
            this.myTextBox1 = new MyTextBox.MyTextBox(this.components);
            this.myTextBox2 = new MyTextBox.MyTextBox(this.components);
            this.SuspendLayout();
            // 
            // myTextBox1
            // 
            this.myTextBox1.AllowControls = true;
            this.myTextBox1.AllowDecimal = true;
            this.myTextBox1.AllowLetters = true;
            this.myTextBox1.AllowNumbers = false;
            this.myTextBox1.AllowSpace = true;
            this.myTextBox1.ChangeColor = true;
            this.myTextBox1.ChangeColorTo = System.Drawing.Color.DeepSkyBlue;
            this.myTextBox1.DefaultValue = 0;
            this.myTextBox1.Location = new System.Drawing.Point(111, 112);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(100, 20);
            this.myTextBox1.TabIndex = 0;
            this.myTextBox1.TransparentBox = false;
            // 
            // myTextBox2
            // 
            this.myTextBox2.AllowControls = true;
            this.myTextBox2.AllowDecimal = true;
            this.myTextBox2.AllowLetters = true;
            this.myTextBox2.AllowNumbers = true;
            this.myTextBox2.AllowSpace = true;
            this.myTextBox2.ChangeColor = false;
            this.myTextBox2.ChangeColorTo = System.Drawing.Color.AliceBlue;
            this.myTextBox2.DefaultValue = 0;
            this.myTextBox2.Location = new System.Drawing.Point(68, 147);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(100, 20);
            this.myTextBox2.TabIndex = 1;
            this.myTextBox2.TransparentBox = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox.MyTextBox myTextBox1;
        private MyTextBox.MyTextBox myTextBox2;


    }
}

