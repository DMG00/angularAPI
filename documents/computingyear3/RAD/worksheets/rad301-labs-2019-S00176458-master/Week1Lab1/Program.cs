using ActivityTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity.Track("Designing Classes Model");
            Activity.Track("Starting Queries");

            ProductModel pm = new ProductModel();

            //List Categories
            foreach (var item in pm.CategoryList)
            {
                Console.WriteLine("Category: {0}", item.ToString());
            }

            //List products
            foreach (var item in pm.Products)
            {
                Console.WriteLine("Product: {0}", item.ToString());
            }

            //Quantity is less than 100
            var productQuantity = (from p in pm.Products
                                   where p.QTY <= 100
                                   select p);

            foreach (var item in productQuantity)
            {
                Console.WriteLine("Products with quantity less than 100: {0}", item.ToString());
            }

            var ProductsWithCost = pm.Products.Select(p => new { p.ProductID, p.Description, p.QTY, p.UnitPrice, TotalCost = p.UnitPrice * p.QTY });
            Console.WriteLine();
            foreach (var item in ProductsWithCost)
            {
                Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|{3,5:c}|{4,5:c}|", item.ProductID, item.Description, item.QTY, item.UnitPrice, item.TotalCost));
            }
            Console.WriteLine();



            //Products from the hardware category
            var HardwareProducts = (from p in pm.Products
                                    join c in pm.CategoryList
                                    on p.CategoryID equals c.CategoryID
                                    where c.Description == "Hardware"
                                    select p);

            foreach (var item in HardwareProducts)
            {
                if (item.CategoryID == 1)
                {
                    Console.WriteLine("Products in hardware: {0}", item.ToString());
                };
            }

            //list all suppliers and their parts ordered by supplier name
            var SupplierProductsGrouped = (from s in pm.Suppliers
                                           join sp in pm.SuppliersProducts
                                           on s.SupplierID equals sp.SupplierID
                                           join p in pm.Products
                                           on sp.ProductID equals p.ProductID
                                           select new
                                           {
                                               s.SupplierName,
                                               Products = p
                                           }
                         ).OrderBy(o => o.SupplierName)
                         .GroupBy(g => g.SupplierName);

            // Group has a Key field and a set of elements stored under that key field
            foreach (var group in SupplierProductsGrouped)
            {
                Console.WriteLine($"Supplier Name: {group.Key}");

                for (int i = 0; i < group.Count(); i++)
                {
                    Console.WriteLine("Product {0}", group.ElementAt(i).Products.ToString());
                }
            }


            Console.ReadKey();

            Activity.Track("Finished Queries");
        }
    }
}
