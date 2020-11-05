using System;
using System.Windows;
using System.Windows.Input;
using Business;
using System.Collections.Generic;
using Semana04.Model;
namespace Semana04.ViewModel
{
    public class ManProductoViewModel : ViewModelBase
    {

        #region propiedades
        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre != value)
                {
                    _Nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Cantidad;
        public string Cantidad
        {
            get { return _Cantidad; }
            set
            {
                if (_Cantidad != value)
                {
                    _Cantidad = value;
                    OnPropertyChanged();
                }
            }
        }

        int _Precio;
        public int Precio
        {
            get { return _Precio; }
            set
            {
                if (_Precio != value)
                {
                    _Precio = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand GrabarCommand { get; set; }
        public ICommand CerrarCommand { get; set; }

        public ManProductoViewModel()
        {
            GrabarCommand = new RelayCommand<object>(
                o =>
                {
                    if (ID > 0)
                        new ProductoModel().Actualizar(new Entity.Producto
                        {
                            IdProducto = ID,
                            NombreProducto  = Nombre,
                            CantidadPorUnidad = Cantidad,
                            PrecioUnidad = Precio
                        });
                    else
                        new ProductoModel().Insertar(new Entity.Producto
                        {
                            NombreProducto = Nombre,
                            CantidadPorUnidad = Cantidad,
                            PrecioUnidad = Precio
                        });

                });

            CerrarCommand = new RelayCommand<Window>(
                param => Cerrar(param)
                );
        }

        void Cerrar(Window window)
        {
            window.Close();
        }

    }
}
