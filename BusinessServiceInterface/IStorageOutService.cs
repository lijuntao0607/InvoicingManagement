using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModule;
using CommonEntity;
using ViewModel;

namespace BusinessServiceInterface
{
    public interface IStorageOutService
    {
        StorageOut Get(string id);
        void Add(StorageOut so);
        void Add(StorageOut so, IList<StorageOutItem> list);
        void Update(StorageOut so);
        void Update(StorageOut so, IList<StorageOutItem> list);
        void Delete(string id);
        //StorageInItemView GetItem(string id);
        void DeleteItem(string id);
        IList<StorageOut> GetList(List<DataFilter> filters);
        List<StorageOutView> GetView();
        List<StorageOutView> GetView(string userId);
        List<ProductView> GetItemView(string id);
        string GetStorageOutNumber();
    }
}
