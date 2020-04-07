using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3CarloVitali
{
    public class Person
    {
        protected string Name;
        protected string Lastname;
        protected string Rut;
        protected string Nacionalidad;
        protected string FechaNacimiento;

    }
    public class Clients: Person
    {
        public Random rnd = new Random();
        public int Saldo_Disponible;

        //Constructores
        public Clients(string rut, string name, string lastname, string nacionalidad, string fecha_nacimiento)
        {
            Rut = rut;
            Name = name;
            Lastname = lastname;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fecha_nacimiento;
            this.Saldo_Disponible = rnd.Next(0, 500000);
        }

    }

    public class Workers: Person
    {
        //Atributos
        protected string Job;
        protected int Salary;
        protected int WorkHours = 40;
        //ojala bajaran las horas maximas a 40 jajaja

        //Constructores

        public Workers(string rut, string name, string lastname, string nacionalidad, string fecha_nacimiento, string job)
        {
            Rut = rut;
            Name = name;
            Lastname = lastname;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fecha_nacimiento;
            Job = job;
            
        }

        //métodos que permitan cambiar su puesto de trabajo, sueldo y horario de trabajo según corresponda.

        public void ChangeJobs(Workers Worker, string job)
        {
            Worker.Job = job;
            if (job == "Cleaner")
            {
                Worker.Salary = 318000;
            }

            else if (job == "Cashier")
            {
                Worker.Salary = 600000;
            }

            else if(job == "Boss")
            {
                Worker.Salary = 3000000;
            }

            else if (job == "Supervisor")
            {
                Worker.Salary = 1500000;
            }
            Console.WriteLine("El puesto ha sido cambiado con exito a " + job + "con un nuevo sueldo de " + Worker.Salary);
        }

    }
    public class Product
    {
        private string ProductName;
        private string Brand;
        private int Price;
        private int Stock;

        public Product()
        {

        }

       
    }

    public class Registro
    {


    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
            //Console.WriteLine(date1.ToString());
        }
    }
}
