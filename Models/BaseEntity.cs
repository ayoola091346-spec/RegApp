using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegApp.Models
{
    public abstract class BaseEntity
    {
        public int Id{get; set;}
        public string CreatedBy{get; set;} = default!;
        public DateTime DateCreated{get; set;}
        public bool IsDeleted{get; set;}
    }
}