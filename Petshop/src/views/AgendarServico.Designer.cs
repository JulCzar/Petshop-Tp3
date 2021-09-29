
namespace Petshop.src.views {
  partial class AgendarServico {
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
      this.value = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.details = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.pet = new System.Windows.Forms.ComboBox();
      this.button4 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.warn = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 15);
      this.label1.TabIndex = 19;
      this.label1.Text = "Exame";
      // 
      // name
      // 
      this.name.Location = new System.Drawing.Point(12, 43);
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size(339, 23);
      this.name.TabIndex = 18;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 15);
      this.label2.TabIndex = 21;
      this.label2.Text = "Valor";
      // 
      // value
      // 
      this.value.Location = new System.Drawing.Point(12, 98);
      this.value.Name = "value";
      this.value.Size = new System.Drawing.Size(339, 23);
      this.value.TabIndex = 20;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 136);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 15);
      this.label3.TabIndex = 23;
      this.label3.Text = "Detalhes";
      // 
      // details
      // 
      this.details.Location = new System.Drawing.Point(11, 154);
      this.details.Name = "details";
      this.details.Size = new System.Drawing.Size(339, 23);
      this.details.TabIndex = 22;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(11, 191);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(24, 15);
      this.label4.TabIndex = 25;
      this.label4.Text = "Pet";
      // 
      // pet
      // 
      this.pet.FormattingEnabled = true;
      this.pet.Items.AddRange(new object[] {
            "kadu",
            "leo",
            "bidu"});
      this.pet.Location = new System.Drawing.Point(12, 210);
      this.pet.Name = "pet";
      this.pet.Size = new System.Drawing.Size(338, 23);
      this.pet.TabIndex = 26;
      this.pet.Text = "Pet";
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(12, 399);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(116, 39);
      this.button4.TabIndex = 36;
      this.button4.Text = "Voltar";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(240, 399);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 39);
      this.button1.TabIndex = 35;
      this.button1.Text = "Agendar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // warn
      // 
      this.warn.AutoSize = true;
      this.warn.Location = new System.Drawing.Point(165, 9);
      this.warn.Name = "warn";
      this.warn.Size = new System.Drawing.Size(0, 15);
      this.warn.TabIndex = 37;
      // 
      // AgendarServico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(369, 450);
      this.Controls.Add(this.warn);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pet);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.details);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.value);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.name);
      this.Name = "AgendarServico";
      this.Text = "AgendarServico";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox name;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox value;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox details;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox pet;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label warn;
  }
}