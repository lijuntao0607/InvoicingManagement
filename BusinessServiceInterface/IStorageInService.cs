using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModule;
using ViewModel;
using CommonEntity;

namespace BusinessServiceInterface
{
    public interface IStorageInService
    {
         StorageIn Get(string id);
         void Add(StorageIn si);
         void Add(StorageIn si, IList<StorageInItem> list);
         void Update(StorageIn si);
         void Update(StorageIn si, IList<StorageInItem> list);
         void Delete(string id);
         //StorageInItemView GetItem(string id);
         void DeleteItem(string id);
         IList<StorageIn> GetList(List<DataFilter> filters);
         List<StorageInView> GetView();
         List<StorageInView> GetView(string userId);
         List<ProductView> GetItemView(string id);
         string GetStorageInNumber();
    }
}
