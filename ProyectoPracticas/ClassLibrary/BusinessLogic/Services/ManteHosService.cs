using ManteHos.Entities;
using ManteHos.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ManteHos.Services
{
    public class ManteHosService : IManteHosService
    {
        private readonly IDAL dal;

        public ManteHosService(IDAL dal)
        {
            this.dal = dal;
        }

        /// <summary>
        /// Borra todos los datos de la BD
        /// </summary>
        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        /// <summary>
        /// Salva todos los cambios que haya habido en el contexto de la aplicación desde la última vez que se hizo Commit
        /// </summary>
        public void Commit()
        {
            dal.Commit();
        }

        /// <summary>
        /// Inicializa los datos para que haya ciertos datos para poder usarlos luego
        Employee logged;
        ICollection<WorkOrder> WorkOrders = new List<WorkOrder>();
        /// </summary>
        public void DBInitialization()
        {
            RemoveAllData();

            // Dar de alta ciertos datos relevantes para el sistema
            Head head = new Head("Ibañez", "h1", "h1");
            AddPerson(head);
            Master tfmotu = new Master("Bárcenas", "m1", "m1");
            AddPerson(tfmotu);
            Master master2 = new Master("He-Man", "m2", "m2");
            AddPerson(master2);
            Master master3 = new Master("Picasso", "m3", "m3");
            AddPerson(master3);
            Operator op1 = new Operator("Pepe Gotera", "o1", "o1", Shift.Morning);
            AddPerson(op1);
            Operator op2 = new Operator("Otilio", "o2", "o2", Shift.Morning);
            AddPerson(op2);
            Operator op3 = new Operator("Rompetechos", "o3", "o3", Shift.Night);
            AddPerson(op3);

            Employee empleado1 = new Employee("Sacarino", "e1", "e1");
            AddPerson(empleado1);
            Employee empleado2 = new Employee("Pepe García", "e2", "e2");
            AddPerson(empleado2);

            Area a1 = new Area("Mecánica", tfmotu);
            AddArea(a1);
            Area a2 = new Area("Electricidad", master2);
            AddArea(a2);
            Area a3 = new Area("Pintura", master3);
            AddArea(a3);

            Part p1 = new Part("Esc50", 5, "Placa de escayola para techo", 1, "Placa de 50x30cms", 5);
            AddPart(p1);
            Part p2 = new Part("TM8", 3000, "Tornillo métrica 8", 100, "Tornillo", 0.01F);
            AddPart(p2);
            Part p3 = new Part("ClimaEst", 4, "Cristal Climalit de ventana estándar", 0, "Cristal 75x100cms", 200);
            AddPart(p3);

            Commit();
        }

        public void AddPerson(Employee person)
        {
            // Restricción: No puede haber dos personas con el mismo Id
            if (dal.GetById<Employee>(person.Id) == null)
            {
                dal.Insert<Employee>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos áreas con el mismo Nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with Name " + area.Name + " already exists.");
        }

        public void AddPart(Part part)
        {
            // Restricción: No puede haber dos piezas con la misma descripción
            if (!dal.GetWhere<Part>(x => x.Description == part.Description).Any())
            {
                dal.Insert<Part>(part);
                dal.Commit();
            }
            else throw new ServiceException("Part with Description " + part.Description + " already exists.");
        }
        public void LogIn(String Id, String password)
        {
            if (dal.Exists<Employee>(Id))
            {
                Employee e = dal.GetById<Employee>(Id);
                if (e.Password == password)
                {
                    logged = e;
                }
                else
                {
                    throw new ServiceException("El password no coincide");
                }

            }
            else
            {
                throw new ServiceException("El id no existe");
            }
        }

        public void LogOut()
        {
            logged = null;
        }

        public Employee GetLogged()
        {
            return this.logged;
        }
        public void ReportIncident(String departamento, String desc, DateTime fecha)
        {
            Incident i = new Incident(departamento, desc, fecha, logged);
            dal.Insert(i);
            dal.Commit();
        }

        public Boolean IncidentAlreadyExists(string dep, string descp)
        {
            return dal.GetWhere<Incident>(inc => inc.Department == dep && inc.Description == descp).Any();
        }

        

        public ICollection<WorkOrder> GetOperatorOpenWorkOrders()//no guardar listas en la interfaz de usuarios
        {
            if (logged == null || !(logged is Operator o))
                throw new ServiceException("Logged user is not a operator.");
            return o.GetOpenWorkOrders();
            //where es un metodo de collection para quedarte con algunos where (parametros->(goes to) expresion booleana)
            //wo le he puesto yo el nombre al workOrder
            // un WorkOrder esta cerrado si no tiene fecha de cierre
            //debe retornar un ICollection
        }

        public WorkOrder GetWorkOrder(int woID)
        {
            if (dal.GetById<WorkOrder>(woID) != null) //preguntar si es == o !=
                return dal.GetById<WorkOrder>(woID);
            else return null;
        }

        public void CloseWorkOrder(int woID, DateTime endDate, string repairReport)
        {
            if (logged == null || !(logged is Operator op))
                throw new ServiceException("Logged user is not an operator.");

            var wo = dal.GetById<WorkOrder>(woID);
            if (wo == null)
                throw new ServiceException("Work order does not exist.");

            if (!op.WorkOrders.Contains(wo))
                throw new ServiceException("This work order is not assigned to the operator.");

            wo.close(endDate, repairReport);

            dal.Commit();   
        }


        // CASO MASTER------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //2. El sistema busca y muestra las incidencias asignadas al área del maestro no cerradas y las muestra.
        public ICollection<Incident> GetMasterIncidents()
        {
            if (logged == null || !(logged is Master m))
                throw new ServiceException("Logged user is not a master.");
            
            return m.Area.GetOpenIncidents();
        }
        //4. El sistema muestra la información de la orden incluida la de las piezas que han sido incluidas en la orden, y el coste total de las piezas utilizadas, si las hubiera
        //lo quE yo tengo que hacer, es devolver esa incidencia, y la interfaz es la que se encanraga de mostrar la informacion de esa incidencia(workorder, y operators)
        public Incident GetIncident(int incidentId)
        { //hay que poner un if para ver si es null o no, ya que mantehosservice get incident no siempre devuelve un valor( En 4, si no hay orden de trabajo asociada
          //  a la incidencia el sistema pregunta si debe crear una y en caso de que el maestro diga que sí se crea. En caso contrario, continúa en el punto 3)
            Incident incId = dal.GetById<Incident>(incidentId);
            if (incId == null)
            {
                throw new ServiceException("Incident not found.");
            }
            return incId; 
        }

        public void CreateWorkOrder(int incidentId)
        {
            // Verificar que un Master está logueado
            if (logged == null || !(logged is Master))
                throw new ServiceException("Solo un master puede crear órdenes de trabajo.");

            // Obtener la incidencia
            Incident inc = dal.GetById<Incident>(incidentId);
            if (inc == null)
                throw new ServiceException("La incidencia no existe.");

            // Revisar si ya tiene orden asociada
            if (inc.WorkOrder != null)
                throw new ServiceException("La incidencia ya tiene una orden de trabajo.");

            // Crear la WorkOrder
            WorkOrder wo = new WorkOrder(DateTime.Now, inc);

            // Guardar en la BD
            dal.Insert(wo);
            dal.Commit();
        }

        //añadir metodob para obtener los operadores que son asignables (en workorder???)
        //retonar los operators que nob estan en la coleccion operators del workorder
        //hacer esto con linQ en una sola linea de codigo
        //muestra info sobre operadores assignables
        public ICollection<Operator> GetAllOperators()
        {
            return dal.GetWhere<Operator>(op => true).ToList();
        }


        public void AddOperatortoWorkOrder(int workOrderId, string operatorId) {
            //tendria que volverlo a comprobar???
            if (logged == null || !(logged is Master m))
                throw new ServiceException("Solo asigna operadores un master");

            // Ahora, buscamos la workorder en la interfaz
            WorkOrder wo = dal.GetById<WorkOrder>(workOrderId);
            //si no hay, excepción
            if (wo == null)
                throw new ServiceException("WorkOrder no encontrada.");

            // Buscamos operador en la interfaz
            Operator op = dal.GetById<Operator>(operatorId);
            //si no hay operador, excepción (preguntar si laazar excepción o no)
            if (op == null)
                throw new ServiceException("Operator no encontrado.");

            // Si está todo bien, se añade (confirmo y guardo en la BD la transacción)
            wo.AddOperator(op);
            dal.Commit();
        }


        public void RemoveOperatortoWorkOrder(int workOrderId, string operatorId)
        {
            // Validar usuario logueado
            if (logged == null || !(logged is Master))
                throw new ServiceException("Solo asigna operadores un master");

            // Recuperar la WorkOrder y Operador
            WorkOrder wo = dal.GetById<WorkOrder>(workOrderId);
            if (wo == null)
                throw new ServiceException("WorkOrder no encontrado.");

            Operator op = dal.GetById<Operator>(operatorId);
            if (op == null)
                throw new ServiceException("Operator no encontrado.");

            // Quitar operario(la función la tenía que añadir en WorkOrder)
            wo.RemoveOperator(op);
            // con los commit ya hago el paso 8 de almacenado???
            dal.Commit();
        }

        //CASO HEAD---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void VerifyIsHeadLogged()
        {
            if(logged == null)
            {
                throw new ServiceException("No hay usuario logueado");
            }
            if (!(logged is Head head))
            {
                throw new ServiceException("El usuario logueado no es un Jefe de Servicio");
            }
        }
        public ICollection<Incident> GetIncidentCreated()
        {
            //Verificar si es head
            VerifyIsHeadLogged();
            //Devolver todas las incidencias donde su estado sea Created y añadirlas todas en una lista
            return dal.GetWhere<Incident>(i=>i.Status == Status.Created).ToList();
        }

        public void AcceptIncident(Incident incident, Priority priority, Area area)
        {
            VerifyIsHeadLogged();
            //miras q incidencia no sea nula
            if (incident == null) throw new ServiceException("La incidencia no existe");
            //Si la incidencia no esta en estado Created lanzar exception
            if (incident.Status != Status.Created) throw new ServiceException("La incidencia no existe");
            //mirar que Area no sea nula y que exista esa area 
            if (area == null || dal.GetById<Area>(area.Id)==null) throw new ServiceException("El area indicada no existe");
             
            //actualiza el estado a 'Accepted'
            incident.Status = Status.Accepted;

            //asigna prioridad y el area a la incidencia
            incident.Priority = priority;
            incident.Area = area;
            
            dal.Commit();
        }

        public void RejectIncident(Incident incident, string rejectionReason)
        {
            VerifyIsHeadLogged();
            if (incident == null) throw new ServiceException("La incidencia no existe");

            if (incident.Status != Status.Created) throw new ServiceException("La incidencia no existe");

            //no puede ser solo null pq hay q mirar tambien q no ponga solo un espacio 
            if (string.IsNullOrWhiteSpace(rejectionReason)) throw new ServiceException("Debes indicar una razón de rechazo");

            //actualizar el estado a 'Rechazar'
            incident.Status = Status.Rejected;
            //almacenas razón del rechazo
            incident.RejectionReason = rejectionReason;

            dal.Commit();
        }

        public ICollection<Area> GetAreas()
        {
            VerifyIsHeadLogged();
            //Recoger todas las areas y guardarlas en una lista
            return dal.GetAll<Area>().ToList();
        }

        public Boolean isHead(Employee e)
        {
            if (logged == null)
            {
                return false;
            }
            if (logged is Head head)
            {
                return true;
            }
            return false;
        }


        public Boolean isMaster(Employee e)
        {
            if (logged == null)
            {
                return false;
            }
            if (logged is Master master)
            {
                return true;
            }
            return false;
        }

        public Boolean isOperator(Employee e)
        {
            if (logged == null) { return false; }
            if (logged is Operator op)
            {
                return true;
            }
            return false;
        }

    }
}

       

        

    