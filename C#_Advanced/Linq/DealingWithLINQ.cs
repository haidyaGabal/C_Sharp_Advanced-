
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace C__Advanced.Linq
{
    public class DealingWithLINQ
    {
        #region Load Data

        public List<Product> LoadData()
        {

            string json = File.ReadAllText("products.json");

            //for PropertyNameCaseInsensitive "C"=>"c"
            //var options = new JsonSerializerOptions
            //{
            //    PropertyNameCaseInsensitive = true
            //};

            List<Product> products =
                JsonSerializer.Deserialize<List<Product>>(json)
                ?? new List<Product>();
            return products;
        }

        #endregion

        #region First Element Example

        public void FirstExample()
        {
            List<Product> products = LoadData();
            Console.WriteLine("=== First Product ===");

            // Without LINQ
            var firstProduct = products[0];
            Console.WriteLine($"Without LINQ: {firstProduct.name}");

            // With LINQ First() if not get error =>solve :FirstOrDefault()
            var firstLinq = products.First();
            Console.WriteLine($"With LINQ: {firstLinq.name}");

            //return first item but it should unique and exisit if not give me error
           // var single = products.Single();
            //Console.WriteLine($"With LINQ: {single.name}");
        }

        #endregion

        #region Last Element Example

        public void LastExample()
        {
            List<Product> products = LoadData();
            Console.WriteLine("=== Last Product ===");

            // Without LINQ
            var LastProduct = products[99];
            Console.WriteLine($"Without LINQ: {LastProduct.name}");

            // With LINQ Last() if not get error =>solve :LastOrDefault()
            var lastLinq = products.Last();
            Console.WriteLine($"With LINQ: {lastLinq.name}");
        }

        #endregion

        #region Where Condition Examples

        public void WhereCondition()
        {
            List<Product> products = LoadData();
            Console.WriteLine("=== where condition Product ===");

            // give me IEnumerable 

            var cond = products.Where(x => x.price > 100);

            foreach (var item in cond)
            {
                Console.WriteLine($"Name: {item.name}, Price: {item.price}");
            }
            //or this with tolist()

            //var cond2 = products.Where(x => x.price > 100).ToList();
            //Console.WriteLine("With LINQ:");
            //cond2.ForEach(x => Console.WriteLine($"Name: {x.name}, Price: {x.price}"));
            // 2. Price less than 100
            var cond2 = products.Where(x => x.price < 100);

            // 3. Price equal to 100
            var cond3 = products.Where(x => x.price == 100);

            // 4. Price greater than or equal to 100
            var cond4 = products.Where(x => x.price >= 100);

            // 5. Price between 100 and 500
            var cond5 = products.Where(x => x.price >= 100 && x.price <= 500);

            // 6. Price greater than 100 OR name is Laptop
            var cond6 = products.Where(x => x.price > 100 || x.name == "Laptop");

            // 7. Product name contains "Phone"
            var cond7 = products.Where(x => x.name.Contains("Phone"));

            // 8. Product name starts with "S"
            var cond8 = products.Where(x => x.name.StartsWith("S"));

            // 9. Product name ends with "e"
            var cond9 = products.Where(x => x.name.EndsWith("e"));

            // 10. Price is not equal to 100
            var cond10 = products.Where(x => x.price != 100);
    

    }
        #endregion
    }
}

