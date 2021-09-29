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
  public partial class Cadastrar : Form {
    public Cadastrar() {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {
      if (name.Text == "" || email.Text == "" || password.Text == "" || cpf.Text == "" || rg.Text == "" || birthdate.Text == "") {
        warn.Text = "Falta preencher alguns campos!";
        return;
      }
      Manager man = new();
      man.Name = name.Text;
      man.Email = email.Text;
      man.Password = password.Text;
      man.Cpf = cpf.Text;
      man.Rg = rg.Text;
      man.Birthdate = Convert.ToDateTime(birthdate.Text);

      ManagerDao dao = new();
      dao.Create(man);
    }

    private void button2_Click(object sender, EventArgs e) {
      Login login = new();
      this.Hide();
      login.Show();
    }
  }
}
