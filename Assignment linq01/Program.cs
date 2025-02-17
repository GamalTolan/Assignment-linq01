using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Assignment_linq01.ListGenerator;
using static Assignment_linq01.Customer;



namespace Assignment_linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01(Restriction Operators)

            ////01

            //var result = ProductList.Where(product => product.UnitsInStock == 0);
            //foreach (var unit in result) 
            //    Console.WriteLine(unit);

            ////02

            //var result = ProductList.Where(product => product.UnitsInStock != 0)
            //             .Select((product, index) => $"{index} : {product}");
            //foreach (var products in result) 
            //    Console.WriteLine(products);


            ////03

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //.Select((name, index) => new { Name = name, Value = index })
            //.Where(x => x.Name.Length < x.Value)
            //.Select(x => x.Value);

            //foreach ( var x in result ) 
            //    Console.WriteLine(x);


            #endregion

            #region part02(Ordering Operators)

            ////01

            //var result = from products in ProductList
            //             orderby products.ProductName
            //             select products;

            //foreach (var products in result)
            //{
            //    Console.WriteLine(products);

            //}

            ///02

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}

            ////03

            //var result = from products in ProductList
            //            orderby products.UnitsInStock descending
            //            select products;

            //foreach (var products in result)
            //{
            //    Console.WriteLine(products);

            //}

            ///04

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //.Select((name, index) => new { Name = name, Value = index })
            //.Where(x => x.Name.Length < x.Value)
            //.Select(x => x.Value);

            //foreach (var x in result)
            //    Console.WriteLine(x);

            //var result = Arr
            //    .OrderBy(Name => Name, StringComparer.OrdinalIgnoreCase);
            //foreach ( var item in result ) 
            //    Console.WriteLine(item);


            ////05

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(word => word.Length);
            //foreach ( var item in result ) 
            //    Console.WriteLine(item);


            //var result = Arr
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}

            ////06

            //var result =ProductList.OrderByDescending(product => product.Category)
            //    .OrderByDescending(product => product.UnitPrice);

            //foreach (var item in result) 
            //    Console.WriteLine(item);


            ////07

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderByDescending(word => word.Length);
            //foreach (var item in result)
            //    Console.WriteLine(item);


            //var result = Arr
            //     .OrderByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in Arr)
            //{
            //    Console.WriteLine(word);
            //}

            ////08

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr
            //    .Where(word => word[1] == 'i');
            //foreach (var item in result) 
            //    Console.WriteLine(item);

            #endregion

            #region part03(Transformation Operators)

            ////01

            //var result=ProductList.Select(product=>product.ProductName).ToList();

            //foreach (var product in result)
            //    Console.WriteLine(product);

            ////02

            // String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(word => new
            //             {
            //                 Uppercase = word.ToUpper(),
            //                 Lowercase = word.ToLower()
            //             });

            // foreach (var word in result) 
            //     Console.WriteLine(word);


            ////03

            //var result = ProductList.Select(product => new { Name=product.ProductName , Price=product.UnitPrice });

            //foreach (var item in result) 
            //    Console.WriteLine(item);

            ////04

            //    int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //    var results = arr.Select((value, index) => new {Value=value, Index=index});

            //    foreach (var item in results)
            //    {

            //        bool inPlace = item.Value == item.Index;
            //        if (inPlace)
            //        {
            //            Console.WriteLine($"{item.Value}: True");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{item.Value}: False");
            //        }
            //    }
            //}

            ////05

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from A in numbersA
            //             from B in numbersB
            //             where A < B
            //             select new { A, B };
            //foreach (var number in result)
            //{
            //    Console.WriteLine($"{number.A} is less than {number.B}");
            //}

            ////06

            //var result = CustomerList.SelectMany(C => C.Orders)
            //    .Where(C => C.Total < 500);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //07

            var result = CustomerList.SelectMany(C => C.Orders)
                .Where(C => C.OrderDate.Year<1998);

            foreach (var C in result)
                Console.WriteLine(C);


            #endregion

        }
    }
}