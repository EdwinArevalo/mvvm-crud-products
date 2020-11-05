using System.Windows;
using Semana04.ViewModel;

namespace Semana04.View
{
    /// <summary>
    /// Lógica de interacción para ListaProducto.xaml
    /// </summary>
    public partial class ListaProducto : Window
    {
        ListaProductoViewModel viewModel;
        public ListaProducto()
        {
            InitializeComponent();
            viewModel = new ListaProductoViewModel();
            this.DataContext = viewModel;
        }
    }
}