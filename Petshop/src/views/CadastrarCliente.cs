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
  public partial class CadastrarCliente : Form {
    public CadastrarCliente() {
      InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e) {

    }

    private void button2_Click(object sender, EventArgs e) {

    }

    private void warn_Click(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {

    }

    private void rg_Click(object sender, EventArgs e) {

    }

    private void textBox1_TextChanged(object sender, EventArgs e) {

    }

    private void label4_Click(object sender, EventArgs e) {

    }

    private void cpf_TextChanged(object sender, EventArgs e) {

    }

    private void label3_Click(object sender, EventArgs e) {

    }

    private void Nome_Click(object sender, EventArgs e) {

    }

    private void name_TextChanged(object sender, EventArgs e) {

    }

    private void label2_Click(object sender, EventArgs e) {

    }

    private void password_TextChanged(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void email_TextChanged(object sender, EventArgs e) {

    }

    private void CadastrarCliente_Load(object sender, EventArgs e) {

    }

    private void button2_Click_1(object sender, EventArgs e) {
      Home home = new();
      this.Hide();
      home.Show();
    }

    private void cep_KeyUp(object sender, KeyEventArgs e) {
      if (cep.Text.Length < 9) return;

      using (var ws = new WSCorreio.AtendeClienteClient()) {
        var resultado = ws.consultaCEP(cep.Text);
        street.Text = resultado.end;
        aditional.Text = resultado.complemento2;
        city.Text = resultado.cidade;
        district.Text = resultado.bairro;
        state.Text = resultado.uf;
      }
    }

    private void button1_Click_1(object sender, EventArgs e) {
      if (name.Text == ""
        || email.Text == ""
        || cep.Text == ""
        || cpf.Text == ""
        || rg.Text == ""
        || birthdate.Text == ""
        || street.Text == ""
        || district.Text == ""
        || number.Text == ""
        || city.Text == ""
        || state.Text == ""
      ) {
        warn.Text = "Falta preencher alguns campos!";
        return;
      }

      Address address = new();
      address.Cep = cep.Text;
      address.Street = street.Text;
      address.District = district.Text;
      address.City = city.Text;
      address.State = state.Text;
      address.Number = number.Text;
      address.Aditional = aditional.Text;

      Client client = new();
      client.Name = name.Text;
      client.Email = email.Text;
      client.Cpf = cpf.Text;
      client.Rg = rg.Text;
      client.Birthdate = Convert.ToDateTime(birthdate.Text);
      client.Address = address;

      ClientDao dao = new();
      dao.Create(client);
    }
  }
}
