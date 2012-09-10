using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;
using DomainModule;
using System.Data;

namespace BusinessServiceInterface
{
    public interface IWarehouseService
    {
        IList<ProductView> GetListByUser(string userId);
        DataTable GetInvoicingReportDataTable(DateTime start, DateTime end);
    }
}
