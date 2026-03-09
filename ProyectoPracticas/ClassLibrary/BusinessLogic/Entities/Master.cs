using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManteHos.Entities
{
    public partial class Master
    {

        public Master()
        {
            
        }
        public Master(String fullname, String id, String password):base(fullname, id, password){
           
        }
       
    }
}
