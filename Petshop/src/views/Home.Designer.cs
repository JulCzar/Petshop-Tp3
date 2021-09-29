
namespace Petshop.src.views {
  partial class Home {
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
      this.cadastrarClient = new System.Windows.Forms.Button();
      this.cadastrarPet = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.petsAtendidos = new System.Windows.Forms.Label();
      this.registered = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cadastrarClient
      // 
      this.cadastrarClient.Location = new System.Drawing.Point(12, 12);
      this.cadastrarClient.Name = "cadastrarClient";
      this.cadastrarClient.Size = new System.Drawing.Size(155, 38);
      this.cadastrarClient.TabIndex = 0;
      this.cadastrarClient.Text = "Cadastrar Cliente";
      this.cadastrarClient.UseVisualStyleBackColor = true;
      this.cadastrarClient.Click += new System.EventHandler(this.cadastrarClient_Click);
      // 
      // cadastrarPet
      // 
      this.cadastrarPet.Location = new System.Drawing.Point(12, 56);
      this.cadastrarPet.Name = "cadastrarPet";
      this.cadastrarPet.Size = new System.Drawing.Size(155, 38);
      this.cadastrarPet.TabIndex = 1;
      this.cadastrarPet.Text = "Cadastrar PETs";
      this.cadastrarPet.UseVisualStyleBackColor = true;
      this.cadastrarPet.Click += new System.EventHandler(this.cadastrarPet_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(173, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(155, 38);
      this.button1.TabIndex = 2;
      this.button1.Text = "Agendar Serviço";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(173, 56);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(155, 38);
      this.button2.TabIndex = 3;
      this.button2.Text = "Logoff";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 110);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "Total de Pets Atendidos:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 147);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(137, 15);
      this.label2.TabIndex = 5;
      this.label2.Text = "Total de Pets Registrados";
      // 
      // petsAtendidos
      // 
      this.petsAtendidos.AutoSize = true;
      this.petsAtendidos.Location = new System.Drawing.Point(151, 110);
      this.petsAtendidos.Name = "petsAtendidos";
      this.petsAtendidos.Size = new System.Drawing.Size(13, 15);
      this.petsAtendidos.TabIndex = 6;
      this.petsAtendidos.Text = "0";
      // 
      // registered
      // 
      this.registered.AutoSize = true;
      this.registered.Location = new System.Drawing.Point(155, 147);
      this.registered.Name = "registered";
      this.registered.Size = new System.Drawing.Size(13, 15);
      this.registered.TabIndex = 7;
      this.registered.Text = "0";
      // 
      // Home
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(351, 204);
      this.Controls.Add(this.registered);
      this.Controls.Add(this.petsAtendidos);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cadastrarPet);
      this.Controls.Add(this.cadastrarClient);
      this.Name = "Home";
      this.Text = "Home";
      this.Load += new System.EventHandler(this.Home_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cadastrarClient;
    private System.Windows.Forms.Button cadastrarPet;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label petsAtendidos;
    private System.Windows.Forms.Label registered;
  }
}