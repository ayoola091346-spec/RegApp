using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegApp.Models
{
    public class Student : BaseEntity
    {
        public string AdminNumber{get; set;} = default!;
        public string Name{get; set;} = default!;
        public string Basic{get; set;} = default!;

    }
}