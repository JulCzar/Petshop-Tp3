
namespace Petshop.src.views {
  partial class Cadastrar {
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button2 = new System.Windows.Forms.Button();
      this.warn = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.rg = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.birthdate = new System.Windows.Forms.MaskedTextBox();
      this.Nome = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.password = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.email = new System.Windows.Forms.TextBox();
      this.cpf = new System.Windows.Forms.MaskedTextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.cpf);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.warn);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.rg);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.birthdate);
      this.groupBox1.Controls.Add(this.Nome);
      this.groupBox1.Controls.Add(this.name);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.password);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.email);
      this.groupBox1.Location = new System.Drawing.Point(13, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(339, 425);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Cadastro";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(-1, 386);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(116, 39);
      this.button2.TabIndex = 14;
      this.button2.Text = "Voltar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // warn
      // 
      this.warn.AutoSize = true;
      this.warn.Location = new System.Drawing.Point(167, 19);
      this.warn.Name = "warn";
      this.warn.Size = new System.Drawing.Size(0, 15);
      this.warn.TabIndex = 13;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(230, 386);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 39);
      this.button1.TabIndex = 12;
      this.button1.Text = "Cadastrar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // rg
      // 
      this.rg.AutoSize = true;
      this.rg.Location = new System.Drawing.Point(-1, 296);
      this.rg.Name = "rg";
      this.rg.Size = new System.Drawing.Size(21, 15);
      this.rg.TabIndex = 11;
      this.rg.Text = "Rg";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(0, 314);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(339, 23);
      this.textBox1.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(0, 244);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(26, 15);
      this.label4.TabIndex = 9;
      this.label4.Text = "Cpf";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(1, 189);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "Data de Nascimento";
      // 
      // birthdate
      // 
      this.birthdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.birthdate.Location = new System.Drawing.Point(0, 207);
      this.birthdate.Mask = "00/00/0000";
      this.birthdate.Name = "birthdate";
      this.birthdate.Size = new System.Drawing.Size(339, 23);
      this.birthdate.TabIndex = 6;
      this.birthdate.ValidatingType = typeof(System.DateTime);
      // 
      // Nome
      // 
      this.Nome.AutoSize = true;
      this.Nome.Location = new System.Drawing.Point(-1, 136);
      this.Nome.Name = "Nome";
      this.Nome.Size = new System.Drawing.Size(40, 15);
      this.Nome.TabIndex = 5;
      this.Nome.Text = "Nome";
      // 
      // name
      // 
      this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.name.Location = new System.Drawing.Point(0, 154);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(339, 23);
      this.name.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(-1, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Senha";
      // 
      // password
      // 
      this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.password.Location = new System.Drawing.Point(0, 102);
      this.password.Name = "password";
      this.password.PasswordChar = '*';
      this.password.Size = new System.Drawing.Size(339, 23);
      this.password.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(-1, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Email";
      // 
      // email
      // 
      this.email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.email.Location = new System.Drawing.Point(0, 53);
      this.email.Name = "email";
      this.email.Size = new System.Drawing.Size(339, 23);
      this.email.TabIndex = 0;
      // 
      // cpf
      // 
      this.cpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cpf.Location = new System.Drawing.Point(1, 262);
      this.cpf.Mask = "000.000.000-00";
      this.cpf.Name = "cpf";
      this.cpf.Size = new System.Drawing.Size(339, 23);
      this.cpf.TabIndex = 31;
      this.cpf.ValidatingType = typeof(System.DateTime);
      // 
      // Cadastrar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(364, 450);
      this.Controls.Add(this.groupBox1);
      this.Name = "Cadastrar";
      this.Text = "Cadastrar";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox password;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox email;
    private System.Windows.Forms.Label Nome;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox birthdate;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label rg;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label warn;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.MaskedTextBox cpf;
  }
}