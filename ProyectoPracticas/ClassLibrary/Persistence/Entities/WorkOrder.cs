using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {

        public DateTime? EndDate
        {
            get; set;
        }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public String RepairReport { get; set; }

        public virtual ICollection<Operator> Operators { get; set; }

        public virtual ICollection<UsedPart> UsedParts { get; set; }

        [Required]
        public virtual Incident Incident { get; set; }



    }
}
