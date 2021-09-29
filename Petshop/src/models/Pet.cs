using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.models {
  class Pet {
    private string _name;
    private string _race;
    private double _weight;
    private Client _client;
    private DateTime _birthdate;
    private string _aditional;
    private int _id;

    public int Id {
      get => _id;
      set => _id = value;
    }

    public string Name {
      get => _name;
      set => _name = value;
    }

    public string Race {
      get => _race;
      set => _race = value;
    }

    public double Weight {
      get => _weight;
      set => _weight = value;
    }

    public DateTime Birthdate {
      get => _birthdate;
      set => _birthdate = value;
    }

    public string Aditional {
      get => _aditional;
      set => _aditional = value;
    }

    public Client Client {
      get => _client;
      set => _client = value;
    }
  }
}
