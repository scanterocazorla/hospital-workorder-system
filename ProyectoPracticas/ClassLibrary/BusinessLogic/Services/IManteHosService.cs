using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManteHos.Entities;


namespace ManteHos.Services
{
    public interface IManteHosService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();

        //
        // A partir de aquí los necesarios para los CU solicitados
        //ç
        void LogIn(String Id, String password);
        void LogOut();

        Employee GetLogged();
        void ReportIncident(String departamento, String desc, DateTime fecha);

        ICollection<WorkOrder> GetOperatorOpenWorkOrders();
        WorkOrder GetWorkOrder(int woID);
        void CloseWorkOrder(int woID, DateTime endDate, string repairReport);

        ICollection<Incident> GetMasterIncidents();
        Incident GetIncident(int incidentId);
        ICollection<Operator> GetAllOperators();


        void CreateWorkOrder(int incidentId);

        //necesito saber que order de trabajo añadir(o quitar) y a qué operario
        void AddOperatortoWorkOrder(int workOrderId, string operatorId);
        void RemoveOperatortoWorkOrder(int workOrderId, string operatorId);

        
        ICollection<Incident> GetIncidentCreated();
        void AcceptIncident(Incident incident, Priority priority, Area area);
        void RejectIncident(Incident incident, string rejectionReason);
        ICollection<Area> GetAreas();

        Boolean isHead(Employee e);
        Boolean isMaster(Employee e);
        Boolean isOperator(Employee e);

        Boolean IncidentAlreadyExists(string dep, string descp);
    }
}