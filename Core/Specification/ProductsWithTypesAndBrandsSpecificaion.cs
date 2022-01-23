using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specification
{
   public class ProductsWithTypesAndBrandsSpecificaion : BaseSpecification<Product>
    {
      public ProductsWithTypesAndBrandsSpecificaion()
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
        public ProductsWithTypesAndBrandsSpecificaion(int id) : base (x=>x.Id==id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}
