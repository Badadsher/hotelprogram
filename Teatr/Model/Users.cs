//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teatr.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int IdUsers { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public int idRole { get; set; }
        public string Name { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}
