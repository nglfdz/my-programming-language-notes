﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_types
{
    /*
     * Anonymous type
     * 
     * Anonymous types are class types that
     *      derive directly from object, and
     *      that cannot be cast to any type except object. 

        Anonymous types provide
            a convenient way to
            encapsulate a set of read-only properties
                into a single object
                without having to explicitly define a type first.
                
        The type name is generated by the compiler and is not available at the source code level.
        The type of each property is inferred by the compiler.

        You create anonymous types by using the new operator together with an object initializer.

        Anonymous types typically are used in
            the select clause of a query expression
            to return a subset of the properties
            from each object in the source sequence.
     */

    class Program
    {
        static void Main(string[] args)
        {

            {
                var v = new { Amount = 101, Message = "Hello" };        // new of  an anonymous type
                // compiler gives the anonymous type members
                //      the same name as
                //      the property being used to initialize them

                // Rest the mouse pointer over v.Amount and v.Message
                //      in the following statement to verify that
                //      their inferred types are int and string.  
                Console.WriteLine(v.Amount);
                Console.WriteLine(v.Message);
            }

            {
                var anonArray = new[] {
                    new { name = "apple", diam = 4 },   // new of  an anonymous type
                    new { name = "grape", diam = 1 }    // new of  an anonymous type
                };

                foreach (var v in anonArray)
                {
                    Console.WriteLine($"{v.name}  {v.diam}");
                }
            }

            {
                var products = new List<Product>()
                {
                    new Product("red", 1, "ok"),
                    new Product("red", 1, "ok"),
                    new Product("red", 1, "ok"),
                };
                var productQuery =
                    from prod in products
                    select new { prod.Color, prod.Price };      // new of  an anonymous type

                foreach (var v in productQuery)
                {
                    Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
                }
            }

        }
    }

    class Product
    {
        private string color = string.Empty;
        private int price = 0;
        private string otherAttributes = string.Empty;

        public Product(string color, int price, string otherAttributes)
        {
            Color = color;
            Price = price;
            OtherAttributes = otherAttributes;
        }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }
        public string OtherAttributes { get => otherAttributes; set => otherAttributes = value; }
    }



}