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
            // Get all products from the "Seafood" category. Print each product's name and price.
            var result = ProductList.Where(c => c.Category == "Seafood")
                .Select(s=>new {name=s.ProductName,price=s.UnitPrice});
            #endregion
            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }
        }

    }
}
