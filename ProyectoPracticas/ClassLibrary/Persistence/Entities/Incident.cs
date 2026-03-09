using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Incident
    {
        public int Id { get;set; }

        public DateTime ReportDate{get;set;}

        public string Department{get; set;}

        public string Description {get;set;}

        public Priority Priority {get; set;} //no hay que inicializarlo a low porque eso ya se haría

        public Status Status{get;set;} //lo pondre como 'created' en la implementacion

        public string RejectionReason{get;set;}//al principio no tiene ningun motivo de rechazo, lo pondría despues

        public virtual Area Area { get; set;}

        public virtual WorkOrder WorkOrder { get; set;}

        [Required]
        public virtual Employee Reporter { get; set; }

        //costOfUsedParts:Float=0 no se pone aun
    }
}
