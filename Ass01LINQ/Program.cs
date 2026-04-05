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
            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
        }

    }
}
