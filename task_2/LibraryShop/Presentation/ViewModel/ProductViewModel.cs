using Presentation.ViewModel.MVVM;
using Service.API;
using Service.data_files;
using System;
using System.Collections.Generic;


namespace Presentation.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        private IProductService service;
        public ProductViewModel(ProductService service)
        {
            this.service = service;
        }
        public ProductViewModel()
        {
            service = new ProductService();
            AddProductCommand = new RelayCommand(AddProduct);
            UpdateProductCommand = new RelayCommand(UpdateProduct);
            DeleteProductCommand = new RelayCommand(DeleteProduct);
            RefreshProductsCommand = new RelayCommand(RefreshProducts);
            ShowEventsCommand = new RelayCommand(ShowProductsWindow);
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }

        private bool isAvailable;
        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
            set
            {
                isAvailable = value;
                OnPropertyChanged("IsAvailable");
            }
        }


        public RelayCommand AddProductCommand { get; private set; }
        public RelayCommand UpdateProductCommand { get; private set; }
        public RelayCommand DeleteProductCommand { get; private set; }
        public RelayCommand RefreshProductsCommand { get; private set; }
        public RelayCommand ShowEventsCommand { get; private set; }

        private void AddProduct()
        {
            bool added = service.AddProduct(ID, Name);
            if (added)
            {
                text = "Product added";
            }
            else
            {
                text = "Cannot add Product";
            }
            MessageBoxShowDelegate(Text);
        }

        private IProductData currentProduct;
        public IProductData CurrentProduct
        {
            get => currentProduct;
            set
            {
                currentProduct = value;
                OnPropertyChanged("CurrentProduct");
            }
        }
        private void UpdateProduct()
        {
            bool updated = service.UpdateProduct(ID,Name);
            if (updated)
            {
                text = "Product updated";
            }
            else
            {
                text = "Cannot update product";
            }
            MessageBoxShowDelegate(Text);
        }

        private void DeleteProduct()
        {
            bool deleted = service.DeleteProduct(ID);
            if (deleted)
            {
                text = "Product deleted";
            }
            else
            {
                text = "Cannot delete product";
            }
            MessageBoxShowDelegate(Text);
        }

        private void RefreshProducts()
        {
            Products = service.GetProducts();
        }

        private IEnumerable<IProductData> products;
        public IEnumerable<IProductData> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
                OnPropertyChanged("Products");
            }
        }

        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }
        public Lazy<IWindow> ChildWindow { get; set; }

        private void ShowProductsWindow()
        {
            IWindow window = ChildWindow.Value;
            window.Show();
        }

        public Action<string> MessageBoxShowDelegate { get; set; } = x => throw new ArgumentOutOfRangeException($"The delegate {nameof(MessageBoxShowDelegate)} must be assigned by the view layer");
    }
}
