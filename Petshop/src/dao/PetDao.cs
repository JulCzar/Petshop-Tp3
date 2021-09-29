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
  class PetDao : DAO<Pet> {
    public override void Create(Pet param) {
      SqlCommand cmd = new SqlCommand(@"insert into pet(name, race, weight, birthdate, aditional, client_id) values(@name, @race, @weight, @birthdate, @aditional, @client_id)", Con);

      cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = param.Name;
      cmd.Parameters.Add("@race", SqlDbType.VarChar).Value = param.Race;
      cmd.Parameters.Add("@weight", SqlDbType.Decimal).Value = param.Weight;
      cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = param.Birthdate;
      cmd.Parameters.Add("@aditional", SqlDbType.VarChar).Value = param.Aditional;
      cmd.Parameters.Add("@client_id", SqlDbType.Int).Value = param.Client.Id;

      MessageBox.Show("Enviado Com Sucesso");
      try {
        Con = Connect();

        cmd.ExecuteNonQuery();
      } catch (SqlException ex) {
        Console.WriteLine("Erro: " + ex.Message);

      } finally {
        Con = Disconnect();
      }
    }

    public override void Destroy(Pet param) {
      throw new NotImplementedException();
    }

    public override void Edit(Pet param) {
      throw new NotImplementedException();
    }

    public override List<Pet> Index() {
      List<Pet> exist = new();
      SqlCommand cmd = new();
      SqlDataReader dr;

      cmd.CommandText = "select * from pet order by id";

      try {
        Connect();
        cmd.Connection = Con;
        dr = cmd.ExecuteReader();
        if (dr.HasRows) {
          while (dr.Read()) {
            Pet aux = new();
            aux.Id = int.Parse(dr["id"].ToString());
            aux.Name = dr["name"].ToString();
            aux.Race = dr["race"].ToString();
            aux.Weight = Convert.ToDouble(dr["weight"].ToString());
            aux.Birthdate = Convert.ToDateTime(dr["birthdate"].ToString());
            aux.Aditional = dr["aditional"].ToString();
            exist.Add(aux);
          }
        }
      } catch (SqlException ex) {
        Console.WriteLine("Erro: " + ex.Message);
      } finally {
        Disconnect();
      }
      return exist;
    }

    public override Pet Show(int id) {
      SqlCommand cmd = new();
      SqlDataReader dr;
      Pet aux = new();

      cmd.CommandText = "SELECT * FROM pet WHERE id = @idPet";
      cmd.Parameters.Add("@idPet", SqlDbType.Int).Value = id;

      try {
        Connect();
        cmd.Connection = Con;
        dr = cmd.ExecuteReader();
        if (dr.HasRows) {
          while (dr.Read()) {
            aux.Id = int.Parse(dr["id"].ToString());
            aux.Name = dr["name"].ToString();
            aux.Race = dr["race"].ToString();
            aux.Weight = Convert.ToDouble(dr["weight"].ToString());
            aux.Birthdate = Convert.ToDateTime(dr["birthdate"].ToString());
            aux.Aditional = dr["aditional"].ToString();
          }
        }
      } catch (SqlException ex) {
        Console.WriteLine("Erro: " + ex.Message);
      } finally {
        Disconnect();
      }
      return aux;
    }

    public string getTotalRegistered() {
      SqlCommand cmd = new("select count(id) as total from pet", Con);
      string result = "";
      Con = Connect();

      try {
        result = cmd.ExecuteScalar().ToString();
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Con = Disconnect();
      }
      return result;
    }
  }
}
