using Petshop.src.models;
using Petshop.src.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.controlers {
  class ServiceController : Controller<Service> {
    public override void Create(Service param) {
      ServiceDao dao = new();
      dao.Create(param);
    }

    public override void Destroy(Service param) {
      ServiceDao dao = new();
      dao.Destroy(param);
    }

    public override void Edit(Service param) {
      ServiceDao dao = new();
      dao.Edit(param);
    }

    public override List<Service> Index() {
      ServiceDao dao = new();
      return dao.Index();
    }

    public override Service Show(int id) {
      ServiceDao dao = new();
      return dao.Show(id);
    }
  }
}
