using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.models {
  class Service {
    private string _details;
    private double _value;
    private string _name;
    private Pet _pet;
    private int _id;

    public int Id {
      get => _id;
      set => _id = value;
    }

    public string Details {
      get => _details;
      set => _details = value;
    }
    public double Value {
      get => _value;
      set => _value = value;
    }
    public string Name {
      get => _name;
      set => _name = value;
    }
    internal Pet Pet {
      get => _pet;
      set => _pet = value;
    }
  }
}
