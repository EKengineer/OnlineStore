using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Memory.models
{
    public class User : IdentityUser 
    {
        public string Address { get; set; }

    }
}
