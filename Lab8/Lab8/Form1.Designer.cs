﻿namespace Lab8
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(11, 418);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(127, 418);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(469, 21);
      this.progressBar1.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}

