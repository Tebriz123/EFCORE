using LabAndHomeTask.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Models
{
    internal class Company:BaseEntity
    {
        public string Name { get; set; }

        public List<AppProduct> AppProducts { get; set; } = new List<AppProduct>();
        public int? OwnerId { get; set; }
        public User? Owner { get; set; }

    }
}
