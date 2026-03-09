using ManteHos.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Area
    {
        public Area() {//Constructor sin parametros
            //Colecciones,ini sin parametros
            Incidents = new List<Incident>();
        }

        public Area(string name,Master master){//Constructor con parametros
       
            //no se añade Id porque se lo dará EF, es int

            this.Name = name;

            //Relaciones a 1
            Master = master;

            //Cardinalidad min Incident es 0, no necesario asignar ningun elemento ini a las colecciones-no pasarle al constructor ningun parametro
            Incidents = new List<Incident>();
        }
        public ICollection<Incident> GetOpenIncidents()
        {
            //preguntar si tb tendria que mirar de las pending o de las inprogress, pq como el head las acepata ps ns
            return this.Incidents.Where(inc => inc.Status == Status.Accepted).ToList();
        }
        public override string ToString()
        {
            //mostrar el nombre del Area y no el objeto entero
            return Name;
        }
    }
}
