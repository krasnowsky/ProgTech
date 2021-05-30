using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.API;

namespace Presentation.Model
{
    public class ProductModelView : IProductModelView
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public bool isAvailable { get; set; }

        public ProductModelView(string name, int productID)
        {
            Name = name;
            ProductID = productID;
            isAvailable = true;
        }
    }
}
