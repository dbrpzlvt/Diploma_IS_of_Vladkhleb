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
    
    public partial class Образец
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Образец()
        {
            this.Документ_Передача_брака_в_переработку = new HashSet<Документ_Передача_брака_в_переработку>();
            this.Разрешение_на_отправку = new HashSet<Разрешение_на_отправку>();
        }
    
        public int Код_образца { get; set; }
        public Nullable<int> Код_продукции { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Документ_Передача_брака_в_переработку> Документ_Передача_брака_в_переработку { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Разрешение_на_отправку> Разрешение_на_отправку { get; set; }
        public virtual Продукция Продукция { get; set; }
    }
}
