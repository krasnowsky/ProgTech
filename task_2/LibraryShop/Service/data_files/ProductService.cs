using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;
using LibraryShop.API;
using LibraryShop.data_files;

namespace Service.data_files
{
    class ProductService : IProductService
    {
        private IDataManager manager;

        public ProductService(IDataManager manager)
        {
            this.manager = manager;
        }

        public ProductService()
        {
            this.manager = new DataManager();
        }

        #region Product
        public IProductData Transfer(IProduct product)
        {
            if (product == null)
            {
                return null;
            }

            return new ProductData
            {
                Name = product.Name,
                ProductID = product.ProductID,
                isAvaliable = product.isAvaliable,
            };
        }

        public IEnumerable<IProductData> GetProducts()
        {
            var products = manager.GetProducts();
            var result = new List<IProductData>();

            foreach (var product in products)
            {
                result.Add(Transfer(product));
            }

            return result;
        }

        public IProductData GetProductByID(int ID)
        {
            return Transfer(manager.GetProductByID(ID));
        }

        public IProductData GetProductByName(string Name)
        {
            return Transfer(manager.GetProductByName(Name));
        }

        public bool AddProduct(int ID, string Name)
        {
            return manager.AddProduct(ID, Name);
        }

        public bool UpdateProduct(int ID, string Name)
        {
            return manager.UpdateProduct(ID, Name);
        }

        public bool DeleteProduct(int ID)
        {
            return manager.DeleteProduct(ID);
        }
        #endregion
    }
}
