using Petshop.src.dao;
using Petshop.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.controlers {
  class ClientController : Controller<Client> {
    public override void Create(Client param) {
      ClientDao dao = new();
      dao.Create(param);
    }

    public override void Destroy(Client param) {
      ClientDao dao = new();
      dao.Create(param);
    }

    public override void Edit(Client param) {
      ClientDao dao = new();
      dao.Edit(param);
    }

    public override List<Client> Index() {
      ClientDao dao = new();
      return dao.Index();
    }

    public override Client Show(int id) {
      ClientDao dao = new();
      return dao.Show(id);
    }
  }
}
