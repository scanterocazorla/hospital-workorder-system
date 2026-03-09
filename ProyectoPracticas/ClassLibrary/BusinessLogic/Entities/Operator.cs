using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Operator
    {
        public Operator()
        {
            WorkOrders = new List<WorkOrder>();
        }

        public Operator(String fullname, String id, String password, Shift shift):base(fullname, id, password)
        {
            this.Shift = shift;
            WorkOrders = new List<WorkOrder>();
        }

        public ICollection<WorkOrder> GetOpenWorkOrders()
        {
            return this.WorkOrders.Where(wo => wo.EndDate == null).ToList();
        }
    }
}
