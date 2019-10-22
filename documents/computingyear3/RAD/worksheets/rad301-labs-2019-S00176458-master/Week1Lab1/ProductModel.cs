using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Lab1
{
    public class ProductModel
    {
        public List<Product> Products = new List<Product>()
        {
            new Product{ProductID = 1, Description = "9inch nails", QTY = 200, UnitPrice= 0.10f, CategoryID=1},
            new Product{ProductID = 2, Description = "9inch bolts", QTY = 120, UnitPrice= 0.20f, CategoryID=1},
            new Product{ProductID = 3, Description = "Chimney Hoover", QTY = 10, UnitPrice= 100.50f, CategoryID=2},
            new Product{ProductID = 4, Description = "Washing Machine", QTY = 7, UnitPrice= 399.99f, CategoryID=2}
        };

        public List<Supplier> Suppliers = new List<Supplier>()
        {
            new Supplier{SupplierID = 1, SupplierName = "Supplier 1", AddressLine1 = "Addr 11", AddressLine2 = "Addr 21"},
            new Supplier{SupplierID = 1, SupplierName = "Supplier 2", AddressLine1 = "Addr 11", AddressLine2 = "Addr 21"}
        };

        public List<Category> CategoryList = new List<Category>()
        {
            new Category{CategoryID = 1, Description = "Hardware"},
            new Category{CategoryID = 2, Description = "Electrical Appliances"}
        };

        public List<SupplierProduct> SuppliersProducts = new List<SupplierProduct>()
        {
            new SupplierProduct{SupplierID = 1, ProductID = 1, DateFirstSupplied = new DateTime(2012,12,12)},
            new SupplierProduct{SupplierID = 1, ProductID = 2, DateFirstSupplied = new DateTime(2013,01,06)},
            new SupplierProduct{SupplierID = 2, ProductID = 3, DateFirstSupplied = new DateTime(2017,09,09)},
            new SupplierProduct{SupplierID = 2, ProductID = 4, DateFirstSupplied = new DateTime(2017,09,10)}
        };
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int QTY { get; set; }
        public float UnitPrice { get; set; }
        public int CategoryID { get; set; }


        public override string ToString()
        {
            return String.Concat(new string[]
            { " ProductID:", ProductID.ToString(),
                   " Description ",Description,
                   " Quantity: ", QTY.ToString(),
                   " Unit Price: ", UnitPrice.ToString(),
                   " CategoryID: ", CategoryID.ToString()});
        }
    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public override string ToString()
        {
            return string.Concat(new string[] {
                "SupplierID: ", SupplierID.ToString(),
                "Supplier Name: ", SupplierName,
                "Address Line 1: ", AddressLine1,
                "Address Line 2: ", AddressLine2 });
        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Concat(new string[] {
                "CategoryID: ", CategoryID.ToString(),
                "Description: ", Description });
        }
    }

    public class SupplierProduct
    {
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public DateTime DateFirstSupplied { get; set; }

        public override string ToString()
        {
            return string.Concat(new string[] {
                "SupplierID: ",SupplierID.ToString(),
                "ProductID: ", ProductID.ToString(),
                "Date First Supplied: ", DateFirstSupplied.ToString() });
        }
    }
}
