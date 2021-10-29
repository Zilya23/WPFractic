//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Serias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Serias()
        {
            this.Serias_Genre = new HashSet<Serias_Genre>();
            this.Actor = new HashSet<Actor>();
            this.Director = new HashSet<Director>();
            this.Operator = new HashSet<Operator>();
            this.Screenwriter = new HashSet<Screenwriter>();
        }
    
        public int ID_Serias { get; set; }
        public string Title { get; set; }
        public string Poster { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<decimal> Budget { get; set; }
        public Nullable<decimal> Fees { get; set; }
        public string Country { get; set; }
        public Nullable<int> Count_episodes { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> ID_Rating { get; set; }
    
        public virtual Rating Rating { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Serias_Genre> Serias_Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actor> Actor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Director> Director { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operator> Operator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Screenwriter> Screenwriter { get; set; }
    }
}
