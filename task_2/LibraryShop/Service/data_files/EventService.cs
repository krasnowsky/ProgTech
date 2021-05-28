using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;
using LibraryShop.data_files;
using Service.API;

namespace Service.data_files
{
    class EventService : IEventService
    {
        private IDataManager manager;

        public EventService(IDataManager manager)
        {
            this.manager = manager;
        }

        public EventService()
        {
            this.manager = new DataManager();
        }
        public IEventData Transfer(IEvent _event)
        {
            if (_event == null)
            {
                return null;
            }

            return new EventData
            {
                EventID = _event.Event_id,
                Date = _event.Timestamp,
                ProductID = _event.Product_id,
                CustomerID = _event.Customer_id,
            };
        }

        public IEnumerable<IEventData> GetEvents()
        {
            var events = manager.GetEvents();
            var result = new List<IEventData>();

            foreach (var _event in events)
            {
                result.Add(Transfer(_event));
            }

            return result;
        }

        public IEventData GetEventByID(int ID)
        {
            return Transfer(manager.GetEventByID(ID));
        }

        public IEnumerable<IEventData> GetEventsByCustomerID(int ID)
        {
            var events = manager.GetEventsByCustomerID(ID);
            var result = new List<IEventData>();

            foreach (var _event in events)
            {
                result.Add(Transfer(_event));
            }

            return result;
        }

        public bool AddEvent(int EventID, DateTime Date, int ProductID, int CustomerID)
        {
            return manager.AddEvent(EventID, Date, ProductID, CustomerID);
        }

        public bool UpdateEventProduct(int ID, int ProductID)
        {
            return manager.UpdateEventProduct(ID, ProductID);
        }

        public bool UpdateEventCustomer(int ID, int CustomerID)
        {
            return manager.UpdateEventCustomer(ID, CustomerID);
        }

        public bool DeleteEvent(int ID)
        {
            return manager.DeleteEvent(ID);
        }
    }
}
