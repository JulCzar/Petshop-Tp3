using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.dao {
  abstract class DAO<T> {
    private static SqlConnection _con = new SqlConnection();

    public DAO() {
      _con.ConnectionString = @"Data Source=JULCZARPC\SQLEXPRESS;Initial Catalog=Petshop;Integrated Security=True";
    }

    public static SqlConnection Connect() {
      if (_con.State == System.Data.ConnectionState.Closed) {
        _con.Open();
      }
      return _con;
    }

    public SqlConnection Con {
      get => _con;
      set => _con = value;
    }
    public static SqlConnection Disconnect() {
      if (_con.State == System.Data.ConnectionState.Open)
        _con.Close();
      return _con;
    }

    public abstract void Create(T param);
    public abstract void Destroy(T param);
    public abstract void Edit(T param);
    public abstract List<T> Index();
    public abstract T Show(int id);
  }
}
