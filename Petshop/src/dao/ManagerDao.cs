using Petshop.src.aplication;
using Petshop.src.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop.src.dao {
  class ManagerDao : DAO<Manager> {
    public override void Create(Manager param) {
      SqlCommand cmd = new(@"INSERT INTO manager(name, email, password, birthdate, cpf, rg) VALUES(@name, @email, @password, @birthdate, @cpf, @rg)", Con);

      cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = param.Name;
      cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = param.Email;
      cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = Encrypt.Sha256(param.Password);
      cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = param.Birthdate;
      cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = param.Cpf;
      cmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = param.Rg;

      try {
        Con = Connect();
        cmd.ExecuteNonQuery();
        MessageBox.Show("Enviado Com Sucesso");
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Con = Disconnect();
      }
    }

    public override void Destroy(Manager param) {
      throw new NotImplementedException();
    }

    public override void Edit(Manager param) {
      throw new NotImplementedException();
    }

    public override List<Manager> Index() {
      throw new NotImplementedException();
    }

    public override Manager Show(int id) {
      throw new NotImplementedException();
    }

    public Manager Login(Manager man) {
      Manager result = null;
      SqlDataReader dr;

      SqlCommand cmd = new(@"SELECT * FROM manager WHERE email = @email AND password = @password", Con);
      cmd.Parameters.AddWithValue("@email", man.Email);
      cmd.Parameters.AddWithValue("@password", Encrypt.Sha256(man.Password));

      try {
        Connect();
        cmd.Connection = Con;
        dr = cmd.ExecuteReader();

        if (dr.HasRows) {
          result = new Manager();
          while (dr.Read()) {
            result.Id = Convert.ToInt32(dr["id"].ToString());
            result.Birthdate = Convert.ToDateTime(dr["birthdate"].ToString());
            result.Cpf = dr["cpf"].ToString();
            result.Email = dr["email"].ToString();
            result.Name = dr["name"].ToString();
            result.Rg = dr["rg"].ToString();
          }
        }
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Disconnect();
      }
      return result;
    }
  }
}
