
namespace Petshop.src.views {
  partial class CadastrarPet {
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
      this.label1 = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.race = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.weight = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.aditional = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.client_id = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.birthdate = new System.Windows.Forms.MaskedTextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.warn = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 15);
      this.label1.TabIndex = 17;
      this.label1.Text = "Nome";
      // 
      // name
      // 
      this.name.Location = new System.Drawing.Point(12, 38);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(339, 23);
      this.name.TabIndex = 16;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 15);
      this.label2.TabIndex = 19;
      this.label2.Text = "Raça";
      // 
      // race
      // 
      this.race.Location = new System.Drawing.Point(12, 92);
      this.race.Name = "race";
      this.race.Size = new System.Drawing.Size(339, 23);
      this.race.TabIndex = 18;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(11, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 15);
      this.label4.TabIndex = 23;
      this.label4.Text = "Peso";
      // 
      // weight
      // 
      this.weight.Location = new System.Drawing.Point(12, 145);
      this.weight.Name = "weight";
      this.weight.Size = new System.Drawing.Size(339, 23);
      this.weight.TabIndex = 22;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 231);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(121, 15);
      this.label5.TabIndex = 25;
      this.label5.Text = "Informação Adicional";
      // 
      // aditional
      // 
      this.aditional.Location = new System.Drawing.Point(12, 249);
      this.aditional.Name = "aditional";
      this.aditional.Size = new System.Drawing.Size(339, 23);
      this.aditional.TabIndex = 24;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(11, 283);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 15);
      this.label6.TabIndex = 27;
      this.label6.Text = "Id do cliente";
      // 
      // client_id
      // 
      this.client_id.Location = new System.Drawing.Point(12, 301);
      this.client_id.Name = "client_id";
      this.client_id.Size = new System.Drawing.Size(339, 23);
      this.client_id.TabIndex = 26;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 178);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 15);
      this.label3.TabIndex = 29;
      this.label3.Text = "Data de Nascimento";
      this.label3.Click += new System.EventHandler(this.label3_Click_1);
      // 
      // birthdate
      // 
      this.birthdate.Location = new System.Drawing.Point(11, 196);
      this.birthdate.Mask = "00/00/0000";
      this.birthdate.Name = "birthdate";
      this.birthdate.Size = new System.Drawing.Size(339, 23);
      this.birthdate.TabIndex = 28;
      this.birthdate.ValidatingType = typeof(System.DateTime);
      this.birthdate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.birthdate_MaskInputRejected);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(240, 388);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 39);
      this.button1.TabIndex = 30;
      this.button1.Text = "Cadastrar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(-204, 206);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(116, 39);
      this.button2.TabIndex = 32;
      this.button2.Text = "Voltar";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button3.Location = new System.Drawing.Point(463, 206);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(110, 39);
      this.button3.TabIndex = 31;
      this.button3.Text = "Cadastrar";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(10, 388);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(116, 39);
      this.button4.TabIndex = 34;
      this.button4.Text = "Voltar";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // warn
      // 
      this.warn.AutoSize = true;
      this.warn.Location = new System.Drawing.Point(136, 13);
      this.warn.Name = "warn";
      this.warn.Size = new System.Drawing.Size(0, 15);
      this.warn.TabIndex = 35;
      // 
      // CadastrarPet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 450);
      this.Controls.Add(this.warn);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.birthdate);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.client_id);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.aditional);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.weight);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.race);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.name);
      this.Name = "CadastrarPet";
      this.Text = "CadastrarPet";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox race;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox weight;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox aditional;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox client_id;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox birthdate;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label warn;
  }
}