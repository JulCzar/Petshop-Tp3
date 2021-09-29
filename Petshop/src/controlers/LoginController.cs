using Petshop.src.dao;
using Petshop.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.controlers {
  class LoginController {
    public static Manager Login(Manager man) {
      ManagerDao dao = new();
      return dao.Login(man);
    }
  }
}
