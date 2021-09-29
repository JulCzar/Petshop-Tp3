using Petshop.src.aplication;
using Petshop.src.dao;
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
  public partial class Home : Form {
    public Home() {
      InitializeComponent();
      PetDao petDao = new();
      ServiceDao servDao = new();

      registered.Text = petDao.getTotalRegistered();
      petsAtendidos.Text = servDao.getTotalRegistered();
    }

    private void button2_Click(object sender, EventArgs e) {
      State.LoggedUser = null;
      Login home = new();
      this.Hide();
      home.Show();
    }

    private void cadastrarClient_Click(object sender, EventArgs e) {
      CadastrarCliente cad = new();
      this.Hide();
      cad.Show();
    }

    private void cadastrarPet_Click(object sender, EventArgs e) {
      CadastrarPet scr = new();
      scr.Show();
      this.Hide();
    }

    private void button1_Click(object sender, EventArgs e) {
      AgendarServico serv = new();
      this.Hide();
      serv.Show();
    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void Home_Load(object sender, EventArgs e) {

    }
  }
}
