﻿namespace QhapaqDesktop {
  partial class LoginForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.SuspendLayout();
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 300);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "LoginForm";
      this.Padding = new System.Windows.Forms.Padding(12, 40, 12, 13);
      this.Text = "ログイン";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      this.ResumeLayout(false);

    }

    #endregion
  }
}