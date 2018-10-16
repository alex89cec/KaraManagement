using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaraApi.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsOverdue { get; set; }
    }
}
