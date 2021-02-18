using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Cms.Models
{
    public enum Status
    {
        Active,
        Inactive
    }
    public class Target
    {
        public string ContactsName {get; set; }
        public string Number { get; set; }
        public Status IsActive { get; set; }
    }
}
