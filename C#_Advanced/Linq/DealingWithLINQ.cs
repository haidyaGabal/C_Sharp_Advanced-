
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

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

        public void Sorting()
        {
            List<Product> products = LoadData();

            Console.WriteLine("=== Sorting Products ===");

            var cond = products.Where(x => x.price > 100).OrderBy(x => x.price).ToList();

            foreach (var item in cond)
            {
                Console.WriteLine(
                    $"Name: {item.name}, Price: {item.price}, Brand: {item.brand}");
            }

            Console.WriteLine("=== Multiple Sorting ===");

            var cond2 = products.Where(x => x.price > 100).OrderBy(x => x.price)
                .ThenBy(x => x.brand);

            foreach (var item in cond2)
            {
                Console.WriteLine(
                    $"Name: {item.name}, Price: {item.price}, Brand: {item.brand}");
            }
        }


        public void Projection()
        {
            List<Product> products = LoadData();

            Console.WriteLine("=== Projection Products ===");

            // 1. Select one property
            var cond1 = products.Select(x => x.name);

            // 2. Select multiple properties
            var cond2 = products.Select(x => new
            {
                x.name,
                x.brand,
                x.price
            });

            // 3. Rename properties
            var cond3 = products.Select(x => new
            {
                ProductName = x.name,
                Company = x.brand,
                ProductPrice = x.price
            });

            // 4. Calculate discount
            var cond4 = products.Select(x => new
            {
                x.name,
                OriginalPrice = x.price,
                FinalPrice = x.price * 0.90m
            });

            // 5. Conditional projection
            var cond5 = products.Select(x => new
            {
                x.name,
                Status = x.price > 500 ? "Expensive" : "Cheap"
            });

            // 6. Where + Select
            var cond6 = products
                .Where(x => x.price > 500)
                .Select(x => new
                {
                    x.name,
                    x.price
                });

            // 7. Distinct brands
            var cond7 = products
                .Select(x => x.brand)
                .Distinct()
                .ToList();

            // 8. Select with index
            var cond8 = products.Select((x, index) => new
            {
                Number = index + 1,
                x.name
            });
            //9. 3condition 
            var cond = products.Select(x => new
            {
                ProductName = x.name,

                PriceLevel = x.price > 1000 ? "High" : x.price > 500
                ? "Medium"
                : "Low"
            });

            // Display example
            foreach (var item in cond8)
            {
                Console.WriteLine(
                    $"{item.Number} | name: {item.name}");
            }
        }


        public void Aggregation()
        {
            List<Product> products = LoadData();

            Console.WriteLine("=== LINQ Aggregation ===");

            // 1. Count all products
            var count = products.Count();

            // 2. Count products with price > 500
            var countExpensive = products.Count(x => x.price > 500);

            // 3. Sum all prices
            var total = products.Sum(x => x.price);

            // 4. Average price
            var average = products.Average(x => x.price);

            // 5. Maximum price
            var max = products.Max(x => x.price);

            // 6. Minimum price
            var min = products.Min(x => x.price);

            // 7. Most expensive product => name of max product
            var expensiveProduct = products.MaxBy(x => x.price);

            // 8. Cheapest product
            var cheapProduct = products.MinBy(x => x.price);

            // 9. Aggregate
            var aggregateTotal = products.Aggregate(
                0m,
                (total, item) => total + item.price
            );
            // grouping 

            var countSumOrdreOverCat = products.GroupBy(a => a.category).
                Select(a => new
                {
                    Category=a.Key,
                    ordersCount=a.Count(),
                    allPrice=a.Sum(a => a.price),

                }).ToList();

            

            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Expensive Products: {countExpensive}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Most Expensive: {expensiveProduct?.name}");
            Console.WriteLine($"Cheapest: {cheapProduct?.name}");
            Console.WriteLine($"Aggregate Total: {aggregateTotal}");
        }


    }
}

