using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModel;

namespace UnitTest.Presentation
{
    [TestClass]
    public class ProductViewModelTest
    {
        [TestMethod]
        public void ViewModelInitializeRelaysTest()
        {
            ProductViewModel vm = new ProductViewModel();
            Assert.IsNotNull(vm.RefreshProductsCommand);
            Assert.IsNotNull(vm.AddProductCommand);
            Assert.IsNotNull(vm.UpdateProductCommand);
            Assert.IsNotNull(vm.DeleteProductCommand);
            Assert.IsNotNull(vm.ShowEventsCommand);

            Assert.IsTrue(vm.RefreshProductsCommand.CanExecute(null));
            Assert.IsTrue(vm.AddProductCommand.CanExecute(null));
            Assert.IsTrue(vm.UpdateProductCommand.CanExecute(null));
            Assert.IsTrue(vm.DeleteProductCommand.CanExecute(null));
            Assert.IsTrue(vm.ShowEventsCommand.CanExecute(null));
            Assert.IsTrue(vm.ShowEventsCommand.CanExecute(null));
        }

        [TestMethod]
        public void AddProductCommandPopupWindowTest()
        {
            ProductViewModel vm = new ProductViewModel();
            Assert.IsTrue(vm.AddProductCommand.CanExecute(null));
        }

        [TestMethod]
        public void DeleteProductCommandPopupWindowTest()
        {
            ProductViewModel vm = new ProductViewModel();
            Assert.IsTrue(vm.DeleteProductCommand.CanExecute(null));
        }

        [TestMethod]
        public void UpdateProductCommandPopupWindowTest()
        {
            ProductViewModel vm = new ProductViewModel();
            vm.CurrentProduct = null;
            Assert.IsTrue(vm.UpdateProductCommand.CanExecute(null));
        }

        [TestMethod]
        public void RefreshProductsCommandPopupWindowTest()
        {
            ProductViewModel vm = new ProductViewModel();
            Assert.IsTrue(vm.RefreshProductsCommand.CanExecute(null));
            vm.RefreshProductsCommand.Execute(null);
        }
    }
}
