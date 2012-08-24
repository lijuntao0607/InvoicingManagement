using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;
using DomainModule;

namespace BusinessServiceInterface
{
    public interface IWarehouseService
    {
        IList<ProductView> GetListByUser(string userId);
    }
}
