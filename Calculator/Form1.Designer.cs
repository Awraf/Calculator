namespace Calculator
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
            this.add = new System.Windows.Forms.Button();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.diff = new System.Windows.Forms.Button();
            this.dev = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(70, 94);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(73, 42);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // inputValue
            // 
            this.inputValue.Location = new System.Drawing.Point(70, 39);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(370, 38);
            this.inputValue.TabIndex = 9;
            this.inputValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputValue_KeyPress);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(228, 94);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(103, 90);
            this.equal.TabIndex = 10;
            this.equal.Text = "equal";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(337, 94);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(103, 90);
            this.clear.TabIndex = 11;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(149, 94);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(73, 42);
            this.mult.TabIndex = 12;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(70, 142);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(73, 42);
            this.diff.TabIndex = 13;
            this.diff.Text = "-";
            this.diff.UseVisualStyleBackColor = true;
            this.diff.Click += new System.EventHandler(this.diff_Click);
            // 
            // dev
            // 
            this.dev.Location = new System.Drawing.Point(149, 142);
            this.dev.Name = "dev";
            this.dev.Size = new System.Drawing.Size(73, 42);
            this.dev.TabIndex = 14;
            this.dev.Text = "/";
            this.dev.UseVisualStyleBackColor = true;
            this.dev.Click += new System.EventHandler(this.dev_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(82, 211);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 32);
            this.error.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 258);
            this.Controls.Add(this.error);
            this.Controls.Add(this.dev);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button diff;
        private System.Windows.Forms.Button dev;
        private System.Windows.Forms.Label error;
    }
}

