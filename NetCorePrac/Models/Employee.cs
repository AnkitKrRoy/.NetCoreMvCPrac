using System;
using System.Collections.Generic;

namespace NetCorePrac.Models
{
    public partial class Employee
    {
        public int Eno { get; set; }
        public string? Ename { get; set; }
        public string? Gender { get; set; }
        public string? Job { get; set; }
        public int? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public int? Comm { get; set; }
        public int? Dno { get; set; }
    }
}
