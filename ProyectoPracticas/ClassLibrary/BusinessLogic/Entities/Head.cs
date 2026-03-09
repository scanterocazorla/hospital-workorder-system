using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Head
    {
        
        // constructortor sin parámetros: llama a base y no tiene colecciones propias, hereda inicialización de ReportedIncidents
        public Head()  { }

        // ctor con parámetros:
        // primero los del padre en orden alfabético, luego la asociación obligatoria Master
        public Head(string fullName, string id, string password)
            : base(fullName, id, password) //hereda del padre inicialización de colecciones
        {  
          
        }
    }
}
