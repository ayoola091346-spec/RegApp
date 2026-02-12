using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegApp.Models
{
    public class User: BaseEntity
    {
        public string Email{get; set;} = default!;
        public string Password{get; set;} = default!;
        public string Role{get; set;} = default!;
    }
}