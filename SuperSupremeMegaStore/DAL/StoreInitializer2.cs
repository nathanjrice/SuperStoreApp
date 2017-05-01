using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SuperSupremeMegaStore.Models;

namespace SuperSupremeMegaStore.DAL
{
    public class StoreInitializer2 : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customer = new List<Customer>
            {
            new Customer { FirstName = "James", LastName = "Proton", LastPurchase = DateTime.Parse("2004-09-01") },
            new Customer { FirstName = "Max", LastName = "Hyperdrive", LastPurchase = DateTime.Parse("2005-09-01") },
            new Customer { FirstName = "Jennifer", LastName = "Comet", LastPurchase = DateTime.Parse("2006-09-01") },
            new Customer { FirstName = "Orion", LastName = "Belt", LastPurchase = DateTime.Parse("2007-09-01") },
            new Customer { FirstName = "Xmus Jaxon", LastName = "Flaxon-Waxon", LastPurchase = DateTime.Parse("2008-09-01") },
            new Customer { FirstName = "Bob", LastName = "Smith", LastPurchase = DateTime.Parse("2009-09-01") },
            };

            customer.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
              new Product {ProductID = 1, Name="W-Wing", UPC=42342342321, Price=3.5m, SectionID="OneSeater", Inventory=50},
              new Product {ProductID = 2, Name="Star Crusher", UPC=43423423423, Price=220m, SectionID="BattleStation", Inventory=2},
              new Product {ProductID = 3, Name="Star-O-Death", UPC=01423423423, Price=999m, SectionID="BattleStation", Inventory=1},
              new Product {ProductID = 4, Name="Giant Mechnical Camel", UPC=17423423423, Price=500.5m, SectionID="FourDoor", Inventory=8},
              new Product {ProductID = 5, Name="Century Eagle", UPC=92423423423, Price=.8m, SectionID="FourDoor", Inventory=1},
              new Product {ProductID = 6, Name="Bowtie Fighter", UPC=33423423423, Price=4.1m, SectionID="OneSeater", Inventory=50},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var purchases = new List<Purchase>
            {
            new Purchase { CustomerID=1, ProductID=1, Quantity=1 },
            new Purchase { CustomerID=2, ProductID=2, Quantity=1 },
            new Purchase { CustomerID=3, ProductID=3, Quantity=1 },
            new Purchase { CustomerID=3, ProductID=4, Quantity=4 },
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=4, ProductID=4, Quantity=1 },
            new Purchase { CustomerID=5, ProductID=5, Quantity=1 },
            new Purchase { CustomerID=6, ProductID=6, Quantity=1 },

            };
            purchases.ForEach(s => context.Purchases.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { EmployeeID=1, FirstName = "Nathan", LastName = "Cloudhopper", HireDate = DateTime.Parse("2005-10-10") },
                new Employee { EmployeeID=2, FirstName = "Emperor", LastName = "Porcupine", HireDate = DateTime.Parse("2005-10-10") },
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { DepartmentID = 1, Name = "Single Man Fighter", TotalSales = 10000 },
                new Department { DepartmentID = 2, Name = "Space Stations", TotalSales = 42 },
                new Department { DepartmentID = 3, Name = "Multi-Man Fighters", TotalSales = 10000 },
                new Department { DepartmentID = 4, Name = "Additional Parts", TotalSales = 5000 }

            };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var assignments = new List<Assignment>
            {
                new Assignment { EmployeeID = 1, DepartmentID = 1 },
                new Assignment { EmployeeID = 2, DepartmentID = 2 },

            };
            assignments.ForEach(s => context.Assignments.Add(s));
            context.SaveChanges();


        }
    }
}