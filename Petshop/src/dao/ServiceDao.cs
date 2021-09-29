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
  class ServiceDao : DAO<Service> {
    public override void Create(Service param) {
      SqlCommand cmd = new(@"insert into service(name, value, details, pet_name) values(@name, @value, @details, @pet)", Con);
      cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = param.Name;
      cmd.Parameters.Add("@value", SqlDbType.Decimal).Value = param.Value;
      cmd.Parameters.Add("@details", SqlDbType.VarChar).Value = param.Details;
      cmd.Parameters.Add("@pet", SqlDbType.VarChar).Value = param.Pet.Name;

      Con = Connect();

      try {
        cmd.ExecuteNonQuery();
        MessageBox.Show("Enviado Com Sucesso");
      } catch (SqlException ex) {
        MessageBox.Show("Erro: " + ex.Message);
      } finally {
        Con = Disconnect();
      }
    }

    public override void Destroy(Service param) {
      throw new NotImplementedException();
    }

    public override void Edit(Service param) {
      throw new NotImplementedException();
    }

    public override List<Service> Index() {
      throw new NotImplementedException();
    }

    public override Service Show(int id) {
      throw new NotImplementedException();
    }

    public string getTotalRegistered() {
      SqlCommand cmd = new("select count(id) as total from service", Con);
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
