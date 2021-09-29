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
  class ClientDao : DAO<Client> {
    public override void Create(Client param) {
      SqlCommand clientCmd = new(@"INSERT INTO client(name, status, email, birthdate, cpf, rg, address_id) VALUES(@name, @status, @email, @birthdate, @cpf, @rg, @addressId)", Con);
      SqlCommand addressCmd = new(@"INSERT INTO address(cep, number, street, district, city, state, aditional) VALUES(@cep, @number, @street, @district, @city, @state, @aditional)", Con);

      // Cliente
      clientCmd.Parameters.Add("@name", SqlDbType.VarChar).Value = param.Name;
      clientCmd.Parameters.Add("@status", SqlDbType.TinyInt).Value = 1;
      clientCmd.Parameters.Add("@email", SqlDbType.VarChar).Value = param.Email;
      clientCmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = param.Birthdate;
      clientCmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = param.Cpf;
      clientCmd.Parameters.Add("@rg", SqlDbType.VarChar).Value = param.Rg;
      // Endereço
      addressCmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = param.Address.Cep;
      addressCmd.Parameters.Add("@number", SqlDbType.VarChar).Value = param.Address.Number;
      addressCmd.Parameters.Add("@street", SqlDbType.VarChar).Value = param.Address.Street;
      addressCmd.Parameters.Add("@district", SqlDbType.VarChar).Value = param.Address.District;
      addressCmd.Parameters.Add("@city", SqlDbType.VarChar).Value = param.Address.City;
      addressCmd.Parameters.Add("@state", SqlDbType.VarChar).Value = param.Address.State;
      addressCmd.Parameters.Add("@aditional", SqlDbType.VarChar).Value = param.Address.Aditional;

      Con = Connect();
      SqlTransaction tran = Con.BeginTransaction();

      try {
        addressCmd.Transaction = tran;
        clientCmd.Transaction = tran;
        var id = Convert.ToInt32(addressCmd.ExecuteScalar());
        clientCmd.Parameters.Add("@addressId", SqlDbType.Int).Value = id;
        clientCmd.ExecuteNonQuery();
        tran.Commit();
        MessageBox.Show("Enviado Com Sucesso");
      } catch (SqlException ex) {
        tran.Rollback();

        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Con = Disconnect();
      }
    }

    public override void Destroy(Client param) {
      throw new NotImplementedException();
    }

    public override void Edit(Client param) {
      throw new NotImplementedException();
    }

    public override List<Client> Index() {
      SqlCommand cmd = new("select * from client order by id");
      List<Client> clientList = new();
      SqlDataReader dr;

      try {
        Connect();
        cmd.Connection = Con;
        dr = cmd.ExecuteReader();
        if (dr.HasRows) {
          while (dr.Read()) {
            Client aux = new();
            aux.Address = new Address();
            aux.Id = Convert.ToInt32(dr["id"].ToString());
            aux.Rg = dr["rg"].ToString();
            aux.Cpf = dr["cpf"].ToString();
            aux.Name = dr["name"].ToString();
            aux.Email = dr["email"].ToString();
            aux.Status = Convert.ToInt32(dr["status"].ToString()) == 1;
            aux.Address.Id = Convert.ToInt32(dr["address_id"].ToString());
            aux.Birthdate = Convert.ToDateTime(dr["birthdate"].ToString());
            clientList.Add(aux);
          }
        }
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Disconnect();
      }
      return clientList;
    }

    public override Client Show(int id) {
      SqlCommand cmd = new();
      Client client = new();
      SqlDataReader dr;

      cmd.CommandText = "SELECT * FROM client WHERE id = @idClient";
      cmd.Parameters.Add("@idClient", SqlDbType.Int).Value = id;

      try {
        Connect();
        cmd.Connection = Con;
        dr = cmd.ExecuteReader();

        if (dr.HasRows) {
          while (dr.Read()) {
            Client aux = new();
            client.Address = new Address();
            client.Id = Convert.ToInt32(dr["id"].ToString());
            client.Rg = dr["rg"].ToString();
            client.Cpf = dr["cpf"].ToString();
            client.Name = dr["name"].ToString();
            client.Email = dr["email"].ToString();
            client.Status = Convert.ToInt32(dr["status"].ToString()) == 1;
            client.Address.Id = Convert.ToInt32(dr["address_id"].ToString());
            client.Birthdate = Convert.ToDateTime(dr["birthdate"].ToString());
          }
        }
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Disconnect();
      }
      return client;
    }
  }
}
