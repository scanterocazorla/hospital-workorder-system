using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManteHos.Entities;
using ManteHos.Persistence;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new ManteHosDbContext());

            CreateSampleDB(dal);
            PrintSampleDB(dal);
        }


        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();

            Console.WriteLine("CREANDO LOS DATOS Y ALMACENANDOLOS EN LA BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE PERSONAS");
            //public Course(string descr, string name)

            Head head = new Head("Ibañez", "h1", "h1");
            dal.Insert<Head>(head);
            dal.Commit();

            Master tfmotu = new Master("Bárcenas", "m1", "m1");
            dal.Insert<Master>(tfmotu);
            dal.Commit();

            Master master2 = new Master("He-Man", "m2", "m2");
            dal.Insert<Master>(master2);
            dal.Commit();

            Operator op1 = new Operator("Pepe Gotera", "o1", "o1", Shift.Morning);
            dal.Insert<Operator>(op1);
            dal.Commit();

            Employee empleado1 = new Employee("Sacarino", "e2", "e2");
            dal.Insert<Employee>(empleado1);
            dal.Commit();

            //
            // Populate here the rest of the database
            //
            Area a1 = new Area("Tecnología", tfmotu);
            dal.Insert<Area>(a1);
            dal.Commit();

            Area a2 = new Area("Administración", master2);
            dal.Insert<Area>(a2);
            dal.Commit();

            Incident i1 = new Incident("Informática", "Se necesita cable para poder conectar los ordenadores", new DateTime(2025, 06, 17, 09, 05, 21), empleado1);
            dal.Insert<Incident>(i1);
            dal.Commit();

            Incident i2 = new Incident("Administración", "Mala gestión del presupuesto de los proyectos", new DateTime(2025, 02, 28, 17, 54, 44), empleado1);
            dal.Insert<Incident>(i2);
            dal.Commit();
            //conexion areas con incidentes
            i1.Area = a1;
            i2.Area = a2;

            //conexion incidentes con reporters
            i1.Reporter = empleado1;
            i2.Reporter = empleado1;

            //conexion areas con master
            a1.Master = master2;
            a2.Master = tfmotu;

            WorkOrder o1 = new WorkOrder(new DateTime(2025, 06, 24, 13, 34, 54), i1);
            dal.Insert<WorkOrder>(o1);
            dal.Commit();

            Part p1 = new Part("AJI2", 100, "Cable de cobre con revestimiento de plástico", 10, "metros", 5);
            dal.Insert<Part>(p1);
            dal.Commit();

            Part p2 = new Part("B7JM", 2000, "Líquido anticongelante", 200, "litros", 7);
            dal.Insert<Part>(p2);
            dal.Commit();

            UsedPart up1 = new UsedPart(5, p1);
            dal.Insert<UsedPart>(up1);
            dal.Commit();
            //conexion userPart con workorder
            o1.UsedParts.Add(up1);
            //conexion incident con operator
            i1.WorkOrder = o1;
            //conexion operator con workorder
            op1.WorkOrders.Add(o1);
            //conexion UsedPart con Part
            up1.Part = p1;
            dal.Commit();
        }

        // Copiar a partir de aquí
        private void PrintSampleDB(IDAL dal)
        {
            Console.WriteLine("\n\nMOSTRANDO LOS DATOS DE LA BD");
            Console.WriteLine("============================\n");

            Console.WriteLine("\nPersonas creadas:");
            foreach (Employee p in dal.GetAll<Employee>())
                Console.WriteLine("   FullName: " + p.FullName + " Id: " + p.Id + " Password: " + p.Password);

            // Show the rest of the database
            Console.WriteLine("\nPiezas creadas:");
            foreach (Part p in dal.GetAll<Part>())
                Console.WriteLine("   Code: " + p.Code + " Description: " + p.Description + " CurrentQuantity: " + p.CurrentQuantity);

            Console.WriteLine("\nÁreas, Indicencias, Órdenes de trabajo y piezas pedidas creadas:");
            foreach (Area a in dal.GetAll<Area>())
            {
                Console.WriteLine("   Name: " + a.Name);
                foreach (Incident i in a.Incidents)
                {
                    Console.WriteLine("      Incident Id: " + i.Id + " ReportDate: " + i.ReportDate + " Description: " + i.Description);
                    WorkOrder o = i.WorkOrder;
                    if (o != null)
                    {
                        Console.WriteLine("          WorkOrder Id: " + o.Id + " StartDate: " + o.StartDate);
                        foreach (UsedPart up in o.UsedParts)
                        {
                            Console.WriteLine("             Part Description: " + up.Part.Description + " Quantity: " + up.Quantity);
                        }
                    }

                }
            }


        }

    }

}
