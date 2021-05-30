using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModel;

namespace UnitTest.Presentation
{
    [TestClass]
    public class EventViewModelTest
    {
        [TestMethod]
        public void ViewModelInitializeRelaysTest()
        {
            EventViewModel vm = new EventViewModel();
            Assert.IsNotNull(vm.RefreshEventsCommand);
            Assert.IsNotNull(vm.AddEventCommand);
            Assert.IsNotNull(vm.DeleteEventCommand);
            Assert.IsNotNull(vm.UpdateEventProductCommand);
            Assert.IsNotNull(vm.UpdateEventCustomerCommand);

            Assert.IsTrue(vm.RefreshEventsCommand.CanExecute(null));
            Assert.IsTrue(vm.AddEventCommand.CanExecute(null));
            Assert.IsTrue(vm.UpdateEventProductCommand.CanExecute(null));
            Assert.IsTrue(vm.UpdateEventCustomerCommand.CanExecute(null));
            Assert.IsTrue(vm.DeleteEventCommand.CanExecute(null));
        }

        [TestMethod]
        public void AddEventCommandPopupWindowTest()
        {
            EventViewModel vm = new EventViewModel();
            Assert.IsTrue(vm.AddEventCommand.CanExecute(null));
        }

        [TestMethod]
        public void DeleteEventCommandPopupWindowTest()
        {
            EventViewModel vm = new EventViewModel();
            Assert.IsTrue(vm.DeleteEventCommand.CanExecute(null));
        }

        [TestMethod]
        public void UpdateEventCommandPopupWindowTest()
        {
            EventViewModel vm = new EventViewModel();
            vm.CurrentEvent = null;
            Assert.IsTrue(vm.UpdateEventProductCommand.CanExecute(null));
        }

        [TestMethod]
        public void RefreshEventsCommandPopupWindowTest()
        {
            EventViewModel vm = new EventViewModel();
            Assert.IsTrue(vm.UpdateEventCustomerCommand.CanExecute(null));
            vm.RefreshEventsCommand.Execute(null);
        }
    }
}
