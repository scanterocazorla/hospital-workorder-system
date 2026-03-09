using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities { 
    public partial class Part
    {
        [Required]
        [Key]
        public string Code { get; set;}
        public string Description {  get; set;}
        public float UnitPrice {  get; set;}
        public int CurrentQuantity {  get; set;}
        public int MinimunQuantity { get; set;}
        public string UnitOfMeasure {  get; set;}
        public virtual ICollection<UsedPart> UsedParts { get; set;}
    }
}
