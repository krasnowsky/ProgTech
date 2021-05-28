using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    interface IProductService
    {
        IEnumerable<IProductData> GetProducts();
        IProductData GetProductByID(int ID);
        IProductData GetProductByName(string Name);
        bool AddProduct(int ID, string Name);
        bool UpdateProduct(int ID, string Name);
        bool DeleteProduct(int ID);
    }
}
