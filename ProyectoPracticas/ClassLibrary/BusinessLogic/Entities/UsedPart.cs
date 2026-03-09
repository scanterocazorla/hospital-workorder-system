using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{ 
   public partial class UsedPart
   {
        public UsedPart() 
        { 
        
        }
        public UsedPart(int quantity, Part part)
        {
            this.Quantity = quantity;

            Part = part;


            if (part.CurrentQuantity - Quantity < part.MinimunQuantity) 
            {
                Needed = true;
            }
            else
            {
                Needed = false;
                part.CurrentQuantity = part.CurrentQuantity - Quantity;
            }
        }
    }
}
