using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonEntity;
using Utility;

namespace ViewModel
{
    public class StorageOutView : BaseEntity
    {
        public StorageOutView()
        {
        }
        public StorageOutView(string id, string listNumber, DateTime storageInTime, double totalPrice, double totalAmount)
        {
            this.Id = id;
            this.ListNumber = ListNumber;
            this.StorageInTime = storageInTime;
            this.TotalAmount = totalAmount;
            this.TotalPrice = TotalPrice;
        }
        public StorageOutView(object[] obj)
        {
            this.Id = NoExceptionConvert.ToString(obj[0]);
            this.ListNumber = NoExceptionConvert.ToString(obj[1]);
            this.StorageInTime = Convert.ToDateTime(obj[2]);
            this.TotalAmount = NoExceptionConvert.ToDouble(obj[3]);
            this.TotalPrice = NoExceptionConvert.ToDouble(obj[4]);
        }
        public virtual string ListNumber { get; set; }
        public virtual DateTime StorageInTime { get; set; }
        public virtual double TotalAmount { get; set; }
        public virtual double TotalPrice { get; set; }

    }
}
