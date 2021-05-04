using System;

namespace UpdatedcCudApi
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           using(ProductContext context = new ProductContext())
            {
                //Product p = new Product
                //{
                //    Id="1",
                //    Title="Apple",
                //    Price=90,
                //    InStock=true

                //};
                //context.products.Add(p);
                //context.SaveChanges();
                //Console.WriteLine("Product Added");
                Product p = new Product
                {
                    Id = "2",
                    Title = "banana",
                    Price = 60,
                    InStock = true

                };
                context.products.Add(p);
                var get = context.products.Find("2");
                get.Price = 300;
                var get1 = context.products.Find("1");
                context.products.Remove(get1);
                context.SaveChanges();
                Console.WriteLine("Operation done ");
            }
        }
    }
}
