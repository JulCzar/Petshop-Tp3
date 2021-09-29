using Petshop.src.dao;
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
  public partial class CadastrarPet : Form {
    public CadastrarPet() {
      InitializeComponent();
    }

    private void label3_Click(object sender, EventArgs e) {

    }

    private void label3_Click_1(object sender, EventArgs e) {

    }

    private void birthdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

    }

    private void button4_Click(object sender, EventArgs e) {
      Home home = new();
      this.Hide();
      home.Show();
    }

    private void button1_Click(object sender, EventArgs e) {
      if (name.Text == ""
        || name.Text == ""
        || race.Text == ""
        || weight.Text == ""
        || birthdate.Text == ""
        || client_id.Text == ""
      ) {
        warn.Text = "Falta preencher alguns campos!";
        return;
      }

      Pet pet = new();
      pet.Client= new Client();

      pet.Client.Id = Convert.ToInt32(client_id.Text);
      pet.Name = name.Text;
      pet.Race = race.Text;
      pet.Weight = Convert.ToDouble(weight.Text);
      pet.Birthdate = Convert.ToDateTime(birthdate.Text);
      pet.Aditional = aditional.Text;

      PetDao dao = new();
      dao.Create(pet);
    }
  }
}
