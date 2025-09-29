using LabAndHomeTask.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Models
{
    internal class User:BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public List<Order> Orders { get; set; }
        public decimal Balance { get; set; } = 1000;

    }
}
