
namespace Petshop.src.views {
  partial class Login {
    private System.ComponentModel.IContainer components = null;
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
      this.email = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.password = new System.Windows.Forms.TextBox();
      this.loginBtn = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.passwordHelper = new System.Windows.Forms.Label();
      this.warn = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // email
      // 
      this.email.Location = new System.Drawing.Point(12, 43);
      this.email.Name = "email";
      this.email.Size = new System.Drawing.Size(343, 23);
      this.email.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Email";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 82);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Senha";
      // 
      // password
      // 
      this.password.Location = new System.Drawing.Point(12, 100);
      this.password.Name = "password";
      this.password.PasswordChar = '*';
      this.password.Size = new System.Drawing.Size(343, 23);
      this.password.TabIndex = 2;
      this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
      // 
      // loginBtn
      // 
      this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.loginBtn.Location = new System.Drawing.Point(245, 149);
      this.loginBtn.Name = "loginBtn";
      this.loginBtn.Size = new System.Drawing.Size(110, 35);
      this.loginBtn.TabIndex = 3;
      this.loginBtn.Text = "Entrar";
      this.loginBtn.UseVisualStyleBackColor = true;
      this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.Location = new System.Drawing.Point(12, 149);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(110, 35);
      this.button2.TabIndex = 4;
      this.button2.Text = "Cadastrar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(152, 69);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(0, 15);
      this.label3.TabIndex = 5;
      // 
      // passwordHelper
      // 
      this.passwordHelper.AutoSize = true;
      this.passwordHelper.Location = new System.Drawing.Point(152, 126);
      this.passwordHelper.Name = "passwordHelper";
      this.passwordHelper.Size = new System.Drawing.Size(0, 15);
      this.passwordHelper.TabIndex = 6;
      // 
      // warn
      // 
      this.warn.AutoSize = true;
      this.warn.ForeColor = System.Drawing.Color.Red;
      this.warn.Location = new System.Drawing.Point(152, 13);
      this.warn.Name = "warn";
      this.warn.Size = new System.Drawing.Size(0, 15);
      this.warn.TabIndex = 7;
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(367, 203);
      this.Controls.Add(this.warn);
      this.Controls.Add(this.passwordHelper);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.loginBtn);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.password);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.email);
      this.Name = "Login";
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion


    private System.Windows.Forms.TextBox email;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox password;
    private System.Windows.Forms.Button loginBtn;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label passwordHelper;
    private System.Windows.Forms.Label warn;
  }
}