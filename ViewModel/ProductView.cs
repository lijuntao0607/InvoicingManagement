using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace ViewModel
{
    public class ProductView
    {
        public ProductView()
        {
        }
        public ProductView(string productId,string productName, string productNumber, string category,
            double taxRate, string barcode, string unit, double unitPrice, string specifiText)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductNumber = productNumber;
            this.Category = category;
            this.TaxRate = taxRate;
            this.Barcode = barcode;
            this.Unit = unit;
            this.UnitPrice = unitPrice;
            this.SpecifiText = specifiText;
        }
        /// <summary>
        ///                 string queryString = " select p.Id,p.ProductName,p.ProductNumber," +
        ///            " c.CategoryName,p.TaxRate,s.Barcode,u.DicName,s.UnitPrice,s.SpecifiText " +
        /// </summary>
        /// <param name="obj"></param>
        public ProductView(object[] obj)
        {
            this.ProductId =NoExceptionConvert.ToString( obj[0]);
            this.SpecId = NoExceptionConvert.ToString(obj[1]);
            this.ProductName = NoExceptionConvert.ToString(obj[2]);
            this.ProductNumber = NoExceptionConvert.ToString(obj[3]);
            this.Category = NoExceptionConvert.ToString(obj[4]);
            this.TaxRate = NoExceptionConvert.ToDouble(obj[5]);
            this.Barcode = NoExceptionConvert.ToString(obj[6]);
            this.Unit = NoExceptionConvert.ToString(obj[7]);
            this.UnitPrice = NoExceptionConvert.ToDouble(obj[8]);
            this.SpecifiText = NoExceptionConvert.ToString(obj[9]);
            if (obj.Length > 10)
            {
                this.Amount = NoExceptionConvert.ToDouble(obj[10]);
            }
        }
        public virtual string ProductId { get; set; }
        public virtual string SpecId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual string ProductNumber { get; set; }

        public virtual string Category { get; set; }
        public virtual double? TaxRate { get; set; }

        public virtual string Barcode { get; set; }
        public virtual string Unit { get; set; }
        public virtual double? UnitPrice { get; set; }
        public virtual string SpecifiText { get; set; }
        public virtual double Amount { get; set; }
    }
}
