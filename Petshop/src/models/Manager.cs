using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.models {
  class Manager {
    private string _name;
    private string _email;
    private DateTime _birthdate;
    private string _password;
    private string _cpf;
    private string _rg;
    private int _id;

    public int Id {
      get => _id;
      set => _id = value;
    }

    public string Name {
      get => _name;
      set => _name = value;
    }

    public string Email {
      get => _email;
      set => _email = value;
    }
    public string Password {
      get => _password;
      set => _password = value;
    }

    public DateTime Birthdate {
      get => _birthdate;
      set => _birthdate = value;
    }

    public string Cpf {
      get => _cpf;
      set => _cpf = value;
    }

    public string Rg {
      get => _rg;
      set => _rg = value;
    }
  }
}
