using Petshop.src.controlers;
using Petshop.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop.src.views {
  public partial class AgendarServico : Form {
    public AgendarServico() {
      InitializeComponent();
    }

    private void button4_Click(object sender, EventArgs e) {
      Home home = new();
      this.Hide();
      home.Show();
    }

    private void button1_Click(object sender, EventArgs e) {
      if (name.Text == ""
        || value.Text == ""
        || details.Text == ""
        || pet.Text == ""
      ) {
        warn.Text = "Falta preencher alguns campos!";
        return;
      }

      Service serv = new();
      serv.Pet = new Pet();

      serv.Name = name.Text;
      serv.Details = details.Text;
      serv.Value = Convert.ToDouble(value.Text);
      serv.Pet.Name = pet.Text;

      ServiceController cont = new();
      cont.Create(serv);
    }
  }
}
