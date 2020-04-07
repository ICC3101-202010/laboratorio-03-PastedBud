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
        public int Money;

        //Constructor
        public Clients(string rut, string name, string lastname, string nacionalidad, string fecha_nacimiento)
        {
            Rut = rut;
            Name = name;
            Lastname = lastname;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fecha_nacimiento;
            this.Money= rnd.Next(0, 500000);
        }


        //Metodo para comprobar si un cliente puede comprar o no un producto
        public void ClientPurchase(Clients clients, int QuantityItems, Product product)
        {
            if (QuantityItems <= product.Stock)
            {
                if (Money >= product.Price * QuantityItems)
                {
                    product.Purchase(product, QuantityItems);
                    this.Money = this.Money - product.Price * QuantityItems;
                    Console.WriteLine("Comprado");
                }
                else
                {
                    Console.WriteLine("No se pudo comprar el producto por falta de dinero");
                }
            }
            else
            {
                Console.WriteLine("No se pudo comprar el producto por falta de Stock");
            }
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
        //clase Producto, especificando su nombre, precio, marca y stock disponible,
        private string ProductName;
        private string Brand;
        public int Price;
        public int Stock;

        //Constructor
        public Product(string product_name, string brand, int price, int stock)
        {
            ProductName = product_name;
            Brand = brand;
            Price = price;
            Stock = stock;
        }

        //Metodos

        //Metodo para bajar el stock cada vez que se compra
        public void Purchase(Product product, int QuantityItems)
        {
            product.Stock = product.Stock - QuantityItems;
        }

        //Metodo para retornar cuanto stock queda de cada producto
        public string Disponibilidad(Product product)
        {
            return "Quedan " + product.Stock + " Unidades de " + ProductName + Brand;
        }
    }

    public class Registro
    {
        //Atributos a utilizar en el registro
        //la fecha y hora, la lista de productos, el cliente que la realizó y el cajero que lo atendió

        private DateTime DateTime;
        private string ProductName;
        private string ProductBrand;
        private int ProductQuantity;
        private int ProductPrice;
        private string CustomerName;
        private string CustomerLastname;
        private string CashierName;
        private string CashierLastname;


        //Constructor
        public Registro(DateTime datetime, string product_name, string product_brand, int product_quantity,int product_price, string customer_name, string customer_lastname, string cashier_name, string cashier_lastname)
        {
            DateTime = datetime;
            ProductName = product_name;
            ProductBrand = product_brand;
            ProductQuantity = product_quantity;
            ProductPrice = product_price;
            CustomerName = customer_name;
            CustomerLastname = customer_lastname;
            CashierName = cashier_name;
            CashierLastname = cashier_lastname;
        }

        //Metodo Para Acceder al Registro
        public string Info(Registro registro)
        {
            return "\n|El Cliente: " + registro.CustomerName + " " + registro.CustomerLastname +  "\n|Compro: " + registro.ProductQuantity +" "+ registro.ProductName + " " + registro.ProductBrand + "a " + registro.ProductPrice +"\n|Nombre Vendedor: " + registro.CashierName + " " + registro.CashierLastname + "\n|Hora de compra: " + registro.DateTime;
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
