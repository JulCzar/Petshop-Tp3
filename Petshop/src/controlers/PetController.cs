using Petshop.src.dao;
using Petshop.src.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.controlers {
  class PetController : Controller<Pet> {
    public override void Create(Pet param) {
      PetDao dao = new();
      dao.Create(param);
    }

    public override void Destroy(Pet param) {
      PetDao dao = new();
      dao.Destroy(param);
    }

    public override void Edit(Pet param) {
      PetDao dao = new();
      dao.Edit(param);
    }

    public override List<Pet> Index() {
      PetDao dao = new();
      return dao.Index();
    }

    public override Pet Show(int id) {
      PetDao dao = new();
      return dao.Show(id);
    }
  }
}
