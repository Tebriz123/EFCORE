using LabAndHomeTask.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAndHomeTask.Models
{
    internal class Order:BaseEntity
    {
        public bool IsSuccessful { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public int AppProductId { get; set; }

        public AppProduct? AppProduct { get; set; }
    }
}
