using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.models {
  class Address {
    private string _cep;
    private string _number;
    private string _street;
    private string _district;
    private string _aditional;
    private string _state;
    private string _city;
    private int _id;

    public int Id {
      get => _id;
      set => _id = value;
    }

    public string Cep {
      get => _cep;
      set => _cep = value;
    }

    public string Number {
      get => _number;
      set => _number = value;
    }

    public string Street {
      get => _street;
      set => _street = value;
    }

    public string District {
      get => _district;
      set => _district = value;
    }

    public string Aditional {
      get => _aditional;
      set => _aditional = value;
    }

    public string City {
      get => _city;
      set => _city = value;
    }

    public string State {
      get => _state;
      set => _state = value;
    }
  }
}
