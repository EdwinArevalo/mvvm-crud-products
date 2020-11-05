 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Entity;

using System.Collections.ObjectModel;

namespace Semana04.Model
{
    public class ProductoModel
    {
        public ObservableCollection<Producto> Productos { get; set; }

        public bool Insertar(Producto producto)
        {
            return (new BProducto()).Insertar(producto);
        }

        public bool Actualizar(Producto producto)
        {
            return (new BProducto()).Actualizar(producto);
        }

        public ProductoModel()
        {
            var lista = (new BProducto().Listar(0));
            Productos = new ObservableCollection<Producto>(lista);
        }
    }
}
