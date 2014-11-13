namespace CalculatorBuild
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
            this.one = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.RadioButton();
            this.subtract = new System.Windows.Forms.RadioButton();
            this.mult = new System.Windows.Forms.RadioButton();
            this.div = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.RichTextBox();
            this.sine = new System.Windows.Forms.RadioButton();
            this.cosine = new System.Windows.Forms.RadioButton();
            this.tangent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(60, 64);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(240, 20);
            this.one.TabIndex = 0;
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(343, 64);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(258, 20);
            this.two.TabIndex = 1;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(60, 119);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 2;
            this.go.Text = "Calculate";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Checked = true;
            this.Add.Location = new System.Drawing.Point(61, 148);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(31, 17);
            this.Add.TabIndex = 3;
            this.Add.TabStop = true;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.subtract.AutoSize = true;
            this.subtract.Location = new System.Drawing.Point(61, 171);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(28, 17);
            this.subtract.TabIndex = 4;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Location = new System.Drawing.Point(61, 194);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(29, 17);
            this.mult.TabIndex = 5;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(61, 217);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(30, 17);
            this.div.TabIndex = 6;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(46, 263);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(393, 152);
            this.output.TabIndex = 7;
            this.output.Text = "";
            // 
            // sine
            // 
            this.sine.AutoSize = true;
            this.sine.Location = new System.Drawing.Point(98, 148);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(43, 17);
            this.sine.TabIndex = 8;
            this.sine.TabStop = true;
            this.sine.Text = "SIN";
            this.sine.UseVisualStyleBackColor = true;
            this.sine.CheckedChanged += new System.EventHandler(this.sine_CheckedChanged);
            // 
            // cosine
            // 
            this.cosine.AutoSize = true;
            this.cosine.Location = new System.Drawing.Point(98, 172);
            this.cosine.Name = "cosine";
            this.cosine.Size = new System.Drawing.Size(47, 17);
            this.cosine.TabIndex = 9;
            this.cosine.TabStop = true;
            this.cosine.Text = "COS";
            this.cosine.UseVisualStyleBackColor = true;
            this.cosine.CheckedChanged += new System.EventHandler(this.cosine_CheckedChanged);
            // 
            // tangent
            // 
            this.tangent.AutoSize = true;
            this.tangent.Location = new System.Drawing.Point(98, 195);
            this.tangent.Name = "tangent";
            this.tangent.Size = new System.Drawing.Size(47, 17);
            this.tangent.TabIndex = 10;
            this.tangent.TabStop = true;
            this.tangent.Text = "TAN";
            this.tangent.UseVisualStyleBackColor = true;
            this.tangent.CheckedChanged += new System.EventHandler(this.tangent_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 503);
            this.Controls.Add(this.tangent);
            this.Controls.Add(this.cosine);
            this.Controls.Add(this.sine);
            this.Controls.Add(this.output);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.go);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.RadioButton subtract;
        private System.Windows.Forms.RadioButton mult;
        private System.Windows.Forms.RadioButton div;
        public System.Windows.Forms.RadioButton Add;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.RadioButton sine;
        private System.Windows.Forms.RadioButton cosine;
        private System.Windows.Forms.RadioButton tangent;
    }
}

