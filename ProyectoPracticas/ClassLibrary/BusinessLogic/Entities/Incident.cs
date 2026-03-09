using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public Incident()
        {//Constructor sin parametros
            //Colecciones,ini sin parametros
        }

        public Incident(string department, string description,DateTime reportDate, Employee reporter)
        {
            //no se añade Id porque se lo dará EF, es int
            this.Department = department;
            this.Description = description;
            this.ReportDate = reportDate;
            //this.Priority = priority;
            this.Status = Status.Created;

            // Relaciones a 1
            //Area = area;
            //WorkOrder = workOrder;
            Reporter = reporter;

            //Colecciones

        }

        public override string ToString()
        {
            //mostrar la descripción y no el objeto entero
            return Description;
        }

    }
}
