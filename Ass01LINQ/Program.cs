using Session01LinqG01.Models;
using static Session01LinqG01.DataSources.Source;
namespace Ass01LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            #region Q01
            //// Get all products from the "Seafood" category. Print each product's name and price.
            //var result = ProductList.Where(c => c.Category == "Seafood")
            //    .Select(s=>new {name=s.ProductName,price=s.UnitPrice});
            #endregion
            #region Q02
            //var result = ProductList.Select(s => new { name = s.ProductName });
            #endregion
            #region Q03
            // Sort all products by UnitPrice (ascending). Print each product's name and price. 
            //var result = ProductList.OrderBy(o => o.UnitPrice)
            //    .Select(s => new { name = s.ProductName, price = s.UnitPrice});
            #endregion
            #region Q04
            //Get all products where UnitPrice is between 10 and 30
            //var result = ProductList.Where(c => c.UnitPrice >= 10 && c.UnitPrice <= 30);
            #endregion
            #region Q05
            // Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category
            //var result = ProductList.Where(c => c.UnitsInStock > 0 && c.Category == "Condiments");
            #endregion
            #region Q06
            // Create a new anonymous type with three properties
            //var result = ProductList.Select(s => new
            //{
            //    Name = s.ProductName,
            //    Price = s.UnitPrice,
            //    StockStatus = s.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            #endregion
            #region Q07
            // Print each product's name along with its position (1-based) in the list.
            //var result = ProductList.Select((c, i) => $"{i + 1}. {c.ProductName}");
            #endregion
            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
        }

    }
}
