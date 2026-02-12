using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegApp.Models
{
    public class Guardian : BaseEntity
    {
        public string Name{get; set;} = default!;
        public string Email{get; set;} = default!;
        public string Phone{get; set;} = default!;
        public string Address{get; set;} = default!;
    }
}