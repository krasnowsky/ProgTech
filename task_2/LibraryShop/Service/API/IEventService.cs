using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface IEventService
    {
        IEnumerable<IEventData> GetEvents();
        IEventData GetEventByID(int ID);
        IEnumerable<IEventData> GetEventsByCustomerID(int ID);
        bool AddEvent(int EventID, DateTime Date, int ProductID, int CustomerID);
        bool UpdateEventProduct(int ID, int ProductID);
        bool UpdateEventCustomer(int ID, int CustomerID);
        bool DeleteEvent(int ID);
    }
}
