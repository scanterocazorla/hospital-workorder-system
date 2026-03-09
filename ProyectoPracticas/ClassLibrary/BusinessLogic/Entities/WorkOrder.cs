using ManteHos.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            Operators = new List<Operator>();

            UsedParts = new List<UsedPart>();

        }

        public WorkOrder(DateTime startDate, Incident incident)
        {
            this.EndDate = null;
            this.StartDate = startDate;

            //Relaciones a 1
            Incident = incident;
            incident.WorkOrder = this;

            //Colecciones
            Operators = new List<Operator>();

            UsedParts = new List<UsedPart>();

        }

        // uso ese allOperators pq Operatos me da los operadores ya asignados,
        //necesito que me den todos y a partir de ahí ir descartando según los q haya ya asignados(sí los hay
        public ICollection<Operator> GetAssignableOperators(ICollection<Operator> allOperators)
        {
            return allOperators.Where(op => !Operators.Contains(op) && (!Operators.Any() || op.Shift == Operators.First().Shift)).ToList();
        }



        public void AddOperator(Operator op1)
        {   //lista operators vacia lo añado
            if (Operators.Contains(op1))
                throw new ServiceException("El operador ya está asignado a la WorkOrder.");

            // si no, no puede haber ningun op en opeartors cuyo shift sea diferente al de op1
            //hacer esto con linQ, pista: usar el operador Any
            if (Operators.Any() && Operators.Any(op => op.Shift != op1.Shift))
                throw new ServiceException("Los operadores no están en el mismo turno.");
            
            Operators.Add(op1);
            op1.WorkOrders.Add(this);
        }

        public UsedPart AddUsedPart(int aQuantity, Part aPart)
        {
            UsedPart uP = new UsedPart(aQuantity, aPart);
            UsedParts.Add(uP);
            return uP;
        }

        public void RemoveOperator(Operator op)
        {
            if (Operators.Contains(op))
                Operators.Remove(op);
            else { throw new ServiceException("El operator no está asignado a la WorkOrder");
            
            }
            op.WorkOrders.Remove(this);  
        }


        public void close(DateTime endDate, string repairReport)
        {
            WorkOrder wo = this;
            if (EndDate != null) { throw new ServiceException("La orden de trabajo ya está cerrada."); }
            //hace loop para mirar si usedPart needed true entonces no se puede cerrar, sino mandar error
            if (wo.UsedParts.Any(up => up.Needed)) { throw new ServiceException("La orden necesita piezas para terminar"); }
            else
            {
                wo.EndDate = endDate;
                wo.RepairReport = repairReport;
                wo.Incident.Status = Status.Completed;//cuando se cierra poner Completed en Incident en su clase-> todo esto en memoria
                //En entityframework->dal.commit, dBcontext->saveChanges para q se guarde en la base de datos (manera oculta)
                //wo = null;
            }

            

        }

    }
}
