using System.Collections.ObjectModel; 
using System.Windows.Input;
using System.Windows; 
using Entity;

namespace Semana04.ViewModel
{
    public class ListaProductoViewModel : ViewModelBase
    {
        public ObservableCollection<Producto> Productos { get; set; }

        public ICommand NuevoCommand { get; set; }
        public ICommand ConsultarCommand { get; set; }
        public ListaProductoViewModel()
        {
            Productos = new Model.ProductoModel().Productos;

            NuevoCommand = new RelayCommand<Window>(
                param => Abrir()
            );

            ConsultarCommand = new RelayCommand<object>(
                o => { Productos = (new Model.ProductoModel()).Productos; }
            );

            void Abrir()
            {
                View.ManProducto window = new View.ManProducto();
                window.ShowDialog();
            }
        }

    }
}
