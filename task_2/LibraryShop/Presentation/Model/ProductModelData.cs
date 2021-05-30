using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.API;
using Service.API;

namespace Presentation.Model
{
    public class ProductModelData : IProductModelData
    {
        public IProductService Service { get; }

        public ProductModelData(IProductService service)
        {
            Service = service;
        }

        public IEnumerable<IProductData> Product
        {
            get
            {
                IEnumerable<IProductData> products = Service.GetProducts();
                return products;
            }
        }

        public IProductModelView CreateProduct(string Name, int ID)
        {
            return new ProductModelView(Name, ID);
        }
    }
}
