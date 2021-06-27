using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HutechStore.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        //Id:               Gets or sets the primary key for this role.
        //Name:             Gets or sets the name for this role.
        //NormalizedName:   Gets or sets the normalized name for this role.
        //ConcurrencyStamp: A random value that should change whenever a role is persisted to the store

        public string Description { get; set; }
    }
}
