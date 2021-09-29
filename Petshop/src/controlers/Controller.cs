using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.src.controlers {
  abstract class Controller<T> {
    public abstract void Create(T param);

    public abstract void Destroy(T param);

    public abstract void Edit(T param);

    public abstract List<T> Index();

    public abstract T Show(int id);
  }
}
