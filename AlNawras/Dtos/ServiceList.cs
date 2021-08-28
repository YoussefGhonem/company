using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlNawras.Dtos
{
    public class ServiceList
    {
        public int Id { get; set; }
        public string Ref { get; set; }
        public string Contractors { get; set; }
        public string ProjectName { get; set; }
        public string Consultant { get; set; }
        public string ContValue { get; set; }
    }
}
