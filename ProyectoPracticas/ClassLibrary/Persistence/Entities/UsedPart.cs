using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class UsedPart
    {
        public int Id { get; set; }
        public int Quantity {  get; set; }
        public Boolean Needed {  get; set; }

        [Required]
        public virtual Part Part {  get; set; }

        
    }
}
