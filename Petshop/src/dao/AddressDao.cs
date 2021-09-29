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
  class AddressDao : DAO<Address> {
    public override void Create(Address param) {
      SqlCommand cmd = new(@"INSERT INTO address(cep, number, street, district, city, state, aditional) VALUES(@cep, @number, @street, @district, @city, @state, @aditional)", Con);
      cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = param.Cep;
      cmd.Parameters.Add("@number", SqlDbType.VarChar).Value = param.Number;
      cmd.Parameters.Add("@street", SqlDbType.VarChar).Value = param.Street;
      cmd.Parameters.Add("@district", SqlDbType.VarChar).Value = param.District;
      cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = param.City;
      cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = param.State;
      cmd.Parameters.Add("@aditional", SqlDbType.VarChar).Value = param.Aditional;

      try {
        Con = Connect();

        cmd.ExecuteNonQuery();
      } catch (SqlException ex) {
        Console.WriteLine("Erro: " + ex.Message);

      } finally {
        Con = Disconnect();
      }
    }

    public override void Destroy(Address param) {
      throw new NotImplementedException();
    }

    public override void Edit(Address param) {
      throw new NotImplementedException();
    }

    public override List<Address> Index() {
      throw new NotImplementedException();
    }

    public override Address Show(int id) {
      SqlCommand cmd = new("SELECT * FROM address WHERE id = @id", Con);
      SqlDataReader dr;
      Address p = new();

      cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

      try {
        Connect();
        dr = cmd.ExecuteReader();

        if (dr.HasRows) {
          while (dr.Read()) {
            p.Id = Convert.ToInt32(dr["id"].ToString());
            p.Cep = dr["cep"].ToString();
            p.Street = dr["street"].ToString();
            p.Number = dr["number"].ToString();
            p.District = dr["district"].ToString();
            p.City = dr["city"].ToString();
            p.State = dr["state"].ToString();
            p.Aditional = dr["aditional"].ToString();
          }
        }
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Disconnect();
      }

      return p;
    }
  }
}
