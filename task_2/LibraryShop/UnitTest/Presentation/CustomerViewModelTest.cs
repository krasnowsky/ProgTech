using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModel;

namespace UnitTest.Presentation
{
    [TestClass]
    public class CustomerViewModelTest
    {
        [TestMethod]
        public void ViewModelInitializeRelaysTest()
        {
            CustomerViewModel vm = new CustomerViewModel();
            Assert.IsNotNull(vm.RefreshCustomersCommand);
            Assert.IsNotNull(vm.AddCustomerCommand);
            Assert.IsNotNull(vm.DeleteCustomerCommand);
            Assert.IsNotNull(vm.UpdateCustomerCommand);
            Assert.IsNotNull(vm.ShowProductsCommand);

            Assert.IsTrue(vm.RefreshCustomersCommand.CanExecute(null));
            Assert.IsTrue(vm.AddCustomerCommand.CanExecute(null));
            Assert.IsTrue(vm.DeleteCustomerCommand.CanExecute(null));
            Assert.IsTrue(vm.UpdateCustomerCommand.CanExecute(null));
            Assert.IsTrue(vm.ShowProductsCommand.CanExecute(null));
        }

        [TestMethod]
        public void AddCustomerCommandPopupWindowTest()
        {
            CustomerViewModel vm = new CustomerViewModel();
            Assert.IsTrue(vm.AddCustomerCommand.CanExecute(null));
        }

        [TestMethod]
        public void DeleteCustomerCommandPopupWindowTest()
        {
            CustomerViewModel vm = new CustomerViewModel();
            Assert.IsTrue(vm.DeleteCustomerCommand.CanExecute(null));
        }

        [TestMethod]
        public void UpdateCustomerCommandPopupWindowTest()
        {
            CustomerViewModel vm = new CustomerViewModel();
            vm.CurrentCustomer = null;
            Assert.IsTrue(vm.UpdateCustomerCommand.CanExecute(null));
        }

        [TestMethod]
        public void RefreshCustomersCommandPopupWindowTest()
        {
            CustomerViewModel vm = new CustomerViewModel();
            Assert.IsTrue(vm.ShowProductsCommand.CanExecute(null));
            vm.RefreshCustomersCommand.Execute(null);
        }
    }
}
