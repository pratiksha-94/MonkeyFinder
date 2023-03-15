

using beautyShopApp.Models;
using beautyShopApp.Services;
using System.Collections.ObjectModel;

namespace beautyShopApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<Product> _products;

        public HomeViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            Products = new ObservableCollection<Product>();

            Products.Add(new Product());

            foreach (var product in ProductService.Instance.GetProducts())
                Products.Add(product);
        }

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

    }
}
