using Petshop.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.aplication {
  static class State {
    private static Manager _loggedUser;

    public static Manager LoggedUser {
      get => _loggedUser;
      set => _loggedUser = value;
    }
  }
}
