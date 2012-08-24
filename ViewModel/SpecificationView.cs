using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;
using DomainModule;

namespace ViewModel
{
    public class SpecificationView:BaseEntity
    {
        public SpecificationView()
        {
        }
        public SpecificationView(Specification spec)
        {
            this.Id = spec.Id;
            this.Barcode = spec.Barcode;
            if (spec.Unit != null)
            {
                this.UnitId = spec.Unit.Id;
            }
            this.UnitPrice = spec.UnitPrice;
            this.SpecifiText = spec.SpecifiText;
        }
        //public virtual string ProductId { get; set; }
        //public virtual string ProductName { get; set; }
        public virtual string Barcode { get; set; }
        public virtual string UnitId { get; set; }
        public virtual double? UnitPrice { get; set; }
        public virtual string SpecifiText { get; set; }

        //public static Specification Translate(SpecificationView view)
        //{
        //    Specification spec = new Specification();
        //    spec.SpecifiText = view.SpecifiText;
        //    spec.Unit =SystemVa
        //    return spec;
        //}

    }
}
