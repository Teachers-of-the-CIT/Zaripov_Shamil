//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shamil_Zaripov
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderProducts
    {
        public int OrderProductId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Products Products { get; set; }
    }
}
