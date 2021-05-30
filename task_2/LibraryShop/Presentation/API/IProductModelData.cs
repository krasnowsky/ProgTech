using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.API
{
    public interface IProductModelData
    {
        IProductService Service { get; }
        IEnumerable<IProductData> Product { get; }

        IProductModelView CreateProduct(string Name, int ID);
    }
}
