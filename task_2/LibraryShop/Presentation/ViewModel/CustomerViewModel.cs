using Presentation.ViewModel.MVVM;
using Service.API;
using Service.data_files;
using System;
using System.Collections.Generic;


namespace Presentation.ViewModel
{
    public class CustomerViewModel : ViewModelBase
    {
        private ICustomerService service;
        public CustomerViewModel(CustomerService service)
        {
            this.service = service;
        }
        public CustomerViewModel()
        {
            service = new CustomerService();
            AddCustomerCommand = new RelayCommand(AddCustomer);
            UpdateCustomerCommand = new RelayCommand(UpdateCustomer);
            DeleteCustomerCommand = new RelayCommand(DeleteCustomer);
            RefreshCustomersCommand = new RelayCommand(RefreshCustomers);
            ShowProductsCommand = new RelayCommand(ShowProductsWindow);
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

        public RelayCommand AddCustomerCommand { get; private set; }
        public RelayCommand UpdateCustomerCommand { get; private set; }
        public RelayCommand DeleteCustomerCommand { get; private set; }
        public RelayCommand RefreshCustomersCommand { get; private set; }
        public RelayCommand ShowProductsCommand { get; private set; }

        private void AddCustomer()
        {
            bool added = service.AddCustomer(ID, Name);
            if (added)
            {
                text = "Customer added";
            }
            else
            {
                text = "Cannot add Customer";
            }
            MessageBoxShowDelegate(Text);
        }

        private ICustomerData currentCustomer;
        public ICustomerData CurrentCustomer
        {
            get => currentCustomer;
            set
            {
                currentCustomer = value;
                OnPropertyChanged("CurrentCustomer");
            }
        }
        private void UpdateCustomer()
        {
            bool updated = service.UpdateCustomer(ID, Name);
            if (updated)
            {
                text = "Customer updated";
            }
            else
            {
                text = "Cannot update Customer";
            }
            MessageBoxShowDelegate(Text);
        }
        private void DeleteCustomer()
        {
            bool deleted = service.DeleteCustomer(ID);
            if (deleted)
            {
                text = "Customer deleted";
            }
            else
            {
                text = "Cannot delete Customer";
            }
            MessageBoxShowDelegate(Text);
        }

        private void RefreshCustomers()
        {
            Customers = service.GetCustomers();
        }

        private IEnumerable<ICustomerData> customers;
        public IEnumerable<ICustomerData> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
                OnPropertyChanged("Customers");
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
