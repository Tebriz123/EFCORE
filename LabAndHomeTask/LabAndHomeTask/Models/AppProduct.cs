using LabAndHomeTask.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Models
{
    internal class AppProduct:BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public int CompanyId { get; set; }
        public  Company? Company { get; set; }
        public decimal Price { get; set; }
        public List<Order> Orders { get; set; }




    }
}
