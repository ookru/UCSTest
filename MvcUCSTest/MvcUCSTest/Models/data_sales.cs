//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcUCSTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class data_sales
    {
        public int id { get; set; }
        public int id_good { get; set; }
        public System.DateTime date_sale { get; set; }
        public int quantity { get; set; }
        public int summ { get; set; }
    
        public virtual ref_goods ref_goods { get; set; }
    }
}
