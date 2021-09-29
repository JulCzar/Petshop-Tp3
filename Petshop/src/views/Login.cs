using Petshop.src.aplication;
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
  public partial class Login : Form {
    public Login() {
      InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e) {

    }

    private void ClearHelpers() {
      label3.Text = "";
      passwordHelper.Text = "";
      warn.Text = "";
    }

    private void loginBtn_Click(object sender, EventArgs e) {
      ClearHelpers();
      if (email.Text == "") label3.Text = "O email não pode ficar Vazio";
      if (password.Text == "") passwordHelper.Text = "A senha não pode ficar vazia";
      if (password.Text == "" || email.Text == "") return;

      Manager loginAux = new();
      loginAux.Email = email.Text;
      loginAux.Password = password.Text;

      Manager user = LoginController.Login(loginAux);

      if (user != null) {
        State.LoggedUser = user;
        Home home = new();
        this.Hide();
        home.Show();
      } else {
        warn.Text = "Usuário ou senha incorreto!";
      }
    }

    private void password_TextChanged(object sender, EventArgs e) {

    }

    private void button2_Click(object sender, EventArgs e) {
      Cadastrar cada = new();
      cada.Show();
      this.Hide();
    }
  }
}
