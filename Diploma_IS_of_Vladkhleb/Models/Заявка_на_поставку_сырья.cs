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
    
    public partial class Заявка_на_поставку_сырья
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заявка_на_поставку_сырья()
        {
            this.Строка_заявки_на_поставку_сырья = new HashSet<Строка_заявки_на_поставку_сырья>();
        }
    
        public int Код_заявки { get; set; }
        public string Наименование_заявки { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Строка_заявки_на_поставку_сырья> Строка_заявки_на_поставку_сырья { get; set; }
    }
}
