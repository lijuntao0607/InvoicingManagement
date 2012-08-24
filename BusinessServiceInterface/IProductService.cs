using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;
using ViewModel;
using CommonEntity;

namespace BusinessServiceInterface
{
    public interface IProductService
    {
        void Add(ProductInfo product);
        void Add(ProductInfo product,IList<SpecificationView> list);
        void Update(ProductInfo product);
        void Update(ProductInfo product,IList<SpecificationView> list);
        void Delete(string id);

        ProductInfo Get(string id);

        Specification GetSpecification(string id);

        Specification GetByBarcode(string barcode);
        ProductInfo GetByProductNumber(string number);
        IList<ProductInfo> GetList();

        IList<ProductView> GetProductViewList(Category category, List<DataFilter> filters);

        void SaveOrUpdateSpecification(Specification spec);
        SpecificationView Translate(Specification spec);
        Specification Translate(SpecificationView view);
    }
}
