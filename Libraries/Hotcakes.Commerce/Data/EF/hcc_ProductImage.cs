//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_ProductImage
    {
        public System.Guid bvin { get; set; }
        public System.Guid ProductID { get; set; }
        public string FileName { get; set; }
        public string Caption { get; set; }
        public string AlternateText { get; set; }
        public int SortOrder { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
    
        public virtual hcc_Product hcc_Product { get; set; }
    }
}