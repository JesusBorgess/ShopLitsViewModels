using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;

namespace ShopList.Gui.ViewModels
{
    public  partial class ShopListViewModel : ObservableObject 
    {
        [ObservableProperty]
        private string _nombreDelArticulo = string.Empty;
        [ObservableProperty]
        private int _cantidad = 1;

        //private string _nombreDelArticulo = string.Empty;
        //private int _cantidad = 1;

        //public event NotifyCollectionChangedEventHandler? PropertyChanged;

        //public string NombreDelArticulo
        //{
        //    get => _nombreDelArticulo;
        //        set
        //    {
        //        if (_nombreDelArticulo != value)
        //        {
        //            _nombreDelArticulo = value;
        //            OnProPertyChanged(nameof(NombreDelArticulo));
        //        }
        //    }
        //}
        //public int Cantidad
        //{
        //    get => _cantidad;
        //    set
        //    {
        //        if ( _cantidad != value)
        //        {
        //            _cantidad = value;
        //            OnProPertyChanged(nameof(Cantidad));
        //        }
        //    }
        //}
        public ObservableCollection<ShopListItem> ShopList { get;}
        public ICommand AddShopListItemCommand
        {
            get;
            private set;
        }
        public ShopListViewModel()
        {
            ShopList = new ObservableCollection<ShopListItem>();
            CargarDatos();
            //AddShopListItemCommand = new Command(AddShopListItem);
        }
        [RelayCommand]
        public void AddShopListItem;

        
        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void AddShopListItem()
        {
            if (string.IsNullOrEmpty(NombreDelArticulo) || _cantidad <=0)
               
            {
                return;
            }
            Random generador = new Random();
            var item = new ShopListItem
            {
                Id = generador.Next(),
                Nombre = NombreDelArticulo,
                Cantidad = this.Cantidad,
                Comprado = false,
            };
            ShopList.Add(item);
            NombreDelArticulo = string.Empty;
            Cantidad = 1;
                
        }

        private void CargarDatos()
        {

            ShopList.Add(new ShopListItem()
            {
                Id = 1,
                Nombre = "Pan de caja",
                Cantidad = 1,
                Comprado = false,
            });
            ShopList.Add(new ShopListItem()
            {
                Id = 1,
                Nombre = "Leche",
                Cantidad = 3,
                Comprado = false,
            });
            ShopList.Add(new ShopListItem()
            {
                Id = 1,
                Nombre = "Queso",
                Cantidad = 100,
                Comprado = false,
            });
        }

        //private void OnProPertyChanged (string propertyName)
        //{
        //    PropertyChanged?.Invoke(
        //        this,
        //        new PropertyChangingEventArgs(propertyName));
        //}

    

    }
}
