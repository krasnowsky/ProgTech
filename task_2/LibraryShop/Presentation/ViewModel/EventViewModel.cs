using Presentation.ViewModel.MVVM;
using Service.API;
using Service.data_files;
using System;
using System.Collections.Generic;
namespace Presentation.ViewModel
{
    public class EventViewModel : ViewModelBase
    {
        private IEventService service;
        public EventViewModel(EventService service)
        {
            this.service = service;
        }
        public EventViewModel()
        {
            service = new EventService();
            AddEventCommand = new RelayCommand(AddEvent);
            UpdateEventProductCommand = new RelayCommand(UpdateEventProduct);
            UpdateEventCustomerCommand = new RelayCommand(UpdateEventCustomer);
            DeleteEventCommand = new RelayCommand(DeleteEvent);
            RefreshEventsCommand = new RelayCommand(RefreshEvents);
        }

        private int eventId;
        public int EventID
        {
            get
            {
                return eventId;
            }
            set
            {
                eventId = value;
                OnPropertyChanged("EventID");
            }
        }
        private int productId;
        public int ProductID
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                OnPropertyChanged("ProductID");
            }
        }
        private int customerId;
        public int CustomerID
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }

        public RelayCommand AddEventCommand { get; private set; }
        public RelayCommand UpdateEventProductCommand { get; private set; }
        public RelayCommand UpdateEventCustomerCommand { get; private set; }
        public RelayCommand DeleteEventCommand { get; private set; }
        public RelayCommand RefreshEventsCommand { get; private set; }

        private void AddEvent()
        {
            bool added = service.AddEvent(EventID, DateTime.Now, ProductID, CustomerID);
            if (added)
            {
                text = "Purchase added";
            }
            else
            {
                text = "Cannot add Purchase";
            }
            MessageBoxShowDelegate(Text);
        }

        private IEventData currentEvent;
        public IEventData CurrentEvent
        {
            get => currentEvent;
            set
            {
                currentEvent = value;
                OnPropertyChanged("CurrentEvent");
            }
        }
        private void UpdateEventProduct()
        {
            bool updated = service.UpdateEventProduct(EventID, ProductID);
            if (updated)
            {
                text = "Purchase updated";
            }
            else
            {
                text = "Cannot update purchase";
            }
            MessageBoxShowDelegate(Text);
        }
        private void UpdateEventCustomer()
        {
            bool updated = service.UpdateEventCustomer(EventID, CustomerID);
            if (updated)
            {
                text = "Purchase customer updated";
            }
            else
            {
                text = "Cannot update purchase customer";
            }
            MessageBoxShowDelegate(Text);
        }

        private void DeleteEvent()
        {
            bool deleted = service.DeleteEvent(EventID);
            if (deleted)
            {
                text = "Purchase deleted";
            }
            else
            {
                text = "Cannot delete Purchase";
            }
            MessageBoxShowDelegate(Text);
        }

        private void RefreshEvents()
        {
            Events = service.GetEvents();
        }

        private IEnumerable<IEventData> events;
        public IEnumerable<IEventData> Events
        {
            get
            {
                return events;
            }
            set
            {
                events = value;
                OnPropertyChanged("Events");
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

        public Action<string> MessageBoxShowDelegate { get; set; } = x => throw new ArgumentOutOfRangeException($"The delegate {nameof(MessageBoxShowDelegate)} must be assigned by the view layer");
    }
}
