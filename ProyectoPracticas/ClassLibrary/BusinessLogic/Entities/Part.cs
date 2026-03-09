using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Part
    {
        public Part()
        {
            UsedParts = new List<UsedPart>();
        }

        public Part(string code, int currentQuantity, string description, int minimunQuantity, string unitOfMeasure, float unitPrice):this()
        {
            this.Code = code;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.CurrentQuantity = currentQuantity;
            this.MinimunQuantity = minimunQuantity;
            this.UnitOfMeasure = unitOfMeasure;

            UsedParts = new List<UsedPart>();
        }
    }
}
