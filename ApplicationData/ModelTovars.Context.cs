//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISRPO_Palashicheva_PR14.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KitchenEntities : DbContext
    {
        private static KitchenEntities _context;

        public KitchenEntities()
            : base("name=KitchenEntities")
        {
        }

        public static KitchenEntities GetContext()
        {
            if (_context==null)
                _context = new KitchenEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Strana> Strana { get; set; }
        public virtual DbSet<Tovars> Tovars { get; set; }
    }
}
