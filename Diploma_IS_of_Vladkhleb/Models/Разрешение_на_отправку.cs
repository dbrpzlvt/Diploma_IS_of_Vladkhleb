//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diploma_IS_of_Vladkhleb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Разрешение_на_отправку
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Разрешение_на_отправку()
        {
            this.ТОРГ_8_Заказ_отборочный_лист = new HashSet<ТОРГ_8_Заказ_отборочный_лист>();
        }
    
        public int Код_разрешения_на_отправку { get; set; }
        public Nullable<int> Код_образца { get; set; }
        public Nullable<System.DateTime> Дата_и_время_РазрОтпр { get; set; }
    
        public virtual Образец Образец { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ТОРГ_8_Заказ_отборочный_лист> ТОРГ_8_Заказ_отборочный_лист { get; set; }
    }
}
