using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Employee
    {
        // constructor sin parámetros
        public Employee()
        { //inicializa
            ReportedIncidents = new List<Incident>();
        }

        // constructor con parámetros (atributos tienen que estar en orden alfabético)
        public Employee(string fullName, string id, string password) 
        {
            this.FullName = fullName;
            this.Id = id;       // como es string no lo autogenera EF
            this.Password = password;
            this.ReportedIncidents = new List<Incident>();
        }
    }
}
